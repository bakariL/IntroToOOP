using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro_to_Oop

{
    class Program
    {
        static void Main(string[] args)
        {
            Cat firstCat = new Cat();
            firstCat.Name = "Mr. Fuzzy";

            Cat secondCat = new Cat("Midnight", 14, "black");

            Console.WriteLine(firstCat.Name);
            Console.WriteLine(secondCat.Name);
            Console.WriteLine();

            firstCat.Eat();

            secondCat.Meow();

            Dog firstDog = new Dog();
            firstDog.Name = "Big DOg";

            firstDog.Cuddle();

            firstCat.HairLength = "Nice and Short";
            secondCat.HairLength = "too long";

            Console.WriteLine(firstCat.Hairball());
            Console.WriteLine(secondCat.Hairball());

        }
    }
}
