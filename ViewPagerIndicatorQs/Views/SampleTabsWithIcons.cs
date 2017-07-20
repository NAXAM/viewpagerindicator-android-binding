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
    [Activity]
    public class SampleTabsWithIcons : FragmentActivity
    {
        private static string[] CONTENT = new String[] { "Calendar", "Camera", "Alarms", "Location" };
        private static int[] ICONS = new int[] {
            Resource.Drawable.perm_group_calendar,
            Resource.Drawable.perm_group_camera,
            Resource.Drawable.perm_group_device_alarms,
            Resource.Drawable.perm_group_location,
        };

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.simple_tabs);

            FragmentPagerAdapter adapter = new GoogleMusicAdapter(SupportFragmentManager);

            ViewPager pager = FindViewById<ViewPager>(Resource.Id.pager);
            pager.Adapter = adapter;

            TabPageIndicator indicator = FindViewById<TabPageIndicator>(Resource.Id.indicator);
            indicator.SetViewPager(pager);
        }

        class GoogleMusicAdapter : FragmentPagerAdapter
        {
            public GoogleMusicAdapter(Android.Support.V4.App.FragmentManager fm) : base(fm)
            {

            }
            public override int Count
            {
                get { return CONTENT.Length; }
            }

            public override Android.Support.V4.App.Fragment GetItem(int position)
            {
                return TestFragment.NewInstance(CONTENT[position % CONTENT.Length]);
            }
        }
    }
}