﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using java.lang;
using net.sf.jni4net.attributes;
using net.sf.jni4net.jni;
using Exception=System.Exception;

namespace net.sf.jni4net.utils
{
    partial class Registry
    {
        private static ClrWrapperAttribute GetClrWrapperAttribute(Type type)
        {
            object[] objects = type.GetCustomAttributes(typeof (ClrWrapperAttribute), false);
            if (objects.Length == 1)
            {
                return objects[0] as ClrWrapperAttribute;
            }
            return null;
        }

        private static JavaClassAttribute GetJavaClassAttribute(Type type)
        {
            object[] objects = type.GetCustomAttributes(typeof (JavaClassAttribute), false);
            if (objects.Length == 1)
            {
                return objects[0] as JavaClassAttribute;
            }
            return null;
        }

        private static JavaProxyAttribute GetJavaProxyAttribute(Type type)
        {
            object[] objects = type.GetCustomAttributes(typeof (JavaProxyAttribute), false);
            if (objects.Length == 1)
            {
                return objects[0] as JavaProxyAttribute;
            }
            return null;
        }

        private static string GetStaticName(string package, string name, bool jvm)
        {
            package = GetPackageName(package, jvm);
            return package+ "." + name + "_";
        }

        private static string GetProxyName(string package, string name, bool jvm)
        {
            package = GetPackageName(package, jvm);
            return package + ".__" + name;
        }

        private static string GetPackageName(string package, bool jvm)
        {
            if (jvm)
            {
                package = package.ToLowerInvariant();
                if (package.StartsWith("java."))
                {
                    package = "java_." + package.Substring(5);
                }
            }
            return package;
        }


        private static IConstructionHelper GetConstructor(Type proxy)
        {
            Type cnt = proxy.GetNestedType("ContructionHelper", BindingFlags.NonPublic | BindingFlags.Public);
            if (cnt == null)
            {
                Console.WriteLine("Can't find .NET ContructioHelper: " + proxy);
                throw new JNIException("Can't find .NET ContructioHelper: " + proxy);
            }

            ConstructorInfo constructor =
                cnt.GetConstructor(BindingFlags.CreateInstance | BindingFlags.Instance | BindingFlags.Public, null,
                                   new Type[] {}, null);
            if (constructor == null)
            {
                Console.WriteLine("Can't find .NET ContructioHelper constructor: " + proxy);
                throw new JNIException("Can't find .NET ContructioHelper constructor: " + proxy);
            }
            return (IConstructionHelper) constructor.Invoke(null);
        }


        private static MethodId GetJVMConstructor(JNIEnv env, bool isInterface, Class proxy)
        {
            if (isInterface)
            {
                return env.GetMethodID(proxy, "<init>", "()V");
            }
            else
            {
                return env.GetMethodID(proxy, "<init>", "(Lnet/sf/jni4net/inj/INJEnv;I)V");
            }
        }

        private static MethodInfo GetWrapperInitializer(Type wrapperType)
        {
            MethodInfo initializer = wrapperType.GetMethod("__Init", BindingFlags.Static | BindingFlags.NonPublic, null, new[] { typeof(JNIEnv), typeof(Class) }, null);
            if (initializer == null)
            {
                throw new JNIException("Can't find CLR type init method for " + wrapperType);
            }
            return initializer;
        }

        private static MethodInfo GetProxyInitializer(Type proxyType)
        {
            MethodInfo initMethod = proxyType.GetMethod("InitJNI", BindingFlags.NonPublic | BindingFlags.Static, null,
                                                        new[] { typeof(JNIEnv), typeof(Class) }, null);
            if (initMethod == null)
            {
                Console.WriteLine("Can't find .NET InitJNI: method" + proxyType);
                throw new JNIException("Can't find .NET InitJNI method: " + proxyType);
            }
            return initMethod;
        }

        private static void RegisterNative(MethodInfo initializer, JNIEnv env, Class jvmProxy, Class jvmInterface)
        {
            List<JNINativeMethod> registrations = (List<JNINativeMethod>) initializer.Invoke(null, new object[] {env, jvmProxy});
            if (registrations.Count > 0)
            {
                if (Bridge.Debug)
                {
                    foreach (JNINativeMethod registration in registrations)
                    {
                        string n = Marshal.PtrToStringAnsi(registration.name);
                        string s = Marshal.PtrToStringAnsi(registration.signature);
                        if (env.GetMethodIDNoThrow(jvmInterface, n, s) == null)
                        {
                            try
                            {
                                env.GetStaticMethodID(jvmInterface, n, s);
                            }
                            catch (Exception ex2)
                            {
                                Console.Error.WriteLine(ex2);
                            }
                        }
                    }
                }
                //TODO JNINativeMethod.Register(registrations, jvmProxy, env);
            }
        }

        private void RegisterStaticAndMethods(RegistryRecord record, JNIEnv env)
        {
            try
            {
                //TODO record.CLRProxyInitMethod.Invoke(null, new object[] {env, record.JVMInterface});
            }
            catch (Exception ex)
            {
                throw new JNIException("Can't initialize class " + record.CLRName, ex);
            }
        }

        private void RegisterType(Type type, bool bindJVM, JNIEnv env)
        {
            RegistryRecord record = null;
            RegisterWrapper(type, ref record);
            RegisterInterfaceProxy(type, ref record);
            RegisterClassProxy(type, ref record);
            if (record != null)
            {
                if (bindJVM && !record.JVMBound)
                {
                    RegisterClass(record, env);
                    if (record.CLRProxy != null)
                    {
                        RegisterStaticAndMethods(record, env);
                    }
                    if (record.CLRWrapper != null)
                    {
                        RegisterNative(record.CLRWrapperInitMethod, env, record.JVMProxy, record.JVMInterface);
                    }
                    record.JVMBound = true;
                }
            }
        }
    }
}
