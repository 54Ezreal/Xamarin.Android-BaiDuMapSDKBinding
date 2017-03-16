using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.location']/class[@name='Address']"
	[global::Android.Runtime.Register ("com/baidu/location/Address", DoNotGenerateAcw=true)]
	public sealed partial class Address : global::Java.Lang.Object {


		static IntPtr AddressInfo_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='Address']/field[@name='AddressInfo']"
		[Register ("AddressInfo")]
		public string AddressInfo {
			get {
				if (AddressInfo_jfieldId == IntPtr.Zero)
					AddressInfo_jfieldId = JNIEnv.GetFieldID (class_ref, "AddressInfo", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, AddressInfo_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (AddressInfo_jfieldId == IntPtr.Zero)
					AddressInfo_jfieldId = JNIEnv.GetFieldID (class_ref, "AddressInfo", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, AddressInfo_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr city_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='Address']/field[@name='city']"
		[Register ("city")]
		public string City {
			get {
				if (city_jfieldId == IntPtr.Zero)
					city_jfieldId = JNIEnv.GetFieldID (class_ref, "city", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, city_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (city_jfieldId == IntPtr.Zero)
					city_jfieldId = JNIEnv.GetFieldID (class_ref, "city", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, city_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr cityCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='Address']/field[@name='cityCode']"
		[Register ("cityCode")]
		public string CityCode {
			get {
				if (cityCode_jfieldId == IntPtr.Zero)
					cityCode_jfieldId = JNIEnv.GetFieldID (class_ref, "cityCode", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, cityCode_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (cityCode_jfieldId == IntPtr.Zero)
					cityCode_jfieldId = JNIEnv.GetFieldID (class_ref, "cityCode", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cityCode_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr country_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='Address']/field[@name='country']"
		[Register ("country")]
		public string Country {
			get {
				if (country_jfieldId == IntPtr.Zero)
					country_jfieldId = JNIEnv.GetFieldID (class_ref, "country", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, country_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (country_jfieldId == IntPtr.Zero)
					country_jfieldId = JNIEnv.GetFieldID (class_ref, "country", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, country_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr countryCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='Address']/field[@name='countryCode']"
		[Register ("countryCode")]
		public string CountryCode {
			get {
				if (countryCode_jfieldId == IntPtr.Zero)
					countryCode_jfieldId = JNIEnv.GetFieldID (class_ref, "countryCode", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, countryCode_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (countryCode_jfieldId == IntPtr.Zero)
					countryCode_jfieldId = JNIEnv.GetFieldID (class_ref, "countryCode", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, countryCode_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr district_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='Address']/field[@name='district']"
		[Register ("district")]
		public string District {
			get {
				if (district_jfieldId == IntPtr.Zero)
					district_jfieldId = JNIEnv.GetFieldID (class_ref, "district", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, district_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (district_jfieldId == IntPtr.Zero)
					district_jfieldId = JNIEnv.GetFieldID (class_ref, "district", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, district_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr province_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='Address']/field[@name='province']"
		[Register ("province")]
		public string Province {
			get {
				if (province_jfieldId == IntPtr.Zero)
					province_jfieldId = JNIEnv.GetFieldID (class_ref, "province", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, province_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (province_jfieldId == IntPtr.Zero)
					province_jfieldId = JNIEnv.GetFieldID (class_ref, "province", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, province_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr street_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='Address']/field[@name='street']"
		[Register ("street")]
		public string Street {
			get {
				if (street_jfieldId == IntPtr.Zero)
					street_jfieldId = JNIEnv.GetFieldID (class_ref, "street", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, street_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (street_jfieldId == IntPtr.Zero)
					street_jfieldId = JNIEnv.GetFieldID (class_ref, "street", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, street_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr streetNumber_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='Address']/field[@name='streetNumber']"
		[Register ("streetNumber")]
		public string StreetNumber {
			get {
				if (streetNumber_jfieldId == IntPtr.Zero)
					streetNumber_jfieldId = JNIEnv.GetFieldID (class_ref, "streetNumber", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, streetNumber_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (streetNumber_jfieldId == IntPtr.Zero)
					streetNumber_jfieldId = JNIEnv.GetFieldID (class_ref, "streetNumber", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, streetNumber_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.location']/class[@name='Address.Builder']"
		[global::Android.Runtime.Register ("com/baidu/location/Address$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/location/Address$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.location']/class[@name='Address.Builder']/constructor[@name='Address.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Builder)) {
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

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Location.Address.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Address.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/baidu/location/Address;", "GetBuildHandler")]
			public virtual unsafe global::Com.Baidu.Location.Address Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/baidu/location/Address;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/baidu/location/Address;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_city_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetCity_Ljava_lang_String_Handler ()
			{
				if (cb_city_Ljava_lang_String_ == null)
					cb_city_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_City_Ljava_lang_String_);
				return cb_city_Ljava_lang_String_;
			}

			static IntPtr n_City_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Location.Address.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.City (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_city_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Address.Builder']/method[@name='city' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("city", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;", "GetCity_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Baidu.Location.Address.Builder City (string p0)
			{
				if (id_city_Ljava_lang_String_ == IntPtr.Zero)
					id_city_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "city", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Baidu.Location.Address.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_city_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "city", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_cityCode_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetCityCode_Ljava_lang_String_Handler ()
			{
				if (cb_cityCode_Ljava_lang_String_ == null)
					cb_cityCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CityCode_Ljava_lang_String_);
				return cb_cityCode_Ljava_lang_String_;
			}

			static IntPtr n_CityCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Location.Address.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CityCode (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_cityCode_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Address.Builder']/method[@name='cityCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("cityCode", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;", "GetCityCode_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Baidu.Location.Address.Builder CityCode (string p0)
			{
				if (id_cityCode_Ljava_lang_String_ == IntPtr.Zero)
					id_cityCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "cityCode", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Baidu.Location.Address.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cityCode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cityCode", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_country_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetCountry_Ljava_lang_String_Handler ()
			{
				if (cb_country_Ljava_lang_String_ == null)
					cb_country_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Country_Ljava_lang_String_);
				return cb_country_Ljava_lang_String_;
			}

			static IntPtr n_Country_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Location.Address.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Country (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_country_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Address.Builder']/method[@name='country' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("country", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;", "GetCountry_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Baidu.Location.Address.Builder Country (string p0)
			{
				if (id_country_Ljava_lang_String_ == IntPtr.Zero)
					id_country_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "country", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Baidu.Location.Address.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_country_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "country", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_countryCode_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetCountryCode_Ljava_lang_String_Handler ()
			{
				if (cb_countryCode_Ljava_lang_String_ == null)
					cb_countryCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CountryCode_Ljava_lang_String_);
				return cb_countryCode_Ljava_lang_String_;
			}

			static IntPtr n_CountryCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Location.Address.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CountryCode (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_countryCode_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Address.Builder']/method[@name='countryCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("countryCode", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;", "GetCountryCode_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Baidu.Location.Address.Builder CountryCode (string p0)
			{
				if (id_countryCode_Ljava_lang_String_ == IntPtr.Zero)
					id_countryCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "countryCode", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Baidu.Location.Address.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_countryCode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "countryCode", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_district_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetDistrict_Ljava_lang_String_Handler ()
			{
				if (cb_district_Ljava_lang_String_ == null)
					cb_district_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_District_Ljava_lang_String_);
				return cb_district_Ljava_lang_String_;
			}

			static IntPtr n_District_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Location.Address.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.District (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_district_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Address.Builder']/method[@name='district' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("district", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;", "GetDistrict_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Baidu.Location.Address.Builder District (string p0)
			{
				if (id_district_Ljava_lang_String_ == IntPtr.Zero)
					id_district_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "district", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Baidu.Location.Address.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_district_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "district", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_province_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetProvince_Ljava_lang_String_Handler ()
			{
				if (cb_province_Ljava_lang_String_ == null)
					cb_province_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Province_Ljava_lang_String_);
				return cb_province_Ljava_lang_String_;
			}

			static IntPtr n_Province_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Location.Address.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Province (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_province_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Address.Builder']/method[@name='province' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("province", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;", "GetProvince_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Baidu.Location.Address.Builder Province (string p0)
			{
				if (id_province_Ljava_lang_String_ == IntPtr.Zero)
					id_province_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "province", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Baidu.Location.Address.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_province_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "province", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_street_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetStreet_Ljava_lang_String_Handler ()
			{
				if (cb_street_Ljava_lang_String_ == null)
					cb_street_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Street_Ljava_lang_String_);
				return cb_street_Ljava_lang_String_;
			}

			static IntPtr n_Street_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Location.Address.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Street (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_street_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Address.Builder']/method[@name='street' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("street", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;", "GetStreet_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Baidu.Location.Address.Builder Street (string p0)
			{
				if (id_street_Ljava_lang_String_ == IntPtr.Zero)
					id_street_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "street", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Baidu.Location.Address.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_street_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "street", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_streetNumber_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetStreetNumber_Ljava_lang_String_Handler ()
			{
				if (cb_streetNumber_Ljava_lang_String_ == null)
					cb_streetNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_StreetNumber_Ljava_lang_String_);
				return cb_streetNumber_Ljava_lang_String_;
			}

			static IntPtr n_StreetNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Location.Address.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StreetNumber (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_streetNumber_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Address.Builder']/method[@name='streetNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("streetNumber", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;", "GetStreetNumber_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Baidu.Location.Address.Builder StreetNumber (string p0)
			{
				if (id_streetNumber_Ljava_lang_String_ == IntPtr.Zero)
					id_streetNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "streetNumber", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Baidu.Location.Address.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_streetNumber_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "streetNumber", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/location/Address", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Address); }
		}

		internal Address (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
