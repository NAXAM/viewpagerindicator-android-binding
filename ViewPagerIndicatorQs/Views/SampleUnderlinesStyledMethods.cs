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
using Android.Graphics;

namespace ViewPagerIndicatorQs.Views
{
    [Activity]
    public class SampleUnderlinesStyledMethods : BaseSampleActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.simple_underlines);

            mAdapter = new TestFragmentAdapter(SupportFragmentManager);

            mPager = FindViewById<ViewPager>(Resource.Id.pager);
            mPager.Adapter = mAdapter;

            UnderlinePageIndicator indicator = FindViewById<UnderlinePageIndicator>(Resource.Id.indicator);
            mIndicator = indicator;
            indicator.SetViewPager(mPager);
            indicator.SelectedColor = Color.ParseColor("#FFCC0000");
            indicator.SetBackgroundColor(Color.ParseColor("#FFCCCCCC"));
            indicator.FadeDelay = 1000;
            indicator.FadeLength = 1000;
        }
    }
}