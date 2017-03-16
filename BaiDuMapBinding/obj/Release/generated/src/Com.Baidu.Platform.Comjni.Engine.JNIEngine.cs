using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comjni.Engine {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.platform.comjni.engine']/class[@name='JNIEngine']"
	[global::Android.Runtime.Register ("com/baidu/platform/comjni/engine/JNIEngine", DoNotGenerateAcw=true)]
	public partial class JNIEngine : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/platform/comjni/engine/JNIEngine", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JNIEngine); }
		}

		protected JNIEngine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_InitEngine_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.engine']/class[@name='JNIEngine']/method[@name='InitEngine' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("InitEngine", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool InitEngine (global::Android.Content.Context p0)
		{
			if (id_InitEngine_Landroid_content_Context_ == IntPtr.Zero)
				id_InitEngine_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "InitEngine", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_InitEngine_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_SetProxyInfo_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.engine']/class[@name='JNIEngine']/method[@name='SetProxyInfo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("SetProxyInfo", "(Ljava/lang/String;I)V", "")]
		public static unsafe void SetProxyInfo (string p0, int p1)
		{
			if (id_SetProxyInfo_Ljava_lang_String_I == IntPtr.Zero)
				id_SetProxyInfo_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "SetProxyInfo", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_SetProxyInfo_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_StartSocketProc;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.engine']/class[@name='JNIEngine']/method[@name='StartSocketProc' and count(parameter)=0]"
		[Register ("StartSocketProc", "()Z", "")]
		public static unsafe bool StartSocketProc ()
		{
			if (id_StartSocketProc == IntPtr.Zero)
				id_StartSocketProc = JNIEnv.GetStaticMethodID (class_ref, "StartSocketProc", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_StartSocketProc);
			} finally {
			}
		}

		static IntPtr id_UnInitEngine;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.engine']/class[@name='JNIEngine']/method[@name='UnInitEngine' and count(parameter)=0]"
		[Register ("UnInitEngine", "()Z", "")]
		public static unsafe bool UnInitEngine ()
		{
			if (id_UnInitEngine == IntPtr.Zero)
				id_UnInitEngine = JNIEnv.GetStaticMethodID (class_ref, "UnInitEngine", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_UnInitEngine);
			} finally {
			}
		}

		static IntPtr id_initClass_Ljava_lang_Object_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.engine']/class[@name='JNIEngine']/method[@name='initClass' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='int']]"
		[Register ("initClass", "(Ljava/lang/Object;I)I", "")]
		public static unsafe int InitClass (global::Java.Lang.Object p0, int p1)
		{
			if (id_initClass_Ljava_lang_Object_I == IntPtr.Zero)
				id_initClass_Ljava_lang_Object_I = JNIEnv.GetStaticMethodID (class_ref, "initClass", "(Ljava/lang/Object;I)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_initClass_Ljava_lang_Object_I, __args);
				return __ret;
			} finally {
			}
		}

	}
}
