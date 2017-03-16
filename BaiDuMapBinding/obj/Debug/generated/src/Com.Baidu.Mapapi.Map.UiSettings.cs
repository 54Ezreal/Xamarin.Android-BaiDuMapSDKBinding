using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UiSettings']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/UiSettings", DoNotGenerateAcw=true)]
	public sealed partial class UiSettings : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/UiSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UiSettings); }
		}

		internal UiSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isCompassEnabled;
		static IntPtr id_setCompassEnabled_Z;
		public unsafe bool CompassEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UiSettings']/method[@name='isCompassEnabled' and count(parameter)=0]"
			[Register ("isCompassEnabled", "()Z", "GetIsCompassEnabledHandler")]
			get {
				if (id_isCompassEnabled == IntPtr.Zero)
					id_isCompassEnabled = JNIEnv.GetMethodID (class_ref, "isCompassEnabled", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCompassEnabled);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UiSettings']/method[@name='setCompassEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCompassEnabled", "(Z)V", "GetSetCompassEnabled_ZHandler")]
			set {
				if (id_setCompassEnabled_Z == IntPtr.Zero)
					id_setCompassEnabled_Z = JNIEnv.GetMethodID (class_ref, "setCompassEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCompassEnabled_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_isOverlookingGesturesEnabled;
		static IntPtr id_setOverlookingGesturesEnabled_Z;
		public unsafe bool OverlookingGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UiSettings']/method[@name='isOverlookingGesturesEnabled' and count(parameter)=0]"
			[Register ("isOverlookingGesturesEnabled", "()Z", "GetIsOverlookingGesturesEnabledHandler")]
			get {
				if (id_isOverlookingGesturesEnabled == IntPtr.Zero)
					id_isOverlookingGesturesEnabled = JNIEnv.GetMethodID (class_ref, "isOverlookingGesturesEnabled", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOverlookingGesturesEnabled);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UiSettings']/method[@name='setOverlookingGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setOverlookingGesturesEnabled", "(Z)V", "GetSetOverlookingGesturesEnabled_ZHandler")]
			set {
				if (id_setOverlookingGesturesEnabled_Z == IntPtr.Zero)
					id_setOverlookingGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "setOverlookingGesturesEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOverlookingGesturesEnabled_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_isRotateGesturesEnabled;
		static IntPtr id_setRotateGesturesEnabled_Z;
		public unsafe bool RotateGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UiSettings']/method[@name='isRotateGesturesEnabled' and count(parameter)=0]"
			[Register ("isRotateGesturesEnabled", "()Z", "GetIsRotateGesturesEnabledHandler")]
			get {
				if (id_isRotateGesturesEnabled == IntPtr.Zero)
					id_isRotateGesturesEnabled = JNIEnv.GetMethodID (class_ref, "isRotateGesturesEnabled", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRotateGesturesEnabled);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UiSettings']/method[@name='setRotateGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRotateGesturesEnabled", "(Z)V", "GetSetRotateGesturesEnabled_ZHandler")]
			set {
				if (id_setRotateGesturesEnabled_Z == IntPtr.Zero)
					id_setRotateGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "setRotateGesturesEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRotateGesturesEnabled_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_isScrollGesturesEnabled;
		static IntPtr id_setScrollGesturesEnabled_Z;
		public unsafe bool ScrollGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UiSettings']/method[@name='isScrollGesturesEnabled' and count(parameter)=0]"
			[Register ("isScrollGesturesEnabled", "()Z", "GetIsScrollGesturesEnabledHandler")]
			get {
				if (id_isScrollGesturesEnabled == IntPtr.Zero)
					id_isScrollGesturesEnabled = JNIEnv.GetMethodID (class_ref, "isScrollGesturesEnabled", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isScrollGesturesEnabled);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UiSettings']/method[@name='setScrollGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setScrollGesturesEnabled", "(Z)V", "GetSetScrollGesturesEnabled_ZHandler")]
			set {
				if (id_setScrollGesturesEnabled_Z == IntPtr.Zero)
					id_setScrollGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "setScrollGesturesEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScrollGesturesEnabled_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_isZoomGesturesEnabled;
		static IntPtr id_setZoomGesturesEnabled_Z;
		public unsafe bool ZoomGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UiSettings']/method[@name='isZoomGesturesEnabled' and count(parameter)=0]"
			[Register ("isZoomGesturesEnabled", "()Z", "GetIsZoomGesturesEnabledHandler")]
			get {
				if (id_isZoomGesturesEnabled == IntPtr.Zero)
					id_isZoomGesturesEnabled = JNIEnv.GetMethodID (class_ref, "isZoomGesturesEnabled", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isZoomGesturesEnabled);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UiSettings']/method[@name='setZoomGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setZoomGesturesEnabled", "(Z)V", "GetSetZoomGesturesEnabled_ZHandler")]
			set {
				if (id_setZoomGesturesEnabled_Z == IntPtr.Zero)
					id_setZoomGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "setZoomGesturesEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setZoomGesturesEnabled_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_setAllGesturesEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UiSettings']/method[@name='setAllGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllGesturesEnabled", "(Z)V", "")]
		public unsafe void SetAllGesturesEnabled (bool p0)
		{
			if (id_setAllGesturesEnabled_Z == IntPtr.Zero)
				id_setAllGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "setAllGesturesEnabled", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAllGesturesEnabled_Z, __args);
			} finally {
			}
		}

	}
}
