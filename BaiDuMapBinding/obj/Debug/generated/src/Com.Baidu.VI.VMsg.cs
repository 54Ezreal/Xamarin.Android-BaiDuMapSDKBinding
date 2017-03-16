using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.VI {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.vi']/class[@name='VMsg']"
	[global::Android.Runtime.Register ("com/baidu/vi/VMsg", DoNotGenerateAcw=true)]
	public partial class VMsg : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/vi/VMsg", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VMsg); }
		}

		protected VMsg (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.vi']/class[@name='VMsg']/constructor[@name='VMsg' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VMsg ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VMsg)) {
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

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VMsg']/method[@name='destroy' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.vi']/class[@name='VMsg']/method[@name='init' and count(parameter)=0]"
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
