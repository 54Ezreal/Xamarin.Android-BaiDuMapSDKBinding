using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationConfiguration']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/MyLocationConfiguration", DoNotGenerateAcw=true)]
	public partial class MyLocationConfiguration : global::Java.Lang.Object {


		static IntPtr accuracyCircleFillColor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationConfiguration']/field[@name='accuracyCircleFillColor']"
		[Register ("accuracyCircleFillColor")]
		public int AccuracyCircleFillColor {
			get {
				if (accuracyCircleFillColor_jfieldId == IntPtr.Zero)
					accuracyCircleFillColor_jfieldId = JNIEnv.GetFieldID (class_ref, "accuracyCircleFillColor", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, accuracyCircleFillColor_jfieldId);
			}
			set {
				if (accuracyCircleFillColor_jfieldId == IntPtr.Zero)
					accuracyCircleFillColor_jfieldId = JNIEnv.GetFieldID (class_ref, "accuracyCircleFillColor", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, accuracyCircleFillColor_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr accuracyCircleStrokeColor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationConfiguration']/field[@name='accuracyCircleStrokeColor']"
		[Register ("accuracyCircleStrokeColor")]
		public int AccuracyCircleStrokeColor {
			get {
				if (accuracyCircleStrokeColor_jfieldId == IntPtr.Zero)
					accuracyCircleStrokeColor_jfieldId = JNIEnv.GetFieldID (class_ref, "accuracyCircleStrokeColor", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, accuracyCircleStrokeColor_jfieldId);
			}
			set {
				if (accuracyCircleStrokeColor_jfieldId == IntPtr.Zero)
					accuracyCircleStrokeColor_jfieldId = JNIEnv.GetFieldID (class_ref, "accuracyCircleStrokeColor", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, accuracyCircleStrokeColor_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr customMarker_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationConfiguration']/field[@name='customMarker']"
		[Register ("customMarker")]
		public global::Com.Baidu.Mapapi.Map.BitmapDescriptor CustomMarker {
			get {
				if (customMarker_jfieldId == IntPtr.Zero)
					customMarker_jfieldId = JNIEnv.GetFieldID (class_ref, "customMarker", "Lcom/baidu/mapapi/map/BitmapDescriptor;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, customMarker_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (customMarker_jfieldId == IntPtr.Zero)
					customMarker_jfieldId = JNIEnv.GetFieldID (class_ref, "customMarker", "Lcom/baidu/mapapi/map/BitmapDescriptor;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, customMarker_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr enableDirection_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationConfiguration']/field[@name='enableDirection']"
		[Register ("enableDirection")]
		public bool EnableDirection {
			get {
				if (enableDirection_jfieldId == IntPtr.Zero)
					enableDirection_jfieldId = JNIEnv.GetFieldID (class_ref, "enableDirection", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, enableDirection_jfieldId);
			}
			set {
				if (enableDirection_jfieldId == IntPtr.Zero)
					enableDirection_jfieldId = JNIEnv.GetFieldID (class_ref, "enableDirection", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, enableDirection_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationConfiguration.LocationMode']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/map/MyLocationConfiguration$LocationMode", DoNotGenerateAcw=true)]
		public sealed partial class LocationMode : global::Java.Lang.Enum {


			static IntPtr COMPASS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationConfiguration.LocationMode']/field[@name='COMPASS']"
			[Register ("COMPASS")]
			public static global::Com.Baidu.Mapapi.Map.MyLocationConfiguration.LocationMode Compass {
				get {
					if (COMPASS_jfieldId == IntPtr.Zero)
						COMPASS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPASS", "Lcom/baidu/mapapi/map/MyLocationConfiguration$LocationMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMPASS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationConfiguration.LocationMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FOLLOWING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationConfiguration.LocationMode']/field[@name='FOLLOWING']"
			[Register ("FOLLOWING")]
			public static global::Com.Baidu.Mapapi.Map.MyLocationConfiguration.LocationMode Following {
				get {
					if (FOLLOWING_jfieldId == IntPtr.Zero)
						FOLLOWING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FOLLOWING", "Lcom/baidu/mapapi/map/MyLocationConfiguration$LocationMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FOLLOWING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationConfiguration.LocationMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NORMAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationConfiguration.LocationMode']/field[@name='NORMAL']"
			[Register ("NORMAL")]
			public static global::Com.Baidu.Mapapi.Map.MyLocationConfiguration.LocationMode Normal {
				get {
					if (NORMAL_jfieldId == IntPtr.Zero)
						NORMAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NORMAL", "Lcom/baidu/mapapi/map/MyLocationConfiguration$LocationMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NORMAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationConfiguration.LocationMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/mapapi/map/MyLocationConfiguration$LocationMode", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationConfiguration.LocationMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/MyLocationConfiguration$LocationMode;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Map.MyLocationConfiguration.LocationMode ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/MyLocationConfiguration$LocationMode;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Baidu.Mapapi.Map.MyLocationConfiguration.LocationMode __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationConfiguration.LocationMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationConfiguration.LocationMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/baidu/mapapi/map/MyLocationConfiguration$LocationMode;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Map.MyLocationConfiguration.LocationMode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/baidu/mapapi/map/MyLocationConfiguration$LocationMode;");
				try {
					return (global::Com.Baidu.Mapapi.Map.MyLocationConfiguration.LocationMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.Map.MyLocationConfiguration.LocationMode));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/MyLocationConfiguration", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MyLocationConfiguration); }
		}

		protected MyLocationConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_baidu_mapapi_map_MyLocationConfiguration_LocationMode_ZLcom_baidu_mapapi_map_BitmapDescriptor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationConfiguration']/constructor[@name='MyLocationConfiguration' and count(parameter)=5 and parameter[1][@type='com.baidu.mapapi.map.MyLocationConfiguration.LocationMode'] and parameter[2][@type='boolean'] and parameter[3][@type='com.baidu.mapapi.map.BitmapDescriptor'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Lcom/baidu/mapapi/map/MyLocationConfiguration$LocationMode;ZLcom/baidu/mapapi/map/BitmapDescriptor;II)V", "")]
		public unsafe MyLocationConfiguration (global::Com.Baidu.Mapapi.Map.MyLocationConfiguration.LocationMode p0, bool p1, global::Com.Baidu.Mapapi.Map.BitmapDescriptor p2, int p3, int p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (((object) this).GetType () != typeof (MyLocationConfiguration)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/baidu/mapapi/map/MyLocationConfiguration$LocationMode;ZLcom/baidu/mapapi/map/BitmapDescriptor;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/baidu/mapapi/map/MyLocationConfiguration$LocationMode;ZLcom/baidu/mapapi/map/BitmapDescriptor;II)V", __args);
					return;
				}

				if (id_ctor_Lcom_baidu_mapapi_map_MyLocationConfiguration_LocationMode_ZLcom_baidu_mapapi_map_BitmapDescriptor_II == IntPtr.Zero)
					id_ctor_Lcom_baidu_mapapi_map_MyLocationConfiguration_LocationMode_ZLcom_baidu_mapapi_map_BitmapDescriptor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/baidu/mapapi/map/MyLocationConfiguration$LocationMode;ZLcom/baidu/mapapi/map/BitmapDescriptor;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_baidu_mapapi_map_MyLocationConfiguration_LocationMode_ZLcom_baidu_mapapi_map_BitmapDescriptor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_baidu_mapapi_map_MyLocationConfiguration_LocationMode_ZLcom_baidu_mapapi_map_BitmapDescriptor_II, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_baidu_mapapi_map_MyLocationConfiguration_LocationMode_ZLcom_baidu_mapapi_map_BitmapDescriptor_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationConfiguration']/constructor[@name='MyLocationConfiguration' and count(parameter)=3 and parameter[1][@type='com.baidu.mapapi.map.MyLocationConfiguration.LocationMode'] and parameter[2][@type='boolean'] and parameter[3][@type='com.baidu.mapapi.map.BitmapDescriptor']]"
		[Register (".ctor", "(Lcom/baidu/mapapi/map/MyLocationConfiguration$LocationMode;ZLcom/baidu/mapapi/map/BitmapDescriptor;)V", "")]
		public unsafe MyLocationConfiguration (global::Com.Baidu.Mapapi.Map.MyLocationConfiguration.LocationMode p0, bool p1, global::Com.Baidu.Mapapi.Map.BitmapDescriptor p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (MyLocationConfiguration)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/baidu/mapapi/map/MyLocationConfiguration$LocationMode;ZLcom/baidu/mapapi/map/BitmapDescriptor;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/baidu/mapapi/map/MyLocationConfiguration$LocationMode;ZLcom/baidu/mapapi/map/BitmapDescriptor;)V", __args);
					return;
				}

				if (id_ctor_Lcom_baidu_mapapi_map_MyLocationConfiguration_LocationMode_ZLcom_baidu_mapapi_map_BitmapDescriptor_ == IntPtr.Zero)
					id_ctor_Lcom_baidu_mapapi_map_MyLocationConfiguration_LocationMode_ZLcom_baidu_mapapi_map_BitmapDescriptor_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/baidu/mapapi/map/MyLocationConfiguration$LocationMode;ZLcom/baidu/mapapi/map/BitmapDescriptor;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_baidu_mapapi_map_MyLocationConfiguration_LocationMode_ZLcom_baidu_mapapi_map_BitmapDescriptor_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_baidu_mapapi_map_MyLocationConfiguration_LocationMode_ZLcom_baidu_mapapi_map_BitmapDescriptor_, __args);
			} finally {
			}
		}

	}
}
