﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SilkroadSecurityApi;
using SilkroadInformationAPI.Client.Information;

namespace SilkroadInformationAPI.Client.Packets.Alchemy
{
    class ParseInfo
    {
        public static Dictionary<string, int> ParseBlues(Packet p, int count)
        {
            var Blues = new Dictionary<string, int>();
            for(int i = 0; i < count; i++)
            {
                int blueID = p.ReadInt32();
                int blueValue = p.ReadInt32();
                if (Media.Data.MediaBlues.ContainsKey(blueID))
                    Blues.Add(Media.Data.MediaBlues[blueID], blueValue);
            }

            return Blues;
        }
    }
}
