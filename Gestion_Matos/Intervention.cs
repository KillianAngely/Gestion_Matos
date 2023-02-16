using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Matos
{
    public partial class WindowIntervention : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=Gestion_matos;Trusted_Connection=True;");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        public WindowIntervention()
        {
            InitializeComponent();
            fill_listbox();
        }
        void fill_listbox()
        {
            try{
                conn.Open();
                cmd = new SqlCommand("SELECT i.Id_inter, i.Date_inter, i.Comment, t.Name_tech AS Name_tech, " +
                    " m.Name_Mat AS Name_Mat, s.Name_Site AS Name_site, c.Name AS Name_customer , w.Name AS Name_Type " +
                    "FROM Intervention i JOIN Technician t ON i.Id_tech = t.Id_tech " +
                    "JOIN Material m ON i.Id_Mat = m.Id_Mat JOIN Site s ON i.Id_site = s.Id_site LEFT JOIN Customers c ON m.Id_cust = c.Id_Cust " +
                    "LEFT JOIN Type w On m.Id_Type = w.Id_Type", conn);
                adpt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adpt.Fill(dt);
                foreach(DataRow dr in dt.Rows)
                {
                    DateTime date = Convert.ToDateTime(dr["Date_inter"]);
                    string formattedDate = date.ToString("dd-MM-yyyy");
                    string line = String.Format("{0} | {1}", formattedDate, dr["Name_Mat"]);
                    listBox1.Items.Add(line);
                    conn.Close();   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0) // Vérifie si un élément est sélectionné
            {
                DataRow row = dt.Rows[listBox1.SelectedIndex]; // Récupère la ligne sélectionnée
                string date = row["Date_inter"].ToString(); // Récupère la valeur de la colonne "Date_inter"
                dateTimePickerInter.Text = date; // Remplit la TextBox avec la valeur de "Date_inter"
                string Technician = row["Name_tech"].ToString();
                textBoxtechnician.Text = Technician;
                string Customers = row["Name_customer"].ToString();
                textBoxCustomers.Text = Customers;
                string Material = row["Name_Mat"].ToString();
                textBoxMaterial.Text = Material;
                string Type = row["Name_Type"].ToString(); // Récupère la valeur de la colonne "Name_Type"
                textBoxType.Text = Type; // Remplit la TextBox avec la valeur de "Name_Type"
                string comment = row["Comment"].ToString(); // Récupère la valeur de la colonne "Comment"
                textBox1.Text = comment; // Remplit la TextBox avec la valeur de "Comment"
            }

        }

        void checkMTBF()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT i.Id_inter, i.Date_inter, i.Comment, t.Name_tech AS Name_tech, m.Name_Mat AS Name_Mat," +
                    " s.Name_Site AS Name_site, c.Name AS Name_customer , w.Name AS Name_Type , m.MTBF as MTBF FROM Intervention i " +
                    "JOIN Technician t ON i.Id_tech = t.Id_tech JOIN Material m ON i.Id_Mat = m.Id_Mat JOIN Site s ON i.Id_site = s.Id_site " +
                    "LEFT JOIN Customers c ON m.Id_cust = c.Id_Cust LEFT JOIN Type w On m.Id_Type = w.Id_Type", conn);
                //recupére le MTBF 

            }
            catch
            {
                MessageBox.Show("Failed to show !");
            }
        }

        private void WindowIntervention_Load(object sender, EventArgs e)
        {
            checkMTBF();
        }
    }
}
