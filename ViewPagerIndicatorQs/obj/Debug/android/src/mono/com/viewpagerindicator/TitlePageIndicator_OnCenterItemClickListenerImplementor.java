package mono.com.viewpagerindicator;


public class TitlePageIndicator_OnCenterItemClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.viewpagerindicator.TitlePageIndicator.OnCenterItemClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCenterItemClick:(I)V:GetOnCenterItemClick_IHandler:Com.Viewpagerindicator.TitlePageIndicator/IOnCenterItemClickListenerInvoker, Naxam.ViewPagerIndicator.Droid\n" +
			"";
		mono.android.Runtime.register ("Com.Viewpagerindicator.TitlePageIndicator+IOnCenterItemClickListenerImplementor, Naxam.ViewPagerIndicator.Droid, Version=2.4.1.0, Culture=neutral, PublicKeyToken=null", TitlePageIndicator_OnCenterItemClickListenerImplementor.class, __md_methods);
	}


	public TitlePageIndicator_OnCenterItemClickListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == TitlePageIndicator_OnCenterItemClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Viewpagerindicator.TitlePageIndicator+IOnCenterItemClickListenerImplementor, Naxam.ViewPagerIndicator.Droid, Version=2.4.1.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCenterItemClick (int p0)
	{
		n_onCenterItemClick (p0);
	}

	private native void n_onCenterItemClick (int p0);

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
