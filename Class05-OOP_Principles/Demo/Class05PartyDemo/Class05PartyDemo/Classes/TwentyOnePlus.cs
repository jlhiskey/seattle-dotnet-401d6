using System;
using System.Collections.Generic;
using System.Text;

namespace Class05PartyDemo.Classes
{
    class TwentyOnePlus : Birthday
    {
        public int Alcohol { get; set; }

        public override bool HasClown { get; set; } = false;

        public override void PlayGames()
        {
            Console.WriteLine("Play Darts");
        }

        public override string Setup()
        {
            return "We just gonna show up!";
        }

        public string Goober(Football party)
        {
            return party.Nachos.ToString();
        }

    }
}
