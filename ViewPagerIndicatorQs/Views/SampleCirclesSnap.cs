﻿using System;
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
    public class SampleCirclesSnap : BaseSampleActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.simple_circles);

            mAdapter = new TestFragmentAdapter(SupportFragmentManager);

            mPager = FindViewById<ViewPager>(Resource.Id.pager);
            mPager.Adapter = mAdapter;

            CirclePageIndicator indicator = FindViewById<CirclePageIndicator>(Resource.Id.indicator);
            mIndicator = indicator;
            indicator.SetViewPager(mPager);
            indicator.Snap = true;
        }
    }
}