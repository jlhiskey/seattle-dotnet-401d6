using System;
using System.Collections.Generic;
using System.Text;

namespace Class05PartyDemo.Classes
{
    class Football : Party
    {
        public int TvSize { get; set; }
        public  bool Nachos { get; set; }

        public void Cheering(string cheer)
        {
            Console.WriteLine(cheer);
        }
    }
}
