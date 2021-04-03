using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string number1 = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(number1, 16));
        }
    }
}
