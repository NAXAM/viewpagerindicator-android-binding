Android ViewPagerIndicator - Xamarin Binding Library
==========================

Paging indicator widgets that are compatible with the `ViewPager` from the
[Android Support Library][2] to improve discoverability of content.

Try out the sample application [on the Android Market][10].

![ViewPagerIndicator Sample Screenshots][9]

These widgets can also be used in conjunction with [ActionBarSherlock][3]!


Usage
=====

*For a working implementation of this project see the `sample/` folder.*

  1. Include one of the widgets in your view. This should usually be placed
     adjacent to the `ViewPager` it represents.

        <com.viewpagerindicator.TitlePageIndicator
            android:id="@+id/titles"
            android:layout_height="wrap_content"
            android:layout_width="fill_parent" />

  2. In your `onCreate` method (or `onCreateView` for a fragment), bind the
     indicator to the `ViewPager`.

         //Set the pager with an adapter
         ViewPager pager = (ViewPager)findViewById(R.id.pager);
         pager.setAdapter(new TestAdapter(getSupportFragmentManager()));

         //Bind the title indicator to the adapter
         TitlePageIndicator titleIndicator = (TitlePageIndicator)findViewById(R.id.titles);
         titleIndicator.setViewPager(pager);

  3. *(Optional)* If you use an `OnPageChangeListener` with your view pager
     you should set it in the indicator rather than on the pager directly.

         //continued from above
         titleIndicator.setOnPageChangeListener(mPageChangeListener);


Theming
-------

There are three ways to style the look of the indicators.

 1. **Theme XML**. An attribute for each type of indicator is provided in which
    you can specify a custom style.
 2. **Layout XML**. Through the use of a custom namespace you can include any
    desired styles.
 3. **Object methods**. Both styles have getters and setters for each style
    attribute which can be changed at any point.

Each indicator has a demo which creates the same look using each of these
methods.


Including In Your Project
-------------------------

    Install-Package Naxam.ViewPageIndicator.Droid

This project depends on the `ViewPager` class which is available in the
[Android Support Library][2] or [ActionBarSherlock][3]. Details for
including one of those libraries is available on their respecitve web sites.


Credits
-------

 * [Jake Wharton][11] - Author of original Java library
 * [Patrik Åkerfeldt][1] - Author of [ViewFlow][4], a precursor to the ViewPager,
   which supports paged views and is the original source of both the title
   and circle indicators.
 * [Francisco Figueiredo Jr.][5] - Idea and [first implementation][6] for
   fragment support via ViewPager.




License
=======

    Copyright (c) 2017 NAXAM

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.






 [1]: https://github.com/pakerfeldt
 [2]: http://developer.android.com/sdk/compatibility-library.html
 [3]: http://actionbarsherlock.com
 [4]: https://github.com/pakerfeldt/android-viewflow
 [5]: https://github.com/franciscojunior
 [6]: https://gist.github.com/1122947
 [7]: http://developer.android.com/guide/developing/projects/projects-eclipse.html
 [8]: http://developer.android.com/guide/developing/projects/projects-eclipse.html#ReferencingLibraryProject
 [9]: https://raw.github.com/JakeWharton/Android-ViewPagerIndicator/master/sample/screens.png
 [10]: https://play.google.com/store/apps/details?id=com.viewpagerindicator.sample
 [11]: https://github.com/JakeWharton/ViewPagerIndicator