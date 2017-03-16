using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UrlTileProvider']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/UrlTileProvider", DoNotGenerateAcw=true)]
	public abstract partial class UrlTileProvider : global::Java.Lang.Object, global::Com.Baidu.Mapapi.Map.ITileProvider {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/UrlTileProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UrlTileProvider); }
		}

		protected UrlTileProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UrlTileProvider']/constructor[@name='UrlTileProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UrlTileProvider ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UrlTileProvider)) {
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

		static Delegate cb_getTileUrl;
#pragma warning disable 0169
		static Delegate GetGetTileUrlHandler ()
		{
			if (cb_getTileUrl == null)
				cb_getTileUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTileUrl);
			return cb_getTileUrl;
		}

		static IntPtr n_GetTileUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.UrlTileProvider __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.UrlTileProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TileUrl);
		}
#pragma warning restore 0169

		public abstract string TileUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UrlTileProvider']/method[@name='getTileUrl' and count(parameter)=0]"
			[Register ("getTileUrl", "()Ljava/lang/String;", "GetGetTileUrlHandler")] get;
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
			global::Com.Baidu.Mapapi.Map.UrlTileProvider __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.UrlTileProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxDisLevel;
		}
#pragma warning restore 0169

		public abstract int MaxDisLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UrlTileProvider']/method[@name='getMaxDisLevel' and count(parameter)=0]"
			[Register ("getMaxDisLevel", "()I", "GetGetMaxDisLevelHandler")] get;
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
			global::Com.Baidu.Mapapi.Map.UrlTileProvider __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.UrlTileProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinDisLevel;
		}
#pragma warning restore 0169

		public abstract int MinDisLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UrlTileProvider']/method[@name='getMinDisLevel' and count(parameter)=0]"
			[Register ("getMinDisLevel", "()I", "GetGetMinDisLevelHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/baidu/mapapi/map/UrlTileProvider", DoNotGenerateAcw=true)]
	internal partial class UrlTileProviderInvoker : UrlTileProvider {

		public UrlTileProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (UrlTileProviderInvoker); }
		}

		static IntPtr id_getTileUrl;
		public override unsafe string TileUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UrlTileProvider']/method[@name='getTileUrl' and count(parameter)=0]"
			[Register ("getTileUrl", "()Ljava/lang/String;", "GetGetTileUrlHandler")]
			get {
				if (id_getTileUrl == IntPtr.Zero)
					id_getTileUrl = JNIEnv.GetMethodID (class_ref, "getTileUrl", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTileUrl), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMaxDisLevel;
		public override unsafe int MaxDisLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UrlTileProvider']/method[@name='getMaxDisLevel' and count(parameter)=0]"
			[Register ("getMaxDisLevel", "()I", "GetGetMaxDisLevelHandler")]
			get {
				if (id_getMaxDisLevel == IntPtr.Zero)
					id_getMaxDisLevel = JNIEnv.GetMethodID (class_ref, "getMaxDisLevel", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxDisLevel);
				} finally {
				}
			}
		}

		static IntPtr id_getMinDisLevel;
		public override unsafe int MinDisLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UrlTileProvider']/method[@name='getMinDisLevel' and count(parameter)=0]"
			[Register ("getMinDisLevel", "()I", "GetGetMinDisLevelHandler")]
			get {
				if (id_getMinDisLevel == IntPtr.Zero)
					id_getMinDisLevel = JNIEnv.GetMethodID (class_ref, "getMinDisLevel", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMinDisLevel);
				} finally {
				}
			}
		}

	}

}
