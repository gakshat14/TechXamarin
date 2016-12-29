using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AraHunt.Pages
{
    public partial class Final : ContentPage
    {
        int score;
        public Final(int data)
        {
            score = data;
            InitializeComponent();
            FinalMarks.Text = string.Format("Your final score is: {0}", score.ToString());
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}
