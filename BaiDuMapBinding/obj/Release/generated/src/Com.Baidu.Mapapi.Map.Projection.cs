using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Projection']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/Projection", DoNotGenerateAcw=true)]
	public sealed partial class Projection : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/Projection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Projection); }
		}

		internal Projection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_fromScreenLocation_Landroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Projection']/method[@name='fromScreenLocation' and count(parameter)=1 and parameter[1][@type='android.graphics.Point']]"
		[Register ("fromScreenLocation", "(Landroid/graphics/Point;)Lcom/baidu/mapapi/model/LatLng;", "")]
		public unsafe global::Com.Baidu.Mapapi.Model.LatLng FromScreenLocation (global::Android.Graphics.Point p0)
		{
			if (id_fromScreenLocation_Landroid_graphics_Point_ == IntPtr.Zero)
				id_fromScreenLocation_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "fromScreenLocation", "(Landroid/graphics/Point;)Lcom/baidu/mapapi/model/LatLng;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Model.LatLng __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fromScreenLocation_Landroid_graphics_Point_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_metersToEquatorPixels_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Projection']/method[@name='metersToEquatorPixels' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("metersToEquatorPixels", "(F)F", "")]
		public unsafe float MetersToEquatorPixels (float p0)
		{
			if (id_metersToEquatorPixels_F == IntPtr.Zero)
				id_metersToEquatorPixels_F = JNIEnv.GetMethodID (class_ref, "metersToEquatorPixels", "(F)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_metersToEquatorPixels_F, __args);
			} finally {
			}
		}

		static IntPtr id_toOpenGLLocation_Lcom_baidu_mapapi_model_LatLng_Lcom_baidu_mapapi_map_MapStatus_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Projection']/method[@name='toOpenGLLocation' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.model.LatLng'] and parameter[2][@type='com.baidu.mapapi.map.MapStatus']]"
		[Register ("toOpenGLLocation", "(Lcom/baidu/mapapi/model/LatLng;Lcom/baidu/mapapi/map/MapStatus;)Landroid/graphics/PointF;", "")]
		public unsafe global::Android.Graphics.PointF ToOpenGLLocation (global::Com.Baidu.Mapapi.Model.LatLng p0, global::Com.Baidu.Mapapi.Map.MapStatus p1)
		{
			if (id_toOpenGLLocation_Lcom_baidu_mapapi_model_LatLng_Lcom_baidu_mapapi_map_MapStatus_ == IntPtr.Zero)
				id_toOpenGLLocation_Lcom_baidu_mapapi_model_LatLng_Lcom_baidu_mapapi_map_MapStatus_ = JNIEnv.GetMethodID (class_ref, "toOpenGLLocation", "(Lcom/baidu/mapapi/model/LatLng;Lcom/baidu/mapapi/map/MapStatus;)Landroid/graphics/PointF;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Graphics.PointF __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toOpenGLLocation_Lcom_baidu_mapapi_model_LatLng_Lcom_baidu_mapapi_map_MapStatus_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toOpenGLNormalization_Lcom_baidu_mapapi_model_LatLng_Lcom_baidu_mapapi_map_MapStatus_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Projection']/method[@name='toOpenGLNormalization' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.model.LatLng'] and parameter[2][@type='com.baidu.mapapi.map.MapStatus']]"
		[Register ("toOpenGLNormalization", "(Lcom/baidu/mapapi/model/LatLng;Lcom/baidu/mapapi/map/MapStatus;)Landroid/graphics/PointF;", "")]
		public unsafe global::Android.Graphics.PointF ToOpenGLNormalization (global::Com.Baidu.Mapapi.Model.LatLng p0, global::Com.Baidu.Mapapi.Map.MapStatus p1)
		{
			if (id_toOpenGLNormalization_Lcom_baidu_mapapi_model_LatLng_Lcom_baidu_mapapi_map_MapStatus_ == IntPtr.Zero)
				id_toOpenGLNormalization_Lcom_baidu_mapapi_model_LatLng_Lcom_baidu_mapapi_map_MapStatus_ = JNIEnv.GetMethodID (class_ref, "toOpenGLNormalization", "(Lcom/baidu/mapapi/model/LatLng;Lcom/baidu/mapapi/map/MapStatus;)Landroid/graphics/PointF;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Graphics.PointF __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toOpenGLNormalization_Lcom_baidu_mapapi_model_LatLng_Lcom_baidu_mapapi_map_MapStatus_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toScreenLocation_Lcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Projection']/method[@name='toScreenLocation' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("toScreenLocation", "(Lcom/baidu/mapapi/model/LatLng;)Landroid/graphics/Point;", "")]
		public unsafe global::Android.Graphics.Point ToScreenLocation (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			if (id_toScreenLocation_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_toScreenLocation_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "toScreenLocation", "(Lcom/baidu/mapapi/model/LatLng;)Landroid/graphics/Point;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Graphics.Point __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toScreenLocation_Lcom_baidu_mapapi_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
