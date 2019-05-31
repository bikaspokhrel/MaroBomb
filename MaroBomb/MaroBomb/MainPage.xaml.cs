using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MaroBomb
{
    public partial class MainPage : ContentPage
    {
        private static string bomb = new Random().Next(1, 4).ToString();
        private static int scores = 0;// varible with zero value
        public MainPage()
        {
            InitializeComponent();
        }
        async void ButtonClicked(object sender, EventArgs e)// void because we are not returning anything
        {
            Button button = sender as Button; //We can access attribute of our button now we are going to check whether user clicked the button with bomb or not
            //Game over if..
            if(button.Text == bomb) //this will execute if button clicked equls to the randomly assigned bomb
            {
                await DisplayAlert("Bomb Exploded", "Game Over", "Retry"); //Call display alert with title Bomb Exploded and message Game Over
                bomb = new Random().Next(1, 4).ToString();   
            }
            else
            {
                scores += 1;
                await DisplayAlert("Bomb Defused", "Scores " + scores, "Continue");
                bomb = new Random().Next(1, 4).ToString();
            }

        }
    }
}
