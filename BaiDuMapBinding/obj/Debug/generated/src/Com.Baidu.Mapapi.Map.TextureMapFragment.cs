using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextureMapFragment']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/TextureMapFragment", DoNotGenerateAcw=true)]
	public partial class TextureMapFragment : global::Android.App.Fragment {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/TextureMapFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TextureMapFragment); }
		}

		protected TextureMapFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextureMapFragment']/constructor[@name='TextureMapFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TextureMapFragment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TextureMapFragment)) {
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

		static Delegate cb_getBaiduMap;
#pragma warning disable 0169
		static Delegate GetGetBaiduMapHandler ()
		{
			if (cb_getBaiduMap == null)
				cb_getBaiduMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBaiduMap);
			return cb_getBaiduMap;
		}

		static IntPtr n_GetBaiduMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.TextureMapFragment __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TextureMapFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BaiduMap);
		}
#pragma warning restore 0169

		static IntPtr id_getBaiduMap;
		public virtual unsafe global::Com.Baidu.Mapapi.Map.BaiduMap BaiduMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextureMapFragment']/method[@name='getBaiduMap' and count(parameter)=0]"
			[Register ("getBaiduMap", "()Lcom/baidu/mapapi/map/BaiduMap;", "GetGetBaiduMapHandler")]
			get {
				if (id_getBaiduMap == IntPtr.Zero)
					id_getBaiduMap = JNIEnv.GetMethodID (class_ref, "getBaiduMap", "()Lcom/baidu/mapapi/map/BaiduMap;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBaiduMap), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBaiduMap", "()Lcom/baidu/mapapi/map/BaiduMap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMapView;
#pragma warning disable 0169
		static Delegate GetGetMapViewHandler ()
		{
			if (cb_getMapView == null)
				cb_getMapView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMapView);
			return cb_getMapView;
		}

		static IntPtr n_GetMapView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.TextureMapFragment __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TextureMapFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MapView);
		}
#pragma warning restore 0169

		static IntPtr id_getMapView;
		public virtual unsafe global::Com.Baidu.Mapapi.Map.TextureMapView MapView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextureMapFragment']/method[@name='getMapView' and count(parameter)=0]"
			[Register ("getMapView", "()Lcom/baidu/mapapi/map/TextureMapView;", "GetGetMapViewHandler")]
			get {
				if (id_getMapView == IntPtr.Zero)
					id_getMapView = JNIEnv.GetMethodID (class_ref, "getMapView", "()Lcom/baidu/mapapi/map/TextureMapView;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TextureMapView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMapView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TextureMapView> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMapView", "()Lcom/baidu/mapapi/map/TextureMapView;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_newInstance;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextureMapFragment']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lcom/baidu/mapapi/map/TextureMapFragment;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.TextureMapFragment NewInstance ()
		{
			if (id_newInstance == IntPtr.Zero)
				id_newInstance = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "()Lcom/baidu/mapapi/map/TextureMapFragment;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TextureMapFragment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_newInstance_Lcom_baidu_mapapi_map_BaiduMapOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextureMapFragment']/method[@name='newInstance' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMapOptions']]"
		[Register ("newInstance", "(Lcom/baidu/mapapi/map/BaiduMapOptions;)Lcom/baidu/mapapi/map/TextureMapFragment;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.TextureMapFragment NewInstance (global::Com.Baidu.Mapapi.Map.BaiduMapOptions p0)
		{
			if (id_newInstance_Lcom_baidu_mapapi_map_BaiduMapOptions_ == IntPtr.Zero)
				id_newInstance_Lcom_baidu_mapapi_map_BaiduMapOptions_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Lcom/baidu/mapapi/map/BaiduMapOptions;)Lcom/baidu/mapapi/map/TextureMapFragment;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.TextureMapFragment __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TextureMapFragment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Lcom_baidu_mapapi_map_BaiduMapOptions_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
