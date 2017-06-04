using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SQLiteExample
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Clues : ContentPage
    {
        //definovani promennych
        int retired = 10;
        int position = 10;
        int nationality = 15;
        int picture = 20;
        TodoItem todoItem;
        User user1;
        public Clues(User user) //data uzivatele
        {
            user1 = user;
            InitializeComponent();
            userCoins.Text = "Your coins: " + user.Coins;
            userLevel.Text = "Your level: " + user.Level; 
        }
        private void buttonStatusClicked(object sender, EventArgs e) // zobrazeni napovedy
        {
            if(user1.Coins >= retired)
            {
                var status = App.Database.GetItemsNotDoneAsync(user1.Level).Result;
                foreach (TodoItem todoItem in status)
                {
                    echo.Text = "Is player retired? " + todoItem.Retired.ToString();
                }
                user1.Coins = user1.Coins - retired;
                userCoins.Text = "Your coins: " + user1.Coins;
            }
            else
            {
                echo.Text = "You dont have enough coins";
            }   
        }
        private void buttonPositionClicked(object sender, EventArgs e)
        {
            if (user1.Coins >= position)
            {
                var status = App.Database.GetItemsNotDoneAsync(user1.Level).Result;
                foreach (TodoItem todoItem in status)
                {
                    echo.Text = "Players position: " + todoItem.Position;
                }
                user1.Coins = user1.Coins - position;
                userCoins.Text = "Your coins: " + user1.Coins;
            }
            else
            {
                echo.Text = "You dont have enough coins";
            }
        }
        private void buttonNationalityClicked(object sender, EventArgs e)
        {
            if (user1.Coins >= nationality)
            {
                var status = App.Database.GetItemsNotDoneAsync(user1.Level).Result;
                foreach (TodoItem todoItem in status)
                {
                    echo.Text = "Players nationality: " + todoItem.Nationality;
                }
                user1.Coins = user1.Coins - nationality;
                userCoins.Text = "Your coins: " + user1.Coins;
            }
            else
            {
                echo.Text = "You dont have enough coins";
            }
        }
        private void buttonPictureClicked(object sender, EventArgs e)
        {
            if (user1.Coins >= picture)
            {
                var status = App.Database.GetItemsNotDoneAsync(user1.Level).Result;
                foreach (TodoItem todoItem in status)
                {
                    echoPicture.Source = ImageSource.FromUri(new Uri(todoItem.Picture));
                }
                user1.Coins = user1.Coins - picture;
                userCoins.Text = "Your coins: " + user1.Coins;
            }
            else
            {
                echo.Text = "You dont have enough coins";
            }
        }
    }
}
