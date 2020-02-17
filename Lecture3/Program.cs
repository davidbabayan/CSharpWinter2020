using System;
using static System.Console;

namespace Lecture3
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("What is your name? ");
            //Console.ReadLine();
            WriteLine("Hello " + ReadLine() + "!");
        }
    }
}
