using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/http/HttpClient", DoNotGenerateAcw=true)]
	public partial class HttpClient : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient.HttpStateError']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/http/HttpClient$HttpStateError", DoNotGenerateAcw=true)]
		public sealed partial class HttpStateError : global::Java.Lang.Enum {


			static IntPtr INNER_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient.HttpStateError']/field[@name='INNER_ERROR']"
			[Register ("INNER_ERROR")]
			public static global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError InnerError {
				get {
					if (INNER_ERROR_jfieldId == IntPtr.Zero)
						INNER_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INNER_ERROR", "Lcom/baidu/mapapi/http/HttpClient$HttpStateError;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INNER_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NETWORK_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient.HttpStateError']/field[@name='NETWORK_ERROR']"
			[Register ("NETWORK_ERROR")]
			public static global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError NetworkError {
				get {
					if (NETWORK_ERROR_jfieldId == IntPtr.Zero)
						NETWORK_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_ERROR", "Lcom/baidu/mapapi/http/HttpClient$HttpStateError;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NO_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient.HttpStateError']/field[@name='NO_ERROR']"
			[Register ("NO_ERROR")]
			public static global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError NoError {
				get {
					if (NO_ERROR_jfieldId == IntPtr.Zero)
						NO_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_ERROR", "Lcom/baidu/mapapi/http/HttpClient$HttpStateError;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REQUEST_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient.HttpStateError']/field[@name='REQUEST_ERROR']"
			[Register ("REQUEST_ERROR")]
			public static global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError RequestError {
				get {
					if (REQUEST_ERROR_jfieldId == IntPtr.Zero)
						REQUEST_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REQUEST_ERROR", "Lcom/baidu/mapapi/http/HttpClient$HttpStateError;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REQUEST_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SERVER_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient.HttpStateError']/field[@name='SERVER_ERROR']"
			[Register ("SERVER_ERROR")]
			public static global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError ServerError {
				get {
					if (SERVER_ERROR_jfieldId == IntPtr.Zero)
						SERVER_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVER_ERROR", "Lcom/baidu/mapapi/http/HttpClient$HttpStateError;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SERVER_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/mapapi/http/HttpClient$HttpStateError", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HttpStateError); }
			}

			internal HttpStateError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient.HttpStateError']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/http/HttpClient$HttpStateError;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/http/HttpClient$HttpStateError;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient.HttpStateError']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/baidu/mapapi/http/HttpClient$HttpStateError;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/baidu/mapapi/http/HttpClient$HttpStateError;");
				try {
					return (global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient.ProtoResultCallback']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/http/HttpClient$ProtoResultCallback", DoNotGenerateAcw=true)]
		public abstract partial class ProtoResultCallback : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/mapapi/http/HttpClient$ProtoResultCallback", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ProtoResultCallback); }
			}

			protected ProtoResultCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient.ProtoResultCallback']/constructor[@name='HttpClient.ProtoResultCallback' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ProtoResultCallback ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (ProtoResultCallback)) {
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

			static Delegate cb_onFailed_Lcom_baidu_mapapi_http_HttpClient_HttpStateError_;
#pragma warning disable 0169
			static Delegate GetOnFailed_Lcom_baidu_mapapi_http_HttpClient_HttpStateError_Handler ()
			{
				if (cb_onFailed_Lcom_baidu_mapapi_http_HttpClient_HttpStateError_ == null)
					cb_onFailed_Lcom_baidu_mapapi_http_HttpClient_HttpStateError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFailed_Lcom_baidu_mapapi_http_HttpClient_HttpStateError_);
				return cb_onFailed_Lcom_baidu_mapapi_http_HttpClient_HttpStateError_;
			}

			static void n_OnFailed_Lcom_baidu_mapapi_http_HttpClient_HttpStateError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Http.HttpClient.ProtoResultCallback __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.HttpClient.ProtoResultCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFailed (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient.ProtoResultCallback']/method[@name='onFailed' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.http.HttpClient.HttpStateError']]"
			[Register ("onFailed", "(Lcom/baidu/mapapi/http/HttpClient$HttpStateError;)V", "GetOnFailed_Lcom_baidu_mapapi_http_HttpClient_HttpStateError_Handler")]
			public abstract void OnFailed (global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError p0);

			static Delegate cb_onSuccess_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnSuccess_Ljava_lang_String_Handler ()
			{
				if (cb_onSuccess_Ljava_lang_String_ == null)
					cb_onSuccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Ljava_lang_String_);
				return cb_onSuccess_Ljava_lang_String_;
			}

			static void n_OnSuccess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Http.HttpClient.ProtoResultCallback __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.HttpClient.ProtoResultCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient.ProtoResultCallback']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onSuccess", "(Ljava/lang/String;)V", "GetOnSuccess_Ljava_lang_String_Handler")]
			public abstract void OnSuccess (string p0);

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/http/HttpClient$ProtoResultCallback", DoNotGenerateAcw=true)]
		internal partial class ProtoResultCallbackInvoker : ProtoResultCallback {

			public ProtoResultCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (ProtoResultCallbackInvoker); }
			}

			static IntPtr id_onFailed_Lcom_baidu_mapapi_http_HttpClient_HttpStateError_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient.ProtoResultCallback']/method[@name='onFailed' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.http.HttpClient.HttpStateError']]"
			[Register ("onFailed", "(Lcom/baidu/mapapi/http/HttpClient$HttpStateError;)V", "GetOnFailed_Lcom_baidu_mapapi_http_HttpClient_HttpStateError_Handler")]
			public override unsafe void OnFailed (global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError p0)
			{
				if (id_onFailed_Lcom_baidu_mapapi_http_HttpClient_HttpStateError_ == IntPtr.Zero)
					id_onFailed_Lcom_baidu_mapapi_http_HttpClient_HttpStateError_ = JNIEnv.GetMethodID (class_ref, "onFailed", "(Lcom/baidu/mapapi/http/HttpClient$HttpStateError;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailed_Lcom_baidu_mapapi_http_HttpClient_HttpStateError_, __args);
				} finally {
				}
			}

			static IntPtr id_onSuccess_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient.ProtoResultCallback']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onSuccess", "(Ljava/lang/String;)V", "GetOnSuccess_Ljava_lang_String_Handler")]
			public override unsafe void OnSuccess (string p0)
			{
				if (id_onSuccess_Ljava_lang_String_ == IntPtr.Zero)
					id_onSuccess_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/http/HttpClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpClient); }
		}

		protected HttpClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_baidu_mapapi_http_HttpClient_ProtoResultCallback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient']/constructor[@name='HttpClient' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.baidu.mapapi.http.HttpClient.ProtoResultCallback']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/baidu/mapapi/http/HttpClient$ProtoResultCallback;)V", "")]
		public unsafe HttpClient (string p0, global::Com.Baidu.Mapapi.Http.HttpClient.ProtoResultCallback p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (HttpClient)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Lcom/baidu/mapapi/http/HttpClient$ProtoResultCallback;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lcom/baidu/mapapi/http/HttpClient$ProtoResultCallback;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_baidu_mapapi_http_HttpClient_ProtoResultCallback_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_baidu_mapapi_http_HttpClient_ProtoResultCallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/baidu/mapapi/http/HttpClient$ProtoResultCallback;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_baidu_mapapi_http_HttpClient_ProtoResultCallback_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_baidu_mapapi_http_HttpClient_ProtoResultCallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getAuthToken;
		public static unsafe string AuthToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient']/method[@name='getAuthToken' and count(parameter)=0]"
			[Register ("getAuthToken", "()Ljava/lang/String;", "GetGetAuthTokenHandler")]
			get {
				if (id_getAuthToken == IntPtr.Zero)
					id_getAuthToken = JNIEnv.GetStaticMethodID (class_ref, "getAuthToken", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAuthToken), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPhoneInfo;
		public static unsafe string PhoneInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient']/method[@name='getPhoneInfo' and count(parameter)=0]"
			[Register ("getPhoneInfo", "()Ljava/lang/String;", "GetGetPhoneInfoHandler")]
			get {
				if (id_getPhoneInfo == IntPtr.Zero)
					id_getPhoneInfo = JNIEnv.GetStaticMethodID (class_ref, "getPhoneInfo", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPhoneInfo), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_checkNetwork;
#pragma warning disable 0169
		static Delegate GetCheckNetworkHandler ()
		{
			if (cb_checkNetwork == null)
				cb_checkNetwork = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CheckNetwork);
			return cb_checkNetwork;
		}

		static bool n_CheckNetwork (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Http.HttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.HttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckNetwork ();
		}
#pragma warning restore 0169

		static IntPtr id_checkNetwork;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient']/method[@name='checkNetwork' and count(parameter)=0]"
		[Register ("checkNetwork", "()Z", "GetCheckNetworkHandler")]
		protected virtual unsafe bool CheckNetwork ()
		{
			if (id_checkNetwork == IntPtr.Zero)
				id_checkNetwork = JNIEnv.GetMethodID (class_ref, "checkNetwork", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_checkNetwork);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkNetwork", "()Z"));
			} finally {
			}
		}

		static Delegate cb_request_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRequest_Ljava_lang_String_Handler ()
		{
			if (cb_request_Ljava_lang_String_ == null)
				cb_request_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Request_Ljava_lang_String_);
			return cb_request_Ljava_lang_String_;
		}

		static void n_Request_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Http.HttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.HttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Request (p0);
		}
