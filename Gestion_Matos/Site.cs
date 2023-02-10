using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Gestion_Matos
{
    public partial class WindowSite : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=Gestion_matos;Trusted_Connection=True;");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;


        public WindowSite()
        {
            InitializeComponent();
            Showdata_site();

        }

        void Showdata_site()
        {


            try
            {
                dataGridView1.Update();
                adpt = new SqlDataAdapter("select * from Site", conn);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Failed to show Data");
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            WindowDashboard windowDashboard = new WindowDashboard();
            windowDashboard.Show();
            this.Close();
        }

        private void buttonAddsite_Click(object sender, EventArgs e)
        {
            string NameSites = textBoxName.Text.ToString();
            string NamePostcode = textBoxPostCode.Text.ToString();
            string NameCity = textBoxCity.Text.ToString();
            string NameAdress = textBoxAdress.Text.ToString();

            try
            {
                SqlCommand cmd = new SqlCommand(" Insert into Site values (@Name,@Postcode,@City,@Adress)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Name", NameSites);
                cmd.Parameters.AddWithValue("@Postcode", NamePostcode);
                cmd.Parameters.AddWithValue("@City", NameCity);
                cmd.Parameters.AddWithValue("@Adress", NameAdress);
                cmd.ExecuteNonQuery(); 
                Showdata_site();
                conn.Close();
                MessageBox.Show("Your data has succesfully added");
            }
            catch
            {
                MessageBox.Show("Failed to Add");
            }
        }

        private void buttonRemovesite_Click(object sender, EventArgs e)
        {
            string selected_eid = dataGridView1.CurrentRow.Cells["Id_site"].Value.ToString();
            string selected_Name= dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            string selected_Postcode = dataGridView1.CurrentRow.Cells["Postcode"].Value.ToString();
            string selected_City = dataGridView1.CurrentRow.Cells["City"].Value.ToString();
            string selected_Adress = dataGridView1.CurrentRow.Cells["Adress"].Value.ToString();
            try
            {
                SqlCommand cmd  = new SqlCommand(" delete from Site where Id_site = @Id_site AND Name = @Name AND Postcode = @Postcode AND City = @City AND Adress = @Adress", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Id_site", selected_eid);
                cmd.Parameters.AddWithValue("@Name", selected_Name);
                cmd.Parameters.AddWithValue("@Postcode", selected_Postcode);
                cmd.Parameters.AddWithValue("@City", selected_City);
                cmd.Parameters.AddWithValue("@Adress", selected_Adress);
                cmd.ExecuteNonQuery();
                Showdata_site();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Failed to delete");
            }
        }

        private void buttonModifysite_Click(object sender, EventArgs e)
        {
            string selected_eid = dataGridView1.CurrentRow.Cells["Id_site"].Value.ToString();
            string NameSites = textBoxName.Text.ToString();
            string NamePostcode = textBoxPostCode.Text.ToString();
            string NameCity = textBoxCity.Text.ToString();
            string NameAdress = textBoxAdress.Text.ToString();

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Site SET Name = @Name, Postcode = @Postcode, City = @City, Adress = @Adress WHERE Id_site = @Id_site", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("Id_site", selected_eid);
                cmd.Parameters.AddWithValue("Name", NameSites);
                cmd.Parameters.AddWithValue("Postcode", NamePostcode);
                cmd.Parameters.AddWithValue("City", NameCity);
                cmd.Parameters.AddWithValue("Adress", NameAdress);
                cmd.ExecuteNonQuery();
                Showdata_site();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Failed to update");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];


            textBoxName.Text = row.Cells["Name"].Value.ToString();
            textBoxAdress.Text = row.Cells["Adress"].Value.ToString();
            textBoxCity.Text = row.Cells["City"].Value.ToString();
            textBoxPostCode.Text = row.Cells["Postcode"].Value.ToString();
        }
    }
}
