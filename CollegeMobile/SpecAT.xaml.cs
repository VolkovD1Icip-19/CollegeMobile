﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollegeMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpecAT : ContentPage
    {
        public SpecAT()
        {
            InitializeComponent();
        }
        private void BackSpec_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}