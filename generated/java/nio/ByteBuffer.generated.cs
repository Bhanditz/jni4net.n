//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.nio {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public unsafe partial class ByteBuffer : global::java.nio.Buffer, global::java.lang.Comparable {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _compareTo0;
        
        internal static global::net.sf.jni4net.jni.MethodId _get1;
        
        internal static global::net.sf.jni4net.jni.MethodId _get2;
        
        internal static global::net.sf.jni4net.jni.MethodId _get3;
        
        internal static global::net.sf.jni4net.jni.MethodId _get4;
        
        internal static global::net.sf.jni4net.jni.MethodId _put5;
        
        internal static global::net.sf.jni4net.jni.MethodId _put6;
        
        internal static global::net.sf.jni4net.jni.MethodId _put7;
        
        internal static global::net.sf.jni4net.jni.MethodId _put8;
        
        internal static global::net.sf.jni4net.jni.MethodId _put9;
        
        internal static global::net.sf.jni4net.jni.MethodId _compareTo10;
        
        internal static global::net.sf.jni4net.jni.MethodId _getShort11;
        
        internal static global::net.sf.jni4net.jni.MethodId _getShort12;
        
        internal static global::net.sf.jni4net.jni.MethodId _putShort13;
        
        internal static global::net.sf.jni4net.jni.MethodId _putShort14;
        
        internal static global::net.sf.jni4net.jni.MethodId _getChar15;
        
        internal static global::net.sf.jni4net.jni.MethodId _getChar16;
        
        internal static global::net.sf.jni4net.jni.MethodId _putChar17;
        
        internal static global::net.sf.jni4net.jni.MethodId _putChar18;
        
        internal static global::net.sf.jni4net.jni.MethodId _getInt19;
        
        internal static global::net.sf.jni4net.jni.MethodId _getInt20;
        
        internal static global::net.sf.jni4net.jni.MethodId _putInt21;
        
        internal static global::net.sf.jni4net.jni.MethodId _putInt22;
        
        internal static global::net.sf.jni4net.jni.MethodId _getLong23;
        
        internal static global::net.sf.jni4net.jni.MethodId _getLong24;
        
        internal static global::net.sf.jni4net.jni.MethodId _putLong25;
        
        internal static global::net.sf.jni4net.jni.MethodId _putLong26;
        
        internal static global::net.sf.jni4net.jni.MethodId _getFloat27;
        
        internal static global::net.sf.jni4net.jni.MethodId _getFloat28;
        
        internal static global::net.sf.jni4net.jni.MethodId _putFloat29;
        
        internal static global::net.sf.jni4net.jni.MethodId _putFloat30;
        
        internal static global::net.sf.jni4net.jni.MethodId _getDouble31;
        
        internal static global::net.sf.jni4net.jni.MethodId _getDouble32;
        
        internal static global::net.sf.jni4net.jni.MethodId _putDouble33;
        
        internal static global::net.sf.jni4net.jni.MethodId _putDouble34;
        
        internal static global::net.sf.jni4net.jni.MethodId _wrap35;
        
        internal static global::net.sf.jni4net.jni.MethodId _wrap36;
        
        internal static global::net.sf.jni4net.jni.MethodId _allocate37;
        
        internal static global::net.sf.jni4net.jni.MethodId _duplicate38;
        
        internal static global::net.sf.jni4net.jni.MethodId _allocateDirect39;
        
        internal static global::net.sf.jni4net.jni.MethodId _asCharBuffer40;
        
        internal static global::net.sf.jni4net.jni.MethodId _asDoubleBuffer41;
        
        internal static global::net.sf.jni4net.jni.MethodId _asFloatBuffer42;
        
        internal static global::net.sf.jni4net.jni.MethodId _asIntBuffer43;
        
        internal static global::net.sf.jni4net.jni.MethodId _asLongBuffer44;
        
        internal static global::net.sf.jni4net.jni.MethodId _asReadOnlyBuffer45;
        
        internal static global::net.sf.jni4net.jni.MethodId _asShortBuffer46;
        
        internal static global::net.sf.jni4net.jni.MethodId _compact47;
        
        internal static global::net.sf.jni4net.jni.MethodId _order48;
        
        internal static global::net.sf.jni4net.jni.MethodId _order49;
        
        internal static global::net.sf.jni4net.jni.MethodId _slice50;
        
        protected ByteBuffer(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.nio.ByteBuffer.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::java.nio.ByteBuffer.staticClass = staticClass;
            global::java.nio.ByteBuffer._compareTo0 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
            global::java.nio.ByteBuffer._get1 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "get", "(I)B");
            global::java.nio.ByteBuffer._get2 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "get", "()B");
            global::java.nio.ByteBuffer._get3 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "get", "([B)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._get4 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "get", "([BII)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._put5 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "put", "([B)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._put6 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "put", "(IB)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._put7 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "put", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._put8 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "put", "(B)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._put9 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "put", "([BII)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._compareTo10 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "compareTo", "(Ljava/nio/ByteBuffer;)I");
            global::java.nio.ByteBuffer._getShort11 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "getShort", "()S");
            global::java.nio.ByteBuffer._getShort12 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "getShort", "(I)S");
            global::java.nio.ByteBuffer._putShort13 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "putShort", "(S)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._putShort14 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "putShort", "(IS)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._getChar15 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "getChar", "()C");
            global::java.nio.ByteBuffer._getChar16 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "getChar", "(I)C");
            global::java.nio.ByteBuffer._putChar17 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "putChar", "(C)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._putChar18 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "putChar", "(IC)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._getInt19 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "getInt", "(I)I");
            global::java.nio.ByteBuffer._getInt20 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "getInt", "()I");
            global::java.nio.ByteBuffer._putInt21 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "putInt", "(II)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._putInt22 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "putInt", "(I)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._getLong23 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "getLong", "(I)J");
            global::java.nio.ByteBuffer._getLong24 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "getLong", "()J");
            global::java.nio.ByteBuffer._putLong25 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "putLong", "(IJ)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._putLong26 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "putLong", "(J)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._getFloat27 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "getFloat", "(I)F");
            global::java.nio.ByteBuffer._getFloat28 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "getFloat", "()F");
            global::java.nio.ByteBuffer._putFloat29 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "putFloat", "(F)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._putFloat30 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "putFloat", "(IF)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._getDouble31 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "getDouble", "()D");
            global::java.nio.ByteBuffer._getDouble32 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "getDouble", "(I)D");
            global::java.nio.ByteBuffer._putDouble33 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "putDouble", "(D)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._putDouble34 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "putDouble", "(ID)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._wrap35 = env.GetStaticMethodID(global::java.nio.ByteBuffer.staticClass, "wrap", "([BII)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._wrap36 = env.GetStaticMethodID(global::java.nio.ByteBuffer.staticClass, "wrap", "([B)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._allocate37 = env.GetStaticMethodID(global::java.nio.ByteBuffer.staticClass, "allocate", "(I)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._duplicate38 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "duplicate", "()Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._allocateDirect39 = env.GetStaticMethodID(global::java.nio.ByteBuffer.staticClass, "allocateDirect", "(I)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._asCharBuffer40 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "asCharBuffer", "()Ljava/nio/CharBuffer;");
            global::java.nio.ByteBuffer._asDoubleBuffer41 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "asDoubleBuffer", "()Ljava/nio/DoubleBuffer;");
            global::java.nio.ByteBuffer._asFloatBuffer42 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "asFloatBuffer", "()Ljava/nio/FloatBuffer;");
            global::java.nio.ByteBuffer._asIntBuffer43 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "asIntBuffer", "()Ljava/nio/IntBuffer;");
            global::java.nio.ByteBuffer._asLongBuffer44 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "asLongBuffer", "()Ljava/nio/LongBuffer;");
            global::java.nio.ByteBuffer._asReadOnlyBuffer45 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._asShortBuffer46 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "asShortBuffer", "()Ljava/nio/ShortBuffer;");
            global::java.nio.ByteBuffer._compact47 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "compact", "()Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._order48 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "order", "(Ljava/nio/ByteOrder;)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._order49 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
            global::java.nio.ByteBuffer._slice50 = env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "slice", "()Ljava/nio/ByteBuffer;");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)I")]
        public virtual int compareTo(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.nio.ByteBuffer._compareTo0, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)B")]
        public virtual byte get(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallByteMethod(this, global::java.nio.ByteBuffer._get1, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()B")]
        public virtual byte get() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallByteMethod(this, global::java.nio.ByteBuffer._get2);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([B)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer get(byte[] par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._get3, global::net.sf.jni4net.jni.Value.CreateArray(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([BII)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer get(byte[] par0, int par1, int par2) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._get4, global::net.sf.jni4net.jni.Value.CreateArray(par0), new global::net.sf.jni4net.jni.Value(par1), new global::net.sf.jni4net.jni.Value(par2)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([B)Ljava/nio/ByteBuffer;")]
        public global::java.nio.ByteBuffer put(byte[] par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._put5, global::net.sf.jni4net.jni.Value.CreateArray(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(IB)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer put(int par0, byte par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._put6, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer put(global::java.nio.ByteBuffer par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._put7, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(B)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer put(byte par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._put8, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([BII)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer put(byte[] par0, int par1, int par2) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._put9, global::net.sf.jni4net.jni.Value.CreateArray(par0), new global::net.sf.jni4net.jni.Value(par1), new global::net.sf.jni4net.jni.Value(par2)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/nio/ByteBuffer;)I")]
        public virtual int compareTo(global::java.nio.ByteBuffer par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.nio.ByteBuffer._compareTo10, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()S")]
        public virtual short getShort() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallShortMethod(this, global::java.nio.ByteBuffer._getShort11);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)S")]
        public virtual short getShort(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallShortMethod(this, global::java.nio.ByteBuffer._getShort12, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(S)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer putShort(short par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._putShort13, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(IS)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer putShort(int par0, short par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._putShort14, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()C")]
        public virtual char getChar() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallCharMethod(this, global::java.nio.ByteBuffer._getChar15);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)C")]
        public virtual char getChar(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallCharMethod(this, global::java.nio.ByteBuffer._getChar16, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(C)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer putChar(char par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._putChar17, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(IC)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer putChar(int par0, char par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._putChar18, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)I")]
        public virtual int getInt(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.nio.ByteBuffer._getInt19, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int getInt() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.nio.ByteBuffer._getInt20);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(II)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer putInt(int par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._putInt21, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer putInt(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._putInt22, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)J")]
        public virtual long getLong(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallLongMethod(this, global::java.nio.ByteBuffer._getLong23, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()J")]
        public virtual long getLong() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallLongMethod(this, global::java.nio.ByteBuffer._getLong24);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(IJ)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer putLong(int par0, long par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._putLong25, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer putLong(long par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._putLong26, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)F")]
        public virtual float getFloat(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallFloatMethod(this, global::java.nio.ByteBuffer._getFloat27, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()F")]
        public virtual float getFloat() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallFloatMethod(this, global::java.nio.ByteBuffer._getFloat28);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(F)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer putFloat(float par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._putFloat29, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(IF)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer putFloat(int par0, float par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._putFloat30, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()D")]
        public virtual double getDouble() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallDoubleMethod(this, global::java.nio.ByteBuffer._getDouble31);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)D")]
        public virtual double getDouble(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallDoubleMethod(this, global::java.nio.ByteBuffer._getDouble32, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(D)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer putDouble(double par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._putDouble33, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(ID)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer putDouble(int par0, double par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._putDouble34, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([BII)Ljava/nio/ByteBuffer;")]
        public static global::java.nio.ByteBuffer wrap(byte[] par0, int par1, int par2) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallStaticObjectMethod(global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._wrap35, global::net.sf.jni4net.jni.Value.CreateArray(par0), new global::net.sf.jni4net.jni.Value(par1), new global::net.sf.jni4net.jni.Value(par2)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([B)Ljava/nio/ByteBuffer;")]
        public static global::java.nio.ByteBuffer wrap(byte[] par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallStaticObjectMethod(global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._wrap36, global::net.sf.jni4net.jni.Value.CreateArray(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/nio/ByteBuffer;")]
        public static global::java.nio.ByteBuffer allocate(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallStaticObjectMethod(global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._allocate37, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer duplicate() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._duplicate38));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/nio/ByteBuffer;")]
        public static global::java.nio.ByteBuffer allocateDirect(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallStaticObjectMethod(global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._allocateDirect39, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/nio/Buffer;")]
        public virtual global::java.nio.Buffer asCharBuffer() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.Buffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._asCharBuffer40));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/nio/Buffer;")]
        public virtual global::java.nio.Buffer asDoubleBuffer() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.Buffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._asDoubleBuffer41));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/nio/Buffer;")]
        public virtual global::java.nio.Buffer asFloatBuffer() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.Buffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._asFloatBuffer42));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/nio/Buffer;")]
        public virtual global::java.nio.Buffer asIntBuffer() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.Buffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._asIntBuffer43));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/nio/Buffer;")]
        public virtual global::java.nio.Buffer asLongBuffer() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.Buffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._asLongBuffer44));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer asReadOnlyBuffer() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._asReadOnlyBuffer45));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/nio/Buffer;")]
        public virtual global::java.nio.Buffer asShortBuffer() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.Buffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._asShortBuffer46));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer compact() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._compact47));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(LSystem/Object;)Ljava/nio/ByteBuffer;")]
        public global::java.nio.ByteBuffer order(object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._order48, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()LSystem/Object;")]
        public object order() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<object>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._order49));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer slice() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.nio.ByteBuffer>(env.CallObjectMethod(this, global::java.nio.ByteBuffer._slice50));
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::java.nio.ByteBuffer(env);
            }
        }
    }
    #endregion
}
