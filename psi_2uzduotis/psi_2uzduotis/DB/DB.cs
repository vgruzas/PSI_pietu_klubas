using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace psi_2uzduotis
{
    class DB
    {
        public IDBOperatable controller;
        private List<Uzrasai> uzr = new List<Uzrasai>();
        private List<Naudotojai> naud = new List<Naudotojai>();

        public DB(List<Uzrasai> uzr, List<Naudotojai> naud)
        {
            this.uzr = uzr;
            this.naud = naud;
        }

        public void Read()
        {
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = controller.Read();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Patikrinkite ar duomenų bazė yra pasiekiama!");
                Application.Exit();
            }
        }
        public void ReadUzrasai()
        {
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = controller.Read();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Uzrasai u = new Uzrasai(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), reader[3].ToString());
                    uzr.Add(u);
                }
                conn.Close();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                System.Windows.Forms.MessageBox.Show("Patikrinkite ar duomenų bazė yra pasiekiama!");
                System.Windows.Forms.Application.Exit();
            }
        }
        public void ReadNaudotojai()
        {
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = controller.Read();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Naudotojai n = new Naudotojai(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), Convert.ToInt32(reader[3]));
                    naud.Add(n);
                }
                conn.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Patikrinkite ar duomenų bazė yra pasiekiama!");
                Application.Exit();
            }
        }
        public void Update()
        {
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = controller.Update();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Patikrinkite ar duomenų bazė yra pasiekiama!");
                Application.Exit();
            }
        }
        public void Delete()
        {
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = controller.Delete();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Patikrinkite ar duomenų bazė yra pasiekiama!");
                Application.Exit();
            }
        }
        public void Insert()
        {
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = controller.Insert();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Patikrinkite ar duomenų bazė yra pasiekiama!");
                Application.Exit();
            }
        }
    }
}
