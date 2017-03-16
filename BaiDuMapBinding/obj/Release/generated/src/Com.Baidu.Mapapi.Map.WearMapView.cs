using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/WearMapView", DoNotGenerateAcw=true)]
	public partial class WearMapView : global::Android.Views.ViewGroup, global::Android.Views.View.IOnApplyWindowInsetsListener {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/field[@name='BT_INVIEW']"
		[Register ("BT_INVIEW")]
		public const int BtInview = (int) 1;

		static IntPtr mTask_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/field[@name='mTask']"
		[Register ("mTask")]
		public global::Com.Baidu.Mapapi.Map.WearMapView.AnimationTask MTask {
			get {
				if (mTask_jfieldId == IntPtr.Zero)
					mTask_jfieldId = JNIEnv.GetFieldID (class_ref, "mTask", "Lcom/baidu/mapapi/map/WearMapView$AnimationTask;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mTask_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView.AnimationTask> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTask_jfieldId == IntPtr.Zero)
					mTask_jfieldId = JNIEnv.GetFieldID (class_ref, "mTask", "Lcom/baidu/mapapi/map/WearMapView$AnimationTask;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mTask_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mTimer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/field[@name='mTimer']"
		[Register ("mTimer")]
		public global::Java.Util.Timer MTimer {
			get {
				if (mTimer_jfieldId == IntPtr.Zero)
					mTimer_jfieldId = JNIEnv.GetFieldID (class_ref, "mTimer", "Ljava/util/Timer;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mTimer_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Timer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTimer_jfieldId == IntPtr.Zero)
					mTimer_jfieldId = JNIEnv.GetFieldID (class_ref, "mTimer", "Ljava/util/Timer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mTimer_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView.AnimationTask']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/map/WearMapView$AnimationTask", DoNotGenerateAcw=true)]
		public partial class AnimationTask : global::Java.Util.TimerTask {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/mapapi/map/WearMapView$AnimationTask", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AnimationTask); }
			}

			protected AnimationTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_baidu_mapapi_map_WearMapView_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView.AnimationTask']/constructor[@name='WearMapView.AnimationTask' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.WearMapView']]"
			[Register (".ctor", "(Lcom/baidu/mapapi/map/WearMapView;)V", "")]
			public unsafe AnimationTask (global::Com.Baidu.Mapapi.Map.WearMapView __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (AnimationTask)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_baidu_mapapi_map_WearMapView_ == IntPtr.Zero)
						id_ctor_Lcom_baidu_mapapi_map_WearMapView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/baidu/mapapi/map/WearMapView;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_baidu_mapapi_map_WearMapView_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_baidu_mapapi_map_WearMapView_, __args);
				} finally {
				}
			}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Map.WearMapView.AnimationTask __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView.AnimationTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView.AnimationTask']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public override unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='WearMapView.OnDismissCallback']"
		[Register ("com/baidu/mapapi/map/WearMapView$OnDismissCallback", "", "Com.Baidu.Mapapi.Map.WearMapView/IOnDismissCallbackInvoker")]
		public partial interface IOnDismissCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='WearMapView.OnDismissCallback']/method[@name='onDismiss' and count(parameter)=0]"
			[Register ("onDismiss", "()V", "GetOnDismissHandler:Com.Baidu.Mapapi.Map.WearMapView/IOnDismissCallbackInvoker, BaiDuMapBinding")]
			void OnDismiss ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='WearMapView.OnDismissCallback']/method[@name='onNotify' and count(parameter)=0]"
			[Register ("onNotify", "()V", "GetOnNotifyHandler:Com.Baidu.Mapapi.Map.WearMapView/IOnDismissCallbackInvoker, BaiDuMapBinding")]
			void OnNotify ();

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/WearMapView$OnDismissCallback", DoNotGenerateAcw=true)]
		internal class IOnDismissCallbackInvoker : global::Java.Lang.Object, IOnDismissCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/mapapi/map/WearMapView$OnDismissCallback");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnDismissCallbackInvoker); }
			}

			IntPtr class_ref;

			public static IOnDismissCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnDismissCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.WearMapView.OnDismissCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnDismissCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onDismiss;
#pragma warning disable 0169
			static Delegate GetOnDismissHandler ()
			{
				if (cb_onDismiss == null)
					cb_onDismiss = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDismiss);
				return cb_onDismiss;
			}

			static void n_OnDismiss (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Map.WearMapView.IOnDismissCallback __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView.IOnDismissCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnDismiss ();
			}
