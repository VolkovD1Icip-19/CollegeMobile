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
    public partial class Filials : ContentPage
    {
        public Filials()
        {
            InitializeComponent();
        }

        private void Plast_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Plast());
        }

        private void Uch11_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Uch11());
        }

        private void Gor_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Gor());
        }

        private void Special_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Special());
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
            
        }

        private void Help_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Help());
        }
    }
}