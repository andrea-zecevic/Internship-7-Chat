using ChatApp.Presentation.Authentication;
using ChatApp.Presentation.Utils;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dobrodosli u ChatApp!\n");
        Utils.DisplayInstructions();

        while (true)
        {
            ShowMainMenu();
        }
    }

    private static void ShowMainMenu()
    {
        Console.WriteLine("\n--- Main Menu ---");
        Console.WriteLine("1. Login");
        Console.WriteLine("2. Registracija");
        Console.WriteLine("3. Izlaz");

        Console.Write("\nUnesi svoju akciju: ");
        var choice = Console.ReadKey();

        switch (choice.Key)
        {
            case ConsoleKey.D1:
            case ConsoleKey.NumPad1:
                new LoginForm().Show();
                break;
            case ConsoleKey.D2:
            case ConsoleKey.NumPad2:
                new RegistrationForm().Show();
                break;
            case ConsoleKey.D3:
            case ConsoleKey.NumPad3:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("\nNeispravan unos. Molim pokusajte ponovno.");
                Utils.WaitForUserInput();
                break;
        }
    }
}
