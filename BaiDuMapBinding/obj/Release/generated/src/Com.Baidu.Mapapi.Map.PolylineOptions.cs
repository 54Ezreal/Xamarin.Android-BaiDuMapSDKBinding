using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/PolylineOptions", DoNotGenerateAcw=true)]
	public sealed partial class PolylineOptions : global::Com.Baidu.Mapapi.Map.OverlayOptions {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/PolylineOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PolylineOptions); }
		}

		internal PolylineOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/constructor[@name='PolylineOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PolylineOptions ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PolylineOptions)) {
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

		static IntPtr id_getColor;
		public unsafe int Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()I", "GetGetColorHandler")]
			get {
				if (id_getColor == IntPtr.Zero)
					id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getColor);
				} finally {
				}
			}
		}

		static IntPtr id_getCustomTexture;
		public unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor CustomTexture {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='getCustomTexture' and count(parameter)=0]"
			[Register ("getCustomTexture", "()Lcom/baidu/mapapi/map/BitmapDescriptor;", "GetGetCustomTextureHandler")]
			get {
				if (id_getCustomTexture == IntPtr.Zero)
					id_getCustomTexture = JNIEnv.GetMethodID (class_ref, "getCustomTexture", "()Lcom/baidu/mapapi/map/BitmapDescriptor;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCustomTexture), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getCustomTextureList;
		public unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> CustomTextureList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='getCustomTextureList' and count(parameter)=0]"
			[Register ("getCustomTextureList", "()Ljava/util/List;", "GetGetCustomTextureListHandler")]
			get {
				if (id_getCustomTextureList == IntPtr.Zero)
					id_getCustomTextureList = JNIEnv.GetMethodID (class_ref, "getCustomTextureList", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.BitmapDescriptor>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCustomTextureList), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getExtraInfo;
		public unsafe global::Android.OS.Bundle ExtraInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='getExtraInfo' and count(parameter)=0]"
			[Register ("getExtraInfo", "()Landroid/os/Bundle;", "GetGetExtraInfoHandler")]
			get {
				if (id_getExtraInfo == IntPtr.Zero)
					id_getExtraInfo = JNIEnv.GetMethodID (class_ref, "getExtraInfo", "()Landroid/os/Bundle;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExtraInfo), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isDottedLine;
		public unsafe bool IsDottedLine {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='isDottedLine' and count(parameter)=0]"
			[Register ("isDottedLine", "()Z", "GetIsDottedLineHandler")]
			get {
				if (id_isDottedLine == IntPtr.Zero)
					id_isDottedLine = JNIEnv.GetMethodID (class_ref, "isDottedLine", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDottedLine);
				} finally {
				}
			}
		}

		static IntPtr id_isFocus;
		public unsafe bool IsFocus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='isFocus' and count(parameter)=0]"
			[Register ("isFocus", "()Z", "GetIsFocusHandler")]
			get {
				if (id_isFocus == IntPtr.Zero)
					id_isFocus = JNIEnv.GetMethodID (class_ref, "isFocus", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFocus);
				} finally {
				}
			}
		}

		static IntPtr id_isVisible;
		public unsafe bool IsVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isVisible);
				} finally {
				}
			}
		}

		static IntPtr id_getPoints;
		public unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Model.LatLng> Points {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='getPoints' and count(parameter)=0]"
			[Register ("getPoints", "()Ljava/util/List;", "GetGetPointsHandler")]
			get {
				if (id_getPoints == IntPtr.Zero)
					id_getPoints = JNIEnv.GetMethodID (class_ref, "getPoints", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Model.LatLng>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPoints), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getTextureIndexs;
		public unsafe global::System.Collections.Generic.IList<global::Java.Lang.Integer> TextureIndexs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='getTextureIndexs' and count(parameter)=0]"
			[Register ("getTextureIndexs", "()Ljava/util/List;", "GetGetTextureIndexsHandler")]
			get {
				if (id_getTextureIndexs == IntPtr.Zero)
					id_getTextureIndexs = JNIEnv.GetMethodID (class_ref, "getTextureIndexs", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTextureIndexs), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getWidth;
		public unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWidth);
				} finally {
				}
			}
		}

		static IntPtr id_getZIndex;
		public unsafe int ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='getZIndex' and count(parameter)=0]"
			[Register ("getZIndex", "()I", "GetGetZIndexHandler")]
			get {
				if (id_getZIndex == IntPtr.Zero)
					id_getZIndex = JNIEnv.GetMethodID (class_ref, "getZIndex", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getZIndex);
				} finally {
				}
			}
		}

		static IntPtr id_color_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='color' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("color", "(I)Lcom/baidu/mapapi/map/PolylineOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolylineOptions InvokeColor (int p0)
		{
			if (id_color_I == IntPtr.Zero)
				id_color_I = JNIEnv.GetMethodID (class_ref, "color", "(I)Lcom/baidu/mapapi/map/PolylineOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_color_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_colorsValues_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='colorsValues' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Integer&gt;']]"
		[Register ("colorsValues", "(Ljava/util/List;)Lcom/baidu/mapapi/map/PolylineOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolylineOptions ColorsValues (global::System.Collections.Generic.IList<global::Java.Lang.Integer> p0)
		{
			if (id_colorsValues_Ljava_util_List_ == IntPtr.Zero)
				id_colorsValues_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "colorsValues", "(Ljava/util/List;)Lcom/baidu/mapapi/map/PolylineOptions;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Baidu.Mapapi.Map.PolylineOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_colorsValues_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_customTexture_Lcom_baidu_mapapi_map_BitmapDescriptor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='customTexture' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BitmapDescriptor']]"
		[Register ("customTexture", "(Lcom/baidu/mapapi/map/BitmapDescriptor;)Lcom/baidu/mapapi/map/PolylineOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolylineOptions InvokeCustomTexture (global::Com.Baidu.Mapapi.Map.BitmapDescriptor p0)
		{
			if (id_customTexture_Lcom_baidu_mapapi_map_BitmapDescriptor_ == IntPtr.Zero)
				id_customTexture_Lcom_baidu_mapapi_map_BitmapDescriptor_ = JNIEnv.GetMethodID (class_ref, "customTexture", "(Lcom/baidu/mapapi/map/BitmapDescriptor;)Lcom/baidu/mapapi/map/PolylineOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.PolylineOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_customTexture_Lcom_baidu_mapapi_map_BitmapDescriptor_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_customTextureList_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='customTextureList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.baidu.mapapi.map.BitmapDescriptor&gt;']]"
		[Register ("customTextureList", "(Ljava/util/List;)Lcom/baidu/mapapi/map/PolylineOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolylineOptions InvokeCustomTextureList (global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> p0)
		{
			if (id_customTextureList_Ljava_util_List_ == IntPtr.Zero)
				id_customTextureList_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "customTextureList", "(Ljava/util/List;)Lcom/baidu/mapapi/map/PolylineOptions;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.BitmapDescriptor>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Baidu.Mapapi.Map.PolylineOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_customTextureList_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_dottedLine_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='dottedLine' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("dottedLine", "(Z)Lcom/baidu/mapapi/map/PolylineOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolylineOptions DottedLine (bool p0)
		{
			if (id_dottedLine_Z == IntPtr.Zero)
				id_dottedLine_Z = JNIEnv.GetMethodID (class_ref, "dottedLine", "(Z)Lcom/baidu/mapapi/map/PolylineOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_dottedLine_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_extraInfo_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='extraInfo' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("extraInfo", "(Landroid/os/Bundle;)Lcom/baidu/mapapi/map/PolylineOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolylineOptions InvokeExtraInfo (global::Android.OS.Bundle p0)
		{
			if (id_extraInfo_Landroid_os_Bundle_ == IntPtr.Zero)
				id_extraInfo_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "extraInfo", "(Landroid/os/Bundle;)Lcom/baidu/mapapi/map/PolylineOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.PolylineOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_extraInfo_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_focus_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='focus' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("focus", "(Z)Lcom/baidu/mapapi/map/PolylineOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolylineOptions Focus (bool p0)
		{
			if (id_focus_Z == IntPtr.Zero)
				id_focus_Z = JNIEnv.GetMethodID (class_ref, "focus", "(Z)Lcom/baidu/mapapi/map/PolylineOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_focus_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_keepScale_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='keepScale' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("keepScale", "(Z)Lcom/baidu/mapapi/map/PolylineOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolylineOptions KeepScale (bool p0)
		{
			if (id_keepScale_Z == IntPtr.Zero)
				id_keepScale_Z = JNIEnv.GetMethodID (class_ref, "keepScale", "(Z)Lcom/baidu/mapapi/map/PolylineOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_keepScale_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_points_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='points' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.baidu.mapapi.model.LatLng&gt;']]"
		[Register ("points", "(Ljava/util/List;)Lcom/baidu/mapapi/map/PolylineOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolylineOptions InvokePoints (global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Model.LatLng> p0)
		{
			if (id_points_Ljava_util_List_ == IntPtr.Zero)
				id_points_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "points", "(Ljava/util/List;)Lcom/baidu/mapapi/map/PolylineOptions;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Model.LatLng>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Baidu.Mapapi.Map.PolylineOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_points_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_textureIndex_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='textureIndex' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Integer&gt;']]"
		[Register ("textureIndex", "(Ljava/util/List;)Lcom/baidu/mapapi/map/PolylineOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolylineOptions TextureIndex (global::System.Collections.Generic.IList<global::Java.Lang.Integer> p0)
		{
			if (id_textureIndex_Ljava_util_List_ == IntPtr.Zero)
				id_textureIndex_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "textureIndex", "(Ljava/util/List;)Lcom/baidu/mapapi/map/PolylineOptions;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Baidu.Mapapi.Map.PolylineOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_textureIndex_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_visible_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='visible' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("visible", "(Z)Lcom/baidu/mapapi/map/PolylineOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolylineOptions Visible (bool p0)
		{
			if (id_visible_Z == IntPtr.Zero)
				id_visible_Z = JNIEnv.GetMethodID (class_ref, "visible", "(Z)Lcom/baidu/mapapi/map/PolylineOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_visible_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_width_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='width' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("width", "(I)Lcom/baidu/mapapi/map/PolylineOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolylineOptions InvokeWidth (int p0)
		{
			if (id_width_I == IntPtr.Zero)
				id_width_I = JNIEnv.GetMethodID (class_ref, "width", "(I)Lcom/baidu/mapapi/map/PolylineOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_width_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_zIndex_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='zIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("zIndex", "(I)Lcom/baidu/mapapi/map/PolylineOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolylineOptions InvokeZIndex (int p0)
		{
			if (id_zIndex_I == IntPtr.Zero)
				id_zIndex_I = JNIEnv.GetMethodID (class_ref, "zIndex", "(I)Lcom/baidu/mapapi/map/PolylineOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_zIndex_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
