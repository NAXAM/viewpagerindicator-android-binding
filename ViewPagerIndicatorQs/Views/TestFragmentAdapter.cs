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
using Com.Viewpagerindicator;
using Java.Lang;

namespace ViewPagerIndicatorQs.Views
{
    public class TestFragmentAdapter : FragmentPagerAdapter, IIconPagerAdapter
    {
        protected static string[] CONTENT = new string[]
        {
            "This","Is","A","Test"
        };
        protected static int[] ICON = new int[]
        {
            Resource.Drawable.perm_group_calendar,
            Resource.Drawable.perm_group_camera,
            Resource.Drawable.perm_group_location
        };

        private int mCount = CONTENT.Length;

        public TestFragmentAdapter(Android.Support.V4.App.FragmentManager fm) : base(fm)
        {
        }
        public override int Count {
            get { return mCount; }
        }
        
        public int GetIconResId(int p0)
        {
            return ICON[p0 % ICON.Length];
        }

        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            return TestFragment.NewInstance(CONTENT[position % CONTENT.Length]);
        }

        public void SetCount(int count)
        {
            if (count > 0 && count <= 10)
            {
                mCount = count;
                NotifyDataSetChanged();
            }
        }
    }
}