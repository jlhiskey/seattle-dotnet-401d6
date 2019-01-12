using System;
using System.Collections.Generic;
using System.Text;

namespace Class05PartyDemo.Classes
{
    abstract class Party
    {
        public int MaxNumberOfGuests { get; set; }
        public string Venue { get; set; }
        public string[] Menu { get; set; }
        public double Budget { get; set; }

        public virtual string Setup()
        {
            return "Setup All the stuffs";
        }

       public bool TearDown()
        {
            Console.WriteLine("Tear Down the Party");
            return true;

        }

        public abstract void PlayGames();
    }
}
