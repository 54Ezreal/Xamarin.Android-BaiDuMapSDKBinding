using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comjni.Map.Commonmemcache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.platform.comjni.map.commonmemcache']/class[@name='JNICommonMemCache']"
	[global::Android.Runtime.Register ("com/baidu/platform/comjni/map/commonmemcache/JNICommonMemCache", DoNotGenerateAcw=true)]
	public partial class JNICommonMemCache : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/platform/comjni/map/commonmemcache/JNICommonMemCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JNICommonMemCache); }
		}

		protected JNICommonMemCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.platform.comjni.map.commonmemcache']/class[@name='JNICommonMemCache']/constructor[@name='JNICommonMemCache' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JNICommonMemCache ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (JNICommonMemCache)) {
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

		static Delegate cb_Create;
#pragma warning disable 0169
		static Delegate GetCreateHandler ()
		{
			if (cb_Create == null)
				cb_Create = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Create);
			return cb_Create;
		}

		static long n_Create (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Platform.Comjni.Map.Commonmemcache.JNICommonMemCache __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Commonmemcache.JNICommonMemCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Create ();
		}
#pragma warning restore 0169

		static IntPtr id_Create;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.commonmemcache']/class[@name='JNICommonMemCache']/method[@name='Create' and count(parameter)=0]"
		[Register ("Create", "()J", "GetCreateHandler")]
		public virtual unsafe long Create ()
		{
			if (id_Create == IntPtr.Zero)
				id_Create = JNIEnv.GetMethodID (class_ref, "Create", "()J");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_Create);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Create", "()J"));
			} finally {
			}
		}

		static Delegate cb_Init_J;
#pragma warning disable 0169
		static Delegate GetInit_JHandler ()
		{
			if (cb_Init_J == null)
				cb_Init_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_Init_J);
			return cb_Init_J;
		}

		static void n_Init_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Platform.Comjni.Map.Commonmemcache.JNICommonMemCache __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Commonmemcache.JNICommonMemCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0);
		}
#pragma warning restore 0169

		static IntPtr id_Init_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.commonmemcache']/class[@name='JNICommonMemCache']/method[@name='Init' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("Init", "(J)V", "GetInit_JHandler")]
		public virtual unsafe void Init (long p0)
		{
			if (id_Init_J == IntPtr.Zero)
				id_Init_J = JNIEnv.GetMethodID (class_ref, "Init", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_Init_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Init", "(J)V"), __args);
			} finally {
			}
		}

	}
}
