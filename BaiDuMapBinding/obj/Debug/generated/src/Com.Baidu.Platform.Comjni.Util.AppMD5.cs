using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comjni.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.platform.comjni.util']/class[@name='AppMD5']"
	[global::Android.Runtime.Register ("com/baidu/platform/comjni/util/AppMD5", DoNotGenerateAcw=true)]
	public partial class AppMD5 : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/platform/comjni/util/AppMD5", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppMD5); }
		}

		protected AppMD5 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.platform.comjni.util']/class[@name='AppMD5']/constructor[@name='AppMD5' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AppMD5 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AppMD5)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_encodeUrlParamsValue_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.util']/class[@name='AppMD5']/method[@name='encodeUrlParamsValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.util']/class[@name='AppMD5']/method[@name='getSignMD5String' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
