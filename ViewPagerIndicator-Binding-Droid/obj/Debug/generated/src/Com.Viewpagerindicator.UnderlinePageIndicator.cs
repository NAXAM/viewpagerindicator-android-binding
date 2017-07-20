using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Viewpagerindicator {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='UnderlinePageIndicator']"
	[global::Android.Runtime.Register ("com/viewpagerindicator/UnderlinePageIndicator", DoNotGenerateAcw=true)]
	public partial class UnderlinePageIndicator : global::Android.Views.View, global::Com.Viewpagerindicator.IPageIndicator {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='UnderlinePageIndicator.SavedState']"
		[global::Android.Runtime.Register ("com/viewpagerindicator/UnderlinePageIndicator$SavedState", DoNotGenerateAcw=true)]
		public partial class SavedState : global::Android.Views.View.BaseSavedState {


			static IntPtr CREATOR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='UnderlinePageIndicator.SavedState']/field[@name='CREATOR']"
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
					return JNIEnv.FindClass ("com/viewpagerindicator/UnderlinePageIndicator$SavedState", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='UnderlinePageIndicator.SavedState']/constructor[@name='UnderlinePageIndicator.SavedState' and count(parameter)=1 and parameter[1][@type='android.os.Parcelable']]"
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
				return JNIEnv.FindClass ("com/viewpagerindicator/UnderlinePageIndicator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UnderlinePageIndicator); }
		}

		protected UnderlinePageIndicator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='UnderlinePageIndicator']/constructor[@name='UnderlinePageIndicator' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe UnderlinePageIndicator (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (UnderlinePageIndicator)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='UnderlinePageIndicator']/constructor[@name='UnderlinePageIndicator' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe UnderlinePageIndicator (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (UnderlinePageIndicator)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='UnderlinePageIndicator']/constructor[@name='UnderlinePageIndicator' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe UnderlinePageIndicator (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (UnderlinePageIndicator)) {
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

		static Delegate cb_getFadeDelay;
#pragma warning disable 0169
		static Delegate GetGetFadeDelayHandler ()
		{
			if (cb_getFadeDelay == null)
				cb_getFadeDelay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFadeDelay);
			return cb_getFadeDelay;
		}

		static int n_GetFadeDelay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.UnderlinePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.UnderlinePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FadeDelay;
		}
#pragma warning restore 0169

		static Delegate cb_setFadeDelay_I;
#pragma warning disable 0169
		static Delegate GetSetFadeDelay_IHandler ()
		{
			if (cb_setFadeDelay_I == null)
				cb_setFadeDelay_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFadeDelay_I);
			return cb_setFadeDelay_I;
		}

		static void n_SetFadeDelay_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Viewpagerindicator.UnderlinePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.UnderlinePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FadeDelay = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFadeDelay;
		static IntPtr id_setFadeDelay_I;
		public virtual unsafe int FadeDelay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='UnderlinePageIndicator']/method[@name='getFadeDelay' and count(parameter)=0]"
			[Register ("getFadeDelay", "()I", "GetGetFadeDelayHandler")]
			get {
				if (id_getFadeDelay == IntPtr.Zero)
					id_getFadeDelay = JNIEnv.GetMethodID (class_ref, "getFadeDelay", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFadeDelay);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFadeDelay", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='UnderlinePageIndicator']/method[@name='setFadeDelay' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFadeDelay", "(I)V", "GetSetFadeDelay_IHandler")]
			set {
				if (id_setFadeDelay_I == IntPtr.Zero)
					id_setFadeDelay_I = JNIEnv.GetMethodID (class_ref, "setFadeDelay", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFadeDelay_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFadeDelay", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFadeLength;
#pragma warning disable 0169
		static Delegate GetGetFadeLengthHandler ()
		{
			if (cb_getFadeLength == null)
				cb_getFadeLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFadeLength);
			return cb_getFadeLength;
		}

		static int n_GetFadeLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.UnderlinePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.UnderlinePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FadeLength;
		}
#pragma warning restore 0169

		static Delegate cb_setFadeLength_I;
