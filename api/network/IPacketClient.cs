using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerProgram
{
    public interface IPacketClient : IPacket
    {
        void PacketFromString(Socket client, String str);
    }
}