#pragma warning restore 0169

			IntPtr id_onDismiss;
			public unsafe void OnDismiss ()
			{
				if (id_onDismiss == IntPtr.Zero)
					id_onDismiss = JNIEnv.GetMethodID (class_ref, "onDismiss", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDismiss);
			}

			static Delegate cb_onNotify;
#pragma warning disable 0169
			static Delegate GetOnNotifyHandler ()
			{
				if (cb_onNotify == null)
					cb_onNotify = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnNotify);
				return cb_onNotify;
			}

			static void n_OnNotify (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Map.WearMapView.IOnDismissCallback __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView.IOnDismissCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnNotify ();
			}
#pragma warning restore 0169

			IntPtr id_onNotify;
			public unsafe void OnNotify ()
			{
				if (id_onNotify == IntPtr.Zero)
					id_onNotify = JNIEnv.GetMethodID (class_ref, "onNotify", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNotify);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/WearMapView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WearMapView); }
		}

		protected WearMapView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/constructor[@name='WearMapView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe WearMapView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (WearMapView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/constructor[@name='WearMapView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe WearMapView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (WearMapView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_baidu_mapapi_map_BaiduMapOptions_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/constructor[@name='WearMapView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.baidu.mapapi.map.BaiduMapOptions']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/baidu/mapapi/map/BaiduMapOptions;)V", "")]
		public unsafe WearMapView (global::Android.Content.Context p0, global::Com.Baidu.Mapapi.Map.BaiduMapOptions p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (WearMapView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Lcom/baidu/mapapi/map/BaiduMapOptions;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Lcom/baidu/mapapi/map/BaiduMapOptions;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_baidu_mapapi_map_BaiduMapOptions_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_baidu_mapapi_map_BaiduMapOptions_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/baidu/mapapi/map/BaiduMapOptions;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_baidu_mapapi_map_BaiduMapOptions_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_baidu_mapapi_map_BaiduMapOptions_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/constructor[@name='WearMapView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe WearMapView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (WearMapView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_getMap;
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMap Map {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='getMap' and count(parameter)=0]"
			[Register ("getMap", "()Lcom/baidu/mapapi/map/BaiduMap;", "GetGetMapHandler")]
			get {
				if (id_getMap == IntPtr.Zero)
					id_getMap = JNIEnv.GetMethodID (class_ref, "getMap", "()Lcom/baidu/mapapi/map/BaiduMap;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMap), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMapLevel;
		public unsafe int MapLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='getMapLevel' and count(parameter)=0]"
			[Register ("getMapLevel", "()I", "GetGetMapLevelHandler")]
			get {
				if (id_getMapLevel == IntPtr.Zero)
					id_getMapLevel = JNIEnv.GetMethodID (class_ref, "getMapLevel", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMapLevel);
				} finally {
				}
			}
		}

		static Delegate cb_getScaleControlViewHeight;
#pragma warning disable 0169
		static Delegate GetGetScaleControlViewHeightHandler ()
		{
			if (cb_getScaleControlViewHeight == null)
				cb_getScaleControlViewHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetScaleControlViewHeight);
			return cb_getScaleControlViewHeight;
		}

		static int n_GetScaleControlViewHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScaleControlViewHeight;
		}
#pragma warning restore 0169

		static IntPtr id_getScaleControlViewHeight;
		public virtual unsafe int ScaleControlViewHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='getScaleControlViewHeight' and count(parameter)=0]"
			[Register ("getScaleControlViewHeight", "()I", "GetGetScaleControlViewHeightHandler")]
			get {
				if (id_getScaleControlViewHeight == IntPtr.Zero)
					id_getScaleControlViewHeight = JNIEnv.GetMethodID (class_ref, "getScaleControlViewHeight", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getScaleControlViewHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScaleControlViewHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getScaleControlViewWidth;
#pragma warning disable 0169
		static Delegate GetGetScaleControlViewWidthHandler ()
		{
			if (cb_getScaleControlViewWidth == null)
				cb_getScaleControlViewWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetScaleControlViewWidth);
			return cb_getScaleControlViewWidth;
		}

		static int n_GetScaleControlViewWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScaleControlViewWidth;
		}
