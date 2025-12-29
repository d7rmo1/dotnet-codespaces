using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            ShowMenu();

            Console.Write("اختر رقم: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShowSystemInfo();
                    break;

                case "2":
                    ShowUserInfo();
                    break;

                case "0":
                    Console.WriteLine("👋 تم الخروج من الأداة");
                    return;

                default:
                    Console.WriteLine("❌ اختيار غير صحيح");
                    break;
            }

            Console.WriteLine("\nاضغط Enter للمتابعة...");
            Console.ReadLine();
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("=== MyFirstTool v1.0 ===");
        Console.WriteLine("1 - عرض معلومات النظام");
        Console.WriteLine("2 - عرض معلومات المستخدم");
        Console.WriteLine("0 - خروج");
        Console.WriteLine("========================");
    }

    static void ShowSystemInfo()
    {
        Console.WriteLine("\n🖥️ معلومات النظام:");
        Console.WriteLine($"OS: {Environment.OSVersion}");
        Console.WriteLine($"64-bit OS: {Environment.Is64BitOperatingSystem}");
        Console.WriteLine($"Processors: {Environment.ProcessorCount}");
    }

    static void ShowUserInfo()
    {
        Console.WriteLine("\n👤 معلومات المستخدم:");
        Console.WriteLine($"User Name: {Environment.UserName}");
        Console.WriteLine($"Machine Name: {Environment.MachineName}");
        Console.WriteLine($"Current Directory: {Environment.CurrentDirectory}");
    }
}
