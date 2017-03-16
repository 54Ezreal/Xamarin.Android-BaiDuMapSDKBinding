using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comapi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.platform.comapi']/class[@name='NativeLoader']"
	[global::Android.Runtime.Register ("com/baidu/platform/comapi/NativeLoader", DoNotGenerateAcw=true)]
	public partial class NativeLoader : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/platform/comapi/NativeLoader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeLoader); }
		}

		protected NativeLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getCodePath;
#pragma warning disable 0169
		static Delegate GetGetCodePathHandler ()
		{
			if (cb_getCodePath == null)
				cb_getCodePath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCodePath);
			return cb_getCodePath;
		}

		static IntPtr n_GetCodePath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Platform.Comapi.NativeLoader __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.NativeLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CodePath);
		}
#pragma warning restore 0169

		static IntPtr id_getCodePath;
		protected virtual unsafe string CodePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi']/class[@name='NativeLoader']/method[@name='getCodePath' and count(parameter)=0]"
			[Register ("getCodePath", "()Ljava/lang/String;", "GetGetCodePathHandler")]
			get {
				if (id_getCodePath == IntPtr.Zero)
					id_getCodePath = JNIEnv.GetMethodID (class_ref, "getCodePath", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCodePath), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCodePath", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCustomizeNativePath;
#pragma warning disable 0169
		static Delegate GetGetCustomizeNativePathHandler ()
		{
			if (cb_getCustomizeNativePath == null)
				cb_getCustomizeNativePath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomizeNativePath);
			return cb_getCustomizeNativePath;
		}

		static IntPtr n_GetCustomizeNativePath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Platform.Comapi.NativeLoader __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.NativeLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CustomizeNativePath);
		}
#pragma warning restore 0169

		static IntPtr id_getCustomizeNativePath;
		protected virtual unsafe string CustomizeNativePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi']/class[@name='NativeLoader']/method[@name='getCustomizeNativePath' and count(parameter)=0]"
			[Register ("getCustomizeNativePath", "()Ljava/lang/String;", "GetGetCustomizeNativePathHandler")]
			get {
				if (id_getCustomizeNativePath == IntPtr.Zero)
					id_getCustomizeNativePath = JNIEnv.GetMethodID (class_ref, "getCustomizeNativePath", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCustomizeNativePath), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCustomizeNativePath", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Baidu.Platform.Comapi.NativeLoader Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi']/class[@name='NativeLoader']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/baidu/platform/comapi/NativeLoader;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/baidu/platform/comapi/NativeLoader;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.NativeLoader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_copyStream_Ljava_io_InputStream_Ljava_io_FileOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi']/class[@name='NativeLoader']/method[@name='copyStream' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.FileOutputStream']]"
		[Register ("copyStream", "(Ljava/io/InputStream;Ljava/io/FileOutputStream;)V", "")]
		protected unsafe void CopyStream (global::System.IO.Stream p0, global::System.IO.Stream p1)
		{
			if (id_copyStream_Ljava_io_InputStream_Ljava_io_FileOutputStream_ == IntPtr.Zero)
				id_copyStream_Ljava_io_InputStream_Ljava_io_FileOutputStream_ = JNIEnv.GetMethodID (class_ref, "copyStream", "(Ljava/io/InputStream;Ljava/io/FileOutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_copyStream_Ljava_io_InputStream_Ljava_io_FileOutputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_loadCustomizeNativeLibrary_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadCustomizeNativeLibrary_Ljava_lang_String_Handler ()
		{
			if (cb_loadCustomizeNativeLibrary_Ljava_lang_String_ == null)
				cb_loadCustomizeNativeLibrary_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_LoadCustomizeNativeLibrary_Ljava_lang_String_);
			return cb_loadCustomizeNativeLibrary_Ljava_lang_String_;
		}

		static bool n_LoadCustomizeNativeLibrary_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Platform.Comapi.NativeLoader __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.NativeLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.LoadCustomizeNativeLibrary (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_loadCustomizeNativeLibrary_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi']/class[@name='NativeLoader']/method[@name='loadCustomizeNativeLibrary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadCustomizeNativeLibrary", "(Ljava/lang/String;)Z", "GetLoadCustomizeNativeLibrary_Ljava_lang_String_Handler")]
		protected virtual unsafe bool LoadCustomizeNativeLibrary (string p0)
		{
			if (id_loadCustomizeNativeLibrary_Ljava_lang_String_ == IntPtr.Zero)
				id_loadCustomizeNativeLibrary_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadCustomizeNativeLibrary", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_loadCustomizeNativeLibrary_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadCustomizeNativeLibrary", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_loadLibrary_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadLibrary_Ljava_lang_String_Handler ()
		{
			if (cb_loadLibrary_Ljava_lang_String_ == null)
				cb_loadLibrary_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_LoadLibrary_Ljava_lang_String_);
			return cb_loadLibrary_Ljava_lang_String_;
		}

		static bool n_LoadLibrary_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Platform.Comapi.NativeLoader __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.NativeLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.LoadLibrary (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_loadLibrary_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi']/class[@name='NativeLoader']/method[@name='loadLibrary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadLibrary", "(Ljava/lang/String;)Z", "GetLoadLibrary_Ljava_lang_String_Handler")]
		public virtual unsafe bool LoadLibrary (string p0)
		{
			if (id_loadLibrary_Ljava_lang_String_ == IntPtr.Zero)
				id_loadLibrary_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadLibrary", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_loadLibrary_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadLibrary", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setContext_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi']/class[@name='NativeLoader']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("setContext", "(Landroid/content/Context;)V", "")]
		public static unsafe void SetContext (global::Android.Content.Context p0)
		{
			if (id_setContext_Landroid_content_Context_ == IntPtr.Zero)
				id_setContext_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "setContext", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setContext_Landroid_content_Context_, __args);
			} finally {
			}
		}

	}
}
