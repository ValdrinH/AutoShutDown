using AutoShutdownWinForm.Classes;
using AutoShutdownWinForm.Classes.DNS;
using AutoShutdownWinForm.Classes.TcpClass;
using AutoShutdownWinForm.UserControls;
using System.Net.Sockets;

namespace AutoShutdownWinForm
{
    public partial class Form1 : Form
    {
        TcpServer server;

        public bool isServerAlive = false;
        public FlowLayoutPanel BodyElements { get => flowLayoutPanel1; }
        public RichTextBox box { get => richTextBox; }
        public Label StatusServer { get => lblStatus; }


        public Form1()
        {
            InitializeComponent();
            server = new TcpServer(12345);
            lblPort.Text = "Port: 12345";
            lblIPServer.Text = "IP Server: " + MyIpServer.GetMyIp();

        }

        protected override void OnLoad(EventArgs e)
        {
            FormInterpretorClass.form_ = this;
            base.OnLoad(e);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            isServerAlive = true;
            btnNdalo.Enabled = true;
            btnStart.Enabled = false;
            server = new TcpServer(12345);
            server.StartThread();
        }

        private void btnNdalo_Click(object sender, EventArgs e)
        {
            isServerAlive = false;
            btnNdalo.Enabled = false;
            btnStart.Enabled = true;
            server.StopServer();
        }

        private void CommandsList(object sender, EventArgs e)
        {
            var _tag = sender as Button;

            string _buttonId = _tag.Tag as string;


            if(FormInterpretorClass.devices_.Count == 0)
            {
                MessageBox.Show("Ju lutem selektoni klientin per te derguar komanden","Njoftim",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<TcpClient> tcpClients = FormInterpretorClass.devices_.Select(x => x._client).ToList();
            switch (_buttonId)
            {
                case "1":
                    FormInterpretorClass.dialogResult(new SpecificMessage());
                    break;
                case "2":
                    break;
                case "3":
                    SendCommandsToUser.SendMessageToIP(tcpClients.ToArray(), "Sleep-60");
                    break;
                case "4":
                    SendCommandsToUser.SendMessageToIP(tcpClients.ToArray(), "CaptureScreenshot-60");
                    break;
                default:
                    break;
            }
        }
    }
}
