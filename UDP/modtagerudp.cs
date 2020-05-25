using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UDP
{
    class modtagerudp
    {
        private int PORT;
        //ctor navn 
        public modtagerudp(int port) //laver en consturkter så vi kan sætte en port på programet når vi kalder den i klassen
        {
            this.PORT = port;            
        }
        //husk at installere json nuget
        public void Start() //den har en udp client 
        {
            using (UdpClient socket = new UdpClient(PORT))
            {
                IPEndPoint senderEP = new IPEndPoint(IPAddress.Any, 0); //IPendpoint vi laver til den kommer hvilkken som helst ipadresse, 0 betdyer den kan komme fra alle steder
                Byte[] data = socket.Receive(ref senderEP); //udp for skellige byttes, så kan vi hente i byttes 

                //laver gode her

                string meddelse = Encoding.ASCII.GetString(data); //hent stringen fra de bytes
                string[] splitmeddelse = meddelse.Split(' '); // her splitter vi meddelsenn (' ') ved brug af det <-- 
                foreach (var i in splitmeddelse) //her skriver den ud i hver linje ved atbruge en foreach
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
