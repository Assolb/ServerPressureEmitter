using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerProgram
{
    public interface IServerChannelListener
    {
        String GetIp();

        int GetPort();

        void RegisterPackets();

        void Start();

        void ListenPackets();

        void SendPacket(Socket client, IPacketServer packet);

        void End();
    }
}
