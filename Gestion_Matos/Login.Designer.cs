namespace Gestion_Matos
{
    partial class Form_login_window
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_name_gestion_matos = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.button_connexion = new System.Windows.Forms.Button();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.labelheaderlogin = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_name_gestion_matos
            // 
            this.label_name_gestion_matos.AutoSize = true;
            this.label_name_gestion_matos.Location = new System.Drawing.Point(153, 405);
            this.label_name_gestion_matos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name_gestion_matos.Name = "label_name_gestion_matos";
            this.label_name_gestion_matos.Size = new System.Drawing.Size(155, 20);
            this.label_name_gestion_matos.TabIndex = 0;
            this.label_name_gestion_matos.Text = "Gestion-Matos-2022";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.Location = new System.Drawing.Point(56, 100);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(73, 29);
            this.label_login.TabIndex = 1;
            this.label_login.Text = "Login";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(57, 194);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(120, 29);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "Password";
            // 
            // button_connexion
            // 
            this.button_connexion.Location = new System.Drawing.Point(227, 320);
            this.button_connexion.Name = "button_connexion";
            this.button_connexion.Size = new System.Drawing.Size(159, 48);
            this.button_connexion.TabIndex = 3;
            this.button_connexion.Text = "Connexion";
            this.button_connexion.UseVisualStyleBackColor = true;
            this.button_connexion.Click += new System.EventHandler(this.button_connexion_Click);
            // 
            // textBox_login
            // 
            this.textBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_login.Location = new System.Drawing.Point(62, 132);
            this.textBox_login.Multiline = true;
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(322, 39);
            this.textBox_login.TabIndex = 4;
            this.textBox_login.Text = "Admin";
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(62, 226);
            this.textBox_password.Multiline = true;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(322, 39);
            this.textBox_password.TabIndex = 5;
            this.textBox_password.Text = "Admin";
            // 
            // labelheaderlogin
            // 
            this.labelheaderlogin.AutoSize = true;
            this.labelheaderlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelheaderlogin.Location = new System.Drawing.Point(105, 55);
            this.labelheaderlogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelheaderlogin.Name = "labelheaderlogin";
            this.labelheaderlogin.Size = new System.Drawing.Size(232, 37);
            this.labelheaderlogin.TabIndex = 6;
            this.labelheaderlogin.Text = " Gestion Matos";
            this.labelheaderlogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(61, 320);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(159, 48);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // Form_login_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 495);
            this.ControlBox = false;
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.labelheaderlogin);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.button_connexion);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.label_name_gestion_matos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_login_window";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name_gestion_matos;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_connexion;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label labelheaderlogin;
        private System.Windows.Forms.Button button_cancel;
    }
}

