using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='VersionInfo']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/VersionInfo", DoNotGenerateAcw=true)]
	public partial class VersionInfo : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='VersionInfo']/field[@name='VersionInformation']"
		[Register ("VersionInformation")]
		public const string VersionInformation = (string) "4_2_1";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/VersionInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VersionInfo); }
		}

		protected VersionInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='VersionInfo']/constructor[@name='VersionInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VersionInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VersionInfo)) {
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

		static IntPtr id_getApiVersion;
		public static unsafe string ApiVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='VersionInfo']/method[@name='getApiVersion' and count(parameter)=0]"
			[Register ("getApiVersion", "()Ljava/lang/String;", "GetGetApiVersionHandler")]
			get {
				if (id_getApiVersion == IntPtr.Zero)
					id_getApiVersion = JNIEnv.GetStaticMethodID (class_ref, "getApiVersion", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getApiVersion), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getKitName;
		public static unsafe string KitName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='VersionInfo']/method[@name='getKitName' and count(parameter)=0]"
			[Register ("getKitName", "()Ljava/lang/String;", "GetGetKitNameHandler")]
			get {
				if (id_getKitName == IntPtr.Zero)
					id_getKitName = JNIEnv.GetStaticMethodID (class_ref, "getKitName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getKitName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getVersionDesc;
		public static unsafe string VersionDesc {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='VersionInfo']/method[@name='getVersionDesc' and count(parameter)=0]"
			[Register ("getVersionDesc", "()Ljava/lang/String;", "GetGetVersionDescHandler")]
			get {
				if (id_getVersionDesc == IntPtr.Zero)
					id_getVersionDesc = JNIEnv.GetStaticMethodID (class_ref, "getVersionDesc", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getVersionDesc), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
