using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"My name is {name}. I have a dream of riding a {color} {animal} while listening to {band}.");

            Console.WriteLine(Sum(3, 2, 54, 66, 31));
        }

        public static int Sum(params int[] list)
        {
            var sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum += list[i];
            }
            return sum;
        }
    }
}
