using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace socketclient
{
    class Program
    {
        static void Main(string[] args)
        {
            Client s = new Client("127.0.0.1", 3367);
            s.Start();
            s.Send("Hola soy el cliente");
        }
    }

}