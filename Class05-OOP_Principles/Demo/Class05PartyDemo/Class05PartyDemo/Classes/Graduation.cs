using System;
using System.Collections.Generic;
using System.Text;

namespace Class05PartyDemo.Classes
{
    class Graduation : Party
    {
        public string Diploma { get; set; }
       
        string Speech()
        {
            return "We are AMAZING!"; 
        }
    }
}
