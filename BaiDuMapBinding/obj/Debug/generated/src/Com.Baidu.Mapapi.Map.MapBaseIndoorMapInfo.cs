using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/MapBaseIndoorMapInfo", DoNotGenerateAcw=true)]
	public sealed partial class MapBaseIndoorMapInfo : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo.SwitchFloorError']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/map/MapBaseIndoorMapInfo$SwitchFloorError", DoNotGenerateAcw=true)]
		public sealed partial class SwitchFloorError : global::Java.Lang.Enum {


			static IntPtr FLOOR_INFO_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo.SwitchFloorError']/field[@name='FLOOR_INFO_ERROR']"
			[Register ("FLOOR_INFO_ERROR")]
			public static global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError FloorInfoError {
				get {
					if (FLOOR_INFO_ERROR_jfieldId == IntPtr.Zero)
						FLOOR_INFO_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FLOOR_INFO_ERROR", "Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo$SwitchFloorError;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FLOOR_INFO_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FLOOR_OVERLFLOW_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo.SwitchFloorError']/field[@name='FLOOR_OVERLFLOW']"
			[Register ("FLOOR_OVERLFLOW")]
			public static global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError FloorOverlflow {
				get {
					if (FLOOR_OVERLFLOW_jfieldId == IntPtr.Zero)
						FLOOR_OVERLFLOW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FLOOR_OVERLFLOW", "Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo$SwitchFloorError;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FLOOR_OVERLFLOW_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FOCUSED_ID_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo.SwitchFloorError']/field[@name='FOCUSED_ID_ERROR']"
			[Register ("FOCUSED_ID_ERROR")]
			public static global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError FocusedIdError {
				get {
					if (FOCUSED_ID_ERROR_jfieldId == IntPtr.Zero)
						FOCUSED_ID_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FOCUSED_ID_ERROR", "Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo$SwitchFloorError;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FOCUSED_ID_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SWITCH_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo.SwitchFloorError']/field[@name='SWITCH_ERROR']"
			[Register ("SWITCH_ERROR")]
			public static global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError SwitchError {
				get {
					if (SWITCH_ERROR_jfieldId == IntPtr.Zero)
						SWITCH_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SWITCH_ERROR", "Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo$SwitchFloorError;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SWITCH_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SWITCH_OK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo.SwitchFloorError']/field[@name='SWITCH_OK']"
			[Register ("SWITCH_OK")]
			public static global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError SwitchOk {
				get {
					if (SWITCH_OK_jfieldId == IntPtr.Zero)
						SWITCH_OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SWITCH_OK", "Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo$SwitchFloorError;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SWITCH_OK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/mapapi/map/MapBaseIndoorMapInfo$SwitchFloorError", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SwitchFloorError); }
			}

			internal SwitchFloorError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo.SwitchFloorError']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo$SwitchFloorError;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo$SwitchFloorError;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo.SwitchFloorError']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo$SwitchFloorError;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo$SwitchFloorError;");
				try {
					return (global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/MapBaseIndoorMapInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapBaseIndoorMapInfo); }
		}

		internal MapBaseIndoorMapInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo']/constructor[@name='MapBaseIndoorMapInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MapBaseIndoorMapInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MapBaseIndoorMapInfo)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_ArrayList_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo']/constructor[@name='MapBaseIndoorMapInfo' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.ArrayList&lt;java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/ArrayList;)V", "")]
		public unsafe MapBaseIndoorMapInfo (string p0, string p1, global::System.Collections.Generic.IList<string> p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (MapBaseIndoorMapInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/util/ArrayList;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/util/ArrayList;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_ArrayList_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/ArrayList;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_ArrayList_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_ArrayList_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_Lcom_baidu_mapapi_map_MapBaseIndoorMapInfo_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo']/constructor[@name='MapBaseIndoorMapInfo' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MapBaseIndoorMapInfo']]"
		[Register (".ctor", "(Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo;)V", "")]
		public unsafe MapBaseIndoorMapInfo (global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MapBaseIndoorMapInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo;)V", __args);
					return;
				}

				if (id_ctor_Lcom_baidu_mapapi_map_MapBaseIndoorMapInfo_ == IntPtr.Zero)
					id_ctor_Lcom_baidu_mapapi_map_MapBaseIndoorMapInfo_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_baidu_mapapi_map_MapBaseIndoorMapInfo_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_baidu_mapapi_map_MapBaseIndoorMapInfo_, __args);
			} finally {
			}
		}

		static IntPtr id_getCurFloor;
		public unsafe string CurFloor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo']/method[@name='getCurFloor' and count(parameter)=0]"
			[Register ("getCurFloor", "()Ljava/lang/String;", "GetGetCurFloorHandler")]
			get {
				if (id_getCurFloor == IntPtr.Zero)
					id_getCurFloor = JNIEnv.GetMethodID (class_ref, "getCurFloor", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurFloor), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getFloors;
		public unsafe global::System.Collections.Generic.IList<string> Floors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo']/method[@name='getFloors' and count(parameter)=0]"
			[Register ("getFloors", "()Ljava/util/ArrayList;", "GetGetFloorsHandler")]
			get {
				if (id_getFloors == IntPtr.Zero)
					id_getFloors = JNIEnv.GetMethodID (class_ref, "getFloors", "()Ljava/util/ArrayList;");
				try {
					return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFloors), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getID;
		public unsafe string ID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo']/method[@name='getID' and count(parameter)=0]"
			[Register ("getID", "()Ljava/lang/String;", "GetGetIDHandler")]
			get {
				if (id_getID == IntPtr.Zero)
					id_getID = JNIEnv.GetMethodID (class_ref, "getID", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getID), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
