using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDP
{
    class Program
    {

        private static readonly int PORT = 12345; //private hvis det ikke skal deles med adnre klasser.
        static void Main(string[] args)
        {
            modtagerudp modtagerudp = new modtagerudp(PORT);
            modtagerudp.Start();

            Console.ReadLine();
        }
    }
}
