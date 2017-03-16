using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comjni.Map.Favorite {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.platform.comjni.map.favorite']/class[@name='JNIFavorite']"
	[global::Android.Runtime.Register ("com/baidu/platform/comjni/map/favorite/JNIFavorite", DoNotGenerateAcw=true)]
	public partial class JNIFavorite : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/platform/comjni/map/favorite/JNIFavorite", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JNIFavorite); }
		}

		protected JNIFavorite (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.platform.comjni.map.favorite']/class[@name='JNIFavorite']/constructor[@name='JNIFavorite' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JNIFavorite ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (JNIFavorite)) {
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

		static Delegate cb_Add_JLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdd_JLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_Add_JLjava_lang_String_Ljava_lang_String_ == null)
				cb_Add_JLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr, bool>) n_Add_JLjava_lang_String_Ljava_lang_String_);
			return cb_Add_JLjava_lang_String_Ljava_lang_String_;
		}

		static bool n_Add_JLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Baidu.Platform.Comjni.Map.Favorite.JNIFavorite __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Favorite.JNIFavorite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Add (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_Add_JLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.favorite']/class[@name='JNIFavorite']/method[@name='Add' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("Add", "(JLjava/lang/String;Ljava/lang/String;)Z", "GetAdd_JLjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool Add (long p0, string p1, string p2)
		{
			if (id_Add_JLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_Add_JLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "Add", "(JLjava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_Add_JLjava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Add", "(JLjava/lang/String;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_Clear_J;
#pragma warning disable 0169
		static Delegate GetClear_JHandler ()
		{
			if (cb_Clear_J == null)
				cb_Clear_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_Clear_J);
			return cb_Clear_J;
		}

		static bool n_Clear_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Platform.Comjni.Map.Favorite.JNIFavorite __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Favorite.JNIFavorite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Clear (p0);
		}
#pragma warning restore 0169

		static IntPtr id_Clear_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.favorite']/class[@name='JNIFavorite']/method[@name='Clear' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("Clear", "(J)Z", "GetClear_JHandler")]
		public virtual unsafe bool Clear (long p0)
		{
			if (id_Clear_J == IntPtr.Zero)
				id_Clear_J = JNIEnv.GetMethodID (class_ref, "Clear", "(J)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_Clear_J, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Clear", "(J)Z"), __args);
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
			global::Com.Baidu.Platform.Comjni.Map.Favorite.JNIFavorite __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Favorite.JNIFavorite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Create ();
		}
