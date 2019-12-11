using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace psi_2uzduotis
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<Uzrasai> uzr = new List<Uzrasai>();
        List<Naudotojai> naud = new List<Naudotojai>();
        List<Naudotojai> deleted = new List<Naudotojai>();
        string usr = Prisijungimas.usrn;
        NaudotojaiController nc;
        private void Form2_Load(object sender, EventArgs e)
        {
            naudPanel.Controls.Clear();
            naud.Clear();
            deletedPanel.Controls.Clear();
            deleted.Clear();
            nc = new NaudotojaiController(0, Convert.ToInt32(ID), "[Login]");
            DB db = new DB(uzr, naud);
            db.controller = nc;
            db.ReadNaudotojai();

            int i = 0;
            foreach (Naudotojai n in naud)
            {
                if (usr != n.GetVardas())
                {
                    Button nButton = new Button();
                    if (n.GetTypeN().ToString() == "1")
                    {
                        nButton.Text = n.GetVardas() + " Admin";
                    }
                    else nButton.Text = n.GetVardas() + " Ne_Admin";
                    nButton.Location = new Point(0, 50 * i);
                    nButton.Size = new Size(120, 50);
                    nButton.Tag = n;
                    nButton.Click += NaudButton_Click;
                    naudPanel.Controls.Add(nButton);
                    i++;
                }
            }
            nc = new NaudotojaiController(0, Convert.ToInt32(ID), "[DeletedLogin]");
            db = new DB(uzr, deleted);
            db.controller = nc;
            db.ReadNaudotojai();
            i = 0;
            foreach (Naudotojai d in deleted)
            {
                Button dButton = new Button();
                dButton.Text = d.GetVardas();
                dButton.Location = new Point(0, 50 * i);
                dButton.Size = new Size(120, 50);
                dButton.Tag = d;
                dButton.Click += DeletedButton_Click;
                deletedPanel.Controls.Add(dButton);
                i++;
            }
        }
        private void NaudButton_Click(object sender, EventArgs e)
        {
            toolPanel.Visible = true;
            revivePanel.Visible = false;
            Button b = (Button)sender;
            Naudotojai u = (Naudotojai)b.Tag;
            ID = u.GetID().ToString();
            Button typeButton = new Button();
            Button type1Button = new Button();
            Button deleteButton = new Button();
            typeButton.Text = "Padaryti Admin";
            typeButton.Width = 110;
            typeButton.Height = 23;
            typeButton.Tag = (Button)sender;
            typeButton.Click += TypeButton_Click;
            typeButton.Location = new Point(0, 0);
            type1Button.Text = "Padaryti Ne_Admin";
            type1Button.Width = 110;
            type1Button.Height = 23;
            type1Button.Tag = (Button)sender;
            type1Button.Click += Type1Button_Click;
            type1Button.Location = new Point(0, 23);
            deleteButton.Click += DeleteButton_Click;
            deleteButton.Text = ">>";
            deleteButton.Width = 110;
            deleteButton.Height = 23;
            deleteButton.Tag = (Button)sender;
            deleteButton.Location = new Point(0, 46);
            toolPanel.Controls.Add(typeButton);
            toolPanel.Controls.Add(deleteButton);
            toolPanel.Controls.Add(type1Button);
        }
        private void DeletedButton_Click(object sender, EventArgs e)
        {
            toolPanel.Visible = false;
            revivePanel.Visible = true;
            Button b = (Button)sender;
            Naudotojai u = (Naudotojai)b.Tag;
            ID = u.GetID().ToString();
            Button reviveButton = new Button();
            reviveButton.Text = "<<";
            reviveButton.Width = 110;
            reviveButton.Height = 23;
            reviveButton.Tag = (Button)sender;
            reviveButton.Click += ReviveButton_Click;
            reviveButton.Location = new Point(0, 0);
            revivePanel.Controls.Add(reviveButton);
        }
        string ID;
        private void TypeButton_Click(object sender, EventArgs e)
        {
            int i = 1;
            nc = new NaudotojaiController(i, Convert.ToInt32(ID), "");
            DB db = new DB(uzr, naud);
            db.controller = nc;
            db.Update();

            Form2_Load(sender, e);
        }
        private void Type1Button_Click(object sender, EventArgs e)
        {
            int i = 0;
            nc = new NaudotojaiController(i, Convert.ToInt32(ID), "");
            DB db = new DB(uzr, naud);
            db.controller = nc;
            db.Update();

            Form2_Load(sender, e);
        }
        private void ReviveButton_Click(object sender, EventArgs e)
        {
            nc = new NaudotojaiController(0, Convert.ToInt32(ID), "Login(username, password, type) select username, password, type from DeletedLogin where ID = '" + ID + "'");
            DB db = new DB(uzr, naud);
            db.controller = nc;
            db.Insert();
            nc = new NaudotojaiController(0, Convert.ToInt32(ID), "[DeletedLogin] where ID='" + ID + "'");
            db.controller = nc;
            db.Delete();

            Form2_Load(sender, e);
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            nc = new NaudotojaiController(0, Convert.ToInt32(ID), "DeletedLogin(username, password, type) select username, password, type from Login where ID = '" + ID + "'");
            DB db = new DB(uzr, naud);
            db.controller = nc;
            db.Insert();
            nc = new NaudotojaiController(0, Convert.ToInt32(ID), "[Login] where ID='" + ID + "'");
            db.controller = nc;
            db.Delete();

            Form2_Load(sender, e);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Prisijungimas p = new Prisijungimas();
            p.Show();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
