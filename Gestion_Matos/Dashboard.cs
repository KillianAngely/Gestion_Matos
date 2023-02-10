using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Matos
{
    public partial class WindowDashboard : Form
    {
        public WindowDashboard()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            WindowCustomers windowCustomers= new WindowCustomers();
            windowCustomers.Show();
            this.Hide();    
        }

        private void buttonSites_Click(object sender, EventArgs e)
        {
            WindowSite windowSite= new WindowSite();
            windowSite.Show();
            this.Hide();
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            WindowMaterial windowMaterial= new WindowMaterial();    
            windowMaterial.Show();
            this.Hide();
        }

        private void buttonBrand_Click(object sender, EventArgs e)
        {
            WindowBrand windowBrand= new WindowBrand();
            windowBrand.Show();
            this.Hide();
        }

        private void buttonType_Click(object sender, EventArgs e)
        {
            WindowType windowType= new WindowType();
            windowType.Show();
            this.Hide();
        }

        private void buttonIntervention_Click(object sender, EventArgs e)
        {
            WindowIntervention windowIntervention = new WindowIntervention();
            windowIntervention.Show();
            this.Hide();
        }

        private void buttonTechnician_Click(object sender, EventArgs e)
        {
            WindowTecnician windowTecnician= new WindowTecnician();
            windowTecnician.Show();
            this.Hide();
        }

        private void WindowDashboard_Load(object sender, EventArgs e)
        {
            Form_login_window dlg = new Form_login_window();
            dlg.ShowDialog();
        }
    }
}
