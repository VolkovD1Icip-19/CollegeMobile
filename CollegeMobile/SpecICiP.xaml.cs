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
    public partial class SpecICiP : ContentPage
    {
        public SpecICiP()
        {
            InitializeComponent();
        }

        private void BackSpec_Tapped(object sender, EventArgs e)
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
            Navigation.PushAsync(new Filials());
        }

        private void Help_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Help());
        }
    }
}