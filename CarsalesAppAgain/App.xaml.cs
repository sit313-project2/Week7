﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CarsalesAppAgain.Services;
using CarsalesAppAgain.Views;

namespace CarsalesAppAgain
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            var splashPage = new NavigationPage(new SplashPage());
            MainPage = splashPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
