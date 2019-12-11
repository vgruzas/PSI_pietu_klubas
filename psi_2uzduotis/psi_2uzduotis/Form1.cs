using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace psi_2uzduotis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Uzrasai> uzr = new List<Uzrasai>();
        List<Naudotojai> naud = new List<Naudotojai>();
        string usr = Prisijungimas.usrn;
        UzrasaiController uc;
        private void Form1_Load(object sender, EventArgs e)
        {
            uc = new UzrasaiController(usr, uzrasaiRichTextBox.Text, Convert.ToInt32(ID));
            DB db = new DB(uzr, naud);
            uzrasaiPanel.Controls.Clear();
            uzr.Clear();
            loginNameLabel.Text = "Prisijungęs kaip: "+usr+"";
            db.controller = uc;
            db.ReadUzrasai();
            int i = 0;
            foreach (Uzrasai u in uzr)
            {
                Button uzButton = new Button();
                uzButton.Text = u.GetPavadinimas();
                uzButton.Location = new Point(0, 50 * i);
                uzButton.Size = new Size(120, 50);
                uzButton.Tag = u;
                uzButton.Click += UzButton_Click;
                uzrasaiPanel.Controls.Add(uzButton);
                i++;
            }
            i = 0;
        }
        private void UzButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Uzrasai u = (Uzrasai)b.Tag;
            uzrasaiRichTextBox.Text = u.GetUzrasai();
            ID = u.GetID().ToString();
            Button saveButton = new Button();
            Button deleteButton = new Button();
            saveButton.Text = "Išsaugoti";
            saveButton.Width = 63;
            saveButton.Height = 23;
            saveButton.Tag = (Button)sender;
            saveButton.Click += SaveButton_Click;
            saveButton.Location = new Point(0, 0);
            deleteButton.Click += DeleteButton_Click;
            deleteButton.Text = "Šalinti";
            deleteButton.Width = 63;
            deleteButton.Height = 23;
            deleteButton.Tag = (Button)sender;
            deleteButton.Location = new Point(63, 0);
            toolPanel.Controls.Add(saveButton);
            toolPanel.Controls.Add(deleteButton);
        }
        string ID;
        private void SaveButton_Click(object sender, EventArgs e)
        {
            uc = new UzrasaiController(usr, uzrasaiRichTextBox.Text, Convert.ToInt32(ID));
            DB db = new DB(uzr, naud);
            db.controller = uc;
            db.Update();
            Form1_Load(sender, e);
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ar tikrai norite ištrinti šį įrašą?", "Patvirtinimas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                uc = new UzrasaiController(usr, uzrasaiRichTextBox.Text, Convert.ToInt32(ID));
                DB db = new DB(uzr, naud);
                db.controller = uc;
                db.Delete();
                uzrasaiRichTextBox.Text = "";
                Form1_Load(sender, e);
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            if(uzrasaiTextBox.Text.TrimEnd()=="")
            {
                MessageBox.Show("Įveskite pavadinimą!");
                uzrasaiTextBox.Select();
            }
            else
            {
                uc = new UzrasaiController(usr, uzrasaiTextBox.Text.TrimEnd().TrimStart(), Convert.ToInt32(ID));
                DB db = new DB(uzr, naud);
                db.controller = uc;
                db.Insert();
                uzrasaiTextBox.Text = "";
            }
            Form1_Load(sender, e);
        }

        private void uzrasaiTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                addButton.PerformClick();
            }
        }

        private void logOutlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Prisijungimas p = new Prisijungimas();
            p.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
