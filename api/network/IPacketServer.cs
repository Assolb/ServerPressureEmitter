﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerProgram
{
    public interface IPacketServer : IPacket
    {
        String PacketToString();
    }
}
