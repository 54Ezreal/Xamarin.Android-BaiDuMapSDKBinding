using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='HeatMap']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/HeatMap", DoNotGenerateAcw=true)]
	public partial class HeatMap : global::Java.Lang.Object {


		static IntPtr DEFAULT_GRADIENT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='HeatMap']/field[@name='DEFAULT_GRADIENT']"
		[Register ("DEFAULT_GRADIENT")]
		public static global::Com.Baidu.Mapapi.Map.Gradient DefaultGradient {
			get {
				if (DEFAULT_GRADIENT_jfieldId == IntPtr.Zero)
					DEFAULT_GRADIENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_GRADIENT", "Lcom/baidu/mapapi/map/Gradient;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_GRADIENT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Gradient> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='HeatMap']/field[@name='DEFAULT_OPACITY']"
		[Register ("DEFAULT_OPACITY")]
		public const double DefaultOpacity = (double) 0.600000000000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='HeatMap']/field[@name='DEFAULT_RADIUS']"
		[Register ("DEFAULT_RADIUS")]
		public const int DefaultRadius = (int) 12;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='HeatMap.Builder']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/map/HeatMap$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/mapapi/map/HeatMap$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='HeatMap.Builder']/constructor[@name='HeatMap.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Builder)) {
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

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Map.HeatMap.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='HeatMap.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/baidu/mapapi/map/HeatMap;", "GetBuildHandler")]
			public virtual unsafe global::Com.Baidu.Mapapi.Map.HeatMap Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/baidu/mapapi/map/HeatMap;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/baidu/mapapi/map/HeatMap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_data_Ljava_util_Collection_;
#pragma warning disable 0169
			static Delegate GetData_Ljava_util_Collection_Handler ()
			{
				if (cb_data_Ljava_util_Collection_ == null)
					cb_data_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Data_Ljava_util_Collection_);
				return cb_data_Ljava_util_Collection_;
			}

			static IntPtr n_Data_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.HeatMap.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaCollection<global::Com.Baidu.Mapapi.Model.LatLng>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Data (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_data_Ljava_util_Collection_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='HeatMap.Builder']/method[@name='data' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;com.baidu.mapapi.model.LatLng&gt;']]"
			[Register ("data", "(Ljava/util/Collection;)Lcom/baidu/mapapi/map/HeatMap$Builder;", "GetData_Ljava_util_Collection_Handler")]
			public virtual unsafe global::Com.Baidu.Mapapi.Map.HeatMap.Builder Data (global::System.Collections.Generic.ICollection<global::Com.Baidu.Mapapi.Model.LatLng> p0)
			{
				if (id_data_Ljava_util_Collection_ == IntPtr.Zero)
					id_data_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "data", "(Ljava/util/Collection;)Lcom/baidu/mapapi/map/HeatMap$Builder;");
				IntPtr native_p0 = global::Android.Runtime.JavaCollection<global::Com.Baidu.Mapapi.Model.LatLng>.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Baidu.Mapapi.Map.HeatMap.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_data_Ljava_util_Collection_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "data", "(Ljava/util/Collection;)Lcom/baidu/mapapi/map/HeatMap$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_gradient_Lcom_baidu_mapapi_map_Gradient_;
#pragma warning disable 0169
			static Delegate GetGradient_Lcom_baidu_mapapi_map_Gradient_Handler ()
			{
				if (cb_gradient_Lcom_baidu_mapapi_map_Gradient_ == null)
					cb_gradient_Lcom_baidu_mapapi_map_Gradient_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Gradient_Lcom_baidu_mapapi_map_Gradient_);
				return cb_gradient_Lcom_baidu_mapapi_map_Gradient_;
			}

			static IntPtr n_Gradient_Lcom_baidu_mapapi_map_Gradient_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.HeatMap.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Map.Gradient p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Gradient> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Gradient (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_gradient_Lcom_baidu_mapapi_map_Gradient_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='HeatMap.Builder']/method[@name='gradient' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.Gradient']]"
			[Register ("gradient", "(Lcom/baidu/mapapi/map/Gradient;)Lcom/baidu/mapapi/map/HeatMap$Builder;", "GetGradient_Lcom_baidu_mapapi_map_Gradient_Handler")]
			public virtual unsafe global::Com.Baidu.Mapapi.Map.HeatMap.Builder Gradient (global::Com.Baidu.Mapapi.Map.Gradient p0)
			{
				if (id_gradient_Lcom_baidu_mapapi_map_Gradient_ == IntPtr.Zero)
					id_gradient_Lcom_baidu_mapapi_map_Gradient_ = JNIEnv.GetMethodID (class_ref, "gradient", "(Lcom/baidu/mapapi/map/Gradient;)Lcom/baidu/mapapi/map/HeatMap$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Baidu.Mapapi.Map.HeatMap.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_gradient_Lcom_baidu_mapapi_map_Gradient_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "gradient", "(Lcom/baidu/mapapi/map/Gradient;)Lcom/baidu/mapapi/map/HeatMap$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_opacity_D;
#pragma warning disable 0169
			static Delegate GetOpacity_DHandler ()
			{
				if (cb_opacity_D == null)
					cb_opacity_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_Opacity_D);
				return cb_opacity_D;
			}

			static IntPtr n_Opacity_D (IntPtr jnienv, IntPtr native__this, double p0)
			{
				global::Com.Baidu.Mapapi.Map.HeatMap.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Opacity (p0));
			}
#pragma warning restore 0169

			static IntPtr id_opacity_D;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='HeatMap.Builder']/method[@name='opacity' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("opacity", "(D)Lcom/baidu/mapapi/map/HeatMap$Builder;", "GetOpacity_DHandler")]
			public virtual unsafe global::Com.Baidu.Mapapi.Map.HeatMap.Builder Opacity (double p0)
			{
				if (id_opacity_D == IntPtr.Zero)
					id_opacity_D = JNIEnv.GetMethodID (class_ref, "opacity", "(D)Lcom/baidu/mapapi/map/HeatMap$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_opacity_D, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "opacity", "(D)Lcom/baidu/mapapi/map/HeatMap$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_radius_I;
#pragma warning disable 0169
			static Delegate GetRadius_IHandler ()
			{
				if (cb_radius_I == null)
					cb_radius_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Radius_I);
				return cb_radius_I;
			}

			static IntPtr n_Radius_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Baidu.Mapapi.Map.HeatMap.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Radius (p0));
			}
