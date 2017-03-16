using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='AsyncHttpClient']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/http/AsyncHttpClient", DoNotGenerateAcw=true)]
	public partial class AsyncHttpClient : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/http/AsyncHttpClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncHttpClient); }
		}

		protected AsyncHttpClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='AsyncHttpClient']/constructor[@name='AsyncHttpClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AsyncHttpClient ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AsyncHttpClient)) {
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

		static Delegate cb_isAuthorized;
#pragma warning disable 0169
		static Delegate GetIsAuthorizedHandler ()
		{
			if (cb_isAuthorized == null)
				cb_isAuthorized = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAuthorized);
			return cb_isAuthorized;
		}

		static bool n_IsAuthorized (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Http.AsyncHttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.AsyncHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAuthorized;
		}
#pragma warning restore 0169

		static IntPtr id_isAuthorized;
		protected virtual unsafe bool IsAuthorized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='AsyncHttpClient']/method[@name='isAuthorized' and count(parameter)=0]"
			[Register ("isAuthorized", "()Z", "GetIsAuthorizedHandler")]
			get {
				if (id_isAuthorized == IntPtr.Zero)
					id_isAuthorized = JNIEnv.GetMethodID (class_ref, "isAuthorized", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAuthorized);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAuthorized", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_get_Ljava_lang_String_Lcom_baidu_mapapi_http_HttpClient_ProtoResultCallback_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Lcom_baidu_mapapi_http_HttpClient_ProtoResultCallback_Handler ()
		{
			if (cb_get_Ljava_lang_String_Lcom_baidu_mapapi_http_HttpClient_ProtoResultCallback_ == null)
				cb_get_Ljava_lang_String_Lcom_baidu_mapapi_http_HttpClient_ProtoResultCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_Lcom_baidu_mapapi_http_HttpClient_ProtoResultCallback_);
			return cb_get_Ljava_lang_String_Lcom_baidu_mapapi_http_HttpClient_ProtoResultCallback_;
		}

		static void n_Get_Ljava_lang_String_Lcom_baidu_mapapi_http_HttpClient_ProtoResultCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Baidu.Mapapi.Http.AsyncHttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.AsyncHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Http.HttpClient.ProtoResultCallback p1 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.HttpClient.ProtoResultCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Get (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_Lcom_baidu_mapapi_http_HttpClient_ProtoResultCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='AsyncHttpClient']/method[@name='get' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.baidu.mapapi.http.HttpClient.ProtoResultCallback']]"
		[Register ("get", "(Ljava/lang/String;Lcom/baidu/mapapi/http/HttpClient$ProtoResultCallback;)V", "GetGet_Ljava_lang_String_Lcom_baidu_mapapi_http_HttpClient_ProtoResultCallback_Handler")]
		public virtual unsafe void Get (string p0, global::Com.Baidu.Mapapi.Http.HttpClient.ProtoResultCallback p1)
		{
			if (id_get_Ljava_lang_String_Lcom_baidu_mapapi_http_HttpClient_ProtoResultCallback_ == IntPtr.Zero)
				id_get_Ljava_lang_String_Lcom_baidu_mapapi_http_HttpClient_ProtoResultCallback_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;Lcom/baidu/mapapi/http/HttpClient$ProtoResultCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_Lcom_baidu_mapapi_http_HttpClient_ProtoResultCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;Lcom/baidu/mapapi/http/HttpClient$ProtoResultCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
