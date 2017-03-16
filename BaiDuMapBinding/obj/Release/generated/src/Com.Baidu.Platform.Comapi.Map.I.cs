using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='I']"
	[global::Android.Runtime.Register ("com/baidu/platform/comapi/map/I", DoNotGenerateAcw=true)]
	public partial class I : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/platform/comapi/map/I", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (I); }
		}

		protected I (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_a_Lcom_baidu_mapapi_model_inner_GeoPoint_;
#pragma warning disable 0169
		static Delegate GetA_Lcom_baidu_mapapi_model_inner_GeoPoint_Handler ()
		{
			if (cb_a_Lcom_baidu_mapapi_model_inner_GeoPoint_ == null)
				cb_a_Lcom_baidu_mapapi_model_inner_GeoPoint_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Lcom_baidu_mapapi_model_inner_GeoPoint_);
			return cb_a_Lcom_baidu_mapapi_model_inner_GeoPoint_;
		}

		static IntPtr n_A_Lcom_baidu_mapapi_model_inner_GeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Platform.Comapi.Map.I __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.I> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Model.Inner.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.A (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_a_Lcom_baidu_mapapi_model_inner_GeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='I']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.inner.GeoPoint']]"
		[Register ("a", "(Lcom/baidu/mapapi/model/inner/GeoPoint;)Landroid/graphics/Point;", "GetA_Lcom_baidu_mapapi_model_inner_GeoPoint_Handler")]
		public virtual unsafe global::Android.Graphics.Point A (global::Com.Baidu.Mapapi.Model.Inner.GeoPoint p0)
		{
			if (id_a_Lcom_baidu_mapapi_model_inner_GeoPoint_ == IntPtr.Zero)
				id_a_Lcom_baidu_mapapi_model_inner_GeoPoint_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/baidu/mapapi/model/inner/GeoPoint;)Landroid/graphics/Point;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.Graphics.Point __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_a_Lcom_baidu_mapapi_model_inner_GeoPoint_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Lcom/baidu/mapapi/model/inner/GeoPoint;)Landroid/graphics/Point;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_a_II;
#pragma warning disable 0169
		static Delegate GetA_IIHandler ()
		{
			if (cb_a_II == null)
				cb_a_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_A_II);
			return cb_a_II;
		}

		static IntPtr n_A_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Baidu.Platform.Comapi.Map.I __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.I> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.A (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_a_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='I']/method[@name='a' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("a", "(II)Lcom/baidu/mapapi/model/inner/GeoPoint;", "GetA_IIHandler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Model.Inner.GeoPoint A (int p0, int p1)
		{
			if (id_a_II == IntPtr.Zero)
				id_a_II = JNIEnv.GetMethodID (class_ref, "a", "(II)Lcom/baidu/mapapi/model/inner/GeoPoint;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.GeoPoint> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_a_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.GeoPoint> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(II)Lcom/baidu/mapapi/model/inner/GeoPoint;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
