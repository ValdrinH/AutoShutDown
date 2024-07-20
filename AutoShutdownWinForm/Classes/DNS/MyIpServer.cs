using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AutoShutdownWinForm.Classes.DNS
{
    public class MyIpServer
    {
        public static string GetMyIp()
        {
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST
            return Dns.GetHostByName(hostName).AddressList[1].ToString();
        }
    }
}
