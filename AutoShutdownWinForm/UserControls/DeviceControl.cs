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
    public partial class DeviceControl : UserControl
    {
        public string _DeviceName { set => lblName.Text = value; }
        public string _DeviceOriginalName { get; set; }
        public string _TimeJoin { set => lblOra.Text = "Ora e kyqjes: " + value; }
        public string _IpAddress { get; set; }
        public string _ClientId { get; set; }
        public bool _SelectedObject {  get; set; }
        public TcpClient _client {  get; set; }


        public EventHandler _Selected = null;

        public DeviceControl()
        {
            InitializeComponent();
        }

        private void DeviceControl_Load(object sender, EventArgs e)
        {

        }

        private void DeviceControl_Click(object sender, EventArgs e)
        {
            _Selected?.Invoke(sender, e);

            if (_SelectedObject)
            {
                this.BackColor = Color.FromName("Control");
                _SelectedObject = false;
            }
            else
            {
                this.BackColor = Color.FromName("OliveDrab");
                _SelectedObject = true;
            }
        }
    }
}
