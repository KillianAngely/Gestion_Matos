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
    public partial class WindowBrand : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=Gestion_matos;Trusted_Connection=True;");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        public WindowBrand()
        {
            InitializeComponent();
            fill_listbox();
        }

        void fill_listbox()
        {

            try
            {
                listBoxBrand.Items.Clear();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Name from Brand";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    listBoxBrand.Items.Add(dr["Name"].ToString());
                }
                conn.Close();

            }
            catch
            {
                MessageBox.Show("Failed to Show");
            }
        }

        private void listBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Name from Brand where Name='" + listBoxBrand.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBoxName.Text = dr["Name"].ToString();
            }
            conn.Close();

        }

        private void buttonAddsite_Click(object sender, EventArgs e)
        {
            string valueName = textBoxName.Text.ToString();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Brand values (@Name)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Name", valueName);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has sucessfully registered");
                conn.Close();
                fill_listbox();
            }
            catch
            {
                MessageBox.Show("Failed to add ");
            }
        }

        private void buttonRemovesite_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Brand where Name='" + textBoxName.Text + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                fill_listbox();
                MessageBox.Show("Data has sucessfully registered");
            }
            catch
            {
                MessageBox.Show("Failed to delete ");
            }
        }

        private void WindowBrand_Load(object sender, EventArgs e)
        {

        }
    }
      
}