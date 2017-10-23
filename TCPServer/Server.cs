﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

using System.Threading.Tasks;


namespace TCPServer
{
    class Server
    {

        //private readonly int PORT;

        public Server(/*int port*/)
        {
            //this.PORT = port;
        }

        public void Start()
        {
            TcpListener server = new TcpListener(IPAddress.Loopback, 1001);
            server.Start();
            TcpClient client = server.AcceptTcpClient();

            DoClient(client);

        }

        private static void DoClient(TcpClient client)
        {
            using (Stream ns = client.GetStream())
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                String inline = sr.ReadLine();
                String outLine = HandleClient(inline);

                sw.WriteLine(outLine);
                sw.Flush();
            }
        }

        public static String HandleClient(String line)
        {
            Console.WriteLine("server modtaget : " + line);
            return line;
        }
    }
}
