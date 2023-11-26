using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace socketclient
{
    internal class Client
    {
        IPHostEntry host;
        IPAddress remoteAddress;
        IPEndPoint remoteEndPoint;

        Socket s_cli;

        public Client(string ip, int port)
        {
            host = Dns.GetHostByName(ip);
            remoteAddress = host.AddressList[0];
            remoteEndPoint = new IPEndPoint(remoteAddress, port);

            s_cli = new Socket(remoteAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            //s_cli.Connect(remoteEndPoint);
        }
        public void Start()
        {
            s_cli.Connect(remoteEndPoint);

        }
        public void Send(string msj)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(msj);
            s_cli.Send(bytes);
            Console.WriteLine("Mensaje Enviado desde cliente");
        }
    }
}
