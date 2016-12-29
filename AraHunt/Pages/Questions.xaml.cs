using AraHunt.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AraHunt.Pages
{
    public partial class Questions : ContentPage
    {
        List<string> ques = new List<string>();
        List<string> option1 = new List<string>();
        List<string> option2 = new List<string>();
        List<string> option3 = new List<string>();
        List<string> option4 = new List<string>();
        Random rand = new Random();
        int score = 0;
        int quesIndex = 0;
        public Questions()
        {
            //generating questions
            ques.Add("Tizen OS is joint effort of");
            ques.Add("What is the name of Windows 10 default wallpaper?");
            ques.Add("Latest phone by Blackberry");
            ques.Add("IFA 2016 took place at");
            ques.Add("Project name for porting iOS app to UWP");
            ques.Add("Framework which uses C# to create cross-platform app");
            ques.Add("iPhone7 is _________ certified");
            ques.Add("Nokia OZO is a");
            ques.Add("Who is the CEO of Samsung");
            ques.Add("is best known for Continous Integration server");
            ques.Add("A project was announced in XBOX E3, name it");

            //generating option 1
            option1.Add("Nokia and Microsoft");
            option1.Add("Windows Hello");
            option1.Add("Priv");
            option1.Add("Berlin");//answer
            option1.Add("Project Milky Way");
            option1.Add("Cordova");
            option1.Add("IP67");//answer
            option1.Add("SmartPhone");
            option1.Add("Yoon Boo Keun");
            option1.Add("GitHub");
            option1.Add("Project Spartan");

            //generating option 2
            option2.Add("Samsung and Intel");//answer
            option2.Add("Windows Here");
            option2.Add("Z30");
            option2.Add("San Francisco");
            option2.Add("Project WestMinster");
            option2.Add("PhoneGap");
            option2.Add("IP34");
            option2.Add("SmartCamera");
            option2.Add("Jong-Kyun Shin");
            option2.Add("Xamarin Test Cloud");
            option2.Add("Project Scorpio");//answer

            //generating option 3
            option3.Add("Samsung and Google");
            option3.Add("Windows Hero");//answer
            option3.Add("BlackBerry Porche");
            option3.Add("Las Vegas");
            option3.Add("Project Astoria");
            option3.Add("Xamarin");//answer
            option3.Add("IP87");
            option3.Add("Digital camera");
            option3.Add("Kwon Oh-hyun");
            option3.Add("Jenkins");//answer
            option3.Add("Project Spartan");

            //generating option 4
            option4.Add("None of the above");
            option4.Add("all of the above");
            option4.Add("BlackBerry DTEK50");//answer
            option4.Add("Mexico");
            option4.Add("Project Islandwood");//answer
            option4.Add("Ionic");
            option4.Add("None of the above");
            option4.Add("VR Camera");//answer
            option4.Add("All of the above");//answer
            option4.Add("Shell Script");
            option4.Add("Project Scorpion");

            InitializeComponent();

            scoreLabel.Text = String.Format("Your Score: {0}", score.ToString());

            generateQuestion();
        }

        private void generateQuestion()
        {

            switch (quesIndex)
            {
                case 0:
                    quesLabel.Text = ques[quesIndex];
                    Answerbtn1.Text = option1[quesIndex];
                    Answerbtn2.Text = option2[quesIndex];
                    Answerbtn3.Text = option3[quesIndex];
                    Answerbtn4.Text = option4[quesIndex];
                    break;
                case 1:
                    quesLabel.Text = ques[quesIndex];
                    Answerbtn1.Text = option1[quesIndex];
                    Answerbtn2.Text = option2[quesIndex];
                    Answerbtn3.Text = option3[quesIndex];
                    Answerbtn4.Text = option4[quesIndex];
                    break;
                case 2:
                    quesLabel.Text = ques[quesIndex];
                    Answerbtn1.Text = option1[quesIndex];
                    Answerbtn2.Text = option2[quesIndex];
                    Answerbtn3.Text = option3[quesIndex];
                    Answerbtn4.Text = option4[quesIndex];
                    break;
                case 3:
                    quesLabel.Text = ques[quesIndex];
                    Answerbtn1.Text = option1[quesIndex];
                    Answerbtn2.Text = option2[quesIndex];
                    Answerbtn3.Text = option3[quesIndex];
                    Answerbtn4.Text = option4[quesIndex];
                    break;
                case 4:
                    quesLabel.Text = ques[quesIndex];
                    Answerbtn1.Text = option1[quesIndex];
                    Answerbtn2.Text = option2[quesIndex];
                    Answerbtn3.Text = option3[quesIndex];
                    Answerbtn4.Text = option4[quesIndex];
                    break;
                case 5:
                    quesLabel.Text = ques[quesIndex];
                    Answerbtn1.Text = option1[quesIndex];
                    Answerbtn2.Text = option2[quesIndex];
                    Answerbtn3.Text = option3[quesIndex];
                    Answerbtn4.Text = option4[quesIndex];
                    break;
                case 6:
                    quesLabel.Text = ques[quesIndex];
                    Answerbtn1.Text = option1[quesIndex];
                    Answerbtn2.Text = option2[quesIndex];
                    Answerbtn3.Text = option3[quesIndex];
                    Answerbtn4.Text = option4[quesIndex];
                    break;
                case 7:
                    quesLabel.Text = ques[quesIndex];
                    Answerbtn1.Text = option1[quesIndex];
                    Answerbtn2.Text = option2[quesIndex];
                    Answerbtn3.Text = option3[quesIndex];
                    Answerbtn4.Text = option4[quesIndex];
                    break;
                case 8:
                    quesLabel.Text = ques[quesIndex];
                    Answerbtn1.Text = option1[quesIndex];
                    Answerbtn2.Text = option2[quesIndex];
                    Answerbtn3.Text = option3[quesIndex];
                    Answerbtn4.Text = option4[quesIndex];
                    break;
                case 9:
                    quesLabel.Text = ques[quesIndex];
                    Answerbtn1.Text = option1[quesIndex];
                    Answerbtn2.Text = option2[quesIndex];
                    Answerbtn3.Text = option3[quesIndex];
                    Answerbtn4.Text = option4[quesIndex];
                    break;
                case 10:
                    quesLabel.Text = ques[quesIndex];
                    Answerbtn1.Text = option1[quesIndex];
                    Answerbtn2.Text = option2[quesIndex];
                    Answerbtn3.Text = option3[quesIndex];
                    Answerbtn4.Text = option4[quesIndex];
                    break;
            }
        }

        private void correct()
        {
            score = score + 2;

            scoreLabel.Text = String.Format("Your Score: {0}", score.ToString());

            if (quesIndex == 10)
            {
                Navigation.PushModalAsync(new Final(score), true);
            }
            
        }

        private void wrong()
        {
            if (quesIndex == 10)
            {
                Navigation.PushModalAsync(new Final(score), true);
            }
            

        }

        private void Answerbtn1Clicked(object sender, EventArgs e)
        {
            if (quesIndex == 3 || quesIndex == 6)
            {
                correct();
                
            }
            if (quesIndex != 3 && quesIndex != 6)
            {
                wrong();
            }

            quesIndex = quesIndex + 1;
            if(quesIndex != 11)
            {
                generateQuestion();
            }
        }

        private void Answerbtn2Clicked(object sender, EventArgs e)
        {
            if (quesIndex == 0 || quesIndex == 10)
            {
                correct();
                
            }
            if (quesIndex != 0 && quesIndex != 10)
            {
                wrong();
            }

            quesIndex = quesIndex + 1;
            if (quesIndex != 11)
            {
                generateQuestion();
            }
        }

        private void Answerbtn3Clicked(object sender, EventArgs e)
        {
            if (quesIndex == 1 || quesIndex == 5 || quesIndex == 9)
            {
                correct();
                
            }
            if (quesIndex != 1 && quesIndex != 5 && quesIndex != 9)
            {
                wrong();
            }

            quesIndex = quesIndex + 1;
            if (quesIndex != 11)
            {
                generateQuestion();
            }
        }

        private void Answerbtn4Clicked(object sender, EventArgs e)
        {
            if (quesIndex == 2 || quesIndex == 4 || quesIndex == 8 || quesIndex == 7)
            {
                correct();
                
            }
            if (quesIndex != 2 && quesIndex != 4 && quesIndex != 8 && quesIndex != 7)
            {
                wrong();
            }

            quesIndex = quesIndex + 1;
            if (quesIndex != 11)
            {
                generateQuestion();
            }
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

    }
}
