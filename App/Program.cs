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
    }
}
