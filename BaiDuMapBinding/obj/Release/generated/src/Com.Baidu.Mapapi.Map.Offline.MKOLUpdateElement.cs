using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map.Offline {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/offline/MKOLUpdateElement", DoNotGenerateAcw=true)]
	public partial class MKOLUpdateElement : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='DOWNLOADING']"
		[Register ("DOWNLOADING")]
		public const int Downloading = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='FINISHED']"
		[Register ("FINISHED")]
		public const int Finished = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='SUSPENDED']"
		[Register ("SUSPENDED")]
		public const int Suspended = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='UNDEFINED']"
		[Register ("UNDEFINED")]
		public const int Undefined = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='WAITING']"
		[Register ("WAITING")]
		public const int Waiting = (int) 2;

		static IntPtr cityID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='cityID']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='cityName']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='eOLDSFormatError']"
		[Register ("eOLDSFormatError")]
		public const int EOLDSFormatError = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='eOLDSIOError']"
		[Register ("eOLDSIOError")]
		public const int EOLDSIOError = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='eOLDSInstalling']"
		[Register ("eOLDSInstalling")]
		public const int EOLDSInstalling = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='eOLDSMd5Error']"
		[Register ("eOLDSMd5Error")]
		public const int EOLDSMd5Error = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='eOLDSNetError']"
		[Register ("eOLDSNetError")]
		public const int EOLDSNetError = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='eOLDSWifiError']"
		[Register ("eOLDSWifiError")]
		public const int EOLDSWifiError = (int) 8;

		static IntPtr geoPt_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='geoPt']"
		[Register ("geoPt")]
		public global::Com.Baidu.Mapapi.Model.LatLng GeoPt {
			get {
				if (geoPt_jfieldId == IntPtr.Zero)
					geoPt_jfieldId = JNIEnv.GetFieldID (class_ref, "geoPt", "Lcom/baidu/mapapi/model/LatLng;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, geoPt_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (geoPt_jfieldId == IntPtr.Zero)
					geoPt_jfieldId = JNIEnv.GetFieldID (class_ref, "geoPt", "Lcom/baidu/mapapi/model/LatLng;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, geoPt_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr level_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='level']"
		[Register ("level")]
		public int Level {
			get {
				if (level_jfieldId == IntPtr.Zero)
					level_jfieldId = JNIEnv.GetFieldID (class_ref, "level", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, level_jfieldId);
			}
			set {
				if (level_jfieldId == IntPtr.Zero)
					level_jfieldId = JNIEnv.GetFieldID (class_ref, "level", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, level_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr ratio_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='ratio']"
		[Register ("ratio")]
		public int Ratio {
			get {
				if (ratio_jfieldId == IntPtr.Zero)
					ratio_jfieldId = JNIEnv.GetFieldID (class_ref, "ratio", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, ratio_jfieldId);
			}
			set {
				if (ratio_jfieldId == IntPtr.Zero)
					ratio_jfieldId = JNIEnv.GetFieldID (class_ref, "ratio", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ratio_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr serversize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='serversize']"
		[Register ("serversize")]
		public int Serversize {
			get {
				if (serversize_jfieldId == IntPtr.Zero)
					serversize_jfieldId = JNIEnv.GetFieldID (class_ref, "serversize", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, serversize_jfieldId);
			}
			set {
				if (serversize_jfieldId == IntPtr.Zero)
					serversize_jfieldId = JNIEnv.GetFieldID (class_ref, "serversize", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, serversize_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr size_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='size']"
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

		static IntPtr status_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='status']"
		[Register ("status")]
		public int Status {
			get {
				if (status_jfieldId == IntPtr.Zero)
					status_jfieldId = JNIEnv.GetFieldID (class_ref, "status", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, status_jfieldId);
			}
			set {
				if (status_jfieldId == IntPtr.Zero)
					status_jfieldId = JNIEnv.GetFieldID (class_ref, "status", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, status_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr update_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='update']"
		[Register ("update")]
		public bool Update {
			get {
				if (update_jfieldId == IntPtr.Zero)
					update_jfieldId = JNIEnv.GetFieldID (class_ref, "update", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, update_jfieldId);
			}
			set {
				if (update_jfieldId == IntPtr.Zero)
					update_jfieldId = JNIEnv.GetFieldID (class_ref, "update", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, update_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/offline/MKOLUpdateElement", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MKOLUpdateElement); }
		}

		protected MKOLUpdateElement (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/constructor[@name='MKOLUpdateElement' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MKOLUpdateElement ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MKOLUpdateElement)) {
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
