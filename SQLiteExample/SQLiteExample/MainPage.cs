using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SQLiteExample
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            VerticalTextAlignment = TextAlignment.Center,
                            Text = "Guess the Footballer"
                        },
                        new Button
                        {
                            Text = "Start Game",
                             Command = showPageCommand(new NewGame()),
                             //BorderColor = 
                        },
                    }
            };
        }

        Command showPageCommand(Page page)
        {
            return new Command((() =>
            {
                Navigation.PushAsync(page);
            }));


        }
    }
}
