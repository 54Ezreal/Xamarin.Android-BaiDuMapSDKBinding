using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comjni.Engine {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.platform.comjni.engine']/class[@name='AppEngine']"
	[global::Android.Runtime.Register ("com/baidu/platform/comjni/engine/AppEngine", DoNotGenerateAcw=true)]
	public partial class AppEngine : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/platform/comjni/engine/AppEngine", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppEngine); }
		}

		protected AppEngine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.platform.comjni.engine']/class[@name='AppEngine']/constructor[@name='AppEngine' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AppEngine ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AppEngine)) {
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

		static IntPtr id_InitClass;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.engine']/class[@name='AppEngine']/method[@name='InitClass' and count(parameter)=0]"
		[Register ("InitClass", "()V", "")]
		public static unsafe void InitClass ()
		{
			if (id_InitClass == IntPtr.Zero)
				id_InitClass = JNIEnv.GetStaticMethodID (class_ref, "InitClass", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_InitClass);
			} finally {
			}
		}

		static IntPtr id_InitEngine_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.engine']/class[@name='AppEngine']/method[@name='InitEngine' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.engine']/class[@name='AppEngine']/method[@name='SetProxyInfo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.engine']/class[@name='AppEngine']/method[@name='StartSocketProc' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.engine']/class[@name='AppEngine']/method[@name='UnInitEngine' and count(parameter)=0]"
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

		static IntPtr id_despatchMessage_IIIJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.engine']/class[@name='AppEngine']/method[@name='despatchMessage' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("despatchMessage", "(IIIJ)V", "")]
		public static unsafe void DespatchMessage (int p0, int p1, int p2, long p3)
		{
			if (id_despatchMessage_IIIJ == IntPtr.Zero)
				id_despatchMessage_IIIJ = JNIEnv.GetStaticMethodID (class_ref, "despatchMessage", "(IIIJ)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_despatchMessage_IIIJ, __args);
			} finally {
			}
		}

	}
}
