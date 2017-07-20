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
using static Com.Viewpagerindicator.TitlePageIndicator;

namespace ViewPagerIndicatorQs.Views
{
    [Activity]
    public class SampleTitlesTriangle : BaseSampleActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.simple_titles);

            mAdapter = new TestFragmentAdapter(SupportFragmentManager);

            mPager = FindViewById<ViewPager>(Resource.Id.pager);
            mPager.Adapter = mAdapter;

            TitlePageIndicator indicator = FindViewById<TitlePageIndicator>(Resource.Id.indicator);
            indicator.SetViewPager(mPager);
            indicator.FooterIndicatorStyle = IndicatorStyle.Triangle;
            mIndicator = indicator;
        }
    }
}