using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comjni.Map.Basemap {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']"
	[global::Android.Runtime.Register ("com/baidu/platform/comjni/map/basemap/JNIBaseMap", DoNotGenerateAcw=true)]
	public partial class JNIBaseMap : global::Java.Lang.Object {


		static IntPtr a_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/field[@name='a']"
		[Register ("a")]
		public long A {
			get {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, a_jfieldId);
			}
			set {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, a_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/platform/comjni/map/basemap/JNIBaseMap", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JNIBaseMap); }
		}

		protected JNIBaseMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/constructor[@name='JNIBaseMap' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JNIBaseMap ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (JNIBaseMap)) {
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

		static Delegate cb_AddLayer_JIILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddLayer_JIILjava_lang_String_Handler ()
		{
			if (cb_AddLayer_JIILjava_lang_String_ == null)
				cb_AddLayer_JIILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, int, IntPtr, long>) n_AddLayer_JIILjava_lang_String_);
			return cb_AddLayer_JIILjava_lang_String_;
		}

		static long n_AddLayer_JIILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, int p1, int p2, IntPtr native_p3)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.AddLayer (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddLayer_JIILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='AddLayer' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("AddLayer", "(JIILjava/lang/String;)J", "GetAddLayer_JIILjava_lang_String_Handler")]
		public virtual unsafe long AddLayer (long p0, int p1, int p2, string p3)
		{
			if (id_AddLayer_JIILjava_lang_String_ == IntPtr.Zero)
				id_AddLayer_JIILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "AddLayer", "(JIILjava/lang/String;)J");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);

				long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_AddLayer_JIILjava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddLayer", "(JIILjava/lang/String;)J"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_ClearLayer_JJ;
#pragma warning disable 0169
		static Delegate GetClearLayer_JJHandler ()
		{
			if (cb_ClearLayer_JJ == null)
				cb_ClearLayer_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, long>) n_ClearLayer_JJ);
			return cb_ClearLayer_JJ;
		}

		static void n_ClearLayer_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearLayer (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_ClearLayer_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='ClearLayer' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("ClearLayer", "(JJ)V", "GetClearLayer_JJHandler")]
		public virtual unsafe void ClearLayer (long p0, long p1)
		{
			if (id_ClearLayer_JJ == IntPtr.Zero)
				id_ClearLayer_JJ = JNIEnv.GetMethodID (class_ref, "ClearLayer", "(JJ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ClearLayer_JJ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ClearLayer", "(JJ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_Create;
#pragma warning disable 0169
		static Delegate GetCreateHandler ()
		{
			if (cb_Create == null)
				cb_Create = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Create);
			return cb_Create;
		}

		static long n_Create (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Create ();
		}
#pragma warning restore 0169

		static IntPtr id_Create;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='Create' and count(parameter)=0]"
		[Register ("Create", "()J", "GetCreateHandler")]
		public virtual unsafe long Create ()
		{
			if (id_Create == IntPtr.Zero)
				id_Create = JNIEnv.GetMethodID (class_ref, "Create", "()J");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_Create);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Create", "()J"));
			} finally {
			}
		}

		static Delegate cb_CreateDuplicate_J;
#pragma warning disable 0169
		static Delegate GetCreateDuplicate_JHandler ()
		{
			if (cb_CreateDuplicate_J == null)
				cb_CreateDuplicate_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long>) n_CreateDuplicate_J);
			return cb_CreateDuplicate_J;
		}

		static long n_CreateDuplicate_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CreateDuplicate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_CreateDuplicate_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='CreateDuplicate' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("CreateDuplicate", "(J)J", "GetCreateDuplicate_JHandler")]
		public virtual unsafe long CreateDuplicate (long p0)
		{
			if (id_CreateDuplicate_J == IntPtr.Zero)
				id_CreateDuplicate_J = JNIEnv.GetMethodID (class_ref, "CreateDuplicate", "(J)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_CreateDuplicate_J, __args);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "CreateDuplicate", "(J)J"), __args);
			} finally {
			}
		}

		static Delegate cb_GeoPtToScrPoint_JII;
#pragma warning disable 0169
		static Delegate GetGeoPtToScrPoint_JIIHandler ()
		{
			if (cb_GeoPtToScrPoint_JII == null)
				cb_GeoPtToScrPoint_JII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, int, IntPtr>) n_GeoPtToScrPoint_JII);
			return cb_GeoPtToScrPoint_JII;
		}

		static IntPtr n_GeoPtToScrPoint_JII (IntPtr jnienv, IntPtr native__this, long p0, int p1, int p2)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GeoPtToScrPoint (p0, p1, p2));
		}
#pragma warning restore 0169

		static IntPtr id_GeoPtToScrPoint_JII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='GeoPtToScrPoint' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("GeoPtToScrPoint", "(JII)Ljava/lang/String;", "GetGeoPtToScrPoint_JIIHandler")]
		public virtual unsafe string GeoPtToScrPoint (long p0, int p1, int p2)
		{
			if (id_GeoPtToScrPoint_JII == IntPtr.Zero)
				id_GeoPtToScrPoint_JII = JNIEnv.GetMethodID (class_ref, "GeoPtToScrPoint", "(JII)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GeoPtToScrPoint_JII, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GeoPtToScrPoint", "(JII)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_GetBaiduHotMapCityInfo_J;
#pragma warning disable 0169
		static Delegate GetGetBaiduHotMapCityInfo_JHandler ()
		{
			if (cb_GetBaiduHotMapCityInfo_J == null)
				cb_GetBaiduHotMapCityInfo_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_GetBaiduHotMapCityInfo_J);
			return cb_GetBaiduHotMapCityInfo_J;
		}

		static bool n_GetBaiduHotMapCityInfo_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetBaiduHotMapCityInfo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_GetBaiduHotMapCityInfo_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='GetBaiduHotMapCityInfo' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("GetBaiduHotMapCityInfo", "(J)Z", "GetGetBaiduHotMapCityInfo_JHandler")]
		public virtual unsafe bool GetBaiduHotMapCityInfo (long p0)
		{
			if (id_GetBaiduHotMapCityInfo_J == IntPtr.Zero)
				id_GetBaiduHotMapCityInfo_J = JNIEnv.GetMethodID (class_ref, "GetBaiduHotMapCityInfo", "(J)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetBaiduHotMapCityInfo_J, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetBaiduHotMapCityInfo", "(J)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_GetMapStatus_J;
#pragma warning disable 0169
		static Delegate GetGetMapStatus_JHandler ()
		{
			if (cb_GetMapStatus_J == null)
				cb_GetMapStatus_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_GetMapStatus_J);
			return cb_GetMapStatus_J;
		}

		static IntPtr n_GetMapStatus_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetMapStatus (p0));
		}
#pragma warning restore 0169

		static IntPtr id_GetMapStatus_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='GetMapStatus' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("GetMapStatus", "(J)Landroid/os/Bundle;", "GetGetMapStatus_JHandler")]
		public virtual unsafe global::Android.OS.Bundle GetMapStatus (long p0)
		{
			if (id_GetMapStatus_J == IntPtr.Zero)
				id_GetMapStatus_J = JNIEnv.GetMethodID (class_ref, "GetMapStatus", "(J)Landroid/os/Bundle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetMapStatus_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetMapStatus", "(J)Landroid/os/Bundle;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_GetNearlyObjID_JJIII;
#pragma warning disable 0169
		static Delegate GetGetNearlyObjID_JJIIIHandler ()
		{
			if (cb_GetNearlyObjID_JJIII == null)
				cb_GetNearlyObjID_JJIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long, int, int, int, IntPtr>) n_GetNearlyObjID_JJIII);
			return cb_GetNearlyObjID_JJIII;
		}

		static IntPtr n_GetNearlyObjID_JJIII (IntPtr jnienv, IntPtr native__this, long p0, long p1, int p2, int p3, int p4)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetNearlyObjID (p0, p1, p2, p3, p4));
		}
