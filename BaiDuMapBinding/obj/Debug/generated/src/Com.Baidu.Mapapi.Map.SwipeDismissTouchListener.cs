using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='SwipeDismissTouchListener']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/SwipeDismissTouchListener", DoNotGenerateAcw=true)]
	public partial class SwipeDismissTouchListener : global::Java.Lang.Object, global::Android.Views.View.IOnTouchListener {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='SwipeDismissTouchListener.DismissCallbacks']"
		[Register ("com/baidu/mapapi/map/SwipeDismissTouchListener$DismissCallbacks", "", "Com.Baidu.Mapapi.Map.SwipeDismissTouchListener/IDismissCallbacksInvoker")]
		public partial interface IDismissCallbacks : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='SwipeDismissTouchListener.DismissCallbacks']/method[@name='canDismiss' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("canDismiss", "(Ljava/lang/Object;)Z", "GetCanDismiss_Ljava_lang_Object_Handler:Com.Baidu.Mapapi.Map.SwipeDismissTouchListener/IDismissCallbacksInvoker, XamarinBaiDuMapSDKBinding")]
			bool CanDismiss (global::Java.Lang.Object p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='SwipeDismissTouchListener.DismissCallbacks']/method[@name='onDismiss' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.Object']]"
			[Register ("onDismiss", "(Landroid/view/View;Ljava/lang/Object;)V", "GetOnDismiss_Landroid_view_View_Ljava_lang_Object_Handler:Com.Baidu.Mapapi.Map.SwipeDismissTouchListener/IDismissCallbacksInvoker, XamarinBaiDuMapSDKBinding")]
			void OnDismiss (global::Android.Views.View p0, global::Java.Lang.Object p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='SwipeDismissTouchListener.DismissCallbacks']/method[@name='onNotify' and count(parameter)=0]"
			[Register ("onNotify", "()V", "GetOnNotifyHandler:Com.Baidu.Mapapi.Map.SwipeDismissTouchListener/IDismissCallbacksInvoker, XamarinBaiDuMapSDKBinding")]
			void OnNotify ();

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/SwipeDismissTouchListener$DismissCallbacks", DoNotGenerateAcw=true)]
		internal class IDismissCallbacksInvoker : global::Java.Lang.Object, IDismissCallbacks {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/mapapi/map/SwipeDismissTouchListener$DismissCallbacks");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IDismissCallbacksInvoker); }
			}

			IntPtr class_ref;

			public static IDismissCallbacks GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDismissCallbacks> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.SwipeDismissTouchListener.DismissCallbacks"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDismissCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_canDismiss_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetCanDismiss_Ljava_lang_Object_Handler ()
			{
				if (cb_canDismiss_Ljava_lang_Object_ == null)
					cb_canDismiss_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_CanDismiss_Ljava_lang_Object_);
				return cb_canDismiss_Ljava_lang_Object_;
			}

			static bool n_CanDismiss_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.SwipeDismissTouchListener.IDismissCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.SwipeDismissTouchListener.IDismissCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.CanDismiss (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_canDismiss_Ljava_lang_Object_;
			public unsafe bool CanDismiss (global::Java.Lang.Object p0)
			{
				if (id_canDismiss_Ljava_lang_Object_ == IntPtr.Zero)
					id_canDismiss_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "canDismiss", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canDismiss_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_onDismiss_Landroid_view_View_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetOnDismiss_Landroid_view_View_Ljava_lang_Object_Handler ()
			{
				if (cb_onDismiss_Landroid_view_View_Ljava_lang_Object_ == null)
					cb_onDismiss_Landroid_view_View_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnDismiss_Landroid_view_View_Ljava_lang_Object_);
				return cb_onDismiss_Landroid_view_View_Ljava_lang_Object_;
			}

			static void n_OnDismiss_Landroid_view_View_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Baidu.Mapapi.Map.SwipeDismissTouchListener.IDismissCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.SwipeDismissTouchListener.IDismissCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnDismiss (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onDismiss_Landroid_view_View_Ljava_lang_Object_;
			public unsafe void OnDismiss (global::Android.Views.View p0, global::Java.Lang.Object p1)
			{
				if (id_onDismiss_Landroid_view_View_Ljava_lang_Object_ == IntPtr.Zero)
					id_onDismiss_Landroid_view_View_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onDismiss", "(Landroid/view/View;Ljava/lang/Object;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDismiss_Landroid_view_View_Ljava_lang_Object_, __args);
			}

			static Delegate cb_onNotify;
#pragma warning disable 0169
			static Delegate GetOnNotifyHandler ()
			{
				if (cb_onNotify == null)
					cb_onNotify = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnNotify);
				return cb_onNotify;
			}

			static void n_OnNotify (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Map.SwipeDismissTouchListener.IDismissCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.SwipeDismissTouchListener.IDismissCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnNotify ();
			}
#pragma warning restore 0169

			IntPtr id_onNotify;
			public unsafe void OnNotify ()
			{
				if (id_onNotify == IntPtr.Zero)
					id_onNotify = JNIEnv.GetMethodID (class_ref, "onNotify", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNotify);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/SwipeDismissTouchListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SwipeDismissTouchListener); }
		}

		protected SwipeDismissTouchListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_View_Ljava_lang_Object_Lcom_baidu_mapapi_map_SwipeDismissTouchListener_DismissCallbacks_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='SwipeDismissTouchListener']/constructor[@name='SwipeDismissTouchListener' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='com.baidu.mapapi.map.SwipeDismissTouchListener.DismissCallbacks']]"
		[Register (".ctor", "(Landroid/view/View;Ljava/lang/Object;Lcom/baidu/mapapi/map/SwipeDismissTouchListener$DismissCallbacks;)V", "")]
		public unsafe SwipeDismissTouchListener (global::Android.Views.View p0, global::Java.Lang.Object p1, global::Com.Baidu.Mapapi.Map.SwipeDismissTouchListener.IDismissCallbacks p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (SwipeDismissTouchListener)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/view/View;Ljava/lang/Object;Lcom/baidu/mapapi/map/SwipeDismissTouchListener$DismissCallbacks;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/view/View;Ljava/lang/Object;Lcom/baidu/mapapi/map/SwipeDismissTouchListener$DismissCallbacks;)V", __args);
					return;
				}

				if (id_ctor_Landroid_view_View_Ljava_lang_Object_Lcom_baidu_mapapi_map_SwipeDismissTouchListener_DismissCallbacks_ == IntPtr.Zero)
					id_ctor_Landroid_view_View_Ljava_lang_Object_Lcom_baidu_mapapi_map_SwipeDismissTouchListener_DismissCallbacks_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/View;Ljava/lang/Object;Lcom/baidu/mapapi/map/SwipeDismissTouchListener$DismissCallbacks;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_View_Ljava_lang_Object_Lcom_baidu_mapapi_map_SwipeDismissTouchListener_DismissCallbacks_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_view_View_Ljava_lang_Object_Lcom_baidu_mapapi_map_SwipeDismissTouchListener_DismissCallbacks_, __args);
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
			global::Com.Baidu.Mapapi.Map.SwipeDismissTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.SwipeDismissTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouch (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='SwipeDismissTouchListener']/method[@name='onTouch' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.MotionEvent']]"
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
