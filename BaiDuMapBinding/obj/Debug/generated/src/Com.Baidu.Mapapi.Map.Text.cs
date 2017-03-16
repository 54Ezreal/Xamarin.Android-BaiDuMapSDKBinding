using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Text']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/Text", DoNotGenerateAcw=true)]
	public sealed partial class Text : global::Com.Baidu.Mapapi.Map.Overlay {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/Text", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Text); }
		}

		internal Text (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAlignX;
		public unsafe float AlignX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Text']/method[@name='getAlignX' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Text']/method[@name='getAlignY' and count(parameter)=0]"
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
		static IntPtr id_setBgColor_I;
		public unsafe int BgColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Text']/method[@name='getBgColor' and count(parameter)=0]"
			[Register ("getBgColor", "()I", "GetGetBgColorHandler")]
			get {
				if (id_getBgColor == IntPtr.Zero)
					id_getBgColor = JNIEnv.GetMethodID (class_ref, "getBgColor", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBgColor);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Text']/method[@name='setBgColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBgColor", "(I)V", "GetSetBgColor_IHandler")]
			set {
				if (id_setBgColor_I == IntPtr.Zero)
					id_setBgColor_I = JNIEnv.GetMethodID (class_ref, "setBgColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBgColor_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getFontColor;
		static IntPtr id_setFontColor_I;
		public unsafe int FontColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Text']/method[@name='getFontColor' and count(parameter)=0]"
			[Register ("getFontColor", "()I", "GetGetFontColorHandler")]
			get {
				if (id_getFontColor == IntPtr.Zero)
					id_getFontColor = JNIEnv.GetMethodID (class_ref, "getFontColor", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFontColor);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Text']/method[@name='setFontColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFontColor", "(I)V", "GetSetFontColor_IHandler")]
			set {
				if (id_setFontColor_I == IntPtr.Zero)
					id_setFontColor_I = JNIEnv.GetMethodID (class_ref, "setFontColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFontColor_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getFontSize;
		static IntPtr id_setFontSize_I;
		public unsafe int FontSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Text']/method[@name='getFontSize' and count(parameter)=0]"
			[Register ("getFontSize", "()I", "GetGetFontSizeHandler")]
			get {
				if (id_getFontSize == IntPtr.Zero)
					id_getFontSize = JNIEnv.GetMethodID (class_ref, "getFontSize", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFontSize);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Text']/method[@name='setFontSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFontSize", "(I)V", "GetSetFontSize_IHandler")]
			set {
				if (id_setFontSize_I == IntPtr.Zero)
					id_setFontSize_I = JNIEnv.GetMethodID (class_ref, "setFontSize", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFontSize_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getPosition;
		static IntPtr id_setPosition_Lcom_baidu_mapapi_model_LatLng_;
		public unsafe global::Com.Baidu.Mapapi.Model.LatLng Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Text']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()Lcom/baidu/mapapi/model/LatLng;", "GetGetPositionHandler")]
			get {
				if (id_getPosition == IntPtr.Zero)
					id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()Lcom/baidu/mapapi/model/LatLng;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPosition), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Text']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Text']/method[@name='getRotate' and count(parameter)=0]"
			[Register ("getRotate", "()F", "GetGetRotateHandler")]
			get {
				if (id_getRotate == IntPtr.Zero)
					id_getRotate = JNIEnv.GetMethodID (class_ref, "getRotate", "()F");
				try {
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getRotate);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Text']/method[@name='setRotate' and count(parameter)=1 and parameter[1][@type='float']]"
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

		static IntPtr id_getTypeface;
		static IntPtr id_setTypeface_Landroid_graphics_Typeface_;
		public unsafe global::Android.Graphics.Typeface Typeface {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Text']/method[@name='getTypeface' and count(parameter)=0]"
			[Register ("getTypeface", "()Landroid/graphics/Typeface;", "GetGetTypefaceHandler")]
			get {
				if (id_getTypeface == IntPtr.Zero)
					id_getTypeface = JNIEnv.GetMethodID (class_ref, "getTypeface", "()Landroid/graphics/Typeface;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTypeface), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Text']/method[@name='setTypeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
			[Register ("setTypeface", "(Landroid/graphics/Typeface;)V", "GetSetTypeface_Landroid_graphics_Typeface_Handler")]
			set {
				if (id_setTypeface_Landroid_graphics_Typeface_ == IntPtr.Zero)
					id_setTypeface_Landroid_graphics_Typeface_ = JNIEnv.GetMethodID (class_ref, "setTypeface", "(Landroid/graphics/Typeface;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTypeface_Landroid_graphics_Typeface_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getText;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Text']/method[@name='getText' and count(parameter)=0]"
		[Register ("getText", "()Ljava/lang/String;", "")]
		public unsafe string GetText ()
		{
			if (id_getText == IntPtr.Zero)
				id_getText = JNIEnv.GetMethodID (class_ref, "getText", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getText), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setAlign_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Text']/method[@name='setAlign' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setAlign", "(II)V", "")]
		public unsafe void SetAlign (int p0, int p1)
		{
			if (id_setAlign_II == IntPtr.Zero)
				id_setAlign_II = JNIEnv.GetMethodID (class_ref, "setAlign", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAlign_II, __args);
			} finally {
			}
		}

		static IntPtr id_setText_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Text']/method[@name='setText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setText", "(Ljava/lang/String;)V", "")]
		public unsafe void SetText (string p0)
		{
			if (id_setText_Ljava_lang_String_ == IntPtr.Zero)
				id_setText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setText", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setText_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
