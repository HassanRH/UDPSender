using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udp_sender
{
    class Program
    {
        private static readonly int PORT = 54321;
        static void Main(string[] args)
        {
            senderclass senderclass = new senderclass(PORT);
            senderclass.Start();

            Console.ReadLine();
        }
    }
}
