using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma();
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("First Value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second Value: ");
            float v2 = float.Parse(Console.ReadLine());
            float sum = v1 + v2;


            Console.WriteLine($"The result of {v1} + {v2} is: {sum}.");
        }
    }
}