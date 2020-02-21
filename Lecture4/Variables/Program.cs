using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //ամբողջ թվեր int
            int i = 34;
            //կոտորակային թվեր double
            double d = 12.5;
            //այո/ոչ արժեք bool
            bool b = true; //true/false
            //սիմվոլներ char
            char ch = 'c';
            //տեքստ string
            string s = "Some Text";

            //Printing Name and Age
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            
            Console.Write("How old are you? ");
            int age = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine($"Your name is {name} and you are {age} years old!");

            //Arithmetic operations

            // գումարում +
            // հանում -
            // բաժանում /
            // բազմապատկում *
            // մնացորդ %

            Console.WriteLine("Hello, " + "World!");
        }
    }
}
