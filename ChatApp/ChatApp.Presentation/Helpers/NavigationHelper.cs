using ChatApp.Data.Entities.Models;
using ChatApp.Presentation.Views;
namespace ChatApp.Presentation.Helpers
{
    public static class NavigationHelper
    {
        public static void ReturnToDashboard(User currentUser)
        {
            Console.WriteLine("\nPritisnite bilo koju tipku za povratak na Dashboard.");
            Console.ReadKey();
            new DashboardMenu(currentUser).Show();
        }
    }
}
