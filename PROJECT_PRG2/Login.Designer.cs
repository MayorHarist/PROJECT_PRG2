namespace PROJECT_PRG2
{
    partial class Login
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMhs = new System.Windows.Forms.Button();
            this.btnTKN = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(179, 778);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(458, 69);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMhs
            // 
            this.btnMhs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(148)))), ((int)(((byte)(237)))));
            this.btnMhs.FlatAppearance.BorderSize = 0;
            this.btnMhs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMhs.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMhs.ForeColor = System.Drawing.Color.White;
            this.btnMhs.Location = new System.Drawing.Point(179, 600);
            this.btnMhs.Name = "btnMhs";
            this.btnMhs.Size = new System.Drawing.Size(458, 69);
            this.btnMhs.TabIndex = 6;
            this.btnMhs.Text = "Mahasiswa";
            this.btnMhs.UseVisualStyleBackColor = false;
            // 
            // btnTKN
            // 
            this.btnTKN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(148)))), ((int)(((byte)(237)))));
            this.btnTKN.FlatAppearance.BorderSize = 0;
            this.btnTKN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTKN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKN.ForeColor = System.Drawing.Color.White;
            this.btnTKN.Location = new System.Drawing.Point(179, 415);
            this.btnTKN.Name = "btnTKN";
            this.btnTKN.Size = new System.Drawing.Size(458, 69);
            this.btnTKN.TabIndex = 5;
            this.btnTKN.Text = "Tenaga Kependidikan";
            this.btnTKN.UseVisualStyleBackColor = false;
            // 
            // labelLogin
            // 
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 70.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.White;
            this.labelLogin.Location = new System.Drawing.Point(45, 90);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(1055, 203);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "PILIHAN LOGIN";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJECT_PRG2.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1710, 840);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMhs);
            this.Controls.Add(this.btnTKN);
            this.Controls.Add(this.labelLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMhs;
        private System.Windows.Forms.Button btnTKN;
        private System.Windows.Forms.Label labelLogin;
    }
}