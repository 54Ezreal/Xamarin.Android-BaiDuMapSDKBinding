using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='FileTileProvider']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/FileTileProvider", DoNotGenerateAcw=true)]
	public abstract partial class FileTileProvider : global::Java.Lang.Object, global::Com.Baidu.Mapapi.Map.ITileProvider {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/FileTileProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileTileProvider); }
		}

		protected FileTileProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='FileTileProvider']/constructor[@name='FileTileProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FileTileProvider ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (FileTileProvider)) {
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

		static Delegate cb_getTile_III;
#pragma warning disable 0169
		static Delegate GetGetTile_IIIHandler ()
		{
			if (cb_getTile_III == null)
				cb_getTile_III = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, IntPtr>) n_GetTile_III);
			return cb_getTile_III;
		}

		static IntPtr n_GetTile_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::Com.Baidu.Mapapi.Map.FileTileProvider __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.FileTileProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetTile (p0, p1, p2));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='FileTileProvider']/method[@name='getTile' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getTile", "(III)Lcom/baidu/mapapi/map/Tile;", "GetGetTile_IIIHandler")]
		public abstract global::Com.Baidu.Mapapi.Map.Tile GetTile (int p0, int p1, int p2);

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
			global::Com.Baidu.Mapapi.Map.FileTileProvider __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.FileTileProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxDisLevel;
		}
#pragma warning restore 0169

		public abstract int MaxDisLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='FileTileProvider']/method[@name='getMaxDisLevel' and count(parameter)=0]"
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
			global::Com.Baidu.Mapapi.Map.FileTileProvider __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.FileTileProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinDisLevel;
		}
#pragma warning restore 0169

		public abstract int MinDisLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='FileTileProvider']/method[@name='getMinDisLevel' and count(parameter)=0]"
			[Register ("getMinDisLevel", "()I", "GetGetMinDisLevelHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/baidu/mapapi/map/FileTileProvider", DoNotGenerateAcw=true)]
	internal partial class FileTileProviderInvoker : FileTileProvider {

		public FileTileProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileTileProviderInvoker); }
		}

		static IntPtr id_getTile_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='FileTileProvider']/method[@name='getTile' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getTile", "(III)Lcom/baidu/mapapi/map/Tile;", "GetGetTile_IIIHandler")]
		public override unsafe global::Com.Baidu.Mapapi.Map.Tile GetTile (int p0, int p1, int p2)
		{
			if (id_getTile_III == IntPtr.Zero)
				id_getTile_III = JNIEnv.GetMethodID (class_ref, "getTile", "(III)Lcom/baidu/mapapi/map/Tile;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Tile> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTile_III, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getMaxDisLevel;
		public override unsafe int MaxDisLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='FileTileProvider']/method[@name='getMaxDisLevel' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='FileTileProvider']/method[@name='getMinDisLevel' and count(parameter)=0]"
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
