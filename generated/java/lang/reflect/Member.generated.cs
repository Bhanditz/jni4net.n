//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang.reflect {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface Member {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        int getModifiers();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        global::java.lang.String getName();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Class;")]
        global::java.lang.Class getDeclaringClass();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        bool isSynthetic();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class Member_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.reflect.@__Member.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int PUBLIC {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.@__Member.staticClass, global::java.lang.reflect.@__Member._PUBLIC4)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int DECLARED {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.@__Member.staticClass, global::java.lang.reflect.@__Member._DECLARED5)));
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::java.lang.reflect.Member))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::java.lang.reflect.Member))]
    internal sealed partial class @__Member : global::java.lang.Object, global::java.lang.reflect.Member {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getModifiers0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getName1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getDeclaringClass2;
        
        internal static global::net.sf.jni4net.jni.MethodId _isSynthetic3;
        
        internal static global::net.sf.jni4net.jni.FieldId _PUBLIC4;
        
        internal static global::net.sf.jni4net.jni.FieldId _DECLARED5;
        
        protected @__Member(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.reflect.@__Member.staticClass = @__class;
            global::java.lang.reflect.@__Member._getModifiers0 = @__env.GetMethodID(global::java.lang.reflect.@__Member.staticClass, "getModifiers", "()I");
            global::java.lang.reflect.@__Member._getName1 = @__env.GetMethodID(global::java.lang.reflect.@__Member.staticClass, "getName", "()Ljava/lang/String;");
            global::java.lang.reflect.@__Member._getDeclaringClass2 = @__env.GetMethodID(global::java.lang.reflect.@__Member.staticClass, "getDeclaringClass", "()Ljava/lang/Class;");
            global::java.lang.reflect.@__Member._isSynthetic3 = @__env.GetMethodID(global::java.lang.reflect.@__Member.staticClass, "isSynthetic", "()Z");
            global::java.lang.reflect.@__Member._PUBLIC4 = @__env.GetStaticFieldID(global::java.lang.reflect.@__Member.staticClass, "PUBLIC", "I");
            global::java.lang.reflect.@__Member._DECLARED5 = @__env.GetStaticFieldID(global::java.lang.reflect.@__Member.staticClass, "DECLARED", "I");
        }
        
        public int getModifiers() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.lang.reflect.@__Member._getModifiers0)));
        }
        
        public global::java.lang.String getName() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.@__Member._getName1));
        }
        
        public global::java.lang.Class getDeclaringClass() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.Class>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.@__Member._getDeclaringClass2));
        }
        
        public bool isSynthetic() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.lang.reflect.@__Member._isSynthetic3)));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__Member);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getModifiers", "getModifiers0", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getName", "getName1", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getDeclaringClass", "getDeclaringClass2", "()Ljava/lang/Class;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isSynthetic", "isSynthetic3", "()Z"));
            return methods;
        }
        
        private static int getModifiers0(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.lang.reflect.Member @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.reflect.Member>(@__env, @__obj);
            return ((int)(@__real.getModifiers()));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static global::System.IntPtr getName1(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Ljava/lang/String;
            // ()Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.lang.reflect.Member @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.reflect.Member>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.FinalCp2J(@__real.getName());
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr getDeclaringClass2(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Ljava/lang/Class;
            // ()Ljava/lang/Class;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.lang.reflect.Member @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.reflect.Member>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.FinalCp2J(@__real.getDeclaringClass());
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static bool isSynthetic3(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.lang.reflect.Member @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.reflect.Member>(@__env, @__obj);
            return ((bool)(@__real.isSynthetic()));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.reflect.@__Member(@__env);
            }
        }
    }
    #endregion
}
