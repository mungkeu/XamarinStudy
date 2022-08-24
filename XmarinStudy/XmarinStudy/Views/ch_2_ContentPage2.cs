using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XmarinStudy.Views
{
    public class ch_2_ContentPage2 : ContentPage
    {
        public ch_2_ContentPage2()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!", FontSize=30, TextColor=Color.Red }
                }
            };
        }
    }
}