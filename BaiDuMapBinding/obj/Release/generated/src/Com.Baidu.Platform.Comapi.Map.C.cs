using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='C']"
	[global::Android.Runtime.Register ("com/baidu/platform/comapi/map/C", DoNotGenerateAcw=true)]
	public sealed partial class C : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/platform/comapi/map/C", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (C); }
		}

		internal C (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='C']/constructor[@name='C' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe C ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (C)) {
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

		static IntPtr id_a_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='C']/method[@name='a' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("a", "(Z)Lcom/baidu/platform/comapi/map/C;", "")]
		public unsafe global::Com.Baidu.Platform.Comapi.Map.C A (bool p0)
		{
			if (id_a_Z == IntPtr.Zero)
				id_a_Z = JNIEnv.GetMethodID (class_ref, "a", "(Z)Lcom/baidu/platform/comapi/map/C;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.C> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_a_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_a_Lcom_baidu_platform_comapi_map_E_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='C']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.baidu.platform.comapi.map.E']]"
		[Register ("a", "(Lcom/baidu/platform/comapi/map/E;)Lcom/baidu/platform/comapi/map/C;", "")]
		public unsafe global::Com.Baidu.Platform.Comapi.Map.C A (global::Com.Baidu.Platform.Comapi.Map.E p0)
		{
			if (id_a_Lcom_baidu_platform_comapi_map_E_ == IntPtr.Zero)
				id_a_Lcom_baidu_platform_comapi_map_E_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/baidu/platform/comapi/map/E;)Lcom/baidu/platform/comapi/map/C;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Platform.Comapi.Map.C __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.C> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_a_Lcom_baidu_platform_comapi_map_E_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_a_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='C']/method[@name='a' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("a", "(I)Lcom/baidu/platform/comapi/map/C;", "")]
		public unsafe global::Com.Baidu.Platform.Comapi.Map.C A (int p0)
		{
			if (id_a_I == IntPtr.Zero)
				id_a_I = JNIEnv.GetMethodID (class_ref, "a", "(I)Lcom/baidu/platform/comapi/map/C;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.C> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_a_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_b_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='C']/method[@name='b' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("b", "(Z)Lcom/baidu/platform/comapi/map/C;", "")]
		public unsafe global::Com.Baidu.Platform.Comapi.Map.C B (bool p0)
		{
			if (id_b_Z == IntPtr.Zero)
				id_b_Z = JNIEnv.GetMethodID (class_ref, "b", "(Z)Lcom/baidu/platform/comapi/map/C;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.C> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_b_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_c_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='C']/method[@name='c' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("c", "(Z)Lcom/baidu/platform/comapi/map/C;", "")]
		public unsafe global::Com.Baidu.Platform.Comapi.Map.C InvokeC (bool p0)
		{
			if (id_c_Z == IntPtr.Zero)
				id_c_Z = JNIEnv.GetMethodID (class_ref, "c", "(Z)Lcom/baidu/platform/comapi/map/C;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.C> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_c_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_d_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='C']/method[@name='d' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("d", "(Z)Lcom/baidu/platform/comapi/map/C;", "")]
		public unsafe global::Com.Baidu.Platform.Comapi.Map.C D (bool p0)
		{
			if (id_d_Z == IntPtr.Zero)
				id_d_Z = JNIEnv.GetMethodID (class_ref, "d", "(Z)Lcom/baidu/platform/comapi/map/C;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.C> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_d_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_e_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='C']/method[@name='e' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("e", "(Z)Lcom/baidu/platform/comapi/map/C;", "")]
		public unsafe global::Com.Baidu.Platform.Comapi.Map.C E (bool p0)
		{
			if (id_e_Z == IntPtr.Zero)
				id_e_Z = JNIEnv.GetMethodID (class_ref, "e", "(Z)Lcom/baidu/platform/comapi/map/C;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.C> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_e_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
