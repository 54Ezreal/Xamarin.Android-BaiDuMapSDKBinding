using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Circle']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/Circle", DoNotGenerateAcw=true)]
	public sealed partial class Circle : global::Com.Baidu.Mapapi.Map.Overlay {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/Circle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Circle); }
		}

		internal Circle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getCenter;
		static IntPtr id_setCenter_Lcom_baidu_mapapi_model_LatLng_;
		public unsafe global::Com.Baidu.Mapapi.Model.LatLng Center {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Circle']/method[@name='getCenter' and count(parameter)=0]"
			[Register ("getCenter", "()Lcom/baidu/mapapi/model/LatLng;", "GetGetCenterHandler")]
			get {
				if (id_getCenter == IntPtr.Zero)
					id_getCenter = JNIEnv.GetMethodID (class_ref, "getCenter", "()Lcom/baidu/mapapi/model/LatLng;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCenter), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Circle']/method[@name='setCenter' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
			[Register ("setCenter", "(Lcom/baidu/mapapi/model/LatLng;)V", "GetSetCenter_Lcom_baidu_mapapi_model_LatLng_Handler")]
			set {
				if (id_setCenter_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
					id_setCenter_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "setCenter", "(Lcom/baidu/mapapi/model/LatLng;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCenter_Lcom_baidu_mapapi_model_LatLng_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getFillColor;
		static IntPtr id_setFillColor_I;
		public unsafe int FillColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Circle']/method[@name='getFillColor' and count(parameter)=0]"
			[Register ("getFillColor", "()I", "GetGetFillColorHandler")]
			get {
				if (id_getFillColor == IntPtr.Zero)
					id_getFillColor = JNIEnv.GetMethodID (class_ref, "getFillColor", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFillColor);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Circle']/method[@name='setFillColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFillColor", "(I)V", "GetSetFillColor_IHandler")]
			set {
				if (id_setFillColor_I == IntPtr.Zero)
					id_setFillColor_I = JNIEnv.GetMethodID (class_ref, "setFillColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFillColor_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getRadius;
		static IntPtr id_setRadius_I;
		public unsafe int Radius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Circle']/method[@name='getRadius' and count(parameter)=0]"
			[Register ("getRadius", "()I", "GetGetRadiusHandler")]
			get {
				if (id_getRadius == IntPtr.Zero)
					id_getRadius = JNIEnv.GetMethodID (class_ref, "getRadius", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRadius);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Circle']/method[@name='setRadius' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRadius", "(I)V", "GetSetRadius_IHandler")]
			set {
				if (id_setRadius_I == IntPtr.Zero)
					id_setRadius_I = JNIEnv.GetMethodID (class_ref, "setRadius", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRadius_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getStroke;
		static IntPtr id_setStroke_Lcom_baidu_mapapi_map_Stroke_;
		public unsafe global::Com.Baidu.Mapapi.Map.Stroke Stroke {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Circle']/method[@name='getStroke' and count(parameter)=0]"
			[Register ("getStroke", "()Lcom/baidu/mapapi/map/Stroke;", "GetGetStrokeHandler")]
			get {
				if (id_getStroke == IntPtr.Zero)
					id_getStroke = JNIEnv.GetMethodID (class_ref, "getStroke", "()Lcom/baidu/mapapi/map/Stroke;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Stroke> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStroke), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Circle']/method[@name='setStroke' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.Stroke']]"
			[Register ("setStroke", "(Lcom/baidu/mapapi/map/Stroke;)V", "GetSetStroke_Lcom_baidu_mapapi_map_Stroke_Handler")]
			set {
				if (id_setStroke_Lcom_baidu_mapapi_map_Stroke_ == IntPtr.Zero)
					id_setStroke_Lcom_baidu_mapapi_map_Stroke_ = JNIEnv.GetMethodID (class_ref, "setStroke", "(Lcom/baidu/mapapi/map/Stroke;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStroke_Lcom_baidu_mapapi_map_Stroke_, __args);
				} finally {
				}
			}
		}

	}
}
