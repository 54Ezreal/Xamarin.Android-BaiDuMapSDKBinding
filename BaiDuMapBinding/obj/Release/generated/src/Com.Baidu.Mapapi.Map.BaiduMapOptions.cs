using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMapOptions", DoNotGenerateAcw=true)]
	public sealed partial class BaiduMapOptions : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/BaiduMapOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaiduMapOptions); }
		}

		internal BaiduMapOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/constructor[@name='BaiduMapOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaiduMapOptions ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BaiduMapOptions)) {
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

		static IntPtr id_compassEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='compassEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("compassEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions CompassEnabled (bool p0)
		{
			if (id_compassEnabled_Z == IntPtr.Zero)
				id_compassEnabled_Z = JNIEnv.GetMethodID (class_ref, "compassEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_compassEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='describeContents' and count(parameter)=0]"
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

		static IntPtr id_logoPosition_Lcom_baidu_mapapi_map_LogoPosition_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='logoPosition' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.LogoPosition']]"
		[Register ("logoPosition", "(Lcom/baidu/mapapi/map/LogoPosition;)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions LogoPosition (global::Com.Baidu.Mapapi.Map.LogoPosition p0)
		{
			if (id_logoPosition_Lcom_baidu_mapapi_map_LogoPosition_ == IntPtr.Zero)
				id_logoPosition_Lcom_baidu_mapapi_map_LogoPosition_ = JNIEnv.GetMethodID (class_ref, "logoPosition", "(Lcom/baidu/mapapi/map/LogoPosition;)Lcom/baidu/mapapi/map/BaiduMapOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.BaiduMapOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_logoPosition_Lcom_baidu_mapapi_map_LogoPosition_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_mapStatus_Lcom_baidu_mapapi_map_MapStatus_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='mapStatus' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MapStatus']]"
		[Register ("mapStatus", "(Lcom/baidu/mapapi/map/MapStatus;)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions MapStatus (global::Com.Baidu.Mapapi.Map.MapStatus p0)
		{
			if (id_mapStatus_Lcom_baidu_mapapi_map_MapStatus_ == IntPtr.Zero)
				id_mapStatus_Lcom_baidu_mapapi_map_MapStatus_ = JNIEnv.GetMethodID (class_ref, "mapStatus", "(Lcom/baidu/mapapi/map/MapStatus;)Lcom/baidu/mapapi/map/BaiduMapOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.BaiduMapOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_mapStatus_Lcom_baidu_mapapi_map_MapStatus_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_mapType_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='mapType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("mapType", "(I)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions MapType (int p0)
		{
			if (id_mapType_I == IntPtr.Zero)
				id_mapType_I = JNIEnv.GetMethodID (class_ref, "mapType", "(I)Lcom/baidu/mapapi/map/BaiduMapOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_mapType_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_overlookingGesturesEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='overlookingGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("overlookingGesturesEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions OverlookingGesturesEnabled (bool p0)
		{
			if (id_overlookingGesturesEnabled_Z == IntPtr.Zero)
				id_overlookingGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "overlookingGesturesEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_overlookingGesturesEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_rotateGesturesEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='rotateGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("rotateGesturesEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions RotateGesturesEnabled (bool p0)
		{
			if (id_rotateGesturesEnabled_Z == IntPtr.Zero)
				id_rotateGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "rotateGesturesEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_rotateGesturesEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_scaleControlEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='scaleControlEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("scaleControlEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions ScaleControlEnabled (bool p0)
		{
			if (id_scaleControlEnabled_Z == IntPtr.Zero)
				id_scaleControlEnabled_Z = JNIEnv.GetMethodID (class_ref, "scaleControlEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_scaleControlEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_scaleControlPosition_Landroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='scaleControlPosition' and count(parameter)=1 and parameter[1][@type='android.graphics.Point']]"
		[Register ("scaleControlPosition", "(Landroid/graphics/Point;)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions ScaleControlPosition (global::Android.Graphics.Point p0)
		{
			if (id_scaleControlPosition_Landroid_graphics_Point_ == IntPtr.Zero)
				id_scaleControlPosition_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "scaleControlPosition", "(Landroid/graphics/Point;)Lcom/baidu/mapapi/map/BaiduMapOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.BaiduMapOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_scaleControlPosition_Landroid_graphics_Point_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_scrollGesturesEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='scrollGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("scrollGesturesEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions ScrollGesturesEnabled (bool p0)
		{
			if (id_scrollGesturesEnabled_Z == IntPtr.Zero)
				id_scrollGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "scrollGesturesEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_scrollGesturesEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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

		static IntPtr id_zoomControlsEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='zoomControlsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("zoomControlsEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions ZoomControlsEnabled (bool p0)
		{
			if (id_zoomControlsEnabled_Z == IntPtr.Zero)
				id_zoomControlsEnabled_Z = JNIEnv.GetMethodID (class_ref, "zoomControlsEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_zoomControlsEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_zoomControlsPosition_Landroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='zoomControlsPosition' and count(parameter)=1 and parameter[1][@type='android.graphics.Point']]"
		[Register ("zoomControlsPosition", "(Landroid/graphics/Point;)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions ZoomControlsPosition (global::Android.Graphics.Point p0)
		{
			if (id_zoomControlsPosition_Landroid_graphics_Point_ == IntPtr.Zero)
				id_zoomControlsPosition_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "zoomControlsPosition", "(Landroid/graphics/Point;)Lcom/baidu/mapapi/map/BaiduMapOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.BaiduMapOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_zoomControlsPosition_Landroid_graphics_Point_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_zoomGesturesEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='zoomGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("zoomGesturesEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions ZoomGesturesEnabled (bool p0)
		{
			if (id_zoomGesturesEnabled_Z == IntPtr.Zero)
				id_zoomGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "zoomGesturesEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_zoomGesturesEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
