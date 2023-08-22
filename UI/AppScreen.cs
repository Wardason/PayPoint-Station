using PayPoint_Station.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PayPoint_Station.UI
{
    public static class AppScreen
    {
        internal static void Welcome()
        {
            Console.WriteLine("\n\n------------------------------PayPoint------------------------\n\n");
            Console.WriteLine("Insert your ATM Card");
            Console.WriteLine("Note: Actual ATM system will accept and validate physical ATM card");
            Console.WriteLine("Mote: For Creating an Account, press 'a' to continue\n");
            Console.WriteLine("\n\nPress 'c' to continue.\n");
            //TODO: Try catch null
            string userAction = Console.ReadLine();

            Program.processUserInput(userAction);
        }

        internal static void Login()
        {
            Console.Write("\n\nPlease enter your card number: ");
            //TODO: Try catch null
            string cardNumber = Console.ReadLine();
            Console.Write("Enter your card PIN: ");
            //TODO: Try catch null
            string cardPin = Console.ReadLine();
        }

        internal static void CreatingAccound()
        {
            Console.WriteLine("----------Creating Account----------");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your birth date");
            string birth_date = Console.ReadLine();

            Console.Write("Enter your current address: ");
            string address = Console.ReadLine();
            
            
        }
    }
}
