using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu() 
        {
            Console.WriteLine("Chose your operation: ");
            Console.WriteLine("1 - Sum ");
            Console.WriteLine("2 - Subtract ");
            Console.WriteLine("3 - Divide ");
            Console.WriteLine("4 - Multiplication ");
            Console.WriteLine("5 - Exit ");
            Console.WriteLine("---------------");
            Console.WriteLine(" ");
            
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Sum(); break;
                case 2: Subtract(); break;
                case 3: Divide(); break;
                case 4: Multiplication(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
               
        }
        static void Sum()
        {
            Console.Clear();
            Console.WriteLine("First Value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second Value: ");
            float v2 = float.Parse(Console.ReadLine());
            float sum = v1 + v2;


            Console.WriteLine($"The result of {v1} + {v2} is: {sum}.");

            Console.ReadKey();
            Menu();
        }

        static void Subtract()
        {
            Console.Clear();
            
            Console.WriteLine("First value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"The result of {v1} - {v2} is {v1 - v2}.");

            Console.ReadKey();
            Menu();
        }

        static void Divide()
        {
            Console.Clear();

            Console.WriteLine("First value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"The result of {v1} / {v2} is {v1 / v2}.");

            Console.ReadKey();
            Menu();
        }

        static void Multiplication()
        {
            Console.Clear();

            Console.WriteLine("First value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"The result of {v1} * {v2} is {v1 * v2}.");

            Console.ReadKey();
            Menu();
        }
    }
}