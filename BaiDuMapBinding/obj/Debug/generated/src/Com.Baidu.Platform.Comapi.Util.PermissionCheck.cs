using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comapi.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.platform.comapi.util']/class[@name='PermissionCheck']"
	[global::Android.Runtime.Register ("com/baidu/platform/comapi/util/PermissionCheck", DoNotGenerateAcw=true)]
	public partial class PermissionCheck : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/platform/comapi/util/PermissionCheck", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PermissionCheck); }
		}

		protected PermissionCheck (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.platform.comapi.util']/class[@name='PermissionCheck']/constructor[@name='PermissionCheck' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PermissionCheck ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PermissionCheck)) {
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

		static IntPtr id_destory;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.util']/class[@name='PermissionCheck']/method[@name='destory' and count(parameter)=0]"
		[Register ("destory", "()V", "")]
		public static unsafe void Destory ()
		{
			if (id_destory == IntPtr.Zero)
				id_destory = JNIEnv.GetStaticMethodID (class_ref, "destory", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_destory);
			} finally {
			}
		}

		static IntPtr id_init_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.util']/class[@name='PermissionCheck']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "")]
		public static unsafe void Init (global::Android.Content.Context p0)
		{
			if (id_init_Landroid_content_Context_ == IntPtr.Zero)
				id_init_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_init_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_permissionCheck;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.util']/class[@name='PermissionCheck']/method[@name='permissionCheck' and count(parameter)=0]"
		[Register ("permissionCheck", "()I", "")]
		public static unsafe int InvokePermissionCheck ()
		{
			if (id_permissionCheck == IntPtr.Zero)
				id_permissionCheck = JNIEnv.GetStaticMethodID (class_ref, "permissionCheck", "()I");
			try {
				return JNIEnv.CallStaticIntMethod  (class_ref, id_permissionCheck);
			} finally {
			}
		}

	}
}
