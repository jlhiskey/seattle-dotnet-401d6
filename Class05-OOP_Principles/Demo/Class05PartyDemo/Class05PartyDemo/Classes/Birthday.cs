using System;

namespace Class05PartyDemo.Classes
{
    // Birthday is derived from the base class party
    abstract class Birthday : Party
    {
        protected int NumberOfPresents { get; set; }
        public virtual bool HasClown { get; set; } = true;
        public int BirthdayCandles { get; set; }

        public void BlowOutCandles()
        {
            Console.WriteLine("Happy Birthday");
        }
    }
}
