using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='LogoPosition']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/LogoPosition", DoNotGenerateAcw=true)]
	public sealed partial class LogoPosition : global::Java.Lang.Enum {


		static IntPtr logoPostionCenterBottom_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='LogoPosition']/field[@name='logoPostionCenterBottom']"
		[Register ("logoPostionCenterBottom")]
		public static global::Com.Baidu.Mapapi.Map.LogoPosition LogoPostionCenterBottom {
			get {
				if (logoPostionCenterBottom_jfieldId == IntPtr.Zero)
					logoPostionCenterBottom_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "logoPostionCenterBottom", "Lcom/baidu/mapapi/map/LogoPosition;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, logoPostionCenterBottom_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.LogoPosition> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr logoPostionCenterTop_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='LogoPosition']/field[@name='logoPostionCenterTop']"
		[Register ("logoPostionCenterTop")]
		public static global::Com.Baidu.Mapapi.Map.LogoPosition LogoPostionCenterTop {
			get {
				if (logoPostionCenterTop_jfieldId == IntPtr.Zero)
					logoPostionCenterTop_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "logoPostionCenterTop", "Lcom/baidu/mapapi/map/LogoPosition;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, logoPostionCenterTop_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.LogoPosition> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr logoPostionRightBottom_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='LogoPosition']/field[@name='logoPostionRightBottom']"
		[Register ("logoPostionRightBottom")]
		public static global::Com.Baidu.Mapapi.Map.LogoPosition LogoPostionRightBottom {
			get {
				if (logoPostionRightBottom_jfieldId == IntPtr.Zero)
					logoPostionRightBottom_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "logoPostionRightBottom", "Lcom/baidu/mapapi/map/LogoPosition;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, logoPostionRightBottom_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.LogoPosition> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr logoPostionRightTop_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='LogoPosition']/field[@name='logoPostionRightTop']"
		[Register ("logoPostionRightTop")]
		public static global::Com.Baidu.Mapapi.Map.LogoPosition LogoPostionRightTop {
			get {
				if (logoPostionRightTop_jfieldId == IntPtr.Zero)
					logoPostionRightTop_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "logoPostionRightTop", "Lcom/baidu/mapapi/map/LogoPosition;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, logoPostionRightTop_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.LogoPosition> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr logoPostionleftBottom_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='LogoPosition']/field[@name='logoPostionleftBottom']"
		[Register ("logoPostionleftBottom")]
		public static global::Com.Baidu.Mapapi.Map.LogoPosition LogoPostionleftBottom {
			get {
				if (logoPostionleftBottom_jfieldId == IntPtr.Zero)
					logoPostionleftBottom_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "logoPostionleftBottom", "Lcom/baidu/mapapi/map/LogoPosition;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, logoPostionleftBottom_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.LogoPosition> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr logoPostionleftTop_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='LogoPosition']/field[@name='logoPostionleftTop']"
		[Register ("logoPostionleftTop")]
		public static global::Com.Baidu.Mapapi.Map.LogoPosition LogoPostionleftTop {
			get {
				if (logoPostionleftTop_jfieldId == IntPtr.Zero)
					logoPostionleftTop_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "logoPostionleftTop", "Lcom/baidu/mapapi/map/LogoPosition;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, logoPostionleftTop_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.LogoPosition> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/LogoPosition", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LogoPosition); }
		}

		internal LogoPosition (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='LogoPosition']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/LogoPosition;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.LogoPosition ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/LogoPosition;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Baidu.Mapapi.Map.LogoPosition __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.LogoPosition> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='LogoPosition']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/baidu/mapapi/map/LogoPosition;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.LogoPosition[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/baidu/mapapi/map/LogoPosition;");
			try {
				return (global::Com.Baidu.Mapapi.Map.LogoPosition[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.Map.LogoPosition));
			} finally {
			}
		}

	}
}
