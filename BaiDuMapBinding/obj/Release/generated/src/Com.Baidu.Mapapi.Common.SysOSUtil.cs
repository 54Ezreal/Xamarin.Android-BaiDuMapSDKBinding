using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='SysOSUtil']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/common/SysOSUtil", DoNotGenerateAcw=true)]
	public partial class SysOSUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/common/SysOSUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SysOSUtil); }
		}

		protected SysOSUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='SysOSUtil']/constructor[@name='SysOSUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SysOSUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SysOSUtil)) {
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

		static IntPtr id_getDensity;
		public static unsafe float Density {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='SysOSUtil']/method[@name='getDensity' and count(parameter)=0]"
			[Register ("getDensity", "()F", "GetGetDensityHandler")]
			get {
				if (id_getDensity == IntPtr.Zero)
					id_getDensity = JNIEnv.GetStaticMethodID (class_ref, "getDensity", "()F");
				try {
					return JNIEnv.CallStaticFloatMethod  (class_ref, id_getDensity);
				} finally {
				}
			}
		}

		static IntPtr id_getDensityDpi;
		public static unsafe int DensityDpi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='SysOSUtil']/method[@name='getDensityDpi' and count(parameter)=0]"
			[Register ("getDensityDpi", "()I", "GetGetDensityDpiHandler")]
			get {
				if (id_getDensityDpi == IntPtr.Zero)
					id_getDensityDpi = JNIEnv.GetStaticMethodID (class_ref, "getDensityDpi", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getDensityDpi);
				} finally {
				}
			}
		}

		static IntPtr id_getDeviceID;
		public static unsafe string DeviceID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='SysOSUtil']/method[@name='getDeviceID' and count(parameter)=0]"
			[Register ("getDeviceID", "()Ljava/lang/String;", "GetGetDeviceIDHandler")]
			get {
				if (id_getDeviceID == IntPtr.Zero)
					id_getDeviceID = JNIEnv.GetStaticMethodID (class_ref, "getDeviceID", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDeviceID), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getModuleFileName;
		public static unsafe string ModuleFileName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='SysOSUtil']/method[@name='getModuleFileName' and count(parameter)=0]"
			[Register ("getModuleFileName", "()Ljava/lang/String;", "GetGetModuleFileNameHandler")]
			get {
				if (id_getModuleFileName == IntPtr.Zero)
					id_getModuleFileName = JNIEnv.GetStaticMethodID (class_ref, "getModuleFileName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getModuleFileName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPhoneType;
		public static unsafe string PhoneType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='SysOSUtil']/method[@name='getPhoneType' and count(parameter)=0]"
			[Register ("getPhoneType", "()Ljava/lang/String;", "GetGetPhoneTypeHandler")]
			get {
				if (id_getPhoneType == IntPtr.Zero)
					id_getPhoneType = JNIEnv.GetStaticMethodID (class_ref, "getPhoneType", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPhoneType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getScreenSizeX;
		public static unsafe int ScreenSizeX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='SysOSUtil']/method[@name='getScreenSizeX' and count(parameter)=0]"
			[Register ("getScreenSizeX", "()I", "GetGetScreenSizeXHandler")]
			get {
				if (id_getScreenSizeX == IntPtr.Zero)
					id_getScreenSizeX = JNIEnv.GetStaticMethodID (class_ref, "getScreenSizeX", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getScreenSizeX);
				} finally {
				}
			}
		}

		static IntPtr id_getScreenSizeY;
		public static unsafe int ScreenSizeY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='SysOSUtil']/method[@name='getScreenSizeY' and count(parameter)=0]"
			[Register ("getScreenSizeY", "()I", "GetGetScreenSizeYHandler")]
			get {
				if (id_getScreenSizeY == IntPtr.Zero)
					id_getScreenSizeY = JNIEnv.GetStaticMethodID (class_ref, "getScreenSizeY", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getScreenSizeY);
				} finally {
				}
			}
		}

	}
}
