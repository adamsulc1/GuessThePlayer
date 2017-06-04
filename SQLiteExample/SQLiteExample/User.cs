using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteExample
{
    public class User
    {
        public User(int coins, int level)
        {
            _coins = coins;
            _level = level;
        }
        private int _coins;
        public int Coins
        {
            get { return _coins; }
            set { _coins = value; }
        }
        private int _level;
        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }
    }

    public class Uzivatel
    {
        public Uzivatel(int coins, int level)
        {
            _coins = coins;
            _level = level;
        }
        private int _coins;
        public int Coins
        {
            get { return _coins; }
            set { _coins = value; }
        }
        private int _level;
        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }

        public Vysledek Hádá_Vysledek
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
