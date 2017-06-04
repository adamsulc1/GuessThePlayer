using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SQLiteExample
{
    public partial class NewGame : ContentPage
    {
        //Player player1;
        User user1;
        TodoItem todoItem = new TodoItem();
        Players players = new Players();
        int clue = 5;

        public NewGame()
        {
            InitializeComponent();
            //osetreni proti opakovani zaznamu v databazi
            var count = App.Database.GetItemsNotDoneAsync2().Result.Count;
            if (count <= 0)
            {
                players.database_players();
            }
           // players.database_players();
             user1 = new User(0,1);
             ShowClubs();
            
              
        }

        private void ButtonClicked(object sender, EventArgs e) // overeni zda hrac zadal spravne jmeno
        {
            var result = App.Database.GetItemsNotDoneAsync(user1.Level).Result;
            foreach (TodoItem todoItem in result)
            {
                var text = userInput.Text;
                if (text == todoItem.Name)
                {
                    guess.Text = "You got it!";
                    user1.Coins = user1.Coins + clue;
                    ShowPicture();
                    user1.Level++;
                    userLevel.Text = "Level: " + user1.Level;
                    ShowClubs();
                }
                else
                {
                    guess.Text = "Try again!";
                }
            }
            if (user1.Level == 9)
            {
                guess.Text = "Congratulation! You have finished stage 1";
            }
        }
        void ShowClubs() // funkce pro vypsani klubu fotbalisty 
        {
                playerClubs.Text = todoItem.Clubs;
                var clubs = App.Database.GetItemsNotDoneAsync(user1.Level).Result;
                foreach (TodoItem todoItem in clubs)
                {
                    playerClubs.Text = todoItem.Clubs;
                }
        }
        void ShowPicture() // zobrazeni obrazku z db
        {
                var pictures = App.Database.GetItemsNotDoneAsync(user1.Level).Result;
                foreach (TodoItem todoItem in pictures)
                {
                    playerPicture.Source = ImageSource.FromUri(new Uri(todoItem.Picture));
                }
        }
        private void buttonCluesClicked (object sender, EventArgs e)
        {
            Navigation.PushAsync(new Clues(user1));
        }
        private void buttonGalleryClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Gallery(user1));
        }
    }
}
