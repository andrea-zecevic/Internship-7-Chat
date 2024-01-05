namespace ChatApp.Presentation.Utils
{
    public static class Utils
    {
        public static void DisplayInstructions()
        {
            Console.WriteLine("Upute:\n - Koristite brojeve za navigaciju izbornikom.");
        }

        public static void WaitForUserInput()
        {
            Console.WriteLine("Pritisni bilo koju tipku za nastavak...");
            Console.ReadKey();
        }
    }
}
