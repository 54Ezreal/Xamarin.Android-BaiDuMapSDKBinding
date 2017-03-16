using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Favorite {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoritePoiInfo']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/favorite/FavoritePoiInfo", DoNotGenerateAcw=true)]
	public partial class FavoritePoiInfo : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/favorite/FavoritePoiInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FavoritePoiInfo); }
		}

		protected FavoritePoiInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoritePoiInfo']/constructor[@name='FavoritePoiInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FavoritePoiInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (FavoritePoiInfo)) {
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

		static Delegate cb_getAddr;
#pragma warning disable 0169
		static Delegate GetGetAddrHandler ()
		{
			if (cb_getAddr == null)
				cb_getAddr = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAddr);
			return cb_getAddr;
		}

		static IntPtr n_GetAddr (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Addr);
		}
#pragma warning restore 0169

		static IntPtr id_getAddr;
		public virtual unsafe string Addr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoritePoiInfo']/method[@name='getAddr' and count(parameter)=0]"
			[Register ("getAddr", "()Ljava/lang/String;", "GetGetAddrHandler")]
			get {
				if (id_getAddr == IntPtr.Zero)
					id_getAddr = JNIEnv.GetMethodID (class_ref, "getAddr", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAddr), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAddr", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCityName;
#pragma warning disable 0169
		static Delegate GetGetCityNameHandler ()
		{
			if (cb_getCityName == null)
				cb_getCityName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCityName);
			return cb_getCityName;
		}

		static IntPtr n_GetCityName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CityName);
		}
#pragma warning restore 0169

		static IntPtr id_getCityName;
		public virtual unsafe string CityName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoritePoiInfo']/method[@name='getCityName' and count(parameter)=0]"
			[Register ("getCityName", "()Ljava/lang/String;", "GetGetCityNameHandler")]
			get {
				if (id_getCityName == IntPtr.Zero)
					id_getCityName = JNIEnv.GetMethodID (class_ref, "getCityName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCityName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCityName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getID;
#pragma warning disable 0169
		static Delegate GetGetIDHandler ()
		{
			if (cb_getID == null)
				cb_getID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetID);
			return cb_getID;
		}

		static IntPtr n_GetID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ID);
		}
#pragma warning restore 0169

		static IntPtr id_getID;
		public virtual unsafe string ID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoritePoiInfo']/method[@name='getID' and count(parameter)=0]"
			[Register ("getID", "()Ljava/lang/String;", "GetGetIDHandler")]
			get {
				if (id_getID == IntPtr.Zero)
					id_getID = JNIEnv.GetMethodID (class_ref, "getID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPoiName;
#pragma warning disable 0169
		static Delegate GetGetPoiNameHandler ()
		{
			if (cb_getPoiName == null)
				cb_getPoiName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPoiName);
			return cb_getPoiName;
		}

		static IntPtr n_GetPoiName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PoiName);
		}
#pragma warning restore 0169

		static IntPtr id_getPoiName;
		public virtual unsafe string PoiName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoritePoiInfo']/method[@name='getPoiName' and count(parameter)=0]"
			[Register ("getPoiName", "()Ljava/lang/String;", "GetGetPoiNameHandler")]
			get {
				if (id_getPoiName == IntPtr.Zero)
					id_getPoiName = JNIEnv.GetMethodID (class_ref, "getPoiName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPoiName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPoiName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPt;
#pragma warning disable 0169
		static Delegate GetGetPtHandler ()
		{
			if (cb_getPt == null)
				cb_getPt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPt);
			return cb_getPt;
		}

		static IntPtr n_GetPt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Pt);
		}
#pragma warning restore 0169

		static IntPtr id_getPt;
		public virtual unsafe global::Com.Baidu.Mapapi.Model.LatLng Pt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoritePoiInfo']/method[@name='getPt' and count(parameter)=0]"
			[Register ("getPt", "()Lcom/baidu/mapapi/model/LatLng;", "GetGetPtHandler")]
			get {
				if (id_getPt == IntPtr.Zero)
					id_getPt = JNIEnv.GetMethodID (class_ref, "getPt", "()Lcom/baidu/mapapi/model/LatLng;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPt", "()Lcom/baidu/mapapi/model/LatLng;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTimeStamp;
#pragma warning disable 0169
		static Delegate GetGetTimeStampHandler ()
		{
			if (cb_getTimeStamp == null)
				cb_getTimeStamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimeStamp);
			return cb_getTimeStamp;
		}

		static long n_GetTimeStamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeStamp;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeStamp;
		public virtual unsafe long TimeStamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoritePoiInfo']/method[@name='getTimeStamp' and count(parameter)=0]"
			[Register ("getTimeStamp", "()J", "GetGetTimeStampHandler")]
			get {
				if (id_getTimeStamp == IntPtr.Zero)
					id_getTimeStamp = JNIEnv.GetMethodID (class_ref, "getTimeStamp", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTimeStamp);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeStamp", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getUid;
#pragma warning disable 0169
		static Delegate GetGetUidHandler ()
		{
			if (cb_getUid == null)
				cb_getUid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUid);
			return cb_getUid;
		}

		static IntPtr n_GetUid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Uid);
		}
