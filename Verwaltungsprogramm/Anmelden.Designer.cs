namespace Verwaltungsprogramm
{
    partial class anmelden
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.BSFLanmelden = new System.Windows.Forms.Button();
            this.LBusername = new System.Windows.Forms.Label();
            this.LBpassword = new System.Windows.Forms.Label();
            this.TBusername = new System.Windows.Forms.TextBox();
            this.TBpassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BSFLanmelden
            // 
            this.BSFLanmelden.Location = new System.Drawing.Point(12, 99);
            this.BSFLanmelden.Name = "BSFLanmelden";
            this.BSFLanmelden.Size = new System.Drawing.Size(260, 50);
            this.BSFLanmelden.TabIndex = 0;
            this.BSFLanmelden.Text = "Anmelden";
            this.BSFLanmelden.UseVisualStyleBackColor = true;
            this.BSFLanmelden.Click += new System.EventHandler(this.BSFLanmelden_Click);
            // 
            // LBusername
            // 
            this.LBusername.AutoSize = true;
            this.LBusername.Location = new System.Drawing.Point(13, 13);
            this.LBusername.Name = "LBusername";
            this.LBusername.Size = new System.Drawing.Size(55, 13);
            this.LBusername.TabIndex = 1;
            this.LBusername.Text = "Username";
            // 
            // LBpassword
            // 
            this.LBpassword.AutoSize = true;
            this.LBpassword.Location = new System.Drawing.Point(13, 54);
            this.LBpassword.Name = "LBpassword";
            this.LBpassword.Size = new System.Drawing.Size(53, 13);
            this.LBpassword.TabIndex = 2;
            this.LBpassword.Text = "Password";
            // 
            // TBusername
            // 
            this.TBusername.Location = new System.Drawing.Point(12, 29);
            this.TBusername.Name = "TBusername";
            this.TBusername.Size = new System.Drawing.Size(260, 20);
            this.TBusername.TabIndex = 3;
            // 
            // TBpassword
            // 
            this.TBpassword.Location = new System.Drawing.Point(12, 70);
            this.TBpassword.Name = "TBpassword";
            this.TBpassword.Size = new System.Drawing.Size(260, 20);
            this.TBpassword.TabIndex = 4;
            // 
            // anmelden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.TBpassword);
            this.Controls.Add(this.TBusername);
            this.Controls.Add(this.LBpassword);
            this.Controls.Add(this.LBusername);
            this.Controls.Add(this.BSFLanmelden);
            this.Name = "anmelden";
            this.Text = "Startbildschirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BSFLanmelden;
        private System.Windows.Forms.Label LBusername;
        private System.Windows.Forms.Label LBpassword;
        private System.Windows.Forms.TextBox TBusername;
        private System.Windows.Forms.TextBox TBpassword;
    }
}

