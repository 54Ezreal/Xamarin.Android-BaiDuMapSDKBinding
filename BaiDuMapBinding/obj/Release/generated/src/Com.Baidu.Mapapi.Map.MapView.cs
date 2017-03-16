using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/MapView", DoNotGenerateAcw=true)]
	public sealed partial class MapView : global::Android.Views.ViewGroup {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/MapView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapView); }
		}

		internal MapView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_baidu_mapapi_map_BaiduMapOptions_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/constructor[@name='MapView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.baidu.mapapi.map.BaiduMapOptions']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/baidu/mapapi/map/BaiduMapOptions;)V", "")]
		public unsafe MapView (global::Android.Content.Context p0, global::Com.Baidu.Mapapi.Map.BaiduMapOptions p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MapView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Lcom/baidu/mapapi/map/BaiduMapOptions;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Lcom/baidu/mapapi/map/BaiduMapOptions;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_baidu_mapapi_map_BaiduMapOptions_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_baidu_mapapi_map_BaiduMapOptions_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/baidu/mapapi/map/BaiduMapOptions;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_baidu_mapapi_map_BaiduMapOptions_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_baidu_mapapi_map_BaiduMapOptions_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/constructor[@name='MapView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe MapView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (MapView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/constructor[@name='MapView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe MapView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MapView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/constructor[@name='MapView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MapView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MapView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_getLogoPosition;
		static IntPtr id_setLogoPosition_Lcom_baidu_mapapi_map_LogoPosition_;
		public unsafe global::Com.Baidu.Mapapi.Map.LogoPosition LogoPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='getLogoPosition' and count(parameter)=0]"
			[Register ("getLogoPosition", "()Lcom/baidu/mapapi/map/LogoPosition;", "GetGetLogoPositionHandler")]
			get {
				if (id_getLogoPosition == IntPtr.Zero)
					id_getLogoPosition = JNIEnv.GetMethodID (class_ref, "getLogoPosition", "()Lcom/baidu/mapapi/map/LogoPosition;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.LogoPosition> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLogoPosition), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='setLogoPosition' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.LogoPosition']]"
			[Register ("setLogoPosition", "(Lcom/baidu/mapapi/map/LogoPosition;)V", "GetSetLogoPosition_Lcom_baidu_mapapi_map_LogoPosition_Handler")]
			set {
				if (id_setLogoPosition_Lcom_baidu_mapapi_map_LogoPosition_ == IntPtr.Zero)
					id_setLogoPosition_Lcom_baidu_mapapi_map_LogoPosition_ = JNIEnv.GetMethodID (class_ref, "setLogoPosition", "(Lcom/baidu/mapapi/map/LogoPosition;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLogoPosition_Lcom_baidu_mapapi_map_LogoPosition_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getMap;
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMap Map {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='getMap' and count(parameter)=0]"
			[Register ("getMap", "()Lcom/baidu/mapapi/map/BaiduMap;", "GetGetMapHandler")]
			get {
				if (id_getMap == IntPtr.Zero)
					id_getMap = JNIEnv.GetMethodID (class_ref, "getMap", "()Lcom/baidu/mapapi/map/BaiduMap;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMap), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMapLevel;
		public unsafe int MapLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='getMapLevel' and count(parameter)=0]"
			[Register ("getMapLevel", "()I", "GetGetMapLevelHandler")]
			get {
				if (id_getMapLevel == IntPtr.Zero)
					id_getMapLevel = JNIEnv.GetMethodID (class_ref, "getMapLevel", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMapLevel);
				} finally {
				}
			}
		}

		static IntPtr id_getScaleControlViewHeight;
		public unsafe int ScaleControlViewHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='getScaleControlViewHeight' and count(parameter)=0]"
			[Register ("getScaleControlViewHeight", "()I", "GetGetScaleControlViewHeightHandler")]
			get {
				if (id_getScaleControlViewHeight == IntPtr.Zero)
					id_getScaleControlViewHeight = JNIEnv.GetMethodID (class_ref, "getScaleControlViewHeight", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getScaleControlViewHeight);
				} finally {
				}
			}
		}

		static IntPtr id_getScaleControlViewWidth;
		public unsafe int ScaleControlViewWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='getScaleControlViewWidth' and count(parameter)=0]"
			[Register ("getScaleControlViewWidth", "()I", "GetGetScaleControlViewWidthHandler")]
			get {
				if (id_getScaleControlViewWidth == IntPtr.Zero)
					id_getScaleControlViewWidth = JNIEnv.GetMethodID (class_ref, "getScaleControlViewWidth", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getScaleControlViewWidth);
				} finally {
				}
			}
		}

		static IntPtr id_onCreate_Landroid_content_Context_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='onCreate' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/content/Context;Landroid/os/Bundle;)V", "")]
		public unsafe void OnCreate (global::Android.Content.Context p0, global::Android.OS.Bundle p1)
		{
			if (id_onCreate_Landroid_content_Context_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCreate_Landroid_content_Context_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/content/Context;Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreate_Landroid_content_Context_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "")]
		public unsafe void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDestroy);
			} finally {
			}
		}

		static IntPtr id_onLayout_ZIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onLayout", "(ZIIII)V", "")]
		protected override sealed unsafe void OnLayout (bool p0, int p1, int p2, int p3, int p4)
		{
			if (id_onLayout_ZIIII == IntPtr.Zero)
				id_onLayout_ZIIII = JNIEnv.GetMethodID (class_ref, "onLayout", "(ZIIII)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLayout_ZIIII, __args);
			} finally {
			}
		}

		static IntPtr id_onPause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "")]
		public unsafe void OnPause ()
		{
			if (id_onPause == IntPtr.Zero)
				id_onPause = JNIEnv.GetMethodID (class_ref, "onPause", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPause);
			} finally {
			}
		}

		static IntPtr id_onResume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "")]
		public unsafe void OnResume ()
		{
			if (id_onResume == IntPtr.Zero)
				id_onResume = JNIEnv.GetMethodID (class_ref, "onResume", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResume);
			} finally {
			}
		}

		static IntPtr id_onSaveInstanceState_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='onSaveInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onSaveInstanceState", "(Landroid/os/Bundle;)V", "")]
		public unsafe void OnSaveInstanceState (global::Android.OS.Bundle p0)
		{
			if (id_onSaveInstanceState_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onSaveInstanceState_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onSaveInstanceState", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSaveInstanceState_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

		static IntPtr id_setCustomMapStylePath_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='setCustomMapStylePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCustomMapStylePath", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetCustomMapStylePath (string p0)
		{
			if (id_setCustomMapStylePath_Ljava_lang_String_ == IntPtr.Zero)
				id_setCustomMapStylePath_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setCustomMapStylePath", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setCustomMapStylePath_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setMapCustomEnable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='setMapCustomEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMapCustomEnable", "(Z)V", "")]
		public static unsafe void SetMapCustomEnable (bool p0)
		{
			if (id_setMapCustomEnable_Z == IntPtr.Zero)
				id_setMapCustomEnable_Z = JNIEnv.GetStaticMethodID (class_ref, "setMapCustomEnable", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setMapCustomEnable_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setScaleControlPosition_Landroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='setScaleControlPosition' and count(parameter)=1 and parameter[1][@type='android.graphics.Point']]"
		[Register ("setScaleControlPosition", "(Landroid/graphics/Point;)V", "")]
		public unsafe void SetScaleControlPosition (global::Android.Graphics.Point p0)
		{
			if (id_setScaleControlPosition_Landroid_graphics_Point_ == IntPtr.Zero)
				id_setScaleControlPosition_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "setScaleControlPosition", "(Landroid/graphics/Point;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScaleControlPosition_Landroid_graphics_Point_, __args);
			} finally {
			}
		}

		static IntPtr id_setZOrderMediaOverlay_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='setZOrderMediaOverlay' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setZOrderMediaOverlay", "(Z)V", "")]
		public unsafe void SetZOrderMediaOverlay (bool p0)
		{
			if (id_setZOrderMediaOverlay_Z == IntPtr.Zero)
				id_setZOrderMediaOverlay_Z = JNIEnv.GetMethodID (class_ref, "setZOrderMediaOverlay", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setZOrderMediaOverlay_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setZoomControlsPosition_Landroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='setZoomControlsPosition' and count(parameter)=1 and parameter[1][@type='android.graphics.Point']]"
		[Register ("setZoomControlsPosition", "(Landroid/graphics/Point;)V", "")]
		public unsafe void SetZoomControlsPosition (global::Android.Graphics.Point p0)
		{
			if (id_setZoomControlsPosition_Landroid_graphics_Point_ == IntPtr.Zero)
				id_setZoomControlsPosition_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "setZoomControlsPosition", "(Landroid/graphics/Point;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setZoomControlsPosition_Landroid_graphics_Point_, __args);
			} finally {
			}
		}

		static IntPtr id_showScaleControl_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='showScaleControl' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showScaleControl", "(Z)V", "")]
		public unsafe void ShowScaleControl (bool p0)
		{
			if (id_showScaleControl_Z == IntPtr.Zero)
				id_showScaleControl_Z = JNIEnv.GetMethodID (class_ref, "showScaleControl", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showScaleControl_Z, __args);
			} finally {
			}
		}

		static IntPtr id_showZoomControls_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='showZoomControls' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showZoomControls", "(Z)V", "")]
		public unsafe void ShowZoomControls (bool p0)
		{
			if (id_showZoomControls_Z == IntPtr.Zero)
				id_showZoomControls_Z = JNIEnv.GetMethodID (class_ref, "showZoomControls", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showZoomControls_Z, __args);
			} finally {
			}
		}

	}
}
