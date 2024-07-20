using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AutoShutdownWinForm.Classes.TcpClass
{
    public class SendCommandsToUser
    {
        public static void SendCommandToClients(NetworkStream networkStream,string commandToSend)
        {
            byte[] commandData = Encoding.ASCII.GetBytes(commandToSend);
            networkStream.Write(commandData, 0, commandData.Length);
        }

        public static void SendMessageToIP(TcpClient[] tcpClient, string message)
        {
            tcpClient.ToList().ForEach(client =>
            {
                string clientAddress = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();

                NetworkStream clientStream = client.GetStream();
                byte[] data = Encoding.ASCII.GetBytes(message);
                clientStream.Write(data, 0, data.Length);
            });
        }
    }
}
