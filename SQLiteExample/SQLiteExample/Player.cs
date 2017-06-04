using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteExample
{
    public class Player
    {
        public Player(string name, string nationality, bool retired, int level, string clubs)
        {
            _name = name;
            _nationality = nationality;
            _retired = retired;
            _level = level;
            _clubs = clubs;
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _nationality;
        public string Nationality
        {
            get { return _nationality; }
            set { _nationality = value; }
        }
        private bool _retired;
        public bool Retired
        {
            get { return _retired; }
            set { _retired = value; }
        }
        private int _level;
        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }
        private string _clubs;
        public string Clubs
        {
            get { return _clubs; }
            set { _clubs = value; }
        }
    }

    public class Hrac
    {
        public Hrac(string name, string nationality, bool retired, int level, string clubs)
        {
            _name = name;
            _nationality = nationality;
            _retired = retired;
            _level = level;
            _clubs = clubs;
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _nationality;
        public string Nationality
        {
            get { return _nationality; }
            set { _nationality = value; }
        }
        private bool _retired;
        public bool Retired
        {
            get { return _retired; }
            set { _retired = value; }
        }
        private int _level;
        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }
        private string _clubs;
        public string Clubs
        {
            get { return _clubs; }
            set { _clubs = value; }
        }

        public Vysledek Spravne_jmeno
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
