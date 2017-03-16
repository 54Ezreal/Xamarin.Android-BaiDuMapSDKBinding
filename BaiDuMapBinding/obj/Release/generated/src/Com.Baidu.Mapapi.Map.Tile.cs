using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Tile']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/Tile", DoNotGenerateAcw=true)]
	public partial class Tile : global::Java.Lang.Object {


		static IntPtr data_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Tile']/field[@name='data']"
		[Register ("data")]
		public IList<byte> Data {
			get {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, data_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, data_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr height_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Tile']/field[@name='height']"
		[Register ("height")]
		public int Height {
			get {
				if (height_jfieldId == IntPtr.Zero)
					height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, height_jfieldId);
			}
			set {
				if (height_jfieldId == IntPtr.Zero)
					height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, height_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr width_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Tile']/field[@name='width']"
		[Register ("width")]
		public int Width {
			get {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, width_jfieldId);
			}
			set {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, width_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/Tile", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Tile); }
		}

		protected Tile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IIarrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Tile']/constructor[@name='Tile' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register (".ctor", "(II[B)V", "")]
		public unsafe Tile (int p0, int p1, byte[] p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (Tile)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(II[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(II[B)V", __args);
					return;
				}

				if (id_ctor_IIarrayB == IntPtr.Zero)
					id_ctor_IIarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(II[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIarrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIarrayB, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_toBundle;
#pragma warning disable 0169
		static Delegate GetToBundleHandler ()
		{
			if (cb_toBundle == null)
				cb_toBundle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToBundle);
			return cb_toBundle;
		}

		static IntPtr n_ToBundle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.Tile __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Tile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToBundle ());
		}
#pragma warning restore 0169

		static IntPtr id_toBundle;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Tile']/method[@name='toBundle' and count(parameter)=0]"
		[Register ("toBundle", "()Landroid/os/Bundle;", "GetToBundleHandler")]
		public virtual unsafe global::Android.OS.Bundle ToBundle ()
		{
			if (id_toBundle == IntPtr.Zero)
				id_toBundle = JNIEnv.GetMethodID (class_ref, "toBundle", "()Landroid/os/Bundle;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toBundle), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toBundle", "()Landroid/os/Bundle;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
