//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public unsafe partial class NoClassDefFoundError : global::java.lang.LinkageError {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor0;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor1;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public NoClassDefFoundError() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.GetEnv();
            env.NewObject(global::java.lang.NoClassDefFoundError.staticClass, global::java.lang.NoClassDefFoundError.@__ctor0, this);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public NoClassDefFoundError(global::java.lang.String par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.GetEnv();
            env.NewObject(global::java.lang.NoClassDefFoundError.staticClass, global::java.lang.NoClassDefFoundError.@__ctor1, this, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        protected NoClassDefFoundError(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.NoClassDefFoundError.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::java.lang.NoClassDefFoundError.staticClass = staticClass;
            global::java.lang.NoClassDefFoundError.@__ctor0 = env.GetMethodID(global::java.lang.NoClassDefFoundError.staticClass, "<init>", "()V");
            global::java.lang.NoClassDefFoundError.@__ctor1 = env.GetMethodID(global::java.lang.NoClassDefFoundError.staticClass, "<init>", "(Ljava/lang/String;)V");
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::java.lang.NoClassDefFoundError(env);
            }
        }
    }
    #endregion
}
