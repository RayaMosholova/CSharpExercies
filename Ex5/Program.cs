using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            try
            {
                bool newBool = Convert.ToBoolean(input);

                if (newBool)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            catch
            {
                Console.WriteLine("You have inserted invaluid value.");
            }
        }
    }
}
