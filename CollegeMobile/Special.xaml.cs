using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollegeMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Special : ContentPage
    {
        public Special()
        {
            InitializeComponent();
        }

        private void BackSpec_Tapped(object sender, EventArgs e)
        {
            
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

        private void Tokar_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpecTokar());
        }

        private void Search_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Serch());
        }

        private void Home_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void Filial_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Filials());
        }

        private void Help_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Help());
        }
    }
}