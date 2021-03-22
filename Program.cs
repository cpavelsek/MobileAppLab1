using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<ITalkable> zoo = new List<ITalkable>();
            

            // Lines to Replace Begin Here
            zoo.Add(new Dog(true, "Bean"));
            zoo.Add(new Cat(9, "Charlie"));
            zoo.Add(new Teacher(44, "Stacy Read"));

            AnimalBuilder newAnimal = new AnimalBuilder(zoo);
            // End Lines to Replace

            foreach (ITalkable thing in zoo)
            {
                printOut(thing);
            }

        }

        public static void printOut(ITalkable p)
        {
            Console.WriteLine(p.GetName() + " says " + p.Talk());
 
        }
    }
}
