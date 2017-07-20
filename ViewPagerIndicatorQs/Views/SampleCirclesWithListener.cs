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
using Android.Support.V4.View;
using Com.Viewpagerindicator;

namespace ViewPagerIndicatorQs.Views
{
    [Activity]
    public class SampleCirclesWithListener : BaseSampleActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.simple_circles);

            mAdapter = new TestFragmentAdapter(SupportFragmentManager);

            mPager = FindViewById<ViewPager>(Resource.Id.pager);
            mPager.Adapter = mAdapter;

            mIndicator = FindViewById<CirclePageIndicator>(Resource.Id.indicator);
            mIndicator.SetViewPager(mPager);

            //We set this on the indicator, NOT the pager
            mIndicator.SetOnPageChangeListener(new OnPageChangeListener((i) =>
            {
                Toast.MakeText(this, "Changed to page " + i, ToastLength.Short).Show();
            }));
        }
    }

    class OnPageChangeListener : Java.Lang.Object, ViewPager.IOnPageChangeListener
    {
        Action<int> PageSelected;

        public OnPageChangeListener(Action<int> PageSelected)
        {
            this.PageSelected = PageSelected;
        }

        public void OnPageScrolled(int position, float positionOffset, int positionOffsetPixels)
        {
        }

        public void OnPageScrollStateChanged(int state)
        {
        }

        public void OnPageSelected(int position)
        {
            PageSelected?.Invoke(position);
        }
    }
}