using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Viewpagerindicator {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']"
	[global::Android.Runtime.Register ("com/viewpagerindicator/CirclePageIndicator", DoNotGenerateAcw=true)]
	public partial class CirclePageIndicator : global::Android.Views.View, global::Com.Viewpagerindicator.IPageIndicator {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator.SavedState']"
		[global::Android.Runtime.Register ("com/viewpagerindicator/CirclePageIndicator$SavedState", DoNotGenerateAcw=true)]
		public partial class SavedState : global::Android.Views.View.BaseSavedState {


			static IntPtr CREATOR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator.SavedState']/field[@name='CREATOR']"
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
					return JNIEnv.FindClass ("com/viewpagerindicator/CirclePageIndicator$SavedState", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator.SavedState']/constructor[@name='CirclePageIndicator.SavedState' and count(parameter)=1 and parameter[1][@type='android.os.Parcelable']]"
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
				return JNIEnv.FindClass ("com/viewpagerindicator/CirclePageIndicator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CirclePageIndicator); }
		}

		protected CirclePageIndicator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/constructor[@name='CirclePageIndicator' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe CirclePageIndicator (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (CirclePageIndicator)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/constructor[@name='CirclePageIndicator' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe CirclePageIndicator (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (CirclePageIndicator)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/constructor[@name='CirclePageIndicator' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe CirclePageIndicator (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (CirclePageIndicator)) {
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

		static Delegate cb_isCentered;
#pragma warning disable 0169
		static Delegate GetIsCenteredHandler ()
		{
			if (cb_isCentered == null)
				cb_isCentered = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCentered);
			return cb_isCentered;
		}

		static bool n_IsCentered (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.CirclePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.CirclePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Centered;
		}
#pragma warning restore 0169

		static Delegate cb_setCentered_Z;
#pragma warning disable 0169
		static Delegate GetSetCentered_ZHandler ()
		{
			if (cb_setCentered_Z == null)
				cb_setCentered_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCentered_Z);
			return cb_setCentered_Z;
		}

		static void n_SetCentered_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Viewpagerindicator.CirclePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.CirclePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Centered = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isCentered;
		static IntPtr id_setCentered_Z;
		public virtual unsafe bool Centered {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/method[@name='isCentered' and count(parameter)=0]"
			[Register ("isCentered", "()Z", "GetIsCenteredHandler")]
			get {
				if (id_isCentered == IntPtr.Zero)
					id_isCentered = JNIEnv.GetMethodID (class_ref, "isCentered", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCentered);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCentered", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/method[@name='setCentered' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCentered", "(Z)V", "GetSetCentered_ZHandler")]
			set {
				if (id_setCentered_Z == IntPtr.Zero)
					id_setCentered_Z = JNIEnv.GetMethodID (class_ref, "setCentered", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCentered_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCentered", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFillColor;
#pragma warning disable 0169
		static Delegate GetGetFillColorHandler ()
		{
			if (cb_getFillColor == null)
				cb_getFillColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFillColor);
			return cb_getFillColor;
		}

		static int n_GetFillColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.CirclePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.CirclePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FillColor;
		}
#pragma warning restore 0169

		static Delegate cb_setFillColor_I;
#pragma warning disable 0169
		static Delegate GetSetFillColor_IHandler ()
		{
			if (cb_setFillColor_I == null)
				cb_setFillColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFillColor_I);
			return cb_setFillColor_I;
		}

		static void n_SetFillColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Viewpagerindicator.CirclePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.CirclePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FillColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFillColor;
		static IntPtr id_setFillColor_I;
		public virtual unsafe int FillColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/method[@name='getFillColor' and count(parameter)=0]"
			[Register ("getFillColor", "()I", "GetGetFillColorHandler")]
			get {
				if (id_getFillColor == IntPtr.Zero)
					id_getFillColor = JNIEnv.GetMethodID (class_ref, "getFillColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFillColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFillColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/method[@name='setFillColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFillColor", "(I)V", "GetSetFillColor_IHandler")]
			set {
				if (id_setFillColor_I == IntPtr.Zero)
					id_setFillColor_I = JNIEnv.GetMethodID (class_ref, "setFillColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFillColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFillColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOrientation;
#pragma warning disable 0169
		static Delegate GetGetOrientationHandler ()
		{
			if (cb_getOrientation == null)
				cb_getOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOrientation);
			return cb_getOrientation;
		}

		static int n_GetOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.CirclePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.CirclePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Orientation;
		}
#pragma warning restore 0169

		static Delegate cb_setOrientation_I;
#pragma warning disable 0169
		static Delegate GetSetOrientation_IHandler ()
		{
			if (cb_setOrientation_I == null)
				cb_setOrientation_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetOrientation_I);
			return cb_setOrientation_I;
		}

		static void n_SetOrientation_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Viewpagerindicator.CirclePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.CirclePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Orientation = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOrientation;
		static IntPtr id_setOrientation_I;
		public virtual unsafe int Orientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/method[@name='getOrientation' and count(parameter)=0]"
			[Register ("getOrientation", "()I", "GetGetOrientationHandler")]
			get {
				if (id_getOrientation == IntPtr.Zero)
					id_getOrientation = JNIEnv.GetMethodID (class_ref, "getOrientation", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getOrientation);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrientation", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/method[@name='setOrientation' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setOrientation", "(I)V", "GetSetOrientation_IHandler")]
			set {
				if (id_setOrientation_I == IntPtr.Zero)
					id_setOrientation_I = JNIEnv.GetMethodID (class_ref, "setOrientation", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOrientation_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOrientation", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPageColor;
#pragma warning disable 0169
		static Delegate GetGetPageColorHandler ()
		{
			if (cb_getPageColor == null)
				cb_getPageColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPageColor);
			return cb_getPageColor;
		}

		static int n_GetPageColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.CirclePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.CirclePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PageColor;
		}
#pragma warning restore 0169

		static Delegate cb_setPageColor_I;
#pragma warning disable 0169
		static Delegate GetSetPageColor_IHandler ()
		{
			if (cb_setPageColor_I == null)
				cb_setPageColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPageColor_I);
			return cb_setPageColor_I;
		}

		static void n_SetPageColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Viewpagerindicator.CirclePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.CirclePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PageColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPageColor;
		static IntPtr id_setPageColor_I;
		public virtual unsafe int PageColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/method[@name='getPageColor' and count(parameter)=0]"
			[Register ("getPageColor", "()I", "GetGetPageColorHandler")]
			get {
				if (id_getPageColor == IntPtr.Zero)
					id_getPageColor = JNIEnv.GetMethodID (class_ref, "getPageColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPageColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPageColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/method[@name='setPageColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPageColor", "(I)V", "GetSetPageColor_IHandler")]
			set {
				if (id_setPageColor_I == IntPtr.Zero)
					id_setPageColor_I = JNIEnv.GetMethodID (class_ref, "setPageColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPageColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPageColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRadius;
#pragma warning disable 0169
		static Delegate GetGetRadiusHandler ()
		{
			if (cb_getRadius == null)
				cb_getRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetRadius);
			return cb_getRadius;
		}

		static float n_GetRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.CirclePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.CirclePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Radius;
		}
#pragma warning restore 0169

		static Delegate cb_setRadius_F;
#pragma warning disable 0169
		static Delegate GetSetRadius_FHandler ()
		{
			if (cb_setRadius_F == null)
				cb_setRadius_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetRadius_F);
			return cb_setRadius_F;
		}

		static void n_SetRadius_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Viewpagerindicator.CirclePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.CirclePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Radius = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRadius;
		static IntPtr id_setRadius_F;
		public virtual unsafe float Radius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/method[@name='getRadius' and count(parameter)=0]"
			[Register ("getRadius", "()F", "GetGetRadiusHandler")]
			get {
				if (id_getRadius == IntPtr.Zero)
					id_getRadius = JNIEnv.GetMethodID (class_ref, "getRadius", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getRadius);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRadius", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/method[@name='setRadius' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setRadius", "(F)V", "GetSetRadius_FHandler")]
			set {
				if (id_setRadius_F == IntPtr.Zero)
					id_setRadius_F = JNIEnv.GetMethodID (class_ref, "setRadius", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRadius_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRadius", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isSnap;
#pragma warning disable 0169
		static Delegate GetIsSnapHandler ()
		{
			if (cb_isSnap == null)
				cb_isSnap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSnap);
			return cb_isSnap;
		}

		static bool n_IsSnap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.CirclePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.CirclePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Snap;
		}
#pragma warning restore 0169

		static Delegate cb_setSnap_Z;
#pragma warning disable 0169
		static Delegate GetSetSnap_ZHandler ()
		{
			if (cb_setSnap_Z == null)
				cb_setSnap_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSnap_Z);
			return cb_setSnap_Z;
		}

		static void n_SetSnap_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Viewpagerindicator.CirclePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.CirclePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Snap = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isSnap;
		static IntPtr id_setSnap_Z;
		public virtual unsafe bool Snap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/method[@name='isSnap' and count(parameter)=0]"
			[Register ("isSnap", "()Z", "GetIsSnapHandler")]
			get {
				if (id_isSnap == IntPtr.Zero)
					id_isSnap = JNIEnv.GetMethodID (class_ref, "isSnap", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSnap);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSnap", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/method[@name='setSnap' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSnap", "(Z)V", "GetSetSnap_ZHandler")]
			set {
				if (id_setSnap_Z == IntPtr.Zero)
					id_setSnap_Z = JNIEnv.GetMethodID (class_ref, "setSnap", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSnap_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSnap", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStrokeColor;
#pragma warning disable 0169
		static Delegate GetGetStrokeColorHandler ()
		{
			if (cb_getStrokeColor == null)
				cb_getStrokeColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStrokeColor);
			return cb_getStrokeColor;
		}

		static int n_GetStrokeColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.CirclePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.CirclePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StrokeColor;
		}
