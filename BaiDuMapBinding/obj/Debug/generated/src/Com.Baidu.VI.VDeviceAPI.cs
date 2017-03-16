using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.VI {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']"
	[global::Android.Runtime.Register ("com/baidu/vi/VDeviceAPI", DoNotGenerateAcw=true)]
	public partial class VDeviceAPI : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/vi/VDeviceAPI", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VDeviceAPI); }
		}

		protected VDeviceAPI (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/constructor[@name='VDeviceAPI' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VDeviceAPI ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VDeviceAPI)) {
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

		static IntPtr id_getAppVersion;
		public static unsafe string AppVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='getAppVersion' and count(parameter)=0]"
			[Register ("getAppVersion", "()Ljava/lang/String;", "GetGetAppVersionHandler")]
			get {
				if (id_getAppVersion == IntPtr.Zero)
					id_getAppVersion = JNIEnv.GetStaticMethodID (class_ref, "getAppVersion", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppVersion), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getAvailableMemory;
		public static unsafe long AvailableMemory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='getAvailableMemory' and count(parameter)=0]"
			[Register ("getAvailableMemory", "()J", "GetGetAvailableMemoryHandler")]
			get {
				if (id_getAvailableMemory == IntPtr.Zero)
					id_getAvailableMemory = JNIEnv.GetStaticMethodID (class_ref, "getAvailableMemory", "()J");
				try {
					return JNIEnv.CallStaticLongMethod  (class_ref, id_getAvailableMemory);
				} finally {
				}
			}
		}

		static IntPtr id_getCachePath;
		public static unsafe string CachePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='getCachePath' and count(parameter)=0]"
			[Register ("getCachePath", "()Ljava/lang/String;", "GetGetCachePathHandler")]
			get {
				if (id_getCachePath == IntPtr.Zero)
					id_getCachePath = JNIEnv.GetStaticMethodID (class_ref, "getCachePath", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCachePath), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getCellId;
		public static unsafe string CellId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='getCellId' and count(parameter)=0]"
			[Register ("getCellId", "()Ljava/lang/String;", "GetGetCellIdHandler")]
			get {
				if (id_getCellId == IntPtr.Zero)
					id_getCellId = JNIEnv.GetStaticMethodID (class_ref, "getCellId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCellId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getCurrentNetworkType;
		public static unsafe int CurrentNetworkType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='getCurrentNetworkType' and count(parameter)=0]"
			[Register ("getCurrentNetworkType", "()I", "GetGetCurrentNetworkTypeHandler")]
			get {
				if (id_getCurrentNetworkType == IntPtr.Zero)
					id_getCurrentNetworkType = JNIEnv.GetStaticMethodID (class_ref, "getCurrentNetworkType", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getCurrentNetworkType);
				} finally {
				}
			}
		}

		static IntPtr id_getFreeSpace;
		public static unsafe long FreeSpace {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='getFreeSpace' and count(parameter)=0]"
			[Register ("getFreeSpace", "()J", "GetGetFreeSpaceHandler")]
			get {
				if (id_getFreeSpace == IntPtr.Zero)
					id_getFreeSpace = JNIEnv.GetStaticMethodID (class_ref, "getFreeSpace", "()J");
				try {
					return JNIEnv.CallStaticLongMethod  (class_ref, id_getFreeSpace);
				} finally {
				}
			}
		}

		static IntPtr id_getImei;
		public static unsafe string Imei {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='getImei' and count(parameter)=0]"
			[Register ("getImei", "()Ljava/lang/String;", "GetGetImeiHandler")]
			get {
				if (id_getImei == IntPtr.Zero)
					id_getImei = JNIEnv.GetStaticMethodID (class_ref, "getImei", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getImei), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getImsi;
		public static unsafe string Imsi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='getImsi' and count(parameter)=0]"
			[Register ("getImsi", "()Ljava/lang/String;", "GetGetImsiHandler")]
			get {
				if (id_getImsi == IntPtr.Zero)
					id_getImsi = JNIEnv.GetStaticMethodID (class_ref, "getImsi", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getImsi), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isWifiConnected;
		public static unsafe bool IsWifiConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='isWifiConnected' and count(parameter)=0]"
			[Register ("isWifiConnected", "()Z", "GetIsWifiConnectedHandler")]
			get {
				if (id_isWifiConnected == IntPtr.Zero)
					id_isWifiConnected = JNIEnv.GetStaticMethodID (class_ref, "isWifiConnected", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isWifiConnected);
				} finally {
				}
			}
		}

		static IntPtr id_getLac;
		public static unsafe string Lac {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='getLac' and count(parameter)=0]"
			[Register ("getLac", "()Ljava/lang/String;", "GetGetLacHandler")]
			get {
				if (id_getLac == IntPtr.Zero)
					id_getLac = JNIEnv.GetStaticMethodID (class_ref, "getLac", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLac), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getModuleFileName;
		public static unsafe string ModuleFileName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='getModuleFileName' and count(parameter)=0]"
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

		static IntPtr id_getOsVersion;
		public static unsafe string OsVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='getOsVersion' and count(parameter)=0]"
			[Register ("getOsVersion", "()Ljava/lang/String;", "GetGetOsVersionHandler")]
			get {
				if (id_getOsVersion == IntPtr.Zero)
					id_getOsVersion = JNIEnv.GetStaticMethodID (class_ref, "getOsVersion", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOsVersion), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getScreenBrightness;
		public static unsafe int ScreenBrightness {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='getScreenBrightness' and count(parameter)=0]"
			[Register ("getScreenBrightness", "()I", "GetGetScreenBrightnessHandler")]
			get {
				if (id_getScreenBrightness == IntPtr.Zero)
					id_getScreenBrightness = JNIEnv.GetStaticMethodID (class_ref, "getScreenBrightness", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getScreenBrightness);
				} finally {
				}
			}
		}

		static IntPtr id_getScreenDensity;
		public static unsafe float ScreenDensity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='getScreenDensity' and count(parameter)=0]"
			[Register ("getScreenDensity", "()F", "GetGetScreenDensityHandler")]
			get {
				if (id_getScreenDensity == IntPtr.Zero)
					id_getScreenDensity = JNIEnv.GetStaticMethodID (class_ref, "getScreenDensity", "()F");
				try {
					return JNIEnv.CallStaticFloatMethod  (class_ref, id_getScreenDensity);
				} finally {
				}
			}
		}

		static IntPtr id_getScreenDensityDpi;
		public static unsafe int ScreenDensityDpi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='getScreenDensityDpi' and count(parameter)=0]"
			[Register ("getScreenDensityDpi", "()I", "GetGetScreenDensityDpiHandler")]
			get {
				if (id_getScreenDensityDpi == IntPtr.Zero)
					id_getScreenDensityDpi = JNIEnv.GetStaticMethodID (class_ref, "getScreenDensityDpi", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getScreenDensityDpi);
				} finally {
				}
			}
		}

		static IntPtr id_getSdcardFreeSpace;
		public static unsafe long SdcardFreeSpace {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='getSdcardFreeSpace' and count(parameter)=0]"
			[Register ("getSdcardFreeSpace", "()J", "GetGetSdcardFreeSpaceHandler")]
			get {
				if (id_getSdcardFreeSpace == IntPtr.Zero)
					id_getSdcardFreeSpace = JNIEnv.GetStaticMethodID (class_ref, "getSdcardFreeSpace", "()J");
				try {
					return JNIEnv.CallStaticLongMethod  (class_ref, id_getSdcardFreeSpace);
				} finally {
				}
			}
		}

		static IntPtr id_getSdcardPath;
		public static unsafe string SdcardPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='getSdcardPath' and count(parameter)=0]"
			[Register ("getSdcardPath", "()Ljava/lang/String;", "GetGetSdcardPathHandler")]
			get {
				if (id_getSdcardPath == IntPtr.Zero)
					id_getSdcardPath = JNIEnv.GetStaticMethodID (class_ref, "getSdcardPath", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSdcardPath), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSdcardTotalSpace;
		public static unsafe long SdcardTotalSpace {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='getSdcardTotalSpace' and count(parameter)=0]"
			[Register ("getSdcardTotalSpace", "()J", "GetGetSdcardTotalSpaceHandler")]
			get {
				if (id_getSdcardTotalSpace == IntPtr.Zero)
					id_getSdcardTotalSpace = JNIEnv.GetStaticMethodID (class_ref, "getSdcardTotalSpace", "()J");
				try {
					return JNIEnv.CallStaticLongMethod  (class_ref, id_getSdcardTotalSpace);
				} finally {
				}
			}
		}

		static IntPtr id_getSystemMetricsX;
		public static unsafe float SystemMetricsX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='getSystemMetricsX' and count(parameter)=0]"
			[Register ("getSystemMetricsX", "()F", "GetGetSystemMetricsXHandler")]
			get {
				if (id_getSystemMetricsX == IntPtr.Zero)
					id_getSystemMetricsX = JNIEnv.GetStaticMethodID (class_ref, "getSystemMetricsX", "()F");
				try {
					return JNIEnv.CallStaticFloatMethod  (class_ref, id_getSystemMetricsX);
				} finally {
				}
			}
		}

		static IntPtr id_getSystemMetricsY;
		public static unsafe float SystemMetricsY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='getSystemMetricsY' and count(parameter)=0]"
			[Register ("getSystemMetricsY", "()F", "GetGetSystemMetricsYHandler")]
			get {
				if (id_getSystemMetricsY == IntPtr.Zero)
					id_getSystemMetricsY = JNIEnv.GetStaticMethodID (class_ref, "getSystemMetricsY", "()F");
				try {
					return JNIEnv.CallStaticFloatMethod  (class_ref, id_getSystemMetricsY);
				} finally {
				}
			}
		}

		static IntPtr id_getTotalMemory;
		public static unsafe long TotalMemory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='getTotalMemory' and count(parameter)=0]"
			[Register ("getTotalMemory", "()J", "GetGetTotalMemoryHandler")]
			get {
				if (id_getTotalMemory == IntPtr.Zero)
					id_getTotalMemory = JNIEnv.GetStaticMethodID (class_ref, "getTotalMemory", "()J");
				try {
					return JNIEnv.CallStaticLongMethod  (class_ref, id_getTotalMemory);
				} finally {
				}
			}
		}

		static IntPtr id_getTotalSpace;
		public static unsafe long TotalSpace {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='getTotalSpace' and count(parameter)=0]"
			[Register ("getTotalSpace", "()J", "GetGetTotalSpaceHandler")]
			get {
				if (id_getTotalSpace == IntPtr.Zero)
					id_getTotalSpace = JNIEnv.GetStaticMethodID (class_ref, "getTotalSpace", "()J");
				try {
					return JNIEnv.CallStaticLongMethod  (class_ref, id_getTotalSpace);
				} finally {
				}
			}
		}

		static IntPtr id_getWifiHotpot;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='getWifiHotpot' and count(parameter)=0]"
		[Register ("getWifiHotpot", "()[Landroid/net/wifi/ScanResult;", "")]
		public static unsafe global::Android.Net.Wifi.ScanResult[] GetWifiHotpot ()
		{
			if (id_getWifiHotpot == IntPtr.Zero)
				id_getWifiHotpot = JNIEnv.GetStaticMethodID (class_ref, "getWifiHotpot", "()[Landroid/net/wifi/ScanResult;");
			try {
				return (global::Android.Net.Wifi.ScanResult[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getWifiHotpot), JniHandleOwnership.TransferLocalRef, typeof (global::Android.Net.Wifi.ScanResult));
			} finally {
			}
		}

		static IntPtr id_makeCall_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='makeCall' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeCall", "(Ljava/lang/String;)V", "")]
		public static unsafe void MakeCall (string p0)
		{
			if (id_makeCall_Ljava_lang_String_ == IntPtr.Zero)
				id_makeCall_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "makeCall", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_makeCall_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_onNetworkStateChanged;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='onNetworkStateChanged' and count(parameter)=0]"
		[Register ("onNetworkStateChanged", "()V", "")]
		public static unsafe void OnNetworkStateChanged ()
		{
			if (id_onNetworkStateChanged == IntPtr.Zero)
				id_onNetworkStateChanged = JNIEnv.GetStaticMethodID (class_ref, "onNetworkStateChanged", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onNetworkStateChanged);
			} finally {
			}
		}

		static IntPtr id_openUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='openUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("openUrl", "(Ljava/lang/String;)V", "")]
		public static unsafe void OpenUrl (string p0)
		{
			if (id_openUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_openUrl_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "openUrl", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_openUrl_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_sendMMS_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='sendMMS' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("sendMMS", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int SendMMS (string p0, string p1, string p2, string p3)
		{
			if (id_sendMMS_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendMMS_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sendMMS", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_sendMMS_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_sendSMS_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='sendSMS' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendSMS", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SendSMS (string p0, string p1)
		{
			if (id_sendSMS_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendSMS_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sendSMS", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendSMS_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setNetworkChangedCallback;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='setNetworkChangedCallback' and count(parameter)=0]"
		[Register ("setNetworkChangedCallback", "()V", "")]
		public static unsafe void SetNetworkChangedCallback ()
		{
			if (id_setNetworkChangedCallback == IntPtr.Zero)
				id_setNetworkChangedCallback = JNIEnv.GetStaticMethodID (class_ref, "setNetworkChangedCallback", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setNetworkChangedCallback);
			} finally {
			}
		}

		static IntPtr id_setScreenAlwaysOn_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='setScreenAlwaysOn' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScreenAlwaysOn", "(Z)V", "")]
		public static unsafe void SetScreenAlwaysOn (bool p0)
		{
			if (id_setScreenAlwaysOn_Z == IntPtr.Zero)
				id_setScreenAlwaysOn_Z = JNIEnv.GetStaticMethodID (class_ref, "setScreenAlwaysOn", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setScreenAlwaysOn_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setupSoftware_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='setupSoftware' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setupSoftware", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetupSoftware (string p0)
		{
			if (id_setupSoftware_Ljava_lang_String_ == IntPtr.Zero)
				id_setupSoftware_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setupSoftware", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setupSoftware_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_unsetNetworkChangedCallback;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VDeviceAPI']/method[@name='unsetNetworkChangedCallback' and count(parameter)=0]"
		[Register ("unsetNetworkChangedCallback", "()V", "")]
		public static unsafe void UnsetNetworkChangedCallback ()
		{
			if (id_unsetNetworkChangedCallback == IntPtr.Zero)
				id_unsetNetworkChangedCallback = JNIEnv.GetStaticMethodID (class_ref, "unsetNetworkChangedCallback", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_unsetNetworkChangedCallback);
			} finally {
			}
		}

	}
}
