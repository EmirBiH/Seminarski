﻿using eFastFood.Login;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.Navigacija;

namespace eFastFood
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MDPage();   //new NavigationPage(new Prijava()); 

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
