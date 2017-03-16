using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comjni.Map.Basemap {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='BaseMapCallback']"
	[global::Android.Runtime.Register ("com/baidu/platform/comjni/map/basemap/BaseMapCallback", DoNotGenerateAcw=true)]
	public partial class BaseMapCallback : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/platform/comjni/map/basemap/BaseMapCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseMapCallback); }
		}

		protected BaseMapCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='BaseMapCallback']/constructor[@name='BaseMapCallback' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseMapCallback ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BaseMapCallback)) {
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

		static IntPtr id_ReqLayerData_Landroid_os_Bundle_JILandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='BaseMapCallback']/method[@name='ReqLayerData' and count(parameter)=4 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='long'] and parameter[3][@type='int'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("ReqLayerData", "(Landroid/os/Bundle;JILandroid/os/Bundle;)I", "")]
		public static unsafe int ReqLayerData (global::Android.OS.Bundle p0, long p1, int p2, global::Android.OS.Bundle p3)
		{
			if (id_ReqLayerData_Landroid_os_Bundle_JILandroid_os_Bundle_ == IntPtr.Zero)
				id_ReqLayerData_Landroid_os_Bundle_JILandroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "ReqLayerData", "(Landroid/os/Bundle;JILandroid/os/Bundle;)I");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_ReqLayerData_Landroid_os_Bundle_JILandroid_os_Bundle_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_removeLayerDataInterface_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='BaseMapCallback']/method[@name='removeLayerDataInterface' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("removeLayerDataInterface", "(J)V", "")]
		public static unsafe void RemoveLayerDataInterface (long p0)
		{
			if (id_removeLayerDataInterface_J == IntPtr.Zero)
				id_removeLayerDataInterface_J = JNIEnv.GetStaticMethodID (class_ref, "removeLayerDataInterface", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_removeLayerDataInterface_J, __args);
			} finally {
			}
		}

	}
}
