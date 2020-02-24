using System;

namespace MathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var variable = "14";
            
            Console.WriteLine(Math.Abs(Double.Parse(Console.ReadLine())));

            Console.WriteLine(Math.Ceiling(Double.Parse(Console.ReadLine())));

            Console.WriteLine((5.0).Equals(Double.Parse(Console.ReadLine())));

            Console.WriteLine(Math.Exp(Double.Parse(Console.ReadLine())));

            Console.WriteLine(Math.Floor(Double.Parse(Console.ReadLine())));

            Console.WriteLine(Math.Max(Double.Parse(Console.ReadLine()), 5.0));

            Console.WriteLine(Math.Pow(2, 4));

            Console.WriteLine(Math.Round(Double.Parse(Console.ReadLine())));

            Console.WriteLine(Math.Sign(Double.Parse(Console.ReadLine())));

            Console.WriteLine(Math.Sqrt(Double.Parse(Console.ReadLine())));
        }
    }
}
