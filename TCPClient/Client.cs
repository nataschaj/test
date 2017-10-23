using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using WcfMock;

namespace TCPClient
{

    class Client
    {
        //private readonly int PORT;

        public Client(/*int port*/)
        {
            //this.PORT = port;
        }

        
        
        

        public void Start()
        {
            var calc = new CalculatorReference.Service1Client();

            //calc.GetVolume(20, 30, 10);
            //calc.GetSide(2, 5, 4);

            using (TcpClient client = new TcpClient("Localhost", 1001))
            using (NetworkStream ns = client.GetStream())
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                sw.WriteLine(calc.GetSide(5, 10, 25));
                sw.WriteLine(calc.GetVolume(50, 50, 10));
                sw.Flush();

                String incomingString = sr.ReadLine();
                Console.WriteLine("Ekko er modtaget: " + incomingString);
            }
        }
    }

}
