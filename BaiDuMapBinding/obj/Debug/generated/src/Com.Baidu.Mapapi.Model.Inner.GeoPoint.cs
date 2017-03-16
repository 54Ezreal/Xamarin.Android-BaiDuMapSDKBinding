using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Model.Inner {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='GeoPoint']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/model/inner/GeoPoint", DoNotGenerateAcw=true)]
	public partial class GeoPoint : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/model/inner/GeoPoint", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GeoPoint); }
		}

		protected GeoPoint (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_DD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='GeoPoint']/constructor[@name='GeoPoint' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register (".ctor", "(DD)V", "")]
		public unsafe GeoPoint (double p0, double p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (GeoPoint)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(DD)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(DD)V", __args);
					return;
				}

				if (id_ctor_DD == IntPtr.Zero)
					id_ctor_DD = JNIEnv.GetMethodID (class_ref, "<init>", "(DD)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_DD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_DD, __args);
			} finally {
			}
		}

		static Delegate cb_getLatitudeE6;
#pragma warning disable 0169
		static Delegate GetGetLatitudeE6Handler ()
		{
			if (cb_getLatitudeE6 == null)
				cb_getLatitudeE6 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLatitudeE6);
			return cb_getLatitudeE6;
		}

		static double n_GetLatitudeE6 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Model.Inner.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LatitudeE6;
		}
#pragma warning restore 0169

		static Delegate cb_setLatitudeE6_D;
#pragma warning disable 0169
		static Delegate GetSetLatitudeE6_DHandler ()
		{
			if (cb_setLatitudeE6_D == null)
				cb_setLatitudeE6_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetLatitudeE6_D);
			return cb_setLatitudeE6_D;
		}

		static void n_SetLatitudeE6_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Baidu.Mapapi.Model.Inner.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LatitudeE6 = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLatitudeE6;
		static IntPtr id_setLatitudeE6_D;
		public virtual unsafe double LatitudeE6 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='GeoPoint']/method[@name='getLatitudeE6' and count(parameter)=0]"
			[Register ("getLatitudeE6", "()D", "GetGetLatitudeE6Handler")]
			get {
				if (id_getLatitudeE6 == IntPtr.Zero)
					id_getLatitudeE6 = JNIEnv.GetMethodID (class_ref, "getLatitudeE6", "()D");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getLatitudeE6);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLatitudeE6", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='GeoPoint']/method[@name='setLatitudeE6' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLatitudeE6", "(D)V", "GetSetLatitudeE6_DHandler")]
			set {
				if (id_setLatitudeE6_D == IntPtr.Zero)
					id_setLatitudeE6_D = JNIEnv.GetMethodID (class_ref, "setLatitudeE6", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLatitudeE6_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLatitudeE6", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLongitudeE6;
#pragma warning disable 0169
		static Delegate GetGetLongitudeE6Handler ()
		{
			if (cb_getLongitudeE6 == null)
				cb_getLongitudeE6 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLongitudeE6);
			return cb_getLongitudeE6;
		}

		static double n_GetLongitudeE6 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Model.Inner.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LongitudeE6;
		}
#pragma warning restore 0169

		static Delegate cb_setLongitudeE6_D;
#pragma warning disable 0169
		static Delegate GetSetLongitudeE6_DHandler ()
		{
			if (cb_setLongitudeE6_D == null)
				cb_setLongitudeE6_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetLongitudeE6_D);
			return cb_setLongitudeE6_D;
		}

		static void n_SetLongitudeE6_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Baidu.Mapapi.Model.Inner.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LongitudeE6 = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLongitudeE6;
		static IntPtr id_setLongitudeE6_D;
		public virtual unsafe double LongitudeE6 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='GeoPoint']/method[@name='getLongitudeE6' and count(parameter)=0]"
			[Register ("getLongitudeE6", "()D", "GetGetLongitudeE6Handler")]
			get {
				if (id_getLongitudeE6 == IntPtr.Zero)
					id_getLongitudeE6 = JNIEnv.GetMethodID (class_ref, "getLongitudeE6", "()D");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getLongitudeE6);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLongitudeE6", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='GeoPoint']/method[@name='setLongitudeE6' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLongitudeE6", "(D)V", "GetSetLongitudeE6_DHandler")]
			set {
				if (id_setLongitudeE6_D == IntPtr.Zero)
					id_setLongitudeE6_D = JNIEnv.GetMethodID (class_ref, "setLongitudeE6", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLongitudeE6_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLongitudeE6", "(D)V"), __args);
				} finally {
				}
			}
		}

	}
}
