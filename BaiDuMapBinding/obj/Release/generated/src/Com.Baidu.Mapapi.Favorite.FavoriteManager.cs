using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Favorite {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoriteManager']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/favorite/FavoriteManager", DoNotGenerateAcw=true)]
	public partial class FavoriteManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/favorite/FavoriteManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FavoriteManager); }
		}

		protected FavoriteManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAllFavPois;
#pragma warning disable 0169
		static Delegate GetGetAllFavPoisHandler ()
		{
			if (cb_getAllFavPois == null)
				cb_getAllFavPois = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllFavPois);
			return cb_getAllFavPois;
		}

		static IntPtr n_GetAllFavPois (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoriteManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoriteManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo>.ToLocalJniHandle (__this.AllFavPois);
		}
#pragma warning restore 0169

		static IntPtr id_getAllFavPois;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> AllFavPois {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoriteManager']/method[@name='getAllFavPois' and count(parameter)=0]"
			[Register ("getAllFavPois", "()Ljava/util/List;", "GetGetAllFavPoisHandler")]
			get {
				if (id_getAllFavPois == IntPtr.Zero)
					id_getAllFavPois = JNIEnv.GetMethodID (class_ref, "getAllFavPois", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllFavPois), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllFavPois", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Baidu.Mapapi.Favorite.FavoriteManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoriteManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/baidu/mapapi/favorite/FavoriteManager;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/baidu/mapapi/favorite/FavoriteManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoriteManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_add_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_;
#pragma warning disable 0169
		static Delegate GetAdd_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_Handler ()
		{
			if (cb_add_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_ == null)
				cb_add_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Add_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_);
			return cb_add_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_;
		}

		static int n_Add_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoriteManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoriteManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Add (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_add_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoriteManager']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.favorite.FavoritePoiInfo']]"
		[Register ("add", "(Lcom/baidu/mapapi/favorite/FavoritePoiInfo;)I", "GetAdd_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_Handler")]
		public virtual unsafe int Add (global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo p0)
		{
			if (id_add_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_ == IntPtr.Zero)
				id_add_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_ = JNIEnv.GetMethodID (class_ref, "add", "(Lcom/baidu/mapapi/favorite/FavoritePoiInfo;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_add_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lcom/baidu/mapapi/favorite/FavoritePoiInfo;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_clearAllFavPois;
#pragma warning disable 0169
		static Delegate GetClearAllFavPoisHandler ()
		{
			if (cb_clearAllFavPois == null)
				cb_clearAllFavPois = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ClearAllFavPois);
			return cb_clearAllFavPois;
		}

		static bool n_ClearAllFavPois (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoriteManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoriteManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ClearAllFavPois ();
		}
#pragma warning restore 0169

		static IntPtr id_clearAllFavPois;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoriteManager']/method[@name='clearAllFavPois' and count(parameter)=0]"
		[Register ("clearAllFavPois", "()Z", "GetClearAllFavPoisHandler")]
		public virtual unsafe bool ClearAllFavPois ()
		{
			if (id_clearAllFavPois == IntPtr.Zero)
				id_clearAllFavPois = JNIEnv.GetMethodID (class_ref, "clearAllFavPois", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_clearAllFavPois);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearAllFavPois", "()Z"));
			} finally {
			}
		}

		static Delegate cb_deleteFavPoi_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteFavPoi_Ljava_lang_String_Handler ()
		{
			if (cb_deleteFavPoi_Ljava_lang_String_ == null)
				cb_deleteFavPoi_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DeleteFavPoi_Ljava_lang_String_);
			return cb_deleteFavPoi_Ljava_lang_String_;
		}

		static bool n_DeleteFavPoi_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoriteManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoriteManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DeleteFavPoi (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteFavPoi_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoriteManager']/method[@name='deleteFavPoi' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteFavPoi", "(Ljava/lang/String;)Z", "GetDeleteFavPoi_Ljava_lang_String_Handler")]
		public virtual unsafe bool DeleteFavPoi (string p0)
		{
			if (id_deleteFavPoi_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteFavPoi_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteFavPoi", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_deleteFavPoi_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteFavPoi", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoriteManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoriteManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoriteManager']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroy);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destroy", "()V"));
			} finally {
			}
		}

		static Delegate cb_getFavPoi_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFavPoi_Ljava_lang_String_Handler ()
		{
			if (cb_getFavPoi_Ljava_lang_String_ == null)
				cb_getFavPoi_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetFavPoi_Ljava_lang_String_);
			return cb_getFavPoi_Ljava_lang_String_;
		}

		static IntPtr n_GetFavPoi_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoriteManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoriteManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetFavPoi (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getFavPoi_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoriteManager']/method[@name='getFavPoi' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFavPoi", "(Ljava/lang/String;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;", "GetGetFavPoi_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo GetFavPoi (string p0)
		{
			if (id_getFavPoi_Ljava_lang_String_ == IntPtr.Zero)
				id_getFavPoi_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getFavPoi", "(Ljava/lang/String;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFavPoi_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFavPoi", "(Ljava/lang/String;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_init;
#pragma warning disable 0169
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Init);
			return cb_init;
		}

		static void n_Init (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoriteManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoriteManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoriteManager']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		public virtual unsafe void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetMethodID (class_ref, "init", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "()V"));
			} finally {
			}
		}

		static Delegate cb_updateFavPoi_Ljava_lang_String_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_;
#pragma warning disable 0169
		static Delegate GetUpdateFavPoi_Ljava_lang_String_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_Handler ()
		{
			if (cb_updateFavPoi_Ljava_lang_String_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_ == null)
				cb_updateFavPoi_Ljava_lang_String_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_UpdateFavPoi_Ljava_lang_String_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_);
			return cb_updateFavPoi_Ljava_lang_String_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_;
		}

		static bool n_UpdateFavPoi_Ljava_lang_String_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoriteManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoriteManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo p1 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateFavPoi (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateFavPoi_Ljava_lang_String_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoriteManager']/method[@name='updateFavPoi' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.baidu.mapapi.favorite.FavoritePoiInfo']]"
		[Register ("updateFavPoi", "(Ljava/lang/String;Lcom/baidu/mapapi/favorite/FavoritePoiInfo;)Z", "GetUpdateFavPoi_Ljava_lang_String_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_Handler")]
		public virtual unsafe bool UpdateFavPoi (string p0, global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo p1)
		{
			if (id_updateFavPoi_Ljava_lang_String_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_ == IntPtr.Zero)
				id_updateFavPoi_Ljava_lang_String_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_ = JNIEnv.GetMethodID (class_ref, "updateFavPoi", "(Ljava/lang/String;Lcom/baidu/mapapi/favorite/FavoritePoiInfo;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_updateFavPoi_Ljava_lang_String_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateFavPoi", "(Ljava/lang/String;Lcom/baidu/mapapi/favorite/FavoritePoiInfo;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
