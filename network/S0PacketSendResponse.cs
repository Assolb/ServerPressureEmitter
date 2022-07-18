using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerProgram
{
    public class S0PacketSendResponse : IPacketServer
    {
        private byte response;

        public S0PacketSendResponse(byte response)
        {
            this.response = response;
        }

        public String PacketToString()
        {
            return Convert.ToString(this.response);
        }
    }
}