#pragma warning restore 0169

		static IntPtr id_GetNearlyObjID_JJIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='GetNearlyObjID' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("GetNearlyObjID", "(JJIII)Ljava/lang/String;", "GetGetNearlyObjID_JJIIIHandler")]
		public virtual unsafe string GetNearlyObjID (long p0, long p1, int p2, int p3, int p4)
		{
			if (id_GetNearlyObjID_JJIII == IntPtr.Zero)
				id_GetNearlyObjID_JJIII = JNIEnv.GetMethodID (class_ref, "GetNearlyObjID", "(JJIII)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetNearlyObjID_JJIII, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetNearlyObjID", "(JJIII)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_GetScreenBuf_JarrayIII;
#pragma warning disable 0169
		static Delegate GetGetScreenBuf_JarrayIIIHandler ()
		{
			if (cb_GetScreenBuf_JarrayIII == null)
				cb_GetScreenBuf_JarrayIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, int, int, IntPtr>) n_GetScreenBuf_JarrayIII);
			return cb_GetScreenBuf_JarrayIII;
		}

		static IntPtr n_GetScreenBuf_JarrayIII (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, int p2, int p3)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.NewArray (__this.GetScreenBuf (p0, p1, p2, p3));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetScreenBuf_JarrayIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='GetScreenBuf' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='int[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("GetScreenBuf", "(J[III)[I", "GetGetScreenBuf_JarrayIIIHandler")]
		public virtual unsafe int[] GetScreenBuf (long p0, int[] p1, int p2, int p3)
		{
			if (id_GetScreenBuf_JarrayIII == IntPtr.Zero)
				id_GetScreenBuf_JarrayIII = JNIEnv.GetMethodID (class_ref, "GetScreenBuf", "(J[III)[I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				int[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetScreenBuf_JarrayIII, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					__ret = (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetScreenBuf", "(J[III)[I"), __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_GetZoomToBound_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetZoomToBound_JLandroid_os_Bundle_Handler ()
		{
			if (cb_GetZoomToBound_JLandroid_os_Bundle_ == null)
				cb_GetZoomToBound_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, float>) n_GetZoomToBound_JLandroid_os_Bundle_);
			return cb_GetZoomToBound_JLandroid_os_Bundle_;
		}

		static float n_GetZoomToBound_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetZoomToBound (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetZoomToBound_JLandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='GetZoomToBound' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("GetZoomToBound", "(JLandroid/os/Bundle;)F", "GetGetZoomToBound_JLandroid_os_Bundle_Handler")]
		public virtual unsafe float GetZoomToBound (long p0, global::Android.OS.Bundle p1)
		{
			if (id_GetZoomToBound_JLandroid_os_Bundle_ == IntPtr.Zero)
				id_GetZoomToBound_JLandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "GetZoomToBound", "(JLandroid/os/Bundle;)F");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				float __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_GetZoomToBound_JLandroid_os_Bundle_, __args);
				else
					__ret = JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetZoomToBound", "(JLandroid/os/Bundle;)F"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_IsBaseIndoorMapMode_J;
#pragma warning disable 0169
		static Delegate GetIsBaseIndoorMapMode_JHandler ()
		{
			if (cb_IsBaseIndoorMapMode_J == null)
				cb_IsBaseIndoorMapMode_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_IsBaseIndoorMapMode_J);
			return cb_IsBaseIndoorMapMode_J;
		}

		static bool n_IsBaseIndoorMapMode_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBaseIndoorMapMode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_IsBaseIndoorMapMode_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='IsBaseIndoorMapMode' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("IsBaseIndoorMapMode", "(J)Z", "GetIsBaseIndoorMapMode_JHandler")]
		public virtual unsafe bool IsBaseIndoorMapMode (long p0)
		{
			if (id_IsBaseIndoorMapMode_J == IntPtr.Zero)
				id_IsBaseIndoorMapMode_J = JNIEnv.GetMethodID (class_ref, "IsBaseIndoorMapMode", "(J)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_IsBaseIndoorMapMode_J, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "IsBaseIndoorMapMode", "(J)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_LayersIsShow_JJ;
#pragma warning disable 0169
		static Delegate GetLayersIsShow_JJHandler ()
		{
			if (cb_LayersIsShow_JJ == null)
				cb_LayersIsShow_JJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long, bool>) n_LayersIsShow_JJ);
			return cb_LayersIsShow_JJ;
		}

		static bool n_LayersIsShow_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LayersIsShow (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_LayersIsShow_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='LayersIsShow' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("LayersIsShow", "(JJ)Z", "GetLayersIsShow_JJHandler")]
		public virtual unsafe bool LayersIsShow (long p0, long p1)
		{
			if (id_LayersIsShow_JJ == IntPtr.Zero)
				id_LayersIsShow_JJ = JNIEnv.GetMethodID (class_ref, "LayersIsShow", "(JJ)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_LayersIsShow_JJ, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "LayersIsShow", "(JJ)Z"), __args);
			} finally {
			}
		}

		static IntPtr id_MapProc_JIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='MapProc' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("MapProc", "(JIII)I", "")]
		public static unsafe int MapProc (long p0, int p1, int p2, int p3)
		{
			if (id_MapProc_JIII == IntPtr.Zero)
				id_MapProc_JIII = JNIEnv.GetStaticMethodID (class_ref, "MapProc", "(JIII)I");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_MapProc_JIII, __args);
			} finally {
			}
		}

		static Delegate cb_OnBackground_J;
#pragma warning disable 0169
		static Delegate GetOnBackground_JHandler ()
		{
			if (cb_OnBackground_J == null)
				cb_OnBackground_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_OnBackground_J);
			return cb_OnBackground_J;
		}

		static void n_OnBackground_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBackground (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnBackground_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='OnBackground' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("OnBackground", "(J)V", "GetOnBackground_JHandler")]
		public virtual unsafe void OnBackground (long p0)
		{
			if (id_OnBackground_J == IntPtr.Zero)
				id_OnBackground_J = JNIEnv.GetMethodID (class_ref, "OnBackground", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnBackground_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnBackground", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnForeground_J;
#pragma warning disable 0169
		static Delegate GetOnForeground_JHandler ()
		{
			if (cb_OnForeground_J == null)
				cb_OnForeground_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_OnForeground_J);
			return cb_OnForeground_J;
		}

		static void n_OnForeground_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnForeground (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnForeground_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='OnForeground' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("OnForeground", "(J)V", "GetOnForeground_JHandler")]
		public virtual unsafe void OnForeground (long p0)
		{
			if (id_OnForeground_J == IntPtr.Zero)
				id_OnForeground_J = JNIEnv.GetMethodID (class_ref, "OnForeground", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnForeground_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnForeground", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnHotcityGet_J;
#pragma warning disable 0169
		static Delegate GetOnHotcityGet_JHandler ()
		{
			if (cb_OnHotcityGet_J == null)
				cb_OnHotcityGet_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_OnHotcityGet_J);
			return cb_OnHotcityGet_J;
		}

		static IntPtr n_OnHotcityGet_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OnHotcityGet (p0));
		}
