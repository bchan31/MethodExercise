using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Questions();
            Sum(3, 2, 54, 66, 31);
            Multiply(4, 2, 5);
        }

        public static void Questions()
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
        }

        public static void Sum(params int[] list)
        {
            var sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum += list[i];
            }
            Console.WriteLine(sum);
        }

        public static void Multiply(params int[] list)
        {
            int answer = 1;
            for (int i = 0; i < list.Length; i++)
            {
                answer *= list[i];
            }
            Console.WriteLine(answer);
        }
    }
}
