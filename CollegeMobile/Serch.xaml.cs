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
    public partial class Serch : ContentPage
    {
        
        public Serch()
        {
            InitializeComponent();
            
        }
        
        private void SpecialArrow_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void SpecialArrow1_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Special());
        }

        private void Enter_Tapped(object sender, EventArgs e)
        {
            Search.Text = "Поиск ...";
        }
    }
}