#pragma warning restore 0169

		static IntPtr id_request_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient']/method[@name='request' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("request", "(Ljava/lang/String;)V", "GetRequest_Ljava_lang_String_Handler")]
		protected virtual unsafe void Request (string p0)
		{
			if (id_request_Ljava_lang_String_ == IntPtr.Zero)
				id_request_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "request", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_request_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "request", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setMaxTimeOut_I;
#pragma warning disable 0169
		static Delegate GetSetMaxTimeOut_IHandler ()
		{
			if (cb_setMaxTimeOut_I == null)
				cb_setMaxTimeOut_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxTimeOut_I);
			return cb_setMaxTimeOut_I;
		}

		static void n_SetMaxTimeOut_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Http.HttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.HttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaxTimeOut (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMaxTimeOut_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient']/method[@name='setMaxTimeOut' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaxTimeOut", "(I)V", "GetSetMaxTimeOut_IHandler")]
		public virtual unsafe void SetMaxTimeOut (int p0)
		{
			if (id_setMaxTimeOut_I == IntPtr.Zero)
				id_setMaxTimeOut_I = JNIEnv.GetMethodID (class_ref, "setMaxTimeOut", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaxTimeOut_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxTimeOut", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setReadTimeOut_I;
#pragma warning disable 0169
		static Delegate GetSetReadTimeOut_IHandler ()
		{
			if (cb_setReadTimeOut_I == null)
				cb_setReadTimeOut_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetReadTimeOut_I);
			return cb_setReadTimeOut_I;
		}

		static void n_SetReadTimeOut_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Http.HttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.HttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetReadTimeOut (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setReadTimeOut_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient']/method[@name='setReadTimeOut' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setReadTimeOut", "(I)V", "GetSetReadTimeOut_IHandler")]
		public virtual unsafe void SetReadTimeOut (int p0)
		{
			if (id_setReadTimeOut_I == IntPtr.Zero)
				id_setReadTimeOut_I = JNIEnv.GetMethodID (class_ref, "setReadTimeOut", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setReadTimeOut_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReadTimeOut", "(I)V"), __args);
			} finally {
			}
		}

	}
}
