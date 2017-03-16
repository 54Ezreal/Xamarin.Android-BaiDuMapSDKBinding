using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='LatLng']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/model/LatLng", DoNotGenerateAcw=true)]
	public sealed partial class LatLng : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='LatLng']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr latitude_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='LatLng']/field[@name='latitude']"
		[Register ("latitude")]
		public double Latitude {
			get {
				if (latitude_jfieldId == IntPtr.Zero)
					latitude_jfieldId = JNIEnv.GetFieldID (class_ref, "latitude", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, latitude_jfieldId);
			}
			set {
				if (latitude_jfieldId == IntPtr.Zero)
					latitude_jfieldId = JNIEnv.GetFieldID (class_ref, "latitude", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, latitude_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr latitudeE6_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='LatLng']/field[@name='latitudeE6']"
		[Register ("latitudeE6")]
		public double LatitudeE6 {
			get {
				if (latitudeE6_jfieldId == IntPtr.Zero)
					latitudeE6_jfieldId = JNIEnv.GetFieldID (class_ref, "latitudeE6", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, latitudeE6_jfieldId);
			}
			set {
				if (latitudeE6_jfieldId == IntPtr.Zero)
					latitudeE6_jfieldId = JNIEnv.GetFieldID (class_ref, "latitudeE6", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, latitudeE6_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr longitude_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='LatLng']/field[@name='longitude']"
		[Register ("longitude")]
		public double Longitude {
			get {
				if (longitude_jfieldId == IntPtr.Zero)
					longitude_jfieldId = JNIEnv.GetFieldID (class_ref, "longitude", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, longitude_jfieldId);
			}
			set {
				if (longitude_jfieldId == IntPtr.Zero)
					longitude_jfieldId = JNIEnv.GetFieldID (class_ref, "longitude", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, longitude_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr longitudeE6_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='LatLng']/field[@name='longitudeE6']"
		[Register ("longitudeE6")]
		public double LongitudeE6 {
			get {
				if (longitudeE6_jfieldId == IntPtr.Zero)
					longitudeE6_jfieldId = JNIEnv.GetFieldID (class_ref, "longitudeE6", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, longitudeE6_jfieldId);
			}
			set {
				if (longitudeE6_jfieldId == IntPtr.Zero)
					longitudeE6_jfieldId = JNIEnv.GetFieldID (class_ref, "longitudeE6", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, longitudeE6_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/model/LatLng", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LatLng); }
		}

		internal LatLng (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_DD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='LatLng']/constructor[@name='LatLng' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register (".ctor", "(DD)V", "")]
		public unsafe LatLng (double p0, double p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (LatLng)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(DD)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(DD)V", __args);
					return;
				}

				if (id_ctor_DD == IntPtr.Zero)
					id_ctor_DD = JNIEnv.GetMethodID (class_ref, "<init>", "(DD)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_DD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_DD, __args);
			} finally {
			}
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='LatLng']/method[@name='describeContents' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='LatLng']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
