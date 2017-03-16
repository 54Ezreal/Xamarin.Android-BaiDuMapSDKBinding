using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='B']"
	[global::Android.Runtime.Register ("com/baidu/platform/comapi/map/B", DoNotGenerateAcw=true)]
	public sealed partial class B : global::Java.Lang.Enum {


		static IntPtr a_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='B']/field[@name='a']"
		[Register ("a")]
		public static global::Com.Baidu.Platform.Comapi.Map.B A {
			get {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "a", "Lcom/baidu/platform/comapi/map/B;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, a_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.B> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BField_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='B']/field[@name='BField']"
		[Register ("BField")]
		public static global::Com.Baidu.Platform.Comapi.Map.B BField {
			get {
				if (BField_jfieldId == IntPtr.Zero)
					BField_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BField", "Lcom/baidu/platform/comapi/map/B;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BField_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.B> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr c_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='B']/field[@name='c']"
		[Register ("c")]
		public static global::Com.Baidu.Platform.Comapi.Map.B C {
			get {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lcom/baidu/platform/comapi/map/B;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, c_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.B> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/platform/comapi/map/B", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (B); }
		}

		internal B (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='B']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/platform/comapi/map/B;", "")]
		public static unsafe global::Com.Baidu.Platform.Comapi.Map.B ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/baidu/platform/comapi/map/B;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Baidu.Platform.Comapi.Map.B __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.B> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='B']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/baidu/platform/comapi/map/B;", "")]
		public static unsafe global::Com.Baidu.Platform.Comapi.Map.B[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/baidu/platform/comapi/map/B;");
			try {
				return (global::Com.Baidu.Platform.Comapi.Map.B[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Platform.Comapi.Map.B));
			} finally {
			}
		}

	}
}
