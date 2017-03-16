using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='LatLngBounds']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/model/LatLngBounds", DoNotGenerateAcw=true)]
	public sealed partial class LatLngBounds : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='LatLngBounds']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr northeast_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='LatLngBounds']/field[@name='northeast']"
		[Register ("northeast")]
		public global::Com.Baidu.Mapapi.Model.LatLng Northeast {
			get {
				if (northeast_jfieldId == IntPtr.Zero)
					northeast_jfieldId = JNIEnv.GetFieldID (class_ref, "northeast", "Lcom/baidu/mapapi/model/LatLng;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, northeast_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (northeast_jfieldId == IntPtr.Zero)
					northeast_jfieldId = JNIEnv.GetFieldID (class_ref, "northeast", "Lcom/baidu/mapapi/model/LatLng;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, northeast_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr southwest_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='LatLngBounds']/field[@name='southwest']"
		[Register ("southwest")]
		public global::Com.Baidu.Mapapi.Model.LatLng Southwest {
			get {
				if (southwest_jfieldId == IntPtr.Zero)
					southwest_jfieldId = JNIEnv.GetFieldID (class_ref, "southwest", "Lcom/baidu/mapapi/model/LatLng;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, southwest_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (southwest_jfieldId == IntPtr.Zero)
					southwest_jfieldId = JNIEnv.GetFieldID (class_ref, "southwest", "Lcom/baidu/mapapi/model/LatLng;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, southwest_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='LatLngBounds.Builder']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/model/LatLngBounds$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/mapapi/model/LatLngBounds$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='LatLngBounds.Builder']/constructor[@name='LatLngBounds.Builder' and count(parameter)=0]"
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

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='LatLngBounds.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/baidu/mapapi/model/LatLngBounds;", "")]
			public unsafe global::Com.Baidu.Mapapi.Model.LatLngBounds Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/baidu/mapapi/model/LatLngBounds;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLngBounds> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_include_Lcom_baidu_mapapi_model_LatLng_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='LatLngBounds.Builder']/method[@name='include' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
			[Register ("include", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/model/LatLngBounds$Builder;", "")]
			public unsafe global::Com.Baidu.Mapapi.Model.LatLngBounds.Builder Include (global::Com.Baidu.Mapapi.Model.LatLng p0)
			{
				if (id_include_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
					id_include_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "include", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/model/LatLngBounds$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Com.Baidu.Mapapi.Model.LatLngBounds.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLngBounds.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_include_Lcom_baidu_mapapi_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/model/LatLngBounds", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LatLngBounds); }
		}

		internal LatLngBounds (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getCenter;
		public unsafe global::Com.Baidu.Mapapi.Model.LatLng Center {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='LatLngBounds']/method[@name='getCenter' and count(parameter)=0]"
			[Register ("getCenter", "()Lcom/baidu/mapapi/model/LatLng;", "GetGetCenterHandler")]
			get {
				if (id_getCenter == IntPtr.Zero)
					id_getCenter = JNIEnv.GetMethodID (class_ref, "getCenter", "()Lcom/baidu/mapapi/model/LatLng;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCenter), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_contains_Lcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='LatLngBounds']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("contains", "(Lcom/baidu/mapapi/model/LatLng;)Z", "")]
		public unsafe bool Contains (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			if (id_contains_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_contains_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "contains", "(Lcom/baidu/mapapi/model/LatLng;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_contains_Lcom_baidu_mapapi_model_LatLng_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='LatLngBounds']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
			} finally {
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='LatLngBounds']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
			} finally {
			}
		}

	}
}
