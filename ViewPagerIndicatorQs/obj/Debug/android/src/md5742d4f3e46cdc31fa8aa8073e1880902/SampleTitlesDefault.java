package md5742d4f3e46cdc31fa8aa8073e1880902;


public class SampleTitlesDefault
	extends md5742d4f3e46cdc31fa8aa8073e1880902.BaseSampleActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("ViewPagerIndicatorQs.Views.SampleTitlesDefault, ViewPagerIndicatorQs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SampleTitlesDefault.class, __md_methods);
	}


	public SampleTitlesDefault () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SampleTitlesDefault.class)
			mono.android.TypeManager.Activate ("ViewPagerIndicatorQs.Views.SampleTitlesDefault, ViewPagerIndicatorQs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
