using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Model.Inner {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='MapBound']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/model/inner/MapBound", DoNotGenerateAcw=true)]
	public partial class MapBound : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/model/inner/MapBound", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapBound); }
		}

		protected MapBound (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='MapBound']/constructor[@name='MapBound' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MapBound ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MapBound)) {
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

		static Delegate cb_getPtLB;
#pragma warning disable 0169
		static Delegate GetGetPtLBHandler ()
		{
			if (cb_getPtLB == null)
				cb_getPtLB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPtLB);
			return cb_getPtLB;
		}

		static IntPtr n_GetPtLB (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Model.Inner.MapBound __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.MapBound> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PtLB);
		}
#pragma warning restore 0169

		static Delegate cb_setPtLB_Lcom_baidu_mapapi_model_inner_Point_;
#pragma warning disable 0169
		static Delegate GetSetPtLB_Lcom_baidu_mapapi_model_inner_Point_Handler ()
		{
			if (cb_setPtLB_Lcom_baidu_mapapi_model_inner_Point_ == null)
				cb_setPtLB_Lcom_baidu_mapapi_model_inner_Point_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPtLB_Lcom_baidu_mapapi_model_inner_Point_);
			return cb_setPtLB_Lcom_baidu_mapapi_model_inner_Point_;
		}

		static void n_SetPtLB_Lcom_baidu_mapapi_model_inner_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Model.Inner.MapBound __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.MapBound> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Model.Inner.Point p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PtLB = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPtLB;
		static IntPtr id_setPtLB_Lcom_baidu_mapapi_model_inner_Point_;
		public virtual unsafe global::Com.Baidu.Mapapi.Model.Inner.Point PtLB {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='MapBound']/method[@name='getPtLB' and count(parameter)=0]"
			[Register ("getPtLB", "()Lcom/baidu/mapapi/model/inner/Point;", "GetGetPtLBHandler")]
			get {
				if (id_getPtLB == IntPtr.Zero)
					id_getPtLB = JNIEnv.GetMethodID (class_ref, "getPtLB", "()Lcom/baidu/mapapi/model/inner/Point;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.Point> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPtLB), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.Point> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPtLB", "()Lcom/baidu/mapapi/model/inner/Point;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='MapBound']/method[@name='setPtLB' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.inner.Point']]"
			[Register ("setPtLB", "(Lcom/baidu/mapapi/model/inner/Point;)V", "GetSetPtLB_Lcom_baidu_mapapi_model_inner_Point_Handler")]
			set {
				if (id_setPtLB_Lcom_baidu_mapapi_model_inner_Point_ == IntPtr.Zero)
					id_setPtLB_Lcom_baidu_mapapi_model_inner_Point_ = JNIEnv.GetMethodID (class_ref, "setPtLB", "(Lcom/baidu/mapapi/model/inner/Point;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPtLB_Lcom_baidu_mapapi_model_inner_Point_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPtLB", "(Lcom/baidu/mapapi/model/inner/Point;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPtRT;
#pragma warning disable 0169
		static Delegate GetGetPtRTHandler ()
		{
			if (cb_getPtRT == null)
				cb_getPtRT = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPtRT);
			return cb_getPtRT;
		}

		static IntPtr n_GetPtRT (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Model.Inner.MapBound __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.MapBound> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PtRT);
		}
#pragma warning restore 0169

		static Delegate cb_setPtRT_Lcom_baidu_mapapi_model_inner_Point_;
#pragma warning disable 0169
		static Delegate GetSetPtRT_Lcom_baidu_mapapi_model_inner_Point_Handler ()
		{
			if (cb_setPtRT_Lcom_baidu_mapapi_model_inner_Point_ == null)
				cb_setPtRT_Lcom_baidu_mapapi_model_inner_Point_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPtRT_Lcom_baidu_mapapi_model_inner_Point_);
			return cb_setPtRT_Lcom_baidu_mapapi_model_inner_Point_;
		}

		static void n_SetPtRT_Lcom_baidu_mapapi_model_inner_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Model.Inner.MapBound __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.MapBound> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Model.Inner.Point p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PtRT = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPtRT;
		static IntPtr id_setPtRT_Lcom_baidu_mapapi_model_inner_Point_;
		public virtual unsafe global::Com.Baidu.Mapapi.Model.Inner.Point PtRT {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='MapBound']/method[@name='getPtRT' and count(parameter)=0]"
			[Register ("getPtRT", "()Lcom/baidu/mapapi/model/inner/Point;", "GetGetPtRTHandler")]
			get {
				if (id_getPtRT == IntPtr.Zero)
					id_getPtRT = JNIEnv.GetMethodID (class_ref, "getPtRT", "()Lcom/baidu/mapapi/model/inner/Point;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.Point> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPtRT), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.Point> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPtRT", "()Lcom/baidu/mapapi/model/inner/Point;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='MapBound']/method[@name='setPtRT' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.inner.Point']]"
			[Register ("setPtRT", "(Lcom/baidu/mapapi/model/inner/Point;)V", "GetSetPtRT_Lcom_baidu_mapapi_model_inner_Point_Handler")]
			set {
				if (id_setPtRT_Lcom_baidu_mapapi_model_inner_Point_ == IntPtr.Zero)
					id_setPtRT_Lcom_baidu_mapapi_model_inner_Point_ = JNIEnv.GetMethodID (class_ref, "setPtRT", "(Lcom/baidu/mapapi/model/inner/Point;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPtRT_Lcom_baidu_mapapi_model_inner_Point_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPtRT", "(Lcom/baidu/mapapi/model/inner/Point;)V"), __args);
				} finally {
				}
			}
		}

	}
}
