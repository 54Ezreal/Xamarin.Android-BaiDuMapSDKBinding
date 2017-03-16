using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Arc']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/Arc", DoNotGenerateAcw=true)]
	public sealed partial class Arc : global::Com.Baidu.Mapapi.Map.Overlay {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/Arc", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Arc); }
		}

		internal Arc (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getColor;
		static IntPtr id_setColor_I;
		public unsafe int Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Arc']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()I", "GetGetColorHandler")]
			get {
				if (id_getColor == IntPtr.Zero)
					id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getColor);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Arc']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setColor", "(I)V", "GetSetColor_IHandler")]
			set {
				if (id_setColor_I == IntPtr.Zero)
					id_setColor_I = JNIEnv.GetMethodID (class_ref, "setColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setColor_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getEndPoint;
		public unsafe global::Com.Baidu.Mapapi.Model.LatLng EndPoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Arc']/method[@name='getEndPoint' and count(parameter)=0]"
			[Register ("getEndPoint", "()Lcom/baidu/mapapi/model/LatLng;", "GetGetEndPointHandler")]
			get {
				if (id_getEndPoint == IntPtr.Zero)
					id_getEndPoint = JNIEnv.GetMethodID (class_ref, "getEndPoint", "()Lcom/baidu/mapapi/model/LatLng;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEndPoint), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMiddlePoint;
		public unsafe global::Com.Baidu.Mapapi.Model.LatLng MiddlePoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Arc']/method[@name='getMiddlePoint' and count(parameter)=0]"
			[Register ("getMiddlePoint", "()Lcom/baidu/mapapi/model/LatLng;", "GetGetMiddlePointHandler")]
			get {
				if (id_getMiddlePoint == IntPtr.Zero)
					id_getMiddlePoint = JNIEnv.GetMethodID (class_ref, "getMiddlePoint", "()Lcom/baidu/mapapi/model/LatLng;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMiddlePoint), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getStartPoint;
		public unsafe global::Com.Baidu.Mapapi.Model.LatLng StartPoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Arc']/method[@name='getStartPoint' and count(parameter)=0]"
			[Register ("getStartPoint", "()Lcom/baidu/mapapi/model/LatLng;", "GetGetStartPointHandler")]
			get {
				if (id_getStartPoint == IntPtr.Zero)
					id_getStartPoint = JNIEnv.GetMethodID (class_ref, "getStartPoint", "()Lcom/baidu/mapapi/model/LatLng;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStartPoint), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getWidth;
		static IntPtr id_setWidth_I;
		public unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Arc']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWidth);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Arc']/method[@name='setWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setWidth", "(I)V", "GetSetWidth_IHandler")]
			set {
				if (id_setWidth_I == IntPtr.Zero)
					id_setWidth_I = JNIEnv.GetMethodID (class_ref, "setWidth", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWidth_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_setPoints_Lcom_baidu_mapapi_model_LatLng_Lcom_baidu_mapapi_model_LatLng_Lcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Arc']/method[@name='setPoints' and count(parameter)=3 and parameter[1][@type='com.baidu.mapapi.model.LatLng'] and parameter[2][@type='com.baidu.mapapi.model.LatLng'] and parameter[3][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("setPoints", "(Lcom/baidu/mapapi/model/LatLng;Lcom/baidu/mapapi/model/LatLng;Lcom/baidu/mapapi/model/LatLng;)V", "")]
		public unsafe void SetPoints (global::Com.Baidu.Mapapi.Model.LatLng p0, global::Com.Baidu.Mapapi.Model.LatLng p1, global::Com.Baidu.Mapapi.Model.LatLng p2)
		{
			if (id_setPoints_Lcom_baidu_mapapi_model_LatLng_Lcom_baidu_mapapi_model_LatLng_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_setPoints_Lcom_baidu_mapapi_model_LatLng_Lcom_baidu_mapapi_model_LatLng_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "setPoints", "(Lcom/baidu/mapapi/model/LatLng;Lcom/baidu/mapapi/model/LatLng;Lcom/baidu/mapapi/model/LatLng;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPoints_Lcom_baidu_mapapi_model_LatLng_Lcom_baidu_mapapi_model_LatLng_Lcom_baidu_mapapi_model_LatLng_, __args);
			} finally {
			}
		}

	}
}
