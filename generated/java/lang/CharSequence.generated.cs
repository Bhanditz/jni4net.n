//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface CharSequence {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        global::java.lang.String toString();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)C")]
        char charAt(int par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        int length();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(II)Ljava/lang/CharSequence;")]
        global::java.lang.CharSequence subSequence(int par0, int par1);
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class CharSequence_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.@__CharSequence.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::java.lang.CharSequence))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::java.lang.CharSequence))]
    internal sealed partial class @__CharSequence : global::java.lang.Object, global::java.lang.CharSequence {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _toString0;
        
        internal static global::net.sf.jni4net.jni.MethodId _charAt1;
        
        internal static global::net.sf.jni4net.jni.MethodId _length2;
        
        internal static global::net.sf.jni4net.jni.MethodId _subSequence3;
        
        protected @__CharSequence(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::java.lang.@__CharSequence.staticClass = staticClass;
            global::java.lang.@__CharSequence._toString0 = env.GetMethodID(global::java.lang.@__CharSequence.staticClass, "toString", "()Ljava/lang/String;");
            global::java.lang.@__CharSequence._charAt1 = env.GetMethodID(global::java.lang.@__CharSequence.staticClass, "charAt", "(I)C");
            global::java.lang.@__CharSequence._length2 = env.GetMethodID(global::java.lang.@__CharSequence.staticClass, "length", "()I");
            global::java.lang.@__CharSequence._subSequence3 = env.GetMethodID(global::java.lang.@__CharSequence.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
        }
        
        public global::java.lang.String toString() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallObjectMethod(this, global::java.lang.@__CharSequence._toString0));
        }
        
        public char charAt(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallCharMethod(this, global::java.lang.@__CharSequence._charAt1, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        public int length() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.lang.@__CharSequence._length2);
        }
        
        public global::java.lang.CharSequence subSequence(int par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.CharSequence>(env.CallObjectMethod(this, global::java.lang.@__CharSequence._subSequence3, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__CharSequence);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "toString", "toString0", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "charAt", "charAt1", "(I)C"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "length", "length2", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "subSequence", "subSequence3", "(II)Ljava/lang/CharSequence;"));
            return methods;
        }
        
        private static global::System.IntPtr toString0(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Ljava/lang/String;
            // ()Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::java.lang.CharSequence real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.lang.CharSequence>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.toString());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static char charAt1(global::System.IntPtr @__envi, global::System.IntPtr @__obj, int par0) {
            // (I)C
            // (I)C
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::java.lang.CharSequence real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.lang.CharSequence>(__env, @__obj);
            return real.charAt(par0);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(char);
        }
        
        private static int length2(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::java.lang.CharSequence real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.lang.CharSequence>(__env, @__obj);
            return real.length();
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static global::System.IntPtr subSequence3(global::System.IntPtr @__envi, global::System.IntPtr @__obj, int par0, int par1) {
            // (II)Ljava/lang/CharSequence;
            // (II)Ljava/lang/CharSequence;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::java.lang.CharSequence real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.lang.CharSequence>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.subSequence(par0, par1));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::java.lang.@__CharSequence(env);
            }
        }
    }
    #endregion
}
