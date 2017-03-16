using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolygonOptions']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/PolygonOptions", DoNotGenerateAcw=true)]
	public sealed partial class PolygonOptions : global::Com.Baidu.Mapapi.Map.OverlayOptions {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/PolygonOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PolygonOptions); }
		}

		internal PolygonOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolygonOptions']/constructor[@name='PolygonOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PolygonOptions ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PolygonOptions)) {
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

		static IntPtr id_getExtraInfo;
		public unsafe global::Android.OS.Bundle ExtraInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolygonOptions']/method[@name='getExtraInfo' and count(parameter)=0]"
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

		static IntPtr id_getFillColor;
		public unsafe int FillColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolygonOptions']/method[@name='getFillColor' and count(parameter)=0]"
			[Register ("getFillColor", "()I", "GetGetFillColorHandler")]
			get {
				if (id_getFillColor == IntPtr.Zero)
					id_getFillColor = JNIEnv.GetMethodID (class_ref, "getFillColor", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFillColor);
				} finally {
				}
			}
		}

		static IntPtr id_isVisible;
		public unsafe bool IsVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolygonOptions']/method[@name='isVisible' and count(parameter)=0]"
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

		static IntPtr id_getPoints;
		public unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Model.LatLng> Points {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolygonOptions']/method[@name='getPoints' and count(parameter)=0]"
			[Register ("getPoints", "()Ljava/util/List;", "GetGetPointsHandler")]
			get {
				if (id_getPoints == IntPtr.Zero)
					id_getPoints = JNIEnv.GetMethodID (class_ref, "getPoints", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Model.LatLng>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPoints), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getStroke;
		public unsafe global::Com.Baidu.Mapapi.Map.Stroke Stroke {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolygonOptions']/method[@name='getStroke' and count(parameter)=0]"
			[Register ("getStroke", "()Lcom/baidu/mapapi/map/Stroke;", "GetGetStrokeHandler")]
			get {
				if (id_getStroke == IntPtr.Zero)
					id_getStroke = JNIEnv.GetMethodID (class_ref, "getStroke", "()Lcom/baidu/mapapi/map/Stroke;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Stroke> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStroke), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getZIndex;
		public unsafe int ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolygonOptions']/method[@name='getZIndex' and count(parameter)=0]"
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

		static IntPtr id_extraInfo_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolygonOptions']/method[@name='extraInfo' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("extraInfo", "(Landroid/os/Bundle;)Lcom/baidu/mapapi/map/PolygonOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolygonOptions InvokeExtraInfo (global::Android.OS.Bundle p0)
		{
			if (id_extraInfo_Landroid_os_Bundle_ == IntPtr.Zero)
				id_extraInfo_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "extraInfo", "(Landroid/os/Bundle;)Lcom/baidu/mapapi/map/PolygonOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.PolygonOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolygonOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_extraInfo_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fillColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolygonOptions']/method[@name='fillColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fillColor", "(I)Lcom/baidu/mapapi/map/PolygonOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolygonOptions InvokeFillColor (int p0)
		{
			if (id_fillColor_I == IntPtr.Zero)
				id_fillColor_I = JNIEnv.GetMethodID (class_ref, "fillColor", "(I)Lcom/baidu/mapapi/map/PolygonOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolygonOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fillColor_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_points_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolygonOptions']/method[@name='points' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.baidu.mapapi.model.LatLng&gt;']]"
		[Register ("points", "(Ljava/util/List;)Lcom/baidu/mapapi/map/PolygonOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolygonOptions InvokePoints (global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Model.LatLng> p0)
		{
			if (id_points_Ljava_util_List_ == IntPtr.Zero)
				id_points_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "points", "(Ljava/util/List;)Lcom/baidu/mapapi/map/PolygonOptions;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Model.LatLng>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Baidu.Mapapi.Map.PolygonOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolygonOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_points_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_stroke_Lcom_baidu_mapapi_map_Stroke_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolygonOptions']/method[@name='stroke' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.Stroke']]"
		[Register ("stroke", "(Lcom/baidu/mapapi/map/Stroke;)Lcom/baidu/mapapi/map/PolygonOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolygonOptions InvokeStroke (global::Com.Baidu.Mapapi.Map.Stroke p0)
		{
			if (id_stroke_Lcom_baidu_mapapi_map_Stroke_ == IntPtr.Zero)
				id_stroke_Lcom_baidu_mapapi_map_Stroke_ = JNIEnv.GetMethodID (class_ref, "stroke", "(Lcom/baidu/mapapi/map/Stroke;)Lcom/baidu/mapapi/map/PolygonOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.PolygonOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolygonOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_stroke_Lcom_baidu_mapapi_map_Stroke_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_visible_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolygonOptions']/method[@name='visible' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("visible", "(Z)Lcom/baidu/mapapi/map/PolygonOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolygonOptions Visible (bool p0)
		{
			if (id_visible_Z == IntPtr.Zero)
				id_visible_Z = JNIEnv.GetMethodID (class_ref, "visible", "(Z)Lcom/baidu/mapapi/map/PolygonOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolygonOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_visible_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_zIndex_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolygonOptions']/method[@name='zIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("zIndex", "(I)Lcom/baidu/mapapi/map/PolygonOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolygonOptions InvokeZIndex (int p0)
		{
			if (id_zIndex_I == IntPtr.Zero)
				id_zIndex_I = JNIEnv.GetMethodID (class_ref, "zIndex", "(I)Lcom/baidu/mapapi/map/PolygonOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolygonOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_zIndex_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
