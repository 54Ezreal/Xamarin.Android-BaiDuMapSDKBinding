using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='JNIInitializer']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/JNIInitializer", DoNotGenerateAcw=true)]
	public partial class JNIInitializer : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/JNIInitializer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JNIInitializer); }
		}

		protected JNIInitializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='JNIInitializer']/constructor[@name='JNIInitializer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JNIInitializer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (JNIInitializer)) {
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

		static IntPtr id_getCachedContext;
		public static unsafe global::Android.Content.Context CachedContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='JNIInitializer']/method[@name='getCachedContext' and count(parameter)=0]"
			[Register ("getCachedContext", "()Landroid/content/Context;", "GetGetCachedContextHandler")]
			get {
				if (id_getCachedContext == IntPtr.Zero)
					id_getCachedContext = JNIEnv.GetStaticMethodID (class_ref, "getCachedContext", "()Landroid/content/Context;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCachedContext), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_setContext_Landroid_app_Application_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='JNIInitializer']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
		[Register ("setContext", "(Landroid/app/Application;)V", "")]
		public static unsafe void SetContext (global::Android.App.Application p0)
		{
			if (id_setContext_Landroid_app_Application_ == IntPtr.Zero)
				id_setContext_Landroid_app_Application_ = JNIEnv.GetStaticMethodID (class_ref, "setContext", "(Landroid/app/Application;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setContext_Landroid_app_Application_, __args);
			} finally {
			}
		}

	}
}
