using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class AnimalBuilder : ITalkable
    {
        public AnimalBuilder(List<ITalkable> zoo)
        {

            Console.WriteLine("Would you like to create an animal?  ('Q' to quit)");
            var input = Console.ReadLine();

            do
            {

                Console.WriteLine("What type of animal would you like to create? (Cat or Dog)");
                var userAnimal = Console.ReadLine();
               
                //while(string.IsNullOrEmpty(userAnimal) || string.)
            
                    if (userAnimal == "dog" || userAnimal == "Dog")
                    {

                        Console.WriteLine("What is your dogs name? ");
                        var dogName = Console.ReadLine();

                        Console.WriteLine("Is your dog friendly? (true or false) ");
                        var dogFriendly = Console.ReadLine();

                        if (dogFriendly.Equals("true", StringComparison.OrdinalIgnoreCase))
                        {
                            zoo.Add(new Dog(true, dogName));
                        }
                        else if (dogFriendly == "false")
                        {
                            zoo.Add(new Dog(false, dogName));
                        }
                    
                    }

                    else if (userAnimal == "cat" || userAnimal == "Cat")
                    {

                        Console.WriteLine("What is your cats name? ");
                        var catName = Console.ReadLine();

                        Console.WriteLine("How many mice has your cat killed? ");
                        var deadMice = Convert.ToInt32(Console.ReadLine());

                        zoo.Add(new Cat(deadMice, catName));
                    
                    }
                    else 
                    {
                        Console.WriteLine("That wasn't an option. Try again");
                    }

                Console.WriteLine("Would you like to create another animal?  ('Q' to quit)");
                input = Console.ReadLine();

            } while (!input.ToUpper().Equals("Q"));

        }


    }
}
