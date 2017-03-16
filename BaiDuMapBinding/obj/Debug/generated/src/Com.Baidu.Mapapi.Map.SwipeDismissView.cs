using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='SwipeDismissView']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/SwipeDismissView", DoNotGenerateAcw=true)]
	public partial class SwipeDismissView : global::Android.Widget.RelativeLayout {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/SwipeDismissView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SwipeDismissView); }
		}

		protected SwipeDismissView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_Landroid_view_View_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='SwipeDismissView']/constructor[@name='SwipeDismissView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;Landroid/view/View;)V", "")]
		public unsafe SwipeDismissView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, global::Android.Views.View p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (SwipeDismissView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;Landroid/view/View;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;Landroid/view/View;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_Landroid_view_View_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;Landroid/view/View;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_Landroid_view_View_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_Landroid_view_View_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_view_View_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='SwipeDismissView']/constructor[@name='SwipeDismissView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/view/View;)V", "")]
		public unsafe SwipeDismissView (global::Android.Content.Context p0, global::Android.Views.View p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (SwipeDismissView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/view/View;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/view/View;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_view_View_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/view/View;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_view_View_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_view_View_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ILandroid_view_View_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='SwipeDismissView']/constructor[@name='SwipeDismissView' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int'] and parameter[4][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;ILandroid/view/View;)V", "")]
		public unsafe SwipeDismissView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2, global::Android.Views.View p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (SwipeDismissView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;ILandroid/view/View;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;ILandroid/view/View;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ILandroid_view_View_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ILandroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;ILandroid/view/View;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ILandroid_view_View_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ILandroid_view_View_, __args);
			} finally {
			}
		}

		static Delegate cb_setCallback_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_;
#pragma warning disable 0169
		static Delegate GetSetCallback_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_Handler ()
		{
			if (cb_setCallback_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_ == null)
				cb_setCallback_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallback_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_);
			return cb_setCallback_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_;
		}

		static void n_SetCallback_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.SwipeDismissView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.SwipeDismissView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.WearMapView.IOnDismissCallback p0 = (global::Com.Baidu.Mapapi.Map.WearMapView.IOnDismissCallback)global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView.IOnDismissCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCallback_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='SwipeDismissView']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.WearMapView.OnDismissCallback']]"
		[Register ("setCallback", "(Lcom/baidu/mapapi/map/WearMapView$OnDismissCallback;)V", "GetSetCallback_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_Handler")]
		public virtual unsafe void SetCallback (global::Com.Baidu.Mapapi.Map.WearMapView.IOnDismissCallback p0)
		{
			if (id_setCallback_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_ == IntPtr.Zero)
				id_setCallback_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_ = JNIEnv.GetMethodID (class_ref, "setCallback", "(Lcom/baidu/mapapi/map/WearMapView$OnDismissCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCallback_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCallback", "(Lcom/baidu/mapapi/map/WearMapView$OnDismissCallback;)V"), __args);
			} finally {
			}
		}

	}
}
