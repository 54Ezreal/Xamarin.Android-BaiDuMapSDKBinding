using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='D']"
	[global::Android.Runtime.Register ("com/baidu/platform/comapi/map/D", DoNotGenerateAcw=true)]
	public sealed partial class D : global::Java.Lang.Enum {


		static IntPtr a_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='D']/field[@name='a']"
		[Register ("a")]
		public static global::Com.Baidu.Platform.Comapi.Map.D A {
			get {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "a", "Lcom/baidu/platform/comapi/map/D;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, a_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.D> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr b_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='D']/field[@name='b']"
		[Register ("b")]
		public static global::Com.Baidu.Platform.Comapi.Map.D B {
			get {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Lcom/baidu/platform/comapi/map/D;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, b_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.D> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/platform/comapi/map/D", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (D); }
		}

		internal D (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='D']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/platform/comapi/map/D;", "")]
		public static unsafe global::Com.Baidu.Platform.Comapi.Map.D ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/baidu/platform/comapi/map/D;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Baidu.Platform.Comapi.Map.D __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.D> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='D']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/baidu/platform/comapi/map/D;", "")]
		public static unsafe global::Com.Baidu.Platform.Comapi.Map.D[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/baidu/platform/comapi/map/D;");
			try {
				return (global::Com.Baidu.Platform.Comapi.Map.D[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Platform.Comapi.Map.D));
			} finally {
			}
		}

	}
}
