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
                    Console.WriteLine("Continue");
                    break;
                case "a":
                    Console.WriteLine("Crating new account");
                    break;
                case "e":
                    Console.WriteLine("exit");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
