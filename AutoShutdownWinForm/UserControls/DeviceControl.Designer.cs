namespace AutoShutdownWinForm.UserControls
{
    partial class DeviceControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            pictureBox1 = new PictureBox();
            lblOra = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(3, 138);
            lblName.Name = "lblName";
            lblName.Size = new Size(66, 23);
            lblName.TabIndex = 13;
            lblName.Text = "Njoftimt: ";
            lblName.Click += DeviceControl_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_device_100;
            pictureBox1.Location = new Point(26, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += DeviceControl_Click;
            // 
            // lblOra
            // 
            lblOra.AutoSize = true;
            lblOra.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblOra.Location = new Point(3, 163);
            lblOra.Name = "lblOra";
            lblOra.Size = new Size(100, 23);
            lblOra.TabIndex = 15;
            lblOra.Text = "Ora e kyqjes: ";
            lblOra.Click += DeviceControl_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 115);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 16;
            label2.Text = "Emri Paisjes";
            label2.Click += DeviceControl_Click;
            // 
            // DeviceControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(lblOra);
            Controls.Add(pictureBox1);
            Controls.Add(lblName);
            Name = "DeviceControl";
            Size = new Size(154, 195);
            Load += DeviceControl_Load;
            Click += DeviceControl_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private PictureBox pictureBox1;
        private Label lblOra;
        private Label label2;
    }
}
