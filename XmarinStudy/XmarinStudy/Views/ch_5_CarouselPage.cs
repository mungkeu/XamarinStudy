using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XmarinStudy.Views
{
    public class ch_5_CarouselPage : CarouselPage // ContentPage로 만들었으므로 바꾸어준다.
    {
        public ch_5_CarouselPage()
        {
            Children.Add(new ch_2_ContentPage());
            Children.Add(new ch_2_ContentPage2());
            Children.Add(new ch_3_ToobarPage());
        }
    }
}