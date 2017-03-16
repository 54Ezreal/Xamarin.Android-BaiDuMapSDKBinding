using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='N']"
	[global::Android.Runtime.Register ("com/baidu/platform/comapi/map/N", DoNotGenerateAcw=true)]
	public partial class N : global::Android.Widget.LinearLayout, global::Android.Views.View.IOnTouchListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/platform/comapi/map/N", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (N); }
		}

		protected N (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='N']/constructor[@name='N' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;Z)V", "")]
		public unsafe N (global::Android.Content.Context p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (N)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Z)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Z == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Z, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='N']/constructor[@name='N' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe N (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (N)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_A);
			return cb_a;
		}

		static bool n_A (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Platform.Comapi.Map.N __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.N> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.A ();
		}
#pragma warning restore 0169

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='N']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Z", "GetAHandler")]
		public virtual unsafe bool A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_a);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "()Z"));
			} finally {
			}
		}

		static Delegate cb_a_Landroid_view_View_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetA_Landroid_view_View_OnClickListener_Handler ()
		{
			if (cb_a_Landroid_view_View_OnClickListener_ == null)
				cb_a_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Landroid_view_View_OnClickListener_);
			return cb_a_Landroid_view_View_OnClickListener_;
		}

		static void n_A_Landroid_view_View_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Platform.Comapi.Map.N __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.N> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View.IOnClickListener p0 = (global::Android.Views.View.IOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		static IntPtr id_a_Landroid_view_View_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='N']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.view.View.OnClickListener']]"
		[Register ("a", "(Landroid/view/View$OnClickListener;)V", "GetA_Landroid_view_View_OnClickListener_Handler")]
		public virtual unsafe void A (global::Android.Views.View.IOnClickListener p0)
		{
			if (id_a_Landroid_view_View_OnClickListener_ == IntPtr.Zero)
				id_a_Landroid_view_View_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/view/View$OnClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Landroid_view_View_OnClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Landroid/view/View$OnClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_a_Z;
#pragma warning disable 0169
		static Delegate GetA_ZHandler ()
		{
			if (cb_a_Z == null)
				cb_a_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_A_Z);
			return cb_a_Z;
		}

		static void n_A_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Baidu.Platform.Comapi.Map.N __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.N> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		static IntPtr id_a_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='N']/method[@name='a' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("a", "(Z)V", "GetA_ZHandler")]
		public virtual unsafe void A (bool p0)
		{
			if (id_a_Z == IntPtr.Zero)
				id_a_Z = JNIEnv.GetMethodID (class_ref, "a", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_B);
			return cb_b;
		}

		static void n_B (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Platform.Comapi.Map.N __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.N> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.B ();
		}
#pragma warning restore 0169

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='N']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "GetBHandler")]
		public virtual unsafe void B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_b);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "b", "()V"));
			} finally {
			}
		}

		static Delegate cb_b_Landroid_view_View_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetB_Landroid_view_View_OnClickListener_Handler ()
		{
			if (cb_b_Landroid_view_View_OnClickListener_ == null)
				cb_b_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_B_Landroid_view_View_OnClickListener_);
			return cb_b_Landroid_view_View_OnClickListener_;
		}

		static void n_B_Landroid_view_View_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Platform.Comapi.Map.N __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.N> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View.IOnClickListener p0 = (global::Android.Views.View.IOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.B (p0);
		}
#pragma warning restore 0169

		static IntPtr id_b_Landroid_view_View_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='N']/method[@name='b' and count(parameter)=1 and parameter[1][@type='android.view.View.OnClickListener']]"
		[Register ("b", "(Landroid/view/View$OnClickListener;)V", "GetB_Landroid_view_View_OnClickListener_Handler")]
		public virtual unsafe void B (global::Android.Views.View.IOnClickListener p0)
		{
			if (id_b_Landroid_view_View_OnClickListener_ == IntPtr.Zero)
				id_b_Landroid_view_View_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "b", "(Landroid/view/View$OnClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_b_Landroid_view_View_OnClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "b", "(Landroid/view/View$OnClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_b_Z;
#pragma warning disable 0169
		static Delegate GetB_ZHandler ()
		{
			if (cb_b_Z == null)
				cb_b_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_B_Z);
			return cb_b_Z;
		}

		static void n_B_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Baidu.Platform.Comapi.Map.N __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.N> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.B (p0);
		}
#pragma warning restore 0169

		static IntPtr id_b_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='N']/method[@name='b' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("b", "(Z)V", "GetB_ZHandler")]
		public virtual unsafe void B (bool p0)
		{
			if (id_b_Z == IntPtr.Zero)
				id_b_Z = JNIEnv.GetMethodID (class_ref, "b", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_b_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "b", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == null)
				cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_);
			return cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
		}

		static bool n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comapi.Map.N __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.N> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouch (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='N']/method[@name='onTouch' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.MotionEvent']]"
		[Register ("onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnTouch (global::Android.Views.View p0, global::Android.Views.MotionEvent p1)
		{
			if (id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
