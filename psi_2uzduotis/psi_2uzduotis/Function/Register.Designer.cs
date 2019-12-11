namespace psi_2uzduotis
{
    partial class Register
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pswTextBox = new System.Windows.Forms.TextBox();
            this.pswLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.regPswTextBox = new System.Windows.Forms.TextBox();
            this.repPswLabel = new System.Windows.Forms.Label();
            this.regButton = new System.Windows.Forms.Button();
            this.backLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // pswTextBox
            // 
            this.pswTextBox.Location = new System.Drawing.Point(176, 34);
            this.pswTextBox.Name = "pswTextBox";
            this.pswTextBox.PasswordChar = '*';
            this.pswTextBox.Size = new System.Drawing.Size(156, 22);
            this.pswTextBox.TabIndex = 7;
            this.pswTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PswTextBox_KeyDown);
            // 
            // pswLabel
            // 
            this.pswLabel.AutoSize = true;
            this.pswLabel.Location = new System.Drawing.Point(89, 37);
            this.pswLabel.Name = "pswLabel";
            this.pswLabel.Size = new System.Drawing.Size(81, 17);
            this.pswLabel.TabIndex = 6;
            this.pswLabel.Text = "Slaptažodis";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(176, 4);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(156, 22);
            this.loginTextBox.TabIndex = 5;
            this.loginTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginTextBox_KeyDown);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(39, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(131, 17);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Prisijungimo vardas";
            // 
            // regPswTextBox
            // 
            this.regPswTextBox.Location = new System.Drawing.Point(176, 62);
            this.regPswTextBox.Name = "regPswTextBox";
            this.regPswTextBox.PasswordChar = '*';
            this.regPswTextBox.Size = new System.Drawing.Size(156, 22);
            this.regPswTextBox.TabIndex = 9;
            this.regPswTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegPswTextBox_KeyDown);
            // 
            // repPswLabel
            // 
            this.repPswLabel.AutoSize = true;
            this.repPswLabel.Location = new System.Drawing.Point(23, 65);
            this.repPswLabel.Name = "repPswLabel";
            this.repPswLabel.Size = new System.Drawing.Size(147, 17);
            this.repPswLabel.TabIndex = 8;
            this.repPswLabel.Text = "Pakartokite slaptažodį";
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(239, 91);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(93, 28);
            this.regButton.TabIndex = 10;
            this.regButton.Text = "Registruotis";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // backLinkLabel
            // 
            this.backLinkLabel.AutoSize = true;
            this.backLinkLabel.Location = new System.Drawing.Point(12, 102);
            this.backLinkLabel.Name = "backLinkLabel";
            this.backLinkLabel.Size = new System.Drawing.Size(40, 17);
            this.backLinkLabel.TabIndex = 11;
            this.backLinkLabel.TabStop = true;
            this.backLinkLabel.Text = "Atgal";
            this.backLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BackLinkLabel_LinkClicked);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 126);
            this.Controls.Add(this.backLinkLabel);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.regPswTextBox);
            this.Controls.Add(this.repPswLabel);
            this.Controls.Add(this.pswTextBox);
            this.Controls.Add(this.pswLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pswTextBox;
        private System.Windows.Forms.Label pswLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox regPswTextBox;
        private System.Windows.Forms.Label repPswLabel;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.LinkLabel backLinkLabel;
    }
}