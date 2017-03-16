using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comjni.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.platform.comjni.util']/class[@name='JNIMD5']"
	[global::Android.Runtime.Register ("com/baidu/platform/comjni/util/JNIMD5", DoNotGenerateAcw=true)]
	public partial class JNIMD5 : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/platform/comjni/util/JNIMD5", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JNIMD5); }
		}

		protected JNIMD5 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_encodeUrlParamsValue_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.util']/class[@name='JNIMD5']/method[@name='encodeUrlParamsValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encodeUrlParamsValue", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string EncodeUrlParamsValue (string p0)
		{
			if (id_encodeUrlParamsValue_Ljava_lang_String_ == IntPtr.Zero)
				id_encodeUrlParamsValue_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encodeUrlParamsValue", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeUrlParamsValue_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getSignMD5String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.util']/class[@name='JNIMD5']/method[@name='getSignMD5String' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSignMD5String", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetSignMD5String (string p0)
		{
			if (id_getSignMD5String_Ljava_lang_String_ == IntPtr.Zero)
				id_getSignMD5String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getSignMD5String", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSignMD5String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
