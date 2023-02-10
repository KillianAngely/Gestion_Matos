namespace Gestion_Matos
{
    partial class WindowBrand
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.listBoxBrand = new System.Windows.Forms.ListBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonRemovesite = new System.Windows.Forms.Button();
            this.buttonAddsite = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelheaderSite = new System.Windows.Forms.Label();
            this.label_name_gestion_matos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(18, 268);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(300, 26);
            this.textBoxName.TabIndex = 67;
            // 
            // listBoxBrand
            // 
            this.listBoxBrand.FormattingEnabled = true;
            this.listBoxBrand.ItemHeight = 20;
            this.listBoxBrand.Location = new System.Drawing.Point(18, 71);
            this.listBoxBrand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxBrand.Name = "listBoxBrand";
            this.listBoxBrand.Size = new System.Drawing.Size(301, 164);
            this.listBoxBrand.TabIndex = 66;
            this.listBoxBrand.SelectedIndexChanged += new System.EventHandler(this.listBoxBrand_SelectedIndexChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(18, 391);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(303, 68);
            this.buttonClose.TabIndex = 65;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonRemovesite
            // 
            this.buttonRemovesite.Location = new System.Drawing.Point(18, 308);
            this.buttonRemovesite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemovesite.Name = "buttonRemovesite";
            this.buttonRemovesite.Size = new System.Drawing.Size(147, 68);
            this.buttonRemovesite.TabIndex = 64;
            this.buttonRemovesite.Text = "Remove";
            this.buttonRemovesite.UseVisualStyleBackColor = true;
            this.buttonRemovesite.Click += new System.EventHandler(this.buttonRemovesite_Click);
            // 
            // buttonAddsite
            // 
            this.buttonAddsite.Location = new System.Drawing.Point(173, 308);
            this.buttonAddsite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddsite.Name = "buttonAddsite";
            this.buttonAddsite.Size = new System.Drawing.Size(147, 68);
            this.buttonAddsite.TabIndex = 62;
            this.buttonAddsite.Text = "Add";
            this.buttonAddsite.UseVisualStyleBackColor = true;
            this.buttonAddsite.Click += new System.EventHandler(this.buttonAddsite_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(14, 243);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 20);
            this.labelName.TabIndex = 60;
            this.labelName.Text = "Name:";
            // 
            // labelheaderSite
            // 
            this.labelheaderSite.AutoSize = true;
            this.labelheaderSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelheaderSite.Location = new System.Drawing.Point(112, 14);
            this.labelheaderSite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelheaderSite.Name = "labelheaderSite";
            this.labelheaderSite.Size = new System.Drawing.Size(92, 33);
            this.labelheaderSite.TabIndex = 59;
            this.labelheaderSite.Text = "Brand";
            // 
            // label_name_gestion_matos
            // 
            this.label_name_gestion_matos.AutoSize = true;
            this.label_name_gestion_matos.Location = new System.Drawing.Point(96, 463);
            this.label_name_gestion_matos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name_gestion_matos.Name = "label_name_gestion_matos";
            this.label_name_gestion_matos.Size = new System.Drawing.Size(155, 20);
            this.label_name_gestion_matos.TabIndex = 68;
            this.label_name_gestion_matos.Text = "Gestion-Matos-2022";
            // 
            // WindowBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 492);
            this.Controls.Add(this.label_name_gestion_matos);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listBoxBrand);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonRemovesite);
            this.Controls.Add(this.buttonAddsite);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelheaderSite);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WindowBrand";
            this.Text = "Brand";
            this.Load += new System.EventHandler(this.WindowBrand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ListBox listBoxBrand;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonRemovesite;
        private System.Windows.Forms.Button buttonAddsite;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelheaderSite;
        private System.Windows.Forms.Label label_name_gestion_matos;
    }
}