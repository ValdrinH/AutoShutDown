using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoShutdownWinForm
{
    public partial class UseForm : Form
    {
        private UserControl userControl;
        public UseForm(UserControl userControl)
        {
            InitializeComponent();
            this.userControl = userControl;
        }

        protected override void OnLoad(EventArgs e)
        {
            Body.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            Body.Controls.Add(userControl);
            base.OnLoad(e);
        }
    }
}
