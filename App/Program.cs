// See https://aka.ms/new-console-template for more information

using PayPoint_Station.UI;

namespace PayPoint_Station.App
{
    class Program
    {
        static void Main(string[] args)
        {
            AppScreen.Welcome();
        }

         internal static void processUserInput(string userAction)
        {
            switch (userAction)
            {
                case "c":
                   AppScreen.Login();
                    break;
                case "a":
                    AppScreen.CreatingAccound();
                    string cardNumber = GenerateRandomCardNumber();
                    Console.WriteLine(cardNumber);
                    break;
                case "e":
                    ExitProgram();
                    break;
                default:
                    Console.WriteLine("Input Error, please try again.");
                    break;
            }
        }

        static void ExitProgram()
        {
           Environment.Exit(0);
        }

        static string GenerateRandomCardNumber()
    {
        Random random = new Random();

        string prefix = "4";
        int numberOfDigits = 16;

        for (int i = 0; i < numberOfDigits - 1; i++)
        {
            int digit = random.Next(0, 10);
            prefix += digit;
        }

        return prefix;
    }

        static void generateCardPin(){

        }
    }
}
