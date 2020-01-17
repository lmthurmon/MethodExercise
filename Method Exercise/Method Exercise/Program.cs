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

            Console.WriteLine(FindSum(2.2m, 4.6m));
            Console.WriteLine(FindMultiply(10, 2));
            Console.WriteLine(FindSum(1, 1) * FindMultiply(10, 2));
            Console.WriteLine(MyMoney(2.85, 3.4, 5.2));
            Console.WriteLine(GetMax() * FindSum(2, 2));
            FindSum(1, 1, true);
        }

        public static int FindSum(int x, int y)
        {
            return x + y;
        }


        //method can use same name and return type but must have different signature in parameters(value type or number of args)
        public static int FindMultiply(int x, int y)
        {
            return x * y;

        }
        public static double MyMoney(double a, double b, double c)
        {
            return (a * b) / c;
        }
        //can remove retrun type and put Console.Writeline in method by putting public static void(replace return type with void)

        public static int GetMax()
        {
            Console.WriteLine("Enter three numbers to find the greatest value");
            Console.WriteLine("First Number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Third Number");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());


            if (firstNumber > secondNumber)
                return firstNumber;

            else if (thirdNumber > secondNumber)
                return thirdNumber;
            else
                return secondNumber;


        }
        //method overload example of FindSum
        public static decimal FindSum(decimal x, decimal y)
        {
            return x + y;
        }

        public static void FindSum(int x, int y, bool z)

        {
            if (z == true)
            {
                Console.WriteLine(x + y + " Dollars");
            }
            else
            {
                Console.WriteLine(x + y + "Dollar");
            } 


        }



    }
}

