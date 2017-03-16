using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlayOptions']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/GroundOverlayOptions", DoNotGenerateAcw=true)]
	public sealed partial class GroundOverlayOptions : global::Com.Baidu.Mapapi.Map.OverlayOptions {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/GroundOverlayOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GroundOverlayOptions); }
		}

		internal GroundOverlayOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlayOptions']/constructor[@name='GroundOverlayOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GroundOverlayOptions ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GroundOverlayOptions)) {
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

		static IntPtr id_getAnchorX;
		public unsafe float AnchorX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlayOptions']/method[@name='getAnchorX' and count(parameter)=0]"
			[Register ("getAnchorX", "()F", "GetGetAnchorXHandler")]
			get {
				if (id_getAnchorX == IntPtr.Zero)
					id_getAnchorX = JNIEnv.GetMethodID (class_ref, "getAnchorX", "()F");
				try {
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getAnchorX);
				} finally {
				}
			}
		}

		static IntPtr id_getAnchorY;
		public unsafe float AnchorY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlayOptions']/method[@name='getAnchorY' and count(parameter)=0]"
			[Register ("getAnchorY", "()F", "GetGetAnchorYHandler")]
			get {
				if (id_getAnchorY == IntPtr.Zero)
					id_getAnchorY = JNIEnv.GetMethodID (class_ref, "getAnchorY", "()F");
				try {
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getAnchorY);
				} finally {
				}
			}
		}

		static IntPtr id_getBounds;
		public unsafe global::Com.Baidu.Mapapi.Model.LatLngBounds Bounds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlayOptions']/method[@name='getBounds' and count(parameter)=0]"
			[Register ("getBounds", "()Lcom/baidu/mapapi/model/LatLngBounds;", "GetGetBoundsHandler")]
			get {
				if (id_getBounds == IntPtr.Zero)
					id_getBounds = JNIEnv.GetMethodID (class_ref, "getBounds", "()Lcom/baidu/mapapi/model/LatLngBounds;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLngBounds> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBounds), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getExtraInfo;
		public unsafe global::Android.OS.Bundle ExtraInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlayOptions']/method[@name='getExtraInfo' and count(parameter)=0]"
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

		static IntPtr id_getHeight;
		public unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlayOptions']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHeight);
				} finally {
				}
			}
		}

		static IntPtr id_getImage;
		public unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor Image {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlayOptions']/method[@name='getImage' and count(parameter)=0]"
			[Register ("getImage", "()Lcom/baidu/mapapi/map/BitmapDescriptor;", "GetGetImageHandler")]
			get {
				if (id_getImage == IntPtr.Zero)
					id_getImage = JNIEnv.GetMethodID (class_ref, "getImage", "()Lcom/baidu/mapapi/map/BitmapDescriptor;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImage), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isVisible;
		public unsafe bool IsVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlayOptions']/method[@name='isVisible' and count(parameter)=0]"
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

		static IntPtr id_getPosition;
		public unsafe global::Com.Baidu.Mapapi.Model.LatLng Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlayOptions']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()Lcom/baidu/mapapi/model/LatLng;", "GetGetPositionHandler")]
			get {
				if (id_getPosition == IntPtr.Zero)
					id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()Lcom/baidu/mapapi/model/LatLng;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPosition), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getTransparency;
		public unsafe float Transparency {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlayOptions']/method[@name='getTransparency' and count(parameter)=0]"
			[Register ("getTransparency", "()F", "GetGetTransparencyHandler")]
			get {
				if (id_getTransparency == IntPtr.Zero)
					id_getTransparency = JNIEnv.GetMethodID (class_ref, "getTransparency", "()F");
				try {
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getTransparency);
				} finally {
				}
			}
		}

		static IntPtr id_getWidth;
		public unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlayOptions']/method[@name='getWidth' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlayOptions']/method[@name='getZIndex' and count(parameter)=0]"
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

		static IntPtr id_anchor_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlayOptions']/method[@name='anchor' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("anchor", "(FF)Lcom/baidu/mapapi/map/GroundOverlayOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.GroundOverlayOptions Anchor (float p0, float p1)
		{
			if (id_anchor_FF == IntPtr.Zero)
				id_anchor_FF = JNIEnv.GetMethodID (class_ref, "anchor", "(FF)Lcom/baidu/mapapi/map/GroundOverlayOptions;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.GroundOverlayOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_anchor_FF, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_dimensions_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlayOptions']/method[@name='dimensions' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("dimensions", "(I)Lcom/baidu/mapapi/map/GroundOverlayOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.GroundOverlayOptions Dimensions (int p0)
		{
			if (id_dimensions_I == IntPtr.Zero)
				id_dimensions_I = JNIEnv.GetMethodID (class_ref, "dimensions", "(I)Lcom/baidu/mapapi/map/GroundOverlayOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.GroundOverlayOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_dimensions_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_dimensions_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlayOptions']/method[@name='dimensions' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("dimensions", "(II)Lcom/baidu/mapapi/map/GroundOverlayOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.GroundOverlayOptions Dimensions (int p0, int p1)
		{
			if (id_dimensions_II == IntPtr.Zero)
				id_dimensions_II = JNIEnv.GetMethodID (class_ref, "dimensions", "(II)Lcom/baidu/mapapi/map/GroundOverlayOptions;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.GroundOverlayOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_dimensions_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_extraInfo_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlayOptions']/method[@name='extraInfo' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("extraInfo", "(Landroid/os/Bundle;)Lcom/baidu/mapapi/map/GroundOverlayOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.GroundOverlayOptions InvokeExtraInfo (global::Android.OS.Bundle p0)
		{
			if (id_extraInfo_Landroid_os_Bundle_ == IntPtr.Zero)
				id_extraInfo_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "extraInfo", "(Landroid/os/Bundle;)Lcom/baidu/mapapi/map/GroundOverlayOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.GroundOverlayOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.GroundOverlayOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_extraInfo_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_image_Lcom_baidu_mapapi_map_BitmapDescriptor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlayOptions']/method[@name='image' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BitmapDescriptor']]"
		[Register ("image", "(Lcom/baidu/mapapi/map/BitmapDescriptor;)Lcom/baidu/mapapi/map/GroundOverlayOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.GroundOverlayOptions InvokeImage (global::Com.Baidu.Mapapi.Map.BitmapDescriptor p0)
		{
			if (id_image_Lcom_baidu_mapapi_map_BitmapDescriptor_ == IntPtr.Zero)
				id_image_Lcom_baidu_mapapi_map_BitmapDescriptor_ = JNIEnv.GetMethodID (class_ref, "image", "(Lcom/baidu/mapapi/map/BitmapDescriptor;)Lcom/baidu/mapapi/map/GroundOverlayOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.GroundOverlayOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.GroundOverlayOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_image_Lcom_baidu_mapapi_map_BitmapDescriptor_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_position_Lcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlayOptions']/method[@name='position' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("position", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/map/GroundOverlayOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.GroundOverlayOptions InvokePosition (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			if (id_position_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_position_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "position", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/map/GroundOverlayOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.GroundOverlayOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.GroundOverlayOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_position_Lcom_baidu_mapapi_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_positionFromBounds_Lcom_baidu_mapapi_model_LatLngBounds_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlayOptions']/method[@name='positionFromBounds' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLngBounds']]"
		[Register ("positionFromBounds", "(Lcom/baidu/mapapi/model/LatLngBounds;)Lcom/baidu/mapapi/map/GroundOverlayOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.GroundOverlayOptions PositionFromBounds (global::Com.Baidu.Mapapi.Model.LatLngBounds p0)
		{
			if (id_positionFromBounds_Lcom_baidu_mapapi_model_LatLngBounds_ == IntPtr.Zero)
				id_positionFromBounds_Lcom_baidu_mapapi_model_LatLngBounds_ = JNIEnv.GetMethodID (class_ref, "positionFromBounds", "(Lcom/baidu/mapapi/model/LatLngBounds;)Lcom/baidu/mapapi/map/GroundOverlayOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.GroundOverlayOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.GroundOverlayOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_positionFromBounds_Lcom_baidu_mapapi_model_LatLngBounds_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_transparency_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlayOptions']/method[@name='transparency' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("transparency", "(F)Lcom/baidu/mapapi/map/GroundOverlayOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.GroundOverlayOptions InvokeTransparency (float p0)
		{
			if (id_transparency_F == IntPtr.Zero)
				id_transparency_F = JNIEnv.GetMethodID (class_ref, "transparency", "(F)Lcom/baidu/mapapi/map/GroundOverlayOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.GroundOverlayOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_transparency_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_visible_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlayOptions']/method[@name='visible' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("visible", "(Z)Lcom/baidu/mapapi/map/GroundOverlayOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.GroundOverlayOptions Visible (bool p0)
		{
			if (id_visible_Z == IntPtr.Zero)
				id_visible_Z = JNIEnv.GetMethodID (class_ref, "visible", "(Z)Lcom/baidu/mapapi/map/GroundOverlayOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.GroundOverlayOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_visible_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_zIndex_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlayOptions']/method[@name='zIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("zIndex", "(I)Lcom/baidu/mapapi/map/GroundOverlayOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.GroundOverlayOptions InvokeZIndex (int p0)
		{
			if (id_zIndex_I == IntPtr.Zero)
				id_zIndex_I = JNIEnv.GetMethodID (class_ref, "zIndex", "(I)Lcom/baidu/mapapi/map/GroundOverlayOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.GroundOverlayOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_zIndex_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
