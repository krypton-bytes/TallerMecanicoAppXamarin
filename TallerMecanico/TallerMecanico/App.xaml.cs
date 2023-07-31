﻿using System;
using TallerMecanico.views;
using TallerMecanico.views.Cliente;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TallerMecanico
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new EstatusVehiculo();
            //MainPage = new NavigationPage(new inicio());
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
