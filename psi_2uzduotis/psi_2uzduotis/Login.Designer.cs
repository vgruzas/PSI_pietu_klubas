namespace psi_2uzduotis
{
    partial class Prisijungimas
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.pswTextBox = new System.Windows.Forms.TextBox();
            this.pswLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.regLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(131, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Prisijungimo vardas";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(150, 17);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(156, 22);
            this.loginTextBox.TabIndex = 1;
            this.loginTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginTextBox_KeyDown);
            // 
            // pswTextBox
            // 
            this.pswTextBox.Location = new System.Drawing.Point(150, 45);
            this.pswTextBox.Name = "pswTextBox";
            this.pswTextBox.PasswordChar = '*';
            this.pswTextBox.Size = new System.Drawing.Size(156, 22);
            this.pswTextBox.TabIndex = 3;
            this.pswTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PswTextBox_KeyDown);
            // 
            // pswLabel
            // 
            this.pswLabel.AutoSize = true;
            this.pswLabel.Location = new System.Drawing.Point(63, 50);
            this.pswLabel.Name = "pswLabel";
            this.pswLabel.Size = new System.Drawing.Size(81, 17);
            this.pswLabel.TabIndex = 2;
            this.pswLabel.Text = "Slaptažodis";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(221, 73);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(85, 31);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Prisijungti";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // regLinkLabel
            // 
            this.regLinkLabel.AutoSize = true;
            this.regLinkLabel.Location = new System.Drawing.Point(13, 87);
            this.regLinkLabel.Name = "regLinkLabel";
            this.regLinkLabel.Size = new System.Drawing.Size(83, 17);
            this.regLinkLabel.TabIndex = 5;
            this.regLinkLabel.TabStop = true;
            this.regLinkLabel.Text = "Registruotis";
            this.regLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Prisijungimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 110);
            this.Controls.Add(this.regLinkLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.pswTextBox);
            this.Controls.Add(this.pswLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Prisijungimas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prisijungimas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Prisijungimas_FormClosed);
            this.Load += new System.EventHandler(this.Prisijungimas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox pswTextBox;
        private System.Windows.Forms.Label pswLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.LinkLabel regLinkLabel;
    }
}