#pragma warning restore 0169

		static IntPtr id_OnHotcityGet_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='OnHotcityGet' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("OnHotcityGet", "(J)Ljava/lang/String;", "GetOnHotcityGet_JHandler")]
		public virtual unsafe string OnHotcityGet (long p0)
		{
			if (id_OnHotcityGet_J == IntPtr.Zero)
				id_OnHotcityGet_J = JNIEnv.GetMethodID (class_ref, "OnHotcityGet", "(J)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_OnHotcityGet_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnHotcityGet", "(J)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_OnPause_J;
#pragma warning disable 0169
		static Delegate GetOnPause_JHandler ()
		{
			if (cb_OnPause_J == null)
				cb_OnPause_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_OnPause_J);
			return cb_OnPause_J;
		}

		static void n_OnPause_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnPause_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='OnPause' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("OnPause", "(J)V", "GetOnPause_JHandler")]
		public virtual unsafe void OnPause (long p0)
		{
			if (id_OnPause_J == IntPtr.Zero)
				id_OnPause_J = JNIEnv.GetMethodID (class_ref, "OnPause", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnPause_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnPause", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRecordAdd_JI;
#pragma warning disable 0169
		static Delegate GetOnRecordAdd_JIHandler ()
		{
			if (cb_OnRecordAdd_JI == null)
				cb_OnRecordAdd_JI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, bool>) n_OnRecordAdd_JI);
			return cb_OnRecordAdd_JI;
		}

		static bool n_OnRecordAdd_JI (IntPtr jnienv, IntPtr native__this, long p0, int p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnRecordAdd (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnRecordAdd_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='OnRecordAdd' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("OnRecordAdd", "(JI)Z", "GetOnRecordAdd_JIHandler")]
		public virtual unsafe bool OnRecordAdd (long p0, int p1)
		{
			if (id_OnRecordAdd_JI == IntPtr.Zero)
				id_OnRecordAdd_JI = JNIEnv.GetMethodID (class_ref, "OnRecordAdd", "(JI)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_OnRecordAdd_JI, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRecordAdd", "(JI)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRecordGetAll_J;
#pragma warning disable 0169
		static Delegate GetOnRecordGetAll_JHandler ()
		{
			if (cb_OnRecordGetAll_J == null)
				cb_OnRecordGetAll_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_OnRecordGetAll_J);
			return cb_OnRecordGetAll_J;
		}

		static IntPtr n_OnRecordGetAll_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OnRecordGetAll (p0));
		}
