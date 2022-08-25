using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XmarinStudy.Services;
using XmarinStudy.Views;

namespace XmarinStudy
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //MainPage = new AppShell();

            //MainPage = new ch_2_ContentPage();

            //MainPage = new NavigationPage(new ch_3_ToobarPage());

            //MainPage = new ch_4_TabbedPage();

            
            TabbedPage tabbed = new TabbedPage();
            tabbed.Children.Add(new ch_2_ContentPage() { Title = "page1"});
            tabbed.Children.Add(new ch_2_ContentPage2() { Title = "page2" });
            tabbed.Children.Add(new ch_3_ToobarPage() { Title = "page3" });
            MainPage = tabbed;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