#pragma warning restore 0169

		static IntPtr id_getUid;
		public virtual unsafe string Uid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoritePoiInfo']/method[@name='getUid' and count(parameter)=0]"
			[Register ("getUid", "()Ljava/lang/String;", "GetGetUidHandler")]
			get {
				if (id_getUid == IntPtr.Zero)
					id_getUid = JNIEnv.GetMethodID (class_ref, "getUid", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUid), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUid", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addr_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvokeAddr_Ljava_lang_String_Handler ()
		{
			if (cb_addr_Ljava_lang_String_ == null)
				cb_addr_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeAddr_Ljava_lang_String_);
			return cb_addr_Ljava_lang_String_;
		}

		static IntPtr n_InvokeAddr_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeAddr (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addr_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoritePoiInfo']/method[@name='addr' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addr", "(Ljava/lang/String;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;", "GetInvokeAddr_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo InvokeAddr (string p0)
		{
			if (id_addr_Ljava_lang_String_ == IntPtr.Zero)
				id_addr_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addr", "(Ljava/lang/String;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addr_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addr", "(Ljava/lang/String;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_cityName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvokeCityName_Ljava_lang_String_Handler ()
		{
			if (cb_cityName_Ljava_lang_String_ == null)
				cb_cityName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeCityName_Ljava_lang_String_);
			return cb_cityName_Ljava_lang_String_;
		}

		static IntPtr n_InvokeCityName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeCityName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_cityName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoritePoiInfo']/method[@name='cityName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("cityName", "(Ljava/lang/String;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;", "GetInvokeCityName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo InvokeCityName (string p0)
		{
			if (id_cityName_Ljava_lang_String_ == IntPtr.Zero)
				id_cityName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "cityName", "(Ljava/lang/String;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cityName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cityName", "(Ljava/lang/String;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_poiName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvokePoiName_Ljava_lang_String_Handler ()
		{
			if (cb_poiName_Ljava_lang_String_ == null)
				cb_poiName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokePoiName_Ljava_lang_String_);
			return cb_poiName_Ljava_lang_String_;
		}

		static IntPtr n_InvokePoiName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokePoiName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_poiName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoritePoiInfo']/method[@name='poiName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("poiName", "(Ljava/lang/String;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;", "GetInvokePoiName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo InvokePoiName (string p0)
		{
			if (id_poiName_Ljava_lang_String_ == IntPtr.Zero)
				id_poiName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "poiName", "(Ljava/lang/String;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_poiName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "poiName", "(Ljava/lang/String;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_pt_Lcom_baidu_mapapi_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetInvokePt_Lcom_baidu_mapapi_model_LatLng_Handler ()
		{
			if (cb_pt_Lcom_baidu_mapapi_model_LatLng_ == null)
				cb_pt_Lcom_baidu_mapapi_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokePt_Lcom_baidu_mapapi_model_LatLng_);
			return cb_pt_Lcom_baidu_mapapi_model_LatLng_;
		}

		static IntPtr n_InvokePt_Lcom_baidu_mapapi_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokePt (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_pt_Lcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoritePoiInfo']/method[@name='pt' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("pt", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;", "GetInvokePt_Lcom_baidu_mapapi_model_LatLng_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo InvokePt (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			if (id_pt_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_pt_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "pt", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_pt_Lcom_baidu_mapapi_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pt", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_uid_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvokeUid_Ljava_lang_String_Handler ()
		{
			if (cb_uid_Ljava_lang_String_ == null)
				cb_uid_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeUid_Ljava_lang_String_);
			return cb_uid_Ljava_lang_String_;
		}

		static IntPtr n_InvokeUid_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeUid (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_uid_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoritePoiInfo']/method[@name='uid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("uid", "(Ljava/lang/String;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;", "GetInvokeUid_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo InvokeUid (string p0)
		{
			if (id_uid_Ljava_lang_String_ == IntPtr.Zero)
				id_uid_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "uid", "(Ljava/lang/String;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_uid_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "uid", "(Ljava/lang/String;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
