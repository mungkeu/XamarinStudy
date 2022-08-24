﻿using System;
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
            MainPage = new ch_2_ContentPage();
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