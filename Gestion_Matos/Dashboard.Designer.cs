namespace Gestion_Matos
{
    partial class WindowDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxProducts = new System.Windows.Forms.GroupBox();
            this.buttonType = new System.Windows.Forms.Button();
            this.buttonBrand = new System.Windows.Forms.Button();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.groupBoxIntervention = new System.Windows.Forms.GroupBox();
            this.buttonTechnician = new System.Windows.Forms.Button();
            this.buttonIntervention = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label_name_gestion_matos = new System.Windows.Forms.Label();
            this.buttonSites = new System.Windows.Forms.Button();
            this.groupBoxCustomers = new System.Windows.Forms.GroupBox();
            this.buttonCustomers = new System.Windows.Forms.Button();
            this.buttonNew_User = new System.Windows.Forms.Button();
            this.groupBoxProducts.SuspendLayout();
            this.groupBoxIntervention.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBoxCustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxProducts
            // 
            this.groupBoxProducts.Controls.Add(this.buttonType);
            this.groupBoxProducts.Controls.Add(this.buttonBrand);
            this.groupBoxProducts.Controls.Add(this.buttonProducts);
            this.groupBoxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProducts.Location = new System.Drawing.Point(344, 106);
            this.groupBoxProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxProducts.Name = "groupBoxProducts";
            this.groupBoxProducts.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxProducts.Size = new System.Drawing.Size(304, 389);
            this.groupBoxProducts.TabIndex = 1;
            this.groupBoxProducts.TabStop = false;
            this.groupBoxProducts.Text = "Manage Products";
            // 
            // buttonType
            // 
            this.buttonType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonType.Location = new System.Drawing.Point(9, 277);
            this.buttonType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonType.Name = "buttonType";
            this.buttonType.Size = new System.Drawing.Size(286, 83);
            this.buttonType.TabIndex = 3;
            this.buttonType.Text = "Type";
            this.buttonType.UseVisualStyleBackColor = true;
            this.buttonType.Click += new System.EventHandler(this.buttonType_Click);
            // 
            // buttonBrand
            // 
            this.buttonBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrand.Location = new System.Drawing.Point(9, 168);
            this.buttonBrand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBrand.Name = "buttonBrand";
            this.buttonBrand.Size = new System.Drawing.Size(286, 83);
            this.buttonBrand.TabIndex = 2;
            this.buttonBrand.Text = "Brand";
            this.buttonBrand.UseVisualStyleBackColor = true;
            this.buttonBrand.Click += new System.EventHandler(this.buttonBrand_Click);
            // 
            // buttonProducts
            // 
            this.buttonProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProducts.Location = new System.Drawing.Point(9, 46);
            this.buttonProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(286, 83);
            this.buttonProducts.TabIndex = 1;
            this.buttonProducts.Text = "Products";
            this.buttonProducts.UseVisualStyleBackColor = true;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // groupBoxIntervention
            // 
            this.groupBoxIntervention.Controls.Add(this.buttonTechnician);
            this.groupBoxIntervention.Controls.Add(this.buttonIntervention);
            this.groupBoxIntervention.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxIntervention.Location = new System.Drawing.Point(657, 106);
            this.groupBoxIntervention.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxIntervention.Name = "groupBoxIntervention";
            this.groupBoxIntervention.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxIntervention.Size = new System.Drawing.Size(304, 275);
            this.groupBoxIntervention.TabIndex = 2;
            this.groupBoxIntervention.TabStop = false;
            this.groupBoxIntervention.Text = "Manage Intervention";
            // 
            // buttonTechnician
            // 
            this.buttonTechnician.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTechnician.Location = new System.Drawing.Point(9, 168);
            this.buttonTechnician.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTechnician.Name = "buttonTechnician";
            this.buttonTechnician.Size = new System.Drawing.Size(286, 83);
            this.buttonTechnician.TabIndex = 2;
            this.buttonTechnician.Text = "Technician";
            this.buttonTechnician.UseVisualStyleBackColor = true;
            this.buttonTechnician.Click += new System.EventHandler(this.buttonTechnician_Click);
            // 
            // buttonIntervention
            // 
            this.buttonIntervention.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIntervention.Location = new System.Drawing.Point(9, 46);
            this.buttonIntervention.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonIntervention.Name = "buttonIntervention";
            this.buttonIntervention.Size = new System.Drawing.Size(286, 83);
            this.buttonIntervention.TabIndex = 1;
            this.buttonIntervention.Text = "Intervention";
            this.buttonIntervention.UseVisualStyleBackColor = true;
            this.buttonIntervention.Click += new System.EventHandler(this.buttonIntervention_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 68);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(140, 32);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(140, 32);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(657, 488);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(286, 68);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label_name_gestion_matos
            // 
            this.label_name_gestion_matos.AutoSize = true;
            this.label_name_gestion_matos.Location = new System.Drawing.Point(428, 563);
            this.label_name_gestion_matos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name_gestion_matos.Name = "label_name_gestion_matos";
            this.label_name_gestion_matos.Size = new System.Drawing.Size(155, 20);
            this.label_name_gestion_matos.TabIndex = 5;
            this.label_name_gestion_matos.Text = "Gestion-Matos-2022";
            // 
            // buttonSites
            // 
            this.buttonSites.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSites.Location = new System.Drawing.Point(9, 168);
            this.buttonSites.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSites.Name = "buttonSites";
            this.buttonSites.Size = new System.Drawing.Size(286, 83);
            this.buttonSites.TabIndex = 2;
            this.buttonSites.Text = "Sites";
            this.buttonSites.UseVisualStyleBackColor = true;
            this.buttonSites.Click += new System.EventHandler(this.buttonSites_Click);
            // 
            // groupBoxCustomers
            // 
            this.groupBoxCustomers.Controls.Add(this.buttonCustomers);
            this.groupBoxCustomers.Controls.Add(this.buttonSites);
            this.groupBoxCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCustomers.Location = new System.Drawing.Point(18, 106);
            this.groupBoxCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxCustomers.Name = "groupBoxCustomers";
            this.groupBoxCustomers.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxCustomers.Size = new System.Drawing.Size(316, 275);
            this.groupBoxCustomers.TabIndex = 0;
            this.groupBoxCustomers.TabStop = false;
            this.groupBoxCustomers.Text = "Manage Customers";
            // 
            // buttonCustomers
            // 
            this.buttonCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomers.Location = new System.Drawing.Point(9, 46);
            this.buttonCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCustomers.Name = "buttonCustomers";
            this.buttonCustomers.Size = new System.Drawing.Size(286, 83);
            this.buttonCustomers.TabIndex = 3;
            this.buttonCustomers.Text = "Customers";
            this.buttonCustomers.UseVisualStyleBackColor = true;
            this.buttonCustomers.Click += new System.EventHandler(this.buttonCustomers_Click);
            // 
            // buttonNew_User
            // 
            this.buttonNew_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew_User.Location = new System.Drawing.Point(657, 407);
            this.buttonNew_User.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNew_User.Name = "buttonNew_User";
            this.buttonNew_User.Size = new System.Drawing.Size(286, 71);
            this.buttonNew_User.TabIndex = 6;
            this.buttonNew_User.Text = "New user ";
            this.buttonNew_User.UseVisualStyleBackColor = true;
            this.buttonNew_User.Click += new System.EventHandler(this.buttonNew_User_Click);
            // 
            // WindowDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 597);
            this.Controls.Add(this.buttonNew_User);
            this.Controls.Add(this.label_name_gestion_matos);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxIntervention);
            this.Controls.Add(this.groupBoxProducts);
            this.Controls.Add(this.groupBoxCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowDashboard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "GestionMatos";
            this.Load += new System.EventHandler(this.WindowDashboard_Load);
            this.groupBoxProducts.ResumeLayout(false);
            this.groupBoxIntervention.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBoxCustomers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxProducts;
        private System.Windows.Forms.Button buttonType;
        private System.Windows.Forms.Button buttonBrand;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.GroupBox groupBoxIntervention;
        private System.Windows.Forms.Button buttonTechnician;
        private System.Windows.Forms.Button buttonIntervention;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label_name_gestion_matos;
        private System.Windows.Forms.Button buttonSites;
        private System.Windows.Forms.GroupBox groupBoxCustomers;
        private System.Windows.Forms.Button buttonCustomers;
        private System.Windows.Forms.Button buttonNew_User;
    }
}