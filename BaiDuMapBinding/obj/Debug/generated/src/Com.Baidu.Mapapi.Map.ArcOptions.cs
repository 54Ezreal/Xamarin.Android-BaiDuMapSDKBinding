using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='ArcOptions']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/ArcOptions", DoNotGenerateAcw=true)]
	public sealed partial class ArcOptions : global::Com.Baidu.Mapapi.Map.OverlayOptions {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/ArcOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ArcOptions); }
		}

		internal ArcOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='ArcOptions']/constructor[@name='ArcOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ArcOptions ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ArcOptions)) {
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

		static IntPtr id_getColor;
		public unsafe int Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='ArcOptions']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()I", "GetGetColorHandler")]
			get {
				if (id_getColor == IntPtr.Zero)
					id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getColor);
				} finally {
				}
			}
		}

		static IntPtr id_getEndPoint;
		public unsafe global::Com.Baidu.Mapapi.Model.LatLng EndPoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='ArcOptions']/method[@name='getEndPoint' and count(parameter)=0]"
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

		static IntPtr id_getExtraInfo;
		public unsafe global::Android.OS.Bundle ExtraInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='ArcOptions']/method[@name='getExtraInfo' and count(parameter)=0]"
			[Register ("getExtraInfo", "()Landroid/os/Bundle;", "GetGetExtraInfoHandler")]
			get {
				if (id_getExtraInfo == IntPtr.Zero)
					id_getExtraInfo = JNIEnv.GetMethodID (class_ref, "getExtraInfo", "()Landroid/os/Bundle;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExtraInfo), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isVisible;
		public unsafe bool IsVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='ArcOptions']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isVisible);
				} finally {
				}
			}
		}

		static IntPtr id_getMiddlePoint;
		public unsafe global::Com.Baidu.Mapapi.Model.LatLng MiddlePoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='ArcOptions']/method[@name='getMiddlePoint' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='ArcOptions']/method[@name='getStartPoint' and count(parameter)=0]"
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
		public unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='ArcOptions']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWidth);
				} finally {
				}
			}
		}

		static IntPtr id_getZIndex;
		public unsafe int ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='ArcOptions']/method[@name='getZIndex' and count(parameter)=0]"
			[Register ("getZIndex", "()I", "GetGetZIndexHandler")]
			get {
				if (id_getZIndex == IntPtr.Zero)
					id_getZIndex = JNIEnv.GetMethodID (class_ref, "getZIndex", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getZIndex);
				} finally {
				}
			}
		}

		static IntPtr id_color_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='ArcOptions']/method[@name='color' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("color", "(I)Lcom/baidu/mapapi/map/ArcOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.ArcOptions InvokeColor (int p0)
		{
			if (id_color_I == IntPtr.Zero)
				id_color_I = JNIEnv.GetMethodID (class_ref, "color", "(I)Lcom/baidu/mapapi/map/ArcOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.ArcOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_color_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_extraInfo_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='ArcOptions']/method[@name='extraInfo' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("extraInfo", "(Landroid/os/Bundle;)Lcom/baidu/mapapi/map/ArcOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.ArcOptions InvokeExtraInfo (global::Android.OS.Bundle p0)
		{
			if (id_extraInfo_Landroid_os_Bundle_ == IntPtr.Zero)
				id_extraInfo_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "extraInfo", "(Landroid/os/Bundle;)Lcom/baidu/mapapi/map/ArcOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.ArcOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.ArcOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_extraInfo_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_points_Lcom_baidu_mapapi_model_LatLng_Lcom_baidu_mapapi_model_LatLng_Lcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='ArcOptions']/method[@name='points' and count(parameter)=3 and parameter[1][@type='com.baidu.mapapi.model.LatLng'] and parameter[2][@type='com.baidu.mapapi.model.LatLng'] and parameter[3][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("points", "(Lcom/baidu/mapapi/model/LatLng;Lcom/baidu/mapapi/model/LatLng;Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/map/ArcOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.ArcOptions Points (global::Com.Baidu.Mapapi.Model.LatLng p0, global::Com.Baidu.Mapapi.Model.LatLng p1, global::Com.Baidu.Mapapi.Model.LatLng p2)
		{
			if (id_points_Lcom_baidu_mapapi_model_LatLng_Lcom_baidu_mapapi_model_LatLng_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_points_Lcom_baidu_mapapi_model_LatLng_Lcom_baidu_mapapi_model_LatLng_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "points", "(Lcom/baidu/mapapi/model/LatLng;Lcom/baidu/mapapi/model/LatLng;Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/map/ArcOptions;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.Baidu.Mapapi.Map.ArcOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.ArcOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_points_Lcom_baidu_mapapi_model_LatLng_Lcom_baidu_mapapi_model_LatLng_Lcom_baidu_mapapi_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_visible_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='ArcOptions']/method[@name='visible' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("visible", "(Z)Lcom/baidu/mapapi/map/ArcOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.ArcOptions Visible (bool p0)
		{
			if (id_visible_Z == IntPtr.Zero)
				id_visible_Z = JNIEnv.GetMethodID (class_ref, "visible", "(Z)Lcom/baidu/mapapi/map/ArcOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.ArcOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_visible_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_width_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='ArcOptions']/method[@name='width' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("width", "(I)Lcom/baidu/mapapi/map/ArcOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.ArcOptions InvokeWidth (int p0)
		{
			if (id_width_I == IntPtr.Zero)
				id_width_I = JNIEnv.GetMethodID (class_ref, "width", "(I)Lcom/baidu/mapapi/map/ArcOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.ArcOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_width_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_zIndex_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='ArcOptions']/method[@name='zIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("zIndex", "(I)Lcom/baidu/mapapi/map/ArcOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.ArcOptions InvokeZIndex (int p0)
		{
			if (id_zIndex_I == IntPtr.Zero)
				id_zIndex_I = JNIEnv.GetMethodID (class_ref, "zIndex", "(I)Lcom/baidu/mapapi/map/ArcOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.ArcOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_zIndex_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