#pragma warning restore 0169

		static IntPtr id_getScaleControlViewWidth;
		public virtual unsafe int ScaleControlViewWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='getScaleControlViewWidth' and count(parameter)=0]"
			[Register ("getScaleControlViewWidth", "()I", "GetGetScaleControlViewWidthHandler")]
			get {
				if (id_getScaleControlViewWidth == IntPtr.Zero)
					id_getScaleControlViewWidth = JNIEnv.GetMethodID (class_ref, "getScaleControlViewWidth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getScaleControlViewWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScaleControlViewWidth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_onApplyWindowInsets_Landroid_view_View_Landroid_view_WindowInsets_;
#pragma warning disable 0169
		static Delegate GetOnApplyWindowInsets_Landroid_view_View_Landroid_view_WindowInsets_Handler ()
		{
			if (cb_onApplyWindowInsets_Landroid_view_View_Landroid_view_WindowInsets_ == null)
				cb_onApplyWindowInsets_Landroid_view_View_Landroid_view_WindowInsets_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnApplyWindowInsets_Landroid_view_View_Landroid_view_WindowInsets_);
			return cb_onApplyWindowInsets_Landroid_view_View_Landroid_view_WindowInsets_;
		}

		static IntPtr n_OnApplyWindowInsets_Landroid_view_View_Landroid_view_WindowInsets_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.WindowInsets p1 = global::Java.Lang.Object.GetObject<global::Android.Views.WindowInsets> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnApplyWindowInsets (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onApplyWindowInsets_Landroid_view_View_Landroid_view_WindowInsets_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='onApplyWindowInsets' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.WindowInsets']]"
		[Register ("onApplyWindowInsets", "(Landroid/view/View;Landroid/view/WindowInsets;)Landroid/view/WindowInsets;", "GetOnApplyWindowInsets_Landroid_view_View_Landroid_view_WindowInsets_Handler")]
		public virtual unsafe global::Android.Views.WindowInsets OnApplyWindowInsets (global::Android.Views.View p0, global::Android.Views.WindowInsets p1)
		{
			if (id_onApplyWindowInsets_Landroid_view_View_Landroid_view_WindowInsets_ == IntPtr.Zero)
				id_onApplyWindowInsets_Landroid_view_View_Landroid_view_WindowInsets_ = JNIEnv.GetMethodID (class_ref, "onApplyWindowInsets", "(Landroid/view/View;Landroid/view/WindowInsets;)Landroid/view/WindowInsets;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Android.Views.WindowInsets __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.WindowInsets> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onApplyWindowInsets_Landroid_view_View_Landroid_view_WindowInsets_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.WindowInsets> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onApplyWindowInsets", "(Landroid/view/View;Landroid/view/WindowInsets;)Landroid/view/WindowInsets;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onCreate_Landroid_content_Context_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_content_Context_Landroid_os_Bundle_Handler ()
		{
			if (cb_onCreate_Landroid_content_Context_Landroid_os_Bundle_ == null)
				cb_onCreate_Landroid_content_Context_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCreate_Landroid_content_Context_Landroid_os_Bundle_);
			return cb_onCreate_Landroid_content_Context_Landroid_os_Bundle_;
		}

		static void n_OnCreate_Landroid_content_Context_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onCreate_Landroid_content_Context_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='onCreate' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/content/Context;Landroid/os/Bundle;)V", "GetOnCreate_Landroid_content_Context_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnCreate (global::Android.Content.Context p0, global::Android.OS.Bundle p1)
		{
			if (id_onCreate_Landroid_content_Context_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCreate_Landroid_content_Context_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/content/Context;Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreate_Landroid_content_Context_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreate", "(Landroid/content/Context;Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "")]
		public unsafe void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDestroy);
			} finally {
			}
		}

		static IntPtr id_onDismiss;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='onDismiss' and count(parameter)=0]"
		[Register ("onDismiss", "()V", "")]
		public unsafe void OnDismiss ()
		{
			if (id_onDismiss == IntPtr.Zero)
				id_onDismiss = JNIEnv.GetMethodID (class_ref, "onDismiss", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDismiss);
			} finally {
			}
		}

		static IntPtr id_onEnterAmbient_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='onEnterAmbient' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onEnterAmbient", "(Landroid/os/Bundle;)V", "")]
		public unsafe void OnEnterAmbient (global::Android.OS.Bundle p0)
		{
			if (id_onEnterAmbient_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onEnterAmbient_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onEnterAmbient", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEnterAmbient_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

		static Delegate cb_onExitAmbient;
#pragma warning disable 0169
		static Delegate GetOnExitAmbientHandler ()
		{
			if (cb_onExitAmbient == null)
				cb_onExitAmbient = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnExitAmbient);
			return cb_onExitAmbient;
		}

		static void n_OnExitAmbient (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnExitAmbient ();
		}
#pragma warning restore 0169

		static IntPtr id_onExitAmbient;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='onExitAmbient' and count(parameter)=0]"
		[Register ("onExitAmbient", "()V", "GetOnExitAmbientHandler")]
		public virtual unsafe void OnExitAmbient ()
		{
			if (id_onExitAmbient == IntPtr.Zero)
				id_onExitAmbient = JNIEnv.GetMethodID (class_ref, "onExitAmbient", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onExitAmbient);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onExitAmbient", "()V"));
			} finally {
			}
		}

		static IntPtr id_onLayout_ZIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onLayout", "(ZIIII)V", "")]
		protected override sealed unsafe void OnLayout (bool p0, int p1, int p2, int p3, int p4)
		{
			if (id_onLayout_ZIIII == IntPtr.Zero)
				id_onLayout_ZIIII = JNIEnv.GetMethodID (class_ref, "onLayout", "(ZIIII)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLayout_ZIIII, __args);
			} finally {
			}
		}

		static Delegate cb_onSaveInstanceState_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnSaveInstanceState_Landroid_os_Bundle_Handler ()
		{
			if (cb_onSaveInstanceState_Landroid_os_Bundle_ == null)
				cb_onSaveInstanceState_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSaveInstanceState_Landroid_os_Bundle_);
			return cb_onSaveInstanceState_Landroid_os_Bundle_;
		}

		static void n_OnSaveInstanceState_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSaveInstanceState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSaveInstanceState_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='onSaveInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onSaveInstanceState", "(Landroid/os/Bundle;)V", "GetOnSaveInstanceState_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnSaveInstanceState (global::Android.OS.Bundle p0)
		{
			if (id_onSaveInstanceState_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onSaveInstanceState_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onSaveInstanceState", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSaveInstanceState_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_setCustomMapStylePath_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='setCustomMapStylePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCustomMapStylePath", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetCustomMapStylePath (string p0)
		{
			if (id_setCustomMapStylePath_Ljava_lang_String_ == IntPtr.Zero)
				id_setCustomMapStylePath_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setCustomMapStylePath", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setCustomMapStylePath_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setMapCustomEnable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='setMapCustomEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMapCustomEnable", "(Z)V", "")]
		public static unsafe void SetMapCustomEnable (bool p0)
		{
			if (id_setMapCustomEnable_Z == IntPtr.Zero)
				id_setMapCustomEnable_Z = JNIEnv.GetStaticMethodID (class_ref, "setMapCustomEnable", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setMapCustomEnable_Z, __args);
			} finally {
			}
		}

		static Delegate cb_setOnDismissCallbackListener_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_;
