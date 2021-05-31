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

        }

        private void Serch_Tapped(object sender, EventArgs e)
        {

        }

        private void Home_Tapped(object sender, EventArgs e)
        {

        }

        private void Filial_Tapped(object sender, EventArgs e)
        {

        }

        private void Help_Tapped(object sender, EventArgs e)
        {

        }
    }
}
