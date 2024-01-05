using ChatApp.Presentation.Authentication;
using ChatApp.Presentation.Utils;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Dobrodošli u ChatApp!\n");
        Console.ResetColor();
        Utils.DisplayInstructions();

        while (true)
        {
            ShowMainMenu();
        }
    }

    public static void ShowMainMenu()
    {
        while (true)
        {
            Console.WriteLine("\n--- Main Menu ---\n");

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" 1. Login ");
            Console.ResetColor();
            Console.WriteLine(" 2. Registracija ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" 3. Izlaz ");
            Console.ResetColor();

            Console.Write("\nUnesite svoju akciju: ");
            var choice = Console.ReadKey();

            switch (choice.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    new LoginForm().Show();
                    return;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    new RegistrationForm().Show();
                    return;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nNeispravan unos. Molim pokušajte ponovno.");
                    Utils.WaitForUserInput();
                    continue;
            }
        }
    }
}
