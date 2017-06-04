using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SQLiteExample
{
    public partial class Gallery : ContentPage
    {
        User user1;
        TodoItem todoItem;
        public Gallery(User user)
        {
            InitializeComponent();
            user1 = user;
            ShowPictures();
        }
        public void ShowPictures()
        {
            int level = user1.Level;
            if (user1.Level < 2)
            {
                playerName.Text = "There are no players in your gallery yet.";
            }
            //var pictures = App.Database.GetItemsNotDoneAsync3(user1.Level).Result;
            ObservableCollection<TodoItem> pictures = new ObservableCollection<TodoItem>(
                 App.Database.GetItemsNotDoneAsync3(user1.Level).Result
            );
            foreach (TodoItem todoItem in pictures)
            {
                playerName.Text = todoItem.Name + "    Level: " + todoItem.Level;
                playerPicture.Source = ImageSource.FromUri(new Uri(todoItem.Picture));
            }
            /*var pictures = App.Database.GetItemsNotDoneAsync(user1.Level - 1).Result;
            foreach (TodoItem todoItem in pictures)
            {
                playerName.Text = todoItem.Name + "    Level: " + todoItem.Level;
                playerPicture.Source = ImageSource.FromUri(new Uri(todoItem.Picture));
            }   */
        }
    }
}