#pragma warning restore 0169

		static IntPtr id_OnRecordGetAll_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='OnRecordGetAll' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("OnRecordGetAll", "(J)Ljava/lang/String;", "GetOnRecordGetAll_JHandler")]
		public virtual unsafe string OnRecordGetAll (long p0)
		{
			if (id_OnRecordGetAll_J == IntPtr.Zero)
				id_OnRecordGetAll_J = JNIEnv.GetMethodID (class_ref, "OnRecordGetAll", "(J)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_OnRecordGetAll_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRecordGetAll", "(J)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_OnRecordGetAt_JI;
#pragma warning disable 0169
		static Delegate GetOnRecordGetAt_JIHandler ()
		{
			if (cb_OnRecordGetAt_JI == null)
				cb_OnRecordGetAt_JI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, IntPtr>) n_OnRecordGetAt_JI);
			return cb_OnRecordGetAt_JI;
		}

		static IntPtr n_OnRecordGetAt_JI (IntPtr jnienv, IntPtr native__this, long p0, int p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OnRecordGetAt (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_OnRecordGetAt_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='OnRecordGetAt' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("OnRecordGetAt", "(JI)Ljava/lang/String;", "GetOnRecordGetAt_JIHandler")]
		public virtual unsafe string OnRecordGetAt (long p0, int p1)
		{
			if (id_OnRecordGetAt_JI == IntPtr.Zero)
				id_OnRecordGetAt_JI = JNIEnv.GetMethodID (class_ref, "OnRecordGetAt", "(JI)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_OnRecordGetAt_JI, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRecordGetAt", "(JI)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_OnRecordImport_JZZ;
#pragma warning disable 0169
		static Delegate GetOnRecordImport_JZZHandler ()
		{
			if (cb_OnRecordImport_JZZ == null)
				cb_OnRecordImport_JZZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool, bool, bool>) n_OnRecordImport_JZZ);
			return cb_OnRecordImport_JZZ;
		}

		static bool n_OnRecordImport_JZZ (IntPtr jnienv, IntPtr native__this, long p0, bool p1, bool p2)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnRecordImport (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_OnRecordImport_JZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='OnRecordImport' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("OnRecordImport", "(JZZ)Z", "GetOnRecordImport_JZZHandler")]
		public virtual unsafe bool OnRecordImport (long p0, bool p1, bool p2)
		{
			if (id_OnRecordImport_JZZ == IntPtr.Zero)
				id_OnRecordImport_JZZ = JNIEnv.GetMethodID (class_ref, "OnRecordImport", "(JZZ)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_OnRecordImport_JZZ, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRecordImport", "(JZZ)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRecordReload_JIZ;
#pragma warning disable 0169
		static Delegate GetOnRecordReload_JIZHandler ()
		{
			if (cb_OnRecordReload_JIZ == null)
				cb_OnRecordReload_JIZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, bool, bool>) n_OnRecordReload_JIZ);
			return cb_OnRecordReload_JIZ;
		}

		static bool n_OnRecordReload_JIZ (IntPtr jnienv, IntPtr native__this, long p0, int p1, bool p2)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnRecordReload (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_OnRecordReload_JIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='OnRecordReload' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("OnRecordReload", "(JIZ)Z", "GetOnRecordReload_JIZHandler")]
		public virtual unsafe bool OnRecordReload (long p0, int p1, bool p2)
		{
			if (id_OnRecordReload_JIZ == IntPtr.Zero)
				id_OnRecordReload_JIZ = JNIEnv.GetMethodID (class_ref, "OnRecordReload", "(JIZ)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_OnRecordReload_JIZ, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRecordReload", "(JIZ)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRecordRemove_JIZ;
#pragma warning disable 0169
		static Delegate GetOnRecordRemove_JIZHandler ()
		{
			if (cb_OnRecordRemove_JIZ == null)
				cb_OnRecordRemove_JIZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, bool, bool>) n_OnRecordRemove_JIZ);
			return cb_OnRecordRemove_JIZ;
		}

		static bool n_OnRecordRemove_JIZ (IntPtr jnienv, IntPtr native__this, long p0, int p1, bool p2)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnRecordRemove (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_OnRecordRemove_JIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='OnRecordRemove' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("OnRecordRemove", "(JIZ)Z", "GetOnRecordRemove_JIZHandler")]
		public virtual unsafe bool OnRecordRemove (long p0, int p1, bool p2)
		{
			if (id_OnRecordRemove_JIZ == IntPtr.Zero)
				id_OnRecordRemove_JIZ = JNIEnv.GetMethodID (class_ref, "OnRecordRemove", "(JIZ)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_OnRecordRemove_JIZ, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRecordRemove", "(JIZ)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRecordStart_JIZI;
#pragma warning disable 0169
		static Delegate GetOnRecordStart_JIZIHandler ()
		{
			if (cb_OnRecordStart_JIZI == null)
				cb_OnRecordStart_JIZI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, bool, int, bool>) n_OnRecordStart_JIZI);
			return cb_OnRecordStart_JIZI;
		}

		static bool n_OnRecordStart_JIZI (IntPtr jnienv, IntPtr native__this, long p0, int p1, bool p2, int p3)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnRecordStart (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_OnRecordStart_JIZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='OnRecordStart' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='int']]"
		[Register ("OnRecordStart", "(JIZI)Z", "GetOnRecordStart_JIZIHandler")]
		public virtual unsafe bool OnRecordStart (long p0, int p1, bool p2, int p3)
		{
			if (id_OnRecordStart_JIZI == IntPtr.Zero)
				id_OnRecordStart_JIZI = JNIEnv.GetMethodID (class_ref, "OnRecordStart", "(JIZI)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_OnRecordStart_JIZI, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRecordStart", "(JIZI)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_OnRecordSuspend_JIZI;
#pragma warning disable 0169
		static Delegate GetOnRecordSuspend_JIZIHandler ()
		{
			if (cb_OnRecordSuspend_JIZI == null)
				cb_OnRecordSuspend_JIZI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, bool, int, bool>) n_OnRecordSuspend_JIZI);
			return cb_OnRecordSuspend_JIZI;
		}

		static bool n_OnRecordSuspend_JIZI (IntPtr jnienv, IntPtr native__this, long p0, int p1, bool p2, int p3)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnRecordSuspend (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_OnRecordSuspend_JIZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='OnRecordSuspend' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='int']]"
		[Register ("OnRecordSuspend", "(JIZI)Z", "GetOnRecordSuspend_JIZIHandler")]
		public virtual unsafe bool OnRecordSuspend (long p0, int p1, bool p2, int p3)
		{
			if (id_OnRecordSuspend_JIZI == IntPtr.Zero)
				id_OnRecordSuspend_JIZI = JNIEnv.GetMethodID (class_ref, "OnRecordSuspend", "(JIZI)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_OnRecordSuspend_JIZI, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnRecordSuspend", "(JIZI)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_OnResume_J;
#pragma warning disable 0169
		static Delegate GetOnResume_JHandler ()
		{
			if (cb_OnResume_J == null)
				cb_OnResume_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_OnResume_J);
			return cb_OnResume_J;
		}

		static void n_OnResume_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnResume_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='OnResume' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("OnResume", "(J)V", "GetOnResume_JHandler")]
		public virtual unsafe void OnResume (long p0)
		{
			if (id_OnResume_J == IntPtr.Zero)
				id_OnResume_J = JNIEnv.GetMethodID (class_ref, "OnResume", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnResume_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnResume", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnSchcityGet_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSchcityGet_JLjava_lang_String_Handler ()
		{
			if (cb_OnSchcityGet_JLjava_lang_String_ == null)
				cb_OnSchcityGet_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_OnSchcityGet_JLjava_lang_String_);
			return cb_OnSchcityGet_JLjava_lang_String_;
		}

		static IntPtr n_OnSchcityGet_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.OnSchcityGet (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_OnSchcityGet_JLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='OnSchcityGet' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("OnSchcityGet", "(JLjava/lang/String;)Ljava/lang/String;", "GetOnSchcityGet_JLjava_lang_String_Handler")]
		public virtual unsafe string OnSchcityGet (long p0, string p1)
		{
			if (id_OnSchcityGet_JLjava_lang_String_ == IntPtr.Zero)
				id_OnSchcityGet_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "OnSchcityGet", "(JLjava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_OnSchcityGet_JLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnSchcityGet", "(JLjava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_PostStatInfo_J;
#pragma warning disable 0169
		static Delegate GetPostStatInfo_JHandler ()
		{
			if (cb_PostStatInfo_J == null)
				cb_PostStatInfo_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_PostStatInfo_J);
			return cb_PostStatInfo_J;
		}

		static void n_PostStatInfo_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PostStatInfo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_PostStatInfo_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='PostStatInfo' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("PostStatInfo", "(J)V", "GetPostStatInfo_JHandler")]
		public virtual unsafe void PostStatInfo (long p0)
		{
			if (id_PostStatInfo_J == IntPtr.Zero)
				id_PostStatInfo_J = JNIEnv.GetMethodID (class_ref, "PostStatInfo", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_PostStatInfo_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "PostStatInfo", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_Release_J;
#pragma warning disable 0169
		static Delegate GetRelease_JHandler ()
		{
			if (cb_Release_J == null)
				cb_Release_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int>) n_Release_J);
			return cb_Release_J;
		}

		static int n_Release_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Release (p0);
		}
#pragma warning restore 0169

		static IntPtr id_Release_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='Release' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("Release", "(J)I", "GetRelease_JHandler")]
		public virtual unsafe int Release (long p0)
		{
			if (id_Release_J == IntPtr.Zero)
				id_Release_J = JNIEnv.GetMethodID (class_ref, "Release", "(J)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_Release_J, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Release", "(J)I"), __args);
			} finally {
			}
		}

		static Delegate cb_ResetImageRes_J;
#pragma warning disable 0169
		static Delegate GetResetImageRes_JHandler ()
		{
			if (cb_ResetImageRes_J == null)
				cb_ResetImageRes_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_ResetImageRes_J);
			return cb_ResetImageRes_J;
		}

		static void n_ResetImageRes_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetImageRes (p0);
		}
#pragma warning restore 0169

		static IntPtr id_ResetImageRes_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='ResetImageRes' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("ResetImageRes", "(J)V", "GetResetImageRes_JHandler")]
		public virtual unsafe void ResetImageRes (long p0)
		{
			if (id_ResetImageRes_J == IntPtr.Zero)
				id_ResetImageRes_J = JNIEnv.GetMethodID (class_ref, "ResetImageRes", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ResetImageRes_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ResetImageRes", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_SaveScreenToLocal_JLjava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSaveScreenToLocal_JLjava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_SaveScreenToLocal_JLjava_lang_String_Landroid_os_Bundle_ == null)
				cb_SaveScreenToLocal_JLjava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_SaveScreenToLocal_JLjava_lang_String_Landroid_os_Bundle_);
			return cb_SaveScreenToLocal_JLjava_lang_String_Landroid_os_Bundle_;
		}

		static void n_SaveScreenToLocal_JLjava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SaveScreenToLocal (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_SaveScreenToLocal_JLjava_lang_String_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='SaveScreenToLocal' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("SaveScreenToLocal", "(JLjava/lang/String;Landroid/os/Bundle;)V", "GetSaveScreenToLocal_JLjava_lang_String_Landroid_os_Bundle_Handler")]
		public virtual unsafe void SaveScreenToLocal (long p0, string p1, global::Android.OS.Bundle p2)
		{
			if (id_SaveScreenToLocal_JLjava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_SaveScreenToLocal_JLjava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "SaveScreenToLocal", "(JLjava/lang/String;Landroid/os/Bundle;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SaveScreenToLocal_JLjava_lang_String_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SaveScreenToLocal", "(JLjava/lang/String;Landroid/os/Bundle;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_ScrPtToGeoPoint_JII;
#pragma warning disable 0169
		static Delegate GetScrPtToGeoPoint_JIIHandler ()
		{
			if (cb_ScrPtToGeoPoint_JII == null)
				cb_ScrPtToGeoPoint_JII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, int, IntPtr>) n_ScrPtToGeoPoint_JII);
			return cb_ScrPtToGeoPoint_JII;
		}

		static IntPtr n_ScrPtToGeoPoint_JII (IntPtr jnienv, IntPtr native__this, long p0, int p1, int p2)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ScrPtToGeoPoint (p0, p1, p2));
		}
