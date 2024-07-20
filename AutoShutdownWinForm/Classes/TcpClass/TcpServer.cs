using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using AutoShutdownWinForm.UserControls;
using static System.Windows.Forms.AxHost;
using System.Net.Http;

namespace AutoShutdownWinForm.Classes.TcpClass
{
    public class TcpServer
    {
        private TcpListener tcpListener;
        private Thread listenerThread;
        private List<ClientInfo> connectedClients;
        private Dictionary<string, string> clientNames; // Dictionary për të ruajtur emrat e klientëve nga IP
        private object lockObject = new object();
        int serverPort;
        private bool isListening = true; // Shto këtë flag
        private System.Threading.Timer checkDisconnectedClientsTimer;



        public TcpServer(int port)
        {
            tcpListener = new TcpListener(IPAddress.Any, port);
            listenerThread = new Thread(new ThreadStart(ListenForClients));
            connectedClients = new List<ClientInfo>();
            clientNames = new Dictionary<string, string>();
            serverPort = port;
            object state = null;
            checkDisconnectedClientsTimer = new System.Threading.Timer(CheckDisconnectedClientsCallback, state, 0, 30);
        }
        private void CheckDisconnectedClientsCallback(object state)
        {
            CheckAndRemoveDisconnectedClients();
        }
        public void CheckAndRemoveDisconnectedClients()
        {
            lock (lockObject)
            {
                Dictionary<ClientInfo,string> disconnectedClients = new Dictionary<ClientInfo,string>();

                foreach (ClientInfo clientInfo in connectedClients)
                {
                    if (!IsClientConnected(clientInfo.Client))
                    {
                        disconnectedClients.Add(clientInfo, clientInfo.IpAddress);
                    }
                }

                foreach (KeyValuePair<ClientInfo,string> disconnectedClient in disconnectedClients)
                {
                    connectedClients.Remove(disconnectedClient.Key);
                 
                    clientNames.Remove(disconnectedClient.Value);
                    disconnectedClient.Key.Client.Close();
                                    DeviceControl obj = FormInterpretorClass.form_.BodyElements.Controls
                                    .Cast<DeviceControl>()
                                    .AsEnumerable()
                                    .Where(x => x._IpAddress == disconnectedClient.Value)
                                    .FirstOrDefault();

                    FormInterpretorClass.AddTextToMessage($"Lidhja me klientin {obj._DeviceOriginalName} u ndërpre.");
                    FormInterpretorClass.RemoveElementToBodyPanel(obj);
                }
            }
        }
        public void StartThread()
        {
            listenerThread.Start();
            FormInterpretorClass.form_.StatusServer.Text = "Statusi: Online";
        }

        public void StopServer()
        {
            lock (lockObject)
            {
                // Ndrysho flag-in për të ndërprerë ciklin
                isListening = false;

                // Mbyll TcpListener për të ndaluar pranimin e lidhjeve të reja
                tcpListener.Stop();

                // Mbyll lidhjet me klientët
                foreach (ClientInfo clientInfo in connectedClients)
                {
                    clientInfo.Client.Close();
                }

                // Fshij listenIngo dhe clientNames
                connectedClients.Clear();
                clientNames.Clear();

                // Shto një kohëzgjatje për pritjen e thread-it
                if (listenerThread != null && listenerThread.IsAlive)
                {
                    if (!listenerThread.Join(TimeSpan.FromSeconds(5))) // Prit për maksimum 5 sekonda
                    {
                        // Nëse pas 5 sekondave thread-i vazhdon të jetë gjallë, mund të bëni diçka tjetër
                       MessageBox.Show("Koha e pritjes ka skaduar, duke vazhduar pa pritur thread-in.");
                    }
                }
                FormInterpretorClass.AddTextToMessage("Serveri u ndal me sukses...");
                FormInterpretorClass.form_.StatusServer.Text = "Statusi: Offline";
                FormInterpretorClass.ClearElementToBodyPanel();
            }
        }

