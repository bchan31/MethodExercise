using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Questions();
            Add(3, 2, 54, 66, 31);
            Multiply(4, 2, 5);

            Add(5.1m, 7.2m);
            Add(3, 5, true);
            Add(1, 0, true);
            Add(54, 22, false);
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

        public static void Add(params int[] list)
        {
            var sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum += list[i];
            }
            Console.WriteLine(sum);
        }

        public static void Add(params decimal[] list)
        {
            var sum = 0m;
            for (int i = 0; i < list.Length; i++)
            {
                sum += list[i];
            }
            Console.WriteLine(sum);
        }

        public static void Add(int x, int y, bool isNeeded)
        {
            int answer = x + y;
            if(isNeeded == true)
            {
                if(answer != 1)
                {
                    Console.WriteLine(x + y + " dollars");
                }
                else
                {
                    Console.WriteLine(x + y + " dollar");
                }
            }
            else
            {
                Console.WriteLine("It is not needed");
            }
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
