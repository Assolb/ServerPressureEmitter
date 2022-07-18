using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerProgram
{
    public class C0PacketSendPressure : IPacketClient
    {
        public void PacketFromString(Socket client, String str)
        {
            String[] packet = str.Split(';');
            Console.WriteLine(DateTime.Now.ToShortTimeString() + ": {PressureSensor: " + packet[0] + ", Pressure: " + packet[1] + "}");
            Program.listener.SendPacket(client, new S0PacketSendResponse(1));
        }
    }
}
