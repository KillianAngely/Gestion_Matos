namespace Gestion_Matos
{
    partial class WindowTecnician
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
            this.buttonTech = new System.Windows.Forms.Button();
            this.buttonRemoveTech = new System.Windows.Forms.Button();
            this.buttonModifyTech = new System.Windows.Forms.Button();
            this.buttonAddTech = new System.Windows.Forms.Button();
            this.labelHeaderTechnician = new System.Windows.Forms.Label();
            this.label_name_gestion_matos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNameTech = new System.Windows.Forms.TextBox();
            this.textBoxPhoneTech = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTech
            // 
            this.buttonTech.Location = new System.Drawing.Point(394, 544);
            this.buttonTech.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTech.Name = "buttonTech";
            this.buttonTech.Size = new System.Drawing.Size(177, 68);
            this.buttonTech.TabIndex = 73;
            this.buttonTech.Text = "Close";
            this.buttonTech.UseVisualStyleBackColor = true;
            this.buttonTech.Click += new System.EventHandler(this.buttonTech_Click);
            // 
            // buttonRemoveTech
            // 
            this.buttonRemoveTech.Location = new System.Drawing.Point(15, 466);
            this.buttonRemoveTech.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemoveTech.Name = "buttonRemoveTech";
            this.buttonRemoveTech.Size = new System.Drawing.Size(182, 68);
            this.buttonRemoveTech.TabIndex = 72;
            this.buttonRemoveTech.Text = "Remove";
            this.buttonRemoveTech.UseVisualStyleBackColor = true;
            this.buttonRemoveTech.Click += new System.EventHandler(this.buttonRemoveTech_Click);
            // 
            // buttonModifyTech
            // 
            this.buttonModifyTech.Location = new System.Drawing.Point(394, 466);
            this.buttonModifyTech.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonModifyTech.Name = "buttonModifyTech";
            this.buttonModifyTech.Size = new System.Drawing.Size(173, 68);
            this.buttonModifyTech.TabIndex = 71;
            this.buttonModifyTech.Text = "Modify";
            this.buttonModifyTech.UseVisualStyleBackColor = true;
            this.buttonModifyTech.Click += new System.EventHandler(this.buttonModifyTech_Click);
            // 
            // buttonAddTech
            // 
            this.buttonAddTech.Location = new System.Drawing.Point(209, 466);
            this.buttonAddTech.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddTech.Name = "buttonAddTech";
            this.buttonAddTech.Size = new System.Drawing.Size(177, 68);
            this.buttonAddTech.TabIndex = 70;
            this.buttonAddTech.Text = "Add";
            this.buttonAddTech.UseVisualStyleBackColor = true;
            this.buttonAddTech.Click += new System.EventHandler(this.buttonAddTech_Click);
            // 
            // labelHeaderTechnician
            // 
            this.labelHeaderTechnician.AutoSize = true;
            this.labelHeaderTechnician.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderTechnician.Location = new System.Drawing.Point(229, 9);
            this.labelHeaderTechnician.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeaderTechnician.Name = "labelHeaderTechnician";
            this.labelHeaderTechnician.Size = new System.Drawing.Size(157, 33);
            this.labelHeaderTechnician.TabIndex = 68;
            this.labelHeaderTechnician.Text = "Technician";
            // 
            // label_name_gestion_matos
            // 
            this.label_name_gestion_matos.AutoSize = true;
            this.label_name_gestion_matos.Location = new System.Drawing.Point(42, 568);
            this.label_name_gestion_matos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name_gestion_matos.Name = "label_name_gestion_matos";
            this.label_name_gestion_matos.Size = new System.Drawing.Size(155, 20);
            this.label_name_gestion_matos.TabIndex = 78;
            this.label_name_gestion_matos.Text = "Gestion-Matos-2022";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(548, 281);
            this.dataGridView1.TabIndex = 79;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 80;
            this.label1.Text = "Name ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 81;
            this.label2.Text = "Phone";
            // 
            // textBoxNameTech
            // 
            this.textBoxNameTech.Location = new System.Drawing.Point(15, 390);
            this.textBoxNameTech.Name = "textBoxNameTech";
            this.textBoxNameTech.Size = new System.Drawing.Size(172, 26);
            this.textBoxNameTech.TabIndex = 82;
            // 
            // textBoxPhoneTech
            // 
            this.textBoxPhoneTech.Location = new System.Drawing.Point(214, 389);
            this.textBoxPhoneTech.Name = "textBoxPhoneTech";
            this.textBoxPhoneTech.Size = new System.Drawing.Size(172, 26);
            this.textBoxPhoneTech.TabIndex = 83;
            // 
            // WindowTecnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 637);
            this.Controls.Add(this.textBoxPhoneTech);
            this.Controls.Add(this.textBoxNameTech);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_name_gestion_matos);
            this.Controls.Add(this.buttonTech);
            this.Controls.Add(this.buttonRemoveTech);
            this.Controls.Add(this.buttonModifyTech);
            this.Controls.Add(this.buttonAddTech);
            this.Controls.Add(this.labelHeaderTechnician);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowTecnician";
            this.Text = "Tecnician";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonTech;
        private System.Windows.Forms.Button buttonRemoveTech;
        private System.Windows.Forms.Button buttonModifyTech;
        private System.Windows.Forms.Button buttonAddTech;
        private System.Windows.Forms.Label labelHeaderTechnician;
        private System.Windows.Forms.Label label_name_gestion_matos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNameTech;
        private System.Windows.Forms.TextBox textBoxPhoneTech;
    }
}