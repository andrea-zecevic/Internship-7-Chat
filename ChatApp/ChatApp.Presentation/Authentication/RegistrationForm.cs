using ChatApp.Data.Entities.Models;
using ChatApp.Domain.Factories;
using ChatApp.Domain.Repositories;
using System.Text.RegularExpressions;
using ChatApp.Presentation.Views;

namespace ChatApp.Presentation.Authentication
{
    public class RegistrationForm
    {
        public void Show()
        {

            Console.WriteLine("\n--- Registration ---");

            Console.Write("Unesite korisničko ime: ");
            var userName = Console.ReadLine();

            Console.Write("Unesite e-mail: ");
            var email = Console.ReadLine();

            if (!IsValidEmail(email))
            {
                Console.WriteLine("E-mail nije u ispravnom formatu.");
                return;
            }

            Console.Write("Unesite lozinku: ");
            var password = Console.ReadLine();

            Console.Write("Potvrdite lozinku: ");
            var confirmPassword = Console.ReadLine();

            if (password != confirmPassword)
            {
                Console.WriteLine("Lozinke se ne poklapaju.");
                return;
            }

            var captcha = GenerateCaptcha();
            Console.WriteLine($"Molimo unesite sljedeći tekst za potvrdu da niste bot: {captcha}");
            var captchaInput = Console.ReadLine();

            if (captchaInput != captcha)
            {
                Console.WriteLine("Captcha nije ispravno unesena.");
                return;
            }

            if (CheckIfUserExists(email))
            {
                Console.WriteLine("Korisnik s ovim e-mailom već postoji.");
                return;
            }

            var newUser = new User(userName, email, password);

            var userRepository = RepositoryFactory.Create<UserRepository>();
            var result = userRepository.Add(newUser);

            if (result == Domain.Enums.ResponseResultType.Success)
            {
                Console.WriteLine("Registracija uspješna!");
            }
            else
            {
                Console.WriteLine("Došlo je do pogreške prilikom registracije.");
            }

        }

        private static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private static string GenerateCaptcha()
        {
            var random = new Random();
            var captcha = new char[6];
            for (int i = 0; i < captcha.Length; i++)
            {
                captcha[i] = i % 2 == 0 ? (char)('A' + random.Next(0, 26)) : (char)('0' + random.Next(0, 10));
            }
            return new string(captcha);
        }
        private bool CheckIfUserExists(string email)
        {
            var userRepository = RepositoryFactory.Create<UserRepository>();
            var user = userRepository.GetByEmail(email);
            return user != null;
        }
    }

}


