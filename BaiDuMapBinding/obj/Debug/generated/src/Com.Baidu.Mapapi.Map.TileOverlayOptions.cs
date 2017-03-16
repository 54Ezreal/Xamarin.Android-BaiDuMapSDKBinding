using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TileOverlayOptions']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/TileOverlayOptions", DoNotGenerateAcw=true)]
	public sealed partial class TileOverlayOptions : global::Java.Lang.Object {


		static IntPtr datasource_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TileOverlayOptions']/field[@name='datasource']"
		[Register ("datasource")]
		public int Datasource {
			get {
				if (datasource_jfieldId == IntPtr.Zero)
					datasource_jfieldId = JNIEnv.GetFieldID (class_ref, "datasource", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, datasource_jfieldId);
			}
			set {
				if (datasource_jfieldId == IntPtr.Zero)
					datasource_jfieldId = JNIEnv.GetFieldID (class_ref, "datasource", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, datasource_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr urlString_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TileOverlayOptions']/field[@name='urlString']"
		[Register ("urlString")]
		public string UrlString {
			get {
				if (urlString_jfieldId == IntPtr.Zero)
					urlString_jfieldId = JNIEnv.GetFieldID (class_ref, "urlString", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, urlString_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (urlString_jfieldId == IntPtr.Zero)
					urlString_jfieldId = JNIEnv.GetFieldID (class_ref, "urlString", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, urlString_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/TileOverlayOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TileOverlayOptions); }
		}

		internal TileOverlayOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TileOverlayOptions']/constructor[@name='TileOverlayOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TileOverlayOptions ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TileOverlayOptions)) {
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

		static IntPtr id_setMaxTileTmp_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TileOverlayOptions']/method[@name='setMaxTileTmp' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaxTileTmp", "(I)Lcom/baidu/mapapi/map/TileOverlayOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.TileOverlayOptions SetMaxTileTmp (int p0)
		{
			if (id_setMaxTileTmp_I == IntPtr.Zero)
				id_setMaxTileTmp_I = JNIEnv.GetMethodID (class_ref, "setMaxTileTmp", "(I)Lcom/baidu/mapapi/map/TileOverlayOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TileOverlayOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMaxTileTmp_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setPositionFromBounds_Lcom_baidu_mapapi_model_LatLngBounds_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TileOverlayOptions']/method[@name='setPositionFromBounds' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLngBounds']]"
		[Register ("setPositionFromBounds", "(Lcom/baidu/mapapi/model/LatLngBounds;)Lcom/baidu/mapapi/map/TileOverlayOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.TileOverlayOptions SetPositionFromBounds (global::Com.Baidu.Mapapi.Model.LatLngBounds p0)
		{
			if (id_setPositionFromBounds_Lcom_baidu_mapapi_model_LatLngBounds_ == IntPtr.Zero)
				id_setPositionFromBounds_Lcom_baidu_mapapi_model_LatLngBounds_ = JNIEnv.GetMethodID (class_ref, "setPositionFromBounds", "(Lcom/baidu/mapapi/model/LatLngBounds;)Lcom/baidu/mapapi/map/TileOverlayOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.TileOverlayOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TileOverlayOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPositionFromBounds_Lcom_baidu_mapapi_model_LatLngBounds_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_tileProvider_Lcom_baidu_mapapi_map_TileProvider_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TileOverlayOptions']/method[@name='tileProvider' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.TileProvider']]"
		[Register ("tileProvider", "(Lcom/baidu/mapapi/map/TileProvider;)Lcom/baidu/mapapi/map/TileOverlayOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.TileOverlayOptions TileProvider (global::Com.Baidu.Mapapi.Map.ITileProvider p0)
		{
			if (id_tileProvider_Lcom_baidu_mapapi_map_TileProvider_ == IntPtr.Zero)
				id_tileProvider_Lcom_baidu_mapapi_map_TileProvider_ = JNIEnv.GetMethodID (class_ref, "tileProvider", "(Lcom/baidu/mapapi/map/TileProvider;)Lcom/baidu/mapapi/map/TileOverlayOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.TileOverlayOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TileOverlayOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_tileProvider_Lcom_baidu_mapapi_map_TileProvider_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
