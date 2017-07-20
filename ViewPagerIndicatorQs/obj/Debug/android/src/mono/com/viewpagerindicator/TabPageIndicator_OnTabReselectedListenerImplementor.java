package mono.com.viewpagerindicator;


public class TabPageIndicator_OnTabReselectedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.viewpagerindicator.TabPageIndicator.OnTabReselectedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTabReselected:(I)V:GetOnTabReselected_IHandler:Com.Viewpagerindicator.TabPageIndicator/IOnTabReselectedListenerInvoker, Naxam.ViewPagerIndicator.Droid\n" +
			"";
		mono.android.Runtime.register ("Com.Viewpagerindicator.TabPageIndicator+IOnTabReselectedListenerImplementor, Naxam.ViewPagerIndicator.Droid, Version=2.4.1.0, Culture=neutral, PublicKeyToken=null", TabPageIndicator_OnTabReselectedListenerImplementor.class, __md_methods);
	}


	public TabPageIndicator_OnTabReselectedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == TabPageIndicator_OnTabReselectedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Viewpagerindicator.TabPageIndicator+IOnTabReselectedListenerImplementor, Naxam.ViewPagerIndicator.Droid, Version=2.4.1.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onTabReselected (int p0)
	{
		n_onTabReselected (p0);
	}

	private native void n_onTabReselected (int p0);

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
