using System;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Compare("AHello World!", "Helllo"));

            Console.WriteLine(String.CompareOrdinal("AHello World!", "AHelllo"));

            Console.WriteLine(String.Concat("AHello World!", "Helllo"));

            Console.WriteLine(String.Empty);

            Console.WriteLine(String.IsNullOrEmpty("AHello World!"));

            Console.WriteLine(String.IsNullOrWhiteSpace(" "));

            Console.WriteLine(String.Join(" ", "I", "Learn", "Programming"));

            Console.WriteLine("Hello World!".IndexOf('e'));

            Console.WriteLine("Hello World!".Insert(3, "go"));

            Console.WriteLine("Hello World!".Length);

            Console.WriteLine("Hello World!".Remove(3, 3));

            Console.WriteLine("Hello World!".Replace("el", "io"));

            Console.WriteLine("Hello World!".StartsWith("Hed"));

            Console.WriteLine("Hello World!".Substring(4, 3));

            Console.WriteLine("Hello World!".ToLower());
            Console.WriteLine("Hello World!".ToUpper());
        }
    }
}
