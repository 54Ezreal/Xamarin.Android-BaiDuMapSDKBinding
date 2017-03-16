using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap", DoNotGenerateAcw=true)]
	public partial class BaiduMap : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/field[@name='MAP_TYPE_NONE']"
		[Register ("MAP_TYPE_NONE")]
		public const int MapTypeNone = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/field[@name='MAP_TYPE_NORMAL']"
		[Register ("MAP_TYPE_NORMAL")]
		public const int MapTypeNormal = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/field[@name='MAP_TYPE_SATELLITE']"
		[Register ("MAP_TYPE_SATELLITE")]
		public const int MapTypeSatellite = (int) 2;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnBaseIndoorMapListener']"
		[Register ("com/baidu/mapapi/map/BaiduMap$OnBaseIndoorMapListener", "", "Com.Baidu.Mapapi.Map.BaiduMap/IOnBaseIndoorMapListenerInvoker")]
		public partial interface IOnBaseIndoorMapListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnBaseIndoorMapListener']/method[@name='onBaseIndoorMapMode' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.baidu.mapapi.map.MapBaseIndoorMapInfo']]"
			[Register ("onBaseIndoorMapMode", "(ZLcom/baidu/mapapi/map/MapBaseIndoorMapInfo;)V", "GetOnBaseIndoorMapMode_ZLcom_baidu_mapapi_map_MapBaseIndoorMapInfo_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnBaseIndoorMapListenerInvoker, XamarinBaiDuMapSDKBinding")]
			void OnBaseIndoorMapMode (bool p0, global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo p1);

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$OnBaseIndoorMapListener", DoNotGenerateAcw=true)]
		internal class IOnBaseIndoorMapListenerInvoker : global::Java.Lang.Object, IOnBaseIndoorMapListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/mapapi/map/BaiduMap$OnBaseIndoorMapListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnBaseIndoorMapListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnBaseIndoorMapListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnBaseIndoorMapListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.OnBaseIndoorMapListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnBaseIndoorMapListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onBaseIndoorMapMode_ZLcom_baidu_mapapi_map_MapBaseIndoorMapInfo_;
