using AutoShutdownWinForm.Classes;
using AutoShutdownWinForm.Classes.TcpClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoShutdownWinForm.UserControls
{
    public partial class SpecificMessage : UserControl
    {
        public SpecificMessage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text == "")
                return;
            List<TcpClient> tcpClients = FormInterpretorClass.devices_.Select(x => x._client).ToList();
            SendCommandsToUser.SendMessageToIP(tcpClients.ToArray(), txtMessage.Text.Trim());
        }
    }
}
