using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map.Offline {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/interface[@name='MKOfflineMapListener']"
	[Register ("com/baidu/mapapi/map/offline/MKOfflineMapListener", "", "Com.Baidu.Mapapi.Map.Offline.IMKOfflineMapListenerInvoker")]
	public partial interface IMKOfflineMapListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/interface[@name='MKOfflineMapListener']/method[@name='onGetOfflineMapState' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onGetOfflineMapState", "(II)V", "GetOnGetOfflineMapState_IIHandler:Com.Baidu.Mapapi.Map.Offline.IMKOfflineMapListenerInvoker, XamarinBaiDuMapSDKBinding")]
		void OnGetOfflineMapState (int p0, int p1);

	}

	[global::Android.Runtime.Register ("com/baidu/mapapi/map/offline/MKOfflineMapListener", DoNotGenerateAcw=true)]
	internal class IMKOfflineMapListenerInvoker : global::Java.Lang.Object, IMKOfflineMapListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/mapapi/map/offline/MKOfflineMapListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMKOfflineMapListenerInvoker); }
		}

		IntPtr class_ref;

		public static IMKOfflineMapListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMKOfflineMapListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.offline.MKOfflineMapListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMKOfflineMapListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onGetOfflineMapState_II;
#pragma warning disable 0169
		static Delegate GetOnGetOfflineMapState_IIHandler ()
		{
			if (cb_onGetOfflineMapState_II == null)
				cb_onGetOfflineMapState_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnGetOfflineMapState_II);
			return cb_onGetOfflineMapState_II;
		}

		static void n_OnGetOfflineMapState_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Baidu.Mapapi.Map.Offline.IMKOfflineMapListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Offline.IMKOfflineMapListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnGetOfflineMapState (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onGetOfflineMapState_II;
		public unsafe void OnGetOfflineMapState (int p0, int p1)
		{
			if (id_onGetOfflineMapState_II == IntPtr.Zero)
				id_onGetOfflineMapState_II = JNIEnv.GetMethodID (class_ref, "onGetOfflineMapState", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onGetOfflineMapState_II, __args);
		}

	}

	public partial class MKOfflineMapEventArgs : global::System.EventArgs {

		public MKOfflineMapEventArgs (int p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/baidu/mapapi/map/offline/MKOfflineMapListenerImplementor")]
	internal sealed partial class IMKOfflineMapListenerImplementor : global::Java.Lang.Object, IMKOfflineMapListener {

		object sender;

		public IMKOfflineMapListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/map/offline/MKOfflineMapListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<MKOfflineMapEventArgs> Handler;
#pragma warning restore 0649

		public void OnGetOfflineMapState (int p0, int p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new MKOfflineMapEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IMKOfflineMapListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
