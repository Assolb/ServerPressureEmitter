using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerProgram
{
    public class Program
    {
        public static ServerChannelListener listener = new ServerChannelListener("127.0.0.1", 8005);

        public static void Main()
        {
            Console.WriteLine("Сервер запущен, ожидание соединений...");
            listener.RegisterPackets();
            listener.Start();
            
            Console.ReadKey();
            listener.End();
        }
    }
}
