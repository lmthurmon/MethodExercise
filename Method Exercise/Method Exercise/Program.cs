using System;

namespace Method_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("What is your name?");
             var yourName =Console.ReadLine();
             Console.WriteLine("What is your favorite color?");
            var favoriteColor = Console.ReadLine();
             Console.WriteLine("Name an animal");
             var animalName = Console.ReadLine();
             Console.WriteLine("What is your favorite band?");
             var bandName = Console.ReadLine();

             Console.WriteLine($"Your name is {yourName} , and you turn the color {favoriteColor} " +
                 $"when listening to {bandName} with {animalName} .");
                 */

            Console.WriteLine(FindSum(2, 4));
            Console.WriteLine(FindMultiply(10, 2));
            Console.WriteLine(FindSum(1, 1) * FindMultiply(10, 2));
            Console.WriteLine(MyMoney(2.85, 3.4, 5.2));
        }

        public static int FindSum(int x, int y)
        {
            return x + y;
        }

        public static int FindMultiply(int x, int y)
        {
            return x * y;

        }
        public static double MyMoney(double a, double b, double c)
        {
            return (a * b) / c; 
                }


      
    }
    
}
