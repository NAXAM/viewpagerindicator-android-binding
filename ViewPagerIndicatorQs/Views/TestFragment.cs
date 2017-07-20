using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Support.V4.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ViewPagerIndicatorQs.Views
{
    public class TestFragment : Android.Support.V4.App.Fragment
    {
        private static string KEY_CONTENT = "TestFragment:Content";
        private String mContent = "???";
        public static TestFragment NewInstance(string content)
        {
            TestFragment fragment = new TestFragment();

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < 20; i++)
            {
                builder.Append(content).Append(" ");
            }
            //builder.Remove(builder.Length - 1, builder.Length);
            fragment.mContent = builder.ToString();

            return fragment;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            if ((savedInstanceState != null) && savedInstanceState.ContainsKey(KEY_CONTENT))
            {
                mContent = savedInstanceState.GetString(KEY_CONTENT);
            }
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            TextView text = new TextView(Activity);
            text.Gravity = GravityFlags.Center;
            text.Text = mContent;
            text.TextSize = (20 * Resources.DisplayMetrics.Density);
            text.SetPadding(20, 20, 20, 20);

            LinearLayout layout = new LinearLayout(Activity);
            layout.LayoutParameters = new ViewGroup.LayoutParams(WindowManagerLayoutParams.FillParent, WindowManagerLayoutParams.FillParent);
            layout.SetGravity(GravityFlags.Center);
            layout.AddView(text);
            return layout;
        }

        public override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
            outState.PutString(KEY_CONTENT, mContent);
        }
    }
}