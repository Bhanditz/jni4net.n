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
    public partial class Double : global::java.lang.Number, global::java.lang.Comparable {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _compareTo0;
        
        internal static global::net.sf.jni4net.jni.MethodId _doubleToRawLongBits1;
        
        internal static global::net.sf.jni4net.jni.MethodId _doubleToLongBits2;
        
        internal static global::net.sf.jni4net.jni.MethodId _longBitsToDouble3;
        
        internal static global::net.sf.jni4net.jni.MethodId _compareTo4;
        
        internal static global::net.sf.jni4net.jni.MethodId _toHexString5;
        
        internal static global::net.sf.jni4net.jni.MethodId _toString6;
        
        internal static global::net.sf.jni4net.jni.MethodId _compare7;
        
        internal static global::net.sf.jni4net.jni.MethodId _valueOf8;
        
        internal static global::net.sf.jni4net.jni.MethodId _valueOf9;
        
        internal static global::net.sf.jni4net.jni.MethodId _isNaN10;
        
        internal static global::net.sf.jni4net.jni.MethodId _isNaN11;
        
        internal static global::net.sf.jni4net.jni.MethodId _isInfinite12;
        
        internal static global::net.sf.jni4net.jni.MethodId _isInfinite13;
        
        internal static global::net.sf.jni4net.jni.MethodId _parseDouble14;
        
        internal static global::net.sf.jni4net.jni.FieldId _POSITIVE_INFINITY15;
        
        internal static global::net.sf.jni4net.jni.FieldId _NEGATIVE_INFINITY16;
        
        internal static global::net.sf.jni4net.jni.FieldId _NaN17;
        
        internal static global::net.sf.jni4net.jni.FieldId _MAX_VALUE18;
        
        internal static global::net.sf.jni4net.jni.FieldId _MIN_VALUE19;
        
        internal static global::net.sf.jni4net.jni.FieldId _SIZE20;
        
        internal static global::net.sf.jni4net.jni.FieldId _TYPE21;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorDouble22;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorDouble23;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(D)V")]
        public Double(double par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.lang.Double.staticClass, global::java.lang.Double.@__ctorDouble22, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public Double(global::java.lang.String par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.lang.Double.staticClass, global::java.lang.Double.@__ctorDouble23, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        protected Double(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.Double.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("D")]
        public static double POSITIVE_INFINITY {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((double)(@__env.GetStaticDoubleField(global::java.lang.Double.staticClass, global::java.lang.Double._POSITIVE_INFINITY15)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("D")]
        public static double NEGATIVE_INFINITY {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((double)(@__env.GetStaticDoubleField(global::java.lang.Double.staticClass, global::java.lang.Double._NEGATIVE_INFINITY16)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("D")]
        public static double NaN {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((double)(@__env.GetStaticDoubleField(global::java.lang.Double.staticClass, global::java.lang.Double._NaN17)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("D")]
        public static double MAX_VALUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((double)(@__env.GetStaticDoubleField(global::java.lang.Double.staticClass, global::java.lang.Double._MAX_VALUE18)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("D")]
        public static double MIN_VALUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((double)(@__env.GetStaticDoubleField(global::java.lang.Double.staticClass, global::java.lang.Double._MIN_VALUE19)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int SIZE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.lang.Double.staticClass, global::java.lang.Double._SIZE20)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Ljava/lang/Class;")]
        public static global::java.lang.Class TYPE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return global::net.sf.jni4net.utils.Convertor.StrongJ2CpClass(@__env, @__env.GetStaticObjectFieldPtr(global::java.lang.Double.staticClass, global::java.lang.Double._TYPE21));
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.Double.staticClass = @__class;
            global::java.lang.Double._compareTo0 = @__env.GetMethodID(global::java.lang.Double.staticClass, "compareTo", "(Ljava/lang/Object;)I");
            global::java.lang.Double._doubleToRawLongBits1 = @__env.GetStaticMethodID(global::java.lang.Double.staticClass, "doubleToRawLongBits", "(D)J");
            global::java.lang.Double._doubleToLongBits2 = @__env.GetStaticMethodID(global::java.lang.Double.staticClass, "doubleToLongBits", "(D)J");
            global::java.lang.Double._longBitsToDouble3 = @__env.GetStaticMethodID(global::java.lang.Double.staticClass, "longBitsToDouble", "(J)D");
            global::java.lang.Double._compareTo4 = @__env.GetMethodID(global::java.lang.Double.staticClass, "compareTo", "(Ljava/lang/Double;)I");
            global::java.lang.Double._toHexString5 = @__env.GetStaticMethodID(global::java.lang.Double.staticClass, "toHexString", "(D)Ljava/lang/String;");
            global::java.lang.Double._toString6 = @__env.GetStaticMethodID(global::java.lang.Double.staticClass, "toString", "(D)Ljava/lang/String;");
            global::java.lang.Double._compare7 = @__env.GetStaticMethodID(global::java.lang.Double.staticClass, "compare", "(DD)I");
            global::java.lang.Double._valueOf8 = @__env.GetStaticMethodID(global::java.lang.Double.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Double;");
            global::java.lang.Double._valueOf9 = @__env.GetStaticMethodID(global::java.lang.Double.staticClass, "valueOf", "(D)Ljava/lang/Double;");
            global::java.lang.Double._isNaN10 = @__env.GetMethodID(global::java.lang.Double.staticClass, "isNaN", "()Z");
            global::java.lang.Double._isNaN11 = @__env.GetStaticMethodID(global::java.lang.Double.staticClass, "isNaN", "(D)Z");
            global::java.lang.Double._isInfinite12 = @__env.GetMethodID(global::java.lang.Double.staticClass, "isInfinite", "()Z");
            global::java.lang.Double._isInfinite13 = @__env.GetStaticMethodID(global::java.lang.Double.staticClass, "isInfinite", "(D)Z");
            global::java.lang.Double._parseDouble14 = @__env.GetStaticMethodID(global::java.lang.Double.staticClass, "parseDouble", "(Ljava/lang/String;)D");
            global::java.lang.Double._POSITIVE_INFINITY15 = @__env.GetStaticFieldID(global::java.lang.Double.staticClass, "POSITIVE_INFINITY", "D");
            global::java.lang.Double._NEGATIVE_INFINITY16 = @__env.GetStaticFieldID(global::java.lang.Double.staticClass, "NEGATIVE_INFINITY", "D");
            global::java.lang.Double._NaN17 = @__env.GetStaticFieldID(global::java.lang.Double.staticClass, "NaN", "D");
            global::java.lang.Double._MAX_VALUE18 = @__env.GetStaticFieldID(global::java.lang.Double.staticClass, "MAX_VALUE", "D");
            global::java.lang.Double._MIN_VALUE19 = @__env.GetStaticFieldID(global::java.lang.Double.staticClass, "MIN_VALUE", "D");
            global::java.lang.Double._SIZE20 = @__env.GetStaticFieldID(global::java.lang.Double.staticClass, "SIZE", "I");
            global::java.lang.Double._TYPE21 = @__env.GetStaticFieldID(global::java.lang.Double.staticClass, "TYPE", "Ljava/lang/Class;");
            global::java.lang.Double.@__ctorDouble22 = @__env.GetMethodID(global::java.lang.Double.staticClass, "<init>", "(D)V");
            global::java.lang.Double.@__ctorDouble23 = @__env.GetMethodID(global::java.lang.Double.staticClass, "<init>", "(Ljava/lang/String;)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)I")]
        public virtual int compareTo(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.lang.Double._compareTo0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(D)J")]
        public static long doubleToRawLongBits(double par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((long)(@__env.CallStaticLongMethod(global::java.lang.Double.staticClass, global::java.lang.Double._doubleToRawLongBits1, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(D)J")]
        public static long doubleToLongBits(double par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((long)(@__env.CallStaticLongMethod(global::java.lang.Double.staticClass, global::java.lang.Double._doubleToLongBits2, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)D")]
        public static double longBitsToDouble(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((double)(@__env.CallStaticDoubleMethod(global::java.lang.Double.staticClass, global::java.lang.Double._longBitsToDouble3, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Double;)I")]
        public virtual int compareTo(global::java.lang.Double par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.lang.Double._compareTo4, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(D)Ljava/lang/String;")]
        public static global::java.lang.String toHexString(double par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Double.staticClass, global::java.lang.Double._toHexString5, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(D)Ljava/lang/String;")]
        public static global::java.lang.String toString(double par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Double.staticClass, global::java.lang.Double._toString6, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(DD)I")]
        public static int compare(double par0, double par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((int)(@__env.CallStaticIntMethod(global::java.lang.Double.staticClass, global::java.lang.Double._compare7, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/Double;")]
        public static global::java.lang.Double valueOf(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Double>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Double.staticClass, global::java.lang.Double._valueOf8, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(D)Ljava/lang/Double;")]
        public static global::java.lang.Double valueOf(double par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Double>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Double.staticClass, global::java.lang.Double._valueOf9, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isNaN() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.lang.Double._isNaN10)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(D)Z")]
        public static bool isNaN(double par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.Double.staticClass, global::java.lang.Double._isNaN11, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isInfinite() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.lang.Double._isInfinite12)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(D)Z")]
        public static bool isInfinite(double par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.Double.staticClass, global::java.lang.Double._isInfinite13, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)D")]
        public static double parseDouble(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((double)(@__env.CallStaticDoubleMethod(global::java.lang.Double.staticClass, global::java.lang.Double._parseDouble14, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.Double(@__env);
            }
        }
    }
    #endregion
}
