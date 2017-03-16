using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlay']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/GroundOverlay", DoNotGenerateAcw=true)]
	public sealed partial class GroundOverlay : global::Com.Baidu.Mapapi.Map.Overlay {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/GroundOverlay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GroundOverlay); }
		}

		internal GroundOverlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAnchorX;
		public unsafe float AnchorX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlay']/method[@name='getAnchorX' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlay']/method[@name='getAnchorY' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlay']/method[@name='getBounds' and count(parameter)=0]"
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

		static IntPtr id_getHeight;
		public unsafe double Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlay']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()D", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()D");
				try {
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getHeight);
				} finally {
				}
			}
		}

		static IntPtr id_getImage;
		static IntPtr id_setImage_Lcom_baidu_mapapi_map_BitmapDescriptor_;
		public unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor Image {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlay']/method[@name='getImage' and count(parameter)=0]"
			[Register ("getImage", "()Lcom/baidu/mapapi/map/BitmapDescriptor;", "GetGetImageHandler")]
			get {
				if (id_getImage == IntPtr.Zero)
					id_getImage = JNIEnv.GetMethodID (class_ref, "getImage", "()Lcom/baidu/mapapi/map/BitmapDescriptor;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImage), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlay']/method[@name='setImage' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BitmapDescriptor']]"
			[Register ("setImage", "(Lcom/baidu/mapapi/map/BitmapDescriptor;)V", "GetSetImage_Lcom_baidu_mapapi_map_BitmapDescriptor_Handler")]
			set {
				if (id_setImage_Lcom_baidu_mapapi_map_BitmapDescriptor_ == IntPtr.Zero)
					id_setImage_Lcom_baidu_mapapi_map_BitmapDescriptor_ = JNIEnv.GetMethodID (class_ref, "setImage", "(Lcom/baidu/mapapi/map/BitmapDescriptor;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImage_Lcom_baidu_mapapi_map_BitmapDescriptor_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getPosition;
		static IntPtr id_setPosition_Lcom_baidu_mapapi_model_LatLng_;
		public unsafe global::Com.Baidu.Mapapi.Model.LatLng Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlay']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()Lcom/baidu/mapapi/model/LatLng;", "GetGetPositionHandler")]
			get {
				if (id_getPosition == IntPtr.Zero)
					id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()Lcom/baidu/mapapi/model/LatLng;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPosition), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlay']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
			[Register ("setPosition", "(Lcom/baidu/mapapi/model/LatLng;)V", "GetSetPosition_Lcom_baidu_mapapi_model_LatLng_Handler")]
			set {
				if (id_setPosition_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
					id_setPosition_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "setPosition", "(Lcom/baidu/mapapi/model/LatLng;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPosition_Lcom_baidu_mapapi_model_LatLng_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getTransparency;
		static IntPtr id_setTransparency_F;
		public unsafe float Transparency {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlay']/method[@name='getTransparency' and count(parameter)=0]"
			[Register ("getTransparency", "()F", "GetGetTransparencyHandler")]
			get {
				if (id_getTransparency == IntPtr.Zero)
					id_getTransparency = JNIEnv.GetMethodID (class_ref, "getTransparency", "()F");
				try {
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getTransparency);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlay']/method[@name='setTransparency' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setTransparency", "(F)V", "GetSetTransparency_FHandler")]
			set {
				if (id_setTransparency_F == IntPtr.Zero)
					id_setTransparency_F = JNIEnv.GetMethodID (class_ref, "setTransparency", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTransparency_F, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getWidth;
		public unsafe double Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlay']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()D", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()D");
				try {
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getWidth);
				} finally {
				}
			}
		}

		static IntPtr id_setAnchor_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlay']/method[@name='setAnchor' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setAnchor", "(FF)V", "")]
		public unsafe void SetAnchor (float p0, float p1)
		{
			if (id_setAnchor_FF == IntPtr.Zero)
				id_setAnchor_FF = JNIEnv.GetMethodID (class_ref, "setAnchor", "(FF)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAnchor_FF, __args);
			} finally {
			}
		}

		static IntPtr id_setDimensions_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlay']/method[@name='setDimensions' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDimensions", "(I)V", "")]
		public unsafe void SetDimensions (int p0)
		{
			if (id_setDimensions_I == IntPtr.Zero)
				id_setDimensions_I = JNIEnv.GetMethodID (class_ref, "setDimensions", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDimensions_I, __args);
			} finally {
			}
		}

		static IntPtr id_setDimensions_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlay']/method[@name='setDimensions' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setDimensions", "(II)V", "")]
		public unsafe void SetDimensions (int p0, int p1)
		{
			if (id_setDimensions_II == IntPtr.Zero)
				id_setDimensions_II = JNIEnv.GetMethodID (class_ref, "setDimensions", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDimensions_II, __args);
			} finally {
			}
		}

		static IntPtr id_setPositionFromBounds_Lcom_baidu_mapapi_model_LatLngBounds_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='GroundOverlay']/method[@name='setPositionFromBounds' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLngBounds']]"
		[Register ("setPositionFromBounds", "(Lcom/baidu/mapapi/model/LatLngBounds;)V", "")]
		public unsafe void SetPositionFromBounds (global::Com.Baidu.Mapapi.Model.LatLngBounds p0)
		{
			if (id_setPositionFromBounds_Lcom_baidu_mapapi_model_LatLngBounds_ == IntPtr.Zero)
				id_setPositionFromBounds_Lcom_baidu_mapapi_model_LatLngBounds_ = JNIEnv.GetMethodID (class_ref, "setPositionFromBounds", "(Lcom/baidu/mapapi/model/LatLngBounds;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPositionFromBounds_Lcom_baidu_mapapi_model_LatLngBounds_, __args);
			} finally {
			}
		}

	}
}
