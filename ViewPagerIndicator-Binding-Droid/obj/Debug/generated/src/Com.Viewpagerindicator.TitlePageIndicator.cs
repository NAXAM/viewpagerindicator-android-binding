using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Viewpagerindicator {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']"
	[global::Android.Runtime.Register ("com/viewpagerindicator/TitlePageIndicator", DoNotGenerateAcw=true)]
	public partial class TitlePageIndicator : global::Android.Views.View, global::Com.Viewpagerindicator.IPageIndicator {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator.IndicatorStyle']"
		[global::Android.Runtime.Register ("com/viewpagerindicator/TitlePageIndicator$IndicatorStyle", DoNotGenerateAcw=true)]
		public sealed partial class IndicatorStyle : global::Java.Lang.Enum {


			static IntPtr None_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator.IndicatorStyle']/field[@name='None']"
			[Register ("None")]
			public static global::Com.Viewpagerindicator.TitlePageIndicator.IndicatorStyle None {
				get {
					if (None_jfieldId == IntPtr.Zero)
						None_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "None", "Lcom/viewpagerindicator/TitlePageIndicator$IndicatorStyle;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, None_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator.IndicatorStyle> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Triangle_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator.IndicatorStyle']/field[@name='Triangle']"
			[Register ("Triangle")]
			public static global::Com.Viewpagerindicator.TitlePageIndicator.IndicatorStyle Triangle {
				get {
					if (Triangle_jfieldId == IntPtr.Zero)
						Triangle_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Triangle", "Lcom/viewpagerindicator/TitlePageIndicator$IndicatorStyle;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Triangle_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator.IndicatorStyle> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Underline_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator.IndicatorStyle']/field[@name='Underline']"
			[Register ("Underline")]
			public static global::Com.Viewpagerindicator.TitlePageIndicator.IndicatorStyle Underline {
				get {
					if (Underline_jfieldId == IntPtr.Zero)
						Underline_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Underline", "Lcom/viewpagerindicator/TitlePageIndicator$IndicatorStyle;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Underline_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator.IndicatorStyle> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr value_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator.IndicatorStyle']/field[@name='value']"
			[Register ("value")]
			public int Value {
				get {
					if (value_jfieldId == IntPtr.Zero)
						value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, value_jfieldId);
				}
				set {
					if (value_jfieldId == IntPtr.Zero)
						value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, value_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/viewpagerindicator/TitlePageIndicator$IndicatorStyle", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IndicatorStyle); }
			}

			internal IndicatorStyle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_fromValue_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator.IndicatorStyle']/method[@name='fromValue' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("fromValue", "(I)Lcom/viewpagerindicator/TitlePageIndicator$IndicatorStyle;", "")]
			public static unsafe global::Com.Viewpagerindicator.TitlePageIndicator.IndicatorStyle FromValue (int p0)
			{
				if (id_fromValue_I == IntPtr.Zero)
					id_fromValue_I = JNIEnv.GetStaticMethodID (class_ref, "fromValue", "(I)Lcom/viewpagerindicator/TitlePageIndicator$IndicatorStyle;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator.IndicatorStyle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromValue_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator.IndicatorStyle']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/viewpagerindicator/TitlePageIndicator$IndicatorStyle;", "")]
			public static unsafe global::Com.Viewpagerindicator.TitlePageIndicator.IndicatorStyle ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/viewpagerindicator/TitlePageIndicator$IndicatorStyle;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Viewpagerindicator.TitlePageIndicator.IndicatorStyle __ret = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator.IndicatorStyle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator.IndicatorStyle']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/viewpagerindicator/TitlePageIndicator$IndicatorStyle;", "")]
			public static unsafe global::Com.Viewpagerindicator.TitlePageIndicator.IndicatorStyle[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/viewpagerindicator/TitlePageIndicator$IndicatorStyle;");
				try {
					return (global::Com.Viewpagerindicator.TitlePageIndicator.IndicatorStyle[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Viewpagerindicator.TitlePageIndicator.IndicatorStyle));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator.LinePosition']"
		[global::Android.Runtime.Register ("com/viewpagerindicator/TitlePageIndicator$LinePosition", DoNotGenerateAcw=true)]
		public sealed partial class LinePosition : global::Java.Lang.Enum {


			static IntPtr Bottom_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator.LinePosition']/field[@name='Bottom']"
			[Register ("Bottom")]
			public static global::Com.Viewpagerindicator.TitlePageIndicator.LinePosition Bottom {
				get {
					if (Bottom_jfieldId == IntPtr.Zero)
						Bottom_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Bottom", "Lcom/viewpagerindicator/TitlePageIndicator$LinePosition;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Bottom_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator.LinePosition> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Top_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator.LinePosition']/field[@name='Top']"
			[Register ("Top")]
			public static global::Com.Viewpagerindicator.TitlePageIndicator.LinePosition Top {
				get {
					if (Top_jfieldId == IntPtr.Zero)
						Top_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Top", "Lcom/viewpagerindicator/TitlePageIndicator$LinePosition;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Top_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator.LinePosition> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr value_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator.LinePosition']/field[@name='value']"
			[Register ("value")]
			public int Value {
				get {
					if (value_jfieldId == IntPtr.Zero)
						value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, value_jfieldId);
				}
				set {
					if (value_jfieldId == IntPtr.Zero)
						value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, value_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/viewpagerindicator/TitlePageIndicator$LinePosition", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LinePosition); }
			}

			internal LinePosition (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_fromValue_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator.LinePosition']/method[@name='fromValue' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("fromValue", "(I)Lcom/viewpagerindicator/TitlePageIndicator$LinePosition;", "")]
			public static unsafe global::Com.Viewpagerindicator.TitlePageIndicator.LinePosition FromValue (int p0)
			{
				if (id_fromValue_I == IntPtr.Zero)
					id_fromValue_I = JNIEnv.GetStaticMethodID (class_ref, "fromValue", "(I)Lcom/viewpagerindicator/TitlePageIndicator$LinePosition;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator.LinePosition> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromValue_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator.LinePosition']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/viewpagerindicator/TitlePageIndicator$LinePosition;", "")]
			public static unsafe global::Com.Viewpagerindicator.TitlePageIndicator.LinePosition ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/viewpagerindicator/TitlePageIndicator$LinePosition;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Viewpagerindicator.TitlePageIndicator.LinePosition __ret = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator.LinePosition> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator.LinePosition']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/viewpagerindicator/TitlePageIndicator$LinePosition;", "")]
			public static unsafe global::Com.Viewpagerindicator.TitlePageIndicator.LinePosition[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/viewpagerindicator/TitlePageIndicator$LinePosition;");
				try {
					return (global::Com.Viewpagerindicator.TitlePageIndicator.LinePosition[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Viewpagerindicator.TitlePageIndicator.LinePosition));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.viewpagerindicator']/interface[@name='TitlePageIndicator.OnCenterItemClickListener']"
		[Register ("com/viewpagerindicator/TitlePageIndicator$OnCenterItemClickListener", "", "Com.Viewpagerindicator.TitlePageIndicator/IOnCenterItemClickListenerInvoker")]
		public partial interface IOnCenterItemClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/interface[@name='TitlePageIndicator.OnCenterItemClickListener']/method[@name='onCenterItemClick' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onCenterItemClick", "(I)V", "GetOnCenterItemClick_IHandler:Com.Viewpagerindicator.TitlePageIndicator/IOnCenterItemClickListenerInvoker, ViewPagerIndicator-Binding-Droid")]
			void OnCenterItemClick (int p0);

		}

		[global::Android.Runtime.Register ("com/viewpagerindicator/TitlePageIndicator$OnCenterItemClickListener", DoNotGenerateAcw=true)]
		internal class IOnCenterItemClickListenerInvoker : global::Java.Lang.Object, IOnCenterItemClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/viewpagerindicator/TitlePageIndicator$OnCenterItemClickListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnCenterItemClickListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnCenterItemClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnCenterItemClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.viewpagerindicator.TitlePageIndicator.OnCenterItemClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnCenterItemClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCenterItemClick_I;
#pragma warning disable 0169
			static Delegate GetOnCenterItemClick_IHandler ()
			{
				if (cb_onCenterItemClick_I == null)
					cb_onCenterItemClick_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnCenterItemClick_I);
				return cb_onCenterItemClick_I;
			}

			static void n_OnCenterItemClick_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Viewpagerindicator.TitlePageIndicator.IOnCenterItemClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator.IOnCenterItemClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCenterItemClick (p0);
			}
#pragma warning restore 0169

			IntPtr id_onCenterItemClick_I;
			public unsafe void OnCenterItemClick (int p0)
			{
				if (id_onCenterItemClick_I == IntPtr.Zero)
					id_onCenterItemClick_I = JNIEnv.GetMethodID (class_ref, "onCenterItemClick", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCenterItemClick_I, __args);
			}

		}

		public partial class CenterItemClickEventArgs : global::System.EventArgs {

			public CenterItemClickEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/viewpagerindicator/TitlePageIndicator_OnCenterItemClickListenerImplementor")]
		internal sealed partial class IOnCenterItemClickListenerImplementor : global::Java.Lang.Object, IOnCenterItemClickListener {

			object sender;

			public IOnCenterItemClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/viewpagerindicator/TitlePageIndicator_OnCenterItemClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CenterItemClickEventArgs> Handler;
#pragma warning restore 0649

			public void OnCenterItemClick (int p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new CenterItemClickEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnCenterItemClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator.SavedState']"
		[global::Android.Runtime.Register ("com/viewpagerindicator/TitlePageIndicator$SavedState", DoNotGenerateAcw=true)]
		public partial class SavedState : global::Android.Views.View.BaseSavedState {


			static IntPtr CREATOR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator.SavedState']/field[@name='CREATOR']"
			[Register ("CREATOR")]
			public static global::Android.OS.IParcelableCreator Creator {
				get {
					if (CREATOR_jfieldId == IntPtr.Zero)
						CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/viewpagerindicator/TitlePageIndicator$SavedState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SavedState); }
			}

			protected SavedState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_os_Parcelable_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator.SavedState']/constructor[@name='TitlePageIndicator.SavedState' and count(parameter)=1 and parameter[1][@type='android.os.Parcelable']]"
			[Register (".ctor", "(Landroid/os/Parcelable;)V", "")]
			public unsafe SavedState (global::Android.OS.IParcelable p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (SavedState)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/os/Parcelable;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Parcelable;)V", __args);
						return;
					}

					if (id_ctor_Landroid_os_Parcelable_ == IntPtr.Zero)
						id_ctor_Landroid_os_Parcelable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcelable;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcelable_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Parcelable_, __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/viewpagerindicator/TitlePageIndicator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TitlePageIndicator); }
		}

		protected TitlePageIndicator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/constructor[@name='TitlePageIndicator' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe TitlePageIndicator (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (TitlePageIndicator)) {
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

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/constructor[@name='TitlePageIndicator' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe TitlePageIndicator (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (TitlePageIndicator)) {
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

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/constructor[@name='TitlePageIndicator' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe TitlePageIndicator (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (TitlePageIndicator)) {
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

		static Delegate cb_getClipPadding;
#pragma warning disable 0169
		static Delegate GetGetClipPaddingHandler ()
		{
			if (cb_getClipPadding == null)
				cb_getClipPadding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetClipPadding);
			return cb_getClipPadding;
		}

		static float n_GetClipPadding (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ClipPadding;
		}
#pragma warning restore 0169

		static Delegate cb_setClipPadding_F;
#pragma warning disable 0169
		static Delegate GetSetClipPadding_FHandler ()
		{
			if (cb_setClipPadding_F == null)
				cb_setClipPadding_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetClipPadding_F);
			return cb_setClipPadding_F;
		}

		static void n_SetClipPadding_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClipPadding = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClipPadding;
		static IntPtr id_setClipPadding_F;
		public virtual unsafe float ClipPadding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='getClipPadding' and count(parameter)=0]"
			[Register ("getClipPadding", "()F", "GetGetClipPaddingHandler")]
			get {
				if (id_getClipPadding == IntPtr.Zero)
					id_getClipPadding = JNIEnv.GetMethodID (class_ref, "getClipPadding", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getClipPadding);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClipPadding", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='setClipPadding' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setClipPadding", "(F)V", "GetSetClipPadding_FHandler")]
			set {
				if (id_setClipPadding_F == IntPtr.Zero)
					id_setClipPadding_F = JNIEnv.GetMethodID (class_ref, "setClipPadding", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setClipPadding_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClipPadding", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFooterColor;
#pragma warning disable 0169
		static Delegate GetGetFooterColorHandler ()
		{
			if (cb_getFooterColor == null)
				cb_getFooterColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFooterColor);
			return cb_getFooterColor;
		}

		static int n_GetFooterColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FooterColor;
		}
#pragma warning restore 0169

		static Delegate cb_setFooterColor_I;
#pragma warning disable 0169
		static Delegate GetSetFooterColor_IHandler ()
		{
			if (cb_setFooterColor_I == null)
				cb_setFooterColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFooterColor_I);
			return cb_setFooterColor_I;
		}

		static void n_SetFooterColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FooterColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFooterColor;
		static IntPtr id_setFooterColor_I;
		public virtual unsafe int FooterColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='getFooterColor' and count(parameter)=0]"
			[Register ("getFooterColor", "()I", "GetGetFooterColorHandler")]
			get {
				if (id_getFooterColor == IntPtr.Zero)
					id_getFooterColor = JNIEnv.GetMethodID (class_ref, "getFooterColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFooterColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFooterColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='setFooterColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFooterColor", "(I)V", "GetSetFooterColor_IHandler")]
			set {
				if (id_setFooterColor_I == IntPtr.Zero)
					id_setFooterColor_I = JNIEnv.GetMethodID (class_ref, "setFooterColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFooterColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFooterColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFooterIndicatorHeight;
#pragma warning disable 0169
		static Delegate GetGetFooterIndicatorHeightHandler ()
		{
			if (cb_getFooterIndicatorHeight == null)
				cb_getFooterIndicatorHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetFooterIndicatorHeight);
			return cb_getFooterIndicatorHeight;
		}

		static float n_GetFooterIndicatorHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FooterIndicatorHeight;
		}
#pragma warning restore 0169

		static Delegate cb_setFooterIndicatorHeight_F;
#pragma warning disable 0169
		static Delegate GetSetFooterIndicatorHeight_FHandler ()
		{
			if (cb_setFooterIndicatorHeight_F == null)
				cb_setFooterIndicatorHeight_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetFooterIndicatorHeight_F);
			return cb_setFooterIndicatorHeight_F;
		}

		static void n_SetFooterIndicatorHeight_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FooterIndicatorHeight = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFooterIndicatorHeight;
		static IntPtr id_setFooterIndicatorHeight_F;
		public virtual unsafe float FooterIndicatorHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='getFooterIndicatorHeight' and count(parameter)=0]"
			[Register ("getFooterIndicatorHeight", "()F", "GetGetFooterIndicatorHeightHandler")]
			get {
				if (id_getFooterIndicatorHeight == IntPtr.Zero)
					id_getFooterIndicatorHeight = JNIEnv.GetMethodID (class_ref, "getFooterIndicatorHeight", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getFooterIndicatorHeight);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFooterIndicatorHeight", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='setFooterIndicatorHeight' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setFooterIndicatorHeight", "(F)V", "GetSetFooterIndicatorHeight_FHandler")]
			set {
				if (id_setFooterIndicatorHeight_F == IntPtr.Zero)
					id_setFooterIndicatorHeight_F = JNIEnv.GetMethodID (class_ref, "setFooterIndicatorHeight", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFooterIndicatorHeight_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFooterIndicatorHeight", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFooterIndicatorPadding;
#pragma warning disable 0169
		static Delegate GetGetFooterIndicatorPaddingHandler ()
		{
			if (cb_getFooterIndicatorPadding == null)
				cb_getFooterIndicatorPadding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetFooterIndicatorPadding);
			return cb_getFooterIndicatorPadding;
		}

		static float n_GetFooterIndicatorPadding (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FooterIndicatorPadding;
		}
#pragma warning restore 0169

		static Delegate cb_setFooterIndicatorPadding_F;
#pragma warning disable 0169
		static Delegate GetSetFooterIndicatorPadding_FHandler ()
		{
			if (cb_setFooterIndicatorPadding_F == null)
				cb_setFooterIndicatorPadding_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetFooterIndicatorPadding_F);
			return cb_setFooterIndicatorPadding_F;
		}

		static void n_SetFooterIndicatorPadding_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FooterIndicatorPadding = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFooterIndicatorPadding;
		static IntPtr id_setFooterIndicatorPadding_F;
		public virtual unsafe float FooterIndicatorPadding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='getFooterIndicatorPadding' and count(parameter)=0]"
			[Register ("getFooterIndicatorPadding", "()F", "GetGetFooterIndicatorPaddingHandler")]
			get {
				if (id_getFooterIndicatorPadding == IntPtr.Zero)
					id_getFooterIndicatorPadding = JNIEnv.GetMethodID (class_ref, "getFooterIndicatorPadding", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getFooterIndicatorPadding);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFooterIndicatorPadding", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='setFooterIndicatorPadding' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setFooterIndicatorPadding", "(F)V", "GetSetFooterIndicatorPadding_FHandler")]
			set {
				if (id_setFooterIndicatorPadding_F == IntPtr.Zero)
					id_setFooterIndicatorPadding_F = JNIEnv.GetMethodID (class_ref, "setFooterIndicatorPadding", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFooterIndicatorPadding_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFooterIndicatorPadding", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFooterIndicatorStyle;
#pragma warning disable 0169
		static Delegate GetGetFooterIndicatorStyleHandler ()
		{
			if (cb_getFooterIndicatorStyle == null)
				cb_getFooterIndicatorStyle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFooterIndicatorStyle);
			return cb_getFooterIndicatorStyle;
		}

		static IntPtr n_GetFooterIndicatorStyle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FooterIndicatorStyle);
		}
#pragma warning restore 0169

		static Delegate cb_setFooterIndicatorStyle_Lcom_viewpagerindicator_TitlePageIndicator_IndicatorStyle_;
#pragma warning disable 0169
		static Delegate GetSetFooterIndicatorStyle_Lcom_viewpagerindicator_TitlePageIndicator_IndicatorStyle_Handler ()
		{
			if (cb_setFooterIndicatorStyle_Lcom_viewpagerindicator_TitlePageIndicator_IndicatorStyle_ == null)
				cb_setFooterIndicatorStyle_Lcom_viewpagerindicator_TitlePageIndicator_IndicatorStyle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFooterIndicatorStyle_Lcom_viewpagerindicator_TitlePageIndicator_IndicatorStyle_);
			return cb_setFooterIndicatorStyle_Lcom_viewpagerindicator_TitlePageIndicator_IndicatorStyle_;
		}

		static void n_SetFooterIndicatorStyle_Lcom_viewpagerindicator_TitlePageIndicator_IndicatorStyle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Viewpagerindicator.TitlePageIndicator.IndicatorStyle p0 = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator.IndicatorStyle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FooterIndicatorStyle = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFooterIndicatorStyle;
		static IntPtr id_setFooterIndicatorStyle_Lcom_viewpagerindicator_TitlePageIndicator_IndicatorStyle_;
		public virtual unsafe global::Com.Viewpagerindicator.TitlePageIndicator.IndicatorStyle FooterIndicatorStyle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='getFooterIndicatorStyle' and count(parameter)=0]"
			[Register ("getFooterIndicatorStyle", "()Lcom/viewpagerindicator/TitlePageIndicator$IndicatorStyle;", "GetGetFooterIndicatorStyleHandler")]
			get {
				if (id_getFooterIndicatorStyle == IntPtr.Zero)
					id_getFooterIndicatorStyle = JNIEnv.GetMethodID (class_ref, "getFooterIndicatorStyle", "()Lcom/viewpagerindicator/TitlePageIndicator$IndicatorStyle;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator.IndicatorStyle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFooterIndicatorStyle), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator.IndicatorStyle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFooterIndicatorStyle", "()Lcom/viewpagerindicator/TitlePageIndicator$IndicatorStyle;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='setFooterIndicatorStyle' and count(parameter)=1 and parameter[1][@type='com.viewpagerindicator.TitlePageIndicator.IndicatorStyle']]"
			[Register ("setFooterIndicatorStyle", "(Lcom/viewpagerindicator/TitlePageIndicator$IndicatorStyle;)V", "GetSetFooterIndicatorStyle_Lcom_viewpagerindicator_TitlePageIndicator_IndicatorStyle_Handler")]
			set {
				if (id_setFooterIndicatorStyle_Lcom_viewpagerindicator_TitlePageIndicator_IndicatorStyle_ == IntPtr.Zero)
					id_setFooterIndicatorStyle_Lcom_viewpagerindicator_TitlePageIndicator_IndicatorStyle_ = JNIEnv.GetMethodID (class_ref, "setFooterIndicatorStyle", "(Lcom/viewpagerindicator/TitlePageIndicator$IndicatorStyle;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFooterIndicatorStyle_Lcom_viewpagerindicator_TitlePageIndicator_IndicatorStyle_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFooterIndicatorStyle", "(Lcom/viewpagerindicator/TitlePageIndicator$IndicatorStyle;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFooterLineHeight;
#pragma warning disable 0169
		static Delegate GetGetFooterLineHeightHandler ()
		{
			if (cb_getFooterLineHeight == null)
				cb_getFooterLineHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetFooterLineHeight);
			return cb_getFooterLineHeight;
		}

		static float n_GetFooterLineHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FooterLineHeight;
		}
#pragma warning restore 0169

		static Delegate cb_setFooterLineHeight_F;
#pragma warning disable 0169
		static Delegate GetSetFooterLineHeight_FHandler ()
		{
			if (cb_setFooterLineHeight_F == null)
				cb_setFooterLineHeight_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetFooterLineHeight_F);
			return cb_setFooterLineHeight_F;
		}

		static void n_SetFooterLineHeight_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FooterLineHeight = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFooterLineHeight;
		static IntPtr id_setFooterLineHeight_F;
		public virtual unsafe float FooterLineHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='getFooterLineHeight' and count(parameter)=0]"
			[Register ("getFooterLineHeight", "()F", "GetGetFooterLineHeightHandler")]
			get {
				if (id_getFooterLineHeight == IntPtr.Zero)
					id_getFooterLineHeight = JNIEnv.GetMethodID (class_ref, "getFooterLineHeight", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getFooterLineHeight);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFooterLineHeight", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='setFooterLineHeight' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setFooterLineHeight", "(F)V", "GetSetFooterLineHeight_FHandler")]
			set {
				if (id_setFooterLineHeight_F == IntPtr.Zero)
					id_setFooterLineHeight_F = JNIEnv.GetMethodID (class_ref, "setFooterLineHeight", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFooterLineHeight_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFooterLineHeight", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isSelectedBold;
#pragma warning disable 0169
		static Delegate GetIsSelectedBoldHandler ()
		{
			if (cb_isSelectedBold == null)
				cb_isSelectedBold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSelectedBold);
			return cb_isSelectedBold;
		}

		static bool n_IsSelectedBold (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedBold;
		}
#pragma warning restore 0169

		static Delegate cb_setSelectedBold_Z;
#pragma warning disable 0169
		static Delegate GetSetSelectedBold_ZHandler ()
		{
			if (cb_setSelectedBold_Z == null)
				cb_setSelectedBold_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSelectedBold_Z);
			return cb_setSelectedBold_Z;
		}

		static void n_SetSelectedBold_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectedBold = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isSelectedBold;
		static IntPtr id_setSelectedBold_Z;
		public virtual unsafe bool SelectedBold {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='isSelectedBold' and count(parameter)=0]"
			[Register ("isSelectedBold", "()Z", "GetIsSelectedBoldHandler")]
			get {
				if (id_isSelectedBold == IntPtr.Zero)
					id_isSelectedBold = JNIEnv.GetMethodID (class_ref, "isSelectedBold", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSelectedBold);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSelectedBold", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='setSelectedBold' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSelectedBold", "(Z)V", "GetSetSelectedBold_ZHandler")]
			set {
				if (id_setSelectedBold_Z == IntPtr.Zero)
					id_setSelectedBold_Z = JNIEnv.GetMethodID (class_ref, "setSelectedBold", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelectedBold_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectedBold", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedColor;
#pragma warning disable 0169
		static Delegate GetGetSelectedColorHandler ()
		{
			if (cb_getSelectedColor == null)
				cb_getSelectedColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSelectedColor);
			return cb_getSelectedColor;
		}

		static int n_GetSelectedColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedColor;
		}
#pragma warning restore 0169

		static Delegate cb_setSelectedColor_I;
#pragma warning disable 0169
		static Delegate GetSetSelectedColor_IHandler ()
		{
			if (cb_setSelectedColor_I == null)
				cb_setSelectedColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelectedColor_I);
			return cb_setSelectedColor_I;
		}

		static void n_SetSelectedColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectedColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedColor;
		static IntPtr id_setSelectedColor_I;
		public virtual unsafe int SelectedColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='getSelectedColor' and count(parameter)=0]"
			[Register ("getSelectedColor", "()I", "GetGetSelectedColorHandler")]
			get {
				if (id_getSelectedColor == IntPtr.Zero)
					id_getSelectedColor = JNIEnv.GetMethodID (class_ref, "getSelectedColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSelectedColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelectedColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='setSelectedColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSelectedColor", "(I)V", "GetSetSelectedColor_IHandler")]
			set {
				if (id_setSelectedColor_I == IntPtr.Zero)
					id_setSelectedColor_I = JNIEnv.GetMethodID (class_ref, "setSelectedColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelectedColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectedColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTextColor;
#pragma warning disable 0169
		static Delegate GetGetTextColorHandler ()
		{
			if (cb_getTextColor == null)
				cb_getTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTextColor);
			return cb_getTextColor;
		}

		static int n_GetTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextColor;
		}
#pragma warning restore 0169

		static Delegate cb_setTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetTextColor_IHandler ()
		{
			if (cb_setTextColor_I == null)
				cb_setTextColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTextColor_I);
			return cb_setTextColor_I;
		}

		static void n_SetTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TextColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTextColor;
		static IntPtr id_setTextColor_I;
		public virtual unsafe int TextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='getTextColor' and count(parameter)=0]"
			[Register ("getTextColor", "()I", "GetGetTextColorHandler")]
			get {
				if (id_getTextColor == IntPtr.Zero)
					id_getTextColor = JNIEnv.GetMethodID (class_ref, "getTextColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTextColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='setTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTextColor", "(I)V", "GetSetTextColor_IHandler")]
			set {
				if (id_setTextColor_I == IntPtr.Zero)
					id_setTextColor_I = JNIEnv.GetMethodID (class_ref, "setTextColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTextColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTextColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTextSize;
#pragma warning disable 0169
		static Delegate GetGetTextSizeHandler ()
		{
			if (cb_getTextSize == null)
				cb_getTextSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetTextSize);
			return cb_getTextSize;
		}

		static float n_GetTextSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextSize;
		}
#pragma warning restore 0169

		static Delegate cb_setTextSize_F;
#pragma warning disable 0169
		static Delegate GetSetTextSize_FHandler ()
		{
			if (cb_setTextSize_F == null)
				cb_setTextSize_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetTextSize_F);
			return cb_setTextSize_F;
		}

		static void n_SetTextSize_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TextSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTextSize;
		static IntPtr id_setTextSize_F;
		public virtual unsafe float TextSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='getTextSize' and count(parameter)=0]"
			[Register ("getTextSize", "()F", "GetGetTextSizeHandler")]
			get {
				if (id_getTextSize == IntPtr.Zero)
					id_getTextSize = JNIEnv.GetMethodID (class_ref, "getTextSize", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getTextSize);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextSize", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='setTextSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setTextSize", "(F)V", "GetSetTextSize_FHandler")]
			set {
				if (id_setTextSize_F == IntPtr.Zero)
					id_setTextSize_F = JNIEnv.GetMethodID (class_ref, "setTextSize", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTextSize_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTextSize", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTitlePadding;
#pragma warning disable 0169
		static Delegate GetGetTitlePaddingHandler ()
		{
			if (cb_getTitlePadding == null)
				cb_getTitlePadding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetTitlePadding);
			return cb_getTitlePadding;
		}

		static float n_GetTitlePadding (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TitlePadding;
		}
#pragma warning restore 0169

		static Delegate cb_setTitlePadding_F;
#pragma warning disable 0169
		static Delegate GetSetTitlePadding_FHandler ()
		{
			if (cb_setTitlePadding_F == null)
				cb_setTitlePadding_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetTitlePadding_F);
			return cb_setTitlePadding_F;
		}

		static void n_SetTitlePadding_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TitlePadding = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTitlePadding;
		static IntPtr id_setTitlePadding_F;
		public virtual unsafe float TitlePadding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='getTitlePadding' and count(parameter)=0]"
			[Register ("getTitlePadding", "()F", "GetGetTitlePaddingHandler")]
			get {
				if (id_getTitlePadding == IntPtr.Zero)
					id_getTitlePadding = JNIEnv.GetMethodID (class_ref, "getTitlePadding", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getTitlePadding);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitlePadding", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='setTitlePadding' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setTitlePadding", "(F)V", "GetSetTitlePadding_FHandler")]
			set {
				if (id_setTitlePadding_F == IntPtr.Zero)
					id_setTitlePadding_F = JNIEnv.GetMethodID (class_ref, "setTitlePadding", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTitlePadding_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitlePadding", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTopPadding;
#pragma warning disable 0169
		static Delegate GetGetTopPaddingHandler ()
		{
			if (cb_getTopPadding == null)
				cb_getTopPadding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetTopPadding);
			return cb_getTopPadding;
		}

		static float n_GetTopPadding (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TopPadding;
		}
#pragma warning restore 0169

		static Delegate cb_setTopPadding_F;
#pragma warning disable 0169
		static Delegate GetSetTopPadding_FHandler ()
		{
			if (cb_setTopPadding_F == null)
				cb_setTopPadding_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetTopPadding_F);
			return cb_setTopPadding_F;
		}

		static void n_SetTopPadding_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TopPadding = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTopPadding;
		static IntPtr id_setTopPadding_F;
		public virtual unsafe float TopPadding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='getTopPadding' and count(parameter)=0]"
			[Register ("getTopPadding", "()F", "GetGetTopPaddingHandler")]
			get {
				if (id_getTopPadding == IntPtr.Zero)
					id_getTopPadding = JNIEnv.GetMethodID (class_ref, "getTopPadding", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getTopPadding);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTopPadding", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='setTopPadding' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setTopPadding", "(F)V", "GetSetTopPadding_FHandler")]
			set {
				if (id_setTopPadding_F == IntPtr.Zero)
					id_setTopPadding_F = JNIEnv.GetMethodID (class_ref, "setTopPadding", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTopPadding_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTopPadding", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTypeface;
#pragma warning disable 0169
		static Delegate GetGetTypefaceHandler ()
		{
			if (cb_getTypeface == null)
				cb_getTypeface = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTypeface);
			return cb_getTypeface;
		}

		static IntPtr n_GetTypeface (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Typeface);
		}
