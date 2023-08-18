using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine("\n\nPress enter to continue.\n");
            Console.ReadLine();
        }
    }
}
