//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Reflection {
    
    
    #region Component Designer generated code 
    public unsafe partial class MemberInfo_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.Reflection.@__MemberInfo.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute()]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.Reflection.MemberInfo))]
    internal unsafe partial class @__MemberInfo : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        protected @__MemberInfo(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::System.Reflection.@__MemberInfo.staticClass = staticClass;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__MemberInfo);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetCustomAttributes", "GetCustomAttributes0", "(Z)[Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetCustomAttributes", "GetCustomAttributes1", "(Lsystem/Type;Z)[Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "IsDefined", "IsDefined2", "(Lsystem/Type;Z)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getMemberType", "MemberType3", "()Lsystem/Enum;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getName", "Name4", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getDeclaringType", "DeclaringType5", "()Lsystem/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getReflectedType", "ReflectedType6", "()Lsystem/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getMetadataToken", "MetadataToken7", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getModule", "Module8", "()Lsystem/runtime/serialization/ISerializable;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetTypeInfo", "GetTypeInfo9", "(IILsystem/ValueType;)V"));
            return methods;
        }
        
        private static global::java.lang.Object.JavaPtr* GetCustomAttributes0(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, bool inherit) {
            // (Z)[Lsystem/Object;
            // (Z)[LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Reflection.MemberInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MemberInfo>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, ((global::System.Reflection.ICustomAttributeProvider)(real)).GetCustomAttributes(inherit));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* GetCustomAttributes1(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* attributeType, bool inherit) {
            // (Lsystem/Type;Z)[Lsystem/Object;
            // (LSystem/Type;Z)[LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Reflection.MemberInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MemberInfo>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, ((global::System.Reflection.ICustomAttributeProvider)(real)).GetCustomAttributes(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Type>(__env, attributeType), inherit));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static bool IsDefined2(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* attributeType, bool inherit) {
            // (Lsystem/Type;Z)Z
            // (LSystem/Type;Z)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Reflection.MemberInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MemberInfo>(__env, @__obj);
            return ((global::System.Reflection.ICustomAttributeProvider)(real)).IsDefined(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Type>(__env, attributeType), inherit);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static global::java.lang.Object.JavaPtr* MemberType3(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Lsystem/Enum;
            // ()LSystem/Reflection/MemberTypes;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Reflection.MemberInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MemberInfo>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.MemberType);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* Name4(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Ljava/lang/String;
            // ()LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Reflection.MemberInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MemberInfo>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.ConvertString(@__env, real.Name);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* DeclaringType5(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Lsystem/Type;
            // ()LSystem/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Reflection.MemberInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MemberInfo>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.DeclaringType);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* ReflectedType6(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Lsystem/Type;
            // ()LSystem/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Reflection.MemberInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MemberInfo>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.ReflectedType);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static int MetadataToken7(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Reflection.MemberInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MemberInfo>(__env, @__obj);
            return real.MetadataToken;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static global::java.lang.Object.JavaPtr* Module8(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Lsystem/runtime/serialization/ISerializable;
            // ()LSystem/Reflection/Module;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Reflection.MemberInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MemberInfo>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.Module);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static void GetTypeInfo9(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, uint iTInfo, uint lcid, global::System.IntPtr ppTInfo) {
            // (IILsystem/ValueType;)V
            // (LSystem/UInt32;LSystem/UInt32;LSystem/IntPtr;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Reflection.MemberInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.MemberInfo>(__env, @__obj);
            ((global::System.Runtime.InteropServices._MemberInfo)(real)).GetTypeInfo(iTInfo, lcid, ppTInfo);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::System.Reflection.@__MemberInfo(env);
            }
        }
    }
    #endregion
}
