using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BitmapDescriptorFactory']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/BitmapDescriptorFactory", DoNotGenerateAcw=true)]
	public partial class BitmapDescriptorFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/BitmapDescriptorFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BitmapDescriptorFactory); }
		}

		protected BitmapDescriptorFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BitmapDescriptorFactory']/constructor[@name='BitmapDescriptorFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BitmapDescriptorFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BitmapDescriptorFactory)) {
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

		static IntPtr id_fromAsset_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BitmapDescriptorFactory']/method[@name='fromAsset' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromAsset", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/BitmapDescriptor;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor FromAsset (string p0)
		{
			if (id_fromAsset_Ljava_lang_String_ == IntPtr.Zero)
				id_fromAsset_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromAsset", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/BitmapDescriptor;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Baidu.Mapapi.Map.BitmapDescriptor __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromAsset_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_fromAssetWithDpi_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BitmapDescriptorFactory']/method[@name='fromAssetWithDpi' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromAssetWithDpi", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/BitmapDescriptor;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor FromAssetWithDpi (string p0)
		{
			if (id_fromAssetWithDpi_Ljava_lang_String_ == IntPtr.Zero)
				id_fromAssetWithDpi_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromAssetWithDpi", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/BitmapDescriptor;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Baidu.Mapapi.Map.BitmapDescriptor __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromAssetWithDpi_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_fromBitmap_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BitmapDescriptorFactory']/method[@name='fromBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("fromBitmap", "(Landroid/graphics/Bitmap;)Lcom/baidu/mapapi/map/BitmapDescriptor;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor FromBitmap (global::Android.Graphics.Bitmap p0)
		{
			if (id_fromBitmap_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_fromBitmap_Landroid_graphics_Bitmap_ = JNIEnv.GetStaticMethodID (class_ref, "fromBitmap", "(Landroid/graphics/Bitmap;)Lcom/baidu/mapapi/map/BitmapDescriptor;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.BitmapDescriptor __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromBitmap_Landroid_graphics_Bitmap_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromFile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BitmapDescriptorFactory']/method[@name='fromFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromFile", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/BitmapDescriptor;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor FromFile (string p0)
		{
			if (id_fromFile_Ljava_lang_String_ == IntPtr.Zero)
				id_fromFile_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromFile", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/BitmapDescriptor;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Baidu.Mapapi.Map.BitmapDescriptor __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromFile_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_fromPath_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BitmapDescriptorFactory']/method[@name='fromPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromPath", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/BitmapDescriptor;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor FromPath (string p0)
		{
			if (id_fromPath_Ljava_lang_String_ == IntPtr.Zero)
				id_fromPath_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromPath", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/BitmapDescriptor;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Baidu.Mapapi.Map.BitmapDescriptor __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromPath_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_fromResource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BitmapDescriptorFactory']/method[@name='fromResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromResource", "(I)Lcom/baidu/mapapi/map/BitmapDescriptor;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor FromResource (int p0)
		{
			if (id_fromResource_I == IntPtr.Zero)
				id_fromResource_I = JNIEnv.GetStaticMethodID (class_ref, "fromResource", "(I)Lcom/baidu/mapapi/map/BitmapDescriptor;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromResource_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_fromView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BitmapDescriptorFactory']/method[@name='fromView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("fromView", "(Landroid/view/View;)Lcom/baidu/mapapi/map/BitmapDescriptor;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor FromView (global::Android.Views.View p0)
		{
			if (id_fromView_Landroid_view_View_ == IntPtr.Zero)
				id_fromView_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "fromView", "(Landroid/view/View;)Lcom/baidu/mapapi/map/BitmapDescriptor;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.BitmapDescriptor __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromView_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
