//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.util {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public unsafe partial class Hashtable : global::java.util.Dictionary, global::java.util.Map, global::java.lang.Cloneable, global::java.io.Serializable {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _get0;
        
        internal static global::net.sf.jni4net.jni.MethodId _put1;
        
        internal static global::net.sf.jni4net.jni.MethodId _hashCode2;
        
        internal static global::net.sf.jni4net.jni.MethodId _clear3;
        
        internal static global::net.sf.jni4net.jni.MethodId _equals4;
        
        internal static global::net.sf.jni4net.jni.MethodId _isEmpty5;
        
        internal static global::net.sf.jni4net.jni.MethodId _entrySet6;
        
        internal static global::net.sf.jni4net.jni.MethodId _putAll7;
        
        internal static global::net.sf.jni4net.jni.MethodId _size8;
        
        internal static global::net.sf.jni4net.jni.MethodId _values9;
        
        internal static global::net.sf.jni4net.jni.MethodId _remove10;
        
        internal static global::net.sf.jni4net.jni.MethodId _keySet11;
        
        internal static global::net.sf.jni4net.jni.MethodId _containsKey12;
        
        internal static global::net.sf.jni4net.jni.MethodId _containsValue13;
        
        internal static global::net.sf.jni4net.jni.MethodId _contains14;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor15;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor16;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor17;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor18;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)V")]
        public Hashtable(int par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.GetEnv();
            env.NewObject(global::java.util.Hashtable.staticClass, global::java.util.Hashtable.@__ctor15, this, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public Hashtable() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.GetEnv();
            env.NewObject(global::java.util.Hashtable.staticClass, global::java.util.Hashtable.@__ctor16, this);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/Map;)V")]
        public Hashtable(global::java.util.Map par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.GetEnv();
            env.NewObject(global::java.util.Hashtable.staticClass, global::java.util.Hashtable.@__ctor17, this, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(IF)V")]
        public Hashtable(int par0, float par1) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.GetEnv();
            env.NewObject(global::java.util.Hashtable.staticClass, global::java.util.Hashtable.@__ctor18, this, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1));
        }
        
        protected Hashtable(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.util.Hashtable.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::java.util.Hashtable.staticClass = staticClass;
            global::java.util.Hashtable._get0 = env.GetMethodID(global::java.util.Hashtable.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
            global::java.util.Hashtable._put1 = env.GetMethodID(global::java.util.Hashtable.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
            global::java.util.Hashtable._hashCode2 = env.GetMethodID(global::java.util.Hashtable.staticClass, "hashCode", "()I");
            global::java.util.Hashtable._clear3 = env.GetMethodID(global::java.util.Hashtable.staticClass, "clear", "()V");
            global::java.util.Hashtable._equals4 = env.GetMethodID(global::java.util.Hashtable.staticClass, "equals", "(Ljava/lang/Object;)Z");
            global::java.util.Hashtable._isEmpty5 = env.GetMethodID(global::java.util.Hashtable.staticClass, "isEmpty", "()Z");
            global::java.util.Hashtable._entrySet6 = env.GetMethodID(global::java.util.Hashtable.staticClass, "entrySet", "()Ljava/util/Set;");
            global::java.util.Hashtable._putAll7 = env.GetMethodID(global::java.util.Hashtable.staticClass, "putAll", "(Ljava/util/Map;)V");
            global::java.util.Hashtable._size8 = env.GetMethodID(global::java.util.Hashtable.staticClass, "size", "()I");
            global::java.util.Hashtable._values9 = env.GetMethodID(global::java.util.Hashtable.staticClass, "values", "()Ljava/util/Collection;");
            global::java.util.Hashtable._remove10 = env.GetMethodID(global::java.util.Hashtable.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
            global::java.util.Hashtable._keySet11 = env.GetMethodID(global::java.util.Hashtable.staticClass, "keySet", "()Ljava/util/Set;");
            global::java.util.Hashtable._containsKey12 = env.GetMethodID(global::java.util.Hashtable.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
            global::java.util.Hashtable._containsValue13 = env.GetMethodID(global::java.util.Hashtable.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
            global::java.util.Hashtable._contains14 = env.GetMethodID(global::java.util.Hashtable.staticClass, "contains", "(Ljava/lang/Object;)Z");
            global::java.util.Hashtable.@__ctor15 = env.GetMethodID(global::java.util.Hashtable.staticClass, "<init>", "(I)V");
            global::java.util.Hashtable.@__ctor16 = env.GetMethodID(global::java.util.Hashtable.staticClass, "<init>", "()V");
            global::java.util.Hashtable.@__ctor17 = env.GetMethodID(global::java.util.Hashtable.staticClass, "<init>", "(Ljava/util/Map;)V");
            global::java.util.Hashtable.@__ctor18 = env.GetMethodID(global::java.util.Hashtable.staticClass, "<init>", "(IF)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Ljava/lang/Object;")]
        public virtual global::java.lang.Object get(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Object>(env.CallObjectMethod(this, global::java.util.Hashtable._get0, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;")]
        public virtual global::java.lang.Object put(global::java.lang.Object par0, global::java.lang.Object par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Object>(env.CallObjectMethod(this, global::java.util.Hashtable._put1, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int hashCode() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.util.Hashtable._hashCode2);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public virtual void clear() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::java.util.Hashtable._clear3);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        public virtual bool equals(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.util.Hashtable._equals4, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isEmpty() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.util.Hashtable._isEmpty5);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Set;")]
        public virtual global::java.util.Set entrySet() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.util.Set>(env.CallObjectMethod(this, global::java.util.Hashtable._entrySet6));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/Map;)V")]
        public virtual void putAll(global::java.util.Map par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::java.util.Hashtable._putAll7, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int size() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.util.Hashtable._size8);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Collection;")]
        public virtual global::java.util.Collection values() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.util.Collection>(env.CallObjectMethod(this, global::java.util.Hashtable._values9));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Ljava/lang/Object;")]
        public virtual global::java.lang.Object remove(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Object>(env.CallObjectMethod(this, global::java.util.Hashtable._remove10, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Set;")]
        public virtual global::java.util.Set keySet() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.util.Set>(env.CallObjectMethod(this, global::java.util.Hashtable._keySet11));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        public virtual bool containsKey(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.util.Hashtable._containsKey12, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        public virtual bool containsValue(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.util.Hashtable._containsValue13, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        public virtual bool contains(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.util.Hashtable._contains14, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::java.util.Hashtable(env);
            }
        }
    }
    #endregion
}
