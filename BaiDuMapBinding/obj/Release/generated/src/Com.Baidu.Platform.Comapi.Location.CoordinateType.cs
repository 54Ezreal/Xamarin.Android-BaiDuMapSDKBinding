using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comapi.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.platform.comapi.location']/class[@name='CoordinateType']"
	[global::Android.Runtime.Register ("com/baidu/platform/comapi/location/CoordinateType", DoNotGenerateAcw=true)]
	public partial class CoordinateType : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.platform.comapi.location']/class[@name='CoordinateType']/field[@name='BD09LL']"
		[Register ("BD09LL")]
		public const string Bd09ll = (string) "bd09ll";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.platform.comapi.location']/class[@name='CoordinateType']/field[@name='BD09MC']"
		[Register ("BD09MC")]
		public const string Bd09mc = (string) "bd09mc";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.platform.comapi.location']/class[@name='CoordinateType']/field[@name='GCJ02']"
		[Register ("GCJ02")]
		public const string Gcj02 = (string) "gcj02";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.platform.comapi.location']/class[@name='CoordinateType']/field[@name='WGS84']"
		[Register ("WGS84")]
		public const string Wgs84 = (string) "wgs84";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/platform/comapi/location/CoordinateType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CoordinateType); }
		}

		protected CoordinateType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.platform.comapi.location']/class[@name='CoordinateType']/constructor[@name='CoordinateType' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CoordinateType ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CoordinateType)) {
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

	}
}
