using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='TileProvider']"
	[Register ("com/baidu/mapapi/map/TileProvider", "", "Com.Baidu.Mapapi.Map.ITileProviderInvoker")]
	public partial interface ITileProvider : IJavaObject {

		int MaxDisLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='TileProvider']/method[@name='getMaxDisLevel' and count(parameter)=0]"
			[Register ("getMaxDisLevel", "()I", "GetGetMaxDisLevelHandler:Com.Baidu.Mapapi.Map.ITileProviderInvoker, BaiDuMapBinding")] get;
		}

		int MinDisLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='TileProvider']/method[@name='getMinDisLevel' and count(parameter)=0]"
			[Register ("getMinDisLevel", "()I", "GetGetMinDisLevelHandler:Com.Baidu.Mapapi.Map.ITileProviderInvoker, BaiDuMapBinding")] get;
		}

	}

	[global::Android.Runtime.Register ("com/baidu/mapapi/map/TileProvider", DoNotGenerateAcw=true)]
	internal class ITileProviderInvoker : global::Java.Lang.Object, ITileProvider {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/mapapi/map/TileProvider");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITileProviderInvoker); }
		}

		IntPtr class_ref;

		public static ITileProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITileProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.TileProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITileProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getMaxDisLevel;
#pragma warning disable 0169
		static Delegate GetGetMaxDisLevelHandler ()
		{
			if (cb_getMaxDisLevel == null)
				cb_getMaxDisLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxDisLevel);
			return cb_getMaxDisLevel;
		}

		static int n_GetMaxDisLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.ITileProvider __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.ITileProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxDisLevel;
		}
#pragma warning restore 0169

		IntPtr id_getMaxDisLevel;
		public unsafe int MaxDisLevel {
			get {
				if (id_getMaxDisLevel == IntPtr.Zero)
					id_getMaxDisLevel = JNIEnv.GetMethodID (class_ref, "getMaxDisLevel", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxDisLevel);
			}
		}

		static Delegate cb_getMinDisLevel;
#pragma warning disable 0169
		static Delegate GetGetMinDisLevelHandler ()
		{
			if (cb_getMinDisLevel == null)
				cb_getMinDisLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMinDisLevel);
			return cb_getMinDisLevel;
		}

		static int n_GetMinDisLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.ITileProvider __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.ITileProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinDisLevel;
		}
#pragma warning restore 0169

		IntPtr id_getMinDisLevel;
		public unsafe int MinDisLevel {
			get {
				if (id_getMinDisLevel == IntPtr.Zero)
					id_getMinDisLevel = JNIEnv.GetMethodID (class_ref, "getMinDisLevel", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMinDisLevel);
			}
		}

	}

}
