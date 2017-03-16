using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Location {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.location']/interface[@name='BDLocationListener']"
	[Register ("com/baidu/location/BDLocationListener", "", "Com.Baidu.Location.IBDLocationListenerInvoker")]
	public partial interface IBDLocationListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/interface[@name='BDLocationListener']/method[@name='onConnectHotSpotMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("onConnectHotSpotMessage", "(Ljava/lang/String;I)V", "GetOnConnectHotSpotMessage_Ljava_lang_String_IHandler:Com.Baidu.Location.IBDLocationListenerInvoker, XamarinBaiDuMapSDKBinding")]
		void OnConnectHotSpotMessage (string p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/interface[@name='BDLocationListener']/method[@name='onReceiveLocation' and count(parameter)=1 and parameter[1][@type='com.baidu.location.BDLocation']]"
		[Register ("onReceiveLocation", "(Lcom/baidu/location/BDLocation;)V", "GetOnReceiveLocation_Lcom_baidu_location_BDLocation_Handler:Com.Baidu.Location.IBDLocationListenerInvoker, XamarinBaiDuMapSDKBinding")]
		void OnReceiveLocation (global::Com.Baidu.Location.BDLocation p0);

	}

	[global::Android.Runtime.Register ("com/baidu/location/BDLocationListener", DoNotGenerateAcw=true)]
	internal class IBDLocationListenerInvoker : global::Java.Lang.Object, IBDLocationListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/location/BDLocationListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBDLocationListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBDLocationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBDLocationListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.baidu.location.BDLocationListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBDLocationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onConnectHotSpotMessage_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOnConnectHotSpotMessage_Ljava_lang_String_IHandler ()
		{
			if (cb_onConnectHotSpotMessage_Ljava_lang_String_I == null)
				cb_onConnectHotSpotMessage_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnConnectHotSpotMessage_Ljava_lang_String_I);
			return cb_onConnectHotSpotMessage_Ljava_lang_String_I;
		}

		static void n_OnConnectHotSpotMessage_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Baidu.Location.IBDLocationListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.IBDLocationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectHotSpotMessage (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onConnectHotSpotMessage_Ljava_lang_String_I;
		public unsafe void OnConnectHotSpotMessage (string p0, int p1)
		{
			if (id_onConnectHotSpotMessage_Ljava_lang_String_I == IntPtr.Zero)
				id_onConnectHotSpotMessage_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "onConnectHotSpotMessage", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectHotSpotMessage_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onReceiveLocation_Lcom_baidu_location_BDLocation_;
#pragma warning disable 0169
		static Delegate GetOnReceiveLocation_Lcom_baidu_location_BDLocation_Handler ()
		{
			if (cb_onReceiveLocation_Lcom_baidu_location_BDLocation_ == null)
				cb_onReceiveLocation_Lcom_baidu_location_BDLocation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnReceiveLocation_Lcom_baidu_location_BDLocation_);
			return cb_onReceiveLocation_Lcom_baidu_location_BDLocation_;
		}

		static void n_OnReceiveLocation_Lcom_baidu_location_BDLocation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Location.IBDLocationListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.IBDLocationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Location.BDLocation p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.BDLocation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnReceiveLocation (p0);
		}
#pragma warning restore 0169

		IntPtr id_onReceiveLocation_Lcom_baidu_location_BDLocation_;
		public unsafe void OnReceiveLocation (global::Com.Baidu.Location.BDLocation p0)
		{
			if (id_onReceiveLocation_Lcom_baidu_location_BDLocation_ == IntPtr.Zero)
				id_onReceiveLocation_Lcom_baidu_location_BDLocation_ = JNIEnv.GetMethodID (class_ref, "onReceiveLocation", "(Lcom/baidu/location/BDLocation;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReceiveLocation_Lcom_baidu_location_BDLocation_, __args);
		}

	}

	public partial class ConnectHotSpotMessageEventArgs : global::System.EventArgs {

		public ConnectHotSpotMessageEventArgs (string p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}
	}

	public partial class ReceiveLocationEventArgs : global::System.EventArgs {

		public ReceiveLocationEventArgs (global::Com.Baidu.Location.BDLocation p0)
		{
			this.p0 = p0;
		}

		global::Com.Baidu.Location.BDLocation p0;
		public global::Com.Baidu.Location.BDLocation P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/baidu/location/BDLocationListenerImplementor")]
	internal sealed partial class IBDLocationListenerImplementor : global::Java.Lang.Object, IBDLocationListener {

		object sender;

		public IBDLocationListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/location/BDLocationListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ConnectHotSpotMessageEventArgs> OnConnectHotSpotMessageHandler;
#pragma warning restore 0649

		public void OnConnectHotSpotMessage (string p0, int p1)
		{
			var __h = OnConnectHotSpotMessageHandler;
			if (__h != null)
				__h (sender, new ConnectHotSpotMessageEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<ReceiveLocationEventArgs> OnReceiveLocationHandler;
#pragma warning restore 0649

		public void OnReceiveLocation (global::Com.Baidu.Location.BDLocation p0)
		{
			var __h = OnReceiveLocationHandler;
			if (__h != null)
				__h (sender, new ReceiveLocationEventArgs (p0));
		}

		internal static bool __IsEmpty (IBDLocationListenerImplementor value)
		{
			return value.OnConnectHotSpotMessageHandler == null && value.OnReceiveLocationHandler == null;
		}
	}

}
