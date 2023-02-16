namespace Gestion_Matos
{
    partial class WindowMaterial
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBoxCustomers = new System.Windows.Forms.ComboBox();
            this.labelCust = new System.Windows.Forms.Label();
            this.comboBoxSite = new System.Windows.Forms.ComboBox();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDateinstalMat = new System.Windows.Forms.DateTimePicker();
            this.labelSiteMat = new System.Windows.Forms.Label();
            this.textBoxMTBFMat = new System.Windows.Forms.TextBox();
            this.labelMtbfMat = new System.Windows.Forms.Label();
            this.labelDateMat = new System.Windows.Forms.Label();
            this.comboBoxTypeMat = new System.Windows.Forms.ComboBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonRemoveMat = new System.Windows.Forms.Button();
            this.buttonModifyMat = new System.Windows.Forms.Button();
            this.textBoxSerialNumberMat = new System.Windows.Forms.TextBox();
            this.textBoxNameMat = new System.Windows.Forms.TextBox();
            this.labelNameMat = new System.Windows.Forms.Label();
            this.labelBrandMat = new System.Windows.Forms.Label();
            this.labelTypeMat = new System.Windows.Forms.Label();
            this.labelSerialNumbersMat = new System.Windows.Forms.Label();
            this.labelheaderMaterial = new System.Windows.Forms.Label();
            this.buttonAddMaterial = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAddMaterial);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.comboBoxCustomers);
            this.panel1.Controls.Add(this.labelCust);
            this.panel1.Controls.Add(this.comboBoxSite);
            this.panel1.Controls.Add(this.comboBoxBrand);
            this.panel1.Controls.Add(this.dateTimePickerDateinstalMat);
            this.panel1.Controls.Add(this.labelSiteMat);
            this.panel1.Controls.Add(this.textBoxMTBFMat);
            this.panel1.Controls.Add(this.labelMtbfMat);
            this.panel1.Controls.Add(this.labelDateMat);
            this.panel1.Controls.Add(this.comboBoxTypeMat);
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.buttonRemoveMat);
            this.panel1.Controls.Add(this.buttonModifyMat);
            this.panel1.Controls.Add(this.textBoxSerialNumberMat);
            this.panel1.Controls.Add(this.textBoxNameMat);
            this.panel1.Controls.Add(this.labelNameMat);
            this.panel1.Controls.Add(this.labelBrandMat);
            this.panel1.Controls.Add(this.labelTypeMat);
            this.panel1.Controls.Add(this.labelSerialNumbersMat);
            this.panel1.Controls.Add(this.labelheaderMaterial);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 472);
            this.panel1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(448, 404);
            this.listBox1.TabIndex = 64;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBoxCustomers
            // 
            this.comboBoxCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomers.FormattingEnabled = true;
            this.comboBoxCustomers.Location = new System.Drawing.Point(513, 267);
            this.comboBoxCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxCustomers.Name = "comboBoxCustomers";
            this.comboBoxCustomers.Size = new System.Drawing.Size(247, 28);
            this.comboBoxCustomers.TabIndex = 63;
            // 
            // labelCust
            // 
            this.labelCust.AutoSize = true;
            this.labelCust.Location = new System.Drawing.Point(509, 243);
            this.labelCust.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCust.Name = "labelCust";
            this.labelCust.Size = new System.Drawing.Size(90, 20);
            this.labelCust.TabIndex = 62;
            this.labelCust.Text = "Customers:";
            // 
            // comboBoxSite
            // 
            this.comboBoxSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSite.FormattingEnabled = true;
            this.comboBoxSite.Location = new System.Drawing.Point(765, 143);
            this.comboBoxSite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSite.Name = "comboBoxSite";
            this.comboBoxSite.Size = new System.Drawing.Size(247, 28);
            this.comboBoxSite.TabIndex = 61;
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(768, 208);
            this.comboBoxBrand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(247, 28);
            this.comboBoxBrand.TabIndex = 60;
            // 
            // dateTimePickerDateinstalMat
            // 
            this.dateTimePickerDateinstalMat.Location = new System.Drawing.Point(768, 265);
            this.dateTimePickerDateinstalMat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerDateinstalMat.Name = "dateTimePickerDateinstalMat";
            this.dateTimePickerDateinstalMat.Size = new System.Drawing.Size(247, 26);
            this.dateTimePickerDateinstalMat.TabIndex = 58;
            // 
            // labelSiteMat
            // 
            this.labelSiteMat.AutoSize = true;
            this.labelSiteMat.Location = new System.Drawing.Point(762, 119);
            this.labelSiteMat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSiteMat.Name = "labelSiteMat";
            this.labelSiteMat.Size = new System.Drawing.Size(41, 20);
            this.labelSiteMat.TabIndex = 56;
            this.labelSiteMat.Text = "Site:";
            // 
            // textBoxMTBFMat
            // 
            this.textBoxMTBFMat.Location = new System.Drawing.Point(511, 143);
            this.textBoxMTBFMat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMTBFMat.Name = "textBoxMTBFMat";
            this.textBoxMTBFMat.Size = new System.Drawing.Size(247, 26);
            this.textBoxMTBFMat.TabIndex = 55;
            // 
            // labelMtbfMat
            // 
            this.labelMtbfMat.AutoSize = true;
            this.labelMtbfMat.Location = new System.Drawing.Point(507, 117);
            this.labelMtbfMat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMtbfMat.Name = "labelMtbfMat";
            this.labelMtbfMat.Size = new System.Drawing.Size(56, 20);
            this.labelMtbfMat.TabIndex = 54;
            this.labelMtbfMat.Text = "MTBF:";
            // 
            // labelDateMat
            // 
            this.labelDateMat.AutoSize = true;
            this.labelDateMat.Location = new System.Drawing.Point(764, 235);
            this.labelDateMat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateMat.Name = "labelDateMat";
            this.labelDateMat.Size = new System.Drawing.Size(142, 20);
            this.labelDateMat.TabIndex = 53;
            this.labelDateMat.Text = "Date of instalation:";
            // 
            // comboBoxTypeMat
            // 
            this.comboBoxTypeMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeMat.FormattingEnabled = true;
            this.comboBoxTypeMat.Location = new System.Drawing.Point(513, 208);
            this.comboBoxTypeMat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxTypeMat.Name = "comboBoxTypeMat";
            this.comboBoxTypeMat.Size = new System.Drawing.Size(247, 28);
            this.comboBoxTypeMat.TabIndex = 52;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(766, 379);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(249, 68);
            this.buttonReset.TabIndex = 51;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonRemoveMat
            // 
            this.buttonRemoveMat.Location = new System.Drawing.Point(511, 305);
            this.buttonRemoveMat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemoveMat.Name = "buttonRemoveMat";
            this.buttonRemoveMat.Size = new System.Drawing.Size(247, 68);
            this.buttonRemoveMat.TabIndex = 50;
            this.buttonRemoveMat.Text = "Remove";
            this.buttonRemoveMat.UseVisualStyleBackColor = true;
            // 
            // buttonModifyMat
            // 
            this.buttonModifyMat.Location = new System.Drawing.Point(763, 305);
            this.buttonModifyMat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonModifyMat.Name = "buttonModifyMat";
            this.buttonModifyMat.Size = new System.Drawing.Size(252, 68);
            this.buttonModifyMat.TabIndex = 49;
            this.buttonModifyMat.Text = "Modify";
            this.buttonModifyMat.UseVisualStyleBackColor = true;
            // 
            // textBoxSerialNumberMat
            // 
            this.textBoxSerialNumberMat.Location = new System.Drawing.Point(765, 80);
            this.textBoxSerialNumberMat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSerialNumberMat.Name = "textBoxSerialNumberMat";
            this.textBoxSerialNumberMat.Size = new System.Drawing.Size(247, 26);
            this.textBoxSerialNumberMat.TabIndex = 46;
            // 
            // textBoxNameMat
            // 
            this.textBoxNameMat.Location = new System.Drawing.Point(511, 80);
            this.textBoxNameMat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNameMat.Name = "textBoxNameMat";
            this.textBoxNameMat.Size = new System.Drawing.Size(247, 26);
            this.textBoxNameMat.TabIndex = 45;
            // 
            // labelNameMat
            // 
            this.labelNameMat.AutoSize = true;
            this.labelNameMat.Location = new System.Drawing.Point(507, 53);
            this.labelNameMat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameMat.Name = "labelNameMat";
            this.labelNameMat.Size = new System.Drawing.Size(55, 20);
            this.labelNameMat.TabIndex = 44;
            this.labelNameMat.Text = "Name:";
            // 
            // labelBrandMat
            // 
            this.labelBrandMat.AutoSize = true;
            this.labelBrandMat.Location = new System.Drawing.Point(764, 183);
            this.labelBrandMat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBrandMat.Name = "labelBrandMat";
            this.labelBrandMat.Size = new System.Drawing.Size(56, 20);
            this.labelBrandMat.TabIndex = 43;
            this.labelBrandMat.Text = "Brand:";
            // 
            // labelTypeMat
            // 
            this.labelTypeMat.AutoSize = true;
            this.labelTypeMat.Location = new System.Drawing.Point(509, 182);
            this.labelTypeMat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTypeMat.Name = "labelTypeMat";
            this.labelTypeMat.Size = new System.Drawing.Size(47, 20);
            this.labelTypeMat.TabIndex = 42;
            this.labelTypeMat.Text = "Type:";
            // 
            // labelSerialNumbersMat
            // 
            this.labelSerialNumbersMat.AutoSize = true;
            this.labelSerialNumbersMat.Location = new System.Drawing.Point(762, 55);
            this.labelSerialNumbersMat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSerialNumbersMat.Name = "labelSerialNumbersMat";
            this.labelSerialNumbersMat.Size = new System.Drawing.Size(121, 20);
            this.labelSerialNumbersMat.TabIndex = 41;
            this.labelSerialNumbersMat.Text = "Serial Numbers:";
            // 
            // labelheaderMaterial
            // 
            this.labelheaderMaterial.AutoSize = true;
            this.labelheaderMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelheaderMaterial.Location = new System.Drawing.Point(507, 7);
            this.labelheaderMaterial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelheaderMaterial.Name = "labelheaderMaterial";
            this.labelheaderMaterial.Size = new System.Drawing.Size(119, 33);
            this.labelheaderMaterial.TabIndex = 40;
            this.labelheaderMaterial.Text = "Material";
            // 
            // buttonAddMaterial
            // 
            this.buttonAddMaterial.Location = new System.Drawing.Point(511, 382);
            this.buttonAddMaterial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddMaterial.Name = "buttonAddMaterial";
            this.buttonAddMaterial.Size = new System.Drawing.Size(247, 68);
            this.buttonAddMaterial.TabIndex = 65;
            this.buttonAddMaterial.Text = "add";
            this.buttonAddMaterial.UseVisualStyleBackColor = true;
            this.buttonAddMaterial.Click += new System.EventHandler(this.buttonAddMaterial_Click);
            // 
            // WindowMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 500);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WindowMaterial";
            this.Text = "Material";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateinstalMat;
        private System.Windows.Forms.Label labelSiteMat;
        private System.Windows.Forms.TextBox textBoxMTBFMat;
        private System.Windows.Forms.Label labelMtbfMat;
        private System.Windows.Forms.Label labelDateMat;
        private System.Windows.Forms.ComboBox comboBoxTypeMat;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonRemoveMat;
        private System.Windows.Forms.Button buttonModifyMat;
        private System.Windows.Forms.TextBox textBoxSerialNumberMat;
        private System.Windows.Forms.TextBox textBoxNameMat;
        private System.Windows.Forms.Label labelNameMat;
        private System.Windows.Forms.Label labelBrandMat;
        private System.Windows.Forms.Label labelTypeMat;
        private System.Windows.Forms.Label labelSerialNumbersMat;
        private System.Windows.Forms.Label labelheaderMaterial;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.ComboBox comboBoxSite;
        private System.Windows.Forms.ComboBox comboBoxCustomers;
        private System.Windows.Forms.Label labelCust;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonAddMaterial;
    }
}