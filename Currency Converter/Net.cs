using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Net
    {
        public bool Connect()
        {
            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send("google.com");
                return true;
            }
            catch
            { return false; }
        }
    }
}
