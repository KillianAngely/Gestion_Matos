using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    public partial class Form_login_window : Form
    {

        SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=Gestion_matos;Trusted_Connection=True");

        public Form_login_window()
        {
            InitializeComponent();
        }

        private void button_connexion_Click(object sender, EventArgs e)
        {

            this.Close();
            // aaaaaaaaaaaaaaaaaaaaaaaaa



            string UsernameValue, PasswordValue;
            UsernameValue = textBox_login.Text;
            PasswordValue = textBox_password.Text;

            try
            {
                String querry = ("Select * from Login where Name ='" + textBox_login.Text+"'And Password ='"+textBox_password.Text+"'");
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    UsernameValue = textBox_login.Text;
                    PasswordValue = textBox_password.Text;
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("SQL Error failed to connect.");
            }
            finally
            {
                conn.Close();
            }
          
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
