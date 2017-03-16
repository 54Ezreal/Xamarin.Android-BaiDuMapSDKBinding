using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='F']"
	[global::Android.Runtime.Register ("com/baidu/platform/comapi/map/F", DoNotGenerateAcw=true)]
	public partial class F : global::Android.Views.TextureView, global::Android.Views.GestureDetector.IOnDoubleTapListener, global::Android.Views.GestureDetector.IOnGestureListener, global::Android.Views.TextureView.ISurfaceTextureListener {


		static IntPtr b_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='F']/field[@name='b']"
		[Register ("b")]
		public static int B {
			get {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "I");
				return JNIEnv.GetStaticIntField (class_ref, b_jfieldId);
			}
			set {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "I");
				try {
					JNIEnv.SetStaticField (class_ref, b_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/platform/comapi/map/F", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (F); }
		}

		protected F (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_baidu_platform_comapi_map_C_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='F']/constructor[@name='F' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.baidu.platform.comapi.map.C'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/baidu/platform/comapi/map/C;Ljava/lang/String;)V", "")]
		public unsafe F (global::Android.Content.Context p0, global::Com.Baidu.Platform.Comapi.Map.C p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (F)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Lcom/baidu/platform/comapi/map/C;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Lcom/baidu/platform/comapi/map/C;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_baidu_platform_comapi_map_C_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_baidu_platform_comapi_map_C_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/baidu/platform/comapi/map/C;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_baidu_platform_comapi_map_C_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_baidu_platform_comapi_map_C_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_A);
			return cb_a;
		}

		static int n_A (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Platform.Comapi.Map.F __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.F> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.A ();
		}
#pragma warning restore 0169

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='F']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()I", "GetAHandler")]
		public virtual unsafe int A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_a);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "()I"));
			} finally {
			}
		}

		static Delegate cb_a_Ljava_lang_String_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_String_Landroid_graphics_Rect_Handler ()
		{
			if (cb_a_Ljava_lang_String_Landroid_graphics_Rect_ == null)
				cb_a_Ljava_lang_String_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Ljava_lang_String_Landroid_graphics_Rect_);
			return cb_a_Ljava_lang_String_Landroid_graphics_Rect_;
		}

		static void n_A_Ljava_lang_String_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comapi.Map.F __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.F> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.A (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_a_Ljava_lang_String_Landroid_graphics_Rect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='F']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Rect']]"
		[Register ("a", "(Ljava/lang/String;Landroid/graphics/Rect;)V", "GetA_Ljava_lang_String_Landroid_graphics_Rect_Handler")]
		public virtual unsafe void A (string p0, global::Android.Graphics.Rect p1)
		{
			if (id_a_Ljava_lang_String_Landroid_graphics_Rect_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Landroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Landroid/graphics/Rect;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Ljava_lang_String_Landroid_graphics_Rect_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Ljava/lang/String;Landroid/graphics/Rect;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_c;
#pragma warning disable 0169
		static Delegate GetCHandler ()
		{
			if (cb_c == null)
				cb_c = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_C);
			return cb_c;
		}

		static void n_C (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Platform.Comapi.Map.F __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.F> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.C ();
		}
#pragma warning restore 0169

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='F']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()V", "GetCHandler")]
		public virtual unsafe void C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_c);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "c", "()V"));
			} finally {
			}
		}

		static Delegate cb_d;
#pragma warning disable 0169
		static Delegate GetDHandler ()
		{
			if (cb_d == null)
				cb_d = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_D);
			return cb_d;
		}

		static void n_D (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Platform.Comapi.Map.F __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.F> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.D ();
		}
#pragma warning restore 0169

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='F']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()V", "GetDHandler")]
		public virtual unsafe void D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_d);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "d", "()V"));
			} finally {
			}
		}

		static Delegate cb_e;
