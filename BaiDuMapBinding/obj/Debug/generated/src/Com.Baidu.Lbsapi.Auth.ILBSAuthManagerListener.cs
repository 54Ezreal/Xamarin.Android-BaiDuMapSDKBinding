using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Lbsapi.Auth {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.lbsapi.auth']/interface[@name='LBSAuthManagerListener']"
	[Register ("com/baidu/lbsapi/auth/LBSAuthManagerListener", "", "Com.Baidu.Lbsapi.Auth.ILBSAuthManagerListenerInvoker")]
	public partial interface ILBSAuthManagerListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.lbsapi.auth']/interface[@name='LBSAuthManagerListener']/method[@name='onAuthResult' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onAuthResult", "(ILjava/lang/String;)V", "GetOnAuthResult_ILjava_lang_String_Handler:Com.Baidu.Lbsapi.Auth.ILBSAuthManagerListenerInvoker, XamarinBaiDuMapSDKBinding")]
		void OnAuthResult (int p0, string p1);

	}

	[global::Android.Runtime.Register ("com/baidu/lbsapi/auth/LBSAuthManagerListener", DoNotGenerateAcw=true)]
	internal class ILBSAuthManagerListenerInvoker : global::Java.Lang.Object, ILBSAuthManagerListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/lbsapi/auth/LBSAuthManagerListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ILBSAuthManagerListenerInvoker); }
		}

		IntPtr class_ref;

		public static ILBSAuthManagerListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILBSAuthManagerListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.baidu.lbsapi.auth.LBSAuthManagerListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILBSAuthManagerListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAuthResult_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAuthResult_ILjava_lang_String_Handler ()
		{
			if (cb_onAuthResult_ILjava_lang_String_ == null)
				cb_onAuthResult_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnAuthResult_ILjava_lang_String_);
			return cb_onAuthResult_ILjava_lang_String_;
		}

		static void n_OnAuthResult_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Baidu.Lbsapi.Auth.ILBSAuthManagerListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Lbsapi.Auth.ILBSAuthManagerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAuthResult (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAuthResult_ILjava_lang_String_;
		public unsafe void OnAuthResult (int p0, string p1)
		{
			if (id_onAuthResult_ILjava_lang_String_ == IntPtr.Zero)
				id_onAuthResult_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAuthResult", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAuthResult_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	public partial class LBSAuthManagerEventArgs : global::System.EventArgs {

		public LBSAuthManagerEventArgs (int p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/baidu/lbsapi/auth/LBSAuthManagerListenerImplementor")]
	internal sealed partial class ILBSAuthManagerListenerImplementor : global::Java.Lang.Object, ILBSAuthManagerListener {

		object sender;

		public ILBSAuthManagerListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/lbsapi/auth/LBSAuthManagerListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<LBSAuthManagerEventArgs> Handler;
#pragma warning restore 0649

		public void OnAuthResult (int p0, string p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new LBSAuthManagerEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (ILBSAuthManagerListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
