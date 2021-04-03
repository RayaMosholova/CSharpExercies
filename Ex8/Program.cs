using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Age: ");
            byte age = byte.Parse(Console.ReadLine());
            Console.Write("Gender (m or f): ");
            char gender = char.Parse(Console.ReadLine());
            Console.Write("Personal ID number: ");
            long personalIdNumber = long.Parse(Console.ReadLine());
            Console.Write("Unique employee number: ");
            int uniqueEmployeeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {personalIdNumber}");
            Console.WriteLine($"Unique Employee number: {uniqueEmployeeNumber}");
        }
    }
}
