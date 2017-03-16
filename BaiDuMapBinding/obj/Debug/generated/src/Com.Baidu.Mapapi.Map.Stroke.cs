using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Stroke']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/Stroke", DoNotGenerateAcw=true)]
	public sealed partial class Stroke : global::Java.Lang.Object {


		static IntPtr color_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Stroke']/field[@name='color']"
		[Register ("color")]
		public int Color {
			get {
				if (color_jfieldId == IntPtr.Zero)
					color_jfieldId = JNIEnv.GetFieldID (class_ref, "color", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, color_jfieldId);
			}
			set {
				if (color_jfieldId == IntPtr.Zero)
					color_jfieldId = JNIEnv.GetFieldID (class_ref, "color", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, color_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr strokeWidth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Stroke']/field[@name='strokeWidth']"
		[Register ("strokeWidth")]
		public int StrokeWidth {
			get {
				if (strokeWidth_jfieldId == IntPtr.Zero)
					strokeWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "strokeWidth", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, strokeWidth_jfieldId);
			}
			set {
				if (strokeWidth_jfieldId == IntPtr.Zero)
					strokeWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "strokeWidth", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, strokeWidth_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/Stroke", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Stroke); }
		}

		internal Stroke (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Stroke']/constructor[@name='Stroke' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe Stroke (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (Stroke)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

	}
}
