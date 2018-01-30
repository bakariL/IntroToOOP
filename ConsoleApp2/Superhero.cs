using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Superhero
    {
        //STATES FEilds
        private bool isStrong ;
        private string hasCape;
        private int age;
        private string height;
        //Properties
        public bool Strength
        {
            get { return this.isStrong; }
            set { this.isStrong = value; }
        }

        public string favColor
        {
            get { return this.hasCape; }
            set { this.hasCape = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string homeAddress
        {
            get { return this.height; }
            set { this.height = value; }
        }
        //Constructors/behaviors

        public Superhero()
        {
            //default constructor, 
            //takes no parameters (nothing in the ()'s)
        }

        public Superhero(string hasCape, int age, string height, bool strength)
        {
            this.hasCape = hasCape;
            this.age = age;
            this.height = height;
            this.Strength = strength;
        }
        //Methods

        public void Health ()
        {
            if (Strength)
            {
                Console.WriteLine("Toooo STRONG!");
            }
            else
            {
                Console.WriteLine("Your energy is running out!...");
            }
        }

        public void Power()

        {
            if (height == "tall")
            {
                Console.WriteLine("POWER UP! ");
            }

            else
            {
                Console.WriteLine("You need more power now! ");

            }
        }
}
}
