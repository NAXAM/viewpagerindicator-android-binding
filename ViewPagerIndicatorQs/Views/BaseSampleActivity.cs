using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Com.Viewpagerindicator;
namespace ViewPagerIndicatorQs.Views
{
    public class BaseSampleActivity : FragmentActivity
    {
        private static Random RANDOM = new Random();

        public TestFragmentAdapter mAdapter;
        public ViewPager mPager;
        public IPageIndicator mIndicator;

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu, menu);
            return true;
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.random:
                    int page = RANDOM.Next(mAdapter.Count);
                    Toast.MakeText(this, "Changing to page " + page, ToastLength.Short);
                    mPager.SetCurrentItem(page, true);
                    return true;

                case Resource.Id.add_page:
                    if (mAdapter.Count < 10)
                    {
                        mAdapter.SetCount(mAdapter.Count + 1);
                        mIndicator.NotifyDataSetChanged();
                    }
                    return true;

                case Resource.Id.remove_page:
                    if (mAdapter.Count > 1)
                    {
                        mAdapter.SetCount(mAdapter.Count - 1);
                        mIndicator.NotifyDataSetChanged();
                    }
                    return true;
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}