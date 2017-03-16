using System;
using System.Collections.Generic;
using Android.Runtime;

namespace VI.Com.Gdi.Bgl.Android.Java {

	// Metadata.xml XPath class reference: path="/api/package[@name='vi.com.gdi.bgl.android.java']/class[@name='EnvDrawText']"
	[global::Android.Runtime.Register ("vi/com/gdi/bgl/android/java/EnvDrawText", DoNotGenerateAcw=true)]
	public partial class EnvDrawText : global::Java.Lang.Object {


		static IntPtr bBmpChange_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='vi.com.gdi.bgl.android.java']/class[@name='EnvDrawText']/field[@name='bBmpChange']"
		[Register ("bBmpChange")]
		public static bool BBmpChange {
			get {
				if (bBmpChange_jfieldId == IntPtr.Zero)
					bBmpChange_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "bBmpChange", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, bBmpChange_jfieldId);
			}
			set {
				if (bBmpChange_jfieldId == IntPtr.Zero)
					bBmpChange_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "bBmpChange", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, bBmpChange_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr bmp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='vi.com.gdi.bgl.android.java']/class[@name='EnvDrawText']/field[@name='bmp']"
		[Register ("bmp")]
		public static global::Android.Graphics.Bitmap Bmp {
			get {
				if (bmp_jfieldId == IntPtr.Zero)
					bmp_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "bmp", "Landroid/graphics/Bitmap;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, bmp_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (bmp_jfieldId == IntPtr.Zero)
					bmp_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "bmp", "Landroid/graphics/Bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, bmp_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr buffer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='vi.com.gdi.bgl.android.java']/class[@name='EnvDrawText']/field[@name='buffer']"
		[Register ("buffer")]
		public static IList<int> Buffer {
			get {
				if (buffer_jfieldId == IntPtr.Zero)
					buffer_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "buffer", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, buffer_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (buffer_jfieldId == IntPtr.Zero)
					buffer_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "buffer", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, buffer_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr canvasTemp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='vi.com.gdi.bgl.android.java']/class[@name='EnvDrawText']/field[@name='canvasTemp']"
		[Register ("canvasTemp")]
		public static global::Android.Graphics.Canvas CanvasTemp {
			get {
				if (canvasTemp_jfieldId == IntPtr.Zero)
					canvasTemp_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "canvasTemp", "Landroid/graphics/Canvas;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, canvasTemp_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (canvasTemp_jfieldId == IntPtr.Zero)
					canvasTemp_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "canvasTemp", "Landroid/graphics/Canvas;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, canvasTemp_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr fontCache_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='vi.com.gdi.bgl.android.java']/class[@name='EnvDrawText']/field[@name='fontCache']"
		[Register ("fontCache")]
		public static global::Android.Util.SparseArray FontCache {
			get {
				if (fontCache_jfieldId == IntPtr.Zero)
					fontCache_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "fontCache", "Landroid/util/SparseArray;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, fontCache_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Util.SparseArray> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (fontCache_jfieldId == IntPtr.Zero)
					fontCache_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "fontCache", "Landroid/util/SparseArray;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, fontCache_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr iWordHightMax_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='vi.com.gdi.bgl.android.java']/class[@name='EnvDrawText']/field[@name='iWordHightMax']"
		[Register ("iWordHightMax")]
		public static int IWordHightMax {
			get {
				if (iWordHightMax_jfieldId == IntPtr.Zero)
					iWordHightMax_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "iWordHightMax", "I");
				return JNIEnv.GetStaticIntField (class_ref, iWordHightMax_jfieldId);
			}
			set {
				if (iWordHightMax_jfieldId == IntPtr.Zero)
					iWordHightMax_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "iWordHightMax", "I");
				try {
					JNIEnv.SetStaticField (class_ref, iWordHightMax_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr iWordWidthMax_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='vi.com.gdi.bgl.android.java']/class[@name='EnvDrawText']/field[@name='iWordWidthMax']"
		[Register ("iWordWidthMax")]
		public static int IWordWidthMax {
			get {
				if (iWordWidthMax_jfieldId == IntPtr.Zero)
					iWordWidthMax_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "iWordWidthMax", "I");
				return JNIEnv.GetStaticIntField (class_ref, iWordWidthMax_jfieldId);
			}
			set {
				if (iWordWidthMax_jfieldId == IntPtr.Zero)
					iWordWidthMax_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "iWordWidthMax", "I");
				try {
					JNIEnv.SetStaticField (class_ref, iWordWidthMax_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr pt_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='vi.com.gdi.bgl.android.java']/class[@name='EnvDrawText']/field[@name='pt']"
		[Register ("pt")]
		public static global::Android.Graphics.Paint Pt {
			get {
				if (pt_jfieldId == IntPtr.Zero)
					pt_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "pt", "Landroid/graphics/Paint;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, pt_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (pt_jfieldId == IntPtr.Zero)
					pt_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "pt", "Landroid/graphics/Paint;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, pt_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("vi/com/gdi/bgl/android/java/EnvDrawText", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EnvDrawText); }
		}

		protected EnvDrawText (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='vi.com.gdi.bgl.android.java']/class[@name='EnvDrawText']/constructor[@name='EnvDrawText' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EnvDrawText ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (EnvDrawText)) {
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

		static IntPtr id_drawText_Ljava_lang_String_IIarrayIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='vi.com.gdi.bgl.android.java']/class[@name='EnvDrawText']/method[@name='drawText' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int[]'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int']]"
		[Register ("drawText", "(Ljava/lang/String;II[IIIII)[I", "")]
		public static unsafe int[] DrawText (string p0, int p1, int p2, int[] p3, int p4, int p5, int p6, int p7)
		{
			if (id_drawText_Ljava_lang_String_IIarrayIIIII == IntPtr.Zero)
				id_drawText_Ljava_lang_String_IIarrayIIIII = JNIEnv.GetStaticMethodID (class_ref, "drawText", "(Ljava/lang/String;II[IIIII)[I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_drawText_Ljava_lang_String_IIarrayIIIII, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_getTextSize_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='vi.com.gdi.bgl.android.java']/class[@name='EnvDrawText']/method[@name='getTextSize' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getTextSize", "(Ljava/lang/String;II)[S", "")]
		public static unsafe short[] GetTextSize (string p0, int p1, int p2)
		{
			if (id_getTextSize_Ljava_lang_String_II == IntPtr.Zero)
				id_getTextSize_Ljava_lang_String_II = JNIEnv.GetStaticMethodID (class_ref, "getTextSize", "(Ljava/lang/String;II)[S");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				short[] __ret = (short[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTextSize_Ljava_lang_String_II, __args), JniHandleOwnership.TransferLocalRef, typeof (short));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_registFontCache_ILandroid_graphics_Typeface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='vi.com.gdi.bgl.android.java']/class[@name='EnvDrawText']/method[@name='registFontCache' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.graphics.Typeface']]"
		[Register ("registFontCache", "(ILandroid/graphics/Typeface;)V", "")]
		public static unsafe void RegistFontCache (int p0, global::Android.Graphics.Typeface p1)
		{
			if (id_registFontCache_ILandroid_graphics_Typeface_ == IntPtr.Zero)
				id_registFontCache_ILandroid_graphics_Typeface_ = JNIEnv.GetStaticMethodID (class_ref, "registFontCache", "(ILandroid/graphics/Typeface;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_registFontCache_ILandroid_graphics_Typeface_, __args);
			} finally {
			}
		}

		static IntPtr id_removeFontCache_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='vi.com.gdi.bgl.android.java']/class[@name='EnvDrawText']/method[@name='removeFontCache' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeFontCache", "(I)V", "")]
		public static unsafe void RemoveFontCache (int p0)
		{
			if (id_removeFontCache_I == IntPtr.Zero)
				id_removeFontCache_I = JNIEnv.GetStaticMethodID (class_ref, "removeFontCache", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_removeFontCache_I, __args);
			} finally {
			}
		}

	}
}