#pragma warning restore 0169

		static IntPtr id_ScrPtToGeoPoint_JII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='ScrPtToGeoPoint' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("ScrPtToGeoPoint", "(JII)Ljava/lang/String;", "GetScrPtToGeoPoint_JIIHandler")]
		public virtual unsafe string ScrPtToGeoPoint (long p0, int p1, int p2)
		{
			if (id_ScrPtToGeoPoint_JII == IntPtr.Zero)
				id_ScrPtToGeoPoint_JII = JNIEnv.GetMethodID (class_ref, "ScrPtToGeoPoint", "(JII)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_ScrPtToGeoPoint_JII, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ScrPtToGeoPoint", "(JII)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_SetCallback_JLcom_baidu_platform_comjni_map_basemap_BaseMapCallback_;
#pragma warning disable 0169
		static Delegate GetSetCallback_JLcom_baidu_platform_comjni_map_basemap_BaseMapCallback_Handler ()
		{
			if (cb_SetCallback_JLcom_baidu_platform_comjni_map_basemap_BaseMapCallback_ == null)
				cb_SetCallback_JLcom_baidu_platform_comjni_map_basemap_BaseMapCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, int>) n_SetCallback_JLcom_baidu_platform_comjni_map_basemap_BaseMapCallback_);
			return cb_SetCallback_JLcom_baidu_platform_comjni_map_basemap_BaseMapCallback_;
		}

		static int n_SetCallback_JLcom_baidu_platform_comjni_map_basemap_BaseMapCallback_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Platform.Comjni.Map.Basemap.BaseMapCallback p1 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.BaseMapCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetCallback (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetCallback_JLcom_baidu_platform_comjni_map_basemap_BaseMapCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='SetCallback' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.baidu.platform.comjni.map.basemap.BaseMapCallback']]"
		[Register ("SetCallback", "(JLcom/baidu/platform/comjni/map/basemap/BaseMapCallback;)I", "GetSetCallback_JLcom_baidu_platform_comjni_map_basemap_BaseMapCallback_Handler")]
		public virtual unsafe int SetCallback (long p0, global::Com.Baidu.Platform.Comjni.Map.Basemap.BaseMapCallback p1)
		{
			if (id_SetCallback_JLcom_baidu_platform_comjni_map_basemap_BaseMapCallback_ == IntPtr.Zero)
				id_SetCallback_JLcom_baidu_platform_comjni_map_basemap_BaseMapCallback_ = JNIEnv.GetMethodID (class_ref, "SetCallback", "(JLcom/baidu/platform/comjni/map/basemap/BaseMapCallback;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_SetCallback_JLcom_baidu_platform_comjni_map_basemap_BaseMapCallback_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetCallback", "(JLcom/baidu/platform/comjni/map/basemap/BaseMapCallback;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_SetMapControlMode_JI;
#pragma warning disable 0169
		static Delegate GetSetMapControlMode_JIHandler ()
		{
			if (cb_SetMapControlMode_JI == null)
				cb_SetMapControlMode_JI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, int>) n_SetMapControlMode_JI);
			return cb_SetMapControlMode_JI;
		}

		static int n_SetMapControlMode_JI (IntPtr jnienv, IntPtr native__this, long p0, int p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetMapControlMode (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_SetMapControlMode_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='SetMapControlMode' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("SetMapControlMode", "(JI)I", "GetSetMapControlMode_JIHandler")]
		public virtual unsafe int SetMapControlMode (long p0, int p1)
		{
			if (id_SetMapControlMode_JI == IntPtr.Zero)
				id_SetMapControlMode_JI = JNIEnv.GetMethodID (class_ref, "SetMapControlMode", "(JI)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_SetMapControlMode_JI, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetMapControlMode", "(JI)I"), __args);
			} finally {
			}
		}

		static IntPtr id_SetMapCustomEnable_JZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='SetMapCustomEnable' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register ("SetMapCustomEnable", "(JZ)V", "")]
		public static unsafe void SetMapCustomEnable (long p0, bool p1)
		{
			if (id_SetMapCustomEnable_JZ == IntPtr.Zero)
				id_SetMapCustomEnable_JZ = JNIEnv.GetStaticMethodID (class_ref, "SetMapCustomEnable", "(JZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_SetMapCustomEnable_JZ, __args);
			} finally {
			}
		}

		static Delegate cb_SetMapStatus_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSetMapStatus_JLandroid_os_Bundle_Handler ()
		{
			if (cb_SetMapStatus_JLandroid_os_Bundle_ == null)
				cb_SetMapStatus_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_SetMapStatus_JLandroid_os_Bundle_);
			return cb_SetMapStatus_JLandroid_os_Bundle_;
		}

		static void n_SetMapStatus_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetMapStatus (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_SetMapStatus_JLandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='SetMapStatus' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("SetMapStatus", "(JLandroid/os/Bundle;)V", "GetSetMapStatus_JLandroid_os_Bundle_Handler")]
		public virtual unsafe void SetMapStatus (long p0, global::Android.OS.Bundle p1)
		{
			if (id_SetMapStatus_JLandroid_os_Bundle_ == IntPtr.Zero)
				id_SetMapStatus_JLandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "SetMapStatus", "(JLandroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetMapStatus_JLandroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetMapStatus", "(JLandroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_ShowBaseIndoorMap_JZ;
#pragma warning disable 0169
		static Delegate GetShowBaseIndoorMap_JZHandler ()
		{
			if (cb_ShowBaseIndoorMap_JZ == null)
				cb_ShowBaseIndoorMap_JZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, bool>) n_ShowBaseIndoorMap_JZ);
			return cb_ShowBaseIndoorMap_JZ;
		}

		static void n_ShowBaseIndoorMap_JZ (IntPtr jnienv, IntPtr native__this, long p0, bool p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowBaseIndoorMap (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_ShowBaseIndoorMap_JZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='ShowBaseIndoorMap' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register ("ShowBaseIndoorMap", "(JZ)V", "GetShowBaseIndoorMap_JZHandler")]
		public virtual unsafe void ShowBaseIndoorMap (long p0, bool p1)
		{
			if (id_ShowBaseIndoorMap_JZ == IntPtr.Zero)
				id_ShowBaseIndoorMap_JZ = JNIEnv.GetMethodID (class_ref, "ShowBaseIndoorMap", "(JZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ShowBaseIndoorMap_JZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ShowBaseIndoorMap", "(JZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_ShowHotMap_JZ;
#pragma warning disable 0169
		static Delegate GetShowHotMap_JZHandler ()
		{
			if (cb_ShowHotMap_JZ == null)
				cb_ShowHotMap_JZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, bool>) n_ShowHotMap_JZ);
			return cb_ShowHotMap_JZ;
		}

		static void n_ShowHotMap_JZ (IntPtr jnienv, IntPtr native__this, long p0, bool p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowHotMap (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_ShowHotMap_JZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='ShowHotMap' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register ("ShowHotMap", "(JZ)V", "GetShowHotMap_JZHandler")]
		public virtual unsafe void ShowHotMap (long p0, bool p1)
		{
			if (id_ShowHotMap_JZ == IntPtr.Zero)
				id_ShowHotMap_JZ = JNIEnv.GetMethodID (class_ref, "ShowHotMap", "(JZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ShowHotMap_JZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ShowHotMap", "(JZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_ShowLayers_JJZ;
#pragma warning disable 0169
		static Delegate GetShowLayers_JJZHandler ()
		{
			if (cb_ShowLayers_JJZ == null)
				cb_ShowLayers_JJZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, long, bool>) n_ShowLayers_JJZ);
			return cb_ShowLayers_JJZ;
		}

		static void n_ShowLayers_JJZ (IntPtr jnienv, IntPtr native__this, long p0, long p1, bool p2)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowLayers (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_ShowLayers_JJZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='ShowLayers' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='boolean']]"
		[Register ("ShowLayers", "(JJZ)V", "GetShowLayers_JJZHandler")]
		public virtual unsafe void ShowLayers (long p0, long p1, bool p2)
		{
			if (id_ShowLayers_JJZ == IntPtr.Zero)
				id_ShowLayers_JJZ = JNIEnv.GetMethodID (class_ref, "ShowLayers", "(JJZ)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ShowLayers_JJZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ShowLayers", "(JJZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_ShowSatelliteMap_JZ;
#pragma warning disable 0169
		static Delegate GetShowSatelliteMap_JZHandler ()
		{
			if (cb_ShowSatelliteMap_JZ == null)
				cb_ShowSatelliteMap_JZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, bool>) n_ShowSatelliteMap_JZ);
			return cb_ShowSatelliteMap_JZ;
		}

		static void n_ShowSatelliteMap_JZ (IntPtr jnienv, IntPtr native__this, long p0, bool p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowSatelliteMap (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_ShowSatelliteMap_JZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='ShowSatelliteMap' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register ("ShowSatelliteMap", "(JZ)V", "GetShowSatelliteMap_JZHandler")]
		public virtual unsafe void ShowSatelliteMap (long p0, bool p1)
		{
			if (id_ShowSatelliteMap_JZ == IntPtr.Zero)
				id_ShowSatelliteMap_JZ = JNIEnv.GetMethodID (class_ref, "ShowSatelliteMap", "(JZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ShowSatelliteMap_JZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ShowSatelliteMap", "(JZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_ShowTrafficMap_JZ;
#pragma warning disable 0169
		static Delegate GetShowTrafficMap_JZHandler ()
		{
			if (cb_ShowTrafficMap_JZ == null)
				cb_ShowTrafficMap_JZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, bool>) n_ShowTrafficMap_JZ);
			return cb_ShowTrafficMap_JZ;
		}

		static void n_ShowTrafficMap_JZ (IntPtr jnienv, IntPtr native__this, long p0, bool p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowTrafficMap (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_ShowTrafficMap_JZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='ShowTrafficMap' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register ("ShowTrafficMap", "(JZ)V", "GetShowTrafficMap_JZHandler")]
		public virtual unsafe void ShowTrafficMap (long p0, bool p1)
		{
			if (id_ShowTrafficMap_JZ == IntPtr.Zero)
				id_ShowTrafficMap_JZ = JNIEnv.GetMethodID (class_ref, "ShowTrafficMap", "(JZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ShowTrafficMap_JZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ShowTrafficMap", "(JZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_SwitchBaseIndoorMapFloor_JLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSwitchBaseIndoorMapFloor_JLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_SwitchBaseIndoorMapFloor_JLjava_lang_String_Ljava_lang_String_ == null)
				cb_SwitchBaseIndoorMapFloor_JLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr, bool>) n_SwitchBaseIndoorMapFloor_JLjava_lang_String_Ljava_lang_String_);
			return cb_SwitchBaseIndoorMapFloor_JLjava_lang_String_Ljava_lang_String_;
		}

		static bool n_SwitchBaseIndoorMapFloor_JLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SwitchBaseIndoorMapFloor (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SwitchBaseIndoorMapFloor_JLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='SwitchBaseIndoorMapFloor' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("SwitchBaseIndoorMapFloor", "(JLjava/lang/String;Ljava/lang/String;)Z", "GetSwitchBaseIndoorMapFloor_JLjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool SwitchBaseIndoorMapFloor (long p0, string p1, string p2)
		{
			if (id_SwitchBaseIndoorMapFloor_JLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_SwitchBaseIndoorMapFloor_JLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SwitchBaseIndoorMapFloor", "(JLjava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SwitchBaseIndoorMapFloor_JLjava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SwitchBaseIndoorMapFloor", "(JLjava/lang/String;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_UpdateLayers_JJ;
#pragma warning disable 0169
		static Delegate GetUpdateLayers_JJHandler ()
		{
			if (cb_UpdateLayers_JJ == null)
				cb_UpdateLayers_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, long>) n_UpdateLayers_JJ);
			return cb_UpdateLayers_JJ;
		}

		static void n_UpdateLayers_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateLayers (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_UpdateLayers_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='UpdateLayers' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("UpdateLayers", "(JJ)V", "GetUpdateLayers_JJHandler")]
		public virtual unsafe void UpdateLayers (long p0, long p1)
		{
			if (id_UpdateLayers_JJ == IntPtr.Zero)
				id_UpdateLayers_JJ = JNIEnv.GetMethodID (class_ref, "UpdateLayers", "(JJ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_UpdateLayers_JJ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "UpdateLayers", "(JJ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addOneOverlayItem_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetAddOneOverlayItem_JLandroid_os_Bundle_Handler ()
		{
			if (cb_addOneOverlayItem_JLandroid_os_Bundle_ == null)
				cb_addOneOverlayItem_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_AddOneOverlayItem_JLandroid_os_Bundle_);
			return cb_addOneOverlayItem_JLandroid_os_Bundle_;
		}

		static void n_AddOneOverlayItem_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddOneOverlayItem (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addOneOverlayItem_JLandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='addOneOverlayItem' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("addOneOverlayItem", "(JLandroid/os/Bundle;)V", "GetAddOneOverlayItem_JLandroid_os_Bundle_Handler")]
		public virtual unsafe void AddOneOverlayItem (long p0, global::Android.OS.Bundle p1)
		{
			if (id_addOneOverlayItem_JLandroid_os_Bundle_ == IntPtr.Zero)
				id_addOneOverlayItem_JLandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "addOneOverlayItem", "(JLandroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addOneOverlayItem_JLandroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addOneOverlayItem", "(JLandroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addOverlayItems_JarrayLandroid_os_Bundle_I;
#pragma warning disable 0169
		static Delegate GetAddOverlayItems_JarrayLandroid_os_Bundle_IHandler ()
		{
			if (cb_addOverlayItems_JarrayLandroid_os_Bundle_I == null)
				cb_addOverlayItems_JarrayLandroid_os_Bundle_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr, int>) n_AddOverlayItems_JarrayLandroid_os_Bundle_I);
			return cb_addOverlayItems_JarrayLandroid_os_Bundle_I;
		}

		static void n_AddOverlayItems_JarrayLandroid_os_Bundle_I (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, int p2)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle[] p1 = (global::Android.OS.Bundle[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Android.OS.Bundle));
			__this.AddOverlayItems (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_addOverlayItems_JarrayLandroid_os_Bundle_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='addOverlayItems' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle[]'] and parameter[3][@type='int']]"
		[Register ("addOverlayItems", "(J[Landroid/os/Bundle;I)V", "GetAddOverlayItems_JarrayLandroid_os_Bundle_IHandler")]
		public virtual unsafe void AddOverlayItems (long p0, global::Android.OS.Bundle[] p1, int p2)
		{
			if (id_addOverlayItems_JarrayLandroid_os_Bundle_I == IntPtr.Zero)
				id_addOverlayItems_JarrayLandroid_os_Bundle_I = JNIEnv.GetMethodID (class_ref, "addOverlayItems", "(J[Landroid/os/Bundle;I)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addOverlayItems_JarrayLandroid_os_Bundle_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addOverlayItems", "(J[Landroid/os/Bundle;I)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_addtileOverlay_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetAddtileOverlay_JLandroid_os_Bundle_Handler ()
		{
			if (cb_addtileOverlay_JLandroid_os_Bundle_ == null)
				cb_addtileOverlay_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_AddtileOverlay_JLandroid_os_Bundle_);
			return cb_addtileOverlay_JLandroid_os_Bundle_;
		}

		static bool n_AddtileOverlay_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddtileOverlay (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addtileOverlay_JLandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='addtileOverlay' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("addtileOverlay", "(JLandroid/os/Bundle;)Z", "GetAddtileOverlay_JLandroid_os_Bundle_Handler")]
		public virtual unsafe bool AddtileOverlay (long p0, global::Android.OS.Bundle p1)
		{
			if (id_addtileOverlay_JLandroid_os_Bundle_ == IntPtr.Zero)
				id_addtileOverlay_JLandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "addtileOverlay", "(JLandroid/os/Bundle;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_addtileOverlay_JLandroid_os_Bundle_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addtileOverlay", "(JLandroid/os/Bundle;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_cleanSDKTileDataCache_JJ;
#pragma warning disable 0169
		static Delegate GetCleanSDKTileDataCache_JJHandler ()
		{
			if (cb_cleanSDKTileDataCache_JJ == null)
				cb_cleanSDKTileDataCache_JJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long, bool>) n_CleanSDKTileDataCache_JJ);
			return cb_cleanSDKTileDataCache_JJ;
		}

		static bool n_CleanSDKTileDataCache_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CleanSDKTileDataCache (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_cleanSDKTileDataCache_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='cleanSDKTileDataCache' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("cleanSDKTileDataCache", "(JJ)Z", "GetCleanSDKTileDataCache_JJHandler")]
		public virtual unsafe bool CleanSDKTileDataCache (long p0, long p1)
		{
			if (id_cleanSDKTileDataCache_JJ == IntPtr.Zero)
				id_cleanSDKTileDataCache_JJ = JNIEnv.GetMethodID (class_ref, "cleanSDKTileDataCache", "(JJ)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_cleanSDKTileDataCache_JJ, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cleanSDKTileDataCache", "(JJ)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_clearHeatMapLayerCache_J;
#pragma warning disable 0169
		static Delegate GetClearHeatMapLayerCache_JHandler ()
		{
			if (cb_clearHeatMapLayerCache_J == null)
				cb_clearHeatMapLayerCache_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_ClearHeatMapLayerCache_J);
			return cb_clearHeatMapLayerCache_J;
		}

		static void n_ClearHeatMapLayerCache_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearHeatMapLayerCache (p0);
		}
#pragma warning restore 0169

		static IntPtr id_clearHeatMapLayerCache_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='clearHeatMapLayerCache' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("clearHeatMapLayerCache", "(J)V", "GetClearHeatMapLayerCache_JHandler")]
		public virtual unsafe void ClearHeatMapLayerCache (long p0)
		{
			if (id_clearHeatMapLayerCache_J == IntPtr.Zero)
				id_clearHeatMapLayerCache_J = JNIEnv.GetMethodID (class_ref, "clearHeatMapLayerCache", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearHeatMapLayerCache_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearHeatMapLayerCache", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_enableDrawHouseHeight_JZ;
#pragma warning disable 0169
		static Delegate GetEnableDrawHouseHeight_JZHandler ()
		{
			if (cb_enableDrawHouseHeight_JZ == null)
				cb_enableDrawHouseHeight_JZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, bool>) n_EnableDrawHouseHeight_JZ);
			return cb_enableDrawHouseHeight_JZ;
		}

		static void n_EnableDrawHouseHeight_JZ (IntPtr jnienv, IntPtr native__this, long p0, bool p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableDrawHouseHeight (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_enableDrawHouseHeight_JZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='enableDrawHouseHeight' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register ("enableDrawHouseHeight", "(JZ)V", "GetEnableDrawHouseHeight_JZHandler")]
		public virtual unsafe void EnableDrawHouseHeight (long p0, bool p1)
		{
			if (id_enableDrawHouseHeight_JZ == IntPtr.Zero)
				id_enableDrawHouseHeight_JZ = JNIEnv.GetMethodID (class_ref, "enableDrawHouseHeight", "(JZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enableDrawHouseHeight_JZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableDrawHouseHeight", "(JZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getCompassPosition_JJ;
#pragma warning disable 0169
		static Delegate GetGetCompassPosition_JJHandler ()
		{
			if (cb_getCompassPosition_JJ == null)
				cb_getCompassPosition_JJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long, IntPtr>) n_GetCompassPosition_JJ);
			return cb_getCompassPosition_JJ;
		}

		static IntPtr n_GetCompassPosition_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetCompassPosition (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_getCompassPosition_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='getCompassPosition' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("getCompassPosition", "(JJ)Ljava/lang/String;", "GetGetCompassPosition_JJHandler")]
		public virtual unsafe string GetCompassPosition (long p0, long p1)
		{
			if (id_getCompassPosition_JJ == IntPtr.Zero)
				id_getCompassPosition_JJ = JNIEnv.GetMethodID (class_ref, "getCompassPosition", "(JJ)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCompassPosition_JJ, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCompassPosition", "(JJ)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getDrawingMapStatus_J;
#pragma warning disable 0169
		static Delegate GetGetDrawingMapStatus_JHandler ()
		{
			if (cb_getDrawingMapStatus_J == null)
				cb_getDrawingMapStatus_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_GetDrawingMapStatus_J);
			return cb_getDrawingMapStatus_J;
		}

		static IntPtr n_GetDrawingMapStatus_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetDrawingMapStatus (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getDrawingMapStatus_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='getDrawingMapStatus' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getDrawingMapStatus", "(J)Landroid/os/Bundle;", "GetGetDrawingMapStatus_JHandler")]
		public virtual unsafe global::Android.OS.Bundle GetDrawingMapStatus (long p0)
		{
			if (id_getDrawingMapStatus_J == IntPtr.Zero)
				id_getDrawingMapStatus_J = JNIEnv.GetMethodID (class_ref, "getDrawingMapStatus", "(J)Landroid/os/Bundle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDrawingMapStatus_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDrawingMapStatus", "(J)Landroid/os/Bundle;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getMapStatusLimits_J;
#pragma warning disable 0169
		static Delegate GetGetMapStatusLimits_JHandler ()
		{
			if (cb_getMapStatusLimits_J == null)
				cb_getMapStatusLimits_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_GetMapStatusLimits_J);
			return cb_getMapStatusLimits_J;
		}

		static IntPtr n_GetMapStatusLimits_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetMapStatusLimits (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getMapStatusLimits_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='getMapStatusLimits' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getMapStatusLimits", "(J)Landroid/os/Bundle;", "GetGetMapStatusLimits_JHandler")]
		public virtual unsafe global::Android.OS.Bundle GetMapStatusLimits (long p0)
		{
			if (id_getMapStatusLimits_J == IntPtr.Zero)
				id_getMapStatusLimits_J = JNIEnv.GetMethodID (class_ref, "getMapStatusLimits", "(J)Landroid/os/Bundle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMapStatusLimits_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMapStatusLimits", "(J)Landroid/os/Bundle;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getfocusedBaseIndoorMapInfo_J;
#pragma warning disable 0169
		static Delegate GetGetfocusedBaseIndoorMapInfo_JHandler ()
		{
			if (cb_getfocusedBaseIndoorMapInfo_J == null)
				cb_getfocusedBaseIndoorMapInfo_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_GetfocusedBaseIndoorMapInfo_J);
			return cb_getfocusedBaseIndoorMapInfo_J;
		}

		static IntPtr n_GetfocusedBaseIndoorMapInfo_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetfocusedBaseIndoorMapInfo (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getfocusedBaseIndoorMapInfo_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='getfocusedBaseIndoorMapInfo' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getfocusedBaseIndoorMapInfo", "(J)Ljava/lang/String;", "GetGetfocusedBaseIndoorMapInfo_JHandler")]
		public virtual unsafe string GetfocusedBaseIndoorMapInfo (long p0)
		{
			if (id_getfocusedBaseIndoorMapInfo_J == IntPtr.Zero)
				id_getfocusedBaseIndoorMapInfo_J = JNIEnv.GetMethodID (class_ref, "getfocusedBaseIndoorMapInfo", "(J)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getfocusedBaseIndoorMapInfo_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getfocusedBaseIndoorMapInfo", "(J)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isDrawHouseHeightEnable_J;
#pragma warning disable 0169
		static Delegate GetIsDrawHouseHeightEnable_JHandler ()
		{
			if (cb_isDrawHouseHeightEnable_J == null)
				cb_isDrawHouseHeightEnable_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_IsDrawHouseHeightEnable_J);
			return cb_isDrawHouseHeightEnable_J;
		}

		static bool n_IsDrawHouseHeightEnable_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawHouseHeightEnable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isDrawHouseHeightEnable_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='isDrawHouseHeightEnable' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("isDrawHouseHeightEnable", "(J)Z", "GetIsDrawHouseHeightEnable_JHandler")]
		public virtual unsafe bool IsDrawHouseHeightEnable (long p0)
		{
			if (id_isDrawHouseHeightEnable_J == IntPtr.Zero)
				id_isDrawHouseHeightEnable_J = JNIEnv.GetMethodID (class_ref, "isDrawHouseHeightEnable", "(J)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDrawHouseHeightEnable_J, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDrawHouseHeightEnable", "(J)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_removeOneOverlayItem_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetRemoveOneOverlayItem_JLandroid_os_Bundle_Handler ()
		{
			if (cb_removeOneOverlayItem_JLandroid_os_Bundle_ == null)
				cb_removeOneOverlayItem_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_RemoveOneOverlayItem_JLandroid_os_Bundle_);
			return cb_removeOneOverlayItem_JLandroid_os_Bundle_;
		}

		static void n_RemoveOneOverlayItem_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOneOverlayItem (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_removeOneOverlayItem_JLandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='removeOneOverlayItem' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("removeOneOverlayItem", "(JLandroid/os/Bundle;)V", "GetRemoveOneOverlayItem_JLandroid_os_Bundle_Handler")]
		public virtual unsafe void RemoveOneOverlayItem (long p0, global::Android.OS.Bundle p1)
		{
			if (id_removeOneOverlayItem_JLandroid_os_Bundle_ == IntPtr.Zero)
				id_removeOneOverlayItem_JLandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "removeOneOverlayItem", "(JLandroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeOneOverlayItem_JLandroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeOneOverlayItem", "(JLandroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMapStatusLimits_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSetMapStatusLimits_JLandroid_os_Bundle_Handler ()
		{
			if (cb_setMapStatusLimits_JLandroid_os_Bundle_ == null)
				cb_setMapStatusLimits_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_SetMapStatusLimits_JLandroid_os_Bundle_);
			return cb_setMapStatusLimits_JLandroid_os_Bundle_;
		}

		static void n_SetMapStatusLimits_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetMapStatusLimits (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setMapStatusLimits_JLandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='setMapStatusLimits' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("setMapStatusLimits", "(JLandroid/os/Bundle;)V", "GetSetMapStatusLimits_JLandroid_os_Bundle_Handler")]
		public virtual unsafe void SetMapStatusLimits (long p0, global::Android.OS.Bundle p1)
		{
			if (id_setMapStatusLimits_JLandroid_os_Bundle_ == IntPtr.Zero)
				id_setMapStatusLimits_JLandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "setMapStatusLimits", "(JLandroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMapStatusLimits_JLandroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMapStatusLimits", "(JLandroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateOneOverlayItem_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetUpdateOneOverlayItem_JLandroid_os_Bundle_Handler ()
		{
			if (cb_updateOneOverlayItem_JLandroid_os_Bundle_ == null)
				cb_updateOneOverlayItem_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_UpdateOneOverlayItem_JLandroid_os_Bundle_);
			return cb_updateOneOverlayItem_JLandroid_os_Bundle_;
		}

		static void n_UpdateOneOverlayItem_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateOneOverlayItem (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateOneOverlayItem_JLandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='updateOneOverlayItem' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("updateOneOverlayItem", "(JLandroid/os/Bundle;)V", "GetUpdateOneOverlayItem_JLandroid_os_Bundle_Handler")]
		public virtual unsafe void UpdateOneOverlayItem (long p0, global::Android.OS.Bundle p1)
		{
			if (id_updateOneOverlayItem_JLandroid_os_Bundle_ == IntPtr.Zero)
				id_updateOneOverlayItem_JLandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "updateOneOverlayItem", "(JLandroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateOneOverlayItem_JLandroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateOneOverlayItem", "(JLandroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateSDKTile_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetUpdateSDKTile_JLandroid_os_Bundle_Handler ()
		{
			if (cb_updateSDKTile_JLandroid_os_Bundle_ == null)
				cb_updateSDKTile_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_UpdateSDKTile_JLandroid_os_Bundle_);
			return cb_updateSDKTile_JLandroid_os_Bundle_;
		}

		static bool n_UpdateSDKTile_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateSDKTile (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateSDKTile_JLandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='updateSDKTile' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("updateSDKTile", "(JLandroid/os/Bundle;)Z", "GetUpdateSDKTile_JLandroid_os_Bundle_Handler")]
		public virtual unsafe bool UpdateSDKTile (long p0, global::Android.OS.Bundle p1)
		{
			if (id_updateSDKTile_JLandroid_os_Bundle_ == IntPtr.Zero)
				id_updateSDKTile_JLandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "updateSDKTile", "(JLandroid/os/Bundle;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_updateSDKTile_JLandroid_os_Bundle_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateSDKTile", "(JLandroid/os/Bundle;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
