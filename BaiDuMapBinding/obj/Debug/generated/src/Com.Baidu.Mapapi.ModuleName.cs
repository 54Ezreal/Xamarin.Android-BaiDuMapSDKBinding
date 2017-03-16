using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='ModuleName']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/ModuleName", DoNotGenerateAcw=true)]
	public sealed partial class ModuleName : global::Java.Lang.Enum {


		static IntPtr TILE_OVERLAY_MODULE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='ModuleName']/field[@name='TILE_OVERLAY_MODULE']"
		[Register ("TILE_OVERLAY_MODULE")]
		public static global::Com.Baidu.Mapapi.ModuleName TileOverlayModule {
			get {
				if (TILE_OVERLAY_MODULE_jfieldId == IntPtr.Zero)
					TILE_OVERLAY_MODULE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TILE_OVERLAY_MODULE", "Lcom/baidu/mapapi/ModuleName;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TILE_OVERLAY_MODULE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.ModuleName> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/ModuleName", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ModuleName); }
		}

		internal ModuleName (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='ModuleName']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/ModuleName;", "")]
		public static unsafe global::Com.Baidu.Mapapi.ModuleName ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/ModuleName;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Baidu.Mapapi.ModuleName __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.ModuleName> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='ModuleName']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/baidu/mapapi/ModuleName;", "")]
		public static unsafe global::Com.Baidu.Mapapi.ModuleName[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/baidu/mapapi/ModuleName;");
			try {
				return (global::Com.Baidu.Mapapi.ModuleName[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.ModuleName));
			} finally {
			}
		}

	}
}
