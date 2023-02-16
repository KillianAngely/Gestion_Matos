using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Matos
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=Gestion_matos;Trusted_Connection=True");
        public Login()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string username = textBoxName.Text;
            string password = textBoxPassword.Text;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Password FROM Login WHERE Name = @Username", conn);
                cmd.Parameters.AddWithValue("@Username", username);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string hashedPassword = reader.GetString(0);

                    // Compute hash of the entered password
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                    using (SHA256 sha256 = SHA256.Create())
                    {
                        byte[] hashBytes = sha256.ComputeHash(passwordBytes);
                        string hashedInputPassword = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

                        if (hashedInputPassword == hashedPassword)
                        {
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Username or Password is incorrect");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
