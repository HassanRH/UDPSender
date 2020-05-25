using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace udp_sender
{
    class senderclass
    {
        private int PORT;
        //cunstroctor navn

        public senderclass(int port) // port så vi kan sætte den sener
        {
            this.PORT = port;
        }

        //husk json nuget hvis det er
        public void Start()
        {
            using (UdpClient socket = new UdpClient())
                while (true) 
                {
                    string doordata = "Door: 4 \r\n"; // skal s
                    byte[] data = Encoding.ASCII.GetBytes(doordata); //inkoder det i bytes

                    IPEndPoint recieverEP = new IPEndPoint(IPAddress.Loopback, PORT);
                    socket.Send(data, data.Length, recieverEP);
                    Thread.Sleep(5000); //5sek; 
                }
        }
    }
}

