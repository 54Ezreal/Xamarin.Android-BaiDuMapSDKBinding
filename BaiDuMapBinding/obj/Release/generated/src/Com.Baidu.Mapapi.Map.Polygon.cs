using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polygon']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/Polygon", DoNotGenerateAcw=true)]
	public sealed partial class Polygon : global::Com.Baidu.Mapapi.Map.Overlay {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/Polygon", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Polygon); }
		}

		internal Polygon (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getFillColor;
		static IntPtr id_setFillColor_I;
		public unsafe int FillColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polygon']/method[@name='getFillColor' and count(parameter)=0]"
			[Register ("getFillColor", "()I", "GetGetFillColorHandler")]
			get {
				if (id_getFillColor == IntPtr.Zero)
					id_getFillColor = JNIEnv.GetMethodID (class_ref, "getFillColor", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFillColor);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polygon']/method[@name='setFillColor' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static IntPtr id_getPoints;
		static IntPtr id_setPoints_Ljava_util_List_;
		public unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Model.LatLng> Points {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polygon']/method[@name='getPoints' and count(parameter)=0]"
			[Register ("getPoints", "()Ljava/util/List;", "GetGetPointsHandler")]
			get {
				if (id_getPoints == IntPtr.Zero)
					id_getPoints = JNIEnv.GetMethodID (class_ref, "getPoints", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Model.LatLng>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPoints), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polygon']/method[@name='setPoints' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.baidu.mapapi.model.LatLng&gt;']]"
			[Register ("setPoints", "(Ljava/util/List;)V", "GetSetPoints_Ljava_util_List_Handler")]
			set {
				if (id_setPoints_Ljava_util_List_ == IntPtr.Zero)
					id_setPoints_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setPoints", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Model.LatLng>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPoints_Ljava_util_List_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getStroke;
		static IntPtr id_setStroke_Lcom_baidu_mapapi_map_Stroke_;
		public unsafe global::Com.Baidu.Mapapi.Map.Stroke Stroke {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polygon']/method[@name='getStroke' and count(parameter)=0]"
			[Register ("getStroke", "()Lcom/baidu/mapapi/map/Stroke;", "GetGetStrokeHandler")]
			get {
				if (id_getStroke == IntPtr.Zero)
					id_getStroke = JNIEnv.GetMethodID (class_ref, "getStroke", "()Lcom/baidu/mapapi/map/Stroke;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Stroke> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStroke), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polygon']/method[@name='setStroke' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.Stroke']]"
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
