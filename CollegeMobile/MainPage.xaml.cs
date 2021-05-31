using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace CollegeMobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BackSpec_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void ICiP_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpecICiP());
        }

        private void ST_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpecST());
        }

        private void AT_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpecAT());
        }

        private void Kamen_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpecKamen());
        }

        private void Svar_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpecSvar());
        }
    }
}
