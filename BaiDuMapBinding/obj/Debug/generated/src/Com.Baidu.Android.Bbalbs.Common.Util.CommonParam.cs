using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Android.Bbalbs.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.android.bbalbs.common.util']/class[@name='CommonParam']"
	[global::Android.Runtime.Register ("com/baidu/android/bbalbs/common/util/CommonParam", DoNotGenerateAcw=true)]
	public partial class CommonParam : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/android/bbalbs/common/util/CommonParam", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CommonParam); }
		}

		protected CommonParam (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.android.bbalbs.common.util']/class[@name='CommonParam']/constructor[@name='CommonParam' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CommonParam ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CommonParam)) {
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

		static IntPtr id_a_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.bbalbs.common.util']/class[@name='CommonParam']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("a", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string A (global::Android.Content.Context p0)
		{
			if (id_a_Landroid_content_Context_ == IntPtr.Zero)
				id_a_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
