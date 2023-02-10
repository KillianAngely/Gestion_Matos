using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Matos
{
    public partial class WindowTecnician : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=Gestion_matos;Trusted_Connection=True;");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        public WindowTecnician()
        {
            InitializeComponent();
            fill_data();
        }

        void fill_data()
        {

            try
            {   
                    dataGridView1.Update();
                    adpt = new SqlDataAdapter("select * from Technician", conn);
                    dt = new DataTable();
                    adpt.Fill(dt);
                    dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Failed to Show");
            }
        }


        private void buttonTech_Click(object sender, EventArgs e)
        {
            WindowDashboard windowDashboard = new WindowDashboard();
            windowDashboard.Show();
            this.Close();
        }

        private void buttonAddTech_Click(object sender, EventArgs e)
        {
            string valuePhone = textBoxPhoneTech.Text.ToString();
            string valueName = textBoxNameTech.Text.ToString();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Technician values (@Name,@Phone)", conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@Name", valueName);
                cmd.Parameters.AddWithValue("@Phone", valuePhone);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has sucessfully registered");
                conn.Close();
                fill_data();
            }

            catch
            {
                MessageBox.Show("SQL error Failed to Add");
            }
        }

        private void buttonModifyTech_Click(object sender, EventArgs e)
        {
            string selected_eid = dataGridView1.CurrentRow.Cells["Id_Tech"].Value.ToString();
            string selected_Phone = textBoxPhoneTech.Text.ToString();
            string select_Name = textBoxNameTech.Text.ToString();

            try
            {

                conn.Open();
                SqlCommand update_row = new SqlCommand(" UPDATE Technician SET Name = @Name, Phone = @Phone WHERE Id_Tech = @Id_Tech ", conn);

                update_row.Parameters.AddWithValue("@Id_Tech", selected_eid);
                update_row.Parameters.AddWithValue("@Name", select_Name);
                update_row.Parameters.AddWithValue("@Phone", selected_Phone);
                update_row.ExecuteNonQuery();
                MessageBox.Show("Data has sucessfully modify");
                conn.Close();
                fill_data();
            }
            catch
            {
                MessageBox.Show("Failed To modify");
            }
        }
            private void buttonRemoveTech_Click(object sender, EventArgs e)
        {
            string selected_eid = dataGridView1.CurrentRow.Cells["Id_tech"].Value.ToString();
            string select_Name = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            string select_Phone = dataGridView1.CurrentRow.Cells["Phone"].Value.ToString();

            try
            {
                SqlCommand delete_row = new SqlCommand("delete from Technician where Id_tech = @Id_tech AND Name = @Name AND Phone = @Phone", conn);

                conn.Open();

                delete_row.Parameters.AddWithValue("@Id_tech", selected_eid);
                delete_row.Parameters.AddWithValue("@Name", select_Name);
                delete_row.Parameters.AddWithValue("@Phone", select_Phone);

                delete_row.ExecuteNonQuery();

                conn.Close();
                fill_data();

            }
            catch
            {
                MessageBox.Show("Failed to Delete");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];


            textBoxNameTech.Text = row.Cells["Name"].Value.ToString();
            textBoxPhoneTech.Text = row.Cells["Phone"].Value.ToString();
        }
    }
}
