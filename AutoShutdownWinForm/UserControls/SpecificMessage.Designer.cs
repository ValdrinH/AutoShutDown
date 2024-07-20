namespace AutoShutdownWinForm.UserControls
{
    partial class SpecificMessage
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
            txtMessage = new TextBox();
            lblName = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtMessage
            // 
            txtMessage.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMessage.Location = new Point(24, 83);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.PlaceholderText = "Mesazhi...";
            txtMessage.ScrollBars = ScrollBars.Vertical;
            txtMessage.Size = new Size(374, 234);
            txtMessage.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(24, 50);
            lblName.Name = "lblName";
            lblName.Size = new Size(86, 30);
            lblName.TabIndex = 15;
            lblName.Text = "Mesazhi:";
            // 
            // button1
            // 
            button1.Location = new Point(289, 323);
            button1.Name = "button1";
            button1.Size = new Size(109, 34);
            button1.TabIndex = 16;
            button1.Text = "Dergoje";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SpecificMessage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(lblName);
            Controls.Add(txtMessage);
            Name = "SpecificMessage";
            Size = new Size(422, 404);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMessage;
        private Label lblName;
        private Button button1;
    }
}
