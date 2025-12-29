using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ادخل اسمك:");
        string name = Console.ReadLine();

        Console.WriteLine("ادخل عمرك:");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine($"مرحبا {name}، عمرك {age} سنة");

        if (age >= 18)
            Console.WriteLine("أنت بالغ ✅");
        else
            Console.WriteLine("أنت قاصر ❌");
    }
}
