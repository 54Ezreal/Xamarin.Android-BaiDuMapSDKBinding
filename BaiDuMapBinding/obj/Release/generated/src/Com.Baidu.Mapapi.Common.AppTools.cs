using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='AppTools']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/common/AppTools", DoNotGenerateAcw=true)]
	public partial class AppTools : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/common/AppTools", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppTools); }
		}

		protected AppTools (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='AppTools']/constructor[@name='AppTools' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AppTools ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AppTools)) {
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

		static IntPtr id_getBaiduMapToken;
		public static unsafe string BaiduMapToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='AppTools']/method[@name='getBaiduMapToken' and count(parameter)=0]"
			[Register ("getBaiduMapToken", "()Ljava/lang/String;", "GetGetBaiduMapTokenHandler")]
			get {
				if (id_getBaiduMapToken == IntPtr.Zero)
					id_getBaiduMapToken = JNIEnv.GetStaticMethodID (class_ref, "getBaiduMapToken", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBaiduMapToken), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
