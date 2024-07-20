namespace AutoShutdownWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            richTextBox = new RichTextBox();
            label5 = new Label();
            lblPort = new Label();
            lblIPServer = new Label();
            lblStatus = new Label();
            label3 = new Label();
            flowLayoutPanel = new FlowLayoutPanel();
            label4 = new Label();
            btnNdalo = new Button();
            btnStart = new Button();
            Body = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel.SuspendLayout();
            Body.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1172, 82);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(202, 23);
            label2.TabIndex = 1;
            label2.Text = "Powered by : V-Software 2023";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(208, 42);
            label1.TabIndex = 0;
            label1.Text = "Auto ShutDown";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(richTextBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lblPort);
            panel2.Controls.Add(lblIPServer);
            panel2.Controls.Add(lblStatus);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(flowLayoutPanel);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnNdalo);
            panel2.Controls.Add(btnStart);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(680, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(492, 657);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(401, 474);
            button1.Name = "button1";
            button1.Size = new Size(76, 34);
            button1.TabIndex = 14;
            button1.Text = "Pastro";
            button1.UseVisualStyleBackColor = false;
            // 
            // richTextBox
            // 
            richTextBox.BorderStyle = BorderStyle.FixedSingle;
            richTextBox.Location = new Point(9, 285);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(468, 183);
            richTextBox.TabIndex = 13;
            richTextBox.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 261);
            label5.Name = "label5";
            label5.Size = new Size(74, 23);
            label5.TabIndex = 12;
            label5.Text = "Njoftimet: ";
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPort.Location = new Point(11, 566);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(42, 23);
            lblPort.TabIndex = 11;
            lblPort.Text = "Port: ";
            // 
            // lblIPServer
            // 
            lblIPServer.AutoSize = true;
            lblIPServer.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblIPServer.Location = new Point(11, 543);
            lblIPServer.Name = "lblIPServer";
            lblIPServer.Size = new Size(71, 23);
            lblIPServer.TabIndex = 10;
            lblIPServer.Text = "IP Server: ";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.Location = new Point(11, 520);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(101, 23);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Statusi: Offline";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(11, 487);
            label3.Name = "label3";
            label3.Size = new Size(173, 23);
            label3.TabIndex = 8;
            label3.Text = "Informacionet e serverit";
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Controls.Add(button2);
            flowLayoutPanel.Controls.Add(button3);
            flowLayoutPanel.Controls.Add(button4);
            flowLayoutPanel.Controls.Add(button5);
            flowLayoutPanel.Location = new Point(6, 42);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(474, 203);
            flowLayoutPanel.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 16);
            label4.Name = "label4";
            label4.Size = new Size(132, 23);
            label4.TabIndex = 6;
            label4.Text = "Lista e komandave";
            // 
            // btnNdalo
            // 
            btnNdalo.BackColor = Color.FromArgb(192, 0, 0);
            btnNdalo.Cursor = Cursors.Hand;
            btnNdalo.Enabled = false;
            btnNdalo.FlatStyle = FlatStyle.Flat;
            btnNdalo.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNdalo.ForeColor = Color.White;
            btnNdalo.Location = new Point(368, 611);
            btnNdalo.Name = "btnNdalo";
            btnNdalo.Size = new Size(112, 34);
            btnNdalo.TabIndex = 3;
            btnNdalo.Text = "Ndalo Serverin";
            btnNdalo.UseVisualStyleBackColor = false;
            btnNdalo.Click += btnNdalo_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Green;
            btnStart.Cursor = Cursors.Hand;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(255, 611);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(107, 34);
            btnStart.TabIndex = 2;
            btnStart.Text = "Fillo Serverin";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // Body
            // 
            Body.Controls.Add(flowLayoutPanel1);
            Body.Dock = DockStyle.Fill;
            Body.Location = new Point(0, 82);
            Body.Name = "Body";
            Body.Size = new Size(680, 657);
            Body.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(680, 657);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(103, 38);
            button2.TabIndex = 0;
            button2.Tag = "1";
            button2.Text = "Dergo Messazh";
            button2.UseVisualStyleBackColor = true;
            button2.Click += CommandsList;
            // 
            // button3
            // 
            button3.Location = new Point(112, 3);
            button3.Name = "button3";
            button3.Size = new Size(103, 38);
            button3.TabIndex = 1;
            button3.Tag = "2";
            button3.Text = "Vendos Kohen";
            button3.UseVisualStyleBackColor = true;
            button3.Click += CommandsList;
            // 
            // button4
            // 
            button4.Location = new Point(221, 3);
            button4.Name = "button4";
            button4.Size = new Size(113, 38);
            button4.TabIndex = 2;
            button4.Tag = "3";
            button4.Text = "Vendose ne gjume";
            button4.UseVisualStyleBackColor = true;
            button4.Click += CommandsList;
            // 
            // button5
            // 
            button5.Location = new Point(340, 3);
            button5.Name = "button5";
            button5.Size = new Size(113, 38);
            button5.TabIndex = 3;
            button5.Tag = "4";
            button5.Text = "Vendose Screen";
            button5.UseVisualStyleBackColor = true;
            button5.Click += CommandsList;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1172, 739);
            Controls.Add(Body);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel.ResumeLayout(false);
            Body.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel Body;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel;
        private Button btnNdalo;
        private Button btnStart;
        private Label lblStatus;
        private Label label3;
        private Label lblPort;
        private Label lblIPServer;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private RichTextBox richTextBox;
        private Label label5;
        private Label label4;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
