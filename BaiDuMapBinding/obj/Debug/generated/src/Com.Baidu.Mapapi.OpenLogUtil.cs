using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='OpenLogUtil']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/OpenLogUtil", DoNotGenerateAcw=true)]
	public partial class OpenLogUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/OpenLogUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OpenLogUtil); }
		}

		protected OpenLogUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='OpenLogUtil']/constructor[@name='OpenLogUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OpenLogUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (OpenLogUtil)) {
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

		static IntPtr id_setModuleLogEnable_Lcom_baidu_mapapi_ModuleName_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='OpenLogUtil']/method[@name='setModuleLogEnable' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.ModuleName'] and parameter[2][@type='boolean']]"
		[Register ("setModuleLogEnable", "(Lcom/baidu/mapapi/ModuleName;Z)V", "")]
		public static unsafe void SetModuleLogEnable (global::Com.Baidu.Mapapi.ModuleName p0, bool p1)
		{
			if (id_setModuleLogEnable_Lcom_baidu_mapapi_ModuleName_Z == IntPtr.Zero)
				id_setModuleLogEnable_Lcom_baidu_mapapi_ModuleName_Z = JNIEnv.GetStaticMethodID (class_ref, "setModuleLogEnable", "(Lcom/baidu/mapapi/ModuleName;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setModuleLogEnable_Lcom_baidu_mapapi_ModuleName_Z, __args);
			} finally {
			}
		}

	}
}
