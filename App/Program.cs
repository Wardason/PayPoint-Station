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
                    int pinNumber = generateCardPin();
                    Console.WriteLine(pinNumber);
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

        static int generateCardPin(){
            Random random = new Random();
            return random.Next(1000, 10000);
        }

        internal static bool IsValidDate(string dateStr, string format)
    {
        DateTime result;
        return DateTime.TryParseExact(dateStr, format, null, System.Globalization.DateTimeStyles.None, out result);
    }
    }
}
