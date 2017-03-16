using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comapi.Util {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.platform.comapi.util']/interface[@name='SysUpdateObserver']"
	[Register ("com/baidu/platform/comapi/util/SysUpdateObserver", "", "Com.Baidu.Platform.Comapi.Util.ISysUpdateObserverInvoker")]
	public partial interface ISysUpdateObserver : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.util']/interface[@name='SysUpdateObserver']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler:Com.Baidu.Platform.Comapi.Util.ISysUpdateObserverInvoker, XamarinBaiDuMapSDKBinding")]
		void Init ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.util']/interface[@name='SysUpdateObserver']/method[@name='updateNetworkInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("updateNetworkInfo", "(Landroid/content/Context;)V", "GetUpdateNetworkInfo_Landroid_content_Context_Handler:Com.Baidu.Platform.Comapi.Util.ISysUpdateObserverInvoker, XamarinBaiDuMapSDKBinding")]
		void UpdateNetworkInfo (global::Android.Content.Context p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.util']/interface[@name='SysUpdateObserver']/method[@name='updateNetworkProxy' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("updateNetworkProxy", "(Landroid/content/Context;)V", "GetUpdateNetworkProxy_Landroid_content_Context_Handler:Com.Baidu.Platform.Comapi.Util.ISysUpdateObserverInvoker, XamarinBaiDuMapSDKBinding")]
		void UpdateNetworkProxy (global::Android.Content.Context p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.util']/interface[@name='SysUpdateObserver']/method[@name='updatePhoneInfo' and count(parameter)=0]"
		[Register ("updatePhoneInfo", "()V", "GetUpdatePhoneInfoHandler:Com.Baidu.Platform.Comapi.Util.ISysUpdateObserverInvoker, XamarinBaiDuMapSDKBinding")]
		void UpdatePhoneInfo ();

	}

	[global::Android.Runtime.Register ("com/baidu/platform/comapi/util/SysUpdateObserver", DoNotGenerateAcw=true)]
	internal class ISysUpdateObserverInvoker : global::Java.Lang.Object, ISysUpdateObserver {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/platform/comapi/util/SysUpdateObserver");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISysUpdateObserverInvoker); }
		}

		IntPtr class_ref;

		public static ISysUpdateObserver GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISysUpdateObserver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.baidu.platform.comapi.util.SysUpdateObserver"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISysUpdateObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_init;
#pragma warning disable 0169
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Init);
			return cb_init;
		}

		static void n_Init (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Platform.Comapi.Util.ISysUpdateObserver __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Util.ISysUpdateObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		IntPtr id_init;
		public unsafe void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetMethodID (class_ref, "init", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init);
		}

		static Delegate cb_updateNetworkInfo_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetUpdateNetworkInfo_Landroid_content_Context_Handler ()
		{
			if (cb_updateNetworkInfo_Landroid_content_Context_ == null)
				cb_updateNetworkInfo_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateNetworkInfo_Landroid_content_Context_);
			return cb_updateNetworkInfo_Landroid_content_Context_;
		}

		static void n_UpdateNetworkInfo_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Platform.Comapi.Util.ISysUpdateObserver __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Util.ISysUpdateObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateNetworkInfo (p0);
		}
#pragma warning restore 0169

		IntPtr id_updateNetworkInfo_Landroid_content_Context_;
		public unsafe void UpdateNetworkInfo (global::Android.Content.Context p0)
		{
			if (id_updateNetworkInfo_Landroid_content_Context_ == IntPtr.Zero)
				id_updateNetworkInfo_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "updateNetworkInfo", "(Landroid/content/Context;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateNetworkInfo_Landroid_content_Context_, __args);
		}

		static Delegate cb_updateNetworkProxy_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetUpdateNetworkProxy_Landroid_content_Context_Handler ()
		{
			if (cb_updateNetworkProxy_Landroid_content_Context_ == null)
				cb_updateNetworkProxy_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateNetworkProxy_Landroid_content_Context_);
			return cb_updateNetworkProxy_Landroid_content_Context_;
		}

		static void n_UpdateNetworkProxy_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Platform.Comapi.Util.ISysUpdateObserver __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Util.ISysUpdateObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateNetworkProxy (p0);
		}
#pragma warning restore 0169

		IntPtr id_updateNetworkProxy_Landroid_content_Context_;
		public unsafe void UpdateNetworkProxy (global::Android.Content.Context p0)
		{
			if (id_updateNetworkProxy_Landroid_content_Context_ == IntPtr.Zero)
				id_updateNetworkProxy_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "updateNetworkProxy", "(Landroid/content/Context;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateNetworkProxy_Landroid_content_Context_, __args);
		}

		static Delegate cb_updatePhoneInfo;
#pragma warning disable 0169
		static Delegate GetUpdatePhoneInfoHandler ()
		{
			if (cb_updatePhoneInfo == null)
				cb_updatePhoneInfo = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdatePhoneInfo);
			return cb_updatePhoneInfo;
		}

		static void n_UpdatePhoneInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Platform.Comapi.Util.ISysUpdateObserver __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Util.ISysUpdateObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdatePhoneInfo ();
		}
#pragma warning restore 0169

		IntPtr id_updatePhoneInfo;
		public unsafe void UpdatePhoneInfo ()
		{
			if (id_updatePhoneInfo == IntPtr.Zero)
				id_updatePhoneInfo = JNIEnv.GetMethodID (class_ref, "updatePhoneInfo", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updatePhoneInfo);
		}

	}

}
