using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']"
	[global::Android.Runtime.Register ("com/baidu/location/Jni", DoNotGenerateAcw=true)]
	public partial class Jni : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/location/Jni", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Jni); }
		}

		protected Jni (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/constructor[@name='Jni' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Jni ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Jni)) {
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

		static IntPtr id_getSkyKey;
		public static unsafe string SkyKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='getSkyKey' and count(parameter)=0]"
			[Register ("getSkyKey", "()Ljava/lang/String;", "GetGetSkyKeyHandler")]
			get {
				if (id_getSkyKey == IntPtr.Zero)
					id_getSkyKey = JNIEnv.GetStaticMethodID (class_ref, "getSkyKey", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSkyKey), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_coorEncrypt_DDLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='coorEncrypt' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='java.lang.String']]"
		[Register ("coorEncrypt", "(DDLjava/lang/String;)[D", "")]
		public static unsafe double[] CoorEncrypt (double p0, double p1, string p2)
		{
			if (id_coorEncrypt_DDLjava_lang_String_ == IntPtr.Zero)
				id_coorEncrypt_DDLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "coorEncrypt", "(DDLjava/lang/String;)[D");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_coorEncrypt_DDLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_decodeIBeacon_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='decodeIBeacon' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("decodeIBeacon", "([B[B)Ljava/lang/String;", "")]
		public static unsafe string DecodeIBeacon (byte[] p0, byte[] p1)
		{
			if (id_decodeIBeacon_arrayBarrayB == IntPtr.Zero)
				id_decodeIBeacon_arrayBarrayB = JNIEnv.GetStaticMethodID (class_ref, "decodeIBeacon", "([B[B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeIBeacon_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_en1_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='en1' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("en1", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string En1 (string p0)
		{
			if (id_en1_Ljava_lang_String_ == IntPtr.Zero)
				id_en1_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "en1", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_en1_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_encode2_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='encode2' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encode2", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Encode2 (string p0)
		{
			if (id_encode2_Ljava_lang_String_ == IntPtr.Zero)
				id_encode2_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encode2", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encode2_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_encode3_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='encode3' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encode3", "(Ljava/lang/String;)Ljava/lang/Long;", "")]
		public static unsafe global::Java.Lang.Long Encode3 (string p0)
		{
			if (id_encode3_Ljava_lang_String_ == IntPtr.Zero)
				id_encode3_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encode3", "(Ljava/lang/String;)Ljava/lang/Long;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Long __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallStaticObjectMethod  (class_ref, id_encode3_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_encode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encode", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Encode (string p0)
		{
			if (id_encode_Ljava_lang_String_ == IntPtr.Zero)
				id_encode_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encode", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_encodeOfflineLocationUpdateRequest_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='encodeOfflineLocationUpdateRequest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encodeOfflineLocationUpdateRequest", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string EncodeOfflineLocationUpdateRequest (string p0)
		{
			if (id_encodeOfflineLocationUpdateRequest_Ljava_lang_String_ == IntPtr.Zero)
				id_encodeOfflineLocationUpdateRequest_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encodeOfflineLocationUpdateRequest", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeOfflineLocationUpdateRequest_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_encodeTp4_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='encodeTp4' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encodeTp4", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string EncodeTp4 (string p0)
		{
			if (id_encodeTp4_Ljava_lang_String_ == IntPtr.Zero)
				id_encodeTp4_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encodeTp4", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeTp4_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getGpsSwiftRadius_FDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='getGpsSwiftRadius' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("getGpsSwiftRadius", "(FDD)D", "")]
		public static unsafe double GetGpsSwiftRadius (float p0, double p1, double p2)
		{
			if (id_getGpsSwiftRadius_FDD == IntPtr.Zero)
				id_getGpsSwiftRadius_FDD = JNIEnv.GetStaticMethodID (class_ref, "getGpsSwiftRadius", "(FDD)D");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_getGpsSwiftRadius_FDD, __args);
			} finally {
			}
		}

		static IntPtr id_gtr2_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='gtr2' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("gtr2", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Gtr2 (string p0)
		{
			if (id_gtr2_Ljava_lang_String_ == IntPtr.Zero)
				id_gtr2_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "gtr2", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_gtr2_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_removeSoList_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='removeSoList' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeSoList", "(ILjava/lang/String;)V", "")]
		public static unsafe void RemoveSoList (int p0, string p1)
		{
			if (id_removeSoList_ILjava_lang_String_ == IntPtr.Zero)
				id_removeSoList_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "removeSoList", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_removeSoList_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_tr2_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='tr2' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("tr2", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Tr2 (string p0, string p1)
		{
			if (id_tr2_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_tr2_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "tr2", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_tr2_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_uninstall_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='uninstall' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("uninstall", "(Ljava/lang/String;)V", "")]
		public static unsafe void Uninstall (string p0)
		{
			if (id_uninstall_Ljava_lang_String_ == IntPtr.Zero)
				id_uninstall_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "uninstall", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_uninstall_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
