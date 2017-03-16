using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatusUpdateFactory']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/MapStatusUpdateFactory", DoNotGenerateAcw=true)]
	public sealed partial class MapStatusUpdateFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/MapStatusUpdateFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapStatusUpdateFactory); }
		}

		internal MapStatusUpdateFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_newLatLng_Lcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatusUpdateFactory']/method[@name='newLatLng' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("newLatLng", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/map/MapStatusUpdate;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.MapStatusUpdate NewLatLng (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			if (id_newLatLng_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_newLatLng_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetStaticMethodID (class_ref, "newLatLng", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/map/MapStatusUpdate;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.MapStatusUpdate __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatusUpdate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newLatLng_Lcom_baidu_mapapi_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newLatLngBounds_Lcom_baidu_mapapi_model_LatLngBounds_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatusUpdateFactory']/method[@name='newLatLngBounds' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLngBounds']]"
		[Register ("newLatLngBounds", "(Lcom/baidu/mapapi/model/LatLngBounds;)Lcom/baidu/mapapi/map/MapStatusUpdate;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.MapStatusUpdate NewLatLngBounds (global::Com.Baidu.Mapapi.Model.LatLngBounds p0)
		{
			if (id_newLatLngBounds_Lcom_baidu_mapapi_model_LatLngBounds_ == IntPtr.Zero)
				id_newLatLngBounds_Lcom_baidu_mapapi_model_LatLngBounds_ = JNIEnv.GetStaticMethodID (class_ref, "newLatLngBounds", "(Lcom/baidu/mapapi/model/LatLngBounds;)Lcom/baidu/mapapi/map/MapStatusUpdate;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.MapStatusUpdate __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatusUpdate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newLatLngBounds_Lcom_baidu_mapapi_model_LatLngBounds_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newLatLngBounds_Lcom_baidu_mapapi_model_LatLngBounds_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatusUpdateFactory']/method[@name='newLatLngBounds' and count(parameter)=3 and parameter[1][@type='com.baidu.mapapi.model.LatLngBounds'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("newLatLngBounds", "(Lcom/baidu/mapapi/model/LatLngBounds;II)Lcom/baidu/mapapi/map/MapStatusUpdate;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.MapStatusUpdate NewLatLngBounds (global::Com.Baidu.Mapapi.Model.LatLngBounds p0, int p1, int p2)
		{
			if (id_newLatLngBounds_Lcom_baidu_mapapi_model_LatLngBounds_II == IntPtr.Zero)
				id_newLatLngBounds_Lcom_baidu_mapapi_model_LatLngBounds_II = JNIEnv.GetStaticMethodID (class_ref, "newLatLngBounds", "(Lcom/baidu/mapapi/model/LatLngBounds;II)Lcom/baidu/mapapi/map/MapStatusUpdate;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.Baidu.Mapapi.Map.MapStatusUpdate __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatusUpdate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newLatLngBounds_Lcom_baidu_mapapi_model_LatLngBounds_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newLatLngZoom_Lcom_baidu_mapapi_model_LatLng_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatusUpdateFactory']/method[@name='newLatLngZoom' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.model.LatLng'] and parameter[2][@type='float']]"
		[Register ("newLatLngZoom", "(Lcom/baidu/mapapi/model/LatLng;F)Lcom/baidu/mapapi/map/MapStatusUpdate;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.MapStatusUpdate NewLatLngZoom (global::Com.Baidu.Mapapi.Model.LatLng p0, float p1)
		{
			if (id_newLatLngZoom_Lcom_baidu_mapapi_model_LatLng_F == IntPtr.Zero)
				id_newLatLngZoom_Lcom_baidu_mapapi_model_LatLng_F = JNIEnv.GetStaticMethodID (class_ref, "newLatLngZoom", "(Lcom/baidu/mapapi/model/LatLng;F)Lcom/baidu/mapapi/map/MapStatusUpdate;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Baidu.Mapapi.Map.MapStatusUpdate __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatusUpdate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newLatLngZoom_Lcom_baidu_mapapi_model_LatLng_F, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newMapStatus_Lcom_baidu_mapapi_map_MapStatus_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatusUpdateFactory']/method[@name='newMapStatus' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MapStatus']]"
		[Register ("newMapStatus", "(Lcom/baidu/mapapi/map/MapStatus;)Lcom/baidu/mapapi/map/MapStatusUpdate;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.MapStatusUpdate NewMapStatus (global::Com.Baidu.Mapapi.Map.MapStatus p0)
		{
			if (id_newMapStatus_Lcom_baidu_mapapi_map_MapStatus_ == IntPtr.Zero)
				id_newMapStatus_Lcom_baidu_mapapi_map_MapStatus_ = JNIEnv.GetStaticMethodID (class_ref, "newMapStatus", "(Lcom/baidu/mapapi/map/MapStatus;)Lcom/baidu/mapapi/map/MapStatusUpdate;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.MapStatusUpdate __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatusUpdate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newMapStatus_Lcom_baidu_mapapi_map_MapStatus_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_scrollBy_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatusUpdateFactory']/method[@name='scrollBy' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("scrollBy", "(II)Lcom/baidu/mapapi/map/MapStatusUpdate;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.MapStatusUpdate ScrollBy (int p0, int p1)
		{
			if (id_scrollBy_II == IntPtr.Zero)
				id_scrollBy_II = JNIEnv.GetStaticMethodID (class_ref, "scrollBy", "(II)Lcom/baidu/mapapi/map/MapStatusUpdate;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatusUpdate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_scrollBy_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_zoomBy_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatusUpdateFactory']/method[@name='zoomBy' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("zoomBy", "(F)Lcom/baidu/mapapi/map/MapStatusUpdate;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.MapStatusUpdate ZoomBy (float p0)
		{
			if (id_zoomBy_F == IntPtr.Zero)
				id_zoomBy_F = JNIEnv.GetStaticMethodID (class_ref, "zoomBy", "(F)Lcom/baidu/mapapi/map/MapStatusUpdate;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatusUpdate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zoomBy_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_zoomBy_FLandroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatusUpdateFactory']/method[@name='zoomBy' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='android.graphics.Point']]"
		[Register ("zoomBy", "(FLandroid/graphics/Point;)Lcom/baidu/mapapi/map/MapStatusUpdate;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.MapStatusUpdate ZoomBy (float p0, global::Android.Graphics.Point p1)
		{
			if (id_zoomBy_FLandroid_graphics_Point_ == IntPtr.Zero)
				id_zoomBy_FLandroid_graphics_Point_ = JNIEnv.GetStaticMethodID (class_ref, "zoomBy", "(FLandroid/graphics/Point;)Lcom/baidu/mapapi/map/MapStatusUpdate;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Baidu.Mapapi.Map.MapStatusUpdate __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatusUpdate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zoomBy_FLandroid_graphics_Point_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zoomIn;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatusUpdateFactory']/method[@name='zoomIn' and count(parameter)=0]"
		[Register ("zoomIn", "()Lcom/baidu/mapapi/map/MapStatusUpdate;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.MapStatusUpdate ZoomIn ()
		{
			if (id_zoomIn == IntPtr.Zero)
				id_zoomIn = JNIEnv.GetStaticMethodID (class_ref, "zoomIn", "()Lcom/baidu/mapapi/map/MapStatusUpdate;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatusUpdate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zoomIn), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_zoomOut;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatusUpdateFactory']/method[@name='zoomOut' and count(parameter)=0]"
		[Register ("zoomOut", "()Lcom/baidu/mapapi/map/MapStatusUpdate;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.MapStatusUpdate ZoomOut ()
		{
			if (id_zoomOut == IntPtr.Zero)
				id_zoomOut = JNIEnv.GetStaticMethodID (class_ref, "zoomOut", "()Lcom/baidu/mapapi/map/MapStatusUpdate;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatusUpdate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zoomOut), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_zoomTo_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatusUpdateFactory']/method[@name='zoomTo' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("zoomTo", "(F)Lcom/baidu/mapapi/map/MapStatusUpdate;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.MapStatusUpdate ZoomTo (float p0)
		{
			if (id_zoomTo_F == IntPtr.Zero)
				id_zoomTo_F = JNIEnv.GetStaticMethodID (class_ref, "zoomTo", "(F)Lcom/baidu/mapapi/map/MapStatusUpdate;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatusUpdate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zoomTo_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
