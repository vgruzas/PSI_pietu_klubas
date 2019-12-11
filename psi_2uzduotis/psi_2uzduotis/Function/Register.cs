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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text == "" || pswTextBox.Text == ""|| regPswTextBox.Text == "")
            {
                MessageBox.Show("Įveskite visus duomenis!");
            }
            else
            {
                if(regPswTextBox.Text == pswTextBox.Text)
                {
                    try
                    {
                        string connString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
                        SqlConnection conn = new SqlConnection(connString);
                        SqlCommand command = conn.CreateCommand();
                        command.CommandType = CommandType.Text;
                        conn.Open();
                        try
                        {
                            SqlCommand check_User_Name = new SqlCommand("SELECT * FROM Login WHERE username = '" + loginTextBox.Text + "'", conn);
                            int UserExist = (int)check_User_Name.ExecuteScalar();
                            MessageBox.Show("Toks vartotojo vardas jau užimtas!");
                            loginTextBox.Text = "";
                            pswTextBox.Text = "";
                            regPswTextBox.Text = "";
                            loginTextBox.Select();
                            conn.Close();
                        }
                        catch (System.NullReferenceException)
                        {
                            command.CommandText = "insert Login (username, password, type) VALUES ('" + loginTextBox.Text + "', '" + pswTextBox.Text + "', 0)";
                            command.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Registracija sėkminga! Galite prisijungti su savo vartotojo vardu ir slaptažodžiu!");
                            this.Hide();
                            Prisijungimas p = new Prisijungimas();
                            p.Show();
                        }
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        System.Windows.Forms.MessageBox.Show("Patikrinkite ar duomenų bazė yra pasiekiama!");
                        System.Windows.Forms.Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Jūsų pakartotinai įvestas slaptažodis nesutampa pirmu įvestu slaptažodžiu!");
                    regPswTextBox.Text = "";
                    pswTextBox.Text = "";
                    pswTextBox.Select();
                }
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
            if (e.KeyCode == Keys.Enter)
            {
                regPswTextBox.Select();
            }
        }

        private void RegPswTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                regButton.PerformClick();
            }
        }

        private void BackLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Prisijungimas p = new Prisijungimas();
            p.Show();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
