namespace Gestion_Matos
{
    partial class WindowIntervention
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
            this.buttonRemoveInst = new System.Windows.Forms.Button();
            this.buttonModifyInst = new System.Windows.Forms.Button();
            this.buttonAddInt = new System.Windows.Forms.Button();
            this.labelDateInterventions = new System.Windows.Forms.Label();
            this.labelTechnician = new System.Windows.Forms.Label();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.labelSiteInt = new System.Windows.Forms.Label();
            this.labelheaderInterventions = new System.Windows.Forms.Label();
            this.dateTimePickerinter = new System.Windows.Forms.DateTimePicker();
            this.labelcomment = new System.Windows.Forms.Label();
            this.comboBoxmaterint = new System.Windows.Forms.ComboBox();
            this.comboBoxtechInt = new System.Windows.Forms.ComboBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxSite = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(531, 548);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(302, 68);
            this.buttonClose.TabIndex = 29;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonRemoveInst
            // 
            this.buttonRemoveInst.Location = new System.Drawing.Point(174, 548);
            this.buttonRemoveInst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemoveInst.Name = "buttonRemoveInst";
            this.buttonRemoveInst.Size = new System.Drawing.Size(147, 68);
            this.buttonRemoveInst.TabIndex = 28;
            this.buttonRemoveInst.Text = "Remove";
            this.buttonRemoveInst.UseVisualStyleBackColor = true;
            this.buttonRemoveInst.Click += new System.EventHandler(this.buttonRemoveInst_Click);
            // 
            // buttonModifyInst
            // 
            this.buttonModifyInst.Location = new System.Drawing.Point(330, 548);
            this.buttonModifyInst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonModifyInst.Name = "buttonModifyInst";
            this.buttonModifyInst.Size = new System.Drawing.Size(147, 68);
            this.buttonModifyInst.TabIndex = 27;
            this.buttonModifyInst.Text = "Modify";
            this.buttonModifyInst.UseVisualStyleBackColor = true;
            this.buttonModifyInst.Click += new System.EventHandler(this.buttonModifyInst_Click);
            // 
            // buttonAddInt
            // 
            this.buttonAddInt.Location = new System.Drawing.Point(18, 548);
            this.buttonAddInt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddInt.Name = "buttonAddInt";
            this.buttonAddInt.Size = new System.Drawing.Size(147, 68);
            this.buttonAddInt.TabIndex = 26;
            this.buttonAddInt.Text = "Add";
            this.buttonAddInt.UseVisualStyleBackColor = true;
            this.buttonAddInt.Click += new System.EventHandler(this.buttonAddInt_Click);
            // 
            // labelDateInterventions
            // 
            this.labelDateInterventions.AutoSize = true;
            this.labelDateInterventions.Location = new System.Drawing.Point(527, 117);
            this.labelDateInterventions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateInterventions.Name = "labelDateInterventions";
            this.labelDateInterventions.Size = new System.Drawing.Size(105, 20);
            this.labelDateInterventions.TabIndex = 21;
            this.labelDateInterventions.Text = "Interventions:";
            // 
            // labelTechnician
            // 
            this.labelTechnician.AutoSize = true;
            this.labelTechnician.Location = new System.Drawing.Point(527, 257);
            this.labelTechnician.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTechnician.Name = "labelTechnician";
            this.labelTechnician.Size = new System.Drawing.Size(89, 20);
            this.labelTechnician.TabIndex = 20;
            this.labelTechnician.Text = "Technician:";
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Location = new System.Drawing.Point(527, 184);
            this.labelMaterial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(69, 20);
            this.labelMaterial.TabIndex = 19;
            this.labelMaterial.Text = "Material:";
            // 
            // labelSiteInt
            // 
            this.labelSiteInt.AutoSize = true;
            this.labelSiteInt.Location = new System.Drawing.Point(527, 328);
            this.labelSiteInt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSiteInt.Name = "labelSiteInt";
            this.labelSiteInt.Size = new System.Drawing.Size(41, 20);
            this.labelSiteInt.TabIndex = 18;
            this.labelSiteInt.Text = "Site:";
            // 
            // labelheaderInterventions
            // 
            this.labelheaderInterventions.AutoSize = true;
            this.labelheaderInterventions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelheaderInterventions.Location = new System.Drawing.Point(346, 42);
            this.labelheaderInterventions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelheaderInterventions.Name = "labelheaderInterventions";
            this.labelheaderInterventions.Size = new System.Drawing.Size(182, 33);
            this.labelheaderInterventions.TabIndex = 17;
            this.labelheaderInterventions.Text = "Interventions";
            // 
            // dateTimePickerinter
            // 
            this.dateTimePickerinter.Location = new System.Drawing.Point(532, 143);
            this.dateTimePickerinter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerinter.Name = "dateTimePickerinter";
            this.dateTimePickerinter.Size = new System.Drawing.Size(300, 26);
            this.dateTimePickerinter.TabIndex = 31;
            // 
            // labelcomment
            // 
            this.labelcomment.AutoSize = true;
            this.labelcomment.Location = new System.Drawing.Point(534, 400);
            this.labelcomment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelcomment.Name = "labelcomment";
            this.labelcomment.Size = new System.Drawing.Size(82, 20);
            this.labelcomment.TabIndex = 32;
            this.labelcomment.Text = "Comment:";
            // 
            // comboBoxmaterint
            // 
            this.comboBoxmaterint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxmaterint.FormattingEnabled = true;
            this.comboBoxmaterint.Location = new System.Drawing.Point(532, 208);
            this.comboBoxmaterint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxmaterint.Name = "comboBoxmaterint";
            this.comboBoxmaterint.Size = new System.Drawing.Size(300, 28);
            this.comboBoxmaterint.TabIndex = 34;
            this.comboBoxmaterint.SelectedIndexChanged += new System.EventHandler(this.comboBoxmaterint_SelectedIndexChanged);
            // 
            // comboBoxtechInt
            // 
            this.comboBoxtechInt.FormattingEnabled = true;
            this.comboBoxtechInt.Location = new System.Drawing.Point(532, 282);
            this.comboBoxtechInt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxtechInt.Name = "comboBoxtechInt";
            this.comboBoxtechInt.Size = new System.Drawing.Size(300, 28);
            this.comboBoxtechInt.TabIndex = 35;
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(534, 426);
            this.textBoxComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(298, 82);
            this.textBoxComment.TabIndex = 36;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(496, 391);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBoxSite
            // 
            this.textBoxSite.Location = new System.Drawing.Point(532, 353);
            this.textBoxSite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSite.Name = "textBoxSite";
            this.textBoxSite.ReadOnly = true;
            this.textBoxSite.Size = new System.Drawing.Size(300, 26);
            this.textBoxSite.TabIndex = 38;
            // 
            // WindowIntervention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 694);
            this.Controls.Add(this.textBoxSite);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.comboBoxtechInt);
            this.Controls.Add(this.comboBoxmaterint);
            this.Controls.Add(this.labelcomment);
            this.Controls.Add(this.dateTimePickerinter);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonRemoveInst);
            this.Controls.Add(this.buttonModifyInst);
            this.Controls.Add(this.buttonAddInt);
            this.Controls.Add(this.labelDateInterventions);
            this.Controls.Add(this.labelTechnician);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.labelSiteInt);
            this.Controls.Add(this.labelheaderInterventions);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WindowIntervention";
            this.Text = "Intervention";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonRemoveInst;
        private System.Windows.Forms.Button buttonModifyInst;
        private System.Windows.Forms.Button buttonAddInt;
        private System.Windows.Forms.Label labelDateInterventions;
        private System.Windows.Forms.Label labelTechnician;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.Label labelSiteInt;
        private System.Windows.Forms.Label labelheaderInterventions;
        private System.Windows.Forms.DateTimePicker dateTimePickerinter;
        private System.Windows.Forms.Label labelcomment;
        private System.Windows.Forms.ComboBox comboBoxmaterint;
        private System.Windows.Forms.ComboBox comboBoxtechInt;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxSite;
    }
}