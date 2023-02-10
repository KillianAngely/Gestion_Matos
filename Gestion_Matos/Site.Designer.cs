namespace Gestion_Matos
{
    partial class WindowSite
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonRemovesite = new System.Windows.Forms.Button();
            this.buttonModifysite = new System.Windows.Forms.Button();
            this.buttonAddsite = new System.Windows.Forms.Button();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelheaderSite = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxPostCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(813, 595);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(302, 68);
            this.buttonClose.TabIndex = 45;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonRemovesite
            // 
            this.buttonRemovesite.Location = new System.Drawing.Point(198, 595);
            this.buttonRemovesite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemovesite.Name = "buttonRemovesite";
            this.buttonRemovesite.Size = new System.Drawing.Size(147, 68);
            this.buttonRemovesite.TabIndex = 44;
            this.buttonRemovesite.Text = "Remove";
            this.buttonRemovesite.UseVisualStyleBackColor = true;
            this.buttonRemovesite.Click += new System.EventHandler(this.buttonRemovesite_Click);
            // 
            // buttonModifysite
            // 
            this.buttonModifysite.Location = new System.Drawing.Point(354, 595);
            this.buttonModifysite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonModifysite.Name = "buttonModifysite";
            this.buttonModifysite.Size = new System.Drawing.Size(147, 68);
            this.buttonModifysite.TabIndex = 43;
            this.buttonModifysite.Text = "Modify";
            this.buttonModifysite.UseVisualStyleBackColor = true;
            this.buttonModifysite.Click += new System.EventHandler(this.buttonModifysite_Click);
            // 
            // buttonAddsite
            // 
            this.buttonAddsite.Location = new System.Drawing.Point(42, 595);
            this.buttonAddsite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddsite.Name = "buttonAddsite";
            this.buttonAddsite.Size = new System.Drawing.Size(147, 68);
            this.buttonAddsite.TabIndex = 42;
            this.buttonAddsite.Text = "Add";
            this.buttonAddsite.UseVisualStyleBackColor = true;
            this.buttonAddsite.Click += new System.EventHandler(this.buttonAddsite_Click);
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Location = new System.Drawing.Point(285, 108);
            this.labelMaterial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(63, 20);
            this.labelMaterial.TabIndex = 39;
            this.labelMaterial.Text = "Adress:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(37, 106);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 38;
            this.labelName.Text = "Name";
            // 
            // labelheaderSite
            // 
            this.labelheaderSite.AutoSize = true;
            this.labelheaderSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelheaderSite.Location = new System.Drawing.Point(549, 34);
            this.labelheaderSite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelheaderSite.Name = "labelheaderSite";
            this.labelheaderSite.Size = new System.Drawing.Size(65, 33);
            this.labelheaderSite.TabIndex = 37;
            this.labelheaderSite.Text = "Site";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(42, 132);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(236, 26);
            this.textBoxName.TabIndex = 53;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(290, 132);
            this.textBoxAdress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(227, 26);
            this.textBoxAdress.TabIndex = 54;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(754, 132);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(212, 26);
            this.textBoxCity.TabIndex = 58;
            // 
            // textBoxPostCode
            // 
            this.textBoxPostCode.Location = new System.Drawing.Point(525, 132);
            this.textBoxPostCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPostCode.Name = "textBoxPostCode";
            this.textBoxPostCode.Size = new System.Drawing.Size(221, 26);
            this.textBoxPostCode.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(750, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Postcode:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1074, 349);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // WindowSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 692);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxPostCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonRemovesite);
            this.Controls.Add(this.buttonModifysite);
            this.Controls.Add(this.buttonAddsite);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelheaderSite);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WindowSite";
            this.Text = "Site";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonRemovesite;
        private System.Windows.Forms.Button buttonModifysite;
        private System.Windows.Forms.Button buttonAddsite;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelheaderSite;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxPostCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}