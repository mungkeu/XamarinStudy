using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XmarinStudy.Views
{
    public class ch_6_FlyoutPage2 : FlyoutPage
    {
        public ch_6_FlyoutPage2()
        {
            Flyout = new ch_2_ContentPage2() { Title = "FlyoutPage" };
            Detail = new NavigationPage(new ch_3_ToobarPage()); // 디테일이 먼저 실행
            //버튼이 나오려면 네비게이션 페이지로 감싸줘야한다.
        }
    }
}