#pragma warning restore 0169

		static Delegate cb_setTypeface_Landroid_graphics_Typeface_;
#pragma warning disable 0169
		static Delegate GetSetTypeface_Landroid_graphics_Typeface_Handler ()
		{
			if (cb_setTypeface_Landroid_graphics_Typeface_ == null)
				cb_setTypeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTypeface_Landroid_graphics_Typeface_);
			return cb_setTypeface_Landroid_graphics_Typeface_;
		}

		static void n_SetTypeface_Landroid_graphics_Typeface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Typeface p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Typeface = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTypeface;
		static IntPtr id_setTypeface_Landroid_graphics_Typeface_;
		public virtual unsafe global::Android.Graphics.Typeface Typeface {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='getTypeface' and count(parameter)=0]"
			[Register ("getTypeface", "()Landroid/graphics/Typeface;", "GetGetTypefaceHandler")]
			get {
				if (id_getTypeface == IntPtr.Zero)
					id_getTypeface = JNIEnv.GetMethodID (class_ref, "getTypeface", "()Landroid/graphics/Typeface;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTypeface), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTypeface", "()Landroid/graphics/Typeface;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='setTypeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
			[Register ("setTypeface", "(Landroid/graphics/Typeface;)V", "GetSetTypeface_Landroid_graphics_Typeface_Handler")]
			set {
				if (id_setTypeface_Landroid_graphics_Typeface_ == IntPtr.Zero)
					id_setTypeface_Landroid_graphics_Typeface_ = JNIEnv.GetMethodID (class_ref, "setTypeface", "(Landroid/graphics/Typeface;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTypeface_Landroid_graphics_Typeface_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTypeface", "(Landroid/graphics/Typeface;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLinePosition;
#pragma warning disable 0169
		static Delegate GetGetLinePositionHandler ()
		{
			if (cb_getLinePosition == null)
				cb_getLinePosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLinePosition);
			return cb_getLinePosition;
		}

		static IntPtr n_GetLinePosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetLinePosition ());
		}
#pragma warning restore 0169

		static IntPtr id_getLinePosition;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='getLinePosition' and count(parameter)=0]"
		[Register ("getLinePosition", "()Lcom/viewpagerindicator/TitlePageIndicator$LinePosition;", "GetGetLinePositionHandler")]
		public virtual unsafe global::Com.Viewpagerindicator.TitlePageIndicator.LinePosition GetLinePosition ()
		{
			if (id_getLinePosition == IntPtr.Zero)
				id_getLinePosition = JNIEnv.GetMethodID (class_ref, "getLinePosition", "()Lcom/viewpagerindicator/TitlePageIndicator$LinePosition;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator.LinePosition> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLinePosition), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator.LinePosition> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLinePosition", "()Lcom/viewpagerindicator/TitlePageIndicator$LinePosition;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_notifyDataSetChanged;
#pragma warning disable 0169
		static Delegate GetNotifyDataSetChangedHandler ()
		{
			if (cb_notifyDataSetChanged == null)
				cb_notifyDataSetChanged = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyDataSetChanged);
			return cb_notifyDataSetChanged;
		}

		static void n_NotifyDataSetChanged (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyDataSetChanged ();
		}
#pragma warning restore 0169

		static IntPtr id_notifyDataSetChanged;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='notifyDataSetChanged' and count(parameter)=0]"
		[Register ("notifyDataSetChanged", "()V", "GetNotifyDataSetChangedHandler")]
		public virtual unsafe void NotifyDataSetChanged ()
		{
			if (id_notifyDataSetChanged == IntPtr.Zero)
				id_notifyDataSetChanged = JNIEnv.GetMethodID (class_ref, "notifyDataSetChanged", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyDataSetChanged);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyDataSetChanged", "()V"));
			} finally {
			}
		}

		static Delegate cb_onPageScrollStateChanged_I;
#pragma warning disable 0169
		static Delegate GetOnPageScrollStateChanged_IHandler ()
		{
			if (cb_onPageScrollStateChanged_I == null)
				cb_onPageScrollStateChanged_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnPageScrollStateChanged_I);
			return cb_onPageScrollStateChanged_I;
		}

		static void n_OnPageScrollStateChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPageScrollStateChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPageScrollStateChanged_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='onPageScrollStateChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onPageScrollStateChanged", "(I)V", "GetOnPageScrollStateChanged_IHandler")]
		public virtual unsafe void OnPageScrollStateChanged (int p0)
		{
			if (id_onPageScrollStateChanged_I == IntPtr.Zero)
				id_onPageScrollStateChanged_I = JNIEnv.GetMethodID (class_ref, "onPageScrollStateChanged", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPageScrollStateChanged_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPageScrollStateChanged", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onPageScrolled_IFI;
#pragma warning disable 0169
		static Delegate GetOnPageScrolled_IFIHandler ()
		{
			if (cb_onPageScrolled_IFI == null)
				cb_onPageScrolled_IFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, float, int>) n_OnPageScrolled_IFI);
			return cb_onPageScrolled_IFI;
		}

		static void n_OnPageScrolled_IFI (IntPtr jnienv, IntPtr native__this, int p0, float p1, int p2)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPageScrolled (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onPageScrolled_IFI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='onPageScrolled' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='int']]"
		[Register ("onPageScrolled", "(IFI)V", "GetOnPageScrolled_IFIHandler")]
		public virtual unsafe void OnPageScrolled (int p0, float p1, int p2)
		{
			if (id_onPageScrolled_IFI == IntPtr.Zero)
				id_onPageScrolled_IFI = JNIEnv.GetMethodID (class_ref, "onPageScrolled", "(IFI)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPageScrolled_IFI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPageScrolled", "(IFI)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onPageSelected_I;
#pragma warning disable 0169
		static Delegate GetOnPageSelected_IHandler ()
		{
			if (cb_onPageSelected_I == null)
				cb_onPageSelected_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnPageSelected_I);
			return cb_onPageSelected_I;
		}

		static void n_OnPageSelected_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPageSelected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPageSelected_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='onPageSelected' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onPageSelected", "(I)V", "GetOnPageSelected_IHandler")]
		public virtual unsafe void OnPageSelected (int p0)
		{
			if (id_onPageSelected_I == IntPtr.Zero)
				id_onPageSelected_I = JNIEnv.GetMethodID (class_ref, "onPageSelected", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPageSelected_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPageSelected", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onRestoreInstanceState_Landroid_os_Parcelable_;
#pragma warning disable 0169
		static Delegate GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler ()
		{
			if (cb_onRestoreInstanceState_Landroid_os_Parcelable_ == null)
				cb_onRestoreInstanceState_Landroid_os_Parcelable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRestoreInstanceState_Landroid_os_Parcelable_);
			return cb_onRestoreInstanceState_Landroid_os_Parcelable_;
		}

		static void n_OnRestoreInstanceState_Landroid_os_Parcelable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IParcelable p0 = (global::Android.OS.IParcelable)global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRestoreInstanceState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onRestoreInstanceState_Landroid_os_Parcelable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='onRestoreInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Parcelable']]"
		[Register ("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", "GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler")]
		public virtual unsafe void OnRestoreInstanceState (global::Android.OS.IParcelable p0)
		{
			if (id_onRestoreInstanceState_Landroid_os_Parcelable_ == IntPtr.Zero)
				id_onRestoreInstanceState_Landroid_os_Parcelable_ = JNIEnv.GetMethodID (class_ref, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRestoreInstanceState_Landroid_os_Parcelable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSaveInstanceState;
#pragma warning disable 0169
		static Delegate GetOnSaveInstanceStateHandler ()
		{
			if (cb_onSaveInstanceState == null)
				cb_onSaveInstanceState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_OnSaveInstanceState);
			return cb_onSaveInstanceState;
		}

		static IntPtr n_OnSaveInstanceState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnSaveInstanceState ());
		}
#pragma warning restore 0169

		static IntPtr id_onSaveInstanceState;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='onSaveInstanceState' and count(parameter)=0]"
		[Register ("onSaveInstanceState", "()Landroid/os/Parcelable;", "GetOnSaveInstanceStateHandler")]
		public virtual unsafe global::Android.OS.IParcelable OnSaveInstanceState ()
		{
			if (id_onSaveInstanceState == IntPtr.Zero)
				id_onSaveInstanceState = JNIEnv.GetMethodID (class_ref, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onSaveInstanceState), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSaveInstanceState", "()Landroid/os/Parcelable;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCurrentItem_I;
#pragma warning disable 0169
		static Delegate GetSetCurrentItem_IHandler ()
		{
			if (cb_setCurrentItem_I == null)
				cb_setCurrentItem_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCurrentItem_I);
			return cb_setCurrentItem_I;
		}

		static void n_SetCurrentItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCurrentItem (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCurrentItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='setCurrentItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCurrentItem", "(I)V", "GetSetCurrentItem_IHandler")]
		public virtual unsafe void SetCurrentItem (int p0)
		{
			if (id_setCurrentItem_I == IntPtr.Zero)
				id_setCurrentItem_I = JNIEnv.GetMethodID (class_ref, "setCurrentItem", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCurrentItem_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurrentItem", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setLinePosition_Lcom_viewpagerindicator_TitlePageIndicator_LinePosition_;
#pragma warning disable 0169
		static Delegate GetSetLinePosition_Lcom_viewpagerindicator_TitlePageIndicator_LinePosition_Handler ()
		{
			if (cb_setLinePosition_Lcom_viewpagerindicator_TitlePageIndicator_LinePosition_ == null)
				cb_setLinePosition_Lcom_viewpagerindicator_TitlePageIndicator_LinePosition_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLinePosition_Lcom_viewpagerindicator_TitlePageIndicator_LinePosition_);
			return cb_setLinePosition_Lcom_viewpagerindicator_TitlePageIndicator_LinePosition_;
		}

		static void n_SetLinePosition_Lcom_viewpagerindicator_TitlePageIndicator_LinePosition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Viewpagerindicator.TitlePageIndicator.LinePosition p0 = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator.LinePosition> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLinePosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLinePosition_Lcom_viewpagerindicator_TitlePageIndicator_LinePosition_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='setLinePosition' and count(parameter)=1 and parameter[1][@type='com.viewpagerindicator.TitlePageIndicator.LinePosition']]"
		[Register ("setLinePosition", "(Lcom/viewpagerindicator/TitlePageIndicator$LinePosition;)V", "GetSetLinePosition_Lcom_viewpagerindicator_TitlePageIndicator_LinePosition_Handler")]
		public virtual unsafe void SetLinePosition (global::Com.Viewpagerindicator.TitlePageIndicator.LinePosition p0)
		{
			if (id_setLinePosition_Lcom_viewpagerindicator_TitlePageIndicator_LinePosition_ == IntPtr.Zero)
				id_setLinePosition_Lcom_viewpagerindicator_TitlePageIndicator_LinePosition_ = JNIEnv.GetMethodID (class_ref, "setLinePosition", "(Lcom/viewpagerindicator/TitlePageIndicator$LinePosition;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLinePosition_Lcom_viewpagerindicator_TitlePageIndicator_LinePosition_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLinePosition", "(Lcom/viewpagerindicator/TitlePageIndicator$LinePosition;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnCenterItemClickListener_Lcom_viewpagerindicator_TitlePageIndicator_OnCenterItemClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnCenterItemClickListener_Lcom_viewpagerindicator_TitlePageIndicator_OnCenterItemClickListener_Handler ()
		{
			if (cb_setOnCenterItemClickListener_Lcom_viewpagerindicator_TitlePageIndicator_OnCenterItemClickListener_ == null)
				cb_setOnCenterItemClickListener_Lcom_viewpagerindicator_TitlePageIndicator_OnCenterItemClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnCenterItemClickListener_Lcom_viewpagerindicator_TitlePageIndicator_OnCenterItemClickListener_);
			return cb_setOnCenterItemClickListener_Lcom_viewpagerindicator_TitlePageIndicator_OnCenterItemClickListener_;
		}

		static void n_SetOnCenterItemClickListener_Lcom_viewpagerindicator_TitlePageIndicator_OnCenterItemClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Viewpagerindicator.TitlePageIndicator.IOnCenterItemClickListener p0 = (global::Com.Viewpagerindicator.TitlePageIndicator.IOnCenterItemClickListener)global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator.IOnCenterItemClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnCenterItemClickListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnCenterItemClickListener_Lcom_viewpagerindicator_TitlePageIndicator_OnCenterItemClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='setOnCenterItemClickListener' and count(parameter)=1 and parameter[1][@type='com.viewpagerindicator.TitlePageIndicator.OnCenterItemClickListener']]"
		[Register ("setOnCenterItemClickListener", "(Lcom/viewpagerindicator/TitlePageIndicator$OnCenterItemClickListener;)V", "GetSetOnCenterItemClickListener_Lcom_viewpagerindicator_TitlePageIndicator_OnCenterItemClickListener_Handler")]
		public virtual unsafe void SetOnCenterItemClickListener (global::Com.Viewpagerindicator.TitlePageIndicator.IOnCenterItemClickListener p0)
		{
			if (id_setOnCenterItemClickListener_Lcom_viewpagerindicator_TitlePageIndicator_OnCenterItemClickListener_ == IntPtr.Zero)
				id_setOnCenterItemClickListener_Lcom_viewpagerindicator_TitlePageIndicator_OnCenterItemClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnCenterItemClickListener", "(Lcom/viewpagerindicator/TitlePageIndicator$OnCenterItemClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnCenterItemClickListener_Lcom_viewpagerindicator_TitlePageIndicator_OnCenterItemClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnCenterItemClickListener", "(Lcom/viewpagerindicator/TitlePageIndicator$OnCenterItemClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_Handler ()
		{
			if (cb_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_ == null)
				cb_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_);
			return cb_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_;
		}

		static void n_SetOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.View.ViewPager.IOnPageChangeListener p0 = (global::Android.Support.V4.View.ViewPager.IOnPageChangeListener)global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.ViewPager.IOnPageChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnPageChangeListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='setOnPageChangeListener' and count(parameter)=1 and parameter[1][@type='android.support.v4.view.ViewPager.OnPageChangeListener']]"
		[Register ("setOnPageChangeListener", "(Landroid/support/v4/view/ViewPager$OnPageChangeListener;)V", "GetSetOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_Handler")]
		public virtual unsafe void SetOnPageChangeListener (global::Android.Support.V4.View.ViewPager.IOnPageChangeListener p0)
		{
			if (id_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_ == IntPtr.Zero)
				id_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_ = JNIEnv.GetMethodID (class_ref, "setOnPageChangeListener", "(Landroid/support/v4/view/ViewPager$OnPageChangeListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnPageChangeListener", "(Landroid/support/v4/view/ViewPager$OnPageChangeListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setViewPager_Landroid_support_v4_view_ViewPager_;
#pragma warning disable 0169
		static Delegate GetSetViewPager_Landroid_support_v4_view_ViewPager_Handler ()
		{
			if (cb_setViewPager_Landroid_support_v4_view_ViewPager_ == null)
				cb_setViewPager_Landroid_support_v4_view_ViewPager_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetViewPager_Landroid_support_v4_view_ViewPager_);
			return cb_setViewPager_Landroid_support_v4_view_ViewPager_;
		}

		static void n_SetViewPager_Landroid_support_v4_view_ViewPager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.View.ViewPager p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.ViewPager> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetViewPager (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setViewPager_Landroid_support_v4_view_ViewPager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='setViewPager' and count(parameter)=1 and parameter[1][@type='android.support.v4.view.ViewPager']]"
		[Register ("setViewPager", "(Landroid/support/v4/view/ViewPager;)V", "GetSetViewPager_Landroid_support_v4_view_ViewPager_Handler")]
		public virtual unsafe void SetViewPager (global::Android.Support.V4.View.ViewPager p0)
		{
			if (id_setViewPager_Landroid_support_v4_view_ViewPager_ == IntPtr.Zero)
				id_setViewPager_Landroid_support_v4_view_ViewPager_ = JNIEnv.GetMethodID (class_ref, "setViewPager", "(Landroid/support/v4/view/ViewPager;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setViewPager_Landroid_support_v4_view_ViewPager_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setViewPager", "(Landroid/support/v4/view/ViewPager;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setViewPager_Landroid_support_v4_view_ViewPager_I;
#pragma warning disable 0169
		static Delegate GetSetViewPager_Landroid_support_v4_view_ViewPager_IHandler ()
		{
			if (cb_setViewPager_Landroid_support_v4_view_ViewPager_I == null)
				cb_setViewPager_Landroid_support_v4_view_ViewPager_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetViewPager_Landroid_support_v4_view_ViewPager_I);
			return cb_setViewPager_Landroid_support_v4_view_ViewPager_I;
		}

		static void n_SetViewPager_Landroid_support_v4_view_ViewPager_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Viewpagerindicator.TitlePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TitlePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.View.ViewPager p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.ViewPager> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetViewPager (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setViewPager_Landroid_support_v4_view_ViewPager_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TitlePageIndicator']/method[@name='setViewPager' and count(parameter)=2 and parameter[1][@type='android.support.v4.view.ViewPager'] and parameter[2][@type='int']]"
		[Register ("setViewPager", "(Landroid/support/v4/view/ViewPager;I)V", "GetSetViewPager_Landroid_support_v4_view_ViewPager_IHandler")]
		public virtual unsafe void SetViewPager (global::Android.Support.V4.View.ViewPager p0, int p1)
		{
			if (id_setViewPager_Landroid_support_v4_view_ViewPager_I == IntPtr.Zero)
				id_setViewPager_Landroid_support_v4_view_ViewPager_I = JNIEnv.GetMethodID (class_ref, "setViewPager", "(Landroid/support/v4/view/ViewPager;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setViewPager_Landroid_support_v4_view_ViewPager_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setViewPager", "(Landroid/support/v4/view/ViewPager;I)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Viewpagerindicator.TitlePageIndicator.IOnCenterItemClickListener"
		public event EventHandler<global::Com.Viewpagerindicator.TitlePageIndicator.CenterItemClickEventArgs> CenterItemClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Viewpagerindicator.TitlePageIndicator.IOnCenterItemClickListener, global::Com.Viewpagerindicator.TitlePageIndicator.IOnCenterItemClickListenerImplementor>(
						ref weak_implementor_SetOnCenterItemClickListener,
						__CreateIOnCenterItemClickListenerImplementor,
						SetOnCenterItemClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Viewpagerindicator.TitlePageIndicator.IOnCenterItemClickListener, global::Com.Viewpagerindicator.TitlePageIndicator.IOnCenterItemClickListenerImplementor>(
						ref weak_implementor_SetOnCenterItemClickListener,
						global::Com.Viewpagerindicator.TitlePageIndicator.IOnCenterItemClickListenerImplementor.__IsEmpty,
						__v => SetOnCenterItemClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnCenterItemClickListener;

		global::Com.Viewpagerindicator.TitlePageIndicator.IOnCenterItemClickListenerImplementor __CreateIOnCenterItemClickListenerImplementor ()
		{
			return new global::Com.Viewpagerindicator.TitlePageIndicator.IOnCenterItemClickListenerImplementor (this);
		}
#endregion
	}
}
