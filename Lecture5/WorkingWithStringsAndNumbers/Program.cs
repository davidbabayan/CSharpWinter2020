using System;

namespace WorkingWithStringsAndNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());

            // Console.WriteLine(num/100);
            // Console.WriteLine(num%100/10);
            // Console.WriteLine(num%10);

            int result = num % 10 * 100 + num % 100 / 10 * 10 + num / 100;

            Console.WriteLine(result);
        }
    }
}
