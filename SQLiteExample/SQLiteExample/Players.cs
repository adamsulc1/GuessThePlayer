using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteExample
{
    class Players
    {
        TodoItem item;
        public void database_players() // funkce pro pridavani hracu do db
        {
            item = new TodoItem();
            item.Name = "Ronaldo";
            item.Nationality = "Portugal";
            item.Retired = false;
            item.Level = 1;
            item.Clubs = "Sporting Lisabon -> Manchester United -> Real Madrid";
            item.Picture = "http://cdn.gay.it/foto_articoli/originali/cr/cristiano_ronaldo_svenduto_dal_real_madrid.jpg";
            item.Position = "Left wing";
            App.Database.SaveItemAsync(item);

            item = new TodoItem();
            item.Name = "Messi";
            item.Nationality = "Argentina";
            item.Retired = false;
            item.Level = 2;
            item.Clubs = "Barcelona";
            item.Picture = "http://images.performgroup.com/di/library/GOAL_INTERNATIONAL/c2/97/hd-lionel-messi-barcelona_5toanmhsh09f11z1b8ucasj4p.jpg?t=1838656488&w=620&h=430";
            item.Position = "Right wing";
            App.Database.SaveItemAsync(item);

            item = new TodoItem();
            item.Name = "Neymar";
            item.Nationality = "Barcelona";
            item.Retired = false;
            item.Level = 3;
            item.Clubs = "Santos -> Barcelona";
            item.Picture = "http://images.performgroup.com/di/library/GOAL/40/4a/neymar-barcelona-2017_lrjlxis5zpt13wztjji2gwuw.jpg?t=-884324711&w=620&h=430";
            item.Position = "Left wing";
            App.Database.SaveItemAsync(item);

            item = new TodoItem();
            item.Name = "Bale";
            item.Nationality = "Wales";
            item.Retired = false;
            item.Level = 4;
            item.Clubs = "Southampton -> Tottenham -> Real Madrid";
            item.Picture = "https://upload.wikimedia.org/wikipedia/commons/6/6a/Gareth_Bale_2015_%281%29.jpg";
            item.Position = "Right wing";
            App.Database.SaveItemAsync(item);

            item = new TodoItem();
            item.Name = "Pele";
            item.Nationality = "Brasil";
            item.Retired = true;
            item.Level = 5;
            item.Clubs = "Santos -> New York Cosmos";
            item.Picture = "http://img.fifa.com/mm/photo/tournament/competition/02/30/44/42/2304442_full-lnd.jpg";
            item.Position = "Striker";
            App.Database.SaveItemAsync(item);

            item = new TodoItem();
            item.Name = "Maradona";
            item.Nationality = "Argentina";
            item.Retired = true;
            item.Level = 6;
            item.Clubs = "Boca Juniors -> Barcelona -> Neapol -> Sevilla -> Boca Juniors";
            item.Picture = "http://citaty.net/media/authors/diego-maradona.jpg";
            item.Position = "Attacking midfileder";
            App.Database.SaveItemAsync(item);

            item = new TodoItem();
            item.Name = "Ibrahimovic";
            item.Nationality = "Sweden";
            item.Retired = false;
            item.Level = 7;
            item.Clubs = "Malmo -> Ajax -> Juventus -> Inter -> Barcelona -> AC Milan -> PSG -> Manchester United";
            item.Picture = "https://platform-static-files.s3.amazonaws.com/premierleague/photos/players/250x250/p9808.png";
            item.Position = "Center midfielder";
            App.Database.SaveItemAsync(item);

            item = new TodoItem();
            item.Name = "Gerrard";
            item.Nationality = "England";
            item.Retired = true;
            item.Level = 8;
            item.Clubs = "Liverpool -> LA Galaxy";
            item.Picture = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/61/The_big_4-0.jpg/800px-The_big_4-0.jpg";
            item.Position = "Center midfielder";
            App.Database.SaveItemAsync(item);

        }
       public async void Add_Player(TodoItem item) // funkce, ktera kontroluje zda je hrac uz v databazi
        {
            var result = await App.Database.GetItemsNotDoneAsync2();
            foreach(TodoItem todoItem in result)
            {
                if (item.Name != todoItem.Name)
                {
                    await App.Database.SaveItemAsync(item);
                } 
            }
        }
    }

    public class players
    {
        public Hrac Informace_pro_hrace
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}
