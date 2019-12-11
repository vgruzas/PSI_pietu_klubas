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
    public partial class Prisijungimas : Form
    {
        public Prisijungimas()
        {
            InitializeComponent();
        }
        private Form1 f1;
        private Form2 f2;
        private Register r;
        public static string usrn;
        int retries = 0;
        Naudotojai naud;
        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                conn.Open();
                if (loginTextBox.Text == "" || pswTextBox.Text == "")
                {
                    MessageBox.Show("Įveskite prisijungimo vardą ir slaptažodį!");
                }
                else
                {
                    command.CommandText = "select * from [Login] where username ='" + loginTextBox.Text + "'";
                    SqlDataReader reader = command.ExecuteReader();
                    int i = 0;
                    while (reader.Read())
                    {
                        naud = new Naudotojai(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), Convert.ToInt32(reader[3]));
                        i++;
                    }
                    if (i == 0)
                    {
                        retries++;
                        MessageBox.Show("Neteisingas prisijungimo vardas arba slaptažodis!");
                        loginTextBox.Text = "";
                        pswTextBox.Text = "";
                        loginTextBox.Select();
                    }
                    else
                    {
                        usrn = naud.GetVardas();

                        if (naud.GetSlap().TrimEnd() == pswTextBox.Text)
                        {
                            this.Hide();
                            if (naud.GetTypeN() == 0)
                            {
                                f1 = new Form1();
                                f1.Show();
                            }
                            else
                            {
                                f2 = new Form2();
                                f2.Show();
                            }
                        }
                        else
                        {
                            retries++;
                            MessageBox.Show("Neteisingas prisijungimo vardas arba slaptažodis!");
                            loginTextBox.Text = "";
                            pswTextBox.Text = "";
                            loginTextBox.Select();
                        }
                    }
                    if (retries > 2) Application.Exit();
                    conn.Close();
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                System.Windows.Forms.MessageBox.Show("Patikrinkite ar duomenų bazė yra pasiekiama!");
                System.Windows.Forms.Application.Exit();
            }
        }
        private void LoginTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pswTextBox.Select();
            }
        }
        private void PswTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                loginButton.PerformClick();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            r = new Register();
            this.Hide();
            r.Show();
        }

        private void Prisijungimas_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Prisijungimas_Load(object sender, EventArgs e)
        {

        }
    }
}
