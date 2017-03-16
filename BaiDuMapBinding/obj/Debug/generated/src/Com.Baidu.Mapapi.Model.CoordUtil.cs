using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='CoordUtil']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/model/CoordUtil", DoNotGenerateAcw=true)]
	public partial class CoordUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/model/CoordUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CoordUtil); }
		}

		protected CoordUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='CoordUtil']/constructor[@name='CoordUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CoordUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CoordUtil)) {
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

		static IntPtr id_Coordinate_encryptEx_FFLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='CoordUtil']/method[@name='Coordinate_encryptEx' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='java.lang.String']]"
		[Register ("Coordinate_encryptEx", "(FFLjava/lang/String;)Lcom/baidu/mapapi/model/LatLng;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Model.LatLng Coordinate_encryptEx (float p0, float p1, string p2)
		{
			if (id_Coordinate_encryptEx_FFLjava_lang_String_ == IntPtr.Zero)
				id_Coordinate_encryptEx_FFLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "Coordinate_encryptEx", "(FFLjava/lang/String;)Lcom/baidu/mapapi/model/LatLng;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				global::Com.Baidu.Mapapi.Model.LatLng __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallStaticObjectMethod  (class_ref, id_Coordinate_encryptEx_FFLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_decodeLocation_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='CoordUtil']/method[@name='decodeLocation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeLocation", "(Ljava/lang/String;)Lcom/baidu/mapapi/model/LatLng;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Model.LatLng DecodeLocation (string p0)
		{
			if (id_decodeLocation_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeLocation_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decodeLocation", "(Ljava/lang/String;)Lcom/baidu/mapapi/model/LatLng;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Baidu.Mapapi.Model.LatLng __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeLocation_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_decodeLocationList2D_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='CoordUtil']/method[@name='decodeLocationList2D' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeLocationList2D", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Model.LatLng>> DecodeLocationList2D (string p0)
		{
			if (id_decodeLocationList2D_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeLocationList2D_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decodeLocationList2D", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Model.LatLng>> __ret = global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Model.LatLng>>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeLocationList2D_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_decodeLocationList_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='CoordUtil']/method[@name='decodeLocationList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeLocationList", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Model.LatLng> DecodeLocationList (string p0)
		{
			if (id_decodeLocationList_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeLocationList_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decodeLocationList", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Model.LatLng> __ret = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Model.LatLng>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeLocationList_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_decodeNodeLocation_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='CoordUtil']/method[@name='decodeNodeLocation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeNodeLocation", "(Ljava/lang/String;)Lcom/baidu/mapapi/model/LatLng;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Model.LatLng DecodeNodeLocation (string p0)
		{
			if (id_decodeNodeLocation_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeNodeLocation_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decodeNodeLocation", "(Ljava/lang/String;)Lcom/baidu/mapapi/model/LatLng;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Baidu.Mapapi.Model.LatLng __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeNodeLocation_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getDistance_Lcom_baidu_mapapi_model_inner_Point_Lcom_baidu_mapapi_model_inner_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='CoordUtil']/method[@name='getDistance' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.model.inner.Point'] and parameter[2][@type='com.baidu.mapapi.model.inner.Point']]"
		[Register ("getDistance", "(Lcom/baidu/mapapi/model/inner/Point;Lcom/baidu/mapapi/model/inner/Point;)D", "")]
		public static unsafe double GetDistance (global::Com.Baidu.Mapapi.Model.Inner.Point p0, global::Com.Baidu.Mapapi.Model.Inner.Point p1)
		{
			if (id_getDistance_Lcom_baidu_mapapi_model_inner_Point_Lcom_baidu_mapapi_model_inner_Point_ == IntPtr.Zero)
				id_getDistance_Lcom_baidu_mapapi_model_inner_Point_Lcom_baidu_mapapi_model_inner_Point_ = JNIEnv.GetStaticMethodID (class_ref, "getDistance", "(Lcom/baidu/mapapi/model/inner/Point;Lcom/baidu/mapapi/model/inner/Point;)D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_getDistance_Lcom_baidu_mapapi_model_inner_Point_Lcom_baidu_mapapi_model_inner_Point_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getMCDistanceByOneLatLngAndRadius_Lcom_baidu_mapapi_model_LatLng_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='CoordUtil']/method[@name='getMCDistanceByOneLatLngAndRadius' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.model.LatLng'] and parameter[2][@type='int']]"
		[Register ("getMCDistanceByOneLatLngAndRadius", "(Lcom/baidu/mapapi/model/LatLng;I)I", "")]
		public static unsafe int GetMCDistanceByOneLatLngAndRadius (global::Com.Baidu.Mapapi.Model.LatLng p0, int p1)
		{
			if (id_getMCDistanceByOneLatLngAndRadius_Lcom_baidu_mapapi_model_LatLng_I == IntPtr.Zero)
				id_getMCDistanceByOneLatLngAndRadius_Lcom_baidu_mapapi_model_LatLng_I = JNIEnv.GetStaticMethodID (class_ref, "getMCDistanceByOneLatLngAndRadius", "(Lcom/baidu/mapapi/model/LatLng;I)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getMCDistanceByOneLatLngAndRadius_Lcom_baidu_mapapi_model_LatLng_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ll2mc_Lcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='CoordUtil']/method[@name='ll2mc' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("ll2mc", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/model/inner/GeoPoint;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Model.Inner.GeoPoint Ll2mc (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			if (id_ll2mc_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_ll2mc_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetStaticMethodID (class_ref, "ll2mc", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/model/inner/GeoPoint;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Model.Inner.GeoPoint __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.GeoPoint> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ll2mc_Lcom_baidu_mapapi_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ll2point_Lcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='CoordUtil']/method[@name='ll2point' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("ll2point", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/model/inner/Point;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Model.Inner.Point Ll2point (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			if (id_ll2point_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_ll2point_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetStaticMethodID (class_ref, "ll2point", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/model/inner/Point;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Model.Inner.Point __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.Point> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ll2point_Lcom_baidu_mapapi_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_mc2ll_Lcom_baidu_mapapi_model_inner_GeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='CoordUtil']/method[@name='mc2ll' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.inner.GeoPoint']]"
		[Register ("mc2ll", "(Lcom/baidu/mapapi/model/inner/GeoPoint;)Lcom/baidu/mapapi/model/LatLng;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Model.LatLng Mc2ll (global::Com.Baidu.Mapapi.Model.Inner.GeoPoint p0)
		{
			if (id_mc2ll_Lcom_baidu_mapapi_model_inner_GeoPoint_ == IntPtr.Zero)
				id_mc2ll_Lcom_baidu_mapapi_model_inner_GeoPoint_ = JNIEnv.GetStaticMethodID (class_ref, "mc2ll", "(Lcom/baidu/mapapi/model/inner/GeoPoint;)Lcom/baidu/mapapi/model/LatLng;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Model.LatLng __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallStaticObjectMethod  (class_ref, id_mc2ll_Lcom_baidu_mapapi_model_inner_GeoPoint_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
