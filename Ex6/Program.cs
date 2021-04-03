using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "Hello";
            string secondString = "World";
            object greeting = firstString + " " + secondString;

            Console.WriteLine(greeting);

            string thirdString = (string)greeting;
        }
    }
}
