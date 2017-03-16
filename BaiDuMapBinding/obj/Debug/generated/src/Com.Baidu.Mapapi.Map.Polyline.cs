using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polyline']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/Polyline", DoNotGenerateAcw=true)]
	public sealed partial class Polyline : global::Com.Baidu.Mapapi.Map.Overlay {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/Polyline", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Polyline); }
		}

		internal Polyline (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getColor;
		static IntPtr id_setColor_I;
		public unsafe int Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polyline']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()I", "GetGetColorHandler")]
			get {
				if (id_getColor == IntPtr.Zero)
					id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getColor);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polyline']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setColor", "(I)V", "GetSetColor_IHandler")]
			set {
				if (id_setColor_I == IntPtr.Zero)
					id_setColor_I = JNIEnv.GetMethodID (class_ref, "setColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setColor_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_isDottedLine;
		static IntPtr id_setDottedLine_Z;
		public unsafe bool DottedLine {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polyline']/method[@name='isDottedLine' and count(parameter)=0]"
			[Register ("isDottedLine", "()Z", "GetIsDottedLineHandler")]
			get {
				if (id_isDottedLine == IntPtr.Zero)
					id_isDottedLine = JNIEnv.GetMethodID (class_ref, "isDottedLine", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDottedLine);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polyline']/method[@name='setDottedLine' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDottedLine", "(Z)V", "GetSetDottedLine_ZHandler")]
			set {
				if (id_setDottedLine_Z == IntPtr.Zero)
					id_setDottedLine_Z = JNIEnv.GetMethodID (class_ref, "setDottedLine", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDottedLine_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_isFocus;
		static IntPtr id_setFocus_Z;
		public unsafe bool Focus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polyline']/method[@name='isFocus' and count(parameter)=0]"
			[Register ("isFocus", "()Z", "GetIsFocusHandler")]
			get {
				if (id_isFocus == IntPtr.Zero)
					id_isFocus = JNIEnv.GetMethodID (class_ref, "isFocus", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFocus);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polyline']/method[@name='setFocus' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFocus", "(Z)V", "GetSetFocus_ZHandler")]
			set {
				if (id_setFocus_Z == IntPtr.Zero)
					id_setFocus_Z = JNIEnv.GetMethodID (class_ref, "setFocus", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFocus_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getPoints;
		static IntPtr id_setPoints_Ljava_util_List_;
		public unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Model.LatLng> Points {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polyline']/method[@name='getPoints' and count(parameter)=0]"
			[Register ("getPoints", "()Ljava/util/List;", "GetGetPointsHandler")]
			get {
				if (id_getPoints == IntPtr.Zero)
					id_getPoints = JNIEnv.GetMethodID (class_ref, "getPoints", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Model.LatLng>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPoints), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polyline']/method[@name='setPoints' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.baidu.mapapi.model.LatLng&gt;']]"
			[Register ("setPoints", "(Ljava/util/List;)V", "GetSetPoints_Ljava_util_List_Handler")]
			set {
				if (id_setPoints_Ljava_util_List_ == IntPtr.Zero)
					id_setPoints_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setPoints", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Model.LatLng>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPoints_Ljava_util_List_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getWidth;
		static IntPtr id_setWidth_I;
		public unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polyline']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWidth);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polyline']/method[@name='setWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setWidth", "(I)V", "GetSetWidth_IHandler")]
			set {
				if (id_setWidth_I == IntPtr.Zero)
					id_setWidth_I = JNIEnv.GetMethodID (class_ref, "setWidth", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWidth_I, __args);
				} finally {
				}
			}
		}

	}
}
