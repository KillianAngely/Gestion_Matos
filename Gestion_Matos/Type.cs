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
    public partial class WindowType : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=Gestion_matos;Trusted_Connection=True;");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        public WindowType()
        {
            InitializeComponent();
            fill_listbox();
        }
        void fill_listbox()
        {

            try
            {
                listBoxType.Items.Clear();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Name from Type";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    listBoxType.Items.Add(dr["Name"].ToString());
                }
                conn.Close();

            }
            catch
            {
                MessageBox.Show("Failed to Show");
            }
        }

        private void buttonCloseType_Click(object sender, EventArgs e)
        {
            WindowDashboard windowDashboard = new WindowDashboard();
            windowDashboard.Show();
            this.Close();
        }

        private void listBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Name from Type where Name='" + listBoxType.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBoxNameType.Text = dr["Name"].ToString();
            }
            conn.Close();

        }

        private void buttonAddType_Click(object sender, EventArgs e)
        {
            string valueName = textBoxNameType.Text.ToString();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Type values (@Name)", conn);
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

        private void buttonRemoveType_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Type where Name='" + textBoxNameType.Text + "'";
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
    }
}
