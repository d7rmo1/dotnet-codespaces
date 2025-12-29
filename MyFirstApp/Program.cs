using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== My First C# App ===");

        while (true)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            bool isValidAge = int.TryParse(Console.ReadLine(), out int age);

            if (!isValidAge)
            {
                Console.WriteLine("❌ Age must be a number.");
                continue;
            }

            if (age < 18)
            {
                Console.WriteLine($"Hello {name}, you are under 18.");
            }
            else
            {
                Console.WriteLine($"Welcome {name}, you are an adult.");
            }

            Console.Write("Do you want to try again? (y/n): ");
            string choice = Console.ReadLine().ToLower();

            if (choice != "y")
            {
                Console.WriteLine("Goodbye 👋");
                break;
            }
        }
    }
}
