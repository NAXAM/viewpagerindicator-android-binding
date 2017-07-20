package md5742d4f3e46cdc31fa8aa8073e1880902;


public class TestFragmentAdapter
	extends android.support.v4.app.FragmentPagerAdapter
	implements
		mono.android.IGCUserPeer,
		com.viewpagerindicator.IconPagerAdapter
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getCount:()I:GetGetCountHandler\n" +
			"n_getItem:(I)Landroid/support/v4/app/Fragment;:GetGetItem_IHandler\n" +
			"n_getIconResId:(I)I:GetGetIconResId_IHandler:Com.Viewpagerindicator.IIconPagerAdapterInvoker, Naxam.ViewPagerIndicator.Droid\n" +
			"";
		mono.android.Runtime.register ("ViewPagerIndicatorQs.Views.TestFragmentAdapter, ViewPagerIndicatorQs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", TestFragmentAdapter.class, __md_methods);
	}


	public TestFragmentAdapter (android.support.v4.app.FragmentManager p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == TestFragmentAdapter.class)
			mono.android.TypeManager.Activate ("ViewPagerIndicatorQs.Views.TestFragmentAdapter, ViewPagerIndicatorQs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Support.V4.App.FragmentManager, Xamarin.Android.Support.Fragment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}


	public int getCount ()
	{
		return n_getCount ();
	}

	private native int n_getCount ();


	public android.support.v4.app.Fragment getItem (int p0)
	{
		return n_getItem (p0);
	}

	private native android.support.v4.app.Fragment n_getItem (int p0);


	public int getIconResId (int p0)
	{
		return n_getIconResId (p0);
	}

	private native int n_getIconResId (int p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
