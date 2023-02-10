namespace Gestion_Matos
{
    partial class WindowType
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
            this.textBoxNameType = new System.Windows.Forms.TextBox();
            this.listBoxType = new System.Windows.Forms.ListBox();
            this.buttonCloseType = new System.Windows.Forms.Button();
            this.buttonRemoveType = new System.Windows.Forms.Button();
            this.buttonAddType = new System.Windows.Forms.Button();
            this.labelNameType = new System.Windows.Forms.Label();
            this.labelheaderSite = new System.Windows.Forms.Label();
            this.label_name_gestion_matos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNameType
            // 
            this.textBoxNameType.Location = new System.Drawing.Point(18, 269);
            this.textBoxNameType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNameType.Name = "textBoxNameType";
            this.textBoxNameType.Size = new System.Drawing.Size(300, 26);
            this.textBoxNameType.TabIndex = 75;
            // 
            // listBoxType
            // 
            this.listBoxType.FormattingEnabled = true;
            this.listBoxType.ItemHeight = 20;
            this.listBoxType.Location = new System.Drawing.Point(18, 72);
            this.listBoxType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxType.Name = "listBoxType";
            this.listBoxType.Size = new System.Drawing.Size(301, 164);
            this.listBoxType.TabIndex = 74;
            this.listBoxType.SelectedIndexChanged += new System.EventHandler(this.listBoxType_SelectedIndexChanged);
            // 
            // buttonCloseType
            // 
            this.buttonCloseType.Location = new System.Drawing.Point(18, 392);
            this.buttonCloseType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCloseType.Name = "buttonCloseType";
            this.buttonCloseType.Size = new System.Drawing.Size(303, 68);
            this.buttonCloseType.TabIndex = 73;
            this.buttonCloseType.Text = "Close";
            this.buttonCloseType.UseVisualStyleBackColor = true;
            this.buttonCloseType.Click += new System.EventHandler(this.buttonCloseType_Click);
            // 
            // buttonRemoveType
            // 
            this.buttonRemoveType.Location = new System.Drawing.Point(18, 309);
            this.buttonRemoveType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemoveType.Name = "buttonRemoveType";
            this.buttonRemoveType.Size = new System.Drawing.Size(147, 68);
            this.buttonRemoveType.TabIndex = 72;
            this.buttonRemoveType.Text = "Remove";
            this.buttonRemoveType.UseVisualStyleBackColor = true;
            this.buttonRemoveType.Click += new System.EventHandler(this.buttonRemoveType_Click);
            // 
            // buttonAddType
            // 
            this.buttonAddType.Location = new System.Drawing.Point(173, 309);
            this.buttonAddType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddType.Name = "buttonAddType";
            this.buttonAddType.Size = new System.Drawing.Size(147, 68);
            this.buttonAddType.TabIndex = 70;
            this.buttonAddType.Text = "Add";
            this.buttonAddType.UseVisualStyleBackColor = true;
            this.buttonAddType.Click += new System.EventHandler(this.buttonAddType_Click);
            // 
            // labelNameType
            // 
            this.labelNameType.AutoSize = true;
            this.labelNameType.Location = new System.Drawing.Point(14, 245);
            this.labelNameType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameType.Name = "labelNameType";
            this.labelNameType.Size = new System.Drawing.Size(55, 20);
            this.labelNameType.TabIndex = 69;
            this.labelNameType.Text = "Name:";
            // 
            // labelheaderSite
            // 
            this.labelheaderSite.AutoSize = true;
            this.labelheaderSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelheaderSite.Location = new System.Drawing.Point(130, 14);
            this.labelheaderSite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelheaderSite.Name = "labelheaderSite";
            this.labelheaderSite.Size = new System.Drawing.Size(80, 33);
            this.labelheaderSite.TabIndex = 68;
            this.labelheaderSite.Text = "Type";
            // 
            // label_name_gestion_matos
            // 
            this.label_name_gestion_matos.AutoSize = true;
            this.label_name_gestion_matos.Location = new System.Drawing.Point(87, 465);
            this.label_name_gestion_matos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name_gestion_matos.Name = "label_name_gestion_matos";
            this.label_name_gestion_matos.Size = new System.Drawing.Size(155, 20);
            this.label_name_gestion_matos.TabIndex = 76;
            this.label_name_gestion_matos.Text = "Gestion-Matos-2022";
            // 
            // WindowType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 494);
            this.Controls.Add(this.label_name_gestion_matos);
            this.Controls.Add(this.textBoxNameType);
            this.Controls.Add(this.listBoxType);
            this.Controls.Add(this.buttonCloseType);
            this.Controls.Add(this.buttonRemoveType);
            this.Controls.Add(this.buttonAddType);
            this.Controls.Add(this.labelNameType);
            this.Controls.Add(this.labelheaderSite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowType";
            this.Text = "Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNameType;
        private System.Windows.Forms.ListBox listBoxType;
        private System.Windows.Forms.Button buttonCloseType;
        private System.Windows.Forms.Button buttonRemoveType;
        private System.Windows.Forms.Button buttonAddType;
        private System.Windows.Forms.Label labelNameType;
        private System.Windows.Forms.Label labelheaderSite;
        private System.Windows.Forms.Label label_name_gestion_matos;
    }
}