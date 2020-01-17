using System;

namespace Method_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var yourName =Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
           var favoriteColor = Console.ReadLine();
            Console.WriteLine("Name an animal");
            var animalName = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            var bandName = Console.ReadLine();

            Console.WriteLine($"Your name is {yourName} , and you turn the color {favoriteColor} " +
                $"when listening to {bandName} with {animalName}");


        }
    }
}
