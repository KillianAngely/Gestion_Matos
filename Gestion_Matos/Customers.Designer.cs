namespace Gestion_Matos
{
    partial class WindowCustomers
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
            this.labelheaderCustomers = new System.Windows.Forms.Label();
            this.buttonAddcust = new System.Windows.Forms.Button();
            this.buttonModifycust = new System.Windows.Forms.Button();
            this.buttonRemovecust = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelheaderCustomers
            // 
            this.labelheaderCustomers.AutoSize = true;
            this.labelheaderCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelheaderCustomers.Location = new System.Drawing.Point(406, 10);
            this.labelheaderCustomers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelheaderCustomers.Name = "labelheaderCustomers";
            this.labelheaderCustomers.Size = new System.Drawing.Size(157, 33);
            this.labelheaderCustomers.TabIndex = 0;
            this.labelheaderCustomers.Text = "Customers";
            // 
            // buttonAddcust
            // 
            this.buttonAddcust.Location = new System.Drawing.Point(20, 514);
            this.buttonAddcust.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddcust.Name = "buttonAddcust";
            this.buttonAddcust.Size = new System.Drawing.Size(147, 68);
            this.buttonAddcust.TabIndex = 11;
            this.buttonAddcust.Text = "Add";
            this.buttonAddcust.UseVisualStyleBackColor = true;
            this.buttonAddcust.Click += new System.EventHandler(this.buttonAddcust_Click);
            // 
            // buttonModifycust
            // 
            this.buttonModifycust.Location = new System.Drawing.Point(175, 514);
            this.buttonModifycust.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonModifycust.Name = "buttonModifycust";
            this.buttonModifycust.Size = new System.Drawing.Size(147, 68);
            this.buttonModifycust.TabIndex = 12;
            this.buttonModifycust.Text = "Modify";
            this.buttonModifycust.UseVisualStyleBackColor = true;
            this.buttonModifycust.Click += new System.EventHandler(this.buttonModifycust_Click);
            // 
            // buttonRemovecust
            // 
            this.buttonRemovecust.Location = new System.Drawing.Point(330, 514);
            this.buttonRemovecust.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemovecust.Name = "buttonRemovecust";
            this.buttonRemovecust.Size = new System.Drawing.Size(147, 68);
            this.buttonRemovecust.TabIndex = 13;
            this.buttonRemovecust.Text = "Remove";
            this.buttonRemovecust.UseVisualStyleBackColor = true;
            this.buttonRemovecust.Click += new System.EventHandler(this.buttonRemovecust_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(987, 343);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(530, 90);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(247, 26);
            this.textBoxPhone.TabIndex = 9;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(275, 90);
            this.textBoxAdress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(247, 26);
            this.textBoxAdress.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(785, 90);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(247, 26);
            this.textBoxEmail.TabIndex = 10;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(20, 90);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(247, 26);
            this.textBoxName.TabIndex = 7;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(16, 65);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 20);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(780, 66);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(52, 20);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(525, 66);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(136, 20);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "Phone ( Optional):";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(270, 65);
            this.labelAdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(63, 20);
            this.labelAdress.TabIndex = 1;
            this.labelAdress.Text = "Adress:";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(748, 514);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(249, 68);
            this.buttonClose.TabIndex = 15;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.labelheaderCustomers);
            this.panel1.Controls.Add(this.buttonModifycust);
            this.panel1.Controls.Add(this.buttonRemovecust);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.labelAdress);
            this.panel1.Controls.Add(this.buttonAddcust);
            this.panel1.Controls.Add(this.labelPhone);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.textBoxAdress);
            this.panel1.Controls.Add(this.textBoxPhone);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 587);
            this.panel1.TabIndex = 17;
            // 
            // WindowCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 620);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WindowCustomers";
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelheaderCustomers;
        private System.Windows.Forms.Button buttonAddcust;
        private System.Windows.Forms.Button buttonModifycust;
        private System.Windows.Forms.Button buttonRemovecust;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel1;
    }
}