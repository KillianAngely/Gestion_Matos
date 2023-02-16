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
    public partial class New_Connexion : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=Gestion_matos;Trusted_Connection=True;");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        public New_Connexion()
        {
            InitializeComponent();
        }
        private void buttonCreate_Click_1(object sender, EventArgs e)
        {
            string Username = textBoxUsername.Text;
            string Password = textBoxPassword.Text;
            string ConfirmPassword = textBoxConfirmPassword.Text;

            try
            {
                conn.Open();

                // Vérifier si le nom d'utilisateur existe déjà dans la table
                cmd = new SqlCommand("SELECT * FROM Login WHERE Name = @Username", conn);
                cmd.Parameters.AddWithValue("@Username", Username);
                adpt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adpt.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Username already exists");
                }
                else
                {
                    if (Password == ConfirmPassword)
                    {
                        // Convertir le mot de passe en tableau de bytes
                        byte[] passwordBytes = Encoding.UTF8.GetBytes(Password);

                        // Créer un objet SHA-256
                        using (SHA256 sha256 = SHA256.Create())
                        {
                            // Calculer le hachage du mot de passe
                            byte[] hashBytes = sha256.ComputeHash(passwordBytes);

                            // Convertir le hachage en une chaîne hexadécimale
                            string hashedPassword = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

                            try
                            {
                                // Créer la commande SQL avec les paramètres Username et Password hashé
                                cmd = new SqlCommand("INSERT INTO Login (Name, Password) VALUES (@Username, @Password)", conn);
                                cmd.Parameters.AddWithValue("@Username", Username);
                                cmd.Parameters.AddWithValue("@Password", hashedPassword);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Account Created Successfully");
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password and Confirm Password does not match");
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
    }
}
