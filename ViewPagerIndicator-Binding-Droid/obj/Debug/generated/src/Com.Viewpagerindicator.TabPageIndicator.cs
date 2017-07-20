using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Viewpagerindicator {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TabPageIndicator']"
	[global::Android.Runtime.Register ("com/viewpagerindicator/TabPageIndicator", DoNotGenerateAcw=true)]
	public partial class TabPageIndicator : global::Android.Widget.HorizontalScrollView, global::Com.Viewpagerindicator.IPageIndicator {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.viewpagerindicator']/interface[@name='TabPageIndicator.OnTabReselectedListener']"
		[Register ("com/viewpagerindicator/TabPageIndicator$OnTabReselectedListener", "", "Com.Viewpagerindicator.TabPageIndicator/IOnTabReselectedListenerInvoker")]
		public partial interface IOnTabReselectedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/interface[@name='TabPageIndicator.OnTabReselectedListener']/method[@name='onTabReselected' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onTabReselected", "(I)V", "GetOnTabReselected_IHandler:Com.Viewpagerindicator.TabPageIndicator/IOnTabReselectedListenerInvoker, ViewPagerIndicator-Binding-Droid")]
			void OnTabReselected (int p0);

		}

		[global::Android.Runtime.Register ("com/viewpagerindicator/TabPageIndicator$OnTabReselectedListener", DoNotGenerateAcw=true)]
		internal class IOnTabReselectedListenerInvoker : global::Java.Lang.Object, IOnTabReselectedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/viewpagerindicator/TabPageIndicator$OnTabReselectedListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnTabReselectedListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnTabReselectedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnTabReselectedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.viewpagerindicator.TabPageIndicator.OnTabReselectedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnTabReselectedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onTabReselected_I;
#pragma warning disable 0169
			static Delegate GetOnTabReselected_IHandler ()
			{
				if (cb_onTabReselected_I == null)
					cb_onTabReselected_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnTabReselected_I);
				return cb_onTabReselected_I;
			}

			static void n_OnTabReselected_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Viewpagerindicator.TabPageIndicator.IOnTabReselectedListener __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TabPageIndicator.IOnTabReselectedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnTabReselected (p0);
			}
#pragma warning restore 0169

			IntPtr id_onTabReselected_I;
			public unsafe void OnTabReselected (int p0)
			{
				if (id_onTabReselected_I == IntPtr.Zero)
					id_onTabReselected_I = JNIEnv.GetMethodID (class_ref, "onTabReselected", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTabReselected_I, __args);
			}

		}

		public partial class TabReselectedEventArgs : global::System.EventArgs {

			public TabReselectedEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/viewpagerindicator/TabPageIndicator_OnTabReselectedListenerImplementor")]
		internal sealed partial class IOnTabReselectedListenerImplementor : global::Java.Lang.Object, IOnTabReselectedListener {

			object sender;

			public IOnTabReselectedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/viewpagerindicator/TabPageIndicator_OnTabReselectedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<TabReselectedEventArgs> Handler;
#pragma warning restore 0649

			public void OnTabReselected (int p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new TabReselectedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnTabReselectedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TabPageIndicator.TabView']"
		[global::Android.Runtime.Register ("com/viewpagerindicator/TabPageIndicator$TabView", DoNotGenerateAcw=true)]
		public partial class TabView : global::Android.Widget.TextView {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/viewpagerindicator/TabPageIndicator$TabView", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TabView); }
			}

			protected TabView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_viewpagerindicator_TabPageIndicator_Landroid_content_Context_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TabPageIndicator.TabView']/constructor[@name='TabPageIndicator.TabView' and count(parameter)=2 and parameter[1][@type='com.viewpagerindicator.TabPageIndicator'] and parameter[2][@type='android.content.Context']]"
			[Register (".ctor", "(Lcom/viewpagerindicator/TabPageIndicator;Landroid/content/Context;)V", "")]
			public unsafe TabView (global::Com.Viewpagerindicator.TabPageIndicator __self, global::Android.Content.Context p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (((object) this).GetType () != typeof (TabView)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;)V", __args);
						return;
					}

					if (id_ctor_Lcom_viewpagerindicator_TabPageIndicator_Landroid_content_Context_ == IntPtr.Zero)
						id_ctor_Lcom_viewpagerindicator_TabPageIndicator_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/viewpagerindicator/TabPageIndicator;Landroid/content/Context;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_viewpagerindicator_TabPageIndicator_Landroid_content_Context_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_viewpagerindicator_TabPageIndicator_Landroid_content_Context_, __args);
				} finally {
				}
			}

			static Delegate cb_getIndex;
