namespace psi_2uzduotis
{
    partial class Form2
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
            this.naudPanel = new System.Windows.Forms.Panel();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.deletedPanel = new System.Windows.Forms.Panel();
            this.revivePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.logOutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // naudPanel
            // 
            this.naudPanel.AutoScroll = true;
            this.naudPanel.Location = new System.Drawing.Point(12, 29);
            this.naudPanel.Name = "naudPanel";
            this.naudPanel.Size = new System.Drawing.Size(200, 335);
            this.naudPanel.TabIndex = 0;
            // 
            // toolPanel
            // 
            this.toolPanel.Location = new System.Drawing.Point(218, 29);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(145, 86);
            this.toolPanel.TabIndex = 1;
            // 
            // deletedPanel
            // 
            this.deletedPanel.AutoScroll = true;
            this.deletedPanel.Location = new System.Drawing.Point(369, 29);
            this.deletedPanel.Name = "deletedPanel";
            this.deletedPanel.Size = new System.Drawing.Size(200, 335);
            this.deletedPanel.TabIndex = 1;
            // 
            // revivePanel
            // 
            this.revivePanel.Location = new System.Drawing.Point(218, 121);
            this.revivePanel.Name = "revivePanel";
            this.revivePanel.Size = new System.Drawing.Size(145, 33);
            this.revivePanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naudotojai                                                                       " +
    " Ištrinti naudotojai";
            // 
            // logOutLinkLabel
            // 
            this.logOutLinkLabel.AutoSize = true;
            this.logOutLinkLabel.Location = new System.Drawing.Point(9, 372);
            this.logOutLinkLabel.Name = "logOutLinkLabel";
            this.logOutLinkLabel.Size = new System.Drawing.Size(65, 17);
            this.logOutLinkLabel.TabIndex = 4;
            this.logOutLinkLabel.TabStop = true;
            this.logOutLinkLabel.Text = "Atsijungti";
            this.logOutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 398);
            this.Controls.Add(this.logOutLinkLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.revivePanel);
            this.Controls.Add(this.deletedPanel);
            this.Controls.Add(this.toolPanel);
            this.Controls.Add(this.naudPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administravimas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel naudPanel;
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.Panel deletedPanel;
        private System.Windows.Forms.Panel revivePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel logOutLinkLabel;
    }
}