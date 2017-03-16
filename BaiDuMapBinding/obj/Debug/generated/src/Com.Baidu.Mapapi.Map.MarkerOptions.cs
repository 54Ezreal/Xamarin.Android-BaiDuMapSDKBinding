using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/MarkerOptions", DoNotGenerateAcw=true)]
	public sealed partial class MarkerOptions : global::Com.Baidu.Mapapi.Map.OverlayOptions {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions.MarkerAnimateType']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/map/MarkerOptions$MarkerAnimateType", DoNotGenerateAcw=true)]
		public sealed partial class MarkerAnimateType : global::Java.Lang.Enum {


			static IntPtr drop_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions.MarkerAnimateType']/field[@name='drop']"
			[Register ("drop")]
			public static global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType Drop {
				get {
					if (drop_jfieldId == IntPtr.Zero)
						drop_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "drop", "Lcom/baidu/mapapi/map/MarkerOptions$MarkerAnimateType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, drop_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr grow_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions.MarkerAnimateType']/field[@name='grow']"
			[Register ("grow")]
			public static global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType Grow {
				get {
					if (grow_jfieldId == IntPtr.Zero)
						grow_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "grow", "Lcom/baidu/mapapi/map/MarkerOptions$MarkerAnimateType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, grow_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr none_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions.MarkerAnimateType']/field[@name='none']"
			[Register ("none")]
			public static global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType None {
				get {
					if (none_jfieldId == IntPtr.Zero)
						none_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "none", "Lcom/baidu/mapapi/map/MarkerOptions$MarkerAnimateType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, none_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/mapapi/map/MarkerOptions$MarkerAnimateType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MarkerAnimateType); }
			}

			internal MarkerAnimateType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions.MarkerAnimateType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/MarkerOptions$MarkerAnimateType;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/MarkerOptions$MarkerAnimateType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions.MarkerAnimateType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/baidu/mapapi/map/MarkerOptions$MarkerAnimateType;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/baidu/mapapi/map/MarkerOptions$MarkerAnimateType;");
				try {
					return (global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/MarkerOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MarkerOptions); }
		}

		internal MarkerOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/constructor[@name='MarkerOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MarkerOptions ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MarkerOptions)) {
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

		static IntPtr id_getAlpha;
		public unsafe float Alpha {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='getAlpha' and count(parameter)=0]"
			[Register ("getAlpha", "()F", "GetGetAlphaHandler")]
			get {
				if (id_getAlpha == IntPtr.Zero)
					id_getAlpha = JNIEnv.GetMethodID (class_ref, "getAlpha", "()F");
				try {
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getAlpha);
				} finally {
				}
			}
		}

		static IntPtr id_getAnchorX;
		public unsafe float AnchorX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='getAnchorX' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='getAnchorY' and count(parameter)=0]"
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

		static IntPtr id_getAnimateType;
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType AnimateType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='getAnimateType' and count(parameter)=0]"
			[Register ("getAnimateType", "()Lcom/baidu/mapapi/map/MarkerOptions$MarkerAnimateType;", "GetGetAnimateTypeHandler")]
			get {
				if (id_getAnimateType == IntPtr.Zero)
					id_getAnimateType = JNIEnv.GetMethodID (class_ref, "getAnimateType", "()Lcom/baidu/mapapi/map/MarkerOptions$MarkerAnimateType;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAnimateType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getExtraInfo;
		public unsafe global::Android.OS.Bundle ExtraInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='getExtraInfo' and count(parameter)=0]"
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

		static IntPtr id_getIcon;
		public unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor Icon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='getIcon' and count(parameter)=0]"
			[Register ("getIcon", "()Lcom/baidu/mapapi/map/BitmapDescriptor;", "GetGetIconHandler")]
			get {
				if (id_getIcon == IntPtr.Zero)
					id_getIcon = JNIEnv.GetMethodID (class_ref, "getIcon", "()Lcom/baidu/mapapi/map/BitmapDescriptor;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIcon), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getIcons;
		public unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> Icons {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='getIcons' and count(parameter)=0]"
			[Register ("getIcons", "()Ljava/util/ArrayList;", "GetGetIconsHandler")]
			get {
				if (id_getIcons == IntPtr.Zero)
					id_getIcons = JNIEnv.GetMethodID (class_ref, "getIcons", "()Ljava/util/ArrayList;");
				try {
					return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.BitmapDescriptor>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIcons), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isDraggable;
		public unsafe bool IsDraggable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='isDraggable' and count(parameter)=0]"
			[Register ("isDraggable", "()Z", "GetIsDraggableHandler")]
			get {
				if (id_isDraggable == IntPtr.Zero)
					id_isDraggable = JNIEnv.GetMethodID (class_ref, "isDraggable", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDraggable);
				} finally {
				}
			}
		}

		static IntPtr id_isFlat;
		public unsafe bool IsFlat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='isFlat' and count(parameter)=0]"
			[Register ("isFlat", "()Z", "GetIsFlatHandler")]
			get {
				if (id_isFlat == IntPtr.Zero)
					id_isFlat = JNIEnv.GetMethodID (class_ref, "isFlat", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFlat);
				} finally {
				}
			}
		}

		static IntPtr id_isPerspective;
		public unsafe bool IsPerspective {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='isPerspective' and count(parameter)=0]"
			[Register ("isPerspective", "()Z", "GetIsPerspectiveHandler")]
			get {
				if (id_isPerspective == IntPtr.Zero)
					id_isPerspective = JNIEnv.GetMethodID (class_ref, "isPerspective", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPerspective);
				} finally {
				}
			}
		}

		static IntPtr id_isVisible;
		public unsafe bool IsVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='isVisible' and count(parameter)=0]"
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

		static IntPtr id_getPeriod;
		public unsafe int Period {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='getPeriod' and count(parameter)=0]"
			[Register ("getPeriod", "()I", "GetGetPeriodHandler")]
			get {
				if (id_getPeriod == IntPtr.Zero)
					id_getPeriod = JNIEnv.GetMethodID (class_ref, "getPeriod", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPeriod);
				} finally {
				}
			}
		}

		static IntPtr id_getPosition;
		public unsafe global::Com.Baidu.Mapapi.Model.LatLng Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='getPosition' and count(parameter)=0]"
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

		static IntPtr id_getRotate;
		public unsafe float Rotate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='getRotate' and count(parameter)=0]"
			[Register ("getRotate", "()F", "GetGetRotateHandler")]
			get {
				if (id_getRotate == IntPtr.Zero)
					id_getRotate = JNIEnv.GetMethodID (class_ref, "getRotate", "()F");
				try {
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getRotate);
				} finally {
				}
			}
		}

		static IntPtr id_getTitle;
		public unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getZIndex;
		public unsafe int ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='getZIndex' and count(parameter)=0]"
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

		static IntPtr id_alpha_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='alpha' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("alpha", "(F)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions InvokeAlpha (float p0)
		{
			if (id_alpha_F == IntPtr.Zero)
				id_alpha_F = JNIEnv.GetMethodID (class_ref, "alpha", "(F)Lcom/baidu/mapapi/map/MarkerOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_alpha_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_anchor_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='anchor' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("anchor", "(FF)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions Anchor (float p0, float p1)
		{
			if (id_anchor_FF == IntPtr.Zero)
				id_anchor_FF = JNIEnv.GetMethodID (class_ref, "anchor", "(FF)Lcom/baidu/mapapi/map/MarkerOptions;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_anchor_FF, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_animateType_Lcom_baidu_mapapi_map_MarkerOptions_MarkerAnimateType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='animateType' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MarkerOptions.MarkerAnimateType']]"
		[Register ("animateType", "(Lcom/baidu/mapapi/map/MarkerOptions$MarkerAnimateType;)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions InvokeAnimateType (global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType p0)
		{
			if (id_animateType_Lcom_baidu_mapapi_map_MarkerOptions_MarkerAnimateType_ == IntPtr.Zero)
				id_animateType_Lcom_baidu_mapapi_map_MarkerOptions_MarkerAnimateType_ = JNIEnv.GetMethodID (class_ref, "animateType", "(Lcom/baidu/mapapi/map/MarkerOptions$MarkerAnimateType;)Lcom/baidu/mapapi/map/MarkerOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.MarkerOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_animateType_Lcom_baidu_mapapi_map_MarkerOptions_MarkerAnimateType_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_draggable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='draggable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("draggable", "(Z)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions Draggable (bool p0)
		{
			if (id_draggable_Z == IntPtr.Zero)
				id_draggable_Z = JNIEnv.GetMethodID (class_ref, "draggable", "(Z)Lcom/baidu/mapapi/map/MarkerOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_draggable_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_extraInfo_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='extraInfo' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("extraInfo", "(Landroid/os/Bundle;)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions InvokeExtraInfo (global::Android.OS.Bundle p0)
		{
			if (id_extraInfo_Landroid_os_Bundle_ == IntPtr.Zero)
				id_extraInfo_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "extraInfo", "(Landroid/os/Bundle;)Lcom/baidu/mapapi/map/MarkerOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.MarkerOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_extraInfo_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_flat_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='flat' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("flat", "(Z)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions Flat (bool p0)
		{
			if (id_flat_Z == IntPtr.Zero)
				id_flat_Z = JNIEnv.GetMethodID (class_ref, "flat", "(Z)Lcom/baidu/mapapi/map/MarkerOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flat_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_icon_Lcom_baidu_mapapi_map_BitmapDescriptor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='icon' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BitmapDescriptor']]"
		[Register ("icon", "(Lcom/baidu/mapapi/map/BitmapDescriptor;)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions InvokeIcon (global::Com.Baidu.Mapapi.Map.BitmapDescriptor p0)
		{
			if (id_icon_Lcom_baidu_mapapi_map_BitmapDescriptor_ == IntPtr.Zero)
				id_icon_Lcom_baidu_mapapi_map_BitmapDescriptor_ = JNIEnv.GetMethodID (class_ref, "icon", "(Lcom/baidu/mapapi/map/BitmapDescriptor;)Lcom/baidu/mapapi/map/MarkerOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.MarkerOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_icon_Lcom_baidu_mapapi_map_BitmapDescriptor_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_icons_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='icons' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.baidu.mapapi.map.BitmapDescriptor&gt;']]"
		[Register ("icons", "(Ljava/util/ArrayList;)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions InvokeIcons (global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> p0)
		{
			if (id_icons_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_icons_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "icons", "(Ljava/util/ArrayList;)Lcom/baidu/mapapi/map/MarkerOptions;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.BitmapDescriptor>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Baidu.Mapapi.Map.MarkerOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_icons_Ljava_util_ArrayList_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_period_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='period' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("period", "(I)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions InvokePeriod (int p0)
		{
			if (id_period_I == IntPtr.Zero)
				id_period_I = JNIEnv.GetMethodID (class_ref, "period", "(I)Lcom/baidu/mapapi/map/MarkerOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_period_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_perspective_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='perspective' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("perspective", "(Z)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions Perspective (bool p0)
		{
			if (id_perspective_Z == IntPtr.Zero)
				id_perspective_Z = JNIEnv.GetMethodID (class_ref, "perspective", "(Z)Lcom/baidu/mapapi/map/MarkerOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_perspective_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_position_Lcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='position' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("position", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions InvokePosition (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			if (id_position_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_position_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "position", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/map/MarkerOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.MarkerOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_position_Lcom_baidu_mapapi_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_rotate_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='rotate' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("rotate", "(F)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions InvokeRotate (float p0)
		{
			if (id_rotate_F == IntPtr.Zero)
				id_rotate_F = JNIEnv.GetMethodID (class_ref, "rotate", "(F)Lcom/baidu/mapapi/map/MarkerOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_rotate_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_title_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='title' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("title", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions InvokeTitle (string p0)
		{
			if (id_title_Ljava_lang_String_ == IntPtr.Zero)
				id_title_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "title", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/MarkerOptions;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Baidu.Mapapi.Map.MarkerOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_title_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_visible_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='visible' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("visible", "(Z)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions Visible (bool p0)
		{
			if (id_visible_Z == IntPtr.Zero)
				id_visible_Z = JNIEnv.GetMethodID (class_ref, "visible", "(Z)Lcom/baidu/mapapi/map/MarkerOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_visible_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_zIndex_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='zIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("zIndex", "(I)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions InvokeZIndex (int p0)
		{
			if (id_zIndex_I == IntPtr.Zero)
				id_zIndex_I = JNIEnv.GetMethodID (class_ref, "zIndex", "(I)Lcom/baidu/mapapi/map/MarkerOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_zIndex_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
