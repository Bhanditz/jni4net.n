//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.net {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class URL : global::java.lang.Object, global::java.io.Serializable {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _openStream0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getPath1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getAuthority2;
        
        internal static global::net.sf.jni4net.jni.MethodId _getQuery3;
        
        internal static global::net.sf.jni4net.jni.MethodId _toURI4;
        
        internal static global::net.sf.jni4net.jni.MethodId _getFile5;
        
        internal static global::net.sf.jni4net.jni.MethodId _getHost6;
        
        internal static global::net.sf.jni4net.jni.MethodId _getProtocol7;
        
        internal static global::net.sf.jni4net.jni.MethodId _openConnection8;
        
        internal static global::net.sf.jni4net.jni.MethodId _openConnection9;
        
        internal static global::net.sf.jni4net.jni.MethodId _getRef10;
        
        internal static global::net.sf.jni4net.jni.MethodId _getContent11;
        
        internal static global::net.sf.jni4net.jni.MethodId _getContent12;
        
        internal static global::net.sf.jni4net.jni.MethodId _getDefaultPort13;
        
        internal static global::net.sf.jni4net.jni.MethodId _getPort14;
        
        internal static global::net.sf.jni4net.jni.MethodId _getUserInfo15;
        
        internal static global::net.sf.jni4net.jni.MethodId _sameFile16;
        
        internal static global::net.sf.jni4net.jni.MethodId _setURLStreamHandlerFactory17;
        
        internal static global::net.sf.jni4net.jni.MethodId _toExternalForm18;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor19;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor20;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor21;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor22;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor23;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor24;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/net/URLStreamHandle" +
            "r;)V")]
        public URL(global::java.lang.String par0, global::java.lang.String par1, int par2, global::java.lang.String par3, global::java.lang.Object par4) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.net.URL.staticClass, global::java.net.URL.@__ctor19, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par4));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public URL(global::java.lang.String par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.net.URL.staticClass, global::java.net.URL.@__ctor20, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/net/URL;Ljava/lang/String;)V")]
        public URL(global::java.net.URL par0, global::java.lang.String par1) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.net.URL.staticClass, global::java.net.URL.@__ctor21, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/net/URL;Ljava/lang/String;Ljava/net/URLStreamHandler;)V")]
        public URL(global::java.net.URL par0, global::java.lang.String par1, global::java.lang.Object par2) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.net.URL.staticClass, global::java.net.URL.@__ctor22, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par2));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V")]
        public URL(global::java.lang.String par0, global::java.lang.String par1, global::java.lang.String par2) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.net.URL.staticClass, global::java.net.URL.@__ctor23, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par2));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V")]
        public URL(global::java.lang.String par0, global::java.lang.String par1, int par2, global::java.lang.String par3) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.net.URL.staticClass, global::java.net.URL.@__ctor24, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par3));
        }
        
        protected URL(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.net.URL.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.net.URL.staticClass = @__class;
            global::java.net.URL._openStream0 = @__env.GetMethodID(global::java.net.URL.staticClass, "openStream", "()Ljava/io/InputStream;");
            global::java.net.URL._getPath1 = @__env.GetMethodID(global::java.net.URL.staticClass, "getPath", "()Ljava/lang/String;");
            global::java.net.URL._getAuthority2 = @__env.GetMethodID(global::java.net.URL.staticClass, "getAuthority", "()Ljava/lang/String;");
            global::java.net.URL._getQuery3 = @__env.GetMethodID(global::java.net.URL.staticClass, "getQuery", "()Ljava/lang/String;");
            global::java.net.URL._toURI4 = @__env.GetMethodID(global::java.net.URL.staticClass, "toURI", "()Ljava/net/URI;");
            global::java.net.URL._getFile5 = @__env.GetMethodID(global::java.net.URL.staticClass, "getFile", "()Ljava/lang/String;");
            global::java.net.URL._getHost6 = @__env.GetMethodID(global::java.net.URL.staticClass, "getHost", "()Ljava/lang/String;");
            global::java.net.URL._getProtocol7 = @__env.GetMethodID(global::java.net.URL.staticClass, "getProtocol", "()Ljava/lang/String;");
            global::java.net.URL._openConnection8 = @__env.GetMethodID(global::java.net.URL.staticClass, "openConnection", "()Ljava/net/URLConnection;");
            global::java.net.URL._openConnection9 = @__env.GetMethodID(global::java.net.URL.staticClass, "openConnection", "(Ljava/net/Proxy;)Ljava/net/URLConnection;");
            global::java.net.URL._getRef10 = @__env.GetMethodID(global::java.net.URL.staticClass, "getRef", "()Ljava/lang/String;");
            global::java.net.URL._getContent11 = @__env.GetMethodID(global::java.net.URL.staticClass, "getContent", "()Ljava/lang/Object;");
            global::java.net.URL._getContent12 = @__env.GetMethodID(global::java.net.URL.staticClass, "getContent", "([Ljava/lang/Class;)Ljava/lang/Object;");
            global::java.net.URL._getDefaultPort13 = @__env.GetMethodID(global::java.net.URL.staticClass, "getDefaultPort", "()I");
            global::java.net.URL._getPort14 = @__env.GetMethodID(global::java.net.URL.staticClass, "getPort", "()I");
            global::java.net.URL._getUserInfo15 = @__env.GetMethodID(global::java.net.URL.staticClass, "getUserInfo", "()Ljava/lang/String;");
            global::java.net.URL._sameFile16 = @__env.GetMethodID(global::java.net.URL.staticClass, "sameFile", "(Ljava/net/URL;)Z");
            global::java.net.URL._setURLStreamHandlerFactory17 = @__env.GetStaticMethodID(global::java.net.URL.staticClass, "setURLStreamHandlerFactory", "(Ljava/net/URLStreamHandlerFactory;)V");
            global::java.net.URL._toExternalForm18 = @__env.GetMethodID(global::java.net.URL.staticClass, "toExternalForm", "()Ljava/lang/String;");
            global::java.net.URL.@__ctor19 = @__env.GetMethodID(global::java.net.URL.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/net/URLStreamHandle" +
                    "r;)V");
            global::java.net.URL.@__ctor20 = @__env.GetMethodID(global::java.net.URL.staticClass, "<init>", "(Ljava/lang/String;)V");
            global::java.net.URL.@__ctor21 = @__env.GetMethodID(global::java.net.URL.staticClass, "<init>", "(Ljava/net/URL;Ljava/lang/String;)V");
            global::java.net.URL.@__ctor22 = @__env.GetMethodID(global::java.net.URL.staticClass, "<init>", "(Ljava/net/URL;Ljava/lang/String;Ljava/net/URLStreamHandler;)V");
            global::java.net.URL.@__ctor23 = @__env.GetMethodID(global::java.net.URL.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
            global::java.net.URL.@__ctor24 = @__env.GetMethodID(global::java.net.URL.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/io/InputStream;")]
        public global::java.io.InputStream openStream() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URL._openStream0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getPath() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URL._getPath1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getAuthority() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URL._getAuthority2));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getQuery() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URL._getQuery3));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/net/URI;")]
        public virtual global::java.lang.Object toURI() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URL._toURI4));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getFile() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URL._getFile5));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getHost() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URL._getHost6));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getProtocol() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URL._getProtocol7));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/net/URLConnection;")]
        public virtual global::java.lang.Object openConnection() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URL._openConnection8));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/net/Proxy;)Ljava/net/URLConnection;")]
        public virtual global::java.lang.Object openConnection(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URL._openConnection9, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getRef() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URL._getRef10));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Object;")]
        public global::java.lang.Object getContent() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URL._getContent11));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([Ljava/lang/Class;)Ljava/lang/Object;")]
        public global::java.lang.Object getContent(java.lang.Class[] par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URL._getContent12, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int getDefaultPort() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.net.URL._getDefaultPort13)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int getPort() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.net.URL._getPort14)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getUserInfo() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URL._getUserInfo15));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/net/URL;)Z")]
        public virtual bool sameFile(global::java.net.URL par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.net.URL._sameFile16, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/net/URLStreamHandlerFactory;)V")]
        public static void setURLStreamHandlerFactory(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.CallStaticVoidMethod(global::java.net.URL.staticClass, global::java.net.URL._setURLStreamHandlerFactory17, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String toExternalForm() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URL._toExternalForm18));
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.ICJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.net.URL(@__env);
            }
        }
    }
    #endregion
}
