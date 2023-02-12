using Microsoft.SqlServer.Server;
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
    public partial class WindowCustomers : Form
    {

        SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=Gestion_matos;Trusted_Connection=True;");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;


        public WindowCustomers()
        {
            InitializeComponent();
            showdata();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            WindowDashboard windowDashboard= new WindowDashboard();
            windowDashboard.Show();
            this.Close();  
        }

        private void showdata()
        {
            adpt = new SqlDataAdapter("select * from Customers",conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void buttonAddcust_Click(object sender, EventArgs e)
        {


            string valueName = textBoxName.Text.ToString(); 
            string valueAdress = textBoxAdress.Text.ToString();
            string valuePhone = textBoxPhone.Text.ToString();
            string valueEmail = textBoxEmail.Text.ToString();

            try
            {
                SqlCommand cmd  = new SqlCommand("insert into Customers values (@Name,@Adress,@Phone,@Email)", conn);
                conn.Open();
                if (valueName != string.Empty)
                {
                    if (valueName.Length <= 50)
                    {
                        cmd.Parameters.AddWithValue("@Name", valueName);
                    } else {
                        conn.Close();
                        MessageBox.Show("Name is to length");
                    }
                }
                else {
                    conn.Close();
                    MessageBox.Show("Name is empty");
                }

                if(valueAdress != string.Empty)
                {
                    if (valueAdress.Length <= 50)
                    {
                        cmd.Parameters.AddWithValue("@Adress", valueAdress);
                    }else
                    {
                        conn.Close();
                        MessageBox.Show("your Adress is too length");
                    }
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("Adress is empty");
                }

                if (valuePhone.Length == 10)
                {
                        cmd.Parameters.AddWithValue("@Phone", valuePhone);
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("Phone is invalid");
                }

                if (valueEmail != string.Empty)
                {
                    if (valueEmail.Length <= 50)
                    {
                        cmd.Parameters.AddWithValue("@Email", valueEmail);
                    }
                    else
                    {
                        conn.Close();
                        MessageBox.Show("Email is to long");
                    }
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("Email is empty");
                }

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has sucessfully registered");
                conn.Close();
                showdata();
            }

            catch
            {
                MessageBox.Show("SQL error Failed to Add");
            }
            
        }

        private void buttonRemovecust_Click(object sender, EventArgs e)
        {
            string selected_eid = dataGridView1.CurrentRow.Cells["Id_Cust"].Value.ToString();
            string select_Name = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            string selected_email = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            string selected_Adress = dataGridView1.CurrentRow.Cells["Adress"].Value.ToString();
            string selected_Phone = dataGridView1.CurrentRow.Cells["Phone"].Value.ToString();

            try
            {     

                    SqlCommand delete_row = new SqlCommand("Delete from customers where Id_Cust = @Id_Cust ", conn);
                
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                delete_row.Parameters.AddWithValue("@Id_Cust", selected_eid);
                delete_row.Parameters.AddWithValue("@Name", select_Name);
                delete_row.Parameters.AddWithValue("@Email", selected_email);
                delete_row.Parameters.AddWithValue("@Adress", selected_Adress);
                delete_row.Parameters.AddWithValue("@Phone", selected_Phone);

                delete_row.ExecuteNonQuery();

                conn.Close();
                showdata();
                
            }
            catch
            {
                MessageBox.Show("Failed to Delete");
            }
          
        }

        private void buttonModifycust_Click(object sender, EventArgs e)
        {
            string selected_eid = dataGridView1.CurrentRow.Cells["Id_Cust"].Value.ToString();
            string select_Name = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            string selected_email = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            string selected_Adress = dataGridView1.CurrentRow.Cells["Adress"].Value.ToString();
            string selected_Phone = dataGridView1.CurrentRow.Cells["Phone"].Value.ToString();

            try
            {

                conn.Open();
                SqlCommand update_row = new SqlCommand(" UPDATE Customers SET Name = @Name, Email = @Email, Adress = @Adress, Phone = @Phone WHERE Id_Cust = @Id_Cust ", conn);
                update_row.Parameters.AddWithValue("@Id_Cust", selected_eid);
                if (select_Name != string.Empty)
                {
                    if (select_Name.Length <= 50)
                    {
                        update_row.Parameters.AddWithValue("@Name", select_Name);
                    }
                    else
                    {
                        conn.Close();
                        MessageBox.Show("Name is to length");
                    }
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("Name is empty");
                }


                if (selected_email != string.Empty)
                {
                    if (selected_email.Length <= 50)
                    {
               
                        update_row.Parameters.AddWithValue("@Adress", selected_Adress);
                    }
                    else
                    {
                        conn.Close();
                        MessageBox.Show("your Adress is too length");
                    }
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("Adress is empty");
                }

                if (selected_email != string.Empty)
                {
                    if (selected_email.Length <= 50)
                    {
                        update_row.Parameters.AddWithValue("@Email", selected_email);
                    }
                    else
                    {
                        conn.Close();
                        MessageBox.Show("Email is to long");
                    }
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("Email is empty");
                }

                
                if (selected_Phone.Length == 10)
                {
                    update_row.Parameters.AddWithValue("@Phone", selected_Phone);
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("Phone is invalid");
                }
                

                update_row.ExecuteNonQuery();
                MessageBox.Show("Data has sucessfully modify");
                conn.Close();
                showdata();
            }
            catch
            {
                MessageBox.Show("Failed To modify");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            
            textBoxName.Text = row.Cells["Name"].Value.ToString();
            textBoxAdress.Text = row.Cells["Adress"].Value.ToString();
            textBoxEmail.Text = row.Cells["Email"].Value.ToString();
            textBoxPhone.Text = row.Cells["Phone"].Value.ToString();


        }

        
    }
}