#pragma warning disable 0169
		static Delegate GetEHandler ()
		{
			if (cb_e == null)
				cb_e = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_E);
			return cb_e;
		}

		static void n_E (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Platform.Comapi.Map.F __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.F> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.E ();
		}
#pragma warning restore 0169

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='F']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()V", "GetEHandler")]
		public virtual unsafe void E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_e);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "e", "()V"));
			} finally {
			}
		}

		static Delegate cb_onDoubleTap_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnDoubleTap_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onDoubleTap_Landroid_view_MotionEvent_ == null)
				cb_onDoubleTap_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnDoubleTap_Landroid_view_MotionEvent_);
			return cb_onDoubleTap_Landroid_view_MotionEvent_;
		}

		static bool n_OnDoubleTap_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Platform.Comapi.Map.F __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.F> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnDoubleTap (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onDoubleTap_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='F']/method[@name='onDoubleTap' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onDoubleTap", "(Landroid/view/MotionEvent;)Z", "GetOnDoubleTap_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnDoubleTap (global::Android.Views.MotionEvent p0)
		{
			if (id_onDoubleTap_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onDoubleTap_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onDoubleTap", "(Landroid/view/MotionEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onDoubleTap_Landroid_view_MotionEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDoubleTap", "(Landroid/view/MotionEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onDoubleTapEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnDoubleTapEvent_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onDoubleTapEvent_Landroid_view_MotionEvent_ == null)
				cb_onDoubleTapEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnDoubleTapEvent_Landroid_view_MotionEvent_);
			return cb_onDoubleTapEvent_Landroid_view_MotionEvent_;
		}

		static bool n_OnDoubleTapEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Platform.Comapi.Map.F __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.F> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnDoubleTapEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onDoubleTapEvent_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='F']/method[@name='onDoubleTapEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z", "GetOnDoubleTapEvent_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnDoubleTapEvent (global::Android.Views.MotionEvent p0)
		{
			if (id_onDoubleTapEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onDoubleTapEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onDoubleTapEvent_Landroid_view_MotionEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onDown_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnDown_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onDown_Landroid_view_MotionEvent_ == null)
				cb_onDown_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnDown_Landroid_view_MotionEvent_);
			return cb_onDown_Landroid_view_MotionEvent_;
		}

		static bool n_OnDown_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Platform.Comapi.Map.F __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.F> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnDown (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onDown_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='F']/method[@name='onDown' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onDown", "(Landroid/view/MotionEvent;)Z", "GetOnDown_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnDown (global::Android.Views.MotionEvent p0)
		{
			if (id_onDown_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onDown_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onDown", "(Landroid/view/MotionEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onDown_Landroid_view_MotionEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDown", "(Landroid/view/MotionEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
#pragma warning disable 0169
		static Delegate GetOnFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFHandler ()
		{
			if (cb_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF == null)
				cb_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, float, float, bool>) n_OnFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF);
			return cb_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
		}

		static bool n_OnFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2, float p3)
		{
			global::Com.Baidu.Platform.Comapi.Map.F __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.F> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnFling (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='F']/method[@name='onFling' and count(parameter)=4 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='android.view.MotionEvent'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", "GetOnFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFHandler")]
		public virtual unsafe bool OnFling (global::Android.Views.MotionEvent p0, global::Android.Views.MotionEvent p1, float p2, float p3)
		{
			if (id_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF == IntPtr.Zero)
				id_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF = JNIEnv.GetMethodID (class_ref, "onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onLongPress_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnLongPress_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onLongPress_Landroid_view_MotionEvent_ == null)
				cb_onLongPress_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLongPress_Landroid_view_MotionEvent_);
			return cb_onLongPress_Landroid_view_MotionEvent_;
		}

		static void n_OnLongPress_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Platform.Comapi.Map.F __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.F> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLongPress (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onLongPress_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='F']/method[@name='onLongPress' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onLongPress", "(Landroid/view/MotionEvent;)V", "GetOnLongPress_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe void OnLongPress (global::Android.Views.MotionEvent p0)
		{
			if (id_onLongPress_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onLongPress_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onLongPress", "(Landroid/view/MotionEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLongPress_Landroid_view_MotionEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLongPress", "(Landroid/view/MotionEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
#pragma warning disable 0169
		static Delegate GetOnScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFHandler ()
		{
			if (cb_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF == null)
				cb_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, float, float, bool>) n_OnScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF);
			return cb_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
		}

		static bool n_OnScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2, float p3)
		{
			global::Com.Baidu.Platform.Comapi.Map.F __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.F> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnScroll (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='F']/method[@name='onScroll' and count(parameter)=4 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='android.view.MotionEvent'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", "GetOnScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFHandler")]
		public virtual unsafe bool OnScroll (global::Android.Views.MotionEvent p0, global::Android.Views.MotionEvent p1, float p2, float p3)
		{
			if (id_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF == IntPtr.Zero)
				id_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF = JNIEnv.GetMethodID (class_ref, "onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onShowPress_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnShowPress_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onShowPress_Landroid_view_MotionEvent_ == null)
				cb_onShowPress_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnShowPress_Landroid_view_MotionEvent_);
			return cb_onShowPress_Landroid_view_MotionEvent_;
		}

		static void n_OnShowPress_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Platform.Comapi.Map.F __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.F> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnShowPress (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onShowPress_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='F']/method[@name='onShowPress' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onShowPress", "(Landroid/view/MotionEvent;)V", "GetOnShowPress_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe void OnShowPress (global::Android.Views.MotionEvent p0)
		{
			if (id_onShowPress_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onShowPress_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onShowPress", "(Landroid/view/MotionEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onShowPress_Landroid_view_MotionEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onShowPress", "(Landroid/view/MotionEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSingleTapConfirmed_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnSingleTapConfirmed_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onSingleTapConfirmed_Landroid_view_MotionEvent_ == null)
				cb_onSingleTapConfirmed_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnSingleTapConfirmed_Landroid_view_MotionEvent_);
			return cb_onSingleTapConfirmed_Landroid_view_MotionEvent_;
		}

		static bool n_OnSingleTapConfirmed_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Platform.Comapi.Map.F __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.F> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnSingleTapConfirmed (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onSingleTapConfirmed_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='F']/method[@name='onSingleTapConfirmed' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z", "GetOnSingleTapConfirmed_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnSingleTapConfirmed (global::Android.Views.MotionEvent p0)
		{
			if (id_onSingleTapConfirmed_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onSingleTapConfirmed_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onSingleTapConfirmed_Landroid_view_MotionEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onSingleTapUp_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnSingleTapUp_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onSingleTapUp_Landroid_view_MotionEvent_ == null)
				cb_onSingleTapUp_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnSingleTapUp_Landroid_view_MotionEvent_);
			return cb_onSingleTapUp_Landroid_view_MotionEvent_;
		}

		static bool n_OnSingleTapUp_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Platform.Comapi.Map.F __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.F> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnSingleTapUp (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onSingleTapUp_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='F']/method[@name='onSingleTapUp' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onSingleTapUp", "(Landroid/view/MotionEvent;)Z", "GetOnSingleTapUp_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnSingleTapUp (global::Android.Views.MotionEvent p0)
		{
			if (id_onSingleTapUp_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onSingleTapUp_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onSingleTapUp", "(Landroid/view/MotionEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onSingleTapUp_Landroid_view_MotionEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSingleTapUp", "(Landroid/view/MotionEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II;
#pragma warning disable 0169
		static Delegate GetOnSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_IIHandler ()
		{
			if (cb_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II == null)
				cb_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II);
			return cb_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II;
		}

		static void n_OnSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Baidu.Platform.Comapi.Map.F __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.F> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.SurfaceTexture p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceTextureAvailable (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='F']/method[@name='onSurfaceTextureAvailable' and count(parameter)=3 and parameter[1][@type='android.graphics.SurfaceTexture'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onSurfaceTextureAvailable", "(Landroid/graphics/SurfaceTexture;II)V", "GetOnSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_IIHandler")]
		public virtual unsafe void OnSurfaceTextureAvailable (global::Android.Graphics.SurfaceTexture p0, int p1, int p2)
		{
			if (id_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II == IntPtr.Zero)
				id_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II = JNIEnv.GetMethodID (class_ref, "onSurfaceTextureAvailable", "(Landroid/graphics/SurfaceTexture;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurfaceTextureAvailable", "(Landroid/graphics/SurfaceTexture;II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_;
#pragma warning disable 0169
		static Delegate GetOnSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_Handler ()
		{
			if (cb_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_ == null)
				cb_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_);
			return cb_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_;
		}

		static bool n_OnSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Platform.Comapi.Map.F __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.F> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.SurfaceTexture p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnSurfaceTextureDestroyed (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='F']/method[@name='onSurfaceTextureDestroyed' and count(parameter)=1 and parameter[1][@type='android.graphics.SurfaceTexture']]"
		[Register ("onSurfaceTextureDestroyed", "(Landroid/graphics/SurfaceTexture;)Z", "GetOnSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_Handler")]
		public virtual unsafe bool OnSurfaceTextureDestroyed (global::Android.Graphics.SurfaceTexture p0)
		{
			if (id_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_ == IntPtr.Zero)
				id_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_ = JNIEnv.GetMethodID (class_ref, "onSurfaceTextureDestroyed", "(Landroid/graphics/SurfaceTexture;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurfaceTextureDestroyed", "(Landroid/graphics/SurfaceTexture;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II;
#pragma warning disable 0169
		static Delegate GetOnSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_IIHandler ()
		{
			if (cb_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II == null)
				cb_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II);
			return cb_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II;
		}

		static void n_OnSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Baidu.Platform.Comapi.Map.F __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.F> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.SurfaceTexture p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceTextureSizeChanged (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='F']/method[@name='onSurfaceTextureSizeChanged' and count(parameter)=3 and parameter[1][@type='android.graphics.SurfaceTexture'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onSurfaceTextureSizeChanged", "(Landroid/graphics/SurfaceTexture;II)V", "GetOnSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_IIHandler")]
		public virtual unsafe void OnSurfaceTextureSizeChanged (global::Android.Graphics.SurfaceTexture p0, int p1, int p2)
		{
			if (id_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II == IntPtr.Zero)
				id_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II = JNIEnv.GetMethodID (class_ref, "onSurfaceTextureSizeChanged", "(Landroid/graphics/SurfaceTexture;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurfaceTextureSizeChanged", "(Landroid/graphics/SurfaceTexture;II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_;
#pragma warning disable 0169
		static Delegate GetOnSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_Handler ()
		{
			if (cb_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_ == null)
				cb_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_);
			return cb_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_;
		}

		static void n_OnSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Platform.Comapi.Map.F __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.F> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.SurfaceTexture p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceTextureUpdated (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='F']/method[@name='onSurfaceTextureUpdated' and count(parameter)=1 and parameter[1][@type='android.graphics.SurfaceTexture']]"
		[Register ("onSurfaceTextureUpdated", "(Landroid/graphics/SurfaceTexture;)V", "GetOnSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_Handler")]
		public virtual unsafe void OnSurfaceTextureUpdated (global::Android.Graphics.SurfaceTexture p0)
		{
			if (id_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_ == IntPtr.Zero)
				id_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_ = JNIEnv.GetMethodID (class_ref, "onSurfaceTextureUpdated", "(Landroid/graphics/SurfaceTexture;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurfaceTextureUpdated", "(Landroid/graphics/SurfaceTexture;)V"), __args);
			} finally {
			}
		}

	}
}