#pragma warning restore 0169

		static Delegate cb_setStrokeColor_I;
#pragma warning disable 0169
		static Delegate GetSetStrokeColor_IHandler ()
		{
			if (cb_setStrokeColor_I == null)
				cb_setStrokeColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStrokeColor_I);
			return cb_setStrokeColor_I;
		}

		static void n_SetStrokeColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Viewpagerindicator.CirclePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.CirclePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StrokeColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStrokeColor;
		static IntPtr id_setStrokeColor_I;
		public virtual unsafe int StrokeColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/method[@name='getStrokeColor' and count(parameter)=0]"
			[Register ("getStrokeColor", "()I", "GetGetStrokeColorHandler")]
			get {
				if (id_getStrokeColor == IntPtr.Zero)
					id_getStrokeColor = JNIEnv.GetMethodID (class_ref, "getStrokeColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getStrokeColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStrokeColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/method[@name='setStrokeColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStrokeColor", "(I)V", "GetSetStrokeColor_IHandler")]
			set {
				if (id_setStrokeColor_I == IntPtr.Zero)
					id_setStrokeColor_I = JNIEnv.GetMethodID (class_ref, "setStrokeColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStrokeColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStrokeColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStrokeWidth;
#pragma warning disable 0169
		static Delegate GetGetStrokeWidthHandler ()
		{
			if (cb_getStrokeWidth == null)
				cb_getStrokeWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetStrokeWidth);
			return cb_getStrokeWidth;
		}

		static float n_GetStrokeWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.CirclePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.CirclePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StrokeWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setStrokeWidth_F;
#pragma warning disable 0169
		static Delegate GetSetStrokeWidth_FHandler ()
		{
			if (cb_setStrokeWidth_F == null)
				cb_setStrokeWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetStrokeWidth_F);
			return cb_setStrokeWidth_F;
		}

		static void n_SetStrokeWidth_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Viewpagerindicator.CirclePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.CirclePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StrokeWidth = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStrokeWidth;
		static IntPtr id_setStrokeWidth_F;
		public virtual unsafe float StrokeWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/method[@name='getStrokeWidth' and count(parameter)=0]"
			[Register ("getStrokeWidth", "()F", "GetGetStrokeWidthHandler")]
			get {
				if (id_getStrokeWidth == IntPtr.Zero)
					id_getStrokeWidth = JNIEnv.GetMethodID (class_ref, "getStrokeWidth", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getStrokeWidth);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStrokeWidth", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/method[@name='setStrokeWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setStrokeWidth", "(F)V", "GetSetStrokeWidth_FHandler")]
			set {
				if (id_setStrokeWidth_F == IntPtr.Zero)
					id_setStrokeWidth_F = JNIEnv.GetMethodID (class_ref, "setStrokeWidth", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStrokeWidth_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStrokeWidth", "(F)V"), __args);
				} finally {
				}
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
			global::Com.Viewpagerindicator.CirclePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.CirclePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyDataSetChanged ();
		}
