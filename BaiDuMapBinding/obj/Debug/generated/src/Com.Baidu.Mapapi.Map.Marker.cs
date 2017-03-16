using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/Marker", DoNotGenerateAcw=true)]
	public sealed partial class Marker : global::Com.Baidu.Mapapi.Map.Overlay {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/Marker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Marker); }
		}

		internal Marker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAlpha;
		static IntPtr id_setAlpha_F;
		public unsafe float Alpha {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='getAlpha' and count(parameter)=0]"
			[Register ("getAlpha", "()F", "GetGetAlphaHandler")]
			get {
				if (id_getAlpha == IntPtr.Zero)
					id_getAlpha = JNIEnv.GetMethodID (class_ref, "getAlpha", "()F");
				try {
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getAlpha);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setAlpha", "(F)V", "GetSetAlpha_FHandler")]
			set {
				if (id_setAlpha_F == IntPtr.Zero)
					id_setAlpha_F = JNIEnv.GetMethodID (class_ref, "setAlpha", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAlpha_F, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getAnchorX;
		public unsafe float AnchorX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='getAnchorX' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='getAnchorY' and count(parameter)=0]"
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

		static IntPtr id_isDraggable;
		static IntPtr id_setDraggable_Z;
		public unsafe bool Draggable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='isDraggable' and count(parameter)=0]"
			[Register ("isDraggable", "()Z", "GetIsDraggableHandler")]
			get {
				if (id_isDraggable == IntPtr.Zero)
					id_isDraggable = JNIEnv.GetMethodID (class_ref, "isDraggable", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDraggable);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setDraggable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDraggable", "(Z)V", "GetSetDraggable_ZHandler")]
			set {
				if (id_setDraggable_Z == IntPtr.Zero)
					id_setDraggable_Z = JNIEnv.GetMethodID (class_ref, "setDraggable", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDraggable_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_isFlat;
		static IntPtr id_setFlat_Z;
		public unsafe bool Flat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='isFlat' and count(parameter)=0]"
			[Register ("isFlat", "()Z", "GetIsFlatHandler")]
			get {
				if (id_isFlat == IntPtr.Zero)
					id_isFlat = JNIEnv.GetMethodID (class_ref, "isFlat", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFlat);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setFlat' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFlat", "(Z)V", "GetSetFlat_ZHandler")]
			set {
				if (id_setFlat_Z == IntPtr.Zero)
					id_setFlat_Z = JNIEnv.GetMethodID (class_ref, "setFlat", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFlat_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getIcon;
		static IntPtr id_setIcon_Lcom_baidu_mapapi_map_BitmapDescriptor_;
		public unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor Icon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='getIcon' and count(parameter)=0]"
			[Register ("getIcon", "()Lcom/baidu/mapapi/map/BitmapDescriptor;", "GetGetIconHandler")]
			get {
				if (id_getIcon == IntPtr.Zero)
					id_getIcon = JNIEnv.GetMethodID (class_ref, "getIcon", "()Lcom/baidu/mapapi/map/BitmapDescriptor;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIcon), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BitmapDescriptor']]"
			[Register ("setIcon", "(Lcom/baidu/mapapi/map/BitmapDescriptor;)V", "GetSetIcon_Lcom_baidu_mapapi_map_BitmapDescriptor_Handler")]
			set {
				if (id_setIcon_Lcom_baidu_mapapi_map_BitmapDescriptor_ == IntPtr.Zero)
					id_setIcon_Lcom_baidu_mapapi_map_BitmapDescriptor_ = JNIEnv.GetMethodID (class_ref, "setIcon", "(Lcom/baidu/mapapi/map/BitmapDescriptor;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIcon_Lcom_baidu_mapapi_map_BitmapDescriptor_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getIcons;
		static IntPtr id_setIcons_Ljava_util_ArrayList_;
		public unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> Icons {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='getIcons' and count(parameter)=0]"
			[Register ("getIcons", "()Ljava/util/ArrayList;", "GetGetIconsHandler")]
			get {
				if (id_getIcons == IntPtr.Zero)
					id_getIcons = JNIEnv.GetMethodID (class_ref, "getIcons", "()Ljava/util/ArrayList;");
				try {
					return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.BitmapDescriptor>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIcons), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setIcons' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.baidu.mapapi.map.BitmapDescriptor&gt;']]"
			[Register ("setIcons", "(Ljava/util/ArrayList;)V", "GetSetIcons_Ljava_util_ArrayList_Handler")]
			set {
				if (id_setIcons_Ljava_util_ArrayList_ == IntPtr.Zero)
					id_setIcons_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "setIcons", "(Ljava/util/ArrayList;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.BitmapDescriptor>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIcons_Ljava_util_ArrayList_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getPeriod;
		static IntPtr id_setPeriod_I;
		public unsafe int Period {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='getPeriod' and count(parameter)=0]"
			[Register ("getPeriod", "()I", "GetGetPeriodHandler")]
			get {
				if (id_getPeriod == IntPtr.Zero)
					id_getPeriod = JNIEnv.GetMethodID (class_ref, "getPeriod", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPeriod);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setPeriod' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPeriod", "(I)V", "GetSetPeriod_IHandler")]
			set {
				if (id_setPeriod_I == IntPtr.Zero)
					id_setPeriod_I = JNIEnv.GetMethodID (class_ref, "setPeriod", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPeriod_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_isPerspective;
		static IntPtr id_setPerspective_Z;
		public unsafe bool Perspective {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='isPerspective' and count(parameter)=0]"
			[Register ("isPerspective", "()Z", "GetIsPerspectiveHandler")]
			get {
				if (id_isPerspective == IntPtr.Zero)
					id_isPerspective = JNIEnv.GetMethodID (class_ref, "isPerspective", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPerspective);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setPerspective' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPerspective", "(Z)V", "GetSetPerspective_ZHandler")]
			set {
				if (id_setPerspective_Z == IntPtr.Zero)
					id_setPerspective_Z = JNIEnv.GetMethodID (class_ref, "setPerspective", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPerspective_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getPosition;
		static IntPtr id_setPosition_Lcom_baidu_mapapi_model_LatLng_;
		public unsafe global::Com.Baidu.Mapapi.Model.LatLng Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()Lcom/baidu/mapapi/model/LatLng;", "GetGetPositionHandler")]
			get {
				if (id_getPosition == IntPtr.Zero)
					id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()Lcom/baidu/mapapi/model/LatLng;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPosition), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
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

		static IntPtr id_getRotate;
		static IntPtr id_setRotate_F;
		public unsafe float Rotate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='getRotate' and count(parameter)=0]"
			[Register ("getRotate", "()F", "GetGetRotateHandler")]
			get {
				if (id_getRotate == IntPtr.Zero)
					id_getRotate = JNIEnv.GetMethodID (class_ref, "getRotate", "()F");
				try {
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getRotate);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setRotate' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setRotate", "(F)V", "GetSetRotate_FHandler")]
			set {
				if (id_setRotate_F == IntPtr.Zero)
					id_setRotate_F = JNIEnv.GetMethodID (class_ref, "setRotate", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRotate_F, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getTitle;
		static IntPtr id_setTitle_Ljava_lang_String_;
		public unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTitle_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_setAnchor_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setAnchor' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
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

		static IntPtr id_setToTop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setToTop' and count(parameter)=0]"
		[Register ("setToTop", "()V", "")]
		public unsafe void SetToTop ()
		{
			if (id_setToTop == IntPtr.Zero)
				id_setToTop = JNIEnv.GetMethodID (class_ref, "setToTop", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setToTop);
			} finally {
			}
		}

	}
}
