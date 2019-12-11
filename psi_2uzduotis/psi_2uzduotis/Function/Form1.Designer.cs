namespace psi_2uzduotis
{
    partial class Form1
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
            this.loginNameLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.uzrasaiRichTextBox = new System.Windows.Forms.RichTextBox();
            this.uzrasaiPanel = new System.Windows.Forms.Panel();
            this.uzrasaiTextBox = new System.Windows.Forms.TextBox();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.logOutlinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // loginNameLabel
            // 
            this.loginNameLabel.AutoSize = true;
            this.loginNameLabel.Location = new System.Drawing.Point(12, 394);
            this.loginNameLabel.Name = "loginNameLabel";
            this.loginNameLabel.Size = new System.Drawing.Size(115, 17);
            this.loginNameLabel.TabIndex = 0;
            this.loginNameLabel.Text = "Prisijungęs kaip: ";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(118, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(63, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Pridėti";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // uzrasaiRichTextBox
            // 
            this.uzrasaiRichTextBox.Location = new System.Drawing.Point(187, 12);
            this.uzrasaiRichTextBox.Name = "uzrasaiRichTextBox";
            this.uzrasaiRichTextBox.Size = new System.Drawing.Size(395, 367);
            this.uzrasaiRichTextBox.TabIndex = 3;
            this.uzrasaiRichTextBox.Text = "";
            // 
            // uzrasaiPanel
            // 
            this.uzrasaiPanel.AutoScroll = true;
            this.uzrasaiPanel.Location = new System.Drawing.Point(12, 41);
            this.uzrasaiPanel.Name = "uzrasaiPanel";
            this.uzrasaiPanel.Size = new System.Drawing.Size(168, 338);
            this.uzrasaiPanel.TabIndex = 4;
            // 
            // uzrasaiTextBox
            // 
            this.uzrasaiTextBox.Location = new System.Drawing.Point(11, 13);
            this.uzrasaiTextBox.Name = "uzrasaiTextBox";
            this.uzrasaiTextBox.Size = new System.Drawing.Size(101, 22);
            this.uzrasaiTextBox.TabIndex = 5;
            this.uzrasaiTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uzrasaiTextBox_KeyDown);
            // 
            // toolPanel
            // 
            this.toolPanel.Location = new System.Drawing.Point(412, 385);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(170, 42);
            this.toolPanel.TabIndex = 6;
            // 
            // logOutlinkLabel
            // 
            this.logOutlinkLabel.AutoSize = true;
            this.logOutlinkLabel.Location = new System.Drawing.Point(11, 415);
            this.logOutlinkLabel.Name = "logOutlinkLabel";
            this.logOutlinkLabel.Size = new System.Drawing.Size(65, 17);
            this.logOutlinkLabel.TabIndex = 7;
            this.logOutlinkLabel.TabStop = true;
            this.logOutlinkLabel.Text = "Atsijungti";
            this.logOutlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logOutlinkLabel_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 439);
            this.Controls.Add(this.logOutlinkLabel);
            this.Controls.Add(this.toolPanel);
            this.Controls.Add(this.uzrasaiTextBox);
            this.Controls.Add(this.uzrasaiPanel);
            this.Controls.Add(this.uzrasaiRichTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.loginNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Užrašinė";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginNameLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.RichTextBox uzrasaiRichTextBox;
        private System.Windows.Forms.Panel uzrasaiPanel;
        private System.Windows.Forms.TextBox uzrasaiTextBox;
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.LinkLabel logOutlinkLabel;
    }
}

