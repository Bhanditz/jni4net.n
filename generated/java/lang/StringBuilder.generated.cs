//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class StringBuilder : global::java.lang.AbstractStringBuilder, global::java.io.Serializable, global::java.lang.CharSequence {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorStringBuilder0;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorStringBuilder1;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorStringBuilder2;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorStringBuilder3;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)V")]
        public StringBuilder(int par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder.@__ctorStringBuilder0, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public StringBuilder(global::java.lang.String par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder.@__ctorStringBuilder1, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/CharSequence;)V")]
        public StringBuilder(global::java.lang.CharSequence par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder.@__ctorStringBuilder2, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.CharSequence>(@__env, par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public StringBuilder() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.lang.StringBuilder.staticClass, global::java.lang.StringBuilder.@__ctorStringBuilder3, this);
        }
        
        protected StringBuilder(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.StringBuilder.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.StringBuilder.staticClass = @__class;
            global::java.lang.StringBuilder.@__ctorStringBuilder0 = @__env.GetMethodID(global::java.lang.StringBuilder.staticClass, "<init>", "(I)V");
            global::java.lang.StringBuilder.@__ctorStringBuilder1 = @__env.GetMethodID(global::java.lang.StringBuilder.staticClass, "<init>", "(Ljava/lang/String;)V");
            global::java.lang.StringBuilder.@__ctorStringBuilder2 = @__env.GetMethodID(global::java.lang.StringBuilder.staticClass, "<init>", "(Ljava/lang/CharSequence;)V");
            global::java.lang.StringBuilder.@__ctorStringBuilder3 = @__env.GetMethodID(global::java.lang.StringBuilder.staticClass, "<init>", "()V");
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.StringBuilder(@__env);
            }
        }
    }
    #endregion
}
