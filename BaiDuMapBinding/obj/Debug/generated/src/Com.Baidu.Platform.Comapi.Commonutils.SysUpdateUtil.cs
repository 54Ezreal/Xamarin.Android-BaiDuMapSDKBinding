using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comapi.Commonutils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.platform.comapi.commonutils']/class[@name='SysUpdateUtil']"
	[global::Android.Runtime.Register ("com/baidu/platform/comapi/commonutils/SysUpdateUtil", DoNotGenerateAcw=true)]
	public partial class SysUpdateUtil : global::Java.Lang.Object, global::Com.Baidu.Platform.Comapi.Util.ISysUpdateObserver {


		static IntPtr b_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.platform.comapi.commonutils']/class[@name='SysUpdateUtil']/field[@name='b']"
		[Register ("b")]
		public static bool B {
			get {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, b_jfieldId);
			}
			set {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, b_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr c_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.platform.comapi.commonutils']/class[@name='SysUpdateUtil']/field[@name='c']"
		[Register ("c")]
		public static string C {
			get {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, c_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, c_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr d_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.platform.comapi.commonutils']/class[@name='SysUpdateUtil']/field[@name='d']"
		[Register ("d")]
		public static int D {
			get {
				if (d_jfieldId == IntPtr.Zero)
					d_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "d", "I");
				return JNIEnv.GetStaticIntField (class_ref, d_jfieldId);
			}
			set {
				if (d_jfieldId == IntPtr.Zero)
					d_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "d", "I");
				try {
					JNIEnv.SetStaticField (class_ref, d_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/platform/comapi/commonutils/SysUpdateUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SysUpdateUtil); }
		}

		protected SysUpdateUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.platform.comapi.commonutils']/class[@name='SysUpdateUtil']/constructor[@name='SysUpdateUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SysUpdateUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SysUpdateUtil)) {
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
			global::Com.Baidu.Platform.Comapi.Commonutils.SysUpdateUtil __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Commonutils.SysUpdateUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.commonutils']/class[@name='SysUpdateUtil']/method[@name='init' and count(parameter)=0]"
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
			global::Com.Baidu.Platform.Comapi.Commonutils.SysUpdateUtil __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Commonutils.SysUpdateUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateNetworkInfo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateNetworkInfo_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.commonutils']/class[@name='SysUpdateUtil']/method[@name='updateNetworkInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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
			global::Com.Baidu.Platform.Comapi.Commonutils.SysUpdateUtil __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Commonutils.SysUpdateUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateNetworkProxy (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateNetworkProxy_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.commonutils']/class[@name='SysUpdateUtil']/method[@name='updateNetworkProxy' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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
			global::Com.Baidu.Platform.Comapi.Commonutils.SysUpdateUtil __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Commonutils.SysUpdateUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdatePhoneInfo ();
		}
#pragma warning restore 0169

		static IntPtr id_updatePhoneInfo;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.commonutils']/class[@name='SysUpdateUtil']/method[@name='updatePhoneInfo' and count(parameter)=0]"
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
