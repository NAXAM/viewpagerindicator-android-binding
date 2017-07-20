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
    public class SampleLinesStyledMethods : BaseSampleActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.simple_lines);

            mAdapter = new TestFragmentAdapter(SupportFragmentManager);

            mPager = FindViewById<ViewPager>(Resource.Id.pager);
            mPager.Adapter = mAdapter;

            LinePageIndicator indicator = FindViewById<LinePageIndicator>(Resource.Id.indicator);
            mIndicator = indicator;
            indicator.SetViewPager(mPager);

            float density = Resources.DisplayMetrics.Density;
            indicator.SelectedColor = Color.ParseColor("#88FF0000");
            indicator.UnselectedColor = Color.ParseColor("#FF888888");
            indicator.StrokeWidth = 4 * density;
            indicator.LineWidth = 30 * density;
        }
    }
}