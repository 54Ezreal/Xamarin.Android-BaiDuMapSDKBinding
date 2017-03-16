using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']"
	[global::Android.Runtime.Register ("com/baidu/location/LocationClientOption", DoNotGenerateAcw=true)]
	public sealed partial class LocationClientOption : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='GpsFirst']"
		[Register ("GpsFirst")]
		public const int GpsFirst = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='GpsOnly']"
		[Register ("GpsOnly")]
		public const int GpsOnly = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='LOC_SENSITIVITY_HIGHT']"
		[Register ("LOC_SENSITIVITY_HIGHT")]
		public const int LocSensitivityHight = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='LOC_SENSITIVITY_LOW']"
		[Register ("LOC_SENSITIVITY_LOW")]
		public const int LocSensitivityLow = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='LOC_SENSITIVITY_MIDDLE']"
		[Register ("LOC_SENSITIVITY_MIDDLE")]
		public const int LocSensitivityMiddle = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='MIN_AUTO_NOTIFY_INTERVAL']"
		[Register ("MIN_AUTO_NOTIFY_INTERVAL")]
		public const int MinAutoNotifyInterval = (int) 10000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='MIN_SCAN_SPAN']"
		[Register ("MIN_SCAN_SPAN")]
		public const int MinScanSpan = (int) 1000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='NetWorkFirst']"
		[Register ("NetWorkFirst")]
		public const int NetWorkFirst = (int) 2;

		static IntPtr autoNotifyLocSensitivity_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='autoNotifyLocSensitivity']"
		[Register ("autoNotifyLocSensitivity")]
		public float AutoNotifyLocSensitivity {
			get {
				if (autoNotifyLocSensitivity_jfieldId == IntPtr.Zero)
					autoNotifyLocSensitivity_jfieldId = JNIEnv.GetFieldID (class_ref, "autoNotifyLocSensitivity", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, autoNotifyLocSensitivity_jfieldId);
			}
			set {
				if (autoNotifyLocSensitivity_jfieldId == IntPtr.Zero)
					autoNotifyLocSensitivity_jfieldId = JNIEnv.GetFieldID (class_ref, "autoNotifyLocSensitivity", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, autoNotifyLocSensitivity_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr autoNotifyMaxInterval_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='autoNotifyMaxInterval']"
		[Register ("autoNotifyMaxInterval")]
		public int AutoNotifyMaxInterval {
			get {
				if (autoNotifyMaxInterval_jfieldId == IntPtr.Zero)
					autoNotifyMaxInterval_jfieldId = JNIEnv.GetFieldID (class_ref, "autoNotifyMaxInterval", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, autoNotifyMaxInterval_jfieldId);
			}
			set {
				if (autoNotifyMaxInterval_jfieldId == IntPtr.Zero)
					autoNotifyMaxInterval_jfieldId = JNIEnv.GetFieldID (class_ref, "autoNotifyMaxInterval", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, autoNotifyMaxInterval_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr disableLocCache_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='disableLocCache']"
		[Register ("disableLocCache")]
		public bool DisableLocCache {
			get {
				if (disableLocCache_jfieldId == IntPtr.Zero)
					disableLocCache_jfieldId = JNIEnv.GetFieldID (class_ref, "disableLocCache", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, disableLocCache_jfieldId);
			}
			set {
				if (disableLocCache_jfieldId == IntPtr.Zero)
					disableLocCache_jfieldId = JNIEnv.GetFieldID (class_ref, "disableLocCache", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, disableLocCache_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr enableSimulateGps_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='enableSimulateGps']"
		[Register ("enableSimulateGps")]
		public bool EnableSimulateGps {
			get {
				if (enableSimulateGps_jfieldId == IntPtr.Zero)
					enableSimulateGps_jfieldId = JNIEnv.GetFieldID (class_ref, "enableSimulateGps", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, enableSimulateGps_jfieldId);
			}
			set {
				if (enableSimulateGps_jfieldId == IntPtr.Zero)
					enableSimulateGps_jfieldId = JNIEnv.GetFieldID (class_ref, "enableSimulateGps", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, enableSimulateGps_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isIgnoreCacheException_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='isIgnoreCacheException']"
		[Register ("isIgnoreCacheException")]
		public bool IsIgnoreCacheException {
			get {
				if (isIgnoreCacheException_jfieldId == IntPtr.Zero)
					isIgnoreCacheException_jfieldId = JNIEnv.GetFieldID (class_ref, "isIgnoreCacheException", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isIgnoreCacheException_jfieldId);
			}
			set {
				if (isIgnoreCacheException_jfieldId == IntPtr.Zero)
					isIgnoreCacheException_jfieldId = JNIEnv.GetFieldID (class_ref, "isIgnoreCacheException", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isIgnoreCacheException_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isIgnoreKillProcess_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='isIgnoreKillProcess']"
		[Register ("isIgnoreKillProcess")]
		public bool IsIgnoreKillProcess {
			get {
				if (isIgnoreKillProcess_jfieldId == IntPtr.Zero)
					isIgnoreKillProcess_jfieldId = JNIEnv.GetFieldID (class_ref, "isIgnoreKillProcess", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isIgnoreKillProcess_jfieldId);
			}
			set {
				if (isIgnoreKillProcess_jfieldId == IntPtr.Zero)
					isIgnoreKillProcess_jfieldId = JNIEnv.GetFieldID (class_ref, "isIgnoreKillProcess", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isIgnoreKillProcess_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isNeedAltitude_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='isNeedAltitude']"
		[Register ("isNeedAltitude")]
		public bool IsNeedAltitude {
			get {
				if (isNeedAltitude_jfieldId == IntPtr.Zero)
					isNeedAltitude_jfieldId = JNIEnv.GetFieldID (class_ref, "isNeedAltitude", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isNeedAltitude_jfieldId);
			}
			set {
				if (isNeedAltitude_jfieldId == IntPtr.Zero)
					isNeedAltitude_jfieldId = JNIEnv.GetFieldID (class_ref, "isNeedAltitude", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isNeedAltitude_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isNeedAptag_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='isNeedAptag']"
		[Register ("isNeedAptag")]
		public bool IsNeedAptag {
			get {
				if (isNeedAptag_jfieldId == IntPtr.Zero)
					isNeedAptag_jfieldId = JNIEnv.GetFieldID (class_ref, "isNeedAptag", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isNeedAptag_jfieldId);
			}
			set {
				if (isNeedAptag_jfieldId == IntPtr.Zero)
					isNeedAptag_jfieldId = JNIEnv.GetFieldID (class_ref, "isNeedAptag", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isNeedAptag_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isNeedAptagd_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='isNeedAptagd']"
		[Register ("isNeedAptagd")]
		public bool IsNeedAptagd {
			get {
				if (isNeedAptagd_jfieldId == IntPtr.Zero)
					isNeedAptagd_jfieldId = JNIEnv.GetFieldID (class_ref, "isNeedAptagd", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isNeedAptagd_jfieldId);
			}
			set {
				if (isNeedAptagd_jfieldId == IntPtr.Zero)
					isNeedAptagd_jfieldId = JNIEnv.GetFieldID (class_ref, "isNeedAptagd", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isNeedAptagd_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isNeedPoiRegion_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='isNeedPoiRegion']"
		[Register ("isNeedPoiRegion")]
		public bool IsNeedPoiRegion {
			get {
				if (isNeedPoiRegion_jfieldId == IntPtr.Zero)
					isNeedPoiRegion_jfieldId = JNIEnv.GetFieldID (class_ref, "isNeedPoiRegion", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isNeedPoiRegion_jfieldId);
			}
			set {
				if (isNeedPoiRegion_jfieldId == IntPtr.Zero)
					isNeedPoiRegion_jfieldId = JNIEnv.GetFieldID (class_ref, "isNeedPoiRegion", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isNeedPoiRegion_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isNeedRegular_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='isNeedRegular']"
		[Register ("isNeedRegular")]
		public bool IsNeedRegular {
			get {
				if (isNeedRegular_jfieldId == IntPtr.Zero)
					isNeedRegular_jfieldId = JNIEnv.GetFieldID (class_ref, "isNeedRegular", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isNeedRegular_jfieldId);
			}
			set {
				if (isNeedRegular_jfieldId == IntPtr.Zero)
					isNeedRegular_jfieldId = JNIEnv.GetFieldID (class_ref, "isNeedRegular", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isNeedRegular_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr location_change_notify_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='location_change_notify']"
		[Register ("location_change_notify")]
		public bool LocationChangeNotify {
			get {
				if (location_change_notify_jfieldId == IntPtr.Zero)
					location_change_notify_jfieldId = JNIEnv.GetFieldID (class_ref, "location_change_notify", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, location_change_notify_jfieldId);
			}
			set {
				if (location_change_notify_jfieldId == IntPtr.Zero)
					location_change_notify_jfieldId = JNIEnv.GetFieldID (class_ref, "location_change_notify", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, location_change_notify_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mIsNeedDeviceDirect_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='mIsNeedDeviceDirect']"
		[Register ("mIsNeedDeviceDirect")]
		public bool MIsNeedDeviceDirect {
			get {
				if (mIsNeedDeviceDirect_jfieldId == IntPtr.Zero)
					mIsNeedDeviceDirect_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsNeedDeviceDirect", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mIsNeedDeviceDirect_jfieldId);
			}
			set {
				if (mIsNeedDeviceDirect_jfieldId == IntPtr.Zero)
					mIsNeedDeviceDirect_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsNeedDeviceDirect", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mIsNeedDeviceDirect_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mLocationMode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='mLocationMode']"
		[Register ("mLocationMode")]
		protected global::Com.Baidu.Location.LocationClientOption.LocationMode MLocationMode {
			get {
				if (mLocationMode_jfieldId == IntPtr.Zero)
					mLocationMode_jfieldId = JNIEnv.GetFieldID (class_ref, "mLocationMode", "Lcom/baidu/location/LocationClientOption$LocationMode;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mLocationMode_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.LocationClientOption.LocationMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mLocationMode_jfieldId == IntPtr.Zero)
					mLocationMode_jfieldId = JNIEnv.GetFieldID (class_ref, "mLocationMode", "Lcom/baidu/location/LocationClientOption$LocationMode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mLocationMode_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption.LocationMode']"
		[global::Android.Runtime.Register ("com/baidu/location/LocationClientOption$LocationMode", DoNotGenerateAcw=true)]
		public sealed partial class LocationMode : global::Java.Lang.Enum {


			static IntPtr Battery_Saving_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption.LocationMode']/field[@name='Battery_Saving']"
			[Register ("Battery_Saving")]
			public static global::Com.Baidu.Location.LocationClientOption.LocationMode BatterySaving {
				get {
					if (Battery_Saving_jfieldId == IntPtr.Zero)
						Battery_Saving_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Battery_Saving", "Lcom/baidu/location/LocationClientOption$LocationMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Battery_Saving_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.LocationClientOption.LocationMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Device_Sensors_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption.LocationMode']/field[@name='Device_Sensors']"
			[Register ("Device_Sensors")]
			public static global::Com.Baidu.Location.LocationClientOption.LocationMode DeviceSensors {
				get {
					if (Device_Sensors_jfieldId == IntPtr.Zero)
						Device_Sensors_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Device_Sensors", "Lcom/baidu/location/LocationClientOption$LocationMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Device_Sensors_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.LocationClientOption.LocationMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Hight_Accuracy_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption.LocationMode']/field[@name='Hight_Accuracy']"
			[Register ("Hight_Accuracy")]
			public static global::Com.Baidu.Location.LocationClientOption.LocationMode HightAccuracy {
				get {
					if (Hight_Accuracy_jfieldId == IntPtr.Zero)
						Hight_Accuracy_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Hight_Accuracy", "Lcom/baidu/location/LocationClientOption$LocationMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Hight_Accuracy_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.LocationClientOption.LocationMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/location/LocationClientOption$LocationMode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LocationMode); }
			}

			internal LocationMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption.LocationMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/location/LocationClientOption$LocationMode;", "")]
			public static unsafe global::Com.Baidu.Location.LocationClientOption.LocationMode ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/baidu/location/LocationClientOption$LocationMode;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Baidu.Location.LocationClientOption.LocationMode __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.LocationClientOption.LocationMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption.LocationMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/baidu/location/LocationClientOption$LocationMode;", "")]
			public static unsafe global::Com.Baidu.Location.LocationClientOption.LocationMode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/baidu/location/LocationClientOption$LocationMode;");
				try {
					return (global::Com.Baidu.Location.LocationClientOption.LocationMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Location.LocationClientOption.LocationMode));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/location/LocationClientOption", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocationClientOption); }
		}

		internal LocationClientOption (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/constructor[@name='LocationClientOption' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LocationClientOption ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LocationClientOption)) {
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

		static IntPtr id_ctor_Lcom_baidu_location_LocationClientOption_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/constructor[@name='LocationClientOption' and count(parameter)=1 and parameter[1][@type='com.baidu.location.LocationClientOption']]"
		[Register (".ctor", "(Lcom/baidu/location/LocationClientOption;)V", "")]
		public unsafe LocationClientOption (global::Com.Baidu.Location.LocationClientOption p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (LocationClientOption)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/baidu/location/LocationClientOption;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/baidu/location/LocationClientOption;)V", __args);
					return;
				}

				if (id_ctor_Lcom_baidu_location_LocationClientOption_ == IntPtr.Zero)
					id_ctor_Lcom_baidu_location_LocationClientOption_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/baidu/location/LocationClientOption;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_baidu_location_LocationClientOption_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_baidu_location_LocationClientOption_, __args);
			} finally {
			}
		}

		static IntPtr id_getAddrType;
		static IntPtr id_setAddrType_Ljava_lang_String_;
		public unsafe string AddrType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='getAddrType' and count(parameter)=0]"
			[Register ("getAddrType", "()Ljava/lang/String;", "GetGetAddrTypeHandler")]
			get {
				if (id_getAddrType == IntPtr.Zero)
					id_getAddrType = JNIEnv.GetMethodID (class_ref, "getAddrType", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAddrType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setAddrType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAddrType", "(Ljava/lang/String;)V", "GetSetAddrType_Ljava_lang_String_Handler")]
			set {
				if (id_setAddrType_Ljava_lang_String_ == IntPtr.Zero)
					id_setAddrType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAddrType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAddrType_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getAutoNotifyMinDistance;
		public unsafe int AutoNotifyMinDistance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='getAutoNotifyMinDistance' and count(parameter)=0]"
			[Register ("getAutoNotifyMinDistance", "()I", "GetGetAutoNotifyMinDistanceHandler")]
			get {
				if (id_getAutoNotifyMinDistance == IntPtr.Zero)
					id_getAutoNotifyMinDistance = JNIEnv.GetMethodID (class_ref, "getAutoNotifyMinDistance", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAutoNotifyMinDistance);
				} finally {
				}
			}
		}

		static IntPtr id_getAutoNotifyMinTimeInterval;
		public unsafe int AutoNotifyMinTimeInterval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='getAutoNotifyMinTimeInterval' and count(parameter)=0]"
			[Register ("getAutoNotifyMinTimeInterval", "()I", "GetGetAutoNotifyMinTimeIntervalHandler")]
			get {
				if (id_getAutoNotifyMinTimeInterval == IntPtr.Zero)
					id_getAutoNotifyMinTimeInterval = JNIEnv.GetMethodID (class_ref, "getAutoNotifyMinTimeInterval", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAutoNotifyMinTimeInterval);
				} finally {
				}
			}
		}

		static IntPtr id_getCoorType;
		static IntPtr id_setCoorType_Ljava_lang_String_;
		public unsafe string CoorType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='getCoorType' and count(parameter)=0]"
			[Register ("getCoorType", "()Ljava/lang/String;", "GetGetCoorTypeHandler")]
			get {
				if (id_getCoorType == IntPtr.Zero)
					id_getCoorType = JNIEnv.GetMethodID (class_ref, "getCoorType", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCoorType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setCoorType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCoorType", "(Ljava/lang/String;)V", "GetSetCoorType_Ljava_lang_String_Handler")]
			set {
				if (id_setCoorType_Ljava_lang_String_ == IntPtr.Zero)
					id_setCoorType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCoorType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCoorType_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_isDisableCache;
		public unsafe bool IsDisableCache {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='isDisableCache' and count(parameter)=0]"
			[Register ("isDisableCache", "()Z", "GetIsDisableCacheHandler")]
			get {
				if (id_isDisableCache == IntPtr.Zero)
					id_isDisableCache = JNIEnv.GetMethodID (class_ref, "isDisableCache", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDisableCache);
				} finally {
				}
			}
		}

		static IntPtr id_isLocationNotify;
		static IntPtr id_setLocationNotify_Z;
		public unsafe bool LocationNotify {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='isLocationNotify' and count(parameter)=0]"
			[Register ("isLocationNotify", "()Z", "GetIsLocationNotifyHandler")]
			get {
				if (id_isLocationNotify == IntPtr.Zero)
					id_isLocationNotify = JNIEnv.GetMethodID (class_ref, "isLocationNotify", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLocationNotify);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setLocationNotify' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLocationNotify", "(Z)V", "GetSetLocationNotify_ZHandler")]
			set {
				if (id_setLocationNotify_Z == IntPtr.Zero)
					id_setLocationNotify_Z = JNIEnv.GetMethodID (class_ref, "setLocationNotify", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLocationNotify_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_isOpenGps;
		static IntPtr id_setOpenGps_Z;
		public unsafe bool OpenGps {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='isOpenGps' and count(parameter)=0]"
			[Register ("isOpenGps", "()Z", "GetIsOpenGpsHandler")]
			get {
				if (id_isOpenGps == IntPtr.Zero)
					id_isOpenGps = JNIEnv.GetMethodID (class_ref, "isOpenGps", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOpenGps);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setOpenGps' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setOpenGps", "(Z)V", "GetSetOpenGps_ZHandler")]
			set {
				if (id_setOpenGps_Z == IntPtr.Zero)
					id_setOpenGps_Z = JNIEnv.GetMethodID (class_ref, "setOpenGps", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOpenGps_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getPriority;
		static IntPtr id_setPriority_I;
		public unsafe int Priority {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='getPriority' and count(parameter)=0]"
			[Register ("getPriority", "()I", "GetGetPriorityHandler")]
			get {
				if (id_getPriority == IntPtr.Zero)
					id_getPriority = JNIEnv.GetMethodID (class_ref, "getPriority", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPriority);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setPriority' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPriority", "(I)V", "GetSetPriority_IHandler")]
			set {
				if (id_setPriority_I == IntPtr.Zero)
					id_setPriority_I = JNIEnv.GetMethodID (class_ref, "setPriority", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPriority_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getProdName;
		static IntPtr id_setProdName_Ljava_lang_String_;
		public unsafe string ProdName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='getProdName' and count(parameter)=0]"
			[Register ("getProdName", "()Ljava/lang/String;", "GetGetProdNameHandler")]
			get {
				if (id_getProdName == IntPtr.Zero)
					id_getProdName = JNIEnv.GetMethodID (class_ref, "getProdName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProdName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setProdName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setProdName", "(Ljava/lang/String;)V", "GetSetProdName_Ljava_lang_String_Handler")]
			set {
				if (id_setProdName_Ljava_lang_String_ == IntPtr.Zero)
					id_setProdName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setProdName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setProdName_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getScanSpan;
		static IntPtr id_setScanSpan_I;
		public unsafe int ScanSpan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='getScanSpan' and count(parameter)=0]"
			[Register ("getScanSpan", "()I", "GetGetScanSpanHandler")]
			get {
				if (id_getScanSpan == IntPtr.Zero)
					id_getScanSpan = JNIEnv.GetMethodID (class_ref, "getScanSpan", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getScanSpan);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setScanSpan' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setScanSpan", "(I)V", "GetSetScanSpan_IHandler")]
			set {
				if (id_setScanSpan_I == IntPtr.Zero)
					id_setScanSpan_I = JNIEnv.GetMethodID (class_ref, "setScanSpan", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScanSpan_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getServiceName;
		static IntPtr id_setServiceName_Ljava_lang_String_;
		public unsafe string ServiceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='getServiceName' and count(parameter)=0]"
			[Register ("getServiceName", "()Ljava/lang/String;", "GetGetServiceNameHandler")]
			get {
				if (id_getServiceName == IntPtr.Zero)
					id_getServiceName = JNIEnv.GetMethodID (class_ref, "getServiceName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServiceName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setServiceName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setServiceName", "(Ljava/lang/String;)V", "GetSetServiceName_Ljava_lang_String_Handler")]
			set {
				if (id_setServiceName_Ljava_lang_String_ == IntPtr.Zero)
					id_setServiceName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setServiceName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setServiceName_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getTimeOut;
		static IntPtr id_setTimeOut_I;
		public unsafe int TimeOut {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='getTimeOut' and count(parameter)=0]"
			[Register ("getTimeOut", "()I", "GetGetTimeOutHandler")]
			get {
				if (id_getTimeOut == IntPtr.Zero)
					id_getTimeOut = JNIEnv.GetMethodID (class_ref, "getTimeOut", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTimeOut);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setTimeOut' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTimeOut", "(I)V", "GetSetTimeOut_IHandler")]
			set {
				if (id_setTimeOut_I == IntPtr.Zero)
					id_setTimeOut_I = JNIEnv.GetMethodID (class_ref, "setTimeOut", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTimeOut_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_SetIgnoreCacheException_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='SetIgnoreCacheException' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("SetIgnoreCacheException", "(Z)V", "")]
		public unsafe void SetIgnoreCacheException (bool p0)
		{
			if (id_SetIgnoreCacheException_Z == IntPtr.Zero)
				id_SetIgnoreCacheException_Z = JNIEnv.GetMethodID (class_ref, "SetIgnoreCacheException", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetIgnoreCacheException_Z, __args);
			} finally {
			}
		}

		static IntPtr id_disableCache_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='disableCache' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("disableCache", "(Z)V", "")]
		public unsafe void DisableCache (bool p0)
		{
			if (id_disableCache_Z == IntPtr.Zero)
				id_disableCache_Z = JNIEnv.GetMethodID (class_ref, "disableCache", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disableCache_Z, __args);
			} finally {
			}
		}

		static IntPtr id_getLocationMode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='getLocationMode' and count(parameter)=0]"
		[Register ("getLocationMode", "()Lcom/baidu/location/LocationClientOption$LocationMode;", "")]
		public unsafe global::Com.Baidu.Location.LocationClientOption.LocationMode GetLocationMode ()
		{
			if (id_getLocationMode == IntPtr.Zero)
				id_getLocationMode = JNIEnv.GetMethodID (class_ref, "getLocationMode", "()Lcom/baidu/location/LocationClientOption$LocationMode;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.LocationClientOption.LocationMode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocationMode), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_optionEquals_Lcom_baidu_location_LocationClientOption_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='optionEquals' and count(parameter)=1 and parameter[1][@type='com.baidu.location.LocationClientOption']]"
		[Register ("optionEquals", "(Lcom/baidu/location/LocationClientOption;)Z", "")]
		public unsafe bool OptionEquals (global::Com.Baidu.Location.LocationClientOption p0)
		{
			if (id_optionEquals_Lcom_baidu_location_LocationClientOption_ == IntPtr.Zero)
				id_optionEquals_Lcom_baidu_location_LocationClientOption_ = JNIEnv.GetMethodID (class_ref, "optionEquals", "(Lcom/baidu/location/LocationClientOption;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_optionEquals_Lcom_baidu_location_LocationClientOption_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setEnableSimulateGps_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setEnableSimulateGps' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnableSimulateGps", "(Z)V", "")]
		public unsafe void SetEnableSimulateGps (bool p0)
		{
			if (id_setEnableSimulateGps_Z == IntPtr.Zero)
				id_setEnableSimulateGps_Z = JNIEnv.GetMethodID (class_ref, "setEnableSimulateGps", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEnableSimulateGps_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setIgnoreKillProcess_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setIgnoreKillProcess' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIgnoreKillProcess", "(Z)V", "")]
		public unsafe void SetIgnoreKillProcess (bool p0)
		{
			if (id_setIgnoreKillProcess_Z == IntPtr.Zero)
				id_setIgnoreKillProcess_Z = JNIEnv.GetMethodID (class_ref, "setIgnoreKillProcess", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIgnoreKillProcess_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setIsNeedAddress_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setIsNeedAddress' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIsNeedAddress", "(Z)V", "")]
		public unsafe void SetIsNeedAddress (bool p0)
		{
			if (id_setIsNeedAddress_Z == IntPtr.Zero)
				id_setIsNeedAddress_Z = JNIEnv.GetMethodID (class_ref, "setIsNeedAddress", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIsNeedAddress_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setIsNeedAltitude_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setIsNeedAltitude' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIsNeedAltitude", "(Z)V", "")]
		public unsafe void SetIsNeedAltitude (bool p0)
		{
			if (id_setIsNeedAltitude_Z == IntPtr.Zero)
				id_setIsNeedAltitude_Z = JNIEnv.GetMethodID (class_ref, "setIsNeedAltitude", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIsNeedAltitude_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setIsNeedLocationDescribe_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setIsNeedLocationDescribe' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIsNeedLocationDescribe", "(Z)V", "")]
		public unsafe void SetIsNeedLocationDescribe (bool p0)
		{
			if (id_setIsNeedLocationDescribe_Z == IntPtr.Zero)
				id_setIsNeedLocationDescribe_Z = JNIEnv.GetMethodID (class_ref, "setIsNeedLocationDescribe", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIsNeedLocationDescribe_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setIsNeedLocationPoiList_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setIsNeedLocationPoiList' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIsNeedLocationPoiList", "(Z)V", "")]
		public unsafe void SetIsNeedLocationPoiList (bool p0)
		{
			if (id_setIsNeedLocationPoiList_Z == IntPtr.Zero)
				id_setIsNeedLocationPoiList_Z = JNIEnv.GetMethodID (class_ref, "setIsNeedLocationPoiList", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIsNeedLocationPoiList_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setLocationMode_Lcom_baidu_location_LocationClientOption_LocationMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setLocationMode' and count(parameter)=1 and parameter[1][@type='com.baidu.location.LocationClientOption.LocationMode']]"
		[Register ("setLocationMode", "(Lcom/baidu/location/LocationClientOption$LocationMode;)V", "")]
		public unsafe void SetLocationMode (global::Com.Baidu.Location.LocationClientOption.LocationMode p0)
		{
			if (id_setLocationMode_Lcom_baidu_location_LocationClientOption_LocationMode_ == IntPtr.Zero)
				id_setLocationMode_Lcom_baidu_location_LocationClientOption_LocationMode_ = JNIEnv.GetMethodID (class_ref, "setLocationMode", "(Lcom/baidu/location/LocationClientOption$LocationMode;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLocationMode_Lcom_baidu_location_LocationClientOption_LocationMode_, __args);
			} finally {
			}
		}

		static IntPtr id_setNeedDeviceDirect_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setNeedDeviceDirect' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setNeedDeviceDirect", "(Z)V", "")]
		public unsafe void SetNeedDeviceDirect (bool p0)
		{
			if (id_setNeedDeviceDirect_Z == IntPtr.Zero)
				id_setNeedDeviceDirect_Z = JNIEnv.GetMethodID (class_ref, "setNeedDeviceDirect", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNeedDeviceDirect_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setOpenAutoNotifyMode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setOpenAutoNotifyMode' and count(parameter)=0]"
		[Register ("setOpenAutoNotifyMode", "()V", "")]
		public unsafe void SetOpenAutoNotifyMode ()
		{
			if (id_setOpenAutoNotifyMode == IntPtr.Zero)
				id_setOpenAutoNotifyMode = JNIEnv.GetMethodID (class_ref, "setOpenAutoNotifyMode", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOpenAutoNotifyMode);
			} finally {
			}
		}

		static IntPtr id_setOpenAutoNotifyMode_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setOpenAutoNotifyMode' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("setOpenAutoNotifyMode", "(III)V", "")]
		public unsafe void SetOpenAutoNotifyMode (int p0, int p1, int p2)
		{
			if (id_setOpenAutoNotifyMode_III == IntPtr.Zero)
				id_setOpenAutoNotifyMode_III = JNIEnv.GetMethodID (class_ref, "setOpenAutoNotifyMode", "(III)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOpenAutoNotifyMode_III, __args);
			} finally {
			}
		}

		static IntPtr id_setSema_ZZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setSema' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("setSema", "(ZZZ)V", "")]
		public unsafe void SetSema (bool p0, bool p1, bool p2)
		{
			if (id_setSema_ZZZ == IntPtr.Zero)
				id_setSema_ZZZ = JNIEnv.GetMethodID (class_ref, "setSema", "(ZZZ)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSema_ZZZ, __args);
			} finally {
			}
		}

	}
}
