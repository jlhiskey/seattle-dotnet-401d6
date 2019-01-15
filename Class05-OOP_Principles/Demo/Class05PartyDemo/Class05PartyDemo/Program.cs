using Class05PartyDemo.Classes;
using System;

namespace Class05PartyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BirthdayParty();
        }

        static void BirthdayParty()
        {
            //Birthday birthday = new Birthday();
            //birthday.Venue = "Disneyland";

           //string venue =  birthday.Venue;

            Console.WriteLine(venue);

            TwentyOnePlus top = new TwentyOnePlus();

            //Party party = new Party();

            Party party = new TwentyOnePlus();

            Quack quack = new Quack();

            top.Goober(quack);

            // an array of parties
            // top is a 21+ Birthdya party
            // quack is a football party
            Party[] parties = { top, quack };

            for (int i = 0; i < parties.Length; i++)
            {
                if(parties[i] is Football)
                {
                    // Do something
                } else if(parties[i] is Birthday )
                {

                }
            }
        }
    }
}
