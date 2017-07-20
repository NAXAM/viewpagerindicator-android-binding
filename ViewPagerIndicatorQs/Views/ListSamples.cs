using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Java.Lang;
using Java.Util;

namespace ViewPagerIndicatorQs.Views
{
    [Activity(Label = "ViewPagerIndicatorQs", MainLauncher = true, Icon = "@mipmap/ic_launcher", Theme = "@style/MyTheme")]
    public class ListSamples : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
            InitInterface();
        }

        public void InitInterface()
        {
            Button btSampleCirclesDefault = FindViewById<Button>(Resource.Id.SampleCirclesDefault);
            btSampleCirclesDefault.Click += (s, e) =>
            {
                ChangeActivity(new SampleCirclesDefault());
            };

            Button btSampleCirclesInitialPage = FindViewById<Button>(Resource.Id.SampleCirclesInitialPage);
            btSampleCirclesInitialPage.Click += (s, e) =>
            {
                ChangeActivity(new SampleCirclesInitialPage());
            };

            Button btSampleCirclesSnap = FindViewById<Button>(Resource.Id.SampleCirclesSnap);
            btSampleCirclesDefault.Click += (s, e) =>
            {
                ChangeActivity(new SampleCirclesSnap());
            };

            Button btSampleCirclesStyledLayout = FindViewById<Button>(Resource.Id.SampleCirclesStyledLayout);
            btSampleCirclesStyledLayout.Click += (s, e) =>
            {
                ChangeActivity(new SampleCirclesStyledLayout());
            };

            Button btSampleCirclesStyledMethods = FindViewById<Button>(Resource.Id.SampleCirclesStyledMethods);
            btSampleCirclesStyledMethods.Click += (s, e) =>
            {
                ChangeActivity(new SampleCirclesStyledMethods());
            };

            Button btSampleCirclesStyledTheme = FindViewById<Button>(Resource.Id.SampleCirclesStyledTheme);
            btSampleCirclesStyledTheme.Click += (s, e) =>
            {
                ChangeActivity(new SampleCirclesStyledTheme());
            };

            Button btSampleCirclesWithListener = FindViewById<Button>(Resource.Id.SampleCirclesWithListener);
            btSampleCirclesDefault.Click += (s, e) =>
            {
                ChangeActivity(new SampleCirclesWithListener());
            };

            Button btSampleIconsDefault = FindViewById<Button>(Resource.Id.SampleIconsDefault);
            btSampleIconsDefault.Click += (s, e) =>
            {
                ChangeActivity(new SampleIconsDefault());
            };

            Button btSampleLinesDefault = FindViewById<Button>(Resource.Id.SampleLinesDefault);
            btSampleLinesDefault.Click += (s, e) =>
            {
                ChangeActivity(new SampleLinesDefault());
            };

            Button btSampleLinesStyledLayout = FindViewById<Button>(Resource.Id.SampleLinesStyledLayout);
            btSampleLinesStyledLayout.Click += (s, e) =>
            {
                ChangeActivity(new SampleLinesStyledLayout());
            };

            Button btSampleLinesStyledMethods = FindViewById<Button>(Resource.Id.SampleLinesStyledMethods);
            btSampleLinesStyledMethods.Click += (s, e) =>
            {
                ChangeActivity(new SampleLinesStyledMethods());
            };

            Button btSampleLinesStyledTheme = FindViewById<Button>(Resource.Id.SampleLinesStyledTheme);
            btSampleLinesStyledTheme.Click += (s, e) =>
            {
                ChangeActivity(new SampleLinesStyledTheme());
            };

            Button btSampleTabsDefault = FindViewById<Button>(Resource.Id.SampleTabsDefault);
            btSampleTabsDefault.Click += (s, e) =>
            {
                ChangeActivity(new SampleTabsDefault());
            };

            Button btSampleTabsStyled = FindViewById<Button>(Resource.Id.SampleTabsStyled);
            btSampleTabsStyled.Click += (s, e) =>
            {
                ChangeActivity(new SampleTabsStyled());
            };

            Button btSampleTabsWithIcons = FindViewById<Button>(Resource.Id.SampleTabsWithIcons);
            btSampleTabsWithIcons.Click += (s, e) =>
            {
                ChangeActivity(new SampleTabsWithIcons());
            };

            Button btSampleTitlesBottom = FindViewById<Button>(Resource.Id.SampleTitlesBottom);
            btSampleTitlesBottom.Click += (s, e) =>
            {
                ChangeActivity(new SampleTitlesBottom());
            };

            Button btSampleTitlesCenterClickListener = FindViewById<Button>(Resource.Id.SampleTitlesCenterClickListener);
            btSampleTitlesCenterClickListener.Click += (s, e) =>
            {
                ChangeActivity(new SampleTitlesCenterClickListener());
            };

            Button btSampleTitlesDefault = FindViewById<Button>(Resource.Id.SampleTitlesDefault);
            btSampleTitlesDefault.Click += (s, e) =>
            {
                ChangeActivity(new SampleTitlesDefault());
            };

            Button btSampleTitlesInitialPage = FindViewById<Button>(Resource.Id.SampleTitlesInitialPage);
            btSampleTitlesInitialPage.Click += (s, e) =>
            {
                ChangeActivity(new SampleTitlesInitialPage());
            };

            Button btSampleTitlesStyledLayout = FindViewById<Button>(Resource.Id.SampleTitlesStyledLayout);
            btSampleTitlesStyledLayout.Click += (s, e) =>
            {
                ChangeActivity(new SampleTitlesStyledLayout());
            };

            Button btSampleTitlesStyledMethods = FindViewById<Button>(Resource.Id.SampleTitlesStyledMethods);
            btSampleTitlesStyledMethods.Click += (s, e) =>
            {
                ChangeActivity(new SampleTitlesStyledMethods());
            };

            Button btSampleTitlesStyledTheme = FindViewById<Button>(Resource.Id.SampleTitlesStyledTheme);
            btSampleTitlesStyledTheme.Click += (s, e) =>
            {
                ChangeActivity(new SampleTitlesStyledTheme());
            };

            Button btSampleTitlesTriangle = FindViewById<Button>(Resource.Id.SampleTitlesTriangle);
            btSampleTitlesTriangle.Click += (s, e) =>
            {
                ChangeActivity(new SampleTitlesTriangle());
            };

            Button btSampleTitlesWithListener = FindViewById<Button>(Resource.Id.SampleTitlesWithListener);
            btSampleTitlesWithListener.Click += (s, e) =>
            {
                ChangeActivity(new SampleTitlesWithListener());
            };

            Button btSampleUnderlinesDefault = FindViewById<Button>(Resource.Id.SampleUnderlinesDefault);
            btSampleUnderlinesDefault.Click += (s, e) =>
            {
                ChangeActivity(new SampleUnderlinesDefault());
            };

            Button btSampleUnderlinesNoFade = FindViewById<Button>(Resource.Id.SampleUnderlinesNoFade);
            btSampleUnderlinesNoFade.Click += (s, e) =>
            {
                ChangeActivity(new SampleUnderlinesNoFade());
            };

            Button btSampleUnderlinesStyledLayout = FindViewById<Button>(Resource.Id.SampleUnderlinesStyledLayout);
            btSampleUnderlinesStyledLayout.Click += (s, e) =>
            {
                ChangeActivity(new SampleUnderlinesStyledLayout());
            };

            Button btSampleUnderlinesStyledMethods = FindViewById<Button>(Resource.Id.SampleUnderlinesStyledMethods);
            btSampleUnderlinesStyledMethods.Click += (s, e) =>
            {
                ChangeActivity(new SampleUnderlinesStyledMethods());
            };

            Button btSampleUnderlinesStyledTheme = FindViewById<Button>(Resource.Id.SampleUnderlinesStyledTheme);
            btSampleUnderlinesStyledTheme.Click += (s, e) =>
            {
                ChangeActivity(new SampleUnderlinesStyledTheme());
            };
        }

        public void ChangeActivity(Activity activity)
        {
            Intent intent = new Intent(this, activity.Class);
            StartActivity(intent);
        }
    }
}