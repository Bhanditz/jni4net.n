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
    public partial interface Iterable {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Iterator;")]
        global::java.util.Iterator iterator();
    }
    #endregion
    
    #region Component Designer generated code 
    public unsafe partial class Iterable_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.@__Iterable.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute()]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::java.lang.Iterable))]
    internal sealed unsafe partial class @__Iterable : global::java.lang.Object, global::java.lang.Iterable {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _iterator0;
        
        protected @__Iterable(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::java.lang.@__Iterable.staticClass = staticClass;
            global::java.lang.@__Iterable._iterator0 = env.GetMethodID(global::java.lang.@__Iterable.staticClass, "iterator", "()Ljava/util/Iterator;");
        }
        
        public global::java.util.Iterator iterator() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.util.Iterator>(env.CallObjectMethod(this, global::java.lang.@__Iterable._iterator0));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__Iterable);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "iterator", "iterator0", "()Ljava/util/Iterator;"));
            return methods;
        }
        
        private static global::java.lang.Object.JavaPtr* iterator0(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Ljava/util/Iterator;
            // ()Ljava/util/Iterator;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.lang.Iterable real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.lang.Iterable>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.iterator());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::java.lang.@__Iterable(env);
            }
        }
    }
    #endregion
}
