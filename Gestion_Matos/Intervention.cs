using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsGMF;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestion_Matos
{
    public partial class WindowIntervention : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=Gestion_matos;Trusted_Connection=True;");
        SqlCommand cmd;
        SqlDataReader rd;
        SqlDataAdapter adpt;
        DataTable dt;
        int ids;
        int idm;
        int idt;
        public WindowIntervention()
        {
            InitializeComponent();
            showdata();
            fill_material();
            fill_tech();
        }

        void showdata()
        {
            adpt = new SqlDataAdapter("select i.Id_inter as Id_inter , i.Date_inter as Date_inter , " +
                "i.Comment as Comment , t.Name_tech as Name_tech , m.Name_Mat as Name_Mat , s.Name_site as Name_site " +
                "from Intervention i join Technician t on t.Id_tech = i.Id_tech " +
                "join Material m on  m.Id_Mat = i.Id_Mat join Site s on s.Id_site = i.Id_site", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void fill_tech() {
            try
            {
                comboBoxtechInt.Items.Clear();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Id_tech, Name_tech from Technician";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                
                foreach (DataRow dr in dt.Rows)
                {
                    comboBoxtechInt.Items.Add(dr["Name_tech"].ToString());
                    idt = Convert.ToInt32(dr["Id_tech"].ToString());

                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Failed to Show");
            }
        }

        void completeCombo(){
            try
                {
                string Material = comboBoxmaterint.Text;
                string sql = "Select s.Id_site as idsite, s.Name_Site as Name_Site from Material i join Site s on" +
                    " i.Id_site = s.Id_site where Name_Mat = @Name_Mat";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Name_Mat", Material);
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    textBoxSite.Text = rd["Name_Site"].ToString();
                    ids = Convert.ToInt32(rd["idsite"].ToString());
                }
                conn.Close();
                    
            }
            catch
            {
                MessageBox.Show("Failed to Show Combobox");
            }

            }
        void fill_material()
        {
            try
            {
                comboBoxmaterint.Items.Clear();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Id_Mat ,Name_Mat from Material";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                    
                {
                    comboBoxmaterint.Items.Add(dr["Name_Mat"].ToString());
                    idm = Convert.ToInt32(dr["Id_Mat"]);
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Failed to Show");
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            WindowDashboard windowDashboard = new WindowDashboard();
            windowDashboard.Show();
            this.Close();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            dateTimePickerinter.Text = row.Cells["Date_inter"].Value.ToString();
            textBoxComment.Text = row.Cells["Comment"].Value.ToString();
            comboBoxmaterint.Text = row.Cells["Name_Mat"].Value.ToString();
            comboBoxtechInt.Text = row.Cells["Name_tech"].Value.ToString();
            textBoxSite.Text = row.Cells["Name_site"].Value.ToString();
        }

        private void comboBoxmaterint_SelectedIndexChanged(object sender, EventArgs e)
        {
            completeCombo();
        }

        private void buttonAddInt_Click(object sender, EventArgs e)
        {
            string datinstall = dateTimePickerinter.Value.ToString("yyyy-MM-dd");



            try
                    {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Intervention (Date_inter,Comment,Id_tech,Id_Mat,Id_site) values (@Date_inter,@Comment,@Id_tech,@Id_Mat,@Id_site)", conn);
                cmd.Parameters.AddWithValue("@Date_inter", datinstall);
                cmd.Parameters.AddWithValue("@Comment", textBoxComment.Text);
                cmd.Parameters.AddWithValue("@Id_tech", idt);
                cmd.Parameters.AddWithValue("@Id_Mat",  idm);
                cmd.Parameters.AddWithValue("@Id_site", ids);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Intervention Added");
                conn.Close();
                showdata();
            }
            catch
            {
                MessageBox.Show("Failed to Add Intervention");
            }
        }
        
        private void buttonRemoveInst_Click(object sender, EventArgs e)
        {
            string selected_inter = dataGridView1.CurrentRow.Cells["Id_inter"].Value.ToString();
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("delete from Intervention where Id_inter = @Id_inter", conn);
                cmd.Parameters.AddWithValue("@Id_inter",selected_inter );
                cmd.ExecuteNonQuery();
                MessageBox.Show("Intervention Deleted");
                conn.Close();
                showdata();
            }
            catch
            {
                MessageBox.Show("Failed to Delete Intervention");
            }
        }

        private void buttonModifyInst_Click(object sender, EventArgs e)
        {
            string datinstall = dateTimePickerinter.Value.ToString("yyyy-MM-dd");
            string selected_inter = dataGridView1.CurrentRow.Cells["Id_inter"].Value.ToString();
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("update Intervention set Date_inter = @Date_inter, Comment = @Comment, Id_tech = @Id_tech, Id_Mat = @Id_Mat, Id_site = @Id_site where Id_inter = @Id_inter", conn);
                cmd.Parameters.AddWithValue("@Date_inter", datinstall);
                cmd.Parameters.AddWithValue("@Comment", textBoxComment.Text);
                cmd.Parameters.AddWithValue("@Id_tech", idt);
                cmd.Parameters.AddWithValue("@Id_Mat", idm);
                cmd.Parameters.AddWithValue("@Id_site", ids);
                cmd.Parameters.AddWithValue("@Id_inter", selected_inter );
                cmd.ExecuteNonQuery();
                MessageBox.Show("Intervention Modified");
                conn.Close();
                showdata();
            }
            catch
            {
                MessageBox.Show("Failed to Modify Intervention");
            }
        }
    }
}
