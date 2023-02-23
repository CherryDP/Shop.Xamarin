using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GaleriaKot
{
    public partial class MainPage : ContentPage
    {
        private string[] randomOpinion = { "super jedzenie", "takie 50/50", "jest dobrze", "gitara", "totalne dno" };
        private string[] randomRate = { "4.8", "2.5", "3.8", "1", "6" };
        private string[] randomCost = { "20", "5", "8", "Darmowa", "30" };
        public MainPage()
        {
            InitializeComponent();
        }
        
        int x = 1;
        private void previous_Clicked(object sender, EventArgs e)
        {

            Random random = new Random();
            int randomIndex = random.Next(randomOpinion.Length);
            string randomString = randomOpinion[randomIndex];
            Opinion.Text = "Opinie:"+ " " + randomString;

            int randomIndex2 = random.Next(randomOpinion.Length);
            string randomString2 = randomRate[randomIndex2];
            Rate.Text = "Gwiazdki:" + " " + randomString2;

            int randomIndex3 = random.Next(randomOpinion.Length);
            string randomString3 = randomCost[randomIndex3];
            Cost.Text = "Koszt dostawy:" + " " + randomString3;

            if (x == 1)
            {
                x = 3;
                shop.Source = "mc";
            }
            else
            {
                x = x - 1;
                switch (x)
                {

                    case 1:
                        shop.Source = "wendy";
                        break;
                    case 2:
                        shop.Source = "kfc";
                        break;
                    case 3:
                        shop.Source = "mc";
                        break;
                    
                }

            }
        }

        private void next_Clicked(object sender, EventArgs e)
        {

            Random random = new Random();
            int randomIndex = random.Next(randomOpinion.Length);
            string randomString = randomOpinion[randomIndex];
            Opinion.Text = "Opinie:" + " " + randomString;

            int randomIndex2 = random.Next(randomOpinion.Length);
            string randomString2 = randomRate[randomIndex2];
            Rate.Text = "Gwiazdki:" + " " + randomString2;

            int randomIndex3 = random.Next(randomOpinion.Length);
            string randomString3 = randomCost[randomIndex3];
            Cost.Text = "Koszt dostawy:" + " " + randomString3;


            if (x == 3)
            {
                x = 1;
                shop.Source = "wendy";
            }
            else
            {
                x = x + 1;
                switch (x)
                {
                    case 1:
                        shop.Source = "wendy";
                        break;
                    case 2:
                        shop.Source = "kfc";
                        break;
                    case 3:
                        shop.Source = "mc";
                        break;
                    
                }

            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if(x == 1)
            {
                await Navigation.PushAsync(new Page1());
            }
            if (x == 2)
            {
                await Navigation.PushAsync(new Page2());
            }
            if (x == 3)
            {
                await Navigation.PushAsync(new Page3());
            }

        }
    }
}