        private void ListenForClients()
        {
            lock (lockObject)
            {
                if (IsPortInUse(serverPort))
                {
                    FormInterpretorClass.AddTextToMessage($"Porti {serverPort} eshte ende duke u perdorur. Mbyllja dhe hapja e portit...");
                    tcpListener.Stop();
                    Thread.Sleep(1000);
                    serverPort++;
                    tcpListener = new TcpListener(IPAddress.Any, serverPort);
                    tcpListener.Start();
                    FormInterpretorClass.AddTextToMessage($"Porti {serverPort} u hap i ri.");
                    FormInterpretorClass.AddTextToMessage($"Serveri eshte duke degjuar ne portin {serverPort}...");
                }
                else
                {
                    tcpListener.Start();
                    FormInterpretorClass.AddTextToMessage($"Serveri eshte duke degjuar ne portin {serverPort}...");
                }
            }

            while (isListening)
            {
                try
                {
                    TcpClient client = tcpListener.AcceptTcpClient();
                    ClientInfo clientInfo = new ClientInfo(client);
                    connectedClients.Add(clientInfo);

                    Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                    clientThread.Start(clientInfo);
                }
                catch (Exception ex)
                {
                    // Menaxho gabimet sipas nevojës tuaj
                    FormInterpretorClass.AddTextToMessage($"\nGabim gjatë pritjes së klientit: {ex.Message}");
                }
            }
        }
        private bool IsPortInUse(int port)
        {
            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] tcpListeners = ipGlobalProperties.GetActiveTcpListeners();

            foreach (IPEndPoint ep in tcpListeners)
            {
                if (ep.Port == port)
                {
                    return true;
                }
            }

            return false;
        }
        private void HandleClientComm(object clientObj)
        {
            ClientInfo clientInfo = (ClientInfo)clientObj;
            TcpClient tcpClient = clientInfo.Client;
            NetworkStream clientStream = tcpClient.GetStream();

            string clientId = clientInfo.ClientId;
            string clientAddress = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString();


            if (tcpClient != null && tcpClient.Connected)
            {
                string clientHostName = "";
                try
                {
                    // Përdorimi i Dns.GetHostEntry për të marrë emrin e host-it nga adresa IP
                    IPHostEntry entry = Dns.GetHostEntry(clientAddress);
                    clientHostName = entry.HostName;
                    clientNames.Add(clientAddress, clientHostName);
                    var obj = new DeviceControl()
                    {
                        _DeviceName = clientHostName,
                        _DeviceOriginalName = clientHostName,
                        _TimeJoin = DateTime.Now.ToString("HH:mm"),
                        _IpAddress = clientAddress,
                        _ClientId = clientId,
                        _client = tcpClient
                    };
                    obj._Selected += (ss, ee) =>
                    {
                        if (obj._SelectedObject)
                        {
                            FormInterpretorClass.devices_.Remove(obj);
                        }
                        else
                        {
                            FormInterpretorClass.devices_.Add(obj);
                        }
                    };

                    FormInterpretorClass.AddElementToBodyPanel(obj);
                }
                catch (SocketException)
                {
                    // Në raste të caktuara, mund të mos mund të merret emri i host-it
                    clientHostName = "Pa-emër";
                }
                string commandToSend = "U lidhet me sukses!";
              SendCommandsToUser.SendCommandToClients(clientStream, commandToSend);

            }



            string clientInfoString = $"Klienti ({clientId}) {GetClientName(clientAddress)} i lidhur nga: {clientAddress}:{((IPEndPoint)tcpClient.Client.RemoteEndPoint).Port}";
            FormInterpretorClass.AddTextToMessage(clientInfoString);

            byte[] message = new byte[4096];
            int bytesRead;

            while (true)
            {
                bytesRead = 0;

                try
                {
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch
                {
                    break;
                }

                if (bytesRead == 0)
                    break;

                string receivedMessage = Encoding.ASCII.GetString(message, 0, bytesRead);
                FormInterpretorClass.AddTextToMessage($"{GetClientName(clientAddress)} - Mesazhi i pranuar: {receivedMessage}");
            }

            tcpClient.Close();
        }

        private bool IsClientConnected(TcpClient client)
        {
            try
            {
                // Kërkesa e thjeshtë për të verifikuar nëse klienti është ende i lidhur
                byte[] testBuffer = new byte[1];
                NetworkStream stream = client.GetStream();

                // Vendos një timeout për pritjen e përgjigjes nga klienti
                if (!stream.CanRead)
                {
                    return false;
                }

                return true;
            }
            catch
            {
                // Nëse ka gabime, kjo do të thotë se klienti nuk është më i lidhur
                return false;
            }
        }


        private string GetClientName(string ipAddress)
        {
            if (clientNames.ContainsKey(ipAddress))
            {
                return clientNames.FirstOrDefault(x => x.Key == ipAddress).Value;
            }
            return "";
        }

        private class ClientInfo
        {
            public TcpClient Client { get; private set; }
            public string ClientId { get; private set; }
            public string IpAddress { get; private set; }
            private bool handling = true;

            public ClientInfo(TcpClient client)
            {
                Client = client;
                ClientId = Guid.NewGuid().ToString();
                IpAddress = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
            }

            public void StopHandling()
            {
                handling = false;
            }
        }
    }
}
