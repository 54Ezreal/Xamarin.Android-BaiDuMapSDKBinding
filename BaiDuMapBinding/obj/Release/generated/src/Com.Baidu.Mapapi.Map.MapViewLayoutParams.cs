using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/MapViewLayoutParams", DoNotGenerateAcw=true)]
	public sealed partial class MapViewLayoutParams : global::Android.Views.ViewGroup.LayoutParams {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams']/field[@name='ALIGN_BOTTOM']"
		[Register ("ALIGN_BOTTOM")]
		public const int AlignBottom = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams']/field[@name='ALIGN_CENTER_HORIZONTAL']"
		[Register ("ALIGN_CENTER_HORIZONTAL")]
		public const int AlignCenterHorizontal = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams']/field[@name='ALIGN_CENTER_VERTICAL']"
		[Register ("ALIGN_CENTER_VERTICAL")]
		public const int AlignCenterVertical = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams']/field[@name='ALIGN_LEFT']"
		[Register ("ALIGN_LEFT")]
		public const int AlignLeft = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams']/field[@name='ALIGN_RIGHT']"
		[Register ("ALIGN_RIGHT")]
		public const int AlignRight = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams']/field[@name='ALIGN_TOP']"
		[Register ("ALIGN_TOP")]
		public const int AlignTop = (int) 8;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.Builder']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/map/MapViewLayoutParams$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/mapapi/map/MapViewLayoutParams$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.Builder']/constructor[@name='MapViewLayoutParams.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Builder)) {
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

			static IntPtr id_align_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.Builder']/method[@name='align' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("align", "(II)Lcom/baidu/mapapi/map/MapViewLayoutParams$Builder;", "")]
			public unsafe global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder Align (int p0, int p1)
			{
				if (id_align_II == IntPtr.Zero)
					id_align_II = JNIEnv.GetMethodID (class_ref, "align", "(II)Lcom/baidu/mapapi/map/MapViewLayoutParams$Builder;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_align_II, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/baidu/mapapi/map/MapViewLayoutParams;", "")]
			public unsafe global::Com.Baidu.Mapapi.Map.MapViewLayoutParams Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/baidu/mapapi/map/MapViewLayoutParams;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapViewLayoutParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_height_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.Builder']/method[@name='height' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("height", "(I)Lcom/baidu/mapapi/map/MapViewLayoutParams$Builder;", "")]
			public unsafe global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder Height (int p0)
			{
				if (id_height_I == IntPtr.Zero)
					id_height_I = JNIEnv.GetMethodID (class_ref, "height", "(I)Lcom/baidu/mapapi/map/MapViewLayoutParams$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_height_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_layoutMode_Lcom_baidu_mapapi_map_MapViewLayoutParams_ELayoutMode_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.Builder']/method[@name='layoutMode' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MapViewLayoutParams.ELayoutMode']]"
			[Register ("layoutMode", "(Lcom/baidu/mapapi/map/MapViewLayoutParams$ELayoutMode;)Lcom/baidu/mapapi/map/MapViewLayoutParams$Builder;", "")]
			public unsafe global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder LayoutMode (global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.ELayoutMode p0)
			{
				if (id_layoutMode_Lcom_baidu_mapapi_map_MapViewLayoutParams_ELayoutMode_ == IntPtr.Zero)
					id_layoutMode_Lcom_baidu_mapapi_map_MapViewLayoutParams_ELayoutMode_ = JNIEnv.GetMethodID (class_ref, "layoutMode", "(Lcom/baidu/mapapi/map/MapViewLayoutParams$ELayoutMode;)Lcom/baidu/mapapi/map/MapViewLayoutParams$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_layoutMode_Lcom_baidu_mapapi_map_MapViewLayoutParams_ELayoutMode_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_point_Landroid_graphics_Point_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.Builder']/method[@name='point' and count(parameter)=1 and parameter[1][@type='android.graphics.Point']]"
			[Register ("point", "(Landroid/graphics/Point;)Lcom/baidu/mapapi/map/MapViewLayoutParams$Builder;", "")]
			public unsafe global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder Point (global::Android.Graphics.Point p0)
			{
				if (id_point_Landroid_graphics_Point_ == IntPtr.Zero)
					id_point_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "point", "(Landroid/graphics/Point;)Lcom/baidu/mapapi/map/MapViewLayoutParams$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_point_Landroid_graphics_Point_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_position_Lcom_baidu_mapapi_model_LatLng_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.Builder']/method[@name='position' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
			[Register ("position", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/map/MapViewLayoutParams$Builder;", "")]
			public unsafe global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder Position (global::Com.Baidu.Mapapi.Model.LatLng p0)
			{
				if (id_position_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
					id_position_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "position", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/map/MapViewLayoutParams$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_position_Lcom_baidu_mapapi_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_width_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.Builder']/method[@name='width' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("width", "(I)Lcom/baidu/mapapi/map/MapViewLayoutParams$Builder;", "")]
			public unsafe global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder Width (int p0)
			{
				if (id_width_I == IntPtr.Zero)
					id_width_I = JNIEnv.GetMethodID (class_ref, "width", "(I)Lcom/baidu/mapapi/map/MapViewLayoutParams$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_width_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_yOffset_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.Builder']/method[@name='yOffset' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("yOffset", "(I)Lcom/baidu/mapapi/map/MapViewLayoutParams$Builder;", "")]
			public unsafe global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder YOffset (int p0)
			{
				if (id_yOffset_I == IntPtr.Zero)
					id_yOffset_I = JNIEnv.GetMethodID (class_ref, "yOffset", "(I)Lcom/baidu/mapapi/map/MapViewLayoutParams$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_yOffset_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.ELayoutMode']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/map/MapViewLayoutParams$ELayoutMode", DoNotGenerateAcw=true)]
		public sealed partial class ELayoutMode : global::Java.Lang.Enum {


			static IntPtr absoluteMode_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.ELayoutMode']/field[@name='absoluteMode']"
			[Register ("absoluteMode")]
			public static global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.ELayoutMode AbsoluteMode {
				get {
					if (absoluteMode_jfieldId == IntPtr.Zero)
						absoluteMode_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "absoluteMode", "Lcom/baidu/mapapi/map/MapViewLayoutParams$ELayoutMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, absoluteMode_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.ELayoutMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr mapMode_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.ELayoutMode']/field[@name='mapMode']"
			[Register ("mapMode")]
			public static global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.ELayoutMode MapMode {
				get {
					if (mapMode_jfieldId == IntPtr.Zero)
						mapMode_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mapMode", "Lcom/baidu/mapapi/map/MapViewLayoutParams$ELayoutMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, mapMode_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.ELayoutMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/mapapi/map/MapViewLayoutParams$ELayoutMode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ELayoutMode); }
			}

			internal ELayoutMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.ELayoutMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/MapViewLayoutParams$ELayoutMode;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.ELayoutMode ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/MapViewLayoutParams$ELayoutMode;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.ELayoutMode __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.ELayoutMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.ELayoutMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/baidu/mapapi/map/MapViewLayoutParams$ELayoutMode;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.ELayoutMode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/baidu/mapapi/map/MapViewLayoutParams$ELayoutMode;");
				try {
					return (global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.ELayoutMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.ELayoutMode));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/MapViewLayoutParams", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapViewLayoutParams); }
		}

		internal MapViewLayoutParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