#pragma warning disable 0169
		static Delegate GetSetOnDismissCallbackListener_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_Handler ()
		{
			if (cb_setOnDismissCallbackListener_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_ == null)
				cb_setOnDismissCallbackListener_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnDismissCallbackListener_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_);
			return cb_setOnDismissCallbackListener_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_;
		}

		static void n_SetOnDismissCallbackListener_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.WearMapView.IOnDismissCallback p0 = (global::Com.Baidu.Mapapi.Map.WearMapView.IOnDismissCallback)global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView.IOnDismissCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnDismissCallbackListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnDismissCallbackListener_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='setOnDismissCallbackListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.WearMapView.OnDismissCallback']]"
		[Register ("setOnDismissCallbackListener", "(Lcom/baidu/mapapi/map/WearMapView$OnDismissCallback;)V", "GetSetOnDismissCallbackListener_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_Handler")]
		public virtual unsafe void SetOnDismissCallbackListener (global::Com.Baidu.Mapapi.Map.WearMapView.IOnDismissCallback p0)
		{
			if (id_setOnDismissCallbackListener_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_ == IntPtr.Zero)
				id_setOnDismissCallbackListener_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_ = JNIEnv.GetMethodID (class_ref, "setOnDismissCallbackListener", "(Lcom/baidu/mapapi/map/WearMapView$OnDismissCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnDismissCallbackListener_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnDismissCallbackListener", "(Lcom/baidu/mapapi/map/WearMapView$OnDismissCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setScaleControlPosition_Landroid_graphics_Point_;
#pragma warning disable 0169
		static Delegate GetSetScaleControlPosition_Landroid_graphics_Point_Handler ()
		{
			if (cb_setScaleControlPosition_Landroid_graphics_Point_ == null)
				cb_setScaleControlPosition_Landroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScaleControlPosition_Landroid_graphics_Point_);
			return cb_setScaleControlPosition_Landroid_graphics_Point_;
		}

		static void n_SetScaleControlPosition_Landroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetScaleControlPosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScaleControlPosition_Landroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='setScaleControlPosition' and count(parameter)=1 and parameter[1][@type='android.graphics.Point']]"
		[Register ("setScaleControlPosition", "(Landroid/graphics/Point;)V", "GetSetScaleControlPosition_Landroid_graphics_Point_Handler")]
		public virtual unsafe void SetScaleControlPosition (global::Android.Graphics.Point p0)
		{
			if (id_setScaleControlPosition_Landroid_graphics_Point_ == IntPtr.Zero)
				id_setScaleControlPosition_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "setScaleControlPosition", "(Landroid/graphics/Point;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScaleControlPosition_Landroid_graphics_Point_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScaleControlPosition", "(Landroid/graphics/Point;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setViewAnimitionEnable_Z;
#pragma warning disable 0169
		static Delegate GetSetViewAnimitionEnable_ZHandler ()
		{
			if (cb_setViewAnimitionEnable_Z == null)
				cb_setViewAnimitionEnable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetViewAnimitionEnable_Z);
			return cb_setViewAnimitionEnable_Z;
		}

		static void n_SetViewAnimitionEnable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetViewAnimitionEnable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setViewAnimitionEnable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='setViewAnimitionEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setViewAnimitionEnable", "(Z)V", "GetSetViewAnimitionEnable_ZHandler")]
		public virtual unsafe void SetViewAnimitionEnable (bool p0)
		{
			if (id_setViewAnimitionEnable_Z == IntPtr.Zero)
				id_setViewAnimitionEnable_Z = JNIEnv.GetMethodID (class_ref, "setViewAnimitionEnable", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setViewAnimitionEnable_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setViewAnimitionEnable", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setZoomControlsPosition_Landroid_graphics_Point_;
#pragma warning disable 0169
		static Delegate GetSetZoomControlsPosition_Landroid_graphics_Point_Handler ()
		{
			if (cb_setZoomControlsPosition_Landroid_graphics_Point_ == null)
				cb_setZoomControlsPosition_Landroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetZoomControlsPosition_Landroid_graphics_Point_);
			return cb_setZoomControlsPosition_Landroid_graphics_Point_;
		}

		static void n_SetZoomControlsPosition_Landroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetZoomControlsPosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setZoomControlsPosition_Landroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='setZoomControlsPosition' and count(parameter)=1 and parameter[1][@type='android.graphics.Point']]"
		[Register ("setZoomControlsPosition", "(Landroid/graphics/Point;)V", "GetSetZoomControlsPosition_Landroid_graphics_Point_Handler")]
		public virtual unsafe void SetZoomControlsPosition (global::Android.Graphics.Point p0)
		{
			if (id_setZoomControlsPosition_Landroid_graphics_Point_ == IntPtr.Zero)
				id_setZoomControlsPosition_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "setZoomControlsPosition", "(Landroid/graphics/Point;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setZoomControlsPosition_Landroid_graphics_Point_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setZoomControlsPosition", "(Landroid/graphics/Point;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_showScaleControl_Z;
#pragma warning disable 0169
		static Delegate GetShowScaleControl_ZHandler ()
		{
			if (cb_showScaleControl_Z == null)
				cb_showScaleControl_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ShowScaleControl_Z);
			return cb_showScaleControl_Z;
		}

		static void n_ShowScaleControl_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowScaleControl (p0);
		}
