using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='ItemizedOverlay']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/ItemizedOverlay", DoNotGenerateAcw=true)]
	public partial class ItemizedOverlay : global::Com.Baidu.Mapapi.Map.Overlay {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/ItemizedOverlay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ItemizedOverlay); }
		}

		protected ItemizedOverlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_graphics_drawable_Drawable_Lcom_baidu_mapapi_map_MapView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='ItemizedOverlay']/constructor[@name='ItemizedOverlay' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='com.baidu.mapapi.map.MapView']]"
		[Register (".ctor", "(Landroid/graphics/drawable/Drawable;Lcom/baidu/mapapi/map/MapView;)V", "")]
		public unsafe ItemizedOverlay (global::Android.Graphics.Drawables.Drawable p0, global::Com.Baidu.Mapapi.Map.MapView p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ItemizedOverlay)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/graphics/drawable/Drawable;Lcom/baidu/mapapi/map/MapView;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/graphics/drawable/Drawable;Lcom/baidu/mapapi/map/MapView;)V", __args);
					return;
				}

				if (id_ctor_Landroid_graphics_drawable_Drawable_Lcom_baidu_mapapi_map_MapView_ == IntPtr.Zero)
					id_ctor_Landroid_graphics_drawable_Drawable_Lcom_baidu_mapapi_map_MapView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/drawable/Drawable;Lcom/baidu/mapapi/map/MapView;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_drawable_Drawable_Lcom_baidu_mapapi_map_MapView_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_graphics_drawable_Drawable_Lcom_baidu_mapapi_map_MapView_, __args);
			} finally {
			}
		}

		static Delegate cb_addItem_Lcom_baidu_mapapi_map_OverlayOptions_;
#pragma warning disable 0169
		static Delegate GetAddItem_Lcom_baidu_mapapi_map_OverlayOptions_Handler ()
		{
			if (cb_addItem_Lcom_baidu_mapapi_map_OverlayOptions_ == null)
				cb_addItem_Lcom_baidu_mapapi_map_OverlayOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddItem_Lcom_baidu_mapapi_map_OverlayOptions_);
			return cb_addItem_Lcom_baidu_mapapi_map_OverlayOptions_;
		}

		static void n_AddItem_Lcom_baidu_mapapi_map_OverlayOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.OverlayOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.OverlayOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddItem (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addItem_Lcom_baidu_mapapi_map_OverlayOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='ItemizedOverlay']/method[@name='addItem' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.OverlayOptions']]"
		[Register ("addItem", "(Lcom/baidu/mapapi/map/OverlayOptions;)V", "GetAddItem_Lcom_baidu_mapapi_map_OverlayOptions_Handler")]
		public virtual unsafe void AddItem (global::Com.Baidu.Mapapi.Map.OverlayOptions p0)
		{
			if (id_addItem_Lcom_baidu_mapapi_map_OverlayOptions_ == IntPtr.Zero)
				id_addItem_Lcom_baidu_mapapi_map_OverlayOptions_ = JNIEnv.GetMethodID (class_ref, "addItem", "(Lcom/baidu/mapapi/map/OverlayOptions;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addItem_Lcom_baidu_mapapi_map_OverlayOptions_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addItem", "(Lcom/baidu/mapapi/map/OverlayOptions;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_reAddAll;
#pragma warning disable 0169
		static Delegate GetReAddAllHandler ()
		{
			if (cb_reAddAll == null)
				cb_reAddAll = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReAddAll);
			return cb_reAddAll;
		}

		static void n_ReAddAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReAddAll ();
		}
#pragma warning restore 0169

		static IntPtr id_reAddAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='ItemizedOverlay']/method[@name='reAddAll' and count(parameter)=0]"
		[Register ("reAddAll", "()V", "GetReAddAllHandler")]
		public virtual unsafe void ReAddAll ()
		{
			if (id_reAddAll == IntPtr.Zero)
				id_reAddAll = JNIEnv.GetMethodID (class_ref, "reAddAll", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reAddAll);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reAddAll", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeAll;
#pragma warning disable 0169
		static Delegate GetRemoveAllHandler ()
		{
			if (cb_removeAll == null)
				cb_removeAll = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAll);
			return cb_removeAll;
		}

		static void n_RemoveAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAll ();
		}
#pragma warning restore 0169

		static IntPtr id_removeAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='ItemizedOverlay']/method[@name='removeAll' and count(parameter)=0]"
		[Register ("removeAll", "()V", "GetRemoveAllHandler")]
		public virtual unsafe void RemoveAll ()
		{
			if (id_removeAll == IntPtr.Zero)
				id_removeAll = JNIEnv.GetMethodID (class_ref, "removeAll", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeAll);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAll", "()V"));
			} finally {
			}
		}

	}
}