#pragma warning restore 0169

		static IntPtr id_Create;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.favorite']/class[@name='JNIFavorite']/method[@name='Create' and count(parameter)=0]"
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

		static Delegate cb_GetAll_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetAll_JLandroid_os_Bundle_Handler ()
		{
			if (cb_GetAll_JLandroid_os_Bundle_ == null)
				cb_GetAll_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, int>) n_GetAll_JLandroid_os_Bundle_);
			return cb_GetAll_JLandroid_os_Bundle_;
		}

		static int n_GetAll_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Favorite.JNIFavorite __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Favorite.JNIFavorite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetAll (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetAll_JLandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.favorite']/class[@name='JNIFavorite']/method[@name='GetAll' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("GetAll", "(JLandroid/os/Bundle;)I", "GetGetAll_JLandroid_os_Bundle_Handler")]
		public virtual unsafe int GetAll (long p0, global::Android.OS.Bundle p1)
		{
			if (id_GetAll_JLandroid_os_Bundle_ == IntPtr.Zero)
				id_GetAll_JLandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "GetAll", "(JLandroid/os/Bundle;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_GetAll_JLandroid_os_Bundle_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetAll", "(JLandroid/os/Bundle;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_GetValue_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetValue_JLjava_lang_String_Handler ()
		{
			if (cb_GetValue_JLjava_lang_String_ == null)
				cb_GetValue_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_GetValue_JLjava_lang_String_);
			return cb_GetValue_JLjava_lang_String_;
		}

		static IntPtr n_GetValue_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Favorite.JNIFavorite __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Favorite.JNIFavorite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetValue (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetValue_JLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.favorite']/class[@name='JNIFavorite']/method[@name='GetValue' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("GetValue", "(JLjava/lang/String;)Ljava/lang/String;", "GetGetValue_JLjava_lang_String_Handler")]
		public virtual unsafe string GetValue (long p0, string p1)
		{
			if (id_GetValue_JLjava_lang_String_ == IntPtr.Zero)
				id_GetValue_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "GetValue", "(JLjava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetValue_JLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetValue", "(JLjava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_IsExist_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsExist_JLjava_lang_String_Handler ()
		{
			if (cb_IsExist_JLjava_lang_String_ == null)
				cb_IsExist_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_IsExist_JLjava_lang_String_);
			return cb_IsExist_JLjava_lang_String_;
		}

		static bool n_IsExist_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Favorite.JNIFavorite __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Favorite.JNIFavorite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsExist (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_IsExist_JLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.favorite']/class[@name='JNIFavorite']/method[@name='IsExist' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("IsExist", "(JLjava/lang/String;)Z", "GetIsExist_JLjava_lang_String_Handler")]
		public virtual unsafe bool IsExist (long p0, string p1)
		{
			if (id_IsExist_JLjava_lang_String_ == IntPtr.Zero)
				id_IsExist_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "IsExist", "(JLjava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_IsExist_JLjava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "IsExist", "(JLjava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_Load_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_III;
#pragma warning disable 0169
		static Delegate GetLoad_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_IIIHandler ()
		{
			if (cb_Load_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_III == null)
				cb_Load_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_III = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr, IntPtr, int, int, int, bool>) n_Load_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_III);
			return cb_Load_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_III;
		}

		static bool n_Load_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_III (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, int p4, int p5, int p6)
		{
			global::Com.Baidu.Platform.Comjni.Map.Favorite.JNIFavorite __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Favorite.JNIFavorite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Load (p0, p1, p2, p3, p4, p5, p6);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_Load_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.favorite']/class[@name='JNIFavorite']/method[@name='Load' and count(parameter)=7 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("Load", "(JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;III)Z", "GetLoad_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_IIIHandler")]
		public virtual unsafe bool Load (long p0, string p1, string p2, string p3, int p4, int p5, int p6)
		{
			if (id_Load_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_III == IntPtr.Zero)
				id_Load_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_III = JNIEnv.GetMethodID (class_ref, "Load", "(JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;III)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_Load_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_III, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Load", "(JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;III)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
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
			global::Com.Baidu.Platform.Comjni.Map.Favorite.JNIFavorite __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Favorite.JNIFavorite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Release (p0);
		}
#pragma warning restore 0169

		static IntPtr id_Release_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.favorite']/class[@name='JNIFavorite']/method[@name='Release' and count(parameter)=1 and parameter[1][@type='long']]"
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

		static Delegate cb_Remove_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_JLjava_lang_String_Handler ()
		{
			if (cb_Remove_JLjava_lang_String_ == null)
				cb_Remove_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_Remove_JLjava_lang_String_);
			return cb_Remove_JLjava_lang_String_;
		}

		static bool n_Remove_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Favorite.JNIFavorite __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Favorite.JNIFavorite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Remove (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_Remove_JLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.favorite']/class[@name='JNIFavorite']/method[@name='Remove' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("Remove", "(JLjava/lang/String;)Z", "GetRemove_JLjava_lang_String_Handler")]
		public virtual unsafe bool Remove (long p0, string p1)
		{
			if (id_Remove_JLjava_lang_String_ == IntPtr.Zero)
				id_Remove_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "Remove", "(JLjava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_Remove_JLjava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Remove", "(JLjava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_SaveCache_J;
#pragma warning disable 0169
		static Delegate GetSaveCache_JHandler ()
		{
			if (cb_SaveCache_J == null)
				cb_SaveCache_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_SaveCache_J);
			return cb_SaveCache_J;
		}

		static bool n_SaveCache_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Platform.Comjni.Map.Favorite.JNIFavorite __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Favorite.JNIFavorite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SaveCache (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SaveCache_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.favorite']/class[@name='JNIFavorite']/method[@name='SaveCache' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("SaveCache", "(J)Z", "GetSaveCache_JHandler")]
		public virtual unsafe bool SaveCache (long p0)
		{
			if (id_SaveCache_J == IntPtr.Zero)
				id_SaveCache_J = JNIEnv.GetMethodID (class_ref, "SaveCache", "(J)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SaveCache_J, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SaveCache", "(J)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_SetType_JI;
#pragma warning disable 0169
		static Delegate GetSetType_JIHandler ()
		{
			if (cb_SetType_JI == null)
				cb_SetType_JI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, bool>) n_SetType_JI);
			return cb_SetType_JI;
		}

		static bool n_SetType_JI (IntPtr jnienv, IntPtr native__this, long p0, int p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Favorite.JNIFavorite __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Favorite.JNIFavorite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetType (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_SetType_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.favorite']/class[@name='JNIFavorite']/method[@name='SetType' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("SetType", "(JI)Z", "GetSetType_JIHandler")]
		public virtual unsafe bool SetType (long p0, int p1)
		{
			if (id_SetType_JI == IntPtr.Zero)
				id_SetType_JI = JNIEnv.GetMethodID (class_ref, "SetType", "(JI)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_SetType_JI, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetType", "(JI)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_Update_JLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdate_JLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_Update_JLjava_lang_String_Ljava_lang_String_ == null)
				cb_Update_JLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr, bool>) n_Update_JLjava_lang_String_Ljava_lang_String_);
			return cb_Update_JLjava_lang_String_Ljava_lang_String_;
		}

		static bool n_Update_JLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Baidu.Platform.Comjni.Map.Favorite.JNIFavorite __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Favorite.JNIFavorite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Update (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_Update_JLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.favorite']/class[@name='JNIFavorite']/method[@name='Update' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("Update", "(JLjava/lang/String;Ljava/lang/String;)Z", "GetUpdate_JLjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool Update (long p0, string p1, string p2)
		{
			if (id_Update_JLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_Update_JLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "Update", "(JLjava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_Update_JLjava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Update", "(JLjava/lang/String;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
