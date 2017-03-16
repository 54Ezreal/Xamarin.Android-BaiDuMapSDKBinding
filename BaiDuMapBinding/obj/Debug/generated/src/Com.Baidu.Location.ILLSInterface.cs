using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Location {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.location']/interface[@name='LLSInterface']"
	[Register ("com/baidu/location/LLSInterface", "", "Com.Baidu.Location.ILLSInterfaceInvoker")]
	public partial interface ILLSInterface : IJavaObject {

		double Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/interface[@name='LLSInterface']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()D", "GetGetVersionHandler:Com.Baidu.Location.ILLSInterfaceInvoker, XamarinBaiDuMapSDKBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/interface[@name='LLSInterface']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "GetOnBind_Landroid_content_Intent_Handler:Com.Baidu.Location.ILLSInterfaceInvoker, XamarinBaiDuMapSDKBinding")]
		global::Android.OS.IBinder OnBind (global::Android.Content.Intent p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/interface[@name='LLSInterface']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onCreate", "(Landroid/content/Context;)V", "GetOnCreate_Landroid_content_Context_Handler:Com.Baidu.Location.ILLSInterfaceInvoker, XamarinBaiDuMapSDKBinding")]
		void OnCreate (global::Android.Content.Context p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/interface[@name='LLSInterface']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler:Com.Baidu.Location.ILLSInterfaceInvoker, XamarinBaiDuMapSDKBinding")]
		void OnDestroy ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/interface[@name='LLSInterface']/method[@name='onStartCommand' and count(parameter)=3 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onStartCommand", "(Landroid/content/Intent;II)I", "GetOnStartCommand_Landroid_content_Intent_IIHandler:Com.Baidu.Location.ILLSInterfaceInvoker, XamarinBaiDuMapSDKBinding")]
		int OnStartCommand (global::Android.Content.Intent p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/interface[@name='LLSInterface']/method[@name='onUnBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onUnBind", "(Landroid/content/Intent;)Z", "GetOnUnBind_Landroid_content_Intent_Handler:Com.Baidu.Location.ILLSInterfaceInvoker, XamarinBaiDuMapSDKBinding")]
		bool OnUnBind (global::Android.Content.Intent p0);

	}

	[global::Android.Runtime.Register ("com/baidu/location/LLSInterface", DoNotGenerateAcw=true)]
	internal class ILLSInterfaceInvoker : global::Java.Lang.Object, ILLSInterface {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/location/LLSInterface");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ILLSInterfaceInvoker); }
		}

		IntPtr class_ref;

		public static ILLSInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILLSInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.baidu.location.LLSInterface"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILLSInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetVersion);
			return cb_getVersion;
		}

		static double n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Location.ILLSInterface __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.ILLSInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Version;
		}
#pragma warning restore 0169

		IntPtr id_getVersion;
		public unsafe double Version {
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()D");
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getVersion);
			}
		}

		static Delegate cb_onBind_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnBind_Landroid_content_Intent_Handler ()
		{
			if (cb_onBind_Landroid_content_Intent_ == null)
				cb_onBind_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnBind_Landroid_content_Intent_);
			return cb_onBind_Landroid_content_Intent_;
		}

		static IntPtr n_OnBind_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Location.ILLSInterface __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.ILLSInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnBind (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onBind_Landroid_content_Intent_;
		public unsafe global::Android.OS.IBinder OnBind (global::Android.Content.Intent p0)
		{
			if (id_onBind_Landroid_content_Intent_ == IntPtr.Zero)
				id_onBind_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Android.OS.IBinder __ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onBind_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_onCreate_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_content_Context_Handler ()
		{
			if (cb_onCreate_Landroid_content_Context_ == null)
				cb_onCreate_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreate_Landroid_content_Context_);
			return cb_onCreate_Landroid_content_Context_;
		}

		static void n_OnCreate_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Location.ILLSInterface __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.ILLSInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCreate_Landroid_content_Context_;
		public unsafe void OnCreate (global::Android.Content.Context p0)
		{
			if (id_onCreate_Landroid_content_Context_ == IntPtr.Zero)
				id_onCreate_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/content/Context;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreate_Landroid_content_Context_, __args);
		}

		static Delegate cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Location.ILLSInterface __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.ILLSInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		IntPtr id_onDestroy;
		public unsafe void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDestroy);
		}

		static Delegate cb_onStartCommand_Landroid_content_Intent_II;
#pragma warning disable 0169
		static Delegate GetOnStartCommand_Landroid_content_Intent_IIHandler ()
		{
			if (cb_onStartCommand_Landroid_content_Intent_II == null)
				cb_onStartCommand_Landroid_content_Intent_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int>) n_OnStartCommand_Landroid_content_Intent_II);
			return cb_onStartCommand_Landroid_content_Intent_II;
		}

		static int n_OnStartCommand_Landroid_content_Intent_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Baidu.Location.ILLSInterface __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.ILLSInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.OnStartCommand (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onStartCommand_Landroid_content_Intent_II;
		public unsafe int OnStartCommand (global::Android.Content.Intent p0, int p1, int p2)
		{
			if (id_onStartCommand_Landroid_content_Intent_II == IntPtr.Zero)
				id_onStartCommand_Landroid_content_Intent_II = JNIEnv.GetMethodID (class_ref, "onStartCommand", "(Landroid/content/Intent;II)I");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_onStartCommand_Landroid_content_Intent_II, __args);
			return __ret;
		}

		static Delegate cb_onUnBind_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnUnBind_Landroid_content_Intent_Handler ()
		{
			if (cb_onUnBind_Landroid_content_Intent_ == null)
				cb_onUnBind_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnUnBind_Landroid_content_Intent_);
			return cb_onUnBind_Landroid_content_Intent_;
		}

		static bool n_OnUnBind_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Location.ILLSInterface __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.ILLSInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnUnBind (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onUnBind_Landroid_content_Intent_;
		public unsafe bool OnUnBind (global::Android.Content.Intent p0)
		{
			if (id_onUnBind_Landroid_content_Intent_ == IntPtr.Zero)
				id_onUnBind_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onUnBind", "(Landroid/content/Intent;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onUnBind_Landroid_content_Intent_, __args);
			return __ret;
		}

	}

}
