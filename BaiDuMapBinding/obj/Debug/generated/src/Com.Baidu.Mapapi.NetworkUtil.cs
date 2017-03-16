using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='NetworkUtil']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/NetworkUtil", DoNotGenerateAcw=true)]
	public partial class NetworkUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/NetworkUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetworkUtil); }
		}

		protected NetworkUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='NetworkUtil']/constructor[@name='NetworkUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NetworkUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (NetworkUtil)) {
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

		static IntPtr id_getActiveNetworkInfo_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='NetworkUtil']/method[@name='getActiveNetworkInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getActiveNetworkInfo", "(Landroid/content/Context;)Landroid/net/NetworkInfo;", "")]
		public static unsafe global::Android.Net.NetworkInfo GetActiveNetworkInfo (global::Android.Content.Context p0)
		{
			if (id_getActiveNetworkInfo_Landroid_content_Context_ == IntPtr.Zero)
				id_getActiveNetworkInfo_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getActiveNetworkInfo", "(Landroid/content/Context;)Landroid/net/NetworkInfo;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Net.NetworkInfo __ret = global::Java.Lang.Object.GetObject<global::Android.Net.NetworkInfo> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getActiveNetworkInfo_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCurrentNetMode_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='NetworkUtil']/method[@name='getCurrentNetMode' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getCurrentNetMode", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetCurrentNetMode (global::Android.Content.Context p0)
		{
			if (id_getCurrentNetMode_Landroid_content_Context_ == IntPtr.Zero)
				id_getCurrentNetMode_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getCurrentNetMode", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCurrentNetMode_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_initConnectState;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='NetworkUtil']/method[@name='initConnectState' and count(parameter)=0]"
		[Register ("initConnectState", "()Z", "")]
		public static unsafe bool InitConnectState ()
		{
			if (id_initConnectState == IntPtr.Zero)
				id_initConnectState = JNIEnv.GetStaticMethodID (class_ref, "initConnectState", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_initConnectState);
			} finally {
			}
		}

		static IntPtr id_isWifiConnected_Landroid_net_NetworkInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='NetworkUtil']/method[@name='isWifiConnected' and count(parameter)=1 and parameter[1][@type='android.net.NetworkInfo']]"
		[Register ("isWifiConnected", "(Landroid/net/NetworkInfo;)Z", "")]
		public static unsafe bool IsWifiConnected (global::Android.Net.NetworkInfo p0)
		{
			if (id_isWifiConnected_Landroid_net_NetworkInfo_ == IntPtr.Zero)
				id_isWifiConnected_Landroid_net_NetworkInfo_ = JNIEnv.GetStaticMethodID (class_ref, "isWifiConnected", "(Landroid/net/NetworkInfo;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isWifiConnected_Landroid_net_NetworkInfo_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_updateNetworkProxy_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='NetworkUtil']/method[@name='updateNetworkProxy' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("updateNetworkProxy", "(Landroid/content/Context;)V", "")]
		public static unsafe void UpdateNetworkProxy (global::Android.Content.Context p0)
		{
			if (id_updateNetworkProxy_Landroid_content_Context_ == IntPtr.Zero)
				id_updateNetworkProxy_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "updateNetworkProxy", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_updateNetworkProxy_Landroid_content_Context_, __args);
			} finally {
			}
		}

	}
}
