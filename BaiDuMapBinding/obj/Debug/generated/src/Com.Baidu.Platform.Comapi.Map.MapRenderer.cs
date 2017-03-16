using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='MapRenderer']"
	[global::Android.Runtime.Register ("com/baidu/platform/comapi/map/MapRenderer", DoNotGenerateAcw=true)]
	public partial class MapRenderer : global::Java.Lang.Object, global::Android.Opengl.GLSurfaceView.IRenderer {


		static IntPtr b_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='MapRenderer']/field[@name='b']"
		[Register ("b")]
		public int B {
			get {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, b_jfieldId);
			}
			set {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, b_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr c_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='MapRenderer']/field[@name='c']"
		[Register ("c")]
		public int C {
			get {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetFieldID (class_ref, "c", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, c_jfieldId);
			}
			set {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetFieldID (class_ref, "c", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, c_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/platform/comapi/map/MapRenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapRenderer); }
		}

		protected MapRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_a_J;
#pragma warning disable 0169
		static Delegate GetA_JHandler ()
		{
			if (cb_a_J == null)
				cb_a_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_A_J);
			return cb_a_J;
		}

		static void n_A_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Platform.Comapi.Map.MapRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.MapRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		static IntPtr id_a_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='MapRenderer']/method[@name='a' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("a", "(J)V", "GetA_JHandler")]
		public virtual unsafe void A (long p0)
		{
			if (id_a_J == IntPtr.Zero)
				id_a_J = JNIEnv.GetMethodID (class_ref, "a", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(J)V"), __args);
			} finally {
			}
		}

		static IntPtr id_nativeInit_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='MapRenderer']/method[@name='nativeInit' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("nativeInit", "(J)V", "")]
		public static unsafe void NativeInit (long p0)
		{
			if (id_nativeInit_J == IntPtr.Zero)
				id_nativeInit_J = JNIEnv.GetStaticMethodID (class_ref, "nativeInit", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_nativeInit_J, __args);
			} finally {
			}
		}

		static IntPtr id_nativeRender_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='MapRenderer']/method[@name='nativeRender' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("nativeRender", "(J)I", "")]
		public static unsafe int NativeRender (long p0)
		{
			if (id_nativeRender_J == IntPtr.Zero)
				id_nativeRender_J = JNIEnv.GetStaticMethodID (class_ref, "nativeRender", "(J)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_nativeRender_J, __args);
			} finally {
			}
		}

		static IntPtr id_nativeResize_JII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='MapRenderer']/method[@name='nativeResize' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("nativeResize", "(JII)V", "")]
		public static unsafe void NativeResize (long p0, int p1, int p2)
		{
			if (id_nativeResize_JII == IntPtr.Zero)
				id_nativeResize_JII = JNIEnv.GetStaticMethodID (class_ref, "nativeResize", "(JII)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_nativeResize_JII, __args);
			} finally {
			}
		}

		static Delegate cb_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_;
#pragma warning disable 0169
		static Delegate GetOnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Handler ()
		{
			if (cb_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ == null)
				cb_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_);
			return cb_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_;
		}

		static void n_OnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Platform.Comapi.Map.MapRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.MapRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Opengles.IGL10 p0 = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDrawFrame (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='MapRenderer']/method[@name='onDrawFrame' and count(parameter)=1 and parameter[1][@type='javax.microedition.khronos.opengles.GL10']]"
		[Register ("onDrawFrame", "(Ljavax/microedition/khronos/opengles/GL10;)V", "GetOnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Handler")]
		public virtual unsafe void OnDrawFrame (global::Javax.Microedition.Khronos.Opengles.IGL10 p0)
		{
			if (id_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ == IntPtr.Zero)
				id_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ = JNIEnv.GetMethodID (class_ref, "onDrawFrame", "(Ljavax/microedition/khronos/opengles/GL10;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDrawFrame", "(Ljavax/microedition/khronos/opengles/GL10;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II;
#pragma warning disable 0169
		static Delegate GetOnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_IIHandler ()
		{
			if (cb_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II == null)
				cb_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II);
			return cb_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II;
		}

		static void n_OnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Baidu.Platform.Comapi.Map.MapRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.MapRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Opengles.IGL10 p0 = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceChanged (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='MapRenderer']/method[@name='onSurfaceChanged' and count(parameter)=3 and parameter[1][@type='javax.microedition.khronos.opengles.GL10'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onSurfaceChanged", "(Ljavax/microedition/khronos/opengles/GL10;II)V", "GetOnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_IIHandler")]
		public virtual unsafe void OnSurfaceChanged (global::Javax.Microedition.Khronos.Opengles.IGL10 p0, int p1, int p2)
		{
			if (id_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II == IntPtr.Zero)
				id_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II = JNIEnv.GetMethodID (class_ref, "onSurfaceChanged", "(Ljavax/microedition/khronos/opengles/GL10;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurfaceChanged", "(Ljavax/microedition/khronos/opengles/GL10;II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_;
#pragma warning disable 0169
		static Delegate GetOnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_Handler ()
		{
			if (cb_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ == null)
				cb_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_);
			return cb_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_;
		}

		static void n_OnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comapi.Map.MapRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comapi.Map.MapRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Opengles.IGL10 p0 = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Egl.EGLConfig p1 = global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.EGLConfig> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceCreated (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.map']/class[@name='MapRenderer']/method[@name='onSurfaceCreated' and count(parameter)=2 and parameter[1][@type='javax.microedition.khronos.opengles.GL10'] and parameter[2][@type='javax.microedition.khronos.egl.EGLConfig']]"
		[Register ("onSurfaceCreated", "(Ljavax/microedition/khronos/opengles/GL10;Ljavax/microedition/khronos/egl/EGLConfig;)V", "GetOnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_Handler")]
		public virtual unsafe void OnSurfaceCreated (global::Javax.Microedition.Khronos.Opengles.IGL10 p0, global::Javax.Microedition.Khronos.Egl.EGLConfig p1)
		{
			if (id_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ == IntPtr.Zero)
				id_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ = JNIEnv.GetMethodID (class_ref, "onSurfaceCreated", "(Ljavax/microedition/khronos/opengles/GL10;Ljavax/microedition/khronos/egl/EGLConfig;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurfaceCreated", "(Ljavax/microedition/khronos/opengles/GL10;Ljavax/microedition/khronos/egl/EGLConfig;)V"), __args);
			} finally {
			}
		}

	}
}
