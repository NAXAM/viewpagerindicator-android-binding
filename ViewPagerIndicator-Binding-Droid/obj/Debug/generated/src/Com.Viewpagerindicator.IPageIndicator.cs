using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Viewpagerindicator {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.viewpagerindicator']/interface[@name='PageIndicator']"
	[Register ("com/viewpagerindicator/PageIndicator", "", "Com.Viewpagerindicator.IPageIndicatorInvoker")]
	public partial interface IPageIndicator : global::Android.Support.V4.View.ViewPager.IOnPageChangeListener {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/interface[@name='PageIndicator']/method[@name='notifyDataSetChanged' and count(parameter)=0]"
		[Register ("notifyDataSetChanged", "()V", "GetNotifyDataSetChangedHandler:Com.Viewpagerindicator.IPageIndicatorInvoker, ViewPagerIndicator-Binding-Droid")]
		void NotifyDataSetChanged ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/interface[@name='PageIndicator']/method[@name='setCurrentItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCurrentItem", "(I)V", "GetSetCurrentItem_IHandler:Com.Viewpagerindicator.IPageIndicatorInvoker, ViewPagerIndicator-Binding-Droid")]
		void SetCurrentItem (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/interface[@name='PageIndicator']/method[@name='setOnPageChangeListener' and count(parameter)=1 and parameter[1][@type='android.support.v4.view.ViewPager.OnPageChangeListener']]"
		[Register ("setOnPageChangeListener", "(Landroid/support/v4/view/ViewPager$OnPageChangeListener;)V", "GetSetOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_Handler:Com.Viewpagerindicator.IPageIndicatorInvoker, ViewPagerIndicator-Binding-Droid")]
		void SetOnPageChangeListener (global::Android.Support.V4.View.ViewPager.IOnPageChangeListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/interface[@name='PageIndicator']/method[@name='setViewPager' and count(parameter)=1 and parameter[1][@type='android.support.v4.view.ViewPager']]"
		[Register ("setViewPager", "(Landroid/support/v4/view/ViewPager;)V", "GetSetViewPager_Landroid_support_v4_view_ViewPager_Handler:Com.Viewpagerindicator.IPageIndicatorInvoker, ViewPagerIndicator-Binding-Droid")]
		void SetViewPager (global::Android.Support.V4.View.ViewPager p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/interface[@name='PageIndicator']/method[@name='setViewPager' and count(parameter)=2 and parameter[1][@type='android.support.v4.view.ViewPager'] and parameter[2][@type='int']]"
		[Register ("setViewPager", "(Landroid/support/v4/view/ViewPager;I)V", "GetSetViewPager_Landroid_support_v4_view_ViewPager_IHandler:Com.Viewpagerindicator.IPageIndicatorInvoker, ViewPagerIndicator-Binding-Droid")]
		void SetViewPager (global::Android.Support.V4.View.ViewPager p0, int p1);

	}

	[global::Android.Runtime.Register ("com/viewpagerindicator/PageIndicator", DoNotGenerateAcw=true)]
	internal class IPageIndicatorInvoker : global::Java.Lang.Object, IPageIndicator {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/viewpagerindicator/PageIndicator");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPageIndicatorInvoker); }
		}

		IntPtr class_ref;

		public static IPageIndicator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPageIndicator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.viewpagerindicator.PageIndicator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPageIndicatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Viewpagerindicator.IPageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.IPageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyDataSetChanged ();
		}
#pragma warning restore 0169

		IntPtr id_notifyDataSetChanged;
		public unsafe void NotifyDataSetChanged ()
		{
			if (id_notifyDataSetChanged == IntPtr.Zero)
				id_notifyDataSetChanged = JNIEnv.GetMethodID (class_ref, "notifyDataSetChanged", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyDataSetChanged);
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
			global::Com.Viewpagerindicator.IPageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.IPageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCurrentItem (p0);
		}
#pragma warning restore 0169

		IntPtr id_setCurrentItem_I;
		public unsafe void SetCurrentItem (int p0)
		{
			if (id_setCurrentItem_I == IntPtr.Zero)
				id_setCurrentItem_I = JNIEnv.GetMethodID (class_ref, "setCurrentItem", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCurrentItem_I, __args);
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
			global::Com.Viewpagerindicator.IPageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.IPageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.View.ViewPager.IOnPageChangeListener p0 = (global::Android.Support.V4.View.ViewPager.IOnPageChangeListener)global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.ViewPager.IOnPageChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnPageChangeListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_;
		public unsafe void SetOnPageChangeListener (global::Android.Support.V4.View.ViewPager.IOnPageChangeListener p0)
		{
			if (id_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_ == IntPtr.Zero)
				id_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_ = JNIEnv.GetMethodID (class_ref, "setOnPageChangeListener", "(Landroid/support/v4/view/ViewPager$OnPageChangeListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnPageChangeListener_Landroid_support_v4_view_ViewPager_OnPageChangeListener_, __args);
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
			global::Com.Viewpagerindicator.IPageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.IPageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.View.ViewPager p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.ViewPager> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetViewPager (p0);
		}
#pragma warning restore 0169

		IntPtr id_setViewPager_Landroid_support_v4_view_ViewPager_;
		public unsafe void SetViewPager (global::Android.Support.V4.View.ViewPager p0)
		{
			if (id_setViewPager_Landroid_support_v4_view_ViewPager_ == IntPtr.Zero)
				id_setViewPager_Landroid_support_v4_view_ViewPager_ = JNIEnv.GetMethodID (class_ref, "setViewPager", "(Landroid/support/v4/view/ViewPager;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setViewPager_Landroid_support_v4_view_ViewPager_, __args);
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
			global::Com.Viewpagerindicator.IPageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.IPageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.View.ViewPager p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.ViewPager> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetViewPager (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setViewPager_Landroid_support_v4_view_ViewPager_I;
		public unsafe void SetViewPager (global::Android.Support.V4.View.ViewPager p0, int p1)
		{
			if (id_setViewPager_Landroid_support_v4_view_ViewPager_I == IntPtr.Zero)
				id_setViewPager_Landroid_support_v4_view_ViewPager_I = JNIEnv.GetMethodID (class_ref, "setViewPager", "(Landroid/support/v4/view/ViewPager;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setViewPager_Landroid_support_v4_view_ViewPager_I, __args);
		}

		static Delegate cb_onPageScrollStateChanged_I;
#pragma warning disable 0169
		static Delegate GetOnPageScrollStateChanged_IHandler ()
		{
			if (cb_onPageScrollStateChanged_I == null)
				cb_onPageScrollStateChanged_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnPageScrollStateChanged_I);
			return cb_onPageScrollStateChanged_I;
		}

		static void n_OnPageScrollStateChanged_I (IntPtr jnienv, IntPtr native__this, int state)
		{
			global::Com.Viewpagerindicator.IPageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.IPageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPageScrollStateChanged (state);
		}
#pragma warning restore 0169

		IntPtr id_onPageScrollStateChanged_I;
		public unsafe void OnPageScrollStateChanged (int state)
		{
			if (id_onPageScrollStateChanged_I == IntPtr.Zero)
				id_onPageScrollStateChanged_I = JNIEnv.GetMethodID (class_ref, "onPageScrollStateChanged", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (state);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPageScrollStateChanged_I, __args);
		}

		static Delegate cb_onPageScrolled_IFI;
#pragma warning disable 0169
		static Delegate GetOnPageScrolled_IFIHandler ()
		{
			if (cb_onPageScrolled_IFI == null)
				cb_onPageScrolled_IFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, float, int>) n_OnPageScrolled_IFI);
			return cb_onPageScrolled_IFI;
		}

		static void n_OnPageScrolled_IFI (IntPtr jnienv, IntPtr native__this, int position, float positionOffset, int positionOffsetPixels)
		{
			global::Com.Viewpagerindicator.IPageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.IPageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPageScrolled (position, positionOffset, positionOffsetPixels);
		}
#pragma warning restore 0169

		IntPtr id_onPageScrolled_IFI;
		public unsafe void OnPageScrolled (int position, float positionOffset, int positionOffsetPixels)
		{
			if (id_onPageScrolled_IFI == IntPtr.Zero)
				id_onPageScrolled_IFI = JNIEnv.GetMethodID (class_ref, "onPageScrolled", "(IFI)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (position);
			__args [1] = new JValue (positionOffset);
			__args [2] = new JValue (positionOffsetPixels);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPageScrolled_IFI, __args);
		}

		static Delegate cb_onPageSelected_I;
#pragma warning disable 0169
		static Delegate GetOnPageSelected_IHandler ()
		{
			if (cb_onPageSelected_I == null)
				cb_onPageSelected_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnPageSelected_I);
			return cb_onPageSelected_I;
		}

		static void n_OnPageSelected_I (IntPtr jnienv, IntPtr native__this, int position)
		{
			global::Com.Viewpagerindicator.IPageIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.IPageIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPageSelected (position);
		}
#pragma warning restore 0169

		IntPtr id_onPageSelected_I;
		public unsafe void OnPageSelected (int position)
		{
			if (id_onPageSelected_I == IntPtr.Zero)
				id_onPageSelected_I = JNIEnv.GetMethodID (class_ref, "onPageSelected", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (position);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPageSelected_I, __args);
		}

	}

}
