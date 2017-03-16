using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='SDKInitializer']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/SDKInitializer", DoNotGenerateAcw=true)]
	public partial class SDKInitializer : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='SDKInitializer']/field[@name='SDK_BROADCAST_ACTION_STRING_NETWORK_ERROR']"
		[Register ("SDK_BROADCAST_ACTION_STRING_NETWORK_ERROR")]
		public const string SdkBroadcastActionStringNetworkError = (string) "network error";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='SDKInitializer']/field[@name='SDK_BROADTCAST_ACTION_STRING_PERMISSION_CHECK_ERROR']"
		[Register ("SDK_BROADTCAST_ACTION_STRING_PERMISSION_CHECK_ERROR")]
		public const string SdkBroadtcastActionStringPermissionCheckError = (string) "permission check error";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='SDKInitializer']/field[@name='SDK_BROADTCAST_ACTION_STRING_PERMISSION_CHECK_OK']"
		[Register ("SDK_BROADTCAST_ACTION_STRING_PERMISSION_CHECK_OK")]
		public const string SdkBroadtcastActionStringPermissionCheckOk = (string) "permission check ok";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='SDKInitializer']/field[@name='SDK_BROADTCAST_INTENT_EXTRA_INFO_KEY_ERROR_CODE']"
		[Register ("SDK_BROADTCAST_INTENT_EXTRA_INFO_KEY_ERROR_CODE")]
		public const string SdkBroadtcastIntentExtraInfoKeyErrorCode = (string) "error_code";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/SDKInitializer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SDKInitializer); }
		}

		protected SDKInitializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_initialize_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='SDKInitializer']/method[@name='initialize' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initialize", "(Landroid/content/Context;)V", "")]
		public static unsafe void Initialize (global::Android.Content.Context p0)
		{
			if (id_initialize_Landroid_content_Context_ == IntPtr.Zero)
				id_initialize_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "initialize", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initialize_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_initialize_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='SDKInitializer']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("initialize", "(Ljava/lang/String;Landroid/content/Context;)V", "")]
		public static unsafe void Initialize (string p0, global::Android.Content.Context p1)
		{
			if (id_initialize_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_initialize_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "initialize", "(Ljava/lang/String;Landroid/content/Context;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initialize_Ljava_lang_String_Landroid_content_Context_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
