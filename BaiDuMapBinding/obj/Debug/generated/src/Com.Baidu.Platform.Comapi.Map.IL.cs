using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comapi.Map {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.platform.comapi.map']/interface[@name='L']"
	[Register ("com/baidu/platform/comapi/map/L", "", "Com.Baidu.Platform.Comapi.Map.ILInvoker")]
	public partial interface IL : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/interface[@name='L']/method[@name='a' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.content.Context']]"
		[Register ("a", "(IIILandroid/content/Context;)Landroid/os/Bundle;", "GetA_IIILandroid_content_Context_Handler:Com.Baidu.Platform.Comapi.Map.ILInvoker, XamarinBaiDuMapSDKBinding")]
		global::Android.OS.Bundle A (int p0, int p1, int p2, global::Android.Content.Context p3);

	}

	[global::Android.Runtime.Register ("com/baidu/platform/comapi/map/L", DoNotGenerateAcw=true)]
	internal class ILInvoker : global::Java.Lang.Object, IL {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/platform/comapi/map/L");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ILInvoker); }
		}

		IntPtr class_ref;

		public static IL GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IL> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.baidu.platform.comapi.map.L"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_a_IIILandroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetA_IIILandroid_content_Context_Handler ()
		{
			if (cb_a_IIILandroid_content_Context_ == null)
				cb_a_IIILandroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, IntPtr, IntPtr>) n_A_IIILandroid_content_Context_);
			return cb_a_IIILandroid_content_Context_;
		}

		static IntPtr n_A_IIILandroid_content_Context_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
		{
			global::Com.Baidu.Platform.Comapi.Map.IL __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.IL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p3 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.A (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_a_IIILandroid_content_Context_;
		public unsafe global::Android.OS.Bundle A (int p0, int p1, int p2, global::Android.Content.Context p3)
		{
			if (id_a_IIILandroid_content_Context_ == IntPtr.Zero)
				id_a_IIILandroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "a", "(IIILandroid/content/Context;)Landroid/os/Bundle;");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_a_IIILandroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
