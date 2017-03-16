using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Dot']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/Dot", DoNotGenerateAcw=true)]
	public sealed partial class Dot : global::Com.Baidu.Mapapi.Map.Overlay {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/Dot", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Dot); }
		}

		internal Dot (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getCenter;
		static IntPtr id_setCenter_Lcom_baidu_mapapi_model_LatLng_;
		public unsafe global::Com.Baidu.Mapapi.Model.LatLng Center {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Dot']/method[@name='getCenter' and count(parameter)=0]"
			[Register ("getCenter", "()Lcom/baidu/mapapi/model/LatLng;", "GetGetCenterHandler")]
			get {
				if (id_getCenter == IntPtr.Zero)
					id_getCenter = JNIEnv.GetMethodID (class_ref, "getCenter", "()Lcom/baidu/mapapi/model/LatLng;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCenter), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Dot']/method[@name='setCenter' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
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

		static IntPtr id_getColor;
		static IntPtr id_setColor_I;
		public unsafe int Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Dot']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()I", "GetGetColorHandler")]
			get {
				if (id_getColor == IntPtr.Zero)
					id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getColor);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Dot']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static IntPtr id_getRadius;
		static IntPtr id_setRadius_I;
		public unsafe int Radius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Dot']/method[@name='getRadius' and count(parameter)=0]"
			[Register ("getRadius", "()I", "GetGetRadiusHandler")]
			get {
				if (id_getRadius == IntPtr.Zero)
					id_getRadius = JNIEnv.GetMethodID (class_ref, "getRadius", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRadius);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Dot']/method[@name='setRadius' and count(parameter)=1 and parameter[1][@type='int']]"
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

	}
}
