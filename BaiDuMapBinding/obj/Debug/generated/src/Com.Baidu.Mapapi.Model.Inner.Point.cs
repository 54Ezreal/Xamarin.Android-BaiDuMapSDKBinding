using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Model.Inner {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='Point']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/model/inner/Point", DoNotGenerateAcw=true)]
	public partial class Point : global::Java.Lang.Object, global::Java.IO.ISerializable {


		static IntPtr x_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='Point']/field[@name='x']"
		[Register ("x")]
		public int X {
			get {
				if (x_jfieldId == IntPtr.Zero)
					x_jfieldId = JNIEnv.GetFieldID (class_ref, "x", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, x_jfieldId);
			}
			set {
				if (x_jfieldId == IntPtr.Zero)
					x_jfieldId = JNIEnv.GetFieldID (class_ref, "x", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, x_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr y_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='Point']/field[@name='y']"
		[Register ("y")]
		public int Y {
			get {
				if (y_jfieldId == IntPtr.Zero)
					y_jfieldId = JNIEnv.GetFieldID (class_ref, "y", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, y_jfieldId);
			}
			set {
				if (y_jfieldId == IntPtr.Zero)
					y_jfieldId = JNIEnv.GetFieldID (class_ref, "y", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, y_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/model/inner/Point", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Point); }
		}

		protected Point (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='Point']/constructor[@name='Point' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Point ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Point)) {
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

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='Point']/constructor[@name='Point' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe Point (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (Point)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

		static Delegate cb_getmPtx;
#pragma warning disable 0169
		static Delegate GetGetmPtxHandler ()
		{
			if (cb_getmPtx == null)
				cb_getmPtx = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetmPtx);
			return cb_getmPtx;
		}

		static int n_GetmPtx (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Model.Inner.Point __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetmPtx ();
		}
#pragma warning restore 0169

		static IntPtr id_getmPtx;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='Point']/method[@name='getmPtx' and count(parameter)=0]"
		[Register ("getmPtx", "()I", "GetGetmPtxHandler")]
		public virtual unsafe int GetmPtx ()
		{
			if (id_getmPtx == IntPtr.Zero)
				id_getmPtx = JNIEnv.GetMethodID (class_ref, "getmPtx", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getmPtx);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getmPtx", "()I"));
			} finally {
			}
		}

		static Delegate cb_getmPty;
#pragma warning disable 0169
		static Delegate GetGetmPtyHandler ()
		{
			if (cb_getmPty == null)
				cb_getmPty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetmPty);
			return cb_getmPty;
		}

		static int n_GetmPty (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Model.Inner.Point __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetmPty ();
		}
#pragma warning restore 0169

		static IntPtr id_getmPty;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='Point']/method[@name='getmPty' and count(parameter)=0]"
		[Register ("getmPty", "()I", "GetGetmPtyHandler")]
		public virtual unsafe int GetmPty ()
		{
			if (id_getmPty == IntPtr.Zero)
				id_getmPty = JNIEnv.GetMethodID (class_ref, "getmPty", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getmPty);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getmPty", "()I"));
			} finally {
			}
		}

		static Delegate cb_setmPtx_I;
#pragma warning disable 0169
		static Delegate GetSetmPtx_IHandler ()
		{
			if (cb_setmPtx_I == null)
				cb_setmPtx_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetmPtx_I);
			return cb_setmPtx_I;
		}

		static void n_SetmPtx_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Model.Inner.Point __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetmPtx (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setmPtx_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='Point']/method[@name='setmPtx' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setmPtx", "(I)V", "GetSetmPtx_IHandler")]
		public virtual unsafe void SetmPtx (int p0)
		{
			if (id_setmPtx_I == IntPtr.Zero)
				id_setmPtx_I = JNIEnv.GetMethodID (class_ref, "setmPtx", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setmPtx_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setmPtx", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setmPty_I;
#pragma warning disable 0169
		static Delegate GetSetmPty_IHandler ()
		{
			if (cb_setmPty_I == null)
				cb_setmPty_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetmPty_I);
			return cb_setmPty_I;
		}

		static void n_SetmPty_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Model.Inner.Point __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetmPty (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setmPty_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='Point']/method[@name='setmPty' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setmPty", "(I)V", "GetSetmPty_IHandler")]
		public virtual unsafe void SetmPty (int p0)
		{
			if (id_setmPty_I == IntPtr.Zero)
				id_setmPty_I = JNIEnv.GetMethodID (class_ref, "setmPty", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setmPty_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setmPty", "(I)V"), __args);
			} finally {
			}
		}

	}
}
