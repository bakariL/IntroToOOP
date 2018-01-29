using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Cat
    {
        // STATES
        //fields
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;

        //Properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string HairLength
        {
            get {  return this.name; }
            set { this.name = value; }
        }
        //Constructors
        public Cat()
        {
            //default constructor
            //takes no parameters (nothing in the ()'s)
        }

        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }
        //method
        public void Eat()
        {
            if(isHungry)
            {
                isHungry = false;
            }
            Console.WriteLine("Is the cat hungry? "+ isHungry);
        }

        public void Meow()
        {
            Console.WriteLine("\a");
        }

        public string Hairball()
        {
            if (HairLength == "too long")
            {
                return (this.name + "has a bairball");
            }else
            {
                return (this.name + "alsjdflkaj");
            }
        }
        
    }

}

