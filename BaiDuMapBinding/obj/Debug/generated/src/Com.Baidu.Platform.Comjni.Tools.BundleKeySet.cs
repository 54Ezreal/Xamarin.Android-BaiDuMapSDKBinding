using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comjni.Tools {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.platform.comjni.tools']/class[@name='BundleKeySet']"
	[global::Android.Runtime.Register ("com/baidu/platform/comjni/tools/BundleKeySet", DoNotGenerateAcw=true)]
	public partial class BundleKeySet : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/platform/comjni/tools/BundleKeySet", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BundleKeySet); }
		}

		protected BundleKeySet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.platform.comjni.tools']/class[@name='BundleKeySet']/constructor[@name='BundleKeySet' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BundleKeySet ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BundleKeySet)) {
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

		static Delegate cb_getBundleKeys_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetBundleKeys_Landroid_os_Bundle_Handler ()
		{
			if (cb_getBundleKeys_Landroid_os_Bundle_ == null)
				cb_getBundleKeys_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBundleKeys_Landroid_os_Bundle_);
			return cb_getBundleKeys_Landroid_os_Bundle_;
		}

		static IntPtr n_GetBundleKeys_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Platform.Comjni.Tools.BundleKeySet __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Tools.BundleKeySet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetBundleKeys (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBundleKeys_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.tools']/class[@name='BundleKeySet']/method[@name='getBundleKeys' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getBundleKeys", "(Landroid/os/Bundle;)[Ljava/lang/String;", "GetGetBundleKeys_Landroid_os_Bundle_Handler")]
		public virtual unsafe string[] GetBundleKeys (global::Android.OS.Bundle p0)
		{
			if (id_getBundleKeys_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getBundleKeys_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "getBundleKeys", "(Landroid/os/Bundle;)[Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBundleKeys_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					__ret = (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBundleKeys", "(Landroid/os/Bundle;)[Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
			}
		}

	}
}
