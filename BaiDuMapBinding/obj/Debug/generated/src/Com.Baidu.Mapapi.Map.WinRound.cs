using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WinRound']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/WinRound", DoNotGenerateAcw=true)]
	public partial class WinRound : global::Java.Lang.Object {


		static IntPtr bottom_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WinRound']/field[@name='bottom']"
		[Register ("bottom")]
		public int Bottom {
			get {
				if (bottom_jfieldId == IntPtr.Zero)
					bottom_jfieldId = JNIEnv.GetFieldID (class_ref, "bottom", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, bottom_jfieldId);
			}
			set {
				if (bottom_jfieldId == IntPtr.Zero)
					bottom_jfieldId = JNIEnv.GetFieldID (class_ref, "bottom", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, bottom_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr left_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WinRound']/field[@name='left']"
		[Register ("left")]
		public int Left {
			get {
				if (left_jfieldId == IntPtr.Zero)
					left_jfieldId = JNIEnv.GetFieldID (class_ref, "left", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, left_jfieldId);
			}
			set {
				if (left_jfieldId == IntPtr.Zero)
					left_jfieldId = JNIEnv.GetFieldID (class_ref, "left", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, left_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr right_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WinRound']/field[@name='right']"
		[Register ("right")]
		public int Right {
			get {
				if (right_jfieldId == IntPtr.Zero)
					right_jfieldId = JNIEnv.GetFieldID (class_ref, "right", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, right_jfieldId);
			}
			set {
				if (right_jfieldId == IntPtr.Zero)
					right_jfieldId = JNIEnv.GetFieldID (class_ref, "right", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, right_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr top_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WinRound']/field[@name='top']"
		[Register ("top")]
		public int Top {
			get {
				if (top_jfieldId == IntPtr.Zero)
					top_jfieldId = JNIEnv.GetFieldID (class_ref, "top", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, top_jfieldId);
			}
			set {
				if (top_jfieldId == IntPtr.Zero)
					top_jfieldId = JNIEnv.GetFieldID (class_ref, "top", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, top_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/WinRound", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WinRound); }
		}

		protected WinRound (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WinRound']/constructor[@name='WinRound' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WinRound ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (WinRound)) {
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
