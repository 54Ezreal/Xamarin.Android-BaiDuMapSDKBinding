using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comapi.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.platform.comapi.util']/class[@name='SysUpdateObservable']"
	[global::Android.Runtime.Register ("com/baidu/platform/comapi/util/SysUpdateObservable", DoNotGenerateAcw=true)]
	public partial class SysUpdateObservable : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/platform/comapi/util/SysUpdateObservable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SysUpdateObservable); }
		}

		protected SysUpdateObservable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Baidu.Platform.Comapi.Util.SysUpdateObservable Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.util']/class[@name='SysUpdateObservable']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/baidu/platform/comapi/util/SysUpdateObservable;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/baidu/platform/comapi/util/SysUpdateObservable;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Util.SysUpdateObservable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addObserver_Lcom_baidu_platform_comapi_util_SysUpdateObserver_;
#pragma warning disable 0169
		static Delegate GetAddObserver_Lcom_baidu_platform_comapi_util_SysUpdateObserver_Handler ()
		{
			if (cb_addObserver_Lcom_baidu_platform_comapi_util_SysUpdateObserver_ == null)
				cb_addObserver_Lcom_baidu_platform_comapi_util_SysUpdateObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddObserver_Lcom_baidu_platform_comapi_util_SysUpdateObserver_);
			return cb_addObserver_Lcom_baidu_platform_comapi_util_SysUpdateObserver_;
		}

		static void n_AddObserver_Lcom_baidu_platform_comapi_util_SysUpdateObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Platform.Comapi.Util.SysUpdateObservable __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Util.SysUpdateObservable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Platform.Comapi.Util.ISysUpdateObserver p0 = (global::Com.Baidu.Platform.Comapi.Util.ISysUpdateObserver)global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Util.ISysUpdateObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddObserver (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addObserver_Lcom_baidu_platform_comapi_util_SysUpdateObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.util']/class[@name='SysUpdateObservable']/method[@name='addObserver' and count(parameter)=1 and parameter[1][@type='com.baidu.platform.comapi.util.SysUpdateObserver']]"
		[Register ("addObserver", "(Lcom/baidu/platform/comapi/util/SysUpdateObserver;)V", "GetAddObserver_Lcom_baidu_platform_comapi_util_SysUpdateObserver_Handler")]
		public virtual unsafe void AddObserver (global::Com.Baidu.Platform.Comapi.Util.ISysUpdateObserver p0)
		{
			if (id_addObserver_Lcom_baidu_platform_comapi_util_SysUpdateObserver_ == IntPtr.Zero)
				id_addObserver_Lcom_baidu_platform_comapi_util_SysUpdateObserver_ = JNIEnv.GetMethodID (class_ref, "addObserver", "(Lcom/baidu/platform/comapi/util/SysUpdateObserver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addObserver_Lcom_baidu_platform_comapi_util_SysUpdateObserver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addObserver", "(Lcom/baidu/platform/comapi/util/SysUpdateObserver;)V"), __args);
			} finally {
			}
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
			global::Com.Baidu.Platform.Comapi.Util.SysUpdateObservable __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Util.SysUpdateObservable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.util']/class[@name='SysUpdateObservable']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		public virtual unsafe void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetMethodID (class_ref, "init", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "()V"));
			} finally {
			}
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
			global::Com.Baidu.Platform.Comapi.Util.SysUpdateObservable __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Util.SysUpdateObservable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateNetworkInfo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateNetworkInfo_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.util']/class[@name='SysUpdateObservable']/method[@name='updateNetworkInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("updateNetworkInfo", "(Landroid/content/Context;)V", "GetUpdateNetworkInfo_Landroid_content_Context_Handler")]
		public virtual unsafe void UpdateNetworkInfo (global::Android.Content.Context p0)
		{
			if (id_updateNetworkInfo_Landroid_content_Context_ == IntPtr.Zero)
				id_updateNetworkInfo_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "updateNetworkInfo", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateNetworkInfo_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateNetworkInfo", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
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
			global::Com.Baidu.Platform.Comapi.Util.SysUpdateObservable __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Util.SysUpdateObservable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateNetworkProxy (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateNetworkProxy_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.util']/class[@name='SysUpdateObservable']/method[@name='updateNetworkProxy' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("updateNetworkProxy", "(Landroid/content/Context;)V", "GetUpdateNetworkProxy_Landroid_content_Context_Handler")]
		public virtual unsafe void UpdateNetworkProxy (global::Android.Content.Context p0)
		{
			if (id_updateNetworkProxy_Landroid_content_Context_ == IntPtr.Zero)
				id_updateNetworkProxy_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "updateNetworkProxy", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateNetworkProxy_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateNetworkProxy", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
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
			global::Com.Baidu.Platform.Comapi.Util.SysUpdateObservable __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Util.SysUpdateObservable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdatePhoneInfo ();
		}
#pragma warning restore 0169

		static IntPtr id_updatePhoneInfo;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.util']/class[@name='SysUpdateObservable']/method[@name='updatePhoneInfo' and count(parameter)=0]"
		[Register ("updatePhoneInfo", "()V", "GetUpdatePhoneInfoHandler")]
		public virtual unsafe void UpdatePhoneInfo ()
		{
			if (id_updatePhoneInfo == IntPtr.Zero)
				id_updatePhoneInfo = JNIEnv.GetMethodID (class_ref, "updatePhoneInfo", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updatePhoneInfo);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updatePhoneInfo", "()V"));
			} finally {
			}
		}

	}
}
