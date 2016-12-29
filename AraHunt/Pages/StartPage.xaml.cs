using AraHunt.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AraHunt.Pages
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
            var tapped = new TapGestureRecognizer();

            tapped.Tapped += (s, e) => {
                Navigation.PushModalAsync(new About(), true);
            };
            about.GestureRecognizers.Add(tapped);
        }
        
        private void startbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Questions(), true);
        }
        
    }
}
