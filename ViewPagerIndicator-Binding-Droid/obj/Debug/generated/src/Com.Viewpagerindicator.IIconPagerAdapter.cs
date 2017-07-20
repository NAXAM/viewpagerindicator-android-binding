using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Viewpagerindicator {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.viewpagerindicator']/interface[@name='IconPagerAdapter']"
	[Register ("com/viewpagerindicator/IconPagerAdapter", "", "Com.Viewpagerindicator.IIconPagerAdapterInvoker")]
	public partial interface IIconPagerAdapter : IJavaObject {

		int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/interface[@name='IconPagerAdapter']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler:Com.Viewpagerindicator.IIconPagerAdapterInvoker, ViewPagerIndicator-Binding-Droid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.viewpagerindicator']/interface[@name='IconPagerAdapter']/method[@name='getIconResId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getIconResId", "(I)I", "GetGetIconResId_IHandler:Com.Viewpagerindicator.IIconPagerAdapterInvoker, ViewPagerIndicator-Binding-Droid")]
		int GetIconResId (int p0);

	}

	[global::Android.Runtime.Register ("com/viewpagerindicator/IconPagerAdapter", DoNotGenerateAcw=true)]
	internal class IIconPagerAdapterInvoker : global::Java.Lang.Object, IIconPagerAdapter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/viewpagerindicator/IconPagerAdapter");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IIconPagerAdapterInvoker); }
		}

		IntPtr class_ref;

		public static IIconPagerAdapter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIconPagerAdapter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.viewpagerindicator.IconPagerAdapter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIconPagerAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Viewpagerindicator.IIconPagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.IIconPagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		IntPtr id_getCount;
		public unsafe int Count {
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCount);
			}
		}

		static Delegate cb_getIconResId_I;
#pragma warning disable 0169
		static Delegate GetGetIconResId_IHandler ()
		{
			if (cb_getIconResId_I == null)
				cb_getIconResId_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetIconResId_I);
			return cb_getIconResId_I;
		}

		static int n_GetIconResId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Viewpagerindicator.IIconPagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Viewpagerindicator.IIconPagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetIconResId (p0);
		}
#pragma warning restore 0169

		IntPtr id_getIconResId_I;
		public unsafe int GetIconResId (int p0)
		{
			if (id_getIconResId_I == IntPtr.Zero)
				id_getIconResId_I = JNIEnv.GetMethodID (class_ref, "getIconResId", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIconResId_I, __args);
		}

	}

}
