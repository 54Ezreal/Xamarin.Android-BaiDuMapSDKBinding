using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TileOverlay']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/TileOverlay", DoNotGenerateAcw=true)]
	public sealed partial class TileOverlay : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/TileOverlay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TileOverlay); }
		}

		internal TileOverlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_baidu_mapapi_map_BaiduMap_Lcom_baidu_mapapi_map_TileProvider_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TileOverlay']/constructor[@name='TileOverlay' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap'] and parameter[2][@type='com.baidu.mapapi.map.TileProvider']]"
		[Register (".ctor", "(Lcom/baidu/mapapi/map/BaiduMap;Lcom/baidu/mapapi/map/TileProvider;)V", "")]
		public unsafe TileOverlay (global::Com.Baidu.Mapapi.Map.BaiduMap p0, global::Com.Baidu.Mapapi.Map.ITileProvider p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (TileOverlay)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/baidu/mapapi/map/BaiduMap;Lcom/baidu/mapapi/map/TileProvider;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/baidu/mapapi/map/BaiduMap;Lcom/baidu/mapapi/map/TileProvider;)V", __args);
					return;
				}

				if (id_ctor_Lcom_baidu_mapapi_map_BaiduMap_Lcom_baidu_mapapi_map_TileProvider_ == IntPtr.Zero)
					id_ctor_Lcom_baidu_mapapi_map_BaiduMap_Lcom_baidu_mapapi_map_TileProvider_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/baidu/mapapi/map/BaiduMap;Lcom/baidu/mapapi/map/TileProvider;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_baidu_mapapi_map_BaiduMap_Lcom_baidu_mapapi_map_TileProvider_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_baidu_mapapi_map_BaiduMap_Lcom_baidu_mapapi_map_TileProvider_, __args);
			} finally {
			}
		}

		static IntPtr id_clearTileCache;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TileOverlay']/method[@name='clearTileCache' and count(parameter)=0]"
		[Register ("clearTileCache", "()Z", "")]
		public unsafe bool ClearTileCache ()
		{
			if (id_clearTileCache == IntPtr.Zero)
				id_clearTileCache = JNIEnv.GetMethodID (class_ref, "clearTileCache", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_clearTileCache);
			} finally {
			}
		}

		static IntPtr id_removeTileOverlay;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TileOverlay']/method[@name='removeTileOverlay' and count(parameter)=0]"
		[Register ("removeTileOverlay", "()V", "")]
		public unsafe void RemoveTileOverlay ()
		{
			if (id_removeTileOverlay == IntPtr.Zero)
				id_removeTileOverlay = JNIEnv.GetMethodID (class_ref, "removeTileOverlay", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeTileOverlay);
			} finally {
			}
		}

	}
}
