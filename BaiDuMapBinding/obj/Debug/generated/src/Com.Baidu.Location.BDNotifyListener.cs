using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.location']/class[@name='BDNotifyListener']"
	[global::Android.Runtime.Register ("com/baidu/location/BDNotifyListener", DoNotGenerateAcw=true)]
	public abstract partial class BDNotifyListener : global::Java.Lang.Object {


		static IntPtr Notified_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDNotifyListener']/field[@name='Notified']"
		[Register ("Notified")]
		public int Notified {
			get {
				if (Notified_jfieldId == IntPtr.Zero)
					Notified_jfieldId = JNIEnv.GetFieldID (class_ref, "Notified", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, Notified_jfieldId);
			}
			set {
				if (Notified_jfieldId == IntPtr.Zero)
					Notified_jfieldId = JNIEnv.GetFieldID (class_ref, "Notified", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, Notified_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr differDistance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDNotifyListener']/field[@name='differDistance']"
		[Register ("differDistance")]
		public float DifferDistance {
			get {
				if (differDistance_jfieldId == IntPtr.Zero)
					differDistance_jfieldId = JNIEnv.GetFieldID (class_ref, "differDistance", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, differDistance_jfieldId);
			}
			set {
				if (differDistance_jfieldId == IntPtr.Zero)
					differDistance_jfieldId = JNIEnv.GetFieldID (class_ref, "differDistance", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, differDistance_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isAdded_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDNotifyListener']/field[@name='isAdded']"
		[Register ("isAdded")]
		public bool IsAdded {
			get {
				if (isAdded_jfieldId == IntPtr.Zero)
					isAdded_jfieldId = JNIEnv.GetFieldID (class_ref, "isAdded", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isAdded_jfieldId);
			}
			set {
				if (isAdded_jfieldId == IntPtr.Zero)
					isAdded_jfieldId = JNIEnv.GetFieldID (class_ref, "isAdded", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isAdded_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mCoorType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDNotifyListener']/field[@name='mCoorType']"
		[Register ("mCoorType")]
		public string MCoorType {
			get {
				if (mCoorType_jfieldId == IntPtr.Zero)
					mCoorType_jfieldId = JNIEnv.GetFieldID (class_ref, "mCoorType", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCoorType_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCoorType_jfieldId == IntPtr.Zero)
					mCoorType_jfieldId = JNIEnv.GetFieldID (class_ref, "mCoorType", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCoorType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mLatitude_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDNotifyListener']/field[@name='mLatitude']"
		[Register ("mLatitude")]
		public double MLatitude {
			get {
				if (mLatitude_jfieldId == IntPtr.Zero)
					mLatitude_jfieldId = JNIEnv.GetFieldID (class_ref, "mLatitude", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, mLatitude_jfieldId);
			}
			set {
				if (mLatitude_jfieldId == IntPtr.Zero)
					mLatitude_jfieldId = JNIEnv.GetFieldID (class_ref, "mLatitude", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mLatitude_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mLatitudeC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDNotifyListener']/field[@name='mLatitudeC']"
		[Register ("mLatitudeC")]
		public double MLatitudeC {
			get {
				if (mLatitudeC_jfieldId == IntPtr.Zero)
					mLatitudeC_jfieldId = JNIEnv.GetFieldID (class_ref, "mLatitudeC", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, mLatitudeC_jfieldId);
			}
			set {
				if (mLatitudeC_jfieldId == IntPtr.Zero)
					mLatitudeC_jfieldId = JNIEnv.GetFieldID (class_ref, "mLatitudeC", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mLatitudeC_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mLongitude_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDNotifyListener']/field[@name='mLongitude']"
		[Register ("mLongitude")]
		public double MLongitude {
			get {
				if (mLongitude_jfieldId == IntPtr.Zero)
					mLongitude_jfieldId = JNIEnv.GetFieldID (class_ref, "mLongitude", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, mLongitude_jfieldId);
			}
			set {
				if (mLongitude_jfieldId == IntPtr.Zero)
					mLongitude_jfieldId = JNIEnv.GetFieldID (class_ref, "mLongitude", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mLongitude_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mLongitudeC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDNotifyListener']/field[@name='mLongitudeC']"
		[Register ("mLongitudeC")]
		public double MLongitudeC {
			get {
				if (mLongitudeC_jfieldId == IntPtr.Zero)
					mLongitudeC_jfieldId = JNIEnv.GetFieldID (class_ref, "mLongitudeC", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, mLongitudeC_jfieldId);
			}
			set {
				if (mLongitudeC_jfieldId == IntPtr.Zero)
					mLongitudeC_jfieldId = JNIEnv.GetFieldID (class_ref, "mLongitudeC", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mLongitudeC_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mRadius_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDNotifyListener']/field[@name='mRadius']"
		[Register ("mRadius")]
		public float MRadius {
			get {
				if (mRadius_jfieldId == IntPtr.Zero)
					mRadius_jfieldId = JNIEnv.GetFieldID (class_ref, "mRadius", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, mRadius_jfieldId);
			}
			set {
				if (mRadius_jfieldId == IntPtr.Zero)
					mRadius_jfieldId = JNIEnv.GetFieldID (class_ref, "mRadius", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mRadius_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/location/BDNotifyListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BDNotifyListener); }
		}

		protected BDNotifyListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.location']/class[@name='BDNotifyListener']/constructor[@name='BDNotifyListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BDNotifyListener ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BDNotifyListener)) {
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

		static Delegate cb_SetNotifyLocation_DDFLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNotifyLocation_DDFLjava_lang_String_Handler ()
		{
			if (cb_SetNotifyLocation_DDFLjava_lang_String_ == null)
				cb_SetNotifyLocation_DDFLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double, float, IntPtr>) n_SetNotifyLocation_DDFLjava_lang_String_);
			return cb_SetNotifyLocation_DDFLjava_lang_String_;
		}

		static void n_SetNotifyLocation_DDFLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, double p0, double p1, float p2, IntPtr native_p3)
		{
			global::Com.Baidu.Location.BDNotifyListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.BDNotifyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SetNotifyLocation (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_SetNotifyLocation_DDFLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDNotifyListener']/method[@name='SetNotifyLocation' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='float'] and parameter[4][@type='java.lang.String']]"
		[Register ("SetNotifyLocation", "(DDFLjava/lang/String;)V", "GetSetNotifyLocation_DDFLjava_lang_String_Handler")]
		public virtual unsafe void SetNotifyLocation (double p0, double p1, float p2, string p3)
		{
			if (id_SetNotifyLocation_DDFLjava_lang_String_ == IntPtr.Zero)
				id_SetNotifyLocation_DDFLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetNotifyLocation", "(DDFLjava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetNotifyLocation_DDFLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetNotifyLocation", "(DDFLjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_onNotify_Lcom_baidu_location_BDLocation_F;
#pragma warning disable 0169
		static Delegate GetOnNotify_Lcom_baidu_location_BDLocation_FHandler ()
		{
			if (cb_onNotify_Lcom_baidu_location_BDLocation_F == null)
				cb_onNotify_Lcom_baidu_location_BDLocation_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float>) n_OnNotify_Lcom_baidu_location_BDLocation_F);
			return cb_onNotify_Lcom_baidu_location_BDLocation_F;
		}

		static void n_OnNotify_Lcom_baidu_location_BDLocation_F (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1)
		{
			global::Com.Baidu.Location.BDNotifyListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.BDNotifyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Location.BDLocation p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.BDLocation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNotify (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onNotify_Lcom_baidu_location_BDLocation_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDNotifyListener']/method[@name='onNotify' and count(parameter)=2 and parameter[1][@type='com.baidu.location.BDLocation'] and parameter[2][@type='float']]"
		[Register ("onNotify", "(Lcom/baidu/location/BDLocation;F)V", "GetOnNotify_Lcom_baidu_location_BDLocation_FHandler")]
		public virtual unsafe void OnNotify (global::Com.Baidu.Location.BDLocation p0, float p1)
		{
			if (id_onNotify_Lcom_baidu_location_BDLocation_F == IntPtr.Zero)
				id_onNotify_Lcom_baidu_location_BDLocation_F = JNIEnv.GetMethodID (class_ref, "onNotify", "(Lcom/baidu/location/BDLocation;F)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNotify_Lcom_baidu_location_BDLocation_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNotify", "(Lcom/baidu/location/BDLocation;F)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/baidu/location/BDNotifyListener", DoNotGenerateAcw=true)]
	internal partial class BDNotifyListenerInvoker : BDNotifyListener {

		public BDNotifyListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BDNotifyListenerInvoker); }
		}

	}

}
