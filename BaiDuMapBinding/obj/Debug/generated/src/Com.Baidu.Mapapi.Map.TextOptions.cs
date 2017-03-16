using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/TextOptions", DoNotGenerateAcw=true)]
	public sealed partial class TextOptions : global::Com.Baidu.Mapapi.Map.OverlayOptions {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/field[@name='ALIGN_BOTTOM']"
		[Register ("ALIGN_BOTTOM")]
		public const int AlignBottom = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/field[@name='ALIGN_CENTER_HORIZONTAL']"
		[Register ("ALIGN_CENTER_HORIZONTAL")]
		public const int AlignCenterHorizontal = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/field[@name='ALIGN_CENTER_VERTICAL']"
		[Register ("ALIGN_CENTER_VERTICAL")]
		public const int AlignCenterVertical = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/field[@name='ALIGN_LEFT']"
		[Register ("ALIGN_LEFT")]
		public const int AlignLeft = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/field[@name='ALIGN_RIGHT']"
		[Register ("ALIGN_RIGHT")]
		public const int AlignRight = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/field[@name='ALIGN_TOP']"
		[Register ("ALIGN_TOP")]
		public const int AlignTop = (int) 8;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/TextOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TextOptions); }
		}

		internal TextOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/constructor[@name='TextOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TextOptions ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TextOptions)) {
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

		static IntPtr id_getAlignX;
		public unsafe float AlignX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/method[@name='getAlignX' and count(parameter)=0]"
			[Register ("getAlignX", "()F", "GetGetAlignXHandler")]
			get {
				if (id_getAlignX == IntPtr.Zero)
					id_getAlignX = JNIEnv.GetMethodID (class_ref, "getAlignX", "()F");
				try {
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getAlignX);
				} finally {
				}
			}
		}

		static IntPtr id_getAlignY;
		public unsafe float AlignY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/method[@name='getAlignY' and count(parameter)=0]"
			[Register ("getAlignY", "()F", "GetGetAlignYHandler")]
			get {
				if (id_getAlignY == IntPtr.Zero)
					id_getAlignY = JNIEnv.GetMethodID (class_ref, "getAlignY", "()F");
				try {
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getAlignY);
				} finally {
				}
			}
		}

		static IntPtr id_getBgColor;
		public unsafe int BgColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/method[@name='getBgColor' and count(parameter)=0]"
			[Register ("getBgColor", "()I", "GetGetBgColorHandler")]
			get {
				if (id_getBgColor == IntPtr.Zero)
					id_getBgColor = JNIEnv.GetMethodID (class_ref, "getBgColor", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBgColor);
				} finally {
				}
			}
		}

		static IntPtr id_getExtraInfo;
		public unsafe global::Android.OS.Bundle ExtraInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/method[@name='getExtraInfo' and count(parameter)=0]"
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

		static IntPtr id_getFontColor;
		public unsafe int FontColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/method[@name='getFontColor' and count(parameter)=0]"
			[Register ("getFontColor", "()I", "GetGetFontColorHandler")]
			get {
				if (id_getFontColor == IntPtr.Zero)
					id_getFontColor = JNIEnv.GetMethodID (class_ref, "getFontColor", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFontColor);
				} finally {
				}
			}
		}

		static IntPtr id_getFontSize;
		public unsafe int FontSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/method[@name='getFontSize' and count(parameter)=0]"
			[Register ("getFontSize", "()I", "GetGetFontSizeHandler")]
			get {
				if (id_getFontSize == IntPtr.Zero)
					id_getFontSize = JNIEnv.GetMethodID (class_ref, "getFontSize", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFontSize);
				} finally {
				}
			}
		}

		static IntPtr id_isVisible;
		public unsafe bool IsVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/method[@name='isVisible' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/method[@name='getPosition' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/method[@name='getRotate' and count(parameter)=0]"
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

		static IntPtr id_getText;
		public unsafe string Text {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/method[@name='getText' and count(parameter)=0]"
			[Register ("getText", "()Ljava/lang/String;", "GetGetTextHandler")]
			get {
				if (id_getText == IntPtr.Zero)
					id_getText = JNIEnv.GetMethodID (class_ref, "getText", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getText), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getTypeface;
		public unsafe global::Android.Graphics.Typeface Typeface {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/method[@name='getTypeface' and count(parameter)=0]"
			[Register ("getTypeface", "()Landroid/graphics/Typeface;", "GetGetTypefaceHandler")]
			get {
				if (id_getTypeface == IntPtr.Zero)
					id_getTypeface = JNIEnv.GetMethodID (class_ref, "getTypeface", "()Landroid/graphics/Typeface;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTypeface), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getZIndex;
		public unsafe int ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/method[@name='getZIndex' and count(parameter)=0]"
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

		static IntPtr id_align_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/method[@name='align' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("align", "(II)Lcom/baidu/mapapi/map/TextOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.TextOptions Align (int p0, int p1)
		{
			if (id_align_II == IntPtr.Zero)
				id_align_II = JNIEnv.GetMethodID (class_ref, "align", "(II)Lcom/baidu/mapapi/map/TextOptions;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TextOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_align_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_bgColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/method[@name='bgColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("bgColor", "(I)Lcom/baidu/mapapi/map/TextOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.TextOptions InvokeBgColor (int p0)
		{
			if (id_bgColor_I == IntPtr.Zero)
				id_bgColor_I = JNIEnv.GetMethodID (class_ref, "bgColor", "(I)Lcom/baidu/mapapi/map/TextOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TextOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_bgColor_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_extraInfo_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/method[@name='extraInfo' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("extraInfo", "(Landroid/os/Bundle;)Lcom/baidu/mapapi/map/TextOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.TextOptions InvokeExtraInfo (global::Android.OS.Bundle p0)
		{
			if (id_extraInfo_Landroid_os_Bundle_ == IntPtr.Zero)
				id_extraInfo_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "extraInfo", "(Landroid/os/Bundle;)Lcom/baidu/mapapi/map/TextOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.TextOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TextOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_extraInfo_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fontColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/method[@name='fontColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fontColor", "(I)Lcom/baidu/mapapi/map/TextOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.TextOptions InvokeFontColor (int p0)
		{
			if (id_fontColor_I == IntPtr.Zero)
				id_fontColor_I = JNIEnv.GetMethodID (class_ref, "fontColor", "(I)Lcom/baidu/mapapi/map/TextOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TextOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fontColor_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_fontSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/method[@name='fontSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fontSize", "(I)Lcom/baidu/mapapi/map/TextOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.TextOptions InvokeFontSize (int p0)
		{
			if (id_fontSize_I == IntPtr.Zero)
				id_fontSize_I = JNIEnv.GetMethodID (class_ref, "fontSize", "(I)Lcom/baidu/mapapi/map/TextOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TextOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fontSize_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_position_Lcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/method[@name='position' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("position", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/map/TextOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.TextOptions InvokePosition (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			if (id_position_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_position_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "position", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/map/TextOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.TextOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TextOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_position_Lcom_baidu_mapapi_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_rotate_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/method[@name='rotate' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("rotate", "(F)Lcom/baidu/mapapi/map/TextOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.TextOptions InvokeRotate (float p0)
		{
			if (id_rotate_F == IntPtr.Zero)
				id_rotate_F = JNIEnv.GetMethodID (class_ref, "rotate", "(F)Lcom/baidu/mapapi/map/TextOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TextOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_rotate_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_text_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/method[@name='text' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("text", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/TextOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.TextOptions InvokeText (string p0)
		{
			if (id_text_Ljava_lang_String_ == IntPtr.Zero)
				id_text_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "text", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/TextOptions;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Baidu.Mapapi.Map.TextOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TextOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_text_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_typeface_Landroid_graphics_Typeface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/method[@name='typeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
		[Register ("typeface", "(Landroid/graphics/Typeface;)Lcom/baidu/mapapi/map/TextOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.TextOptions InvokeTypeface (global::Android.Graphics.Typeface p0)
		{
			if (id_typeface_Landroid_graphics_Typeface_ == IntPtr.Zero)
				id_typeface_Landroid_graphics_Typeface_ = JNIEnv.GetMethodID (class_ref, "typeface", "(Landroid/graphics/Typeface;)Lcom/baidu/mapapi/map/TextOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.TextOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TextOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_typeface_Landroid_graphics_Typeface_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_visible_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/method[@name='visible' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("visible", "(Z)Lcom/baidu/mapapi/map/TextOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.TextOptions Visible (bool p0)
		{
			if (id_visible_Z == IntPtr.Zero)
				id_visible_Z = JNIEnv.GetMethodID (class_ref, "visible", "(Z)Lcom/baidu/mapapi/map/TextOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TextOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_visible_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_zIndex_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextOptions']/method[@name='zIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("zIndex", "(I)Lcom/baidu/mapapi/map/TextOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.TextOptions InvokeZIndex (int p0)
		{
			if (id_zIndex_I == IntPtr.Zero)
				id_zIndex_I = JNIEnv.GetMethodID (class_ref, "zIndex", "(I)Lcom/baidu/mapapi/map/TextOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TextOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_zIndex_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
