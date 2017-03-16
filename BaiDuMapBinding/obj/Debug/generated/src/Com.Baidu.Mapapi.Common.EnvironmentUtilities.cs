using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='EnvironmentUtilities']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/common/EnvironmentUtilities", DoNotGenerateAcw=true)]
	public partial class EnvironmentUtilities : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/common/EnvironmentUtilities", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EnvironmentUtilities); }
		}

		protected EnvironmentUtilities (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='EnvironmentUtilities']/constructor[@name='EnvironmentUtilities' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EnvironmentUtilities ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (EnvironmentUtilities)) {
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

		static IntPtr id_getAppCachePath;
		public static unsafe string AppCachePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='EnvironmentUtilities']/method[@name='getAppCachePath' and count(parameter)=0]"
			[Register ("getAppCachePath", "()Ljava/lang/String;", "GetGetAppCachePathHandler")]
			get {
				if (id_getAppCachePath == IntPtr.Zero)
					id_getAppCachePath = JNIEnv.GetStaticMethodID (class_ref, "getAppCachePath", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppCachePath), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getAppSDCardPath;
		public static unsafe string AppSDCardPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='EnvironmentUtilities']/method[@name='getAppSDCardPath' and count(parameter)=0]"
			[Register ("getAppSDCardPath", "()Ljava/lang/String;", "GetGetAppSDCardPathHandler")]
			get {
				if (id_getAppSDCardPath == IntPtr.Zero)
					id_getAppSDCardPath = JNIEnv.GetStaticMethodID (class_ref, "getAppSDCardPath", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppSDCardPath), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getAppSecondCachePath;
		public static unsafe string AppSecondCachePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='EnvironmentUtilities']/method[@name='getAppSecondCachePath' and count(parameter)=0]"
			[Register ("getAppSecondCachePath", "()Ljava/lang/String;", "GetGetAppSecondCachePathHandler")]
			get {
				if (id_getAppSecondCachePath == IntPtr.Zero)
					id_getAppSecondCachePath = JNIEnv.GetStaticMethodID (class_ref, "getAppSecondCachePath", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppSecondCachePath), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDomTmpStgMax;
		public static unsafe int DomTmpStgMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='EnvironmentUtilities']/method[@name='getDomTmpStgMax' and count(parameter)=0]"
			[Register ("getDomTmpStgMax", "()I", "GetGetDomTmpStgMaxHandler")]
			get {
				if (id_getDomTmpStgMax == IntPtr.Zero)
					id_getDomTmpStgMax = JNIEnv.GetStaticMethodID (class_ref, "getDomTmpStgMax", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getDomTmpStgMax);
				} finally {
				}
			}
		}

		static IntPtr id_getItsTmpStgMax;
		public static unsafe int ItsTmpStgMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='EnvironmentUtilities']/method[@name='getItsTmpStgMax' and count(parameter)=0]"
			[Register ("getItsTmpStgMax", "()I", "GetGetItsTmpStgMaxHandler")]
			get {
				if (id_getItsTmpStgMax == IntPtr.Zero)
					id_getItsTmpStgMax = JNIEnv.GetStaticMethodID (class_ref, "getItsTmpStgMax", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getItsTmpStgMax);
				} finally {
				}
			}
		}

		static IntPtr id_getMapTmpStgMax;
		public static unsafe int MapTmpStgMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='EnvironmentUtilities']/method[@name='getMapTmpStgMax' and count(parameter)=0]"
			[Register ("getMapTmpStgMax", "()I", "GetGetMapTmpStgMaxHandler")]
			get {
				if (id_getMapTmpStgMax == IntPtr.Zero)
					id_getMapTmpStgMax = JNIEnv.GetStaticMethodID (class_ref, "getMapTmpStgMax", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getMapTmpStgMax);
				} finally {
				}
			}
		}

		static IntPtr id_getSDCardPath;
		static IntPtr id_setSDCardPath_Ljava_lang_String_;
		public static unsafe string SDCardPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='EnvironmentUtilities']/method[@name='getSDCardPath' and count(parameter)=0]"
			[Register ("getSDCardPath", "()Ljava/lang/String;", "GetGetSDCardPathHandler")]
			get {
				if (id_getSDCardPath == IntPtr.Zero)
					id_getSDCardPath = JNIEnv.GetStaticMethodID (class_ref, "getSDCardPath", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSDCardPath), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='EnvironmentUtilities']/method[@name='setSDCardPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSDCardPath", "(Ljava/lang/String;)V", "GetSetSDCardPath_Ljava_lang_String_Handler")]
			set {
				if (id_setSDCardPath_Ljava_lang_String_ == IntPtr.Zero)
					id_setSDCardPath_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setSDCardPath", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setSDCardPath_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_initAppDirectory_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='EnvironmentUtilities']/method[@name='initAppDirectory' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initAppDirectory", "(Landroid/content/Context;)V", "")]
		public static unsafe void InitAppDirectory (global::Android.Content.Context p0)
		{
			if (id_initAppDirectory_Landroid_content_Context_ == IntPtr.Zero)
				id_initAppDirectory_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "initAppDirectory", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initAppDirectory_Landroid_content_Context_, __args);
			} finally {
			}
		}

	}
}