#pragma warning disable 0169
		static Delegate GetSetFadeLength_IHandler ()
		{
			if (cb_setFadeLength_I == null)
				cb_setFadeLength_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFadeLength_I);
			return cb_setFadeLength_I;
		}

		static void n_SetFadeLength_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Viewpagerindicator.UnderlinePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.UnderlinePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FadeLength = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFadeLength;
		static IntPtr id_setFadeLength_I;
		public virtual unsafe int FadeLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='UnderlinePageIndicator']/method[@name='getFadeLength' and count(parameter)=0]"
			[Register ("getFadeLength", "()I", "GetGetFadeLengthHandler")]
			get {
				if (id_getFadeLength == IntPtr.Zero)
					id_getFadeLength = JNIEnv.GetMethodID (class_ref, "getFadeLength", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFadeLength);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFadeLength", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='UnderlinePageIndicator']/method[@name='setFadeLength' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFadeLength", "(I)V", "GetSetFadeLength_IHandler")]
			set {
				if (id_setFadeLength_I == IntPtr.Zero)
					id_setFadeLength_I = JNIEnv.GetMethodID (class_ref, "setFadeLength", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFadeLength_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFadeLength", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFades;
#pragma warning disable 0169
		static Delegate GetGetFadesHandler ()
		{
			if (cb_getFades == null)
				cb_getFades = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetFades);
			return cb_getFades;
		}

		static bool n_GetFades (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.UnderlinePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.UnderlinePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Fades;
		}
#pragma warning restore 0169

		static Delegate cb_setFades_Z;
#pragma warning disable 0169
		static Delegate GetSetFades_ZHandler ()
		{
			if (cb_setFades_Z == null)
				cb_setFades_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFades_Z);
			return cb_setFades_Z;
		}

		static void n_SetFades_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Viewpagerindicator.UnderlinePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.UnderlinePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Fades = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFades;
		static IntPtr id_setFades_Z;
		public virtual unsafe bool Fades {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='UnderlinePageIndicator']/method[@name='getFades' and count(parameter)=0]"
			[Register ("getFades", "()Z", "GetGetFadesHandler")]
			get {
				if (id_getFades == IntPtr.Zero)
					id_getFades = JNIEnv.GetMethodID (class_ref, "getFades", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getFades);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFades", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='UnderlinePageIndicator']/method[@name='setFades' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFades", "(Z)V", "GetSetFades_ZHandler")]
			set {
				if (id_setFades_Z == IntPtr.Zero)
					id_setFades_Z = JNIEnv.GetMethodID (class_ref, "setFades", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFades_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFades", "(Z)V"), __args);
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
			global::Com.Viewpagerindicator.UnderlinePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.UnderlinePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Viewpagerindicator.UnderlinePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.UnderlinePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectedColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedColor;
		static IntPtr id_setSelectedColor_I;
		public virtual unsafe int SelectedColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='UnderlinePageIndicator']/method[@name='getSelectedColor' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='UnderlinePageIndicator']/method[@name='setSelectedColor' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Viewpagerindicator.UnderlinePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.UnderlinePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyDataSetChanged ();
		}
#pragma warning restore 0169

		static IntPtr id_notifyDataSetChanged;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='UnderlinePageIndicator']/method[@name='notifyDataSetChanged' and count(parameter)=0]"
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
			global::Com.Viewpagerindicator.UnderlinePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.UnderlinePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPageScrollStateChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPageScrollStateChanged_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='UnderlinePageIndicator']/method[@name='onPageScrollStateChanged' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Viewpagerindicator.UnderlinePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.UnderlinePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPageScrolled (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onPageScrolled_IFI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='UnderlinePageIndicator']/method[@name='onPageScrolled' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='int']]"
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
			global::Com.Viewpagerindicator.UnderlinePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.UnderlinePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPageSelected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPageSelected_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='UnderlinePageIndicator']/method[@name='onPageSelected' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Viewpagerindicator.UnderlinePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.UnderlinePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IParcelable p0 = (global::Android.OS.IParcelable)global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRestoreInstanceState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onRestoreInstanceState_Landroid_os_Parcelable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='UnderlinePageIndicator']/method[@name='onRestoreInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Parcelable']]"
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
			global::Com.Viewpagerindicator.UnderlinePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.UnderlinePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnSaveInstanceState ());
		}
#pragma warning restore 0169

		static IntPtr id_onSaveInstanceState;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='UnderlinePageIndicator']/method[@name='onSaveInstanceState' and count(parameter)=0]"
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
			global::Com.Viewpagerindicator.UnderlinePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.UnderlinePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCurrentItem (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCurrentItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='UnderlinePageIndicator']/method[@name='setCurrentItem' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Viewpagerindicator.UnderlinePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.UnderlinePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.View.ViewPager.IOnPageChangeListener p0 = (global::Android.Support.V4.View.ViewPager.IOnPageChangeListener)global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.ViewPager.IOnPageChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnPageChangeListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='UnderlinePageIndicator']/method[@name='setOnPageChangeListener' and count(parameter)=1 and parameter[1][@type='android.support.v4.view.ViewPager.OnPageChangeListener']]"
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
			global::Com.Viewpagerindicator.UnderlinePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.UnderlinePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.View.ViewPager p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.ViewPager> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetViewPager (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setViewPager_Landroid_support_v4_view_ViewPager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='UnderlinePageIndicator']/method[@name='setViewPager' and count(parameter)=1 and parameter[1][@type='android.support.v4.view.ViewPager']]"
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
			global::Com.Viewpagerindicator.UnderlinePageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.UnderlinePageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.View.ViewPager p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.ViewPager> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetViewPager (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setViewPager_Landroid_support_v4_view_ViewPager_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='UnderlinePageIndicator']/method[@name='setViewPager' and count(parameter)=2 and parameter[1][@type='android.support.v4.view.ViewPager'] and parameter[2][@type='int']]"
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
