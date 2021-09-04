using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTestMonitor.model
{
    public class SpeedTest
    {
        string type;
        DateTime timestamp;
        Ping ping;
        public Download download;
        public Upload upload;
        int packetLoss;
        string isp;
        Interface interfaceDevice;
        Server server;
        Result result;
    }
}
