//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System {
    
    
    #region Component Designer generated code 
    public unsafe partial class IConvertible_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.@__IConvertible.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute()]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.IConvertible))]
    internal sealed unsafe partial class @__IConvertible : global::java.lang.Object, global::System.IConvertible {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _GetTypeCode0;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToBoolean1;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToChar2;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToSByte3;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToByte4;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToInt165;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToUInt166;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToInt327;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToUInt328;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToInt649;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToUInt6410;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToSingle11;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToDouble12;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToDecimal13;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToDateTime14;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToString15;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToType16;
        
        protected @__IConvertible(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::System.@__IConvertible.staticClass = staticClass;
            global::System.@__IConvertible._GetTypeCode0 = env.GetMethodID(global::System.@__IConvertible.staticClass, "GetTypeCode", "()Lsystem/Enum;");
            global::System.@__IConvertible._ToBoolean1 = env.GetMethodID(global::System.@__IConvertible.staticClass, "ToBoolean", "(Lsystem/IFormatProvider;)Z");
            global::System.@__IConvertible._ToChar2 = env.GetMethodID(global::System.@__IConvertible.staticClass, "ToChar", "(Lsystem/IFormatProvider;)C");
            global::System.@__IConvertible._ToSByte3 = env.GetMethodID(global::System.@__IConvertible.staticClass, "ToSByte", "(Lsystem/IFormatProvider;)B");
            global::System.@__IConvertible._ToByte4 = env.GetMethodID(global::System.@__IConvertible.staticClass, "ToByte", "(Lsystem/IFormatProvider;)B");
            global::System.@__IConvertible._ToInt165 = env.GetMethodID(global::System.@__IConvertible.staticClass, "ToInt16", "(Lsystem/IFormatProvider;)S");
            global::System.@__IConvertible._ToUInt166 = env.GetMethodID(global::System.@__IConvertible.staticClass, "ToUInt16", "(Lsystem/IFormatProvider;)S");
            global::System.@__IConvertible._ToInt327 = env.GetMethodID(global::System.@__IConvertible.staticClass, "ToInt32", "(Lsystem/IFormatProvider;)I");
            global::System.@__IConvertible._ToUInt328 = env.GetMethodID(global::System.@__IConvertible.staticClass, "ToUInt32", "(Lsystem/IFormatProvider;)I");
            global::System.@__IConvertible._ToInt649 = env.GetMethodID(global::System.@__IConvertible.staticClass, "ToInt64", "(Lsystem/IFormatProvider;)J");
            global::System.@__IConvertible._ToUInt6410 = env.GetMethodID(global::System.@__IConvertible.staticClass, "ToUInt64", "(Lsystem/IFormatProvider;)J");
            global::System.@__IConvertible._ToSingle11 = env.GetMethodID(global::System.@__IConvertible.staticClass, "ToSingle", "(Lsystem/IFormatProvider;)F");
            global::System.@__IConvertible._ToDouble12 = env.GetMethodID(global::System.@__IConvertible.staticClass, "ToDouble", "(Lsystem/IFormatProvider;)D");
            global::System.@__IConvertible._ToDecimal13 = env.GetMethodID(global::System.@__IConvertible.staticClass, "ToDecimal", "(Lsystem/IFormatProvider;)Lsystem/Decimal;");
            global::System.@__IConvertible._ToDateTime14 = env.GetMethodID(global::System.@__IConvertible.staticClass, "ToDateTime", "(Lsystem/IFormatProvider;)Lsystem/DateTime;");
            global::System.@__IConvertible._ToString15 = env.GetMethodID(global::System.@__IConvertible.staticClass, "ToString", "(Lsystem/IFormatProvider;)Ljava/lang/String;");
            global::System.@__IConvertible._ToType16 = env.GetMethodID(global::System.@__IConvertible.staticClass, "ToType", "(Lsystem/Type;Lsystem/IFormatProvider;)Lsystem/Object;");
        }
        
        public global::System.TypeCode GetTypeCode() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::System.TypeCode>(env.CallObjectMethod(this, global::System.@__IConvertible._GetTypeCode0));
        }
        
        public bool ToBoolean(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::System.@__IConvertible._ToBoolean1, new global::net.sf.jni4net.jni.Value(provider));
        }
        
        public char ToChar(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallCharMethod(this, global::System.@__IConvertible._ToChar2, new global::net.sf.jni4net.jni.Value(provider));
        }
        
        public sbyte ToSByte(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((sbyte)(env.CallByteMethod(this, global::System.@__IConvertible._ToSByte3, new global::net.sf.jni4net.jni.Value(provider))));
        }
        
        public byte ToByte(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallByteMethod(this, global::System.@__IConvertible._ToByte4, new global::net.sf.jni4net.jni.Value(provider));
        }
        
        public short ToInt16(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallShortMethod(this, global::System.@__IConvertible._ToInt165, new global::net.sf.jni4net.jni.Value(provider));
        }
        
        public ushort ToUInt16(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((ushort)(env.CallShortMethod(this, global::System.@__IConvertible._ToUInt166, new global::net.sf.jni4net.jni.Value(provider))));
        }
        
        public int ToInt32(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::System.@__IConvertible._ToInt327, new global::net.sf.jni4net.jni.Value(provider));
        }
        
        public uint ToUInt32(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((uint)(env.CallIntMethod(this, global::System.@__IConvertible._ToUInt328, new global::net.sf.jni4net.jni.Value(provider))));
        }
        
        public long ToInt64(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallLongMethod(this, global::System.@__IConvertible._ToInt649, new global::net.sf.jni4net.jni.Value(provider));
        }
        
        public ulong ToUInt64(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((ulong)(env.CallLongMethod(this, global::System.@__IConvertible._ToUInt6410, new global::net.sf.jni4net.jni.Value(provider))));
        }
        
        public float ToSingle(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallFloatMethod(this, global::System.@__IConvertible._ToSingle11, new global::net.sf.jni4net.jni.Value(provider));
        }
        
        public double ToDouble(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallDoubleMethod(this, global::System.@__IConvertible._ToDouble12, new global::net.sf.jni4net.jni.Value(provider));
        }
        
        public decimal ToDecimal(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<decimal>(env.CallObjectMethod(this, global::System.@__IConvertible._ToDecimal13, new global::net.sf.jni4net.jni.Value(provider)));
        }
        
        public global::System.DateTime ToDateTime(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::System.DateTime>(env.CallObjectMethod(this, global::System.@__IConvertible._ToDateTime14, new global::net.sf.jni4net.jni.Value(provider)));
        }
        
        public string ToString(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<string>(env.CallObjectMethod(this, global::System.@__IConvertible._ToString15, new global::net.sf.jni4net.jni.Value(provider)));
        }
        
        public object ToType(global::System.Type conversionType, global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<object>(env.CallObjectMethod(this, global::System.@__IConvertible._ToType16, new global::net.sf.jni4net.jni.Value(conversionType), new global::net.sf.jni4net.jni.Value(provider)));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__IConvertible);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetTypeCode", "GetTypeCode0", "()Lsystem/Enum;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToBoolean", "ToBoolean1", "(Lsystem/IFormatProvider;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToChar", "ToChar2", "(Lsystem/IFormatProvider;)C"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToSByte", "ToSByte3", "(Lsystem/IFormatProvider;)B"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToByte", "ToByte4", "(Lsystem/IFormatProvider;)B"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToInt16", "ToInt165", "(Lsystem/IFormatProvider;)S"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToUInt16", "ToUInt166", "(Lsystem/IFormatProvider;)S"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToInt32", "ToInt327", "(Lsystem/IFormatProvider;)I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToUInt32", "ToUInt328", "(Lsystem/IFormatProvider;)I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToInt64", "ToInt649", "(Lsystem/IFormatProvider;)J"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToUInt64", "ToUInt6410", "(Lsystem/IFormatProvider;)J"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToSingle", "ToSingle11", "(Lsystem/IFormatProvider;)F"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToDouble", "ToDouble12", "(Lsystem/IFormatProvider;)D"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToDecimal", "ToDecimal13", "(Lsystem/IFormatProvider;)Lsystem/Decimal;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToDateTime", "ToDateTime14", "(Lsystem/IFormatProvider;)Lsystem/DateTime;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToString", "ToString15", "(Lsystem/IFormatProvider;)Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToType", "ToType16", "(Lsystem/Type;Lsystem/IFormatProvider;)Lsystem/Object;"));
            return methods;
        }
        
        private static global::java.lang.Object.JavaPtr* GetTypeCode0(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Lsystem/Enum;
            // ()LSystem/TypeCode;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.IConvertible real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IConvertible>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.GetTypeCode());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static bool ToBoolean1(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)Z
            // (LSystem/IFormatProvider;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.IConvertible real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IConvertible>(__env, @__obj);
            return real.ToBoolean(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static char ToChar2(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)C
            // (LSystem/IFormatProvider;)C
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.IConvertible real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IConvertible>(__env, @__obj);
            return real.ToChar(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(char);
        }
        
        private static sbyte ToSByte3(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)B
            // (LSystem/IFormatProvider;)LSystem/SByte;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.IConvertible real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IConvertible>(__env, @__obj);
            return ((sbyte)(real.ToSByte(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider))));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(sbyte);
        }
        
        private static byte ToByte4(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)B
            // (LSystem/IFormatProvider;)B
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.IConvertible real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IConvertible>(__env, @__obj);
            return real.ToByte(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(byte);
        }
        
        private static short ToInt165(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)S
            // (LSystem/IFormatProvider;)S
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.IConvertible real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IConvertible>(__env, @__obj);
            return real.ToInt16(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(short);
        }
        
        private static ushort ToUInt166(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)S
            // (LSystem/IFormatProvider;)LSystem/UInt16;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.IConvertible real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IConvertible>(__env, @__obj);
            return ((ushort)(real.ToUInt16(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider))));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(ushort);
        }
        
        private static int ToInt327(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)I
            // (LSystem/IFormatProvider;)I
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.IConvertible real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IConvertible>(__env, @__obj);
            return real.ToInt32(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static uint ToUInt328(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)I
            // (LSystem/IFormatProvider;)LSystem/UInt32;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.IConvertible real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IConvertible>(__env, @__obj);
            return ((uint)(real.ToUInt32(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider))));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(uint);
        }
        
        private static long ToInt649(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)J
            // (LSystem/IFormatProvider;)J
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.IConvertible real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IConvertible>(__env, @__obj);
            return real.ToInt64(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(long);
        }
        
        private static ulong ToUInt6410(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)J
            // (LSystem/IFormatProvider;)LSystem/UInt64;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.IConvertible real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IConvertible>(__env, @__obj);
            return ((ulong)(real.ToUInt64(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider))));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(ulong);
        }
        
        private static float ToSingle11(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)F
            // (LSystem/IFormatProvider;)F
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.IConvertible real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IConvertible>(__env, @__obj);
            return real.ToSingle(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(float);
        }
        
        private static double ToDouble12(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)D
            // (LSystem/IFormatProvider;)D
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.IConvertible real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IConvertible>(__env, @__obj);
            return real.ToDouble(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(double);
        }
        
        private static global::java.lang.Object.JavaPtr* ToDecimal13(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)Lsystem/Decimal;
            // (LSystem/IFormatProvider;)LSystem/Decimal;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.IConvertible real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IConvertible>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.ToDecimal(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* ToDateTime14(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)Lsystem/DateTime;
            // (LSystem/IFormatProvider;)LSystem/DateTime;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.IConvertible real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IConvertible>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.ToDateTime(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* ToString15(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)Ljava/lang/String;
            // (LSystem/IFormatProvider;)LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.IConvertible real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IConvertible>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.ConvertString(@__env, real.ToString(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* ToType16(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* conversionType, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/Type;Lsystem/IFormatProvider;)Lsystem/Object;
            // (LSystem/Type;LSystem/IFormatProvider;)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.IConvertible real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IConvertible>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.ToType(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Type>(__env, conversionType), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::System.@__IConvertible(env);
            }
        }
    }
    #endregion
}