#pragma warning restore 0169

			static IntPtr id_radius_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='HeatMap.Builder']/method[@name='radius' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("radius", "(I)Lcom/baidu/mapapi/map/HeatMap$Builder;", "GetRadius_IHandler")]
			public virtual unsafe global::Com.Baidu.Mapapi.Map.HeatMap.Builder Radius (int p0)
			{
				if (id_radius_I == IntPtr.Zero)
					id_radius_I = JNIEnv.GetMethodID (class_ref, "radius", "(I)Lcom/baidu/mapapi/map/HeatMap$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_radius_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "radius", "(I)Lcom/baidu/mapapi/map/HeatMap$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/HeatMap", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HeatMap); }
		}

		protected HeatMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_removeHeatMap;
#pragma warning disable 0169
		static Delegate GetRemoveHeatMapHandler ()
		{
			if (cb_removeHeatMap == null)
				cb_removeHeatMap = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveHeatMap);
			return cb_removeHeatMap;
		}

		static void n_RemoveHeatMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.HeatMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveHeatMap ();
		}
#pragma warning restore 0169

		static IntPtr id_removeHeatMap;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='HeatMap']/method[@name='removeHeatMap' and count(parameter)=0]"
		[Register ("removeHeatMap", "()V", "GetRemoveHeatMapHandler")]
		public virtual unsafe void RemoveHeatMap ()
		{
			if (id_removeHeatMap == IntPtr.Zero)
				id_removeHeatMap = JNIEnv.GetMethodID (class_ref, "removeHeatMap", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeHeatMap);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeHeatMap", "()V"));
			} finally {
			}
		}

	}
}
