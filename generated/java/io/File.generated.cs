//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.io {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public unsafe partial class File : global::java.lang.Object, global::java.io.Serializable, global::java.lang.Comparable {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _compareTo0;
        
        internal static global::net.sf.jni4net.jni.MethodId _compareTo1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getName2;
        
        internal static global::net.sf.jni4net.jni.MethodId _length3;
        
        internal static global::net.sf.jni4net.jni.MethodId _getCanonicalPath4;
        
        internal static global::net.sf.jni4net.jni.MethodId _getParent5;
        
        internal static global::net.sf.jni4net.jni.MethodId _isAbsolute6;
        
        internal static global::net.sf.jni4net.jni.MethodId _setReadOnly7;
        
        internal static global::net.sf.jni4net.jni.MethodId _list8;
        
        internal static global::net.sf.jni4net.jni.MethodId _list9;
        
        internal static global::net.sf.jni4net.jni.MethodId _delete10;
        
        internal static global::net.sf.jni4net.jni.MethodId _getPath11;
        
        internal static global::net.sf.jni4net.jni.MethodId _canExecute12;
        
        internal static global::net.sf.jni4net.jni.MethodId _canRead13;
        
        internal static global::net.sf.jni4net.jni.MethodId _canWrite14;
        
        internal static global::net.sf.jni4net.jni.MethodId _createNewFile15;
        
        internal static global::net.sf.jni4net.jni.MethodId _createTempFile16;
        
        internal static global::net.sf.jni4net.jni.MethodId _createTempFile17;
        
        internal static global::net.sf.jni4net.jni.MethodId _deleteOnExit18;
        
        internal static global::net.sf.jni4net.jni.MethodId _exists19;
        
        internal static global::net.sf.jni4net.jni.MethodId _getAbsoluteFile20;
        
        internal static global::net.sf.jni4net.jni.MethodId _getAbsolutePath21;
        
        internal static global::net.sf.jni4net.jni.MethodId _getCanonicalFile22;
        
        internal static global::net.sf.jni4net.jni.MethodId _getFreeSpace23;
        
        internal static global::net.sf.jni4net.jni.MethodId _getParentFile24;
        
        internal static global::net.sf.jni4net.jni.MethodId _getTotalSpace25;
        
        internal static global::net.sf.jni4net.jni.MethodId _getUsableSpace26;
        
        internal static global::net.sf.jni4net.jni.MethodId _isDirectory27;
        
        internal static global::net.sf.jni4net.jni.MethodId _isFile28;
        
        internal static global::net.sf.jni4net.jni.MethodId _isHidden29;
        
        internal static global::net.sf.jni4net.jni.MethodId _lastModified30;
        
        internal static global::net.sf.jni4net.jni.MethodId _listFiles31;
        
        internal static global::net.sf.jni4net.jni.MethodId _listFiles32;
        
        internal static global::net.sf.jni4net.jni.MethodId _listRoots33;
        
        internal static global::net.sf.jni4net.jni.MethodId _mkdir34;
        
        internal static global::net.sf.jni4net.jni.MethodId _mkdirs35;
        
        internal static global::net.sf.jni4net.jni.MethodId _renameTo36;
        
        internal static global::net.sf.jni4net.jni.MethodId _setExecutable37;
        
        internal static global::net.sf.jni4net.jni.MethodId _setExecutable38;
        
        internal static global::net.sf.jni4net.jni.MethodId _setLastModified39;
        
        internal static global::net.sf.jni4net.jni.MethodId _setReadable40;
        
        internal static global::net.sf.jni4net.jni.MethodId _setReadable41;
        
        internal static global::net.sf.jni4net.jni.MethodId _setWritable42;
        
        internal static global::net.sf.jni4net.jni.MethodId _setWritable43;
        
        internal static global::net.sf.jni4net.jni.MethodId _toURI44;
        
        internal static global::net.sf.jni4net.jni.MethodId _toURL45;
        
        internal static global::net.sf.jni4net.jni.FieldId _separatorChar46;
        
        internal static global::net.sf.jni4net.jni.FieldId _separator47;
        
        internal static global::net.sf.jni4net.jni.FieldId _pathSeparatorChar48;
        
        internal static global::net.sf.jni4net.jni.FieldId _pathSeparator49;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor50;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor51;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor52;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor53;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public File(global::java.lang.String par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.GetEnv();
            env.NewObject(global::java.io.File.staticClass, global::java.io.File.@__ctor50, this, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;)V")]
        public File(global::java.lang.String par0, global::java.lang.String par1) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.GetEnv();
            env.NewObject(global::java.io.File.staticClass, global::java.io.File.@__ctor51, this, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/File;Ljava/lang/String;)V")]
        public File(global::java.io.File par0, global::java.lang.String par1) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.GetEnv();
            env.NewObject(global::java.io.File.staticClass, global::java.io.File.@__ctor52, this, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(LSystem/Object;)V")]
        public File(object par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.GetEnv();
            env.NewObject(global::java.io.File.staticClass, global::java.io.File.@__ctor53, this, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        protected File(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.io.File.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("C")]
        public static char separatorChar {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.GetEnv();
                return env.GetStaticCharField(global::java.io.File.staticClass, global::java.io.File._separatorChar46);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Ljava/lang/String;")]
        public static global::java.lang.String separator {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.GetEnv();
                return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.GetStaticObjectField(global::java.io.File.staticClass, global::java.io.File._separator47));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("C")]
        public static char pathSeparatorChar {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.GetEnv();
                return env.GetStaticCharField(global::java.io.File.staticClass, global::java.io.File._pathSeparatorChar48);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Ljava/lang/String;")]
        public static global::java.lang.String pathSeparator {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.GetEnv();
                return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.GetStaticObjectField(global::java.io.File.staticClass, global::java.io.File._pathSeparator49));
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::java.io.File.staticClass = staticClass;
            global::java.io.File._compareTo0 = env.GetMethodID(global::java.io.File.staticClass, "compareTo", "(Ljava/lang/Object;)I");
            global::java.io.File._compareTo1 = env.GetMethodID(global::java.io.File.staticClass, "compareTo", "(Ljava/io/File;)I");
            global::java.io.File._getName2 = env.GetMethodID(global::java.io.File.staticClass, "getName", "()Ljava/lang/String;");
            global::java.io.File._length3 = env.GetMethodID(global::java.io.File.staticClass, "length", "()J");
            global::java.io.File._getCanonicalPath4 = env.GetMethodID(global::java.io.File.staticClass, "getCanonicalPath", "()Ljava/lang/String;");
            global::java.io.File._getParent5 = env.GetMethodID(global::java.io.File.staticClass, "getParent", "()Ljava/lang/String;");
            global::java.io.File._isAbsolute6 = env.GetMethodID(global::java.io.File.staticClass, "isAbsolute", "()Z");
            global::java.io.File._setReadOnly7 = env.GetMethodID(global::java.io.File.staticClass, "setReadOnly", "()Z");
            global::java.io.File._list8 = env.GetMethodID(global::java.io.File.staticClass, "list", "(Ljava/io/FilenameFilter;)[Ljava/lang/String;");
            global::java.io.File._list9 = env.GetMethodID(global::java.io.File.staticClass, "list", "()[Ljava/lang/String;");
            global::java.io.File._delete10 = env.GetMethodID(global::java.io.File.staticClass, "delete", "()Z");
            global::java.io.File._getPath11 = env.GetMethodID(global::java.io.File.staticClass, "getPath", "()Ljava/lang/String;");
            global::java.io.File._canExecute12 = env.GetMethodID(global::java.io.File.staticClass, "canExecute", "()Z");
            global::java.io.File._canRead13 = env.GetMethodID(global::java.io.File.staticClass, "canRead", "()Z");
            global::java.io.File._canWrite14 = env.GetMethodID(global::java.io.File.staticClass, "canWrite", "()Z");
            global::java.io.File._createNewFile15 = env.GetMethodID(global::java.io.File.staticClass, "createNewFile", "()Z");
            global::java.io.File._createTempFile16 = env.GetStaticMethodID(global::java.io.File.staticClass, "createTempFile", "(Ljava/lang/String;Ljava/lang/String;Ljava/io/File;)Ljava/io/File;");
            global::java.io.File._createTempFile17 = env.GetStaticMethodID(global::java.io.File.staticClass, "createTempFile", "(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;");
            global::java.io.File._deleteOnExit18 = env.GetMethodID(global::java.io.File.staticClass, "deleteOnExit", "()V");
            global::java.io.File._exists19 = env.GetMethodID(global::java.io.File.staticClass, "exists", "()Z");
            global::java.io.File._getAbsoluteFile20 = env.GetMethodID(global::java.io.File.staticClass, "getAbsoluteFile", "()Ljava/io/File;");
            global::java.io.File._getAbsolutePath21 = env.GetMethodID(global::java.io.File.staticClass, "getAbsolutePath", "()Ljava/lang/String;");
            global::java.io.File._getCanonicalFile22 = env.GetMethodID(global::java.io.File.staticClass, "getCanonicalFile", "()Ljava/io/File;");
            global::java.io.File._getFreeSpace23 = env.GetMethodID(global::java.io.File.staticClass, "getFreeSpace", "()J");
            global::java.io.File._getParentFile24 = env.GetMethodID(global::java.io.File.staticClass, "getParentFile", "()Ljava/io/File;");
            global::java.io.File._getTotalSpace25 = env.GetMethodID(global::java.io.File.staticClass, "getTotalSpace", "()J");
            global::java.io.File._getUsableSpace26 = env.GetMethodID(global::java.io.File.staticClass, "getUsableSpace", "()J");
            global::java.io.File._isDirectory27 = env.GetMethodID(global::java.io.File.staticClass, "isDirectory", "()Z");
            global::java.io.File._isFile28 = env.GetMethodID(global::java.io.File.staticClass, "isFile", "()Z");
            global::java.io.File._isHidden29 = env.GetMethodID(global::java.io.File.staticClass, "isHidden", "()Z");
            global::java.io.File._lastModified30 = env.GetMethodID(global::java.io.File.staticClass, "lastModified", "()J");
            global::java.io.File._listFiles31 = env.GetMethodID(global::java.io.File.staticClass, "listFiles", "()[Ljava/io/File;");
            global::java.io.File._listFiles32 = env.GetMethodID(global::java.io.File.staticClass, "listFiles", "(Ljava/io/FilenameFilter;)[Ljava/io/File;");
            global::java.io.File._listRoots33 = env.GetStaticMethodID(global::java.io.File.staticClass, "listRoots", "()[Ljava/io/File;");
            global::java.io.File._mkdir34 = env.GetMethodID(global::java.io.File.staticClass, "mkdir", "()Z");
            global::java.io.File._mkdirs35 = env.GetMethodID(global::java.io.File.staticClass, "mkdirs", "()Z");
            global::java.io.File._renameTo36 = env.GetMethodID(global::java.io.File.staticClass, "renameTo", "(Ljava/io/File;)Z");
            global::java.io.File._setExecutable37 = env.GetMethodID(global::java.io.File.staticClass, "setExecutable", "(Z)Z");
            global::java.io.File._setExecutable38 = env.GetMethodID(global::java.io.File.staticClass, "setExecutable", "(ZZ)Z");
            global::java.io.File._setLastModified39 = env.GetMethodID(global::java.io.File.staticClass, "setLastModified", "(J)Z");
            global::java.io.File._setReadable40 = env.GetMethodID(global::java.io.File.staticClass, "setReadable", "(Z)Z");
            global::java.io.File._setReadable41 = env.GetMethodID(global::java.io.File.staticClass, "setReadable", "(ZZ)Z");
            global::java.io.File._setWritable42 = env.GetMethodID(global::java.io.File.staticClass, "setWritable", "(ZZ)Z");
            global::java.io.File._setWritable43 = env.GetMethodID(global::java.io.File.staticClass, "setWritable", "(Z)Z");
            global::java.io.File._toURI44 = env.GetMethodID(global::java.io.File.staticClass, "toURI", "()Ljava/net/URI;");
            global::java.io.File._toURL45 = env.GetMethodID(global::java.io.File.staticClass, "toURL", "()Ljava/net/URL;");
            global::java.io.File._separatorChar46 = env.GetStaticFieldID(global::java.io.File.staticClass, "separatorChar", "C");
            global::java.io.File._separator47 = env.GetStaticFieldID(global::java.io.File.staticClass, "separator", "Ljava/lang/String;");
            global::java.io.File._pathSeparatorChar48 = env.GetStaticFieldID(global::java.io.File.staticClass, "pathSeparatorChar", "C");
            global::java.io.File._pathSeparator49 = env.GetStaticFieldID(global::java.io.File.staticClass, "pathSeparator", "Ljava/lang/String;");
            global::java.io.File.@__ctor50 = env.GetMethodID(global::java.io.File.staticClass, "<init>", "(Ljava/lang/String;)V");
            global::java.io.File.@__ctor51 = env.GetMethodID(global::java.io.File.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
            global::java.io.File.@__ctor52 = env.GetMethodID(global::java.io.File.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
            global::java.io.File.@__ctor53 = env.GetMethodID(global::java.io.File.staticClass, "<init>", "(Ljava/net/URI;)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)I")]
        public virtual int compareTo(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.io.File._compareTo0, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/File;)I")]
        public virtual int compareTo(global::java.io.File par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.io.File._compareTo1, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getName() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallObjectMethod(this, global::java.io.File._getName2));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()J")]
        public virtual long length() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallLongMethod(this, global::java.io.File._length3);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getCanonicalPath() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallObjectMethod(this, global::java.io.File._getCanonicalPath4));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getParent() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallObjectMethod(this, global::java.io.File._getParent5));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isAbsolute() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.io.File._isAbsolute6);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool setReadOnly() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.io.File._setReadOnly7);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(LSystem/Object;)[Ljava/lang/String;")]
        public virtual java.lang.String[] list(object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((java.lang.String[])(env.ConvertArrayToNet<java.lang.String>(env.CallObjectMethod(this, global::java.io.File._list8, new global::net.sf.jni4net.jni.Value(par0)))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/String;")]
        public virtual java.lang.String[] list() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((java.lang.String[])(env.ConvertArrayToNet<java.lang.String>(env.CallObjectMethod(this, global::java.io.File._list9))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool delete() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.io.File._delete10);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getPath() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallObjectMethod(this, global::java.io.File._getPath11));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool canExecute() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.io.File._canExecute12);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool canRead() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.io.File._canRead13);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool canWrite() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.io.File._canWrite14);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool createNewFile() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.io.File._createNewFile15);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/io/File;)Ljava/io/File;")]
        public static global::java.io.File createTempFile(global::java.lang.String par0, global::java.lang.String par1, global::java.io.File par2) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.GetEnv();
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.io.File>(env.CallStaticObjectMethod(global::java.io.File.staticClass, global::java.io.File._createTempFile16, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1), new global::net.sf.jni4net.jni.Value(par2)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;")]
        public static global::java.io.File createTempFile(global::java.lang.String par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.GetEnv();
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.io.File>(env.CallStaticObjectMethod(global::java.io.File.staticClass, global::java.io.File._createTempFile17, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public virtual void deleteOnExit() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::java.io.File._deleteOnExit18);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool exists() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.io.File._exists19);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/io/File;")]
        public virtual global::java.io.File getAbsoluteFile() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.io.File>(env.CallObjectMethod(this, global::java.io.File._getAbsoluteFile20));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getAbsolutePath() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallObjectMethod(this, global::java.io.File._getAbsolutePath21));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/io/File;")]
        public virtual global::java.io.File getCanonicalFile() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.io.File>(env.CallObjectMethod(this, global::java.io.File._getCanonicalFile22));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()J")]
        public virtual long getFreeSpace() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallLongMethod(this, global::java.io.File._getFreeSpace23);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/io/File;")]
        public virtual global::java.io.File getParentFile() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.io.File>(env.CallObjectMethod(this, global::java.io.File._getParentFile24));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()J")]
        public virtual long getTotalSpace() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallLongMethod(this, global::java.io.File._getTotalSpace25);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()J")]
        public virtual long getUsableSpace() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallLongMethod(this, global::java.io.File._getUsableSpace26);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isDirectory() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.io.File._isDirectory27);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isFile() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.io.File._isFile28);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isHidden() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.io.File._isHidden29);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()J")]
        public virtual long lastModified() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallLongMethod(this, global::java.io.File._lastModified30);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/io/File;")]
        public virtual java.io.File[] listFiles() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((java.io.File[])(env.ConvertArrayToNet<java.io.File>(env.CallObjectMethod(this, global::java.io.File._listFiles31))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(LSystem/Object;)[Ljava/io/File;")]
        public virtual java.io.File[] listFiles(object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((java.io.File[])(env.ConvertArrayToNet<java.io.File>(env.CallObjectMethod(this, global::java.io.File._listFiles32, new global::net.sf.jni4net.jni.Value(par0)))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/io/File;")]
        public static java.io.File[] listRoots() {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.GetEnv();
            return ((java.io.File[])(env.ConvertArrayToNet<java.io.File>(env.CallStaticObjectMethod(global::java.io.File.staticClass, global::java.io.File._listRoots33))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool mkdir() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.io.File._mkdir34);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool mkdirs() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.io.File._mkdirs35);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/File;)Z")]
        public virtual bool renameTo(global::java.io.File par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.io.File._renameTo36, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Z)Z")]
        public virtual bool setExecutable(bool par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.io.File._setExecutable37, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(ZZ)Z")]
        public virtual bool setExecutable(bool par0, bool par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.io.File._setExecutable38, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)Z")]
        public virtual bool setLastModified(long par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.io.File._setLastModified39, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Z)Z")]
        public virtual bool setReadable(bool par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.io.File._setReadable40, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(ZZ)Z")]
        public virtual bool setReadable(bool par0, bool par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.io.File._setReadable41, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(ZZ)Z")]
        public virtual bool setWritable(bool par0, bool par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.io.File._setWritable42, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Z)Z")]
        public virtual bool setWritable(bool par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.io.File._setWritable43, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()LSystem/Object;")]
        public virtual object toURI() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<object>(env.CallObjectMethod(this, global::java.io.File._toURI44));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/net/URL;")]
        public virtual global::java.net.URL toURL() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.net.URL>(env.CallObjectMethod(this, global::java.io.File._toURL45));
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::java.io.File(env);
            }
        }
    }
    #endregion
}
