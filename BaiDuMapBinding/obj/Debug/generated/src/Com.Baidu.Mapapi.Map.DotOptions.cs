using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='DotOptions']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/DotOptions", DoNotGenerateAcw=true)]
	public sealed partial class DotOptions : global::Com.Baidu.Mapapi.Map.OverlayOptions {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/DotOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DotOptions); }
		}

		internal DotOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='DotOptions']/constructor[@name='DotOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DotOptions ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DotOptions)) {
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

		static IntPtr id_getCenter;
		public unsafe global::Com.Baidu.Mapapi.Model.LatLng Center {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='DotOptions']/method[@name='getCenter' and count(parameter)=0]"
			[Register ("getCenter", "()Lcom/baidu/mapapi/model/LatLng;", "GetGetCenterHandler")]
			get {
				if (id_getCenter == IntPtr.Zero)
					id_getCenter = JNIEnv.GetMethodID (class_ref, "getCenter", "()Lcom/baidu/mapapi/model/LatLng;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCenter), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getColor;
		public unsafe int Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='DotOptions']/method[@name='getColor' and count(parameter)=0]"
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

		static IntPtr id_getExtraInfo;
		public unsafe global::Android.OS.Bundle ExtraInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='DotOptions']/method[@name='getExtraInfo' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='DotOptions']/method[@name='isVisible' and count(parameter)=0]"
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

		static IntPtr id_getRadius;
		public unsafe int Radius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='DotOptions']/method[@name='getRadius' and count(parameter)=0]"
			[Register ("getRadius", "()I", "GetGetRadiusHandler")]
			get {
				if (id_getRadius == IntPtr.Zero)
					id_getRadius = JNIEnv.GetMethodID (class_ref, "getRadius", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRadius);
				} finally {
				}
			}
		}

		static IntPtr id_getZIndex;
		public unsafe int ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='DotOptions']/method[@name='getZIndex' and count(parameter)=0]"
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

		static IntPtr id_center_Lcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='DotOptions']/method[@name='center' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("center", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/map/DotOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.DotOptions InvokeCenter (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			if (id_center_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_center_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "center", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/map/DotOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.DotOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.DotOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_center_Lcom_baidu_mapapi_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_color_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='DotOptions']/method[@name='color' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("color", "(I)Lcom/baidu/mapapi/map/DotOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.DotOptions InvokeColor (int p0)
		{
			if (id_color_I == IntPtr.Zero)
				id_color_I = JNIEnv.GetMethodID (class_ref, "color", "(I)Lcom/baidu/mapapi/map/DotOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.DotOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_color_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_extraInfo_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='DotOptions']/method[@name='extraInfo' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("extraInfo", "(Landroid/os/Bundle;)Lcom/baidu/mapapi/map/DotOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.DotOptions InvokeExtraInfo (global::Android.OS.Bundle p0)
		{
			if (id_extraInfo_Landroid_os_Bundle_ == IntPtr.Zero)
				id_extraInfo_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "extraInfo", "(Landroid/os/Bundle;)Lcom/baidu/mapapi/map/DotOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.DotOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.DotOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_extraInfo_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_radius_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='DotOptions']/method[@name='radius' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("radius", "(I)Lcom/baidu/mapapi/map/DotOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.DotOptions InvokeRadius (int p0)
		{
			if (id_radius_I == IntPtr.Zero)
				id_radius_I = JNIEnv.GetMethodID (class_ref, "radius", "(I)Lcom/baidu/mapapi/map/DotOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.DotOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_radius_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_visible_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='DotOptions']/method[@name='visible' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("visible", "(Z)Lcom/baidu/mapapi/map/DotOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.DotOptions Visible (bool p0)
		{
			if (id_visible_Z == IntPtr.Zero)
				id_visible_Z = JNIEnv.GetMethodID (class_ref, "visible", "(Z)Lcom/baidu/mapapi/map/DotOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.DotOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_visible_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_zIndex_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='DotOptions']/method[@name='zIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("zIndex", "(I)Lcom/baidu/mapapi/map/DotOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.DotOptions InvokeZIndex (int p0)
		{
			if (id_zIndex_I == IntPtr.Zero)
				id_zIndex_I = JNIEnv.GetMethodID (class_ref, "zIndex", "(I)Lcom/baidu/mapapi/map/DotOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.DotOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_zIndex_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
