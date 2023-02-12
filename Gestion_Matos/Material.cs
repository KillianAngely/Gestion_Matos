using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsGMF;

namespace Gestion_Matos
{
    public partial class WindowMaterial : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=Gestion_matos;Trusted_Connection=True;");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        public WindowMaterial()
        {
            InitializeComponent();
            showdata();
            showcomboBoxType();
            ShowcomboBoxBrand();
            ShowcomboxSite();
            ShowCustomer();
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            WindowDashboard windowDashboard= new WindowDashboard();
            windowDashboard.Show();
               this.Close();
        }
        private void showdata()
        {
            adpt = new SqlDataAdapter("select m.Id_Mat as Id_Mat, m.Name_Mat as nameMat, " +
                "m.Serial_Num as SerialMat, m.Date_instal as DateMat,m.MTBF as MTBFMat, " +
                "t.Name as nameType, b.Name as nameBrand, c.Name as nameCustomer ," +
                "s.Name_site as nameSite from Material m join Site s on " +
                "m.Id_site = s.Id_site join Type t on m.Id_Type = t.Id_Type join Brand b " +
                "on m.id_brand = b.id_brand join Customers c on m.Id_Cust = c.Id_Cust", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void showcomboBoxType()
        {
            try
            {
                comboBoxTypeMat.Items.Clear();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Id_Type, Name from Type";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                IdObjItem idc;
                foreach (DataRow dr in dt.Rows)
                {
                    idc = new IdObjItem(Convert.ToInt32(dr["Id_Type"]), dr["Name"].ToString());
                    comboBoxTypeMat.Items.Add(idc);
                }
                conn.Close();                
            }
            catch
            {
                MessageBox.Show("Failed to Show");
            }
        }

        private void ShowcomboBoxBrand()
        {
            try
            {
                comboBoxBrand.Items.Clear();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select id_brand, Name from Brand";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                IdObjItem idc;
                foreach (DataRow dr in dt.Rows)
                {
                    idc = new IdObjItem(Convert.ToInt32(dr["id_brand"]), dr["Name"].ToString());
                    comboBoxBrand.Items.Add(idc);
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Failed to Show");
            }
        }
        private void ShowcomboxSite()
        {
            try
            {
                comboBoxSite.Items.Clear();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Id_site,Name_site from Site";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                IdObjItem idc;
                foreach (DataRow dr in dt.Rows)
                {
                    idc = new IdObjItem(Convert.ToInt32(dr["Id_site"]), dr["Name_site"].ToString());
                    comboBoxSite.Items.Add(idc);
                }
                conn.Close();

            }
            catch
            {
                MessageBox.Show("Failed to Show");
            }
        }
        private void ShowCustomer()
        {
            try
            {
                comboBoxCustomers.Items.Clear();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Id_Cust, Name from Customers";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                IdObjItem idc;
                foreach (DataRow dr in dt.Rows)
                {
                    idc = new IdObjItem(Convert.ToInt32(dr["Id_Cust"]), dr["Name"].ToString());
                    comboBoxCustomers.Items.Add(idc);
                }
                conn.Close();    


            }
            catch
            {
                MessageBox.Show("Failed to Show");
            }
        }
        private void buttonAddMat_Click(object sender, EventArgs e)
        {
            string  datinstall = dateTimePickerDateinstalMat.Value.ToString("yyyy-MM-dd");

            int idsite = ((IdObjItem)comboBoxSite.SelectedItem).ID;
            int idmat = ((IdObjItem)comboBoxTypeMat.SelectedItem).ID;
            int idbrand = ((IdObjItem)comboBoxBrand.SelectedItem).ID;
            int idcust = ((IdObjItem)comboBoxCustomers.SelectedItem).ID;


            try
            {
                if (conn.State == ConnectionState.Closed)
                   conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Material(Name_Mat,Serial_Num,Date_instal,MTBF,Id_site,Id_Type,id_brand,Id_Cust) VALUES (@Name_Mat,@Serial_Num,@Date_instal,@MTBF,@Id_site,@Id_Type,@id_brand,@Id_Cust)", conn);

                cmd.Parameters.AddWithValue("@Name_Mat", textBoxNameMat.Text);
                cmd.Parameters.AddWithValue("@Serial_Num", textBoxSerialNumberMat.Text);
                cmd.Parameters.AddWithValue("@Date_instal", datinstall);
                cmd.Parameters.AddWithValue("@MTBF", textBoxMTBFMat.Text);
                cmd.Parameters.AddWithValue("@Id_site", idsite);
                cmd.Parameters.AddWithValue("@Id_Type", idmat);
                cmd.Parameters.AddWithValue("@id_brand", idbrand);
                cmd.Parameters.AddWithValue("@Id_Cust", idcust);
                cmd.ExecuteNonQuery();
                showdata();
                MessageBox.Show("Data succesfully added !");
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Sql error failed to add");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];


            textBoxNameMat.Text = row.Cells["NameMat"].Value.ToString();
            textBoxSerialNumberMat.Text = row.Cells["SerialMat"].Value.ToString();
            comboBoxTypeMat.Text = row.Cells["nameType"].Value.ToString();
            comboBoxBrand.Text = row.Cells["nameBrand"].Value.ToString();
            dateTimePickerDateinstalMat.Text = row.Cells["DateMat"].Value.ToString();
            textBoxMTBFMat.Text = row.Cells["MTBFmat"].Value.ToString();
            comboBoxSite.Text = row.Cells["nameSite"].Value.ToString();
            comboBoxCustomers.Text = row.Cells["nameCustomer"].Value.ToString();
        }

        private void buttonModifyMat_Click(object sender, EventArgs e)
        {
            string datinstall = dateTimePickerDateinstalMat.Value.ToString("yyyy-MM-dd");

            int idsite = ((IdObjItem)comboBoxSite.SelectedItem).ID;
            int idtype = ((IdObjItem)comboBoxTypeMat.SelectedItem).ID;
            int idbrand = ((IdObjItem)comboBoxBrand.SelectedItem).ID;
            int idcust = ((IdObjItem)comboBoxCustomers.SelectedItem).ID;
            string selected_eid = dataGridView1.CurrentRow.Cells["Id_Mat"].Value.ToString();

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                 SqlCommand cmd = new SqlCommand("UPDATE Material SET Name_Mat = @Name_Mat , Serial_Num = @Serial_Num," +
                     " Date_instal = @Date_instal,MTBF = @MTBF,Id_site = @Id_site,Id_Type = @Id_Type,id_brand = @id_brand," +
                     "Id_Cust = @Id_Cust WHERE Id_Mat = @idsupermat", conn);
                cmd.Parameters.AddWithValue("@Name_Mat", textBoxNameMat.Text);
                cmd.Parameters.AddWithValue("@Serial_Num", textBoxSerialNumberMat.Text);
                cmd.Parameters.AddWithValue("@Date_instal", datinstall);
                cmd.Parameters.AddWithValue("@MTBF", textBoxMTBFMat.Text);
                cmd.Parameters.AddWithValue("@Id_site", idsite);
                cmd.Parameters.AddWithValue("@Id_Type", idtype);
                cmd.Parameters.AddWithValue("@id_brand", idbrand);
                cmd.Parameters.AddWithValue("@Id_Cust", idcust);
                cmd.Parameters.AddWithValue("@idsupermat", selected_eid);
                cmd.ExecuteNonQuery();
                showdata();
                MessageBox.Show("Data succesfully modify!");
                conn.Close();

            }
            catch
            {
                MessageBox.Show("Sql error failed to modify");
            }
        }

        private void buttonRemoveMat_Click(object sender, EventArgs e)
        {
            string selected_eid = dataGridView1.CurrentRow.Cells["Id_Mat"].Value.ToString();

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Intervention WHERE Id_Mat " +
                    "IN(SELECT Id_Mat FROM Material WHERE Id_Mat = @idsupermat)" +
                    "DELETE FROM Material WHERE Id_Mat = @idsupermat", conn) ;
                cmd.Parameters.AddWithValue("@idsupermat", selected_eid);
                cmd.ExecuteNonQuery();
                showdata();
                MessageBox.Show("Data succesfully remove!");
                conn.Close();

            }
            catch
            {
                MessageBox.Show("Sql error failed to remove");
            }
        }
    }

    }