#pragma warning disable 0169
			static Delegate GetOnBaseIndoorMapMode_ZLcom_baidu_mapapi_map_MapBaseIndoorMapInfo_Handler ()
			{
				if (cb_onBaseIndoorMapMode_ZLcom_baidu_mapapi_map_MapBaseIndoorMapInfo_ == null)
					cb_onBaseIndoorMapMode_ZLcom_baidu_mapapi_map_MapBaseIndoorMapInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_OnBaseIndoorMapMode_ZLcom_baidu_mapapi_map_MapBaseIndoorMapInfo_);
				return cb_onBaseIndoorMapMode_ZLcom_baidu_mapapi_map_MapBaseIndoorMapInfo_;
			}

			static void n_OnBaseIndoorMapMode_ZLcom_baidu_mapapi_map_MapBaseIndoorMapInfo_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnBaseIndoorMapListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnBaseIndoorMapListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo p1 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnBaseIndoorMapMode (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onBaseIndoorMapMode_ZLcom_baidu_mapapi_map_MapBaseIndoorMapInfo_;
			public unsafe void OnBaseIndoorMapMode (bool p0, global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo p1)
			{
				if (id_onBaseIndoorMapMode_ZLcom_baidu_mapapi_map_MapBaseIndoorMapInfo_ == IntPtr.Zero)
					id_onBaseIndoorMapMode_ZLcom_baidu_mapapi_map_MapBaseIndoorMapInfo_ = JNIEnv.GetMethodID (class_ref, "onBaseIndoorMapMode", "(ZLcom/baidu/mapapi/map/MapBaseIndoorMapInfo;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBaseIndoorMapMode_ZLcom_baidu_mapapi_map_MapBaseIndoorMapInfo_, __args);
			}

		}

		public partial class BaseIndoorMapEventArgs : global::System.EventArgs {

			public BaseIndoorMapEventArgs (bool p0, global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}

			global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo p1;
			public global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/baidu/mapapi/map/BaiduMap_OnBaseIndoorMapListenerImplementor")]
		internal sealed partial class IOnBaseIndoorMapListenerImplementor : global::Java.Lang.Object, IOnBaseIndoorMapListener {

			object sender;

			public IOnBaseIndoorMapListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/map/BaiduMap_OnBaseIndoorMapListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<BaseIndoorMapEventArgs> Handler;
#pragma warning restore 0649

			public void OnBaseIndoorMapMode (bool p0, global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new BaseIndoorMapEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnBaseIndoorMapListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapClickListener']"
		[Register ("com/baidu/mapapi/map/BaiduMap$OnMapClickListener", "", "Com.Baidu.Mapapi.Map.BaiduMap/IOnMapClickListenerInvoker")]
		public partial interface IOnMapClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapClickListener']/method[@name='onMapClick' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
			[Register ("onMapClick", "(Lcom/baidu/mapapi/model/LatLng;)V", "GetOnMapClick_Lcom_baidu_mapapi_model_LatLng_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapClickListenerInvoker, XamarinBaiDuMapSDKBinding")]
			void OnMapClick (global::Com.Baidu.Mapapi.Model.LatLng p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapClickListener']/method[@name='onMapPoiClick' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MapPoi']]"
			[Register ("onMapPoiClick", "(Lcom/baidu/mapapi/map/MapPoi;)Z", "GetOnMapPoiClick_Lcom_baidu_mapapi_map_MapPoi_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapClickListenerInvoker, XamarinBaiDuMapSDKBinding")]
			bool OnMapPoiClick (global::Com.Baidu.Mapapi.Map.MapPoi p0);

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$OnMapClickListener", DoNotGenerateAcw=true)]
		internal class IOnMapClickListenerInvoker : global::Java.Lang.Object, IOnMapClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/mapapi/map/BaiduMap$OnMapClickListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnMapClickListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnMapClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.OnMapClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMapClick_Lcom_baidu_mapapi_model_LatLng_;
#pragma warning disable 0169
			static Delegate GetOnMapClick_Lcom_baidu_mapapi_model_LatLng_Handler ()
			{
				if (cb_onMapClick_Lcom_baidu_mapapi_model_LatLng_ == null)
					cb_onMapClick_Lcom_baidu_mapapi_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapClick_Lcom_baidu_mapapi_model_LatLng_);
				return cb_onMapClick_Lcom_baidu_mapapi_model_LatLng_;
			}

			static void n_OnMapClick_Lcom_baidu_mapapi_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMapClick (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMapClick_Lcom_baidu_mapapi_model_LatLng_;
			public unsafe void OnMapClick (global::Com.Baidu.Mapapi.Model.LatLng p0)
			{
				if (id_onMapClick_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
					id_onMapClick_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "onMapClick", "(Lcom/baidu/mapapi/model/LatLng;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapClick_Lcom_baidu_mapapi_model_LatLng_, __args);
			}

			static Delegate cb_onMapPoiClick_Lcom_baidu_mapapi_map_MapPoi_;
#pragma warning disable 0169
			static Delegate GetOnMapPoiClick_Lcom_baidu_mapapi_map_MapPoi_Handler ()
			{
				if (cb_onMapPoiClick_Lcom_baidu_mapapi_map_MapPoi_ == null)
					cb_onMapPoiClick_Lcom_baidu_mapapi_map_MapPoi_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnMapPoiClick_Lcom_baidu_mapapi_map_MapPoi_);
				return cb_onMapPoiClick_Lcom_baidu_mapapi_map_MapPoi_;
			}

			static bool n_OnMapPoiClick_Lcom_baidu_mapapi_map_MapPoi_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Map.MapPoi p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapPoi> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnMapPoiClick (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onMapPoiClick_Lcom_baidu_mapapi_map_MapPoi_;
			public unsafe bool OnMapPoiClick (global::Com.Baidu.Mapapi.Map.MapPoi p0)
			{
				if (id_onMapPoiClick_Lcom_baidu_mapapi_map_MapPoi_ == IntPtr.Zero)
					id_onMapPoiClick_Lcom_baidu_mapapi_map_MapPoi_ = JNIEnv.GetMethodID (class_ref, "onMapPoiClick", "(Lcom/baidu/mapapi/map/MapPoi;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onMapPoiClick_Lcom_baidu_mapapi_map_MapPoi_, __args);
				return __ret;
			}

		}

		public partial class MapClickEventArgs : global::System.EventArgs {

			public MapClickEventArgs (global::Com.Baidu.Mapapi.Model.LatLng p0)
			{
				this.p0 = p0;
			}

			global::Com.Baidu.Mapapi.Model.LatLng p0;
			public global::Com.Baidu.Mapapi.Model.LatLng P0 {
				get { return p0; }
			}
		}

		public partial class MapPoiClickEventArgs : global::System.EventArgs {

			public MapPoiClickEventArgs (bool handled, global::Com.Baidu.Mapapi.Map.MapPoi p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Com.Baidu.Mapapi.Map.MapPoi p0;
			public global::Com.Baidu.Mapapi.Map.MapPoi P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/baidu/mapapi/map/BaiduMap_OnMapClickListenerImplementor")]
		internal sealed partial class IOnMapClickListenerImplementor : global::Java.Lang.Object, IOnMapClickListener {

			object sender;

			public IOnMapClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/map/BaiduMap_OnMapClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MapClickEventArgs> OnMapClickHandler;
#pragma warning restore 0649

			public void OnMapClick (global::Com.Baidu.Mapapi.Model.LatLng p0)
			{
				var __h = OnMapClickHandler;
				if (__h != null)
					__h (sender, new MapClickEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<MapPoiClickEventArgs> OnMapPoiClickHandler;
#pragma warning restore 0649

			public bool OnMapPoiClick (global::Com.Baidu.Mapapi.Map.MapPoi p0)
			{
				var __h = OnMapPoiClickHandler;
				if (__h == null)
					return false;
				var __e = new MapPoiClickEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnMapClickListenerImplementor value)
			{
				return value.OnMapClickHandler == null && value.OnMapPoiClickHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapDoubleClickListener']"
		[Register ("com/baidu/mapapi/map/BaiduMap$OnMapDoubleClickListener", "", "Com.Baidu.Mapapi.Map.BaiduMap/IOnMapDoubleClickListenerInvoker")]
		public partial interface IOnMapDoubleClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapDoubleClickListener']/method[@name='onMapDoubleClick' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
			[Register ("onMapDoubleClick", "(Lcom/baidu/mapapi/model/LatLng;)V", "GetOnMapDoubleClick_Lcom_baidu_mapapi_model_LatLng_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapDoubleClickListenerInvoker, XamarinBaiDuMapSDKBinding")]
			void OnMapDoubleClick (global::Com.Baidu.Mapapi.Model.LatLng p0);

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$OnMapDoubleClickListener", DoNotGenerateAcw=true)]
		internal class IOnMapDoubleClickListenerInvoker : global::Java.Lang.Object, IOnMapDoubleClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/mapapi/map/BaiduMap$OnMapDoubleClickListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnMapDoubleClickListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnMapDoubleClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapDoubleClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.OnMapDoubleClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapDoubleClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMapDoubleClick_Lcom_baidu_mapapi_model_LatLng_;
#pragma warning disable 0169
			static Delegate GetOnMapDoubleClick_Lcom_baidu_mapapi_model_LatLng_Handler ()
			{
				if (cb_onMapDoubleClick_Lcom_baidu_mapapi_model_LatLng_ == null)
					cb_onMapDoubleClick_Lcom_baidu_mapapi_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapDoubleClick_Lcom_baidu_mapapi_model_LatLng_);
				return cb_onMapDoubleClick_Lcom_baidu_mapapi_model_LatLng_;
			}

			static void n_OnMapDoubleClick_Lcom_baidu_mapapi_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDoubleClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDoubleClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMapDoubleClick (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMapDoubleClick_Lcom_baidu_mapapi_model_LatLng_;
			public unsafe void OnMapDoubleClick (global::Com.Baidu.Mapapi.Model.LatLng p0)
			{
				if (id_onMapDoubleClick_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
					id_onMapDoubleClick_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "onMapDoubleClick", "(Lcom/baidu/mapapi/model/LatLng;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapDoubleClick_Lcom_baidu_mapapi_model_LatLng_, __args);
			}

		}

		public partial class MapDoubleClickEventArgs : global::System.EventArgs {

			public MapDoubleClickEventArgs (global::Com.Baidu.Mapapi.Model.LatLng p0)
			{
				this.p0 = p0;
			}

			global::Com.Baidu.Mapapi.Model.LatLng p0;
			public global::Com.Baidu.Mapapi.Model.LatLng P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/baidu/mapapi/map/BaiduMap_OnMapDoubleClickListenerImplementor")]
		internal sealed partial class IOnMapDoubleClickListenerImplementor : global::Java.Lang.Object, IOnMapDoubleClickListener {

			object sender;

			public IOnMapDoubleClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/map/BaiduMap_OnMapDoubleClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MapDoubleClickEventArgs> Handler;
#pragma warning restore 0649

			public void OnMapDoubleClick (global::Com.Baidu.Mapapi.Model.LatLng p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new MapDoubleClickEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMapDoubleClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapDrawFrameCallback']"
		[Register ("com/baidu/mapapi/map/BaiduMap$OnMapDrawFrameCallback", "", "Com.Baidu.Mapapi.Map.BaiduMap/IOnMapDrawFrameCallbackInvoker")]
		public partial interface IOnMapDrawFrameCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapDrawFrameCallback']/method[@name='onMapDrawFrame' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MapStatus']]"
			[Register ("onMapDrawFrame", "(Lcom/baidu/mapapi/map/MapStatus;)V", "GetOnMapDrawFrame_Lcom_baidu_mapapi_map_MapStatus_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapDrawFrameCallbackInvoker, XamarinBaiDuMapSDKBinding")]
			void OnMapDrawFrame (global::Com.Baidu.Mapapi.Map.MapStatus p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapDrawFrameCallback']/method[@name='onMapDrawFrame' and count(parameter)=2 and parameter[1][@type='javax.microedition.khronos.opengles.GL10'] and parameter[2][@type='com.baidu.mapapi.map.MapStatus']]"
[Obsolete (@"deprecated")]
			[Register ("onMapDrawFrame", "(Ljavax/microedition/khronos/opengles/GL10;Lcom/baidu/mapapi/map/MapStatus;)V", "GetOnMapDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Lcom_baidu_mapapi_map_MapStatus_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapDrawFrameCallbackInvoker, XamarinBaiDuMapSDKBinding")]
			void OnMapDrawFrame (global::Javax.Microedition.Khronos.Opengles.IGL10 p0, global::Com.Baidu.Mapapi.Map.MapStatus p1);

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$OnMapDrawFrameCallback", DoNotGenerateAcw=true)]
		internal class IOnMapDrawFrameCallbackInvoker : global::Java.Lang.Object, IOnMapDrawFrameCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/mapapi/map/BaiduMap$OnMapDrawFrameCallback");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnMapDrawFrameCallbackInvoker); }
			}

			IntPtr class_ref;

			public static IOnMapDrawFrameCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapDrawFrameCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.OnMapDrawFrameCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapDrawFrameCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMapDrawFrame_Lcom_baidu_mapapi_map_MapStatus_;
#pragma warning disable 0169
			static Delegate GetOnMapDrawFrame_Lcom_baidu_mapapi_map_MapStatus_Handler ()
			{
				if (cb_onMapDrawFrame_Lcom_baidu_mapapi_map_MapStatus_ == null)
					cb_onMapDrawFrame_Lcom_baidu_mapapi_map_MapStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapDrawFrame_Lcom_baidu_mapapi_map_MapStatus_);
				return cb_onMapDrawFrame_Lcom_baidu_mapapi_map_MapStatus_;
			}

			static void n_OnMapDrawFrame_Lcom_baidu_mapapi_map_MapStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDrawFrameCallback __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDrawFrameCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Map.MapStatus p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMapDrawFrame (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMapDrawFrame_Lcom_baidu_mapapi_map_MapStatus_;
			public unsafe void OnMapDrawFrame (global::Com.Baidu.Mapapi.Map.MapStatus p0)
			{
				if (id_onMapDrawFrame_Lcom_baidu_mapapi_map_MapStatus_ == IntPtr.Zero)
					id_onMapDrawFrame_Lcom_baidu_mapapi_map_MapStatus_ = JNIEnv.GetMethodID (class_ref, "onMapDrawFrame", "(Lcom/baidu/mapapi/map/MapStatus;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapDrawFrame_Lcom_baidu_mapapi_map_MapStatus_, __args);
			}

			static Delegate cb_onMapDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Lcom_baidu_mapapi_map_MapStatus_;
#pragma warning disable 0169
			static Delegate GetOnMapDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Lcom_baidu_mapapi_map_MapStatus_Handler ()
			{
				if (cb_onMapDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Lcom_baidu_mapapi_map_MapStatus_ == null)
					cb_onMapDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Lcom_baidu_mapapi_map_MapStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnMapDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Lcom_baidu_mapapi_map_MapStatus_);
				return cb_onMapDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Lcom_baidu_mapapi_map_MapStatus_;
			}

			static void n_OnMapDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Lcom_baidu_mapapi_map_MapStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDrawFrameCallback __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDrawFrameCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Javax.Microedition.Khronos.Opengles.IGL10 p0 = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Map.MapStatus p1 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatus> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnMapDrawFrame (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onMapDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Lcom_baidu_mapapi_map_MapStatus_;
			public unsafe void OnMapDrawFrame (global::Javax.Microedition.Khronos.Opengles.IGL10 p0, global::Com.Baidu.Mapapi.Map.MapStatus p1)
			{
				if (id_onMapDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Lcom_baidu_mapapi_map_MapStatus_ == IntPtr.Zero)
					id_onMapDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Lcom_baidu_mapapi_map_MapStatus_ = JNIEnv.GetMethodID (class_ref, "onMapDrawFrame", "(Ljavax/microedition/khronos/opengles/GL10;Lcom/baidu/mapapi/map/MapStatus;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Lcom_baidu_mapapi_map_MapStatus_, __args);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapLoadedCallback']"
		[Register ("com/baidu/mapapi/map/BaiduMap$OnMapLoadedCallback", "", "Com.Baidu.Mapapi.Map.BaiduMap/IOnMapLoadedCallbackInvoker")]
		public partial interface IOnMapLoadedCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapLoadedCallback']/method[@name='onMapLoaded' and count(parameter)=0]"
			[Register ("onMapLoaded", "()V", "GetOnMapLoadedHandler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapLoadedCallbackInvoker, XamarinBaiDuMapSDKBinding")]
			void OnMapLoaded ();

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$OnMapLoadedCallback", DoNotGenerateAcw=true)]
		internal class IOnMapLoadedCallbackInvoker : global::Java.Lang.Object, IOnMapLoadedCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/mapapi/map/BaiduMap$OnMapLoadedCallback");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnMapLoadedCallbackInvoker); }
			}

			IntPtr class_ref;

			public static IOnMapLoadedCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapLoadedCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.OnMapLoadedCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapLoadedCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMapLoaded;
#pragma warning disable 0169
			static Delegate GetOnMapLoadedHandler ()
			{
				if (cb_onMapLoaded == null)
					cb_onMapLoaded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMapLoaded);
				return cb_onMapLoaded;
			}

			static void n_OnMapLoaded (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLoadedCallback __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLoadedCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnMapLoaded ();
			}
#pragma warning restore 0169

			IntPtr id_onMapLoaded;
			public unsafe void OnMapLoaded ()
			{
				if (id_onMapLoaded == IntPtr.Zero)
					id_onMapLoaded = JNIEnv.GetMethodID (class_ref, "onMapLoaded", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapLoaded);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapLongClickListener']"
		[Register ("com/baidu/mapapi/map/BaiduMap$OnMapLongClickListener", "", "Com.Baidu.Mapapi.Map.BaiduMap/IOnMapLongClickListenerInvoker")]
		public partial interface IOnMapLongClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapLongClickListener']/method[@name='onMapLongClick' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
			[Register ("onMapLongClick", "(Lcom/baidu/mapapi/model/LatLng;)V", "GetOnMapLongClick_Lcom_baidu_mapapi_model_LatLng_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapLongClickListenerInvoker, XamarinBaiDuMapSDKBinding")]
			void OnMapLongClick (global::Com.Baidu.Mapapi.Model.LatLng p0);

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$OnMapLongClickListener", DoNotGenerateAcw=true)]
		internal class IOnMapLongClickListenerInvoker : global::Java.Lang.Object, IOnMapLongClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/mapapi/map/BaiduMap$OnMapLongClickListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnMapLongClickListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnMapLongClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapLongClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.OnMapLongClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapLongClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMapLongClick_Lcom_baidu_mapapi_model_LatLng_;
#pragma warning disable 0169
			static Delegate GetOnMapLongClick_Lcom_baidu_mapapi_model_LatLng_Handler ()
			{
				if (cb_onMapLongClick_Lcom_baidu_mapapi_model_LatLng_ == null)
					cb_onMapLongClick_Lcom_baidu_mapapi_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapLongClick_Lcom_baidu_mapapi_model_LatLng_);
				return cb_onMapLongClick_Lcom_baidu_mapapi_model_LatLng_;
			}

			static void n_OnMapLongClick_Lcom_baidu_mapapi_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLongClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLongClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMapLongClick (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMapLongClick_Lcom_baidu_mapapi_model_LatLng_;
			public unsafe void OnMapLongClick (global::Com.Baidu.Mapapi.Model.LatLng p0)
			{
				if (id_onMapLongClick_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
					id_onMapLongClick_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "onMapLongClick", "(Lcom/baidu/mapapi/model/LatLng;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapLongClick_Lcom_baidu_mapapi_model_LatLng_, __args);
			}

		}

		public partial class MapLongClickEventArgs : global::System.EventArgs {

			public MapLongClickEventArgs (global::Com.Baidu.Mapapi.Model.LatLng p0)
			{
				this.p0 = p0;
			}

			global::Com.Baidu.Mapapi.Model.LatLng p0;
			public global::Com.Baidu.Mapapi.Model.LatLng P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/baidu/mapapi/map/BaiduMap_OnMapLongClickListenerImplementor")]
		internal sealed partial class IOnMapLongClickListenerImplementor : global::Java.Lang.Object, IOnMapLongClickListener {

			object sender;

			public IOnMapLongClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/map/BaiduMap_OnMapLongClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MapLongClickEventArgs> Handler;
#pragma warning restore 0649

			public void OnMapLongClick (global::Com.Baidu.Mapapi.Model.LatLng p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new MapLongClickEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMapLongClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapRenderCallback']"
		[Register ("com/baidu/mapapi/map/BaiduMap$OnMapRenderCallback", "", "Com.Baidu.Mapapi.Map.BaiduMap/IOnMapRenderCallbackInvoker")]
		public partial interface IOnMapRenderCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapRenderCallback']/method[@name='onMapRenderFinished' and count(parameter)=0]"
			[Register ("onMapRenderFinished", "()V", "GetOnMapRenderFinishedHandler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapRenderCallbackInvoker, XamarinBaiDuMapSDKBinding")]
			void OnMapRenderFinished ();

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$OnMapRenderCallback", DoNotGenerateAcw=true)]
		internal class IOnMapRenderCallbackInvoker : global::Java.Lang.Object, IOnMapRenderCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/mapapi/map/BaiduMap$OnMapRenderCallback");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnMapRenderCallbackInvoker); }
			}

			IntPtr class_ref;

			public static IOnMapRenderCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapRenderCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.OnMapRenderCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapRenderCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMapRenderFinished;
#pragma warning disable 0169
			static Delegate GetOnMapRenderFinishedHandler ()
			{
				if (cb_onMapRenderFinished == null)
					cb_onMapRenderFinished = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMapRenderFinished);
				return cb_onMapRenderFinished;
			}

			static void n_OnMapRenderFinished (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapRenderCallback __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapRenderCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnMapRenderFinished ();
			}
#pragma warning restore 0169

			IntPtr id_onMapRenderFinished;
			public unsafe void OnMapRenderFinished ()
			{
				if (id_onMapRenderFinished == IntPtr.Zero)
					id_onMapRenderFinished = JNIEnv.GetMethodID (class_ref, "onMapRenderFinished", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapRenderFinished);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapStatusChangeListener']"
		[Register ("com/baidu/mapapi/map/BaiduMap$OnMapStatusChangeListener", "", "Com.Baidu.Mapapi.Map.BaiduMap/IOnMapStatusChangeListenerInvoker")]
		public partial interface IOnMapStatusChangeListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapStatusChangeListener']/method[@name='onMapStatusChange' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MapStatus']]"
			[Register ("onMapStatusChange", "(Lcom/baidu/mapapi/map/MapStatus;)V", "GetOnMapStatusChange_Lcom_baidu_mapapi_map_MapStatus_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapStatusChangeListenerInvoker, XamarinBaiDuMapSDKBinding")]
			void OnMapStatusChange (global::Com.Baidu.Mapapi.Map.MapStatus p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapStatusChangeListener']/method[@name='onMapStatusChangeFinish' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MapStatus']]"
			[Register ("onMapStatusChangeFinish", "(Lcom/baidu/mapapi/map/MapStatus;)V", "GetOnMapStatusChangeFinish_Lcom_baidu_mapapi_map_MapStatus_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapStatusChangeListenerInvoker, XamarinBaiDuMapSDKBinding")]
			void OnMapStatusChangeFinish (global::Com.Baidu.Mapapi.Map.MapStatus p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapStatusChangeListener']/method[@name='onMapStatusChangeStart' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MapStatus']]"
			[Register ("onMapStatusChangeStart", "(Lcom/baidu/mapapi/map/MapStatus;)V", "GetOnMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapStatusChangeListenerInvoker, XamarinBaiDuMapSDKBinding")]
			void OnMapStatusChangeStart (global::Com.Baidu.Mapapi.Map.MapStatus p0);

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$OnMapStatusChangeListener", DoNotGenerateAcw=true)]
		internal class IOnMapStatusChangeListenerInvoker : global::Java.Lang.Object, IOnMapStatusChangeListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/mapapi/map/BaiduMap$OnMapStatusChangeListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnMapStatusChangeListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnMapStatusChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapStatusChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.OnMapStatusChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapStatusChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMapStatusChange_Lcom_baidu_mapapi_map_MapStatus_;
#pragma warning disable 0169
			static Delegate GetOnMapStatusChange_Lcom_baidu_mapapi_map_MapStatus_Handler ()
			{
				if (cb_onMapStatusChange_Lcom_baidu_mapapi_map_MapStatus_ == null)
					cb_onMapStatusChange_Lcom_baidu_mapapi_map_MapStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapStatusChange_Lcom_baidu_mapapi_map_MapStatus_);
				return cb_onMapStatusChange_Lcom_baidu_mapapi_map_MapStatus_;
			}

			static void n_OnMapStatusChange_Lcom_baidu_mapapi_map_MapStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Map.MapStatus p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMapStatusChange (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMapStatusChange_Lcom_baidu_mapapi_map_MapStatus_;
			public unsafe void OnMapStatusChange (global::Com.Baidu.Mapapi.Map.MapStatus p0)
			{
				if (id_onMapStatusChange_Lcom_baidu_mapapi_map_MapStatus_ == IntPtr.Zero)
					id_onMapStatusChange_Lcom_baidu_mapapi_map_MapStatus_ = JNIEnv.GetMethodID (class_ref, "onMapStatusChange", "(Lcom/baidu/mapapi/map/MapStatus;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapStatusChange_Lcom_baidu_mapapi_map_MapStatus_, __args);
			}

			static Delegate cb_onMapStatusChangeFinish_Lcom_baidu_mapapi_map_MapStatus_;
#pragma warning disable 0169
			static Delegate GetOnMapStatusChangeFinish_Lcom_baidu_mapapi_map_MapStatus_Handler ()
			{
				if (cb_onMapStatusChangeFinish_Lcom_baidu_mapapi_map_MapStatus_ == null)
					cb_onMapStatusChangeFinish_Lcom_baidu_mapapi_map_MapStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapStatusChangeFinish_Lcom_baidu_mapapi_map_MapStatus_);
				return cb_onMapStatusChangeFinish_Lcom_baidu_mapapi_map_MapStatus_;
			}

			static void n_OnMapStatusChangeFinish_Lcom_baidu_mapapi_map_MapStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Map.MapStatus p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMapStatusChangeFinish (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMapStatusChangeFinish_Lcom_baidu_mapapi_map_MapStatus_;
			public unsafe void OnMapStatusChangeFinish (global::Com.Baidu.Mapapi.Map.MapStatus p0)
			{
				if (id_onMapStatusChangeFinish_Lcom_baidu_mapapi_map_MapStatus_ == IntPtr.Zero)
					id_onMapStatusChangeFinish_Lcom_baidu_mapapi_map_MapStatus_ = JNIEnv.GetMethodID (class_ref, "onMapStatusChangeFinish", "(Lcom/baidu/mapapi/map/MapStatus;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapStatusChangeFinish_Lcom_baidu_mapapi_map_MapStatus_, __args);
			}

			static Delegate cb_onMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_;
#pragma warning disable 0169
			static Delegate GetOnMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_Handler ()
			{
				if (cb_onMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_ == null)
					cb_onMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_);
				return cb_onMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_;
			}

			static void n_OnMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Map.MapStatus p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMapStatusChangeStart (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_;
			public unsafe void OnMapStatusChangeStart (global::Com.Baidu.Mapapi.Map.MapStatus p0)
			{
				if (id_onMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_ == IntPtr.Zero)
					id_onMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_ = JNIEnv.GetMethodID (class_ref, "onMapStatusChangeStart", "(Lcom/baidu/mapapi/map/MapStatus;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_, __args);
			}

		}

		public partial class MapStatusChangeEventArgs : global::System.EventArgs {

			public MapStatusChangeEventArgs (global::Com.Baidu.Mapapi.Map.MapStatus p0)
			{
				this.p0 = p0;
			}

			global::Com.Baidu.Mapapi.Map.MapStatus p0;
			public global::Com.Baidu.Mapapi.Map.MapStatus P0 {
				get { return p0; }
			}
		}

		public partial class MapStatusChangeFinishEventArgs : global::System.EventArgs {

			public MapStatusChangeFinishEventArgs (global::Com.Baidu.Mapapi.Map.MapStatus p0)
			{
				this.p0 = p0;
			}

			global::Com.Baidu.Mapapi.Map.MapStatus p0;
			public global::Com.Baidu.Mapapi.Map.MapStatus P0 {
				get { return p0; }
			}
		}

		public partial class MapStatusChangeStartEventArgs : global::System.EventArgs {

			public MapStatusChangeStartEventArgs (global::Com.Baidu.Mapapi.Map.MapStatus p0)
			{
				this.p0 = p0;
			}

			global::Com.Baidu.Mapapi.Map.MapStatus p0;
			public global::Com.Baidu.Mapapi.Map.MapStatus P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/baidu/mapapi/map/BaiduMap_OnMapStatusChangeListenerImplementor")]
		internal sealed partial class IOnMapStatusChangeListenerImplementor : global::Java.Lang.Object, IOnMapStatusChangeListener {

			object sender;

			public IOnMapStatusChangeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/map/BaiduMap_OnMapStatusChangeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MapStatusChangeEventArgs> OnMapStatusChangeHandler;
#pragma warning restore 0649

			public void OnMapStatusChange (global::Com.Baidu.Mapapi.Map.MapStatus p0)
			{
				var __h = OnMapStatusChangeHandler;
				if (__h != null)
					__h (sender, new MapStatusChangeEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<MapStatusChangeFinishEventArgs> OnMapStatusChangeFinishHandler;
#pragma warning restore 0649

			public void OnMapStatusChangeFinish (global::Com.Baidu.Mapapi.Map.MapStatus p0)
			{
				var __h = OnMapStatusChangeFinishHandler;
				if (__h != null)
					__h (sender, new MapStatusChangeFinishEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<MapStatusChangeStartEventArgs> OnMapStatusChangeStartHandler;
#pragma warning restore 0649

			public void OnMapStatusChangeStart (global::Com.Baidu.Mapapi.Map.MapStatus p0)
			{
				var __h = OnMapStatusChangeStartHandler;
				if (__h != null)
					__h (sender, new MapStatusChangeStartEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMapStatusChangeListenerImplementor value)
			{
				return value.OnMapStatusChangeHandler == null && value.OnMapStatusChangeFinishHandler == null && value.OnMapStatusChangeStartHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapTouchListener']"
		[Register ("com/baidu/mapapi/map/BaiduMap$OnMapTouchListener", "", "Com.Baidu.Mapapi.Map.BaiduMap/IOnMapTouchListenerInvoker")]
		public partial interface IOnMapTouchListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapTouchListener']/method[@name='onTouch' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
			[Register ("onTouch", "(Landroid/view/MotionEvent;)V", "GetOnTouch_Landroid_view_MotionEvent_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapTouchListenerInvoker, XamarinBaiDuMapSDKBinding")]
			void OnTouch (global::Android.Views.MotionEvent p0);

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$OnMapTouchListener", DoNotGenerateAcw=true)]
		internal class IOnMapTouchListenerInvoker : global::Java.Lang.Object, IOnMapTouchListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/mapapi/map/BaiduMap$OnMapTouchListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnMapTouchListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnMapTouchListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapTouchListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.OnMapTouchListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapTouchListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onTouch_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnTouch_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onTouch_Landroid_view_MotionEvent_ == null)
					cb_onTouch_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnTouch_Landroid_view_MotionEvent_);
				return cb_onTouch_Landroid_view_MotionEvent_;
			}

			static void n_OnTouch_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnTouch (p0);
			}
#pragma warning restore 0169

			IntPtr id_onTouch_Landroid_view_MotionEvent_;
			public unsafe void OnTouch (global::Android.Views.MotionEvent p0)
			{
				if (id_onTouch_Landroid_view_MotionEvent_ == IntPtr.Zero)
					id_onTouch_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouch", "(Landroid/view/MotionEvent;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTouch_Landroid_view_MotionEvent_, __args);
			}

		}

		public partial class MapTouchEventArgs : global::System.EventArgs {

			public MapTouchEventArgs (global::Android.Views.MotionEvent p0)
			{
				this.p0 = p0;
			}

			global::Android.Views.MotionEvent p0;
			public global::Android.Views.MotionEvent P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/baidu/mapapi/map/BaiduMap_OnMapTouchListenerImplementor")]
		internal sealed partial class IOnMapTouchListenerImplementor : global::Java.Lang.Object, IOnMapTouchListener {

			object sender;

			public IOnMapTouchListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/map/BaiduMap_OnMapTouchListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MapTouchEventArgs> Handler;
#pragma warning restore 0649

			public void OnTouch (global::Android.Views.MotionEvent p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new MapTouchEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMapTouchListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMarkerClickListener']"
		[Register ("com/baidu/mapapi/map/BaiduMap$OnMarkerClickListener", "", "Com.Baidu.Mapapi.Map.BaiduMap/IOnMarkerClickListenerInvoker")]
		public partial interface IOnMarkerClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMarkerClickListener']/method[@name='onMarkerClick' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.Marker']]"
			[Register ("onMarkerClick", "(Lcom/baidu/mapapi/map/Marker;)Z", "GetOnMarkerClick_Lcom_baidu_mapapi_map_Marker_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMarkerClickListenerInvoker, XamarinBaiDuMapSDKBinding")]
			bool OnMarkerClick (global::Com.Baidu.Mapapi.Map.Marker p0);

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$OnMarkerClickListener", DoNotGenerateAcw=true)]
		internal class IOnMarkerClickListenerInvoker : global::Java.Lang.Object, IOnMarkerClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/mapapi/map/BaiduMap$OnMarkerClickListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnMarkerClickListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnMarkerClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMarkerClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.OnMarkerClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMarkerClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMarkerClick_Lcom_baidu_mapapi_map_Marker_;
#pragma warning disable 0169
			static Delegate GetOnMarkerClick_Lcom_baidu_mapapi_map_Marker_Handler ()
			{
				if (cb_onMarkerClick_Lcom_baidu_mapapi_map_Marker_ == null)
					cb_onMarkerClick_Lcom_baidu_mapapi_map_Marker_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnMarkerClick_Lcom_baidu_mapapi_map_Marker_);
				return cb_onMarkerClick_Lcom_baidu_mapapi_map_Marker_;
			}

			static bool n_OnMarkerClick_Lcom_baidu_mapapi_map_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Map.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnMarkerClick (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onMarkerClick_Lcom_baidu_mapapi_map_Marker_;
			public unsafe bool OnMarkerClick (global::Com.Baidu.Mapapi.Map.Marker p0)
			{
				if (id_onMarkerClick_Lcom_baidu_mapapi_map_Marker_ == IntPtr.Zero)
					id_onMarkerClick_Lcom_baidu_mapapi_map_Marker_ = JNIEnv.GetMethodID (class_ref, "onMarkerClick", "(Lcom/baidu/mapapi/map/Marker;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onMarkerClick_Lcom_baidu_mapapi_map_Marker_, __args);
				return __ret;
			}

		}

		public partial class MarkerClickEventArgs : global::System.EventArgs {

			public MarkerClickEventArgs (bool handled, global::Com.Baidu.Mapapi.Map.Marker p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Com.Baidu.Mapapi.Map.Marker p0;
			public global::Com.Baidu.Mapapi.Map.Marker P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/baidu/mapapi/map/BaiduMap_OnMarkerClickListenerImplementor")]
		internal sealed partial class IOnMarkerClickListenerImplementor : global::Java.Lang.Object, IOnMarkerClickListener {

			object sender;

			public IOnMarkerClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/map/BaiduMap_OnMarkerClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MarkerClickEventArgs> Handler;
#pragma warning restore 0649

			public bool OnMarkerClick (global::Com.Baidu.Mapapi.Map.Marker p0)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new MarkerClickEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnMarkerClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMarkerDragListener']"
		[Register ("com/baidu/mapapi/map/BaiduMap$OnMarkerDragListener", "", "Com.Baidu.Mapapi.Map.BaiduMap/IOnMarkerDragListenerInvoker")]
		public partial interface IOnMarkerDragListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMarkerDragListener']/method[@name='onMarkerDrag' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.Marker']]"
			[Register ("onMarkerDrag", "(Lcom/baidu/mapapi/map/Marker;)V", "GetOnMarkerDrag_Lcom_baidu_mapapi_map_Marker_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMarkerDragListenerInvoker, XamarinBaiDuMapSDKBinding")]
			void OnMarkerDrag (global::Com.Baidu.Mapapi.Map.Marker p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMarkerDragListener']/method[@name='onMarkerDragEnd' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.Marker']]"
			[Register ("onMarkerDragEnd", "(Lcom/baidu/mapapi/map/Marker;)V", "GetOnMarkerDragEnd_Lcom_baidu_mapapi_map_Marker_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMarkerDragListenerInvoker, XamarinBaiDuMapSDKBinding")]
			void OnMarkerDragEnd (global::Com.Baidu.Mapapi.Map.Marker p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMarkerDragListener']/method[@name='onMarkerDragStart' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.Marker']]"
			[Register ("onMarkerDragStart", "(Lcom/baidu/mapapi/map/Marker;)V", "GetOnMarkerDragStart_Lcom_baidu_mapapi_map_Marker_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMarkerDragListenerInvoker, XamarinBaiDuMapSDKBinding")]
			void OnMarkerDragStart (global::Com.Baidu.Mapapi.Map.Marker p0);

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$OnMarkerDragListener", DoNotGenerateAcw=true)]
		internal class IOnMarkerDragListenerInvoker : global::Java.Lang.Object, IOnMarkerDragListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/mapapi/map/BaiduMap$OnMarkerDragListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnMarkerDragListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnMarkerDragListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMarkerDragListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.OnMarkerDragListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMarkerDragListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMarkerDrag_Lcom_baidu_mapapi_map_Marker_;
#pragma warning disable 0169
			static Delegate GetOnMarkerDrag_Lcom_baidu_mapapi_map_Marker_Handler ()
			{
				if (cb_onMarkerDrag_Lcom_baidu_mapapi_map_Marker_ == null)
					cb_onMarkerDrag_Lcom_baidu_mapapi_map_Marker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMarkerDrag_Lcom_baidu_mapapi_map_Marker_);
				return cb_onMarkerDrag_Lcom_baidu_mapapi_map_Marker_;
			}

			static void n_OnMarkerDrag_Lcom_baidu_mapapi_map_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Map.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMarkerDrag (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMarkerDrag_Lcom_baidu_mapapi_map_Marker_;
			public unsafe void OnMarkerDrag (global::Com.Baidu.Mapapi.Map.Marker p0)
			{
				if (id_onMarkerDrag_Lcom_baidu_mapapi_map_Marker_ == IntPtr.Zero)
					id_onMarkerDrag_Lcom_baidu_mapapi_map_Marker_ = JNIEnv.GetMethodID (class_ref, "onMarkerDrag", "(Lcom/baidu/mapapi/map/Marker;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMarkerDrag_Lcom_baidu_mapapi_map_Marker_, __args);
			}

			static Delegate cb_onMarkerDragEnd_Lcom_baidu_mapapi_map_Marker_;
#pragma warning disable 0169
			static Delegate GetOnMarkerDragEnd_Lcom_baidu_mapapi_map_Marker_Handler ()
			{
				if (cb_onMarkerDragEnd_Lcom_baidu_mapapi_map_Marker_ == null)
					cb_onMarkerDragEnd_Lcom_baidu_mapapi_map_Marker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMarkerDragEnd_Lcom_baidu_mapapi_map_Marker_);
				return cb_onMarkerDragEnd_Lcom_baidu_mapapi_map_Marker_;
			}

			static void n_OnMarkerDragEnd_Lcom_baidu_mapapi_map_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Map.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMarkerDragEnd (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMarkerDragEnd_Lcom_baidu_mapapi_map_Marker_;
			public unsafe void OnMarkerDragEnd (global::Com.Baidu.Mapapi.Map.Marker p0)
			{
				if (id_onMarkerDragEnd_Lcom_baidu_mapapi_map_Marker_ == IntPtr.Zero)
					id_onMarkerDragEnd_Lcom_baidu_mapapi_map_Marker_ = JNIEnv.GetMethodID (class_ref, "onMarkerDragEnd", "(Lcom/baidu/mapapi/map/Marker;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMarkerDragEnd_Lcom_baidu_mapapi_map_Marker_, __args);
			}

			static Delegate cb_onMarkerDragStart_Lcom_baidu_mapapi_map_Marker_;
#pragma warning disable 0169
			static Delegate GetOnMarkerDragStart_Lcom_baidu_mapapi_map_Marker_Handler ()
			{
				if (cb_onMarkerDragStart_Lcom_baidu_mapapi_map_Marker_ == null)
					cb_onMarkerDragStart_Lcom_baidu_mapapi_map_Marker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMarkerDragStart_Lcom_baidu_mapapi_map_Marker_);
				return cb_onMarkerDragStart_Lcom_baidu_mapapi_map_Marker_;
			}

			static void n_OnMarkerDragStart_Lcom_baidu_mapapi_map_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Map.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMarkerDragStart (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMarkerDragStart_Lcom_baidu_mapapi_map_Marker_;
			public unsafe void OnMarkerDragStart (global::Com.Baidu.Mapapi.Map.Marker p0)
			{
				if (id_onMarkerDragStart_Lcom_baidu_mapapi_map_Marker_ == IntPtr.Zero)
					id_onMarkerDragStart_Lcom_baidu_mapapi_map_Marker_ = JNIEnv.GetMethodID (class_ref, "onMarkerDragStart", "(Lcom/baidu/mapapi/map/Marker;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMarkerDragStart_Lcom_baidu_mapapi_map_Marker_, __args);
			}

		}

		public partial class MarkerDragEventArgs : global::System.EventArgs {

			public MarkerDragEventArgs (global::Com.Baidu.Mapapi.Map.Marker p0)
			{
				this.p0 = p0;
			}

			global::Com.Baidu.Mapapi.Map.Marker p0;
			public global::Com.Baidu.Mapapi.Map.Marker P0 {
				get { return p0; }
			}
		}

		public partial class MarkerDragEndEventArgs : global::System.EventArgs {

			public MarkerDragEndEventArgs (global::Com.Baidu.Mapapi.Map.Marker p0)
			{
				this.p0 = p0;
			}

			global::Com.Baidu.Mapapi.Map.Marker p0;
			public global::Com.Baidu.Mapapi.Map.Marker P0 {
				get { return p0; }
			}
		}

		public partial class MarkerDragStartEventArgs : global::System.EventArgs {

			public MarkerDragStartEventArgs (global::Com.Baidu.Mapapi.Map.Marker p0)
			{
				this.p0 = p0;
			}

			global::Com.Baidu.Mapapi.Map.Marker p0;
			public global::Com.Baidu.Mapapi.Map.Marker P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/baidu/mapapi/map/BaiduMap_OnMarkerDragListenerImplementor")]
		internal sealed partial class IOnMarkerDragListenerImplementor : global::Java.Lang.Object, IOnMarkerDragListener {

			object sender;

			public IOnMarkerDragListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/map/BaiduMap_OnMarkerDragListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MarkerDragEventArgs> OnMarkerDragHandler;
#pragma warning restore 0649

			public void OnMarkerDrag (global::Com.Baidu.Mapapi.Map.Marker p0)
			{
				var __h = OnMarkerDragHandler;
				if (__h != null)
					__h (sender, new MarkerDragEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<MarkerDragEndEventArgs> OnMarkerDragEndHandler;
#pragma warning restore 0649

			public void OnMarkerDragEnd (global::Com.Baidu.Mapapi.Map.Marker p0)
			{
				var __h = OnMarkerDragEndHandler;
				if (__h != null)
					__h (sender, new MarkerDragEndEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<MarkerDragStartEventArgs> OnMarkerDragStartHandler;
#pragma warning restore 0649

			public void OnMarkerDragStart (global::Com.Baidu.Mapapi.Map.Marker p0)
			{
				var __h = OnMarkerDragStartHandler;
				if (__h != null)
					__h (sender, new MarkerDragStartEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMarkerDragListenerImplementor value)
			{
				return value.OnMarkerDragHandler == null && value.OnMarkerDragEndHandler == null && value.OnMarkerDragStartHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMyLocationClickListener']"
		[Register ("com/baidu/mapapi/map/BaiduMap$OnMyLocationClickListener", "", "Com.Baidu.Mapapi.Map.BaiduMap/IOnMyLocationClickListenerInvoker")]
		public partial interface IOnMyLocationClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMyLocationClickListener']/method[@name='onMyLocationClick' and count(parameter)=0]"
			[Register ("onMyLocationClick", "()Z", "GetOnMyLocationClickHandler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMyLocationClickListenerInvoker, XamarinBaiDuMapSDKBinding")]
			bool OnMyLocationClick ();

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$OnMyLocationClickListener", DoNotGenerateAcw=true)]
		internal class IOnMyLocationClickListenerInvoker : global::Java.Lang.Object, IOnMyLocationClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/mapapi/map/BaiduMap$OnMyLocationClickListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnMyLocationClickListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnMyLocationClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMyLocationClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.OnMyLocationClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMyLocationClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMyLocationClick;
#pragma warning disable 0169
			static Delegate GetOnMyLocationClickHandler ()
			{
				if (cb_onMyLocationClick == null)
					cb_onMyLocationClick = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_OnMyLocationClick);
				return cb_onMyLocationClick;
			}

			static bool n_OnMyLocationClick (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMyLocationClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMyLocationClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.OnMyLocationClick ();
			}
#pragma warning restore 0169

			IntPtr id_onMyLocationClick;
			public unsafe bool OnMyLocationClick ()
			{
				if (id_onMyLocationClick == IntPtr.Zero)
					id_onMyLocationClick = JNIEnv.GetMethodID (class_ref, "onMyLocationClick", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onMyLocationClick);
			}

		}

		public partial class MyLocationClickEventArgs : global::System.EventArgs {

			public MyLocationClickEventArgs (bool handled)
			{
				this.handled = handled;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/baidu/mapapi/map/BaiduMap_OnMyLocationClickListenerImplementor")]
		internal sealed partial class IOnMyLocationClickListenerImplementor : global::Java.Lang.Object, IOnMyLocationClickListener {

			object sender;

			public IOnMyLocationClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/map/BaiduMap_OnMyLocationClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MyLocationClickEventArgs> Handler;
#pragma warning restore 0649

			public bool OnMyLocationClick ()
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new MyLocationClickEventArgs (true);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnMyLocationClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnPolylineClickListener']"
		[Register ("com/baidu/mapapi/map/BaiduMap$OnPolylineClickListener", "", "Com.Baidu.Mapapi.Map.BaiduMap/IOnPolylineClickListenerInvoker")]
		public partial interface IOnPolylineClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnPolylineClickListener']/method[@name='onPolylineClick' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.Polyline']]"
			[Register ("onPolylineClick", "(Lcom/baidu/mapapi/map/Polyline;)Z", "GetOnPolylineClick_Lcom_baidu_mapapi_map_Polyline_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnPolylineClickListenerInvoker, XamarinBaiDuMapSDKBinding")]
			bool OnPolylineClick (global::Com.Baidu.Mapapi.Map.Polyline p0);

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$OnPolylineClickListener", DoNotGenerateAcw=true)]
		internal class IOnPolylineClickListenerInvoker : global::Java.Lang.Object, IOnPolylineClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/mapapi/map/BaiduMap$OnPolylineClickListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnPolylineClickListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnPolylineClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnPolylineClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.OnPolylineClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnPolylineClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_;
#pragma warning disable 0169
			static Delegate GetOnPolylineClick_Lcom_baidu_mapapi_map_Polyline_Handler ()
			{
				if (cb_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_ == null)
					cb_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnPolylineClick_Lcom_baidu_mapapi_map_Polyline_);
				return cb_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_;
			}

			static bool n_OnPolylineClick_Lcom_baidu_mapapi_map_Polyline_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnPolylineClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnPolylineClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Map.Polyline p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Polyline> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnPolylineClick (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_;
			public unsafe bool OnPolylineClick (global::Com.Baidu.Mapapi.Map.Polyline p0)
			{
				if (id_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_ == IntPtr.Zero)
					id_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_ = JNIEnv.GetMethodID (class_ref, "onPolylineClick", "(Lcom/baidu/mapapi/map/Polyline;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_, __args);
				return __ret;
			}

		}

		public partial class PolylineClickEventArgs : global::System.EventArgs {

			public PolylineClickEventArgs (bool handled, global::Com.Baidu.Mapapi.Map.Polyline p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Com.Baidu.Mapapi.Map.Polyline p0;
			public global::Com.Baidu.Mapapi.Map.Polyline P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/baidu/mapapi/map/BaiduMap_OnPolylineClickListenerImplementor")]
		internal sealed partial class IOnPolylineClickListenerImplementor : global::Java.Lang.Object, IOnPolylineClickListener {

			object sender;

			public IOnPolylineClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/map/BaiduMap_OnPolylineClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<PolylineClickEventArgs> Handler;
#pragma warning restore 0649

			public bool OnPolylineClick (global::Com.Baidu.Mapapi.Map.Polyline p0)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new PolylineClickEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnPolylineClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.SnapshotReadyCallback']"
		[Register ("com/baidu/mapapi/map/BaiduMap$SnapshotReadyCallback", "", "Com.Baidu.Mapapi.Map.BaiduMap/ISnapshotReadyCallbackInvoker")]
		public partial interface ISnapshotReadyCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.SnapshotReadyCallback']/method[@name='onSnapshotReady' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("onSnapshotReady", "(Landroid/graphics/Bitmap;)V", "GetOnSnapshotReady_Landroid_graphics_Bitmap_Handler:Com.Baidu.Mapapi.Map.BaiduMap/ISnapshotReadyCallbackInvoker, XamarinBaiDuMapSDKBinding")]
			void OnSnapshotReady (global::Android.Graphics.Bitmap p0);

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$SnapshotReadyCallback", DoNotGenerateAcw=true)]
		internal class ISnapshotReadyCallbackInvoker : global::Java.Lang.Object, ISnapshotReadyCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/mapapi/map/BaiduMap$SnapshotReadyCallback");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ISnapshotReadyCallbackInvoker); }
			}

			IntPtr class_ref;

			public static ISnapshotReadyCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISnapshotReadyCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.SnapshotReadyCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISnapshotReadyCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onSnapshotReady_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetOnSnapshotReady_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_onSnapshotReady_Landroid_graphics_Bitmap_ == null)
					cb_onSnapshotReady_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSnapshotReady_Landroid_graphics_Bitmap_);
				return cb_onSnapshotReady_Landroid_graphics_Bitmap_;
			}

			static void n_OnSnapshotReady_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.ISnapshotReadyCallback __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.ISnapshotReadyCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSnapshotReady (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSnapshotReady_Landroid_graphics_Bitmap_;
			public unsafe void OnSnapshotReady (global::Android.Graphics.Bitmap p0)
			{
				if (id_onSnapshotReady_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_onSnapshotReady_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "onSnapshotReady", "(Landroid/graphics/Bitmap;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSnapshotReady_Landroid_graphics_Bitmap_, __args);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/BaiduMap", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaiduMap); }
		}

		protected BaiduMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isBaiduHeatMapEnabled;
		static IntPtr id_setBaiduHeatMapEnabled_Z;
		public unsafe bool BaiduHeatMapEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='isBaiduHeatMapEnabled' and count(parameter)=0]"
			[Register ("isBaiduHeatMapEnabled", "()Z", "GetIsBaiduHeatMapEnabledHandler")]
			get {
				if (id_isBaiduHeatMapEnabled == IntPtr.Zero)
					id_isBaiduHeatMapEnabled = JNIEnv.GetMethodID (class_ref, "isBaiduHeatMapEnabled", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBaiduHeatMapEnabled);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setBaiduHeatMapEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setBaiduHeatMapEnabled", "(Z)V", "GetSetBaiduHeatMapEnabled_ZHandler")]
			set {
				if (id_setBaiduHeatMapEnabled_Z == IntPtr.Zero)
					id_setBaiduHeatMapEnabled_Z = JNIEnv.GetMethodID (class_ref, "setBaiduHeatMapEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBaiduHeatMapEnabled_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_isBuildingsEnabled;
		static IntPtr id_setBuildingsEnabled_Z;
		public unsafe bool BuildingsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='isBuildingsEnabled' and count(parameter)=0]"
			[Register ("isBuildingsEnabled", "()Z", "GetIsBuildingsEnabledHandler")]
			get {
				if (id_isBuildingsEnabled == IntPtr.Zero)
					id_isBuildingsEnabled = JNIEnv.GetMethodID (class_ref, "isBuildingsEnabled", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBuildingsEnabled);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setBuildingsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setBuildingsEnabled", "(Z)V", "GetSetBuildingsEnabled_ZHandler")]
			set {
				if (id_setBuildingsEnabled_Z == IntPtr.Zero)
					id_setBuildingsEnabled_Z = JNIEnv.GetMethodID (class_ref, "setBuildingsEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBuildingsEnabled_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getCompassPosition;
		static IntPtr id_setCompassPosition_Landroid_graphics_Point_;
		public unsafe global::Android.Graphics.Point CompassPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getCompassPosition' and count(parameter)=0]"
			[Register ("getCompassPosition", "()Landroid/graphics/Point;", "GetGetCompassPositionHandler")]
			get {
				if (id_getCompassPosition == IntPtr.Zero)
					id_getCompassPosition = JNIEnv.GetMethodID (class_ref, "getCompassPosition", "()Landroid/graphics/Point;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCompassPosition), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setCompassPosition' and count(parameter)=1 and parameter[1][@type='android.graphics.Point']]"
			[Register ("setCompassPosition", "(Landroid/graphics/Point;)V", "GetSetCompassPosition_Landroid_graphics_Point_Handler")]
			set {
				if (id_setCompassPosition_Landroid_graphics_Point_ == IntPtr.Zero)
					id_setCompassPosition_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "setCompassPosition", "(Landroid/graphics/Point;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCompassPosition_Landroid_graphics_Point_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCompassPosition", "(Landroid/graphics/Point;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFocusedBaseIndoorMapInfo;
#pragma warning disable 0169
		static Delegate GetGetFocusedBaseIndoorMapInfoHandler ()
		{
			if (cb_getFocusedBaseIndoorMapInfo == null)
				cb_getFocusedBaseIndoorMapInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFocusedBaseIndoorMapInfo);
			return cb_getFocusedBaseIndoorMapInfo;
		}

		static IntPtr n_GetFocusedBaseIndoorMapInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FocusedBaseIndoorMapInfo);
		}
#pragma warning restore 0169

		static IntPtr id_getFocusedBaseIndoorMapInfo;
		public virtual unsafe global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo FocusedBaseIndoorMapInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getFocusedBaseIndoorMapInfo' and count(parameter)=0]"
			[Register ("getFocusedBaseIndoorMapInfo", "()Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo;", "GetGetFocusedBaseIndoorMapInfoHandler")]
			get {
				if (id_getFocusedBaseIndoorMapInfo == IntPtr.Zero)
					id_getFocusedBaseIndoorMapInfo = JNIEnv.GetMethodID (class_ref, "getFocusedBaseIndoorMapInfo", "()Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFocusedBaseIndoorMapInfo), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFocusedBaseIndoorMapInfo", "()Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isBaseIndoorMapMode;
#pragma warning disable 0169
		static Delegate GetIsBaseIndoorMapModeHandler ()
		{
			if (cb_isBaseIndoorMapMode == null)
				cb_isBaseIndoorMapMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBaseIndoorMapMode);
			return cb_isBaseIndoorMapMode;
		}

		static bool n_IsBaseIndoorMapMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBaseIndoorMapMode;
		}
#pragma warning restore 0169

		static IntPtr id_isBaseIndoorMapMode;
		public virtual unsafe bool IsBaseIndoorMapMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='isBaseIndoorMapMode' and count(parameter)=0]"
			[Register ("isBaseIndoorMapMode", "()Z", "GetIsBaseIndoorMapModeHandler")]
			get {
				if (id_isBaseIndoorMapMode == IntPtr.Zero)
					id_isBaseIndoorMapMode = JNIEnv.GetMethodID (class_ref, "isBaseIndoorMapMode", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBaseIndoorMapMode);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBaseIndoorMapMode", "()Z"));
				} finally {
				}
			}
		}

		static IntPtr id_isSupportBaiduHeatMap;
		public unsafe bool IsSupportBaiduHeatMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='isSupportBaiduHeatMap' and count(parameter)=0]"
			[Register ("isSupportBaiduHeatMap", "()Z", "GetIsSupportBaiduHeatMapHandler")]
			get {
				if (id_isSupportBaiduHeatMap == IntPtr.Zero)
					id_isSupportBaiduHeatMap = JNIEnv.GetMethodID (class_ref, "isSupportBaiduHeatMap", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSupportBaiduHeatMap);
				} finally {
				}
			}
		}

		static IntPtr id_getLocationConfigeration;
		public unsafe global::Com.Baidu.Mapapi.Map.MyLocationConfiguration LocationConfigeration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getLocationConfigeration' and count(parameter)=0]"
			[Register ("getLocationConfigeration", "()Lcom/baidu/mapapi/map/MyLocationConfiguration;", "GetGetLocationConfigerationHandler")]
			get {
				if (id_getLocationConfigeration == IntPtr.Zero)
					id_getLocationConfigeration = JNIEnv.GetMethodID (class_ref, "getLocationConfigeration", "()Lcom/baidu/mapapi/map/MyLocationConfiguration;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationConfiguration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocationConfigeration), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getLocationData;
		public unsafe global::Com.Baidu.Mapapi.Map.MyLocationData LocationData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getLocationData' and count(parameter)=0]"
			[Register ("getLocationData", "()Lcom/baidu/mapapi/map/MyLocationData;", "GetGetLocationDataHandler")]
			get {
				if (id_getLocationData == IntPtr.Zero)
					id_getLocationData = JNIEnv.GetMethodID (class_ref, "getLocationData", "()Lcom/baidu/mapapi/map/MyLocationData;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocationData), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMapStatus;
		public unsafe global::Com.Baidu.Mapapi.Map.MapStatus MapStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getMapStatus' and count(parameter)=0]"
			[Register ("getMapStatus", "()Lcom/baidu/mapapi/map/MapStatus;", "GetGetMapStatusHandler")]
			get {
				if (id_getMapStatus == IntPtr.Zero)
					id_getMapStatus = JNIEnv.GetMethodID (class_ref, "getMapStatus", "()Lcom/baidu/mapapi/map/MapStatus;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMapStatus), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMapStatusLimit;
		public unsafe global::Com.Baidu.Mapapi.Model.LatLngBounds MapStatusLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getMapStatusLimit' and count(parameter)=0]"
			[Register ("getMapStatusLimit", "()Lcom/baidu/mapapi/model/LatLngBounds;", "GetGetMapStatusLimitHandler")]
			get {
				if (id_getMapStatusLimit == IntPtr.Zero)
					id_getMapStatusLimit = JNIEnv.GetMethodID (class_ref, "getMapStatusLimit", "()Lcom/baidu/mapapi/model/LatLngBounds;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLngBounds> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMapStatusLimit), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMapType;
		static IntPtr id_setMapType_I;
		public unsafe int MapType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getMapType' and count(parameter)=0]"
			[Register ("getMapType", "()I", "GetGetMapTypeHandler")]
			get {
				if (id_getMapType == IntPtr.Zero)
					id_getMapType = JNIEnv.GetMethodID (class_ref, "getMapType", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMapType);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setMapType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMapType", "(I)V", "GetSetMapType_IHandler")]
			set {
				if (id_setMapType_I == IntPtr.Zero)
					id_setMapType_I = JNIEnv.GetMethodID (class_ref, "setMapType", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMapType_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getMaxZoomLevel;
		public unsafe float MaxZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getMaxZoomLevel' and count(parameter)=0]"
			[Register ("getMaxZoomLevel", "()F", "GetGetMaxZoomLevelHandler")]
			get {
				if (id_getMaxZoomLevel == IntPtr.Zero)
					id_getMaxZoomLevel = JNIEnv.GetMethodID (class_ref, "getMaxZoomLevel", "()F");
				try {
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getMaxZoomLevel);
				} finally {
				}
			}
		}

		static IntPtr id_getMinZoomLevel;
		public unsafe float MinZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getMinZoomLevel' and count(parameter)=0]"
			[Register ("getMinZoomLevel", "()F", "GetGetMinZoomLevelHandler")]
			get {
				if (id_getMinZoomLevel == IntPtr.Zero)
					id_getMinZoomLevel = JNIEnv.GetMethodID (class_ref, "getMinZoomLevel", "()F");
				try {
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getMinZoomLevel);
				} finally {
				}
			}
		}

		static IntPtr id_isMyLocationEnabled;
		static IntPtr id_setMyLocationEnabled_Z;
		public unsafe bool MyLocationEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='isMyLocationEnabled' and count(parameter)=0]"
			[Register ("isMyLocationEnabled", "()Z", "GetIsMyLocationEnabledHandler")]
			get {
				if (id_isMyLocationEnabled == IntPtr.Zero)
					id_isMyLocationEnabled = JNIEnv.GetMethodID (class_ref, "isMyLocationEnabled", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMyLocationEnabled);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setMyLocationEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMyLocationEnabled", "(Z)V", "GetSetMyLocationEnabled_ZHandler")]
			set {
				if (id_setMyLocationEnabled_Z == IntPtr.Zero)
					id_setMyLocationEnabled_Z = JNIEnv.GetMethodID (class_ref, "setMyLocationEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMyLocationEnabled_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getProjection;
		public unsafe global::Com.Baidu.Mapapi.Map.Projection Projection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getProjection' and count(parameter)=0]"
			[Register ("getProjection", "()Lcom/baidu/mapapi/map/Projection;", "GetGetProjectionHandler")]
			get {
				if (id_getProjection == IntPtr.Zero)
					id_getProjection = JNIEnv.GetMethodID (class_ref, "getProjection", "()Lcom/baidu/mapapi/map/Projection;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Projection> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProjection), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isTrafficEnabled;
		static IntPtr id_setTrafficEnabled_Z;
		public unsafe bool TrafficEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='isTrafficEnabled' and count(parameter)=0]"
			[Register ("isTrafficEnabled", "()Z", "GetIsTrafficEnabledHandler")]
			get {
				if (id_isTrafficEnabled == IntPtr.Zero)
					id_isTrafficEnabled = JNIEnv.GetMethodID (class_ref, "isTrafficEnabled", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTrafficEnabled);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setTrafficEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTrafficEnabled", "(Z)V", "GetSetTrafficEnabled_ZHandler")]
			set {
				if (id_setTrafficEnabled_Z == IntPtr.Zero)
					id_setTrafficEnabled_Z = JNIEnv.GetMethodID (class_ref, "setTrafficEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrafficEnabled_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getUiSettings;
		public unsafe global::Com.Baidu.Mapapi.Map.UiSettings UiSettings {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getUiSettings' and count(parameter)=0]"
			[Register ("getUiSettings", "()Lcom/baidu/mapapi/map/UiSettings;", "GetGetUiSettingsHandler")]
			get {
				if (id_getUiSettings == IntPtr.Zero)
					id_getUiSettings = JNIEnv.GetMethodID (class_ref, "getUiSettings", "()Lcom/baidu/mapapi/map/UiSettings;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.UiSettings> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUiSettings), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addHeatMap_Lcom_baidu_mapapi_map_HeatMap_;
#pragma warning disable 0169
		static Delegate GetAddHeatMap_Lcom_baidu_mapapi_map_HeatMap_Handler ()
		{
			if (cb_addHeatMap_Lcom_baidu_mapapi_map_HeatMap_ == null)
				cb_addHeatMap_Lcom_baidu_mapapi_map_HeatMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddHeatMap_Lcom_baidu_mapapi_map_HeatMap_);
			return cb_addHeatMap_Lcom_baidu_mapapi_map_HeatMap_;
		}

		static void n_AddHeatMap_Lcom_baidu_mapapi_map_HeatMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.HeatMap p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddHeatMap (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addHeatMap_Lcom_baidu_mapapi_map_HeatMap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='addHeatMap' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.HeatMap']]"
		[Register ("addHeatMap", "(Lcom/baidu/mapapi/map/HeatMap;)V", "GetAddHeatMap_Lcom_baidu_mapapi_map_HeatMap_Handler")]
		public virtual unsafe void AddHeatMap (global::Com.Baidu.Mapapi.Map.HeatMap p0)
		{
			if (id_addHeatMap_Lcom_baidu_mapapi_map_HeatMap_ == IntPtr.Zero)
				id_addHeatMap_Lcom_baidu_mapapi_map_HeatMap_ = JNIEnv.GetMethodID (class_ref, "addHeatMap", "(Lcom/baidu/mapapi/map/HeatMap;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addHeatMap_Lcom_baidu_mapapi_map_HeatMap_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addHeatMap", "(Lcom/baidu/mapapi/map/HeatMap;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_addOverlay_Lcom_baidu_mapapi_map_OverlayOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='addOverlay' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.OverlayOptions']]"
		[Register ("addOverlay", "(Lcom/baidu/mapapi/map/OverlayOptions;)Lcom/baidu/mapapi/map/Overlay;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.Overlay AddOverlay (global::Com.Baidu.Mapapi.Map.OverlayOptions p0)
		{
			if (id_addOverlay_Lcom_baidu_mapapi_map_OverlayOptions_ == IntPtr.Zero)
				id_addOverlay_Lcom_baidu_mapapi_map_OverlayOptions_ = JNIEnv.GetMethodID (class_ref, "addOverlay", "(Lcom/baidu/mapapi/map/OverlayOptions;)Lcom/baidu/mapapi/map/Overlay;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.Overlay __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Overlay> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addOverlay_Lcom_baidu_mapapi_map_OverlayOptions_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_addOverlays_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='addOverlays' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.baidu.mapapi.map.OverlayOptions&gt;']]"
		[Register ("addOverlays", "(Ljava/util/List;)Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.Overlay> AddOverlays (global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.OverlayOptions> p0)
		{
			if (id_addOverlays_Ljava_util_List_ == IntPtr.Zero)
				id_addOverlays_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addOverlays", "(Ljava/util/List;)Ljava/util/List;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.OverlayOptions>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.Overlay> __ret = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.Overlay>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addOverlays_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addTileLayer_Lcom_baidu_mapapi_map_TileOverlayOptions_;
#pragma warning disable 0169
		static Delegate GetAddTileLayer_Lcom_baidu_mapapi_map_TileOverlayOptions_Handler ()
		{
			if (cb_addTileLayer_Lcom_baidu_mapapi_map_TileOverlayOptions_ == null)
				cb_addTileLayer_Lcom_baidu_mapapi_map_TileOverlayOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddTileLayer_Lcom_baidu_mapapi_map_TileOverlayOptions_);
			return cb_addTileLayer_Lcom_baidu_mapapi_map_TileOverlayOptions_;
		}

		static IntPtr n_AddTileLayer_Lcom_baidu_mapapi_map_TileOverlayOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.TileOverlayOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TileOverlayOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddTileLayer (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addTileLayer_Lcom_baidu_mapapi_map_TileOverlayOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='addTileLayer' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.TileOverlayOptions']]"
		[Register ("addTileLayer", "(Lcom/baidu/mapapi/map/TileOverlayOptions;)Lcom/baidu/mapapi/map/TileOverlay;", "GetAddTileLayer_Lcom_baidu_mapapi_map_TileOverlayOptions_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Map.TileOverlay AddTileLayer (global::Com.Baidu.Mapapi.Map.TileOverlayOptions p0)
		{
			if (id_addTileLayer_Lcom_baidu_mapapi_map_TileOverlayOptions_ == IntPtr.Zero)
				id_addTileLayer_Lcom_baidu_mapapi_map_TileOverlayOptions_ = JNIEnv.GetMethodID (class_ref, "addTileLayer", "(Lcom/baidu/mapapi/map/TileOverlayOptions;)Lcom/baidu/mapapi/map/TileOverlay;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Baidu.Mapapi.Map.TileOverlay __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TileOverlay> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addTileLayer_Lcom_baidu_mapapi_map_TileOverlayOptions_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TileOverlay> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addTileLayer", "(Lcom/baidu/mapapi/map/TileOverlayOptions;)Lcom/baidu/mapapi/map/TileOverlay;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_animateMapStatus_Lcom_baidu_mapapi_map_MapStatusUpdate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='animateMapStatus' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MapStatusUpdate']]"
		[Register ("animateMapStatus", "(Lcom/baidu/mapapi/map/MapStatusUpdate;)V", "")]
		public unsafe void AnimateMapStatus (global::Com.Baidu.Mapapi.Map.MapStatusUpdate p0)
		{
			if (id_animateMapStatus_Lcom_baidu_mapapi_map_MapStatusUpdate_ == IntPtr.Zero)
				id_animateMapStatus_Lcom_baidu_mapapi_map_MapStatusUpdate_ = JNIEnv.GetMethodID (class_ref, "animateMapStatus", "(Lcom/baidu/mapapi/map/MapStatusUpdate;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_animateMapStatus_Lcom_baidu_mapapi_map_MapStatusUpdate_, __args);
			} finally {
			}
		}

		static IntPtr id_animateMapStatus_Lcom_baidu_mapapi_map_MapStatusUpdate_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='animateMapStatus' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.map.MapStatusUpdate'] and parameter[2][@type='int']]"
		[Register ("animateMapStatus", "(Lcom/baidu/mapapi/map/MapStatusUpdate;I)V", "")]
		public unsafe void AnimateMapStatus (global::Com.Baidu.Mapapi.Map.MapStatusUpdate p0, int p1)
		{
			if (id_animateMapStatus_Lcom_baidu_mapapi_map_MapStatusUpdate_I == IntPtr.Zero)
				id_animateMapStatus_Lcom_baidu_mapapi_map_MapStatusUpdate_I = JNIEnv.GetMethodID (class_ref, "animateMapStatus", "(Lcom/baidu/mapapi/map/MapStatusUpdate;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_animateMapStatus_Lcom_baidu_mapapi_map_MapStatusUpdate_I, __args);
			} finally {
			}
		}

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
			} finally {
			}
		}

		static Delegate cb_getMarkersInBounds_Lcom_baidu_mapapi_model_LatLngBounds_;
#pragma warning disable 0169
		static Delegate GetGetMarkersInBounds_Lcom_baidu_mapapi_model_LatLngBounds_Handler ()
		{
			if (cb_getMarkersInBounds_Lcom_baidu_mapapi_model_LatLngBounds_ == null)
				cb_getMarkersInBounds_Lcom_baidu_mapapi_model_LatLngBounds_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMarkersInBounds_Lcom_baidu_mapapi_model_LatLngBounds_);
			return cb_getMarkersInBounds_Lcom_baidu_mapapi_model_LatLngBounds_;
		}

		static IntPtr n_GetMarkersInBounds_Lcom_baidu_mapapi_model_LatLngBounds_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Model.LatLngBounds p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLngBounds> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.Marker>.ToLocalJniHandle (__this.GetMarkersInBounds (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMarkersInBounds_Lcom_baidu_mapapi_model_LatLngBounds_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getMarkersInBounds' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLngBounds']]"
		[Register ("getMarkersInBounds", "(Lcom/baidu/mapapi/model/LatLngBounds;)Ljava/util/List;", "GetGetMarkersInBounds_Lcom_baidu_mapapi_model_LatLngBounds_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.Marker> GetMarkersInBounds (global::Com.Baidu.Mapapi.Model.LatLngBounds p0)
		{
			if (id_getMarkersInBounds_Lcom_baidu_mapapi_model_LatLngBounds_ == IntPtr.Zero)
				id_getMarkersInBounds_Lcom_baidu_mapapi_model_LatLngBounds_ = JNIEnv.GetMethodID (class_ref, "getMarkersInBounds", "(Lcom/baidu/mapapi/model/LatLngBounds;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.Marker> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.Marker>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMarkersInBounds_Lcom_baidu_mapapi_model_LatLngBounds_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.Marker>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMarkersInBounds", "(Lcom/baidu/mapapi/model/LatLngBounds;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_hideInfoWindow;
#pragma warning disable 0169
		static Delegate GetHideInfoWindowHandler ()
		{
			if (cb_hideInfoWindow == null)
				cb_hideInfoWindow = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_HideInfoWindow);
			return cb_hideInfoWindow;
		}

		static void n_HideInfoWindow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideInfoWindow ();
		}
#pragma warning restore 0169

		static IntPtr id_hideInfoWindow;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='hideInfoWindow' and count(parameter)=0]"
		[Register ("hideInfoWindow", "()V", "GetHideInfoWindowHandler")]
		public virtual unsafe void HideInfoWindow ()
		{
			if (id_hideInfoWindow == IntPtr.Zero)
				id_hideInfoWindow = JNIEnv.GetMethodID (class_ref, "hideInfoWindow", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_hideInfoWindow);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hideInfoWindow", "()V"));
			} finally {
			}
		}

		static IntPtr id_removeMarkerClickListener_Lcom_baidu_mapapi_map_BaiduMap_OnMarkerClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='removeMarkerClickListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnMarkerClickListener']]"
		[Register ("removeMarkerClickListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnMarkerClickListener;)V", "")]
		public unsafe void RemoveMarkerClickListener (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerClickListener p0)
		{
			if (id_removeMarkerClickListener_Lcom_baidu_mapapi_map_BaiduMap_OnMarkerClickListener_ == IntPtr.Zero)
				id_removeMarkerClickListener_Lcom_baidu_mapapi_map_BaiduMap_OnMarkerClickListener_ = JNIEnv.GetMethodID (class_ref, "removeMarkerClickListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnMarkerClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeMarkerClickListener_Lcom_baidu_mapapi_map_BaiduMap_OnMarkerClickListener_, __args);
			} finally {
			}
		}

		static Delegate cb_setCompassIcon_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetCompassIcon_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setCompassIcon_Landroid_graphics_Bitmap_ == null)
				cb_setCompassIcon_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCompassIcon_Landroid_graphics_Bitmap_);
			return cb_setCompassIcon_Landroid_graphics_Bitmap_;
		}

		static void n_SetCompassIcon_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCompassIcon (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCompassIcon_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setCompassIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("setCompassIcon", "(Landroid/graphics/Bitmap;)V", "GetSetCompassIcon_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void SetCompassIcon (global::Android.Graphics.Bitmap p0)
		{
			if (id_setCompassIcon_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_setCompassIcon_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setCompassIcon", "(Landroid/graphics/Bitmap;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCompassIcon_Landroid_graphics_Bitmap_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCompassIcon", "(Landroid/graphics/Bitmap;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_setIndoorEnable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setIndoorEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIndoorEnable", "(Z)V", "")]
		public unsafe void SetIndoorEnable (bool p0)
		{
			if (id_setIndoorEnable_Z == IntPtr.Zero)
				id_setIndoorEnable_Z = JNIEnv.GetMethodID (class_ref, "setIndoorEnable", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIndoorEnable_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setMapStatus_Lcom_baidu_mapapi_map_MapStatusUpdate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setMapStatus' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MapStatusUpdate']]"
		[Register ("setMapStatus", "(Lcom/baidu/mapapi/map/MapStatusUpdate;)V", "")]
		public unsafe void SetMapStatus (global::Com.Baidu.Mapapi.Map.MapStatusUpdate p0)
		{
			if (id_setMapStatus_Lcom_baidu_mapapi_map_MapStatusUpdate_ == IntPtr.Zero)
				id_setMapStatus_Lcom_baidu_mapapi_map_MapStatusUpdate_ = JNIEnv.GetMethodID (class_ref, "setMapStatus", "(Lcom/baidu/mapapi/map/MapStatusUpdate;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMapStatus_Lcom_baidu_mapapi_map_MapStatusUpdate_, __args);
			} finally {
			}
		}

		static IntPtr id_setMapStatusLimits_Lcom_baidu_mapapi_model_LatLngBounds_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setMapStatusLimits' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLngBounds']]"
		[Register ("setMapStatusLimits", "(Lcom/baidu/mapapi/model/LatLngBounds;)V", "")]
		public unsafe void SetMapStatusLimits (global::Com.Baidu.Mapapi.Model.LatLngBounds p0)
		{
			if (id_setMapStatusLimits_Lcom_baidu_mapapi_model_LatLngBounds_ == IntPtr.Zero)
				id_setMapStatusLimits_Lcom_baidu_mapapi_model_LatLngBounds_ = JNIEnv.GetMethodID (class_ref, "setMapStatusLimits", "(Lcom/baidu/mapapi/model/LatLngBounds;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMapStatusLimits_Lcom_baidu_mapapi_model_LatLngBounds_, __args);
			} finally {
			}
		}

		static IntPtr id_setMaxAndMinZoomLevel_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setMaxAndMinZoomLevel' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setMaxAndMinZoomLevel", "(FF)V", "")]
		public unsafe void SetMaxAndMinZoomLevel (float p0, float p1)
		{
			if (id_setMaxAndMinZoomLevel_FF == IntPtr.Zero)
				id_setMaxAndMinZoomLevel_FF = JNIEnv.GetMethodID (class_ref, "setMaxAndMinZoomLevel", "(FF)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaxAndMinZoomLevel_FF, __args);
			} finally {
			}
		}

		static IntPtr id_setMyLocationConfigeration_Lcom_baidu_mapapi_map_MyLocationConfiguration_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setMyLocationConfigeration' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MyLocationConfiguration']]"
		[Register ("setMyLocationConfigeration", "(Lcom/baidu/mapapi/map/MyLocationConfiguration;)V", "")]
		public unsafe void SetMyLocationConfigeration (global::Com.Baidu.Mapapi.Map.MyLocationConfiguration p0)
		{
			if (id_setMyLocationConfigeration_Lcom_baidu_mapapi_map_MyLocationConfiguration_ == IntPtr.Zero)
				id_setMyLocationConfigeration_Lcom_baidu_mapapi_map_MyLocationConfiguration_ = JNIEnv.GetMethodID (class_ref, "setMyLocationConfigeration", "(Lcom/baidu/mapapi/map/MyLocationConfiguration;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMyLocationConfigeration_Lcom_baidu_mapapi_map_MyLocationConfiguration_, __args);
			} finally {
			}
		}

		static IntPtr id_setMyLocationData_Lcom_baidu_mapapi_map_MyLocationData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setMyLocationData' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MyLocationData']]"
		[Register ("setMyLocationData", "(Lcom/baidu/mapapi/map/MyLocationData;)V", "")]
		public unsafe void SetMyLocationData (global::Com.Baidu.Mapapi.Map.MyLocationData p0)
		{
			if (id_setMyLocationData_Lcom_baidu_mapapi_map_MyLocationData_ == IntPtr.Zero)
				id_setMyLocationData_Lcom_baidu_mapapi_map_MyLocationData_ = JNIEnv.GetMethodID (class_ref, "setMyLocationData", "(Lcom/baidu/mapapi/map/MyLocationData;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMyLocationData_Lcom_baidu_mapapi_map_MyLocationData_, __args);
			} finally {
			}
		}

		static IntPtr id_setOnBaseIndoorMapListener_Lcom_baidu_mapapi_map_BaiduMap_OnBaseIndoorMapListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOnBaseIndoorMapListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnBaseIndoorMapListener']]"
		[Register ("setOnBaseIndoorMapListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnBaseIndoorMapListener;)V", "")]
		public unsafe void SetOnBaseIndoorMapListener (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnBaseIndoorMapListener p0)
		{
			if (id_setOnBaseIndoorMapListener_Lcom_baidu_mapapi_map_BaiduMap_OnBaseIndoorMapListener_ == IntPtr.Zero)
				id_setOnBaseIndoorMapListener_Lcom_baidu_mapapi_map_BaiduMap_OnBaseIndoorMapListener_ = JNIEnv.GetMethodID (class_ref, "setOnBaseIndoorMapListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnBaseIndoorMapListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnBaseIndoorMapListener_Lcom_baidu_mapapi_map_BaiduMap_OnBaseIndoorMapListener_, __args);
			} finally {
			}
		}

		static IntPtr id_setOnMapClickListener_Lcom_baidu_mapapi_map_BaiduMap_OnMapClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOnMapClickListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnMapClickListener']]"
		[Register ("setOnMapClickListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnMapClickListener;)V", "")]
		public unsafe void SetOnMapClickListener (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListener p0)
		{
			if (id_setOnMapClickListener_Lcom_baidu_mapapi_map_BaiduMap_OnMapClickListener_ == IntPtr.Zero)
				id_setOnMapClickListener_Lcom_baidu_mapapi_map_BaiduMap_OnMapClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnMapClickListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnMapClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnMapClickListener_Lcom_baidu_mapapi_map_BaiduMap_OnMapClickListener_, __args);
			} finally {
			}
		}

		static IntPtr id_setOnMapDoubleClickListener_Lcom_baidu_mapapi_map_BaiduMap_OnMapDoubleClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOnMapDoubleClickListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnMapDoubleClickListener']]"
		[Register ("setOnMapDoubleClickListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnMapDoubleClickListener;)V", "")]
		public unsafe void SetOnMapDoubleClickListener (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDoubleClickListener p0)
		{
			if (id_setOnMapDoubleClickListener_Lcom_baidu_mapapi_map_BaiduMap_OnMapDoubleClickListener_ == IntPtr.Zero)
				id_setOnMapDoubleClickListener_Lcom_baidu_mapapi_map_BaiduMap_OnMapDoubleClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnMapDoubleClickListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnMapDoubleClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnMapDoubleClickListener_Lcom_baidu_mapapi_map_BaiduMap_OnMapDoubleClickListener_, __args);
			} finally {
			}
		}

		static IntPtr id_setOnMapDrawFrameCallback_Lcom_baidu_mapapi_map_BaiduMap_OnMapDrawFrameCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOnMapDrawFrameCallback' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnMapDrawFrameCallback']]"
		[Register ("setOnMapDrawFrameCallback", "(Lcom/baidu/mapapi/map/BaiduMap$OnMapDrawFrameCallback;)V", "")]
		public unsafe void SetOnMapDrawFrameCallback (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDrawFrameCallback p0)
		{
			if (id_setOnMapDrawFrameCallback_Lcom_baidu_mapapi_map_BaiduMap_OnMapDrawFrameCallback_ == IntPtr.Zero)
				id_setOnMapDrawFrameCallback_Lcom_baidu_mapapi_map_BaiduMap_OnMapDrawFrameCallback_ = JNIEnv.GetMethodID (class_ref, "setOnMapDrawFrameCallback", "(Lcom/baidu/mapapi/map/BaiduMap$OnMapDrawFrameCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnMapDrawFrameCallback_Lcom_baidu_mapapi_map_BaiduMap_OnMapDrawFrameCallback_, __args);
			} finally {
			}
		}

		static Delegate cb_setOnMapLoadedCallback_Lcom_baidu_mapapi_map_BaiduMap_OnMapLoadedCallback_;
#pragma warning disable 0169
		static Delegate GetSetOnMapLoadedCallback_Lcom_baidu_mapapi_map_BaiduMap_OnMapLoadedCallback_Handler ()
		{
			if (cb_setOnMapLoadedCallback_Lcom_baidu_mapapi_map_BaiduMap_OnMapLoadedCallback_ == null)
				cb_setOnMapLoadedCallback_Lcom_baidu_mapapi_map_BaiduMap_OnMapLoadedCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMapLoadedCallback_Lcom_baidu_mapapi_map_BaiduMap_OnMapLoadedCallback_);
			return cb_setOnMapLoadedCallback_Lcom_baidu_mapapi_map_BaiduMap_OnMapLoadedCallback_;
		}

		static void n_SetOnMapLoadedCallback_Lcom_baidu_mapapi_map_BaiduMap_OnMapLoadedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLoadedCallback p0 = (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLoadedCallback)global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLoadedCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMapLoadedCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnMapLoadedCallback_Lcom_baidu_mapapi_map_BaiduMap_OnMapLoadedCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOnMapLoadedCallback' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnMapLoadedCallback']]"
		[Register ("setOnMapLoadedCallback", "(Lcom/baidu/mapapi/map/BaiduMap$OnMapLoadedCallback;)V", "GetSetOnMapLoadedCallback_Lcom_baidu_mapapi_map_BaiduMap_OnMapLoadedCallback_Handler")]
		public virtual unsafe void SetOnMapLoadedCallback (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLoadedCallback p0)
		{
			if (id_setOnMapLoadedCallback_Lcom_baidu_mapapi_map_BaiduMap_OnMapLoadedCallback_ == IntPtr.Zero)
				id_setOnMapLoadedCallback_Lcom_baidu_mapapi_map_BaiduMap_OnMapLoadedCallback_ = JNIEnv.GetMethodID (class_ref, "setOnMapLoadedCallback", "(Lcom/baidu/mapapi/map/BaiduMap$OnMapLoadedCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnMapLoadedCallback_Lcom_baidu_mapapi_map_BaiduMap_OnMapLoadedCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnMapLoadedCallback", "(Lcom/baidu/mapapi/map/BaiduMap$OnMapLoadedCallback;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_setOnMapLongClickListener_Lcom_baidu_mapapi_map_BaiduMap_OnMapLongClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOnMapLongClickListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnMapLongClickListener']]"
		[Register ("setOnMapLongClickListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnMapLongClickListener;)V", "")]
		public unsafe void SetOnMapLongClickListener (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLongClickListener p0)
		{
			if (id_setOnMapLongClickListener_Lcom_baidu_mapapi_map_BaiduMap_OnMapLongClickListener_ == IntPtr.Zero)
				id_setOnMapLongClickListener_Lcom_baidu_mapapi_map_BaiduMap_OnMapLongClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnMapLongClickListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnMapLongClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnMapLongClickListener_Lcom_baidu_mapapi_map_BaiduMap_OnMapLongClickListener_, __args);
			} finally {
			}
		}

		static Delegate cb_setOnMapRenderCallbadk_Lcom_baidu_mapapi_map_BaiduMap_OnMapRenderCallback_;
#pragma warning disable 0169
		static Delegate GetSetOnMapRenderCallbadk_Lcom_baidu_mapapi_map_BaiduMap_OnMapRenderCallback_Handler ()
		{
			if (cb_setOnMapRenderCallbadk_Lcom_baidu_mapapi_map_BaiduMap_OnMapRenderCallback_ == null)
				cb_setOnMapRenderCallbadk_Lcom_baidu_mapapi_map_BaiduMap_OnMapRenderCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMapRenderCallbadk_Lcom_baidu_mapapi_map_BaiduMap_OnMapRenderCallback_);
			return cb_setOnMapRenderCallbadk_Lcom_baidu_mapapi_map_BaiduMap_OnMapRenderCallback_;
		}

		static void n_SetOnMapRenderCallbadk_Lcom_baidu_mapapi_map_BaiduMap_OnMapRenderCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapRenderCallback p0 = (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapRenderCallback)global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapRenderCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMapRenderCallbadk (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnMapRenderCallbadk_Lcom_baidu_mapapi_map_BaiduMap_OnMapRenderCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOnMapRenderCallbadk' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnMapRenderCallback']]"
		[Register ("setOnMapRenderCallbadk", "(Lcom/baidu/mapapi/map/BaiduMap$OnMapRenderCallback;)V", "GetSetOnMapRenderCallbadk_Lcom_baidu_mapapi_map_BaiduMap_OnMapRenderCallback_Handler")]
		public virtual unsafe void SetOnMapRenderCallbadk (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapRenderCallback p0)
		{
			if (id_setOnMapRenderCallbadk_Lcom_baidu_mapapi_map_BaiduMap_OnMapRenderCallback_ == IntPtr.Zero)
				id_setOnMapRenderCallbadk_Lcom_baidu_mapapi_map_BaiduMap_OnMapRenderCallback_ = JNIEnv.GetMethodID (class_ref, "setOnMapRenderCallbadk", "(Lcom/baidu/mapapi/map/BaiduMap$OnMapRenderCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnMapRenderCallbadk_Lcom_baidu_mapapi_map_BaiduMap_OnMapRenderCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnMapRenderCallbadk", "(Lcom/baidu/mapapi/map/BaiduMap$OnMapRenderCallback;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_setOnMapStatusChangeListener_Lcom_baidu_mapapi_map_BaiduMap_OnMapStatusChangeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOnMapStatusChangeListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnMapStatusChangeListener']]"
		[Register ("setOnMapStatusChangeListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnMapStatusChangeListener;)V", "")]
		public unsafe void SetOnMapStatusChangeListener (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener p0)
		{
			if (id_setOnMapStatusChangeListener_Lcom_baidu_mapapi_map_BaiduMap_OnMapStatusChangeListener_ == IntPtr.Zero)
				id_setOnMapStatusChangeListener_Lcom_baidu_mapapi_map_BaiduMap_OnMapStatusChangeListener_ = JNIEnv.GetMethodID (class_ref, "setOnMapStatusChangeListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnMapStatusChangeListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnMapStatusChangeListener_Lcom_baidu_mapapi_map_BaiduMap_OnMapStatusChangeListener_, __args);
			} finally {
			}
		}

		static IntPtr id_setOnMapTouchListener_Lcom_baidu_mapapi_map_BaiduMap_OnMapTouchListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOnMapTouchListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnMapTouchListener']]"
		[Register ("setOnMapTouchListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnMapTouchListener;)V", "")]
		public unsafe void SetOnMapTouchListener (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapTouchListener p0)
		{
			if (id_setOnMapTouchListener_Lcom_baidu_mapapi_map_BaiduMap_OnMapTouchListener_ == IntPtr.Zero)
				id_setOnMapTouchListener_Lcom_baidu_mapapi_map_BaiduMap_OnMapTouchListener_ = JNIEnv.GetMethodID (class_ref, "setOnMapTouchListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnMapTouchListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnMapTouchListener_Lcom_baidu_mapapi_map_BaiduMap_OnMapTouchListener_, __args);
			} finally {
			}
		}

		static IntPtr id_setOnMarkerClickListener_Lcom_baidu_mapapi_map_BaiduMap_OnMarkerClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOnMarkerClickListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnMarkerClickListener']]"
		[Register ("setOnMarkerClickListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnMarkerClickListener;)V", "")]
		public unsafe void SetOnMarkerClickListener (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerClickListener p0)
		{
			if (id_setOnMarkerClickListener_Lcom_baidu_mapapi_map_BaiduMap_OnMarkerClickListener_ == IntPtr.Zero)
				id_setOnMarkerClickListener_Lcom_baidu_mapapi_map_BaiduMap_OnMarkerClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnMarkerClickListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnMarkerClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnMarkerClickListener_Lcom_baidu_mapapi_map_BaiduMap_OnMarkerClickListener_, __args);
			} finally {
			}
		}

		static IntPtr id_setOnMarkerDragListener_Lcom_baidu_mapapi_map_BaiduMap_OnMarkerDragListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOnMarkerDragListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnMarkerDragListener']]"
		[Register ("setOnMarkerDragListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnMarkerDragListener;)V", "")]
		public unsafe void SetOnMarkerDragListener (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListener p0)
		{
			if (id_setOnMarkerDragListener_Lcom_baidu_mapapi_map_BaiduMap_OnMarkerDragListener_ == IntPtr.Zero)
				id_setOnMarkerDragListener_Lcom_baidu_mapapi_map_BaiduMap_OnMarkerDragListener_ = JNIEnv.GetMethodID (class_ref, "setOnMarkerDragListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnMarkerDragListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnMarkerDragListener_Lcom_baidu_mapapi_map_BaiduMap_OnMarkerDragListener_, __args);
			} finally {
			}
		}

		static IntPtr id_setOnMyLocationClickListener_Lcom_baidu_mapapi_map_BaiduMap_OnMyLocationClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOnMyLocationClickListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnMyLocationClickListener']]"
		[Register ("setOnMyLocationClickListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnMyLocationClickListener;)V", "")]
		public unsafe void SetOnMyLocationClickListener (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMyLocationClickListener p0)
		{
			if (id_setOnMyLocationClickListener_Lcom_baidu_mapapi_map_BaiduMap_OnMyLocationClickListener_ == IntPtr.Zero)
				id_setOnMyLocationClickListener_Lcom_baidu_mapapi_map_BaiduMap_OnMyLocationClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnMyLocationClickListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnMyLocationClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnMyLocationClickListener_Lcom_baidu_mapapi_map_BaiduMap_OnMyLocationClickListener_, __args);
			} finally {
			}
		}

		static IntPtr id_setOnPolylineClickListener_Lcom_baidu_mapapi_map_BaiduMap_OnPolylineClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOnPolylineClickListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnPolylineClickListener']]"
		[Register ("setOnPolylineClickListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnPolylineClickListener;)V", "")]
		public unsafe void SetOnPolylineClickListener (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnPolylineClickListener p0)
		{
			if (id_setOnPolylineClickListener_Lcom_baidu_mapapi_map_BaiduMap_OnPolylineClickListener_ == IntPtr.Zero)
				id_setOnPolylineClickListener_Lcom_baidu_mapapi_map_BaiduMap_OnPolylineClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnPolylineClickListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnPolylineClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnPolylineClickListener_Lcom_baidu_mapapi_map_BaiduMap_OnPolylineClickListener_, __args);
			} finally {
			}
		}

		static IntPtr id_setPadding_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setPadding' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("setPadding", "(IIII)V", "")]
		public unsafe void SetPadding (int p0, int p1, int p2, int p3)
		{
			if (id_setPadding_IIII == IntPtr.Zero)
				id_setPadding_IIII = JNIEnv.GetMethodID (class_ref, "setPadding", "(IIII)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPadding_IIII, __args);
			} finally {
			}
		}

		static IntPtr id_setViewPadding_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setViewPadding' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setViewPadding", "(IIII)V", "")]
		public unsafe void SetViewPadding (int p0, int p1, int p2, int p3)
		{
			if (id_setViewPadding_IIII == IntPtr.Zero)
				id_setViewPadding_IIII = JNIEnv.GetMethodID (class_ref, "setViewPadding", "(IIII)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setViewPadding_IIII, __args);
			} finally {
			}
		}

		static Delegate cb_showInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_;
#pragma warning disable 0169
		static Delegate GetShowInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_Handler ()
		{
			if (cb_showInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_ == null)
				cb_showInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_);
			return cb_showInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_;
		}

		static void n_ShowInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.InfoWindow p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.InfoWindow> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShowInfoWindow (p0);
		}
#pragma warning restore 0169

		static IntPtr id_showInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='showInfoWindow' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.InfoWindow']]"
		[Register ("showInfoWindow", "(Lcom/baidu/mapapi/map/InfoWindow;)V", "GetShowInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_Handler")]
		public virtual unsafe void ShowInfoWindow (global::Com.Baidu.Mapapi.Map.InfoWindow p0)
		{
			if (id_showInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_ == IntPtr.Zero)
				id_showInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_ = JNIEnv.GetMethodID (class_ref, "showInfoWindow", "(Lcom/baidu/mapapi/map/InfoWindow;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showInfoWindow", "(Lcom/baidu/mapapi/map/InfoWindow;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_showMapIndoorPoi_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='showMapIndoorPoi' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showMapIndoorPoi", "(Z)V", "")]
		public unsafe void ShowMapIndoorPoi (bool p0)
		{
			if (id_showMapIndoorPoi_Z == IntPtr.Zero)
				id_showMapIndoorPoi_Z = JNIEnv.GetMethodID (class_ref, "showMapIndoorPoi", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showMapIndoorPoi_Z, __args);
			} finally {
			}
		}

		static IntPtr id_showMapPoi_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='showMapPoi' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showMapPoi", "(Z)V", "")]
		public unsafe void ShowMapPoi (bool p0)
		{
			if (id_showMapPoi_Z == IntPtr.Zero)
				id_showMapPoi_Z = JNIEnv.GetMethodID (class_ref, "showMapPoi", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showMapPoi_Z, __args);
			} finally {
			}
		}

		static IntPtr id_snapshot_Lcom_baidu_mapapi_map_BaiduMap_SnapshotReadyCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='snapshot' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.SnapshotReadyCallback']]"
		[Register ("snapshot", "(Lcom/baidu/mapapi/map/BaiduMap$SnapshotReadyCallback;)V", "")]
		public unsafe void Snapshot (global::Com.Baidu.Mapapi.Map.BaiduMap.ISnapshotReadyCallback p0)
		{
			if (id_snapshot_Lcom_baidu_mapapi_map_BaiduMap_SnapshotReadyCallback_ == IntPtr.Zero)
				id_snapshot_Lcom_baidu_mapapi_map_BaiduMap_SnapshotReadyCallback_ = JNIEnv.GetMethodID (class_ref, "snapshot", "(Lcom/baidu/mapapi/map/BaiduMap$SnapshotReadyCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_snapshot_Lcom_baidu_mapapi_map_BaiduMap_SnapshotReadyCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_snapshotScope_Landroid_graphics_Rect_Lcom_baidu_mapapi_map_BaiduMap_SnapshotReadyCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='snapshotScope' and count(parameter)=2 and parameter[1][@type='android.graphics.Rect'] and parameter[2][@type='com.baidu.mapapi.map.BaiduMap.SnapshotReadyCallback']]"
		[Register ("snapshotScope", "(Landroid/graphics/Rect;Lcom/baidu/mapapi/map/BaiduMap$SnapshotReadyCallback;)V", "")]
		public unsafe void SnapshotScope (global::Android.Graphics.Rect p0, global::Com.Baidu.Mapapi.Map.BaiduMap.ISnapshotReadyCallback p1)
		{
			if (id_snapshotScope_Landroid_graphics_Rect_Lcom_baidu_mapapi_map_BaiduMap_SnapshotReadyCallback_ == IntPtr.Zero)
				id_snapshotScope_Landroid_graphics_Rect_Lcom_baidu_mapapi_map_BaiduMap_SnapshotReadyCallback_ = JNIEnv.GetMethodID (class_ref, "snapshotScope", "(Landroid/graphics/Rect;Lcom/baidu/mapapi/map/BaiduMap$SnapshotReadyCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_snapshotScope_Landroid_graphics_Rect_Lcom_baidu_mapapi_map_BaiduMap_SnapshotReadyCallback_, __args);
			} finally {
			}
		}

		static Delegate cb_switchBaseIndoorMapFloor_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSwitchBaseIndoorMapFloor_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_switchBaseIndoorMapFloor_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_switchBaseIndoorMapFloor_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SwitchBaseIndoorMapFloor_Ljava_lang_String_Ljava_lang_String_);
			return cb_switchBaseIndoorMapFloor_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_SwitchBaseIndoorMapFloor_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SwitchBaseIndoorMapFloor (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_switchBaseIndoorMapFloor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='switchBaseIndoorMapFloor' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("switchBaseIndoorMapFloor", "(Ljava/lang/String;Ljava/lang/String;)Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo$SwitchFloorError;", "GetSwitchBaseIndoorMapFloor_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError SwitchBaseIndoorMapFloor (string p0, string p1)
		{
			if (id_switchBaseIndoorMapFloor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_switchBaseIndoorMapFloor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "switchBaseIndoorMapFloor", "(Ljava/lang/String;Ljava/lang/String;)Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo$SwitchFloorError;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_switchBaseIndoorMapFloor_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "switchBaseIndoorMapFloor", "(Ljava/lang/String;Ljava/lang/String;)Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo$SwitchFloorError;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

#region "Event implementation for Com.Baidu.Mapapi.Map.BaiduMap.IOnBaseIndoorMapListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.BaseIndoorMapEventArgs> BaseIndoorMap {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnBaseIndoorMapListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnBaseIndoorMapListenerImplementor>(
						ref weak_implementor_SetOnBaseIndoorMapListener,
						__CreateIOnBaseIndoorMapListenerImplementor,
						SetOnBaseIndoorMapListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnBaseIndoorMapListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnBaseIndoorMapListenerImplementor>(
						ref weak_implementor_SetOnBaseIndoorMapListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnBaseIndoorMapListenerImplementor.__IsEmpty,
						__v => SetOnBaseIndoorMapListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnBaseIndoorMapListener;

		global::Com.Baidu.Mapapi.Map.BaiduMap.IOnBaseIndoorMapListenerImplementor __CreateIOnBaseIndoorMapListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Map.BaiduMap.IOnBaseIndoorMapListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.MapClickEventArgs> MapClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListenerImplementor>(
						ref weak_implementor_SetOnMapClickListener,
						__CreateIOnMapClickListenerImplementor,
						SetOnMapClickListener,
						__h => __h.OnMapClickHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListenerImplementor>(
						ref weak_implementor_SetOnMapClickListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListenerImplementor.__IsEmpty,
						__v => SetOnMapClickListener (null),
						__h => __h.OnMapClickHandler -= value);
			}
		}

		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.MapPoiClickEventArgs> MapPoiClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListenerImplementor>(
						ref weak_implementor_SetOnMapClickListener,
						__CreateIOnMapClickListenerImplementor,
						SetOnMapClickListener,
						__h => __h.OnMapPoiClickHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListenerImplementor>(
						ref weak_implementor_SetOnMapClickListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListenerImplementor.__IsEmpty,
						__v => SetOnMapClickListener (null),
						__h => __h.OnMapPoiClickHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMapClickListener;

		global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListenerImplementor __CreateIOnMapClickListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDoubleClickListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.MapDoubleClickEventArgs> MapDoubleClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDoubleClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDoubleClickListenerImplementor>(
						ref weak_implementor_SetOnMapDoubleClickListener,
						__CreateIOnMapDoubleClickListenerImplementor,
						SetOnMapDoubleClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDoubleClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDoubleClickListenerImplementor>(
						ref weak_implementor_SetOnMapDoubleClickListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDoubleClickListenerImplementor.__IsEmpty,
						__v => SetOnMapDoubleClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMapDoubleClickListener;

		global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDoubleClickListenerImplementor __CreateIOnMapDoubleClickListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDoubleClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLongClickListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.MapLongClickEventArgs> MapLongClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLongClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLongClickListenerImplementor>(
						ref weak_implementor_SetOnMapLongClickListener,
						__CreateIOnMapLongClickListenerImplementor,
						SetOnMapLongClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLongClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLongClickListenerImplementor>(
						ref weak_implementor_SetOnMapLongClickListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLongClickListenerImplementor.__IsEmpty,
						__v => SetOnMapLongClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMapLongClickListener;

		global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLongClickListenerImplementor __CreateIOnMapLongClickListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLongClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.MapStatusChangeEventArgs> MapStatusChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListenerImplementor>(
						ref weak_implementor_SetOnMapStatusChangeListener,
						__CreateIOnMapStatusChangeListenerImplementor,
						SetOnMapStatusChangeListener,
						__h => __h.OnMapStatusChangeHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListenerImplementor>(
						ref weak_implementor_SetOnMapStatusChangeListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListenerImplementor.__IsEmpty,
						__v => SetOnMapStatusChangeListener (null),
						__h => __h.OnMapStatusChangeHandler -= value);
			}
		}

		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.MapStatusChangeFinishEventArgs> MapStatusChangeFinish {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListenerImplementor>(
						ref weak_implementor_SetOnMapStatusChangeListener,
						__CreateIOnMapStatusChangeListenerImplementor,
						SetOnMapStatusChangeListener,
						__h => __h.OnMapStatusChangeFinishHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListenerImplementor>(
						ref weak_implementor_SetOnMapStatusChangeListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListenerImplementor.__IsEmpty,
						__v => SetOnMapStatusChangeListener (null),
						__h => __h.OnMapStatusChangeFinishHandler -= value);
			}
		}

		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.MapStatusChangeStartEventArgs> MapStatusChangeStart {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListenerImplementor>(
						ref weak_implementor_SetOnMapStatusChangeListener,
						__CreateIOnMapStatusChangeListenerImplementor,
						SetOnMapStatusChangeListener,
						__h => __h.OnMapStatusChangeStartHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListenerImplementor>(
						ref weak_implementor_SetOnMapStatusChangeListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListenerImplementor.__IsEmpty,
						__v => SetOnMapStatusChangeListener (null),
						__h => __h.OnMapStatusChangeStartHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMapStatusChangeListener;

		global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListenerImplementor __CreateIOnMapStatusChangeListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Baidu.Mapapi.Map.BaiduMap.IOnMapTouchListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.MapTouchEventArgs> MapTouch {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapTouchListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapTouchListenerImplementor>(
						ref weak_implementor_SetOnMapTouchListener,
						__CreateIOnMapTouchListenerImplementor,
						SetOnMapTouchListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapTouchListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapTouchListenerImplementor>(
						ref weak_implementor_SetOnMapTouchListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapTouchListenerImplementor.__IsEmpty,
						__v => SetOnMapTouchListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMapTouchListener;

		global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapTouchListenerImplementor __CreateIOnMapTouchListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapTouchListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerClickListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.MarkerClickEventArgs> MarkerClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerClickListenerImplementor>(
						ref weak_implementor_SetOnMarkerClickListener,
						__CreateIOnMarkerClickListenerImplementor,
						SetOnMarkerClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerClickListenerImplementor>(
						ref weak_implementor_SetOnMarkerClickListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerClickListenerImplementor.__IsEmpty,
						__v => SetOnMarkerClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMarkerClickListener;

		global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerClickListenerImplementor __CreateIOnMarkerClickListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.MarkerDragEventArgs> MarkerDrag {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						__CreateIOnMarkerDragListenerImplementor,
						SetOnMarkerDragListener,
						__h => __h.OnMarkerDragHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListenerImplementor.__IsEmpty,
						__v => SetOnMarkerDragListener (null),
						__h => __h.OnMarkerDragHandler -= value);
			}
		}

		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.MarkerDragEndEventArgs> MarkerDragEnd {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						__CreateIOnMarkerDragListenerImplementor,
						SetOnMarkerDragListener,
						__h => __h.OnMarkerDragEndHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListenerImplementor.__IsEmpty,
						__v => SetOnMarkerDragListener (null),
						__h => __h.OnMarkerDragEndHandler -= value);
			}
		}

		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.MarkerDragStartEventArgs> MarkerDragStart {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						__CreateIOnMarkerDragListenerImplementor,
						SetOnMarkerDragListener,
						__h => __h.OnMarkerDragStartHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListenerImplementor.__IsEmpty,
						__v => SetOnMarkerDragListener (null),
						__h => __h.OnMarkerDragStartHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMarkerDragListener;

		global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListenerImplementor __CreateIOnMarkerDragListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Baidu.Mapapi.Map.BaiduMap.IOnMyLocationClickListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.MyLocationClickEventArgs> MyLocationClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMyLocationClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMyLocationClickListenerImplementor>(
						ref weak_implementor_SetOnMyLocationClickListener,
						__CreateIOnMyLocationClickListenerImplementor,
						SetOnMyLocationClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMyLocationClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMyLocationClickListenerImplementor>(
						ref weak_implementor_SetOnMyLocationClickListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMyLocationClickListenerImplementor.__IsEmpty,
						__v => SetOnMyLocationClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMyLocationClickListener;

		global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMyLocationClickListenerImplementor __CreateIOnMyLocationClickListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMyLocationClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Baidu.Mapapi.Map.BaiduMap.IOnPolylineClickListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.PolylineClickEventArgs> PolylineClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnPolylineClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnPolylineClickListenerImplementor>(
						ref weak_implementor_SetOnPolylineClickListener,
						__CreateIOnPolylineClickListenerImplementor,
						SetOnPolylineClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnPolylineClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnPolylineClickListenerImplementor>(
						ref weak_implementor_SetOnPolylineClickListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnPolylineClickListenerImplementor.__IsEmpty,
						__v => SetOnPolylineClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnPolylineClickListener;

		global::Com.Baidu.Mapapi.Map.BaiduMap.IOnPolylineClickListenerImplementor __CreateIOnPolylineClickListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Map.BaiduMap.IOnPolylineClickListenerImplementor (this);
		}
#endregion
	}
}
