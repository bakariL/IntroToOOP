using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Dog
    {
        // STATES
        //fields
        private string hairLength;
        private string height;
        private string runningSpeed;
        private string weight;

        //Properties
        public string Name
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }

        //Constructors
        public Dog()
        {
            // defualt
        }

        public Dog(string hairLength, string height, string runningSpeed, string weight)
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;

        }
        //method

        public void Run()
        {
            if (runningSpeed == "fast")
            {
                Console.WriteLine("The dog is " + runningSpeed);
            }
            else
            {
                Console.WriteLine("This dog is out of shape!");
            }

        }
        public void Bark()
        {
            if (hairLength == "long")
            {
                Console.WriteLine("\a");
            }
            else
            {
                Console.WriteLine("this is one quite dog");
            }
        }
        public void Potty()
        {
            if (weight == "fat")
            {
                Console.WriteLine("This" + weight + "needs to potty!");
            }
            else
            {
                Console.WriteLine("Somebody feed this dog!");
            }

        }
        public void Cuddle()
        {
            if (height == "tall")
            {
                Console.WriteLine("This is a " + height);
            }
            Console.WriteLine("The dog is " + height);
        }
    }
}