#pragma warning disable 0169
			static Delegate GetGetIndexHandler ()
			{
				if (cb_getIndex == null)
					cb_getIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIndex);
				return cb_getIndex;
			}

			static int n_GetIndex (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Viewpagerindicator.TabPageIndicator.TabView __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TabPageIndicator.TabView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Index;
			}
#pragma warning restore 0169

			static IntPtr id_getIndex;
			public virtual unsafe int Index {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TabPageIndicator.TabView']/method[@name='getIndex' and count(parameter)=0]"
				[Register ("getIndex", "()I", "GetGetIndexHandler")]
				get {
					if (id_getIndex == IntPtr.Zero)
						id_getIndex = JNIEnv.GetMethodID (class_ref, "getIndex", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIndex);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIndex", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_onMeasure_II;
#pragma warning disable 0169
			static Delegate GetOnMeasure_IIHandler ()
			{
				if (cb_onMeasure_II == null)
					cb_onMeasure_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnMeasure_II);
				return cb_onMeasure_II;
			}

			static void n_OnMeasure_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				global::Com.Viewpagerindicator.TabPageIndicator.TabView __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TabPageIndicator.TabView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnMeasure (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onMeasure_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TabPageIndicator.TabView']/method[@name='onMeasure' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("onMeasure", "(II)V", "GetOnMeasure_IIHandler")]
			public virtual unsafe void OnMeasure (int p0, int p1)
			{
				if (id_onMeasure_II == IntPtr.Zero)
					id_onMeasure_II = JNIEnv.GetMethodID (class_ref, "onMeasure", "(II)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMeasure_II, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMeasure", "(II)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/viewpagerindicator/TabPageIndicator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TabPageIndicator); }
		}

		protected TabPageIndicator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TabPageIndicator']/constructor[@name='TabPageIndicator' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe TabPageIndicator (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (TabPageIndicator)) {
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

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TabPageIndicator']/constructor[@name='TabPageIndicator' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe TabPageIndicator (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (TabPageIndicator)) {
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
			global::Com.Viewpagerindicator.TabPageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TabPageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyDataSetChanged ();
		}
#pragma warning restore 0169

		static IntPtr id_notifyDataSetChanged;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TabPageIndicator']/method[@name='notifyDataSetChanged' and count(parameter)=0]"
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

		static Delegate cb_onAttachedToWindow;
#pragma warning disable 0169
		static Delegate GetOnAttachedToWindowHandler ()
		{
			if (cb_onAttachedToWindow == null)
				cb_onAttachedToWindow = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAttachedToWindow);
			return cb_onAttachedToWindow;
		}

		static void n_OnAttachedToWindow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.TabPageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TabPageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAttachedToWindow ();
		}
#pragma warning restore 0169

		static IntPtr id_onAttachedToWindow;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TabPageIndicator']/method[@name='onAttachedToWindow' and count(parameter)=0]"
		[Register ("onAttachedToWindow", "()V", "GetOnAttachedToWindowHandler")]
		public virtual unsafe void OnAttachedToWindow ()
		{
			if (id_onAttachedToWindow == IntPtr.Zero)
				id_onAttachedToWindow = JNIEnv.GetMethodID (class_ref, "onAttachedToWindow", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAttachedToWindow);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAttachedToWindow", "()V"));
			} finally {
			}
		}

		static Delegate cb_onDetachedFromWindow;
#pragma warning disable 0169
		static Delegate GetOnDetachedFromWindowHandler ()
		{
			if (cb_onDetachedFromWindow == null)
				cb_onDetachedFromWindow = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDetachedFromWindow);
			return cb_onDetachedFromWindow;
		}

		static void n_OnDetachedFromWindow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.TabPageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TabPageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDetachedFromWindow ();
		}
#pragma warning restore 0169

		static IntPtr id_onDetachedFromWindow;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TabPageIndicator']/method[@name='onDetachedFromWindow' and count(parameter)=0]"
		[Register ("onDetachedFromWindow", "()V", "GetOnDetachedFromWindowHandler")]
		public virtual unsafe void OnDetachedFromWindow ()
		{
			if (id_onDetachedFromWindow == IntPtr.Zero)
				id_onDetachedFromWindow = JNIEnv.GetMethodID (class_ref, "onDetachedFromWindow", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDetachedFromWindow);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDetachedFromWindow", "()V"));
			} finally {
			}
		}

		static Delegate cb_onMeasure_II;
#pragma warning disable 0169
		static Delegate GetOnMeasure_IIHandler ()
		{
			if (cb_onMeasure_II == null)
				cb_onMeasure_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnMeasure_II);
			return cb_onMeasure_II;
		}

		static void n_OnMeasure_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Viewpagerindicator.TabPageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TabPageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMeasure (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onMeasure_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TabPageIndicator']/method[@name='onMeasure' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onMeasure", "(II)V", "GetOnMeasure_IIHandler")]
		public virtual unsafe void OnMeasure (int p0, int p1)
		{
			if (id_onMeasure_II == IntPtr.Zero)
				id_onMeasure_II = JNIEnv.GetMethodID (class_ref, "onMeasure", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMeasure_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMeasure", "(II)V"), __args);
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
			global::Com.Viewpagerindicator.TabPageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TabPageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPageScrollStateChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPageScrollStateChanged_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TabPageIndicator']/method[@name='onPageScrollStateChanged' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Viewpagerindicator.TabPageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TabPageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPageScrolled (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onPageScrolled_IFI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TabPageIndicator']/method[@name='onPageScrolled' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='int']]"
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
			global::Com.Viewpagerindicator.TabPageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TabPageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPageSelected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPageSelected_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TabPageIndicator']/method[@name='onPageSelected' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Viewpagerindicator.TabPageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TabPageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCurrentItem (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCurrentItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TabPageIndicator']/method[@name='setCurrentItem' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Viewpagerindicator.TabPageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TabPageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.View.ViewPager.IOnPageChangeListener p0 = (global::Android.Support.V4.View.ViewPager.IOnPageChangeListener)global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.ViewPager.IOnPageChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnPageChangeListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TabPageIndicator']/method[@name='setOnPageChangeListener' and count(parameter)=1 and parameter[1][@type='android.support.v4.view.ViewPager.OnPageChangeListener']]"
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

		static Delegate cb_setOnTabReselectedListener_Lcom_viewpagerindicator_TabPageIndicator_OnTabReselectedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnTabReselectedListener_Lcom_viewpagerindicator_TabPageIndicator_OnTabReselectedListener_Handler ()
		{
			if (cb_setOnTabReselectedListener_Lcom_viewpagerindicator_TabPageIndicator_OnTabReselectedListener_ == null)
				cb_setOnTabReselectedListener_Lcom_viewpagerindicator_TabPageIndicator_OnTabReselectedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnTabReselectedListener_Lcom_viewpagerindicator_TabPageIndicator_OnTabReselectedListener_);
			return cb_setOnTabReselectedListener_Lcom_viewpagerindicator_TabPageIndicator_OnTabReselectedListener_;
		}

		static void n_SetOnTabReselectedListener_Lcom_viewpagerindicator_TabPageIndicator_OnTabReselectedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Viewpagerindicator.TabPageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TabPageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Viewpagerindicator.TabPageIndicator.IOnTabReselectedListener p0 = (global::Com.Viewpagerindicator.TabPageIndicator.IOnTabReselectedListener)global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TabPageIndicator.IOnTabReselectedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnTabReselectedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnTabReselectedListener_Lcom_viewpagerindicator_TabPageIndicator_OnTabReselectedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TabPageIndicator']/method[@name='setOnTabReselectedListener' and count(parameter)=1 and parameter[1][@type='com.viewpagerindicator.TabPageIndicator.OnTabReselectedListener']]"
		[Register ("setOnTabReselectedListener", "(Lcom/viewpagerindicator/TabPageIndicator$OnTabReselectedListener;)V", "GetSetOnTabReselectedListener_Lcom_viewpagerindicator_TabPageIndicator_OnTabReselectedListener_Handler")]
		public virtual unsafe void SetOnTabReselectedListener (global::Com.Viewpagerindicator.TabPageIndicator.IOnTabReselectedListener p0)
		{
			if (id_setOnTabReselectedListener_Lcom_viewpagerindicator_TabPageIndicator_OnTabReselectedListener_ == IntPtr.Zero)
				id_setOnTabReselectedListener_Lcom_viewpagerindicator_TabPageIndicator_OnTabReselectedListener_ = JNIEnv.GetMethodID (class_ref, "setOnTabReselectedListener", "(Lcom/viewpagerindicator/TabPageIndicator$OnTabReselectedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnTabReselectedListener_Lcom_viewpagerindicator_TabPageIndicator_OnTabReselectedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnTabReselectedListener", "(Lcom/viewpagerindicator/TabPageIndicator$OnTabReselectedListener;)V"), __args);
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
			global::Com.Viewpagerindicator.TabPageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TabPageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.View.ViewPager p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.ViewPager> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetViewPager (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setViewPager_Landroid_support_v4_view_ViewPager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TabPageIndicator']/method[@name='setViewPager' and count(parameter)=1 and parameter[1][@type='android.support.v4.view.ViewPager']]"
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
			global::Com.Viewpagerindicator.TabPageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.TabPageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.View.ViewPager p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.ViewPager> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetViewPager (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setViewPager_Landroid_support_v4_view_ViewPager_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/class[@name='TabPageIndicator']/method[@name='setViewPager' and count(parameter)=2 and parameter[1][@type='android.support.v4.view.ViewPager'] and parameter[2][@type='int']]"
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

#region "Event implementation for Com.Viewpagerindicator.TabPageIndicator.IOnTabReselectedListener"
		public event EventHandler<global::Com.Viewpagerindicator.TabPageIndicator.TabReselectedEventArgs> TabReselected {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Viewpagerindicator.TabPageIndicator.IOnTabReselectedListener, global::Com.Viewpagerindicator.TabPageIndicator.IOnTabReselectedListenerImplementor>(
						ref weak_implementor_SetOnTabReselectedListener,
						__CreateIOnTabReselectedListenerImplementor,
						SetOnTabReselectedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Viewpagerindicator.TabPageIndicator.IOnTabReselectedListener, global::Com.Viewpagerindicator.TabPageIndicator.IOnTabReselectedListenerImplementor>(
						ref weak_implementor_SetOnTabReselectedListener,
						global::Com.Viewpagerindicator.TabPageIndicator.IOnTabReselectedListenerImplementor.__IsEmpty,
						__v => SetOnTabReselectedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnTabReselectedListener;

		global::Com.Viewpagerindicator.TabPageIndicator.IOnTabReselectedListenerImplementor __CreateIOnTabReselectedListenerImplementor ()
		{
			return new global::Com.Viewpagerindicator.TabPageIndicator.IOnTabReselectedListenerImplementor (this);
		}
#endregion
	}
}
