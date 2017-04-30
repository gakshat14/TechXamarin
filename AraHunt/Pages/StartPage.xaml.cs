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
            //Adding gesture on about text block
            //so that when clicked about page can be opened
            tapped.Tapped += (s, e) => {
                Navigation.PushModalAsync(new About(), true);
            };
            about.GestureRecognizers.Add(tapped);
        }
        //navigating to next page by clicking
        private void startbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Questions(), true);
        }
        
    }
}
