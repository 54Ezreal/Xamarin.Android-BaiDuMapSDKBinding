using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='BMapManager']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/BMapManager", DoNotGenerateAcw=true)]
	public partial class BMapManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/BMapManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BMapManager); }
		}

		protected BMapManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='BMapManager']/constructor[@name='BMapManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BMapManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BMapManager)) {
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

		static IntPtr id_getContext;
		public static unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='BMapManager']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				if (id_getContext == IntPtr.Zero)
					id_getContext = JNIEnv.GetStaticMethodID (class_ref, "getContext", "()Landroid/content/Context;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getContext), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='BMapManager']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "")]
		public static unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetStaticMethodID (class_ref, "destroy", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_destroy);
			} finally {
			}
		}

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='BMapManager']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "")]
		public static unsafe void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetStaticMethodID (class_ref, "init", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_init);
			} finally {
			}
		}

	}
}
