using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map.Offline {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLSearchRecord']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/offline/MKOLSearchRecord", DoNotGenerateAcw=true)]
	public partial class MKOLSearchRecord : global::Java.Lang.Object {


		static IntPtr childCities_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLSearchRecord']/field[@name='childCities']"
		[Register ("childCities")]
		public global::System.Collections.IList ChildCities {
			get {
				if (childCities_jfieldId == IntPtr.Zero)
					childCities_jfieldId = JNIEnv.GetFieldID (class_ref, "childCities", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, childCities_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (childCities_jfieldId == IntPtr.Zero)
					childCities_jfieldId = JNIEnv.GetFieldID (class_ref, "childCities", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, childCities_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr cityID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLSearchRecord']/field[@name='cityID']"
		[Register ("cityID")]
		public int CityID {
			get {
				if (cityID_jfieldId == IntPtr.Zero)
					cityID_jfieldId = JNIEnv.GetFieldID (class_ref, "cityID", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, cityID_jfieldId);
			}
			set {
				if (cityID_jfieldId == IntPtr.Zero)
					cityID_jfieldId = JNIEnv.GetFieldID (class_ref, "cityID", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cityID_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr cityName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLSearchRecord']/field[@name='cityName']"
		[Register ("cityName")]
		public string CityName {
			get {
				if (cityName_jfieldId == IntPtr.Zero)
					cityName_jfieldId = JNIEnv.GetFieldID (class_ref, "cityName", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, cityName_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (cityName_jfieldId == IntPtr.Zero)
					cityName_jfieldId = JNIEnv.GetFieldID (class_ref, "cityName", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cityName_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr cityType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLSearchRecord']/field[@name='cityType']"
		[Register ("cityType")]
		public int CityType {
			get {
				if (cityType_jfieldId == IntPtr.Zero)
					cityType_jfieldId = JNIEnv.GetFieldID (class_ref, "cityType", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, cityType_jfieldId);
			}
			set {
				if (cityType_jfieldId == IntPtr.Zero)
					cityType_jfieldId = JNIEnv.GetFieldID (class_ref, "cityType", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cityType_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr size_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLSearchRecord']/field[@name='size']"
		[Register ("size")]
		public int Size {
			get {
				if (size_jfieldId == IntPtr.Zero)
					size_jfieldId = JNIEnv.GetFieldID (class_ref, "size", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, size_jfieldId);
			}
			set {
				if (size_jfieldId == IntPtr.Zero)
					size_jfieldId = JNIEnv.GetFieldID (class_ref, "size", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, size_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/offline/MKOLSearchRecord", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MKOLSearchRecord); }
		}

		protected MKOLSearchRecord (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLSearchRecord']/constructor[@name='MKOLSearchRecord' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MKOLSearchRecord ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MKOLSearchRecord)) {
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

	}
}
