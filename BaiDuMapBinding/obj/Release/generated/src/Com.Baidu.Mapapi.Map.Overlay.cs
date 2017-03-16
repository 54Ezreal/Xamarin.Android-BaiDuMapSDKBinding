using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Overlay']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/Overlay", DoNotGenerateAcw=true)]
	public abstract partial class Overlay : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/Overlay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Overlay); }
		}

		protected Overlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Overlay']/constructor[@name='Overlay' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe Overlay ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Overlay)) {
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

		static Delegate cb_getExtraInfo;
#pragma warning disable 0169
		static Delegate GetGetExtraInfoHandler ()
		{
			if (cb_getExtraInfo == null)
				cb_getExtraInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtraInfo);
			return cb_getExtraInfo;
		}

		static IntPtr n_GetExtraInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExtraInfo);
		}
#pragma warning restore 0169

		static Delegate cb_setExtraInfo_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSetExtraInfo_Landroid_os_Bundle_Handler ()
		{
			if (cb_setExtraInfo_Landroid_os_Bundle_ == null)
				cb_setExtraInfo_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExtraInfo_Landroid_os_Bundle_);
			return cb_setExtraInfo_Landroid_os_Bundle_;
		}

		static void n_SetExtraInfo_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExtraInfo = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExtraInfo;
		static IntPtr id_setExtraInfo_Landroid_os_Bundle_;
		public virtual unsafe global::Android.OS.Bundle ExtraInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Overlay']/method[@name='getExtraInfo' and count(parameter)=0]"
			[Register ("getExtraInfo", "()Landroid/os/Bundle;", "GetGetExtraInfoHandler")]
			get {
				if (id_getExtraInfo == IntPtr.Zero)
					id_getExtraInfo = JNIEnv.GetMethodID (class_ref, "getExtraInfo", "()Landroid/os/Bundle;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExtraInfo), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExtraInfo", "()Landroid/os/Bundle;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Overlay']/method[@name='setExtraInfo' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("setExtraInfo", "(Landroid/os/Bundle;)V", "GetSetExtraInfo_Landroid_os_Bundle_Handler")]
			set {
				if (id_setExtraInfo_Landroid_os_Bundle_ == IntPtr.Zero)
					id_setExtraInfo_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "setExtraInfo", "(Landroid/os/Bundle;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setExtraInfo_Landroid_os_Bundle_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExtraInfo", "(Landroid/os/Bundle;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isVisible;
#pragma warning disable 0169
		static Delegate GetIsVisibleHandler ()
		{
			if (cb_isVisible == null)
				cb_isVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsVisible);
			return cb_isVisible;
		}

		static bool n_IsVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Visible;
		}
#pragma warning restore 0169

		static Delegate cb_setVisible_Z;
#pragma warning disable 0169
		static Delegate GetSetVisible_ZHandler ()
		{
			if (cb_setVisible_Z == null)
				cb_setVisible_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetVisible_Z);
			return cb_setVisible_Z;
		}

		static void n_SetVisible_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Baidu.Mapapi.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Visible = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isVisible;
		static IntPtr id_setVisible_Z;
		public virtual unsafe bool Visible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Overlay']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isVisible);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isVisible", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Overlay']/method[@name='setVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setVisible", "(Z)V", "GetSetVisible_ZHandler")]
			set {
				if (id_setVisible_Z == IntPtr.Zero)
					id_setVisible_Z = JNIEnv.GetMethodID (class_ref, "setVisible", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVisible_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVisible", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getZIndex;
#pragma warning disable 0169
		static Delegate GetGetZIndexHandler ()
		{
			if (cb_getZIndex == null)
				cb_getZIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetZIndex);
			return cb_getZIndex;
		}

		static int n_GetZIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZIndex;
		}
#pragma warning restore 0169

		static Delegate cb_setZIndex_I;
#pragma warning disable 0169
		static Delegate GetSetZIndex_IHandler ()
		{
			if (cb_setZIndex_I == null)
				cb_setZIndex_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetZIndex_I);
			return cb_setZIndex_I;
		}

		static void n_SetZIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZIndex = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getZIndex;
		static IntPtr id_setZIndex_I;
		public virtual unsafe int ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Overlay']/method[@name='getZIndex' and count(parameter)=0]"
			[Register ("getZIndex", "()I", "GetGetZIndexHandler")]
			get {
				if (id_getZIndex == IntPtr.Zero)
					id_getZIndex = JNIEnv.GetMethodID (class_ref, "getZIndex", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getZIndex);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getZIndex", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Overlay']/method[@name='setZIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setZIndex", "(I)V", "GetSetZIndex_IHandler")]
			set {
				if (id_setZIndex_I == IntPtr.Zero)
					id_setZIndex_I = JNIEnv.GetMethodID (class_ref, "setZIndex", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setZIndex_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setZIndex", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_remove;
#pragma warning disable 0169
		static Delegate GetRemoveHandler ()
		{
			if (cb_remove == null)
				cb_remove = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Remove);
			return cb_remove;
		}

		static void n_Remove (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Remove ();
		}
#pragma warning restore 0169

		static IntPtr id_remove;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Overlay']/method[@name='remove' and count(parameter)=0]"
		[Register ("remove", "()V", "GetRemoveHandler")]
		public virtual unsafe void Remove ()
		{
			if (id_remove == IntPtr.Zero)
				id_remove = JNIEnv.GetMethodID (class_ref, "remove", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "()V"));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/baidu/mapapi/map/Overlay", DoNotGenerateAcw=true)]
	internal partial class OverlayInvoker : Overlay {

		public OverlayInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (OverlayInvoker); }
		}

	}

}
