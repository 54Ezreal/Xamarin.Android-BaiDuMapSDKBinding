using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comjni.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.platform.comjni.util']/class[@name='JNISysOSAPI']"
	[global::Android.Runtime.Register ("com/baidu/platform/comjni/util/JNISysOSAPI", DoNotGenerateAcw=true)]
	public partial class JNISysOSAPI : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/platform/comjni/util/JNISysOSAPI", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JNISysOSAPI); }
		}

		protected JNISysOSAPI (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.util']/class[@name='JNISysOSAPI']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()V", "")]
		public static unsafe void Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetStaticMethodID (class_ref, "create", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_create);
			} finally {
			}
		}

		static IntPtr id_init_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.util']/class[@name='JNISysOSAPI']/method[@name='init' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("init", "(Ljava/lang/Object;)V", "")]
		public static unsafe void Init (global::Java.Lang.Object p0)
		{
			if (id_init_Ljava_lang_Object_ == IntPtr.Zero)
				id_init_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_init_Ljava_lang_Object_, __args);
			} finally {
			}
		}

	}
}