#pragma warning restore 0169

		static IntPtr id_showScaleControl_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='showScaleControl' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showScaleControl", "(Z)V", "GetShowScaleControl_ZHandler")]
		public virtual unsafe void ShowScaleControl (bool p0)
		{
			if (id_showScaleControl_Z == IntPtr.Zero)
				id_showScaleControl_Z = JNIEnv.GetMethodID (class_ref, "showScaleControl", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showScaleControl_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showScaleControl", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_showZoomControls_Z;
#pragma warning disable 0169
		static Delegate GetShowZoomControls_ZHandler ()
		{
			if (cb_showZoomControls_Z == null)
				cb_showZoomControls_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ShowZoomControls_Z);
			return cb_showZoomControls_Z;
		}

		static void n_ShowZoomControls_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowZoomControls (p0);
		}
#pragma warning restore 0169

		static IntPtr id_showZoomControls_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='showZoomControls' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showZoomControls", "(Z)V", "GetShowZoomControls_ZHandler")]
		public virtual unsafe void ShowZoomControls (bool p0)
		{
			if (id_showZoomControls_Z == IntPtr.Zero)
				id_showZoomControls_Z = JNIEnv.GetMethodID (class_ref, "showZoomControls", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showZoomControls_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showZoomControls", "(Z)V"), __args);
			} finally {
			}
		}

	}
}
