using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatus']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/MapStatus", DoNotGenerateAcw=true)]
	public sealed partial class MapStatus : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatus']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr bound_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatus']/field[@name='bound']"
		[Register ("bound")]
		public global::Com.Baidu.Mapapi.Model.LatLngBounds Bound {
			get {
				if (bound_jfieldId == IntPtr.Zero)
					bound_jfieldId = JNIEnv.GetFieldID (class_ref, "bound", "Lcom/baidu/mapapi/model/LatLngBounds;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, bound_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLngBounds> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (bound_jfieldId == IntPtr.Zero)
					bound_jfieldId = JNIEnv.GetFieldID (class_ref, "bound", "Lcom/baidu/mapapi/model/LatLngBounds;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, bound_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr overlook_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatus']/field[@name='overlook']"
		[Register ("overlook")]
		public float Overlook {
			get {
				if (overlook_jfieldId == IntPtr.Zero)
					overlook_jfieldId = JNIEnv.GetFieldID (class_ref, "overlook", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, overlook_jfieldId);
			}
			set {
				if (overlook_jfieldId == IntPtr.Zero)
					overlook_jfieldId = JNIEnv.GetFieldID (class_ref, "overlook", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, overlook_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr rotate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatus']/field[@name='rotate']"
		[Register ("rotate")]
		public float Rotate {
			get {
				if (rotate_jfieldId == IntPtr.Zero)
					rotate_jfieldId = JNIEnv.GetFieldID (class_ref, "rotate", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, rotate_jfieldId);
			}
			set {
				if (rotate_jfieldId == IntPtr.Zero)
					rotate_jfieldId = JNIEnv.GetFieldID (class_ref, "rotate", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, rotate_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr target_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatus']/field[@name='target']"
		[Register ("target")]
		public global::Com.Baidu.Mapapi.Model.LatLng Target {
			get {
				if (target_jfieldId == IntPtr.Zero)
					target_jfieldId = JNIEnv.GetFieldID (class_ref, "target", "Lcom/baidu/mapapi/model/LatLng;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, target_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (target_jfieldId == IntPtr.Zero)
					target_jfieldId = JNIEnv.GetFieldID (class_ref, "target", "Lcom/baidu/mapapi/model/LatLng;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, target_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr targetScreen_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatus']/field[@name='targetScreen']"
		[Register ("targetScreen")]
		public global::Android.Graphics.Point TargetScreen {
			get {
				if (targetScreen_jfieldId == IntPtr.Zero)
					targetScreen_jfieldId = JNIEnv.GetFieldID (class_ref, "targetScreen", "Landroid/graphics/Point;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, targetScreen_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (targetScreen_jfieldId == IntPtr.Zero)
					targetScreen_jfieldId = JNIEnv.GetFieldID (class_ref, "targetScreen", "Landroid/graphics/Point;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, targetScreen_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr winRound_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatus']/field[@name='winRound']"
		[Register ("winRound")]
		public global::Com.Baidu.Mapapi.Map.WinRound WinRound {
			get {
				if (winRound_jfieldId == IntPtr.Zero)
					winRound_jfieldId = JNIEnv.GetFieldID (class_ref, "winRound", "Lcom/baidu/mapapi/map/WinRound;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, winRound_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WinRound> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (winRound_jfieldId == IntPtr.Zero)
					winRound_jfieldId = JNIEnv.GetFieldID (class_ref, "winRound", "Lcom/baidu/mapapi/map/WinRound;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, winRound_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr zoom_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatus']/field[@name='zoom']"
		[Register ("zoom")]
		public float Zoom {
			get {
				if (zoom_jfieldId == IntPtr.Zero)
					zoom_jfieldId = JNIEnv.GetFieldID (class_ref, "zoom", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, zoom_jfieldId);
			}
			set {
				if (zoom_jfieldId == IntPtr.Zero)
					zoom_jfieldId = JNIEnv.GetFieldID (class_ref, "zoom", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, zoom_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatus.Builder']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/map/MapStatus$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/mapapi/map/MapStatus$Builder", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatus.Builder']/constructor[@name='MapStatus.Builder' and count(parameter)=0]"
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

			static IntPtr id_ctor_Lcom_baidu_mapapi_map_MapStatus_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatus.Builder']/constructor[@name='MapStatus.Builder' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MapStatus']]"
			[Register (".ctor", "(Lcom/baidu/mapapi/map/MapStatus;)V", "")]
			public unsafe Builder (global::Com.Baidu.Mapapi.Map.MapStatus p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (Builder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/baidu/mapapi/map/MapStatus;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/baidu/mapapi/map/MapStatus;)V", __args);
						return;
					}

					if (id_ctor_Lcom_baidu_mapapi_map_MapStatus_ == IntPtr.Zero)
						id_ctor_Lcom_baidu_mapapi_map_MapStatus_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/baidu/mapapi/map/MapStatus;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_baidu_mapapi_map_MapStatus_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_baidu_mapapi_map_MapStatus_, __args);
				} finally {
				}
			}

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatus.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/baidu/mapapi/map/MapStatus;", "")]
			public unsafe global::Com.Baidu.Mapapi.Map.MapStatus Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/baidu/mapapi/map/MapStatus;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_overlook_F;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatus.Builder']/method[@name='overlook' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("overlook", "(F)Lcom/baidu/mapapi/map/MapStatus$Builder;", "")]
			public unsafe global::Com.Baidu.Mapapi.Map.MapStatus.Builder Overlook (float p0)
			{
				if (id_overlook_F == IntPtr.Zero)
					id_overlook_F = JNIEnv.GetMethodID (class_ref, "overlook", "(F)Lcom/baidu/mapapi/map/MapStatus$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatus.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_overlook_F, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_rotate_F;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatus.Builder']/method[@name='rotate' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("rotate", "(F)Lcom/baidu/mapapi/map/MapStatus$Builder;", "")]
			public unsafe global::Com.Baidu.Mapapi.Map.MapStatus.Builder Rotate (float p0)
			{
				if (id_rotate_F == IntPtr.Zero)
					id_rotate_F = JNIEnv.GetMethodID (class_ref, "rotate", "(F)Lcom/baidu/mapapi/map/MapStatus$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatus.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_rotate_F, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_target_Lcom_baidu_mapapi_model_LatLng_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatus.Builder']/method[@name='target' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
			[Register ("target", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/map/MapStatus$Builder;", "")]
			public unsafe global::Com.Baidu.Mapapi.Map.MapStatus.Builder Target (global::Com.Baidu.Mapapi.Model.LatLng p0)
			{
				if (id_target_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
					id_target_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "target", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/map/MapStatus$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Com.Baidu.Mapapi.Map.MapStatus.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatus.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_target_Lcom_baidu_mapapi_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_targetScreen_Landroid_graphics_Point_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatus.Builder']/method[@name='targetScreen' and count(parameter)=1 and parameter[1][@type='android.graphics.Point']]"
			[Register ("targetScreen", "(Landroid/graphics/Point;)Lcom/baidu/mapapi/map/MapStatus$Builder;", "")]
			public unsafe global::Com.Baidu.Mapapi.Map.MapStatus.Builder TargetScreen (global::Android.Graphics.Point p0)
			{
				if (id_targetScreen_Landroid_graphics_Point_ == IntPtr.Zero)
					id_targetScreen_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "targetScreen", "(Landroid/graphics/Point;)Lcom/baidu/mapapi/map/MapStatus$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Com.Baidu.Mapapi.Map.MapStatus.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatus.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_targetScreen_Landroid_graphics_Point_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_zoom_F;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatus.Builder']/method[@name='zoom' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("zoom", "(F)Lcom/baidu/mapapi/map/MapStatus$Builder;", "")]
			public unsafe global::Com.Baidu.Mapapi.Map.MapStatus.Builder Zoom (float p0)
			{
				if (id_zoom_F == IntPtr.Zero)
					id_zoom_F = JNIEnv.GetMethodID (class_ref, "zoom", "(F)Lcom/baidu/mapapi/map/MapStatus$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatus.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_zoom_F, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/MapStatus", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapStatus); }
		}

		internal MapStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatus']/method[@name='describeContents' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatus']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
