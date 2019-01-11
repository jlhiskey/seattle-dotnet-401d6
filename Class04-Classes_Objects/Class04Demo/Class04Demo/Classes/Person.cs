using System;
using System.Collections.Generic;
using System.Text;

namespace Class04Demo.Classes
{
    class Person
    {
        public Person(string name,string favoriteColor)
        {

        }

        public Person(string favoriteColor)
        {

        }

        public Person(int age)
        {


        }

        public Person(double number)
        {

        }

       

        public Person(string name, int age)
        {

        }

        public Person()
        {

        }

        public string Name { get; set; } = "Amanda";


        // Old school way (prior to C# 6 to get/set properties
        private string favoriteColor;
        public string FavoriteColor
        {
            get
            {
                return favoriteColor;
            }
            set
            {
                favoriteColor = value;
            }
        }

        private int _age = 18;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 18)
                {
                    _age = value;
                }
                
             
            }
        }

        private string _middleName;
        public string MiddleName
        {
            get
            {
                return _middleName != null ? _middleName : "N/A";
            }
            set
            {
                _middleName = value;
            }
        }

        private int _number;
        public int Number
        {
            get
            {
                return _number++;
            }
        }


        public void Speak(string comment)
        {
            Console.WriteLine(comment);
        }

        public void Eat()
        {
            Console.WriteLine($"I am very hungry!!! Cupcakes!");
        }
    }
}
