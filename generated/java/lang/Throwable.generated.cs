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
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class Throwable : global::java.io.Serializable, global::System.IDisposable {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _printStackTrace1;
        
        internal static global::net.sf.jni4net.jni.MethodId _printStackTrace2;
        
        internal static global::net.sf.jni4net.jni.MethodId _printStackTrace3;
        
        internal static global::net.sf.jni4net.jni.MethodId _fillInStackTrace4;
        
        internal static global::net.sf.jni4net.jni.MethodId _toString5;
        
        internal static global::net.sf.jni4net.jni.MethodId _getCause6;
        
        internal static global::net.sf.jni4net.jni.MethodId _getLocalizedMessage7;
        
        internal static global::net.sf.jni4net.jni.MethodId _getMessage8;
        
        internal static global::net.sf.jni4net.jni.MethodId _getStackTrace9;
        
        internal static global::net.sf.jni4net.jni.MethodId _initCause10;
        
        internal static global::net.sf.jni4net.jni.MethodId _setStackTrace11;
        
        internal static global::net.sf.jni4net.jni.MethodId _hashCode12;
        
        internal static global::net.sf.jni4net.jni.MethodId _getClass13;
        
        internal static global::net.sf.jni4net.jni.MethodId _wait14;
        
        internal static global::net.sf.jni4net.jni.MethodId _wait15;
        
        internal static global::net.sf.jni4net.jni.MethodId _wait16;
        
        internal static global::net.sf.jni4net.jni.MethodId _equals17;
        
        internal static global::net.sf.jni4net.jni.MethodId _notify18;
        
        internal static global::net.sf.jni4net.jni.MethodId _notifyAll19;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor20;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor21;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor22;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor23;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V")]
        public Throwable(global::java.lang.String par0, global::java.lang.Throwable par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.lang.Throwable.staticClass, global::java.lang.Throwable.@__ctor20, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Throwable>(@__env, par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Throwable;)V")]
        public Throwable(global::java.lang.Throwable par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.lang.Throwable.staticClass, global::java.lang.Throwable.@__ctor21, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Throwable>(@__env, par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public Throwable() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.lang.Throwable.staticClass, global::java.lang.Throwable.@__ctor22, this);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public Throwable(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.lang.Throwable.staticClass, global::java.lang.Throwable.@__ctor23, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.Throwable.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.Throwable.staticClass = @__class;
            global::java.lang.Throwable._printStackTrace1 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "printStackTrace", "(Ljava/io/PrintWriter;)V");
            global::java.lang.Throwable._printStackTrace2 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "printStackTrace", "(Ljava/io/PrintStream;)V");
            global::java.lang.Throwable._printStackTrace3 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "printStackTrace", "()V");
            global::java.lang.Throwable._fillInStackTrace4 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "fillInStackTrace", "()Ljava/lang/Throwable;");
            global::java.lang.Throwable._toString5 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "toString", "()Ljava/lang/String;");
            global::java.lang.Throwable._getCause6 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "getCause", "()Ljava/lang/Throwable;");
            global::java.lang.Throwable._getLocalizedMessage7 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "getLocalizedMessage", "()Ljava/lang/String;");
            global::java.lang.Throwable._getMessage8 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "getMessage", "()Ljava/lang/String;");
            global::java.lang.Throwable._getStackTrace9 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "getStackTrace", "()[Ljava/lang/StackTraceElement;");
            global::java.lang.Throwable._initCause10 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "initCause", "(Ljava/lang/Throwable;)Ljava/lang/Throwable;");
            global::java.lang.Throwable._setStackTrace11 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "setStackTrace", "([Ljava/lang/StackTraceElement;)V");
            global::java.lang.Throwable._hashCode12 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "hashCode", "()I");
            global::java.lang.Throwable._getClass13 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "getClass", "()Ljava/lang/Class;");
            global::java.lang.Throwable._wait14 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "wait", "()V");
            global::java.lang.Throwable._wait15 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "wait", "(JI)V");
            global::java.lang.Throwable._wait16 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "wait", "(J)V");
            global::java.lang.Throwable._equals17 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "equals", "(Ljava/lang/Object;)Z");
            global::java.lang.Throwable._notify18 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "notify", "()V");
            global::java.lang.Throwable._notifyAll19 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "notifyAll", "()V");
            global::java.lang.Throwable.@__ctor20 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
            global::java.lang.Throwable.@__ctor21 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
            global::java.lang.Throwable.@__ctor22 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "<init>", "()V");
            global::java.lang.Throwable.@__ctor23 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "<init>", "(Ljava/lang/String;)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/PrintWriter;)V")]
        public virtual void printStackTrace(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.Throwable._printStackTrace1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/PrintStream;)V")]
        public virtual void printStackTrace(global::java.io.PrintStream par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.Throwable._printStackTrace2, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public virtual void printStackTrace() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.Throwable._printStackTrace3);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Throwable;")]
        public virtual global::java.lang.Throwable fillInStackTrace() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Throwable>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Throwable._fillInStackTrace4));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String toString() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Throwable._toString5));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Throwable;")]
        public virtual global::java.lang.Throwable getCause() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Throwable>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Throwable._getCause6));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getLocalizedMessage() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Throwable._getLocalizedMessage7));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getMessage() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Throwable._getMessage8));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/StackTraceElement;")]
        public virtual java.lang.StackTraceElement[] getStackTrace() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2Cp<java.lang.StackTraceElement[], global::java.lang.StackTraceElement>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Throwable._getStackTrace9));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Throwable;)Ljava/lang/Throwable;")]
        public virtual global::java.lang.Throwable initCause(global::java.lang.Throwable par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Throwable>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Throwable._initCause10, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Throwable>(@__env, par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([Ljava/lang/StackTraceElement;)V")]
        public virtual void setStackTrace(java.lang.StackTraceElement[] par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.Throwable._setStackTrace11, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int hashCode() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.lang.Throwable._hashCode12)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Class;")]
        public global::java.lang.Class getClass() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpClass(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Throwable._getClass13));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public void wait() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.Throwable._wait14);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(JI)V")]
        public void wait(long par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.Throwable._wait15, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)V")]
        public void wait(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.Throwable._wait16, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        public virtual bool equals(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.lang.Throwable._equals17, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public void notify() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.Throwable._notify18);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public void notifyAll() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.Throwable._notifyAll19);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.ICJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.Throwable(@__env);
            }
        }
    }
    #endregion
}