#pragma warning restore 0169

		static IntPtr id_notifyDataSetChanged;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/method[@name='notifyDataSetChanged' and count(parameter)=0]"
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
			global::Com.Viewpagerindicator.CirclePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.CirclePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPageScrollStateChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPageScrollStateChanged_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/method[@name='onPageScrollStateChanged' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Viewpagerindicator.CirclePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.CirclePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPageScrolled (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onPageScrolled_IFI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/method[@name='onPageScrolled' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='int']]"
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
			global::Com.Viewpagerindicator.CirclePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.CirclePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPageSelected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPageSelected_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/method[@name='onPageSelected' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Viewpagerindicator.CirclePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.CirclePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IParcelable p0 = (global::Android.OS.IParcelable)global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRestoreInstanceState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onRestoreInstanceState_Landroid_os_Parcelable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/method[@name='onRestoreInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Parcelable']]"
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
			global::Com.Viewpagerindicator.CirclePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.CirclePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnSaveInstanceState ());
		}
#pragma warning restore 0169

		static IntPtr id_onSaveInstanceState;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/method[@name='onSaveInstanceState' and count(parameter)=0]"
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
			global::Com.Viewpagerindicator.CirclePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.CirclePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCurrentItem (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCurrentItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/method[@name='setCurrentItem' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Viewpagerindicator.CirclePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.CirclePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.View.ViewPager.IOnPageChangeListener p0 = (global::Android.Support.V4.View.ViewPager.IOnPageChangeListener)global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.ViewPager.IOnPageChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnPageChangeListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/method[@name='setOnPageChangeListener' and count(parameter)=1 and parameter[1][@type='android.support.v4.view.ViewPager.OnPageChangeListener']]"
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
			global::Com.Viewpagerindicator.CirclePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.CirclePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.View.ViewPager p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.ViewPager> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetViewPager (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setViewPager_Landroid_support_v4_view_ViewPager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/method[@name='setViewPager' and count(parameter)=1 and parameter[1][@type='android.support.v4.view.ViewPager']]"
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
			global::Com.Viewpagerindicator.CirclePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.CirclePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.View.ViewPager p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.ViewPager> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetViewPager (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setViewPager_Landroid_support_v4_view_ViewPager_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='CirclePageIndicator']/method[@name='setViewPager' and count(parameter)=2 and parameter[1][@type='android.support.v4.view.ViewPager'] and parameter[2][@type='int']]"
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

	}
}
