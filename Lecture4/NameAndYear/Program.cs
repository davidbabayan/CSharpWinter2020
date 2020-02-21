using System;

namespace NameAndYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            Console.WriteLine($"My name is {Console.ReadLine()}!");
            Console.Write("How old are you?");
            Console.WriteLine($"You are {Console.ReadLine()} years old!");
        }
    }
}

//1. Ask a question "What is your name?" +
//2. Print "My Name is {User Response}!" +
//3. Ask a question "What is your age?"
//4. Print "You are {User Response} years old!"