//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Reflection {
    
    
    #region Component Designer generated code 
    public unsafe partial class MethodInfo_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.Reflection.@__MethodInfo.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute()]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.Reflection.MethodInfo))]
    internal unsafe partial class @__MethodInfo : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        protected @__MethodInfo(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::System.Reflection.@__MethodInfo.staticClass = staticClass;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__MethodInfo);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getReturnType", "ReturnType0", "()Lsystem/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getReturnParameter", "ReturnParameter1", "()Lsystem/reflection/ParameterInfo;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getReturnTypeCustomAttributes", "ReturnTypeCustomAttributes2", "()Lsystem/reflection/ICustomAttributeProvider;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetBaseDefinition", "GetBaseDefinition3", "()Lsystem/reflection/MethodInfo;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetGenericMethodDefinition", "GetGenericMethodDefinition4", "()Lsystem/reflection/MethodInfo;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "MakeGenericMethod", "MakeGenericMethod5", "([Lsystem/Type;)Lsystem/reflection/MethodInfo;"));
            return methods;
        }
        
        private static global::java.lang.Object.JavaPtr* ReturnType0(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Lsystem/Type;
            // ()LSystem/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Reflection.MethodInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodInfo>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.ReturnType);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* ReturnParameter1(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Lsystem/reflection/ParameterInfo;
            // ()LSystem/Reflection/ParameterInfo;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Reflection.MethodInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodInfo>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.ReturnParameter);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* ReturnTypeCustomAttributes2(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Lsystem/reflection/ICustomAttributeProvider;
            // ()LSystem/Reflection/ICustomAttributeProvider;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Reflection.MethodInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodInfo>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.ReturnTypeCustomAttributes);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* GetBaseDefinition3(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Lsystem/reflection/MethodInfo;
            // ()LSystem/Reflection/MethodInfo;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Reflection.MethodInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodInfo>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.GetBaseDefinition());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* GetGenericMethodDefinition4(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Lsystem/reflection/MethodInfo;
            // ()LSystem/Reflection/MethodInfo;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Reflection.MethodInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodInfo>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.GetGenericMethodDefinition());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* MakeGenericMethod5(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* typeArguments) {
            // ([Lsystem/Type;)Lsystem/reflection/MethodInfo;
            // ([LSystem/Type;)LSystem/Reflection/MethodInfo;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Reflection.MethodInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MethodInfo>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.MakeGenericMethod(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Type[]>(__env, typeArguments)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::System.Reflection.@__MethodInfo(env);
            }
        }
    }
    #endregion
}
