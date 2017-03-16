using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/MyLocationData", DoNotGenerateAcw=true)]
	public partial class MyLocationData : global::Java.Lang.Object {


		static IntPtr accuracy_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData']/field[@name='accuracy']"
		[Register ("accuracy")]
		public float Accuracy {
			get {
				if (accuracy_jfieldId == IntPtr.Zero)
					accuracy_jfieldId = JNIEnv.GetFieldID (class_ref, "accuracy", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, accuracy_jfieldId);
			}
			set {
				if (accuracy_jfieldId == IntPtr.Zero)
					accuracy_jfieldId = JNIEnv.GetFieldID (class_ref, "accuracy", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, accuracy_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr direction_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData']/field[@name='direction']"
		[Register ("direction")]
		public float Direction {
			get {
				if (direction_jfieldId == IntPtr.Zero)
					direction_jfieldId = JNIEnv.GetFieldID (class_ref, "direction", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, direction_jfieldId);
			}
			set {
				if (direction_jfieldId == IntPtr.Zero)
					direction_jfieldId = JNIEnv.GetFieldID (class_ref, "direction", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, direction_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr latitude_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData']/field[@name='latitude']"
		[Register ("latitude")]
		public double Latitude {
			get {
				if (latitude_jfieldId == IntPtr.Zero)
					latitude_jfieldId = JNIEnv.GetFieldID (class_ref, "latitude", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, latitude_jfieldId);
			}
			set {
				if (latitude_jfieldId == IntPtr.Zero)
					latitude_jfieldId = JNIEnv.GetFieldID (class_ref, "latitude", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, latitude_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr longitude_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData']/field[@name='longitude']"
		[Register ("longitude")]
		public double Longitude {
			get {
				if (longitude_jfieldId == IntPtr.Zero)
					longitude_jfieldId = JNIEnv.GetFieldID (class_ref, "longitude", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, longitude_jfieldId);
			}
			set {
				if (longitude_jfieldId == IntPtr.Zero)
					longitude_jfieldId = JNIEnv.GetFieldID (class_ref, "longitude", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, longitude_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr satellitesNum_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData']/field[@name='satellitesNum']"
		[Register ("satellitesNum")]
		public int SatellitesNum {
			get {
				if (satellitesNum_jfieldId == IntPtr.Zero)
					satellitesNum_jfieldId = JNIEnv.GetFieldID (class_ref, "satellitesNum", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, satellitesNum_jfieldId);
			}
			set {
				if (satellitesNum_jfieldId == IntPtr.Zero)
					satellitesNum_jfieldId = JNIEnv.GetFieldID (class_ref, "satellitesNum", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, satellitesNum_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr speed_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData']/field[@name='speed']"
		[Register ("speed")]
		public float Speed {
			get {
				if (speed_jfieldId == IntPtr.Zero)
					speed_jfieldId = JNIEnv.GetFieldID (class_ref, "speed", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, speed_jfieldId);
			}
			set {
				if (speed_jfieldId == IntPtr.Zero)
					speed_jfieldId = JNIEnv.GetFieldID (class_ref, "speed", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, speed_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData.Builder']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/map/MyLocationData$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/mapapi/map/MyLocationData$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData.Builder']/constructor[@name='MyLocationData.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Builder)) {
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

			static Delegate cb_accuracy_F;
#pragma warning disable 0169
			static Delegate GetAccuracy_FHandler ()
			{
				if (cb_accuracy_F == null)
					cb_accuracy_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_Accuracy_F);
				return cb_accuracy_F;
			}

			static IntPtr n_Accuracy_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				global::Com.Baidu.Mapapi.Map.MyLocationData.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Accuracy (p0));
			}
#pragma warning restore 0169

			static IntPtr id_accuracy_F;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData.Builder']/method[@name='accuracy' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("accuracy", "(F)Lcom/baidu/mapapi/map/MyLocationData$Builder;", "GetAccuracy_FHandler")]
			public virtual unsafe global::Com.Baidu.Mapapi.Map.MyLocationData.Builder Accuracy (float p0)
			{
				if (id_accuracy_F == IntPtr.Zero)
					id_accuracy_F = JNIEnv.GetMethodID (class_ref, "accuracy", "(F)Lcom/baidu/mapapi/map/MyLocationData$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_accuracy_F, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "accuracy", "(F)Lcom/baidu/mapapi/map/MyLocationData$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Map.MyLocationData.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/baidu/mapapi/map/MyLocationData;", "GetBuildHandler")]
			public virtual unsafe global::Com.Baidu.Mapapi.Map.MyLocationData Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/baidu/mapapi/map/MyLocationData;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/baidu/mapapi/map/MyLocationData;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_direction_F;
#pragma warning disable 0169
			static Delegate GetDirection_FHandler ()
			{
				if (cb_direction_F == null)
					cb_direction_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_Direction_F);
				return cb_direction_F;
			}

			static IntPtr n_Direction_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				global::Com.Baidu.Mapapi.Map.MyLocationData.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Direction (p0));
			}
#pragma warning restore 0169

			static IntPtr id_direction_F;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData.Builder']/method[@name='direction' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("direction", "(F)Lcom/baidu/mapapi/map/MyLocationData$Builder;", "GetDirection_FHandler")]
			public virtual unsafe global::Com.Baidu.Mapapi.Map.MyLocationData.Builder Direction (float p0)
			{
				if (id_direction_F == IntPtr.Zero)
					id_direction_F = JNIEnv.GetMethodID (class_ref, "direction", "(F)Lcom/baidu/mapapi/map/MyLocationData$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_direction_F, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "direction", "(F)Lcom/baidu/mapapi/map/MyLocationData$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_latitude_D;
#pragma warning disable 0169
			static Delegate GetLatitude_DHandler ()
			{
				if (cb_latitude_D == null)
					cb_latitude_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_Latitude_D);
				return cb_latitude_D;
			}

			static IntPtr n_Latitude_D (IntPtr jnienv, IntPtr native__this, double p0)
			{
				global::Com.Baidu.Mapapi.Map.MyLocationData.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Latitude (p0));
			}
#pragma warning restore 0169

			static IntPtr id_latitude_D;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData.Builder']/method[@name='latitude' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("latitude", "(D)Lcom/baidu/mapapi/map/MyLocationData$Builder;", "GetLatitude_DHandler")]
			public virtual unsafe global::Com.Baidu.Mapapi.Map.MyLocationData.Builder Latitude (double p0)
			{
				if (id_latitude_D == IntPtr.Zero)
					id_latitude_D = JNIEnv.GetMethodID (class_ref, "latitude", "(D)Lcom/baidu/mapapi/map/MyLocationData$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_latitude_D, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "latitude", "(D)Lcom/baidu/mapapi/map/MyLocationData$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_longitude_D;
#pragma warning disable 0169
			static Delegate GetLongitude_DHandler ()
			{
				if (cb_longitude_D == null)
					cb_longitude_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_Longitude_D);
				return cb_longitude_D;
			}

			static IntPtr n_Longitude_D (IntPtr jnienv, IntPtr native__this, double p0)
			{
				global::Com.Baidu.Mapapi.Map.MyLocationData.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Longitude (p0));
			}
#pragma warning restore 0169

			static IntPtr id_longitude_D;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData.Builder']/method[@name='longitude' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("longitude", "(D)Lcom/baidu/mapapi/map/MyLocationData$Builder;", "GetLongitude_DHandler")]
			public virtual unsafe global::Com.Baidu.Mapapi.Map.MyLocationData.Builder Longitude (double p0)
			{
				if (id_longitude_D == IntPtr.Zero)
					id_longitude_D = JNIEnv.GetMethodID (class_ref, "longitude", "(D)Lcom/baidu/mapapi/map/MyLocationData$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_longitude_D, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "longitude", "(D)Lcom/baidu/mapapi/map/MyLocationData$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_satellitesNum_I;
#pragma warning disable 0169
			static Delegate GetSatellitesNum_IHandler ()
			{
				if (cb_satellitesNum_I == null)
					cb_satellitesNum_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SatellitesNum_I);
				return cb_satellitesNum_I;
			}

			static IntPtr n_SatellitesNum_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Baidu.Mapapi.Map.MyLocationData.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SatellitesNum (p0));
			}
#pragma warning restore 0169

			static IntPtr id_satellitesNum_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData.Builder']/method[@name='satellitesNum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("satellitesNum", "(I)Lcom/baidu/mapapi/map/MyLocationData$Builder;", "GetSatellitesNum_IHandler")]
			public virtual unsafe global::Com.Baidu.Mapapi.Map.MyLocationData.Builder SatellitesNum (int p0)
			{
				if (id_satellitesNum_I == IntPtr.Zero)
					id_satellitesNum_I = JNIEnv.GetMethodID (class_ref, "satellitesNum", "(I)Lcom/baidu/mapapi/map/MyLocationData$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_satellitesNum_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "satellitesNum", "(I)Lcom/baidu/mapapi/map/MyLocationData$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_speed_F;
#pragma warning disable 0169
			static Delegate GetSpeed_FHandler ()
			{
				if (cb_speed_F == null)
					cb_speed_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_Speed_F);
				return cb_speed_F;
			}

			static IntPtr n_Speed_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				global::Com.Baidu.Mapapi.Map.MyLocationData.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Speed (p0));
			}
#pragma warning restore 0169

			static IntPtr id_speed_F;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData.Builder']/method[@name='speed' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("speed", "(F)Lcom/baidu/mapapi/map/MyLocationData$Builder;", "GetSpeed_FHandler")]
			public virtual unsafe global::Com.Baidu.Mapapi.Map.MyLocationData.Builder Speed (float p0)
			{
				if (id_speed_F == IntPtr.Zero)
					id_speed_F = JNIEnv.GetMethodID (class_ref, "speed", "(F)Lcom/baidu/mapapi/map/MyLocationData$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_speed_F, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "speed", "(F)Lcom/baidu/mapapi/map/MyLocationData$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/MyLocationData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MyLocationData); }
		}

		protected MyLocationData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
