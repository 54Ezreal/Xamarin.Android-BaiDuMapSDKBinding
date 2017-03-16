using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']"
	[global::Android.Runtime.Register ("com/baidu/location/LocationClient", DoNotGenerateAcw=true)]
	public sealed partial class LocationClient : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/field[@name='CONNECT_HOT_SPOT_FALSE']"
		[Register ("CONNECT_HOT_SPOT_FALSE")]
		public const int ConnectHotSpotFalse = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/field[@name='CONNECT_HOT_SPOT_TRUE']"
		[Register ("CONNECT_HOT_SPOT_TRUE")]
		public const int ConnectHotSpotTrue = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/field[@name='CONNECT_HOT_SPOT_UNKNOWN']"
		[Register ("CONNECT_HOT_SPOT_UNKNOWN")]
		public const int ConnectHotSpotUnknown = (int) -1;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/location/LocationClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocationClient); }
		}

		internal LocationClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/constructor[@name='LocationClient' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe LocationClient (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (LocationClient)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_baidu_location_LocationClientOption_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/constructor[@name='LocationClient' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.baidu.location.LocationClientOption']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/baidu/location/LocationClientOption;)V", "")]
		public unsafe LocationClient (global::Android.Content.Context p0, global::Com.Baidu.Location.LocationClientOption p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (LocationClient)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Lcom/baidu/location/LocationClientOption;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Lcom/baidu/location/LocationClientOption;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_baidu_location_LocationClientOption_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_baidu_location_LocationClientOption_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/baidu/location/LocationClientOption;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_baidu_location_LocationClientOption_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_baidu_location_LocationClientOption_, __args);
			} finally {
			}
		}

		static IntPtr id_getAccessKey;
		public unsafe string AccessKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='getAccessKey' and count(parameter)=0]"
			[Register ("getAccessKey", "()Ljava/lang/String;", "GetGetAccessKeyHandler")]
			get {
				if (id_getAccessKey == IntPtr.Zero)
					id_getAccessKey = JNIEnv.GetMethodID (class_ref, "getAccessKey", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccessKey), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isStarted;
		public unsafe bool IsStarted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='isStarted' and count(parameter)=0]"
			[Register ("isStarted", "()Z", "GetIsStartedHandler")]
			get {
				if (id_isStarted == IntPtr.Zero)
					id_isStarted = JNIEnv.GetMethodID (class_ref, "isStarted", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isStarted);
				} finally {
				}
			}
		}

		static IntPtr id_getLastKnownLocation;
		public unsafe global::Com.Baidu.Location.BDLocation LastKnownLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='getLastKnownLocation' and count(parameter)=0]"
			[Register ("getLastKnownLocation", "()Lcom/baidu/location/BDLocation;", "GetGetLastKnownLocationHandler")]
			get {
				if (id_getLastKnownLocation == IntPtr.Zero)
					id_getLastKnownLocation = JNIEnv.GetMethodID (class_ref, "getLastKnownLocation", "()Lcom/baidu/location/BDLocation;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.BDLocation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastKnownLocation), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getLocOption;
		static IntPtr id_setLocOption_Lcom_baidu_location_LocationClientOption_;
		public unsafe global::Com.Baidu.Location.LocationClientOption LocOption {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='getLocOption' and count(parameter)=0]"
			[Register ("getLocOption", "()Lcom/baidu/location/LocationClientOption;", "GetGetLocOptionHandler")]
			get {
				if (id_getLocOption == IntPtr.Zero)
					id_getLocOption = JNIEnv.GetMethodID (class_ref, "getLocOption", "()Lcom/baidu/location/LocationClientOption;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.LocationClientOption> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocOption), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='setLocOption' and count(parameter)=1 and parameter[1][@type='com.baidu.location.LocationClientOption']]"
			[Register ("setLocOption", "(Lcom/baidu/location/LocationClientOption;)V", "GetSetLocOption_Lcom_baidu_location_LocationClientOption_Handler")]
			set {
				if (id_setLocOption_Lcom_baidu_location_LocationClientOption_ == IntPtr.Zero)
					id_setLocOption_Lcom_baidu_location_LocationClientOption_ = JNIEnv.GetMethodID (class_ref, "setLocOption", "(Lcom/baidu/location/LocationClientOption;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLocOption_Lcom_baidu_location_LocationClientOption_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getVersion;
		public unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVersion), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getBDLocationInCoorType_Lcom_baidu_location_BDLocation_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='getBDLocationInCoorType' and count(parameter)=2 and parameter[1][@type='com.baidu.location.BDLocation'] and parameter[2][@type='java.lang.String']]"
		[Register ("getBDLocationInCoorType", "(Lcom/baidu/location/BDLocation;Ljava/lang/String;)Lcom/baidu/location/BDLocation;", "")]
		public static unsafe global::Com.Baidu.Location.BDLocation GetBDLocationInCoorType (global::Com.Baidu.Location.BDLocation p0, string p1)
		{
			if (id_getBDLocationInCoorType_Lcom_baidu_location_BDLocation_Ljava_lang_String_ == IntPtr.Zero)
				id_getBDLocationInCoorType_Lcom_baidu_location_BDLocation_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBDLocationInCoorType", "(Lcom/baidu/location/BDLocation;Ljava/lang/String;)Lcom/baidu/location/BDLocation;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.Baidu.Location.BDLocation __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.BDLocation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBDLocationInCoorType_Lcom_baidu_location_BDLocation_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_onReceiveLocation_Lcom_baidu_location_BDLocation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='onReceiveLocation' and count(parameter)=1 and parameter[1][@type='com.baidu.location.BDLocation']]"
		[Register ("onReceiveLocation", "(Lcom/baidu/location/BDLocation;)V", "")]
		public unsafe void OnReceiveLocation (global::Com.Baidu.Location.BDLocation p0)
		{
			if (id_onReceiveLocation_Lcom_baidu_location_BDLocation_ == IntPtr.Zero)
				id_onReceiveLocation_Lcom_baidu_location_BDLocation_ = JNIEnv.GetMethodID (class_ref, "onReceiveLocation", "(Lcom/baidu/location/BDLocation;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReceiveLocation_Lcom_baidu_location_BDLocation_, __args);
			} finally {
			}
		}

		static IntPtr id_registerLocationListener_Lcom_baidu_location_BDLocationListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='registerLocationListener' and count(parameter)=1 and parameter[1][@type='com.baidu.location.BDLocationListener']]"
		[Register ("registerLocationListener", "(Lcom/baidu/location/BDLocationListener;)V", "")]
		public unsafe void RegisterLocationListener (global::Com.Baidu.Location.IBDLocationListener p0)
		{
			if (id_registerLocationListener_Lcom_baidu_location_BDLocationListener_ == IntPtr.Zero)
				id_registerLocationListener_Lcom_baidu_location_BDLocationListener_ = JNIEnv.GetMethodID (class_ref, "registerLocationListener", "(Lcom/baidu/location/BDLocationListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerLocationListener_Lcom_baidu_location_BDLocationListener_, __args);
			} finally {
			}
		}

		static IntPtr id_registerNotify_Lcom_baidu_location_BDNotifyListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='registerNotify' and count(parameter)=1 and parameter[1][@type='com.baidu.location.BDNotifyListener']]"
		[Register ("registerNotify", "(Lcom/baidu/location/BDNotifyListener;)V", "")]
		public unsafe void RegisterNotify (global::Com.Baidu.Location.BDNotifyListener p0)
		{
			if (id_registerNotify_Lcom_baidu_location_BDNotifyListener_ == IntPtr.Zero)
				id_registerNotify_Lcom_baidu_location_BDNotifyListener_ = JNIEnv.GetMethodID (class_ref, "registerNotify", "(Lcom/baidu/location/BDNotifyListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerNotify_Lcom_baidu_location_BDNotifyListener_, __args);
			} finally {
			}
		}

		static IntPtr id_registerNotifyLocationListener_Lcom_baidu_location_BDLocationListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='registerNotifyLocationListener' and count(parameter)=1 and parameter[1][@type='com.baidu.location.BDLocationListener']]"
		[Register ("registerNotifyLocationListener", "(Lcom/baidu/location/BDLocationListener;)V", "")]
		public unsafe void RegisterNotifyLocationListener (global::Com.Baidu.Location.IBDLocationListener p0)
		{
			if (id_registerNotifyLocationListener_Lcom_baidu_location_BDLocationListener_ == IntPtr.Zero)
				id_registerNotifyLocationListener_Lcom_baidu_location_BDLocationListener_ = JNIEnv.GetMethodID (class_ref, "registerNotifyLocationListener", "(Lcom/baidu/location/BDLocationListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerNotifyLocationListener_Lcom_baidu_location_BDLocationListener_, __args);
			} finally {
			}
		}

		static IntPtr id_removeNotifyEvent_Lcom_baidu_location_BDNotifyListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='removeNotifyEvent' and count(parameter)=1 and parameter[1][@type='com.baidu.location.BDNotifyListener']]"
		[Register ("removeNotifyEvent", "(Lcom/baidu/location/BDNotifyListener;)V", "")]
		public unsafe void RemoveNotifyEvent (global::Com.Baidu.Location.BDNotifyListener p0)
		{
			if (id_removeNotifyEvent_Lcom_baidu_location_BDNotifyListener_ == IntPtr.Zero)
				id_removeNotifyEvent_Lcom_baidu_location_BDNotifyListener_ = JNIEnv.GetMethodID (class_ref, "removeNotifyEvent", "(Lcom/baidu/location/BDNotifyListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeNotifyEvent_Lcom_baidu_location_BDNotifyListener_, __args);
			} finally {
			}
		}

		static IntPtr id_requestHotSpotState;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='requestHotSpotState' and count(parameter)=0]"
		[Register ("requestHotSpotState", "()Z", "")]
		public unsafe bool RequestHotSpotState ()
		{
			if (id_requestHotSpotState == IntPtr.Zero)
				id_requestHotSpotState = JNIEnv.GetMethodID (class_ref, "requestHotSpotState", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_requestHotSpotState);
			} finally {
			}
		}

		static IntPtr id_requestLocation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='requestLocation' and count(parameter)=0]"
		[Register ("requestLocation", "()I", "")]
		public unsafe int RequestLocation ()
		{
			if (id_requestLocation == IntPtr.Zero)
				id_requestLocation = JNIEnv.GetMethodID (class_ref, "requestLocation", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_requestLocation);
			} finally {
			}
		}

		static IntPtr id_requestNotifyLocation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='requestNotifyLocation' and count(parameter)=0]"
		[Register ("requestNotifyLocation", "()V", "")]
		public unsafe void RequestNotifyLocation ()
		{
			if (id_requestNotifyLocation == IntPtr.Zero)
				id_requestNotifyLocation = JNIEnv.GetMethodID (class_ref, "requestNotifyLocation", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestNotifyLocation);
			} finally {
			}
		}

		static IntPtr id_requestOfflineLocation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='requestOfflineLocation' and count(parameter)=0]"
		[Register ("requestOfflineLocation", "()I", "")]
		public unsafe int RequestOfflineLocation ()
		{
			if (id_requestOfflineLocation == IntPtr.Zero)
				id_requestOfflineLocation = JNIEnv.GetMethodID (class_ref, "requestOfflineLocation", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_requestOfflineLocation);
			} finally {
			}
		}

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "")]
		public unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
			} finally {
			}
		}

		static IntPtr id_startIndoorMode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='startIndoorMode' and count(parameter)=0]"
		[Register ("startIndoorMode", "()Z", "")]
		public unsafe bool StartIndoorMode ()
		{
			if (id_startIndoorMode == IntPtr.Zero)
				id_startIndoorMode = JNIEnv.GetMethodID (class_ref, "startIndoorMode", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_startIndoorMode);
			} finally {
			}
		}

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "")]
		public unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
			} finally {
			}
		}

		static IntPtr id_stopIndoorMode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='stopIndoorMode' and count(parameter)=0]"
		[Register ("stopIndoorMode", "()Z", "")]
		public unsafe bool StopIndoorMode ()
		{
			if (id_stopIndoorMode == IntPtr.Zero)
				id_stopIndoorMode = JNIEnv.GetMethodID (class_ref, "stopIndoorMode", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_stopIndoorMode);
			} finally {
			}
		}

		static IntPtr id_unRegisterLocationListener_Lcom_baidu_location_BDLocationListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='unRegisterLocationListener' and count(parameter)=1 and parameter[1][@type='com.baidu.location.BDLocationListener']]"
		[Register ("unRegisterLocationListener", "(Lcom/baidu/location/BDLocationListener;)V", "")]
		public unsafe void UnRegisterLocationListener (global::Com.Baidu.Location.IBDLocationListener p0)
		{
			if (id_unRegisterLocationListener_Lcom_baidu_location_BDLocationListener_ == IntPtr.Zero)
				id_unRegisterLocationListener_Lcom_baidu_location_BDLocationListener_ = JNIEnv.GetMethodID (class_ref, "unRegisterLocationListener", "(Lcom/baidu/location/BDLocationListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unRegisterLocationListener_Lcom_baidu_location_BDLocationListener_, __args);
			} finally {
			}
		}

		static IntPtr id_updateLocation_Landroid_location_Location_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='updateLocation' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
		[Register ("updateLocation", "(Landroid/location/Location;)Z", "")]
		public unsafe bool UpdateLocation (global::Android.Locations.Location p0)
		{
			if (id_updateLocation_Landroid_location_Location_ == IntPtr.Zero)
				id_updateLocation_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "updateLocation", "(Landroid/location/Location;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_updateLocation_Landroid_location_Location_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
