namespace PROJECT_PRG2.Dashboard
{
    partial class DashboardMahasiswa
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
            this.components = new System.ComponentModel.Container();
            this.panelTransaksi = new System.Windows.Forms.Panel();
            this.btnTrsKRPP = new Guna.UI2.WinForms.Guna2Button();
            this.panelData = new System.Windows.Forms.Panel();
            this.btnJenisPrestasi = new Guna.UI2.WinForms.Guna2Button();
            this.btnPengumuman = new Guna.UI2.WinForms.Guna2Button();
            this.btnMatakuliah = new Guna.UI2.WinForms.Guna2Button();
            this.btnTransaksi = new Guna.UI2.WinForms.Guna2Button();
            this.btnData = new Guna.UI2.WinForms.Guna2Button();
            this.timerData = new System.Windows.Forms.Timer(this.components);
            this.timerTRS = new System.Windows.Forms.Timer(this.components);
            this.btnKembali = new Guna.UI2.WinForms.Guna2Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTransaksi.SuspendLayout();
            this.panelData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTransaksi
            // 
            this.panelTransaksi.BackColor = System.Drawing.Color.Transparent;
            this.panelTransaksi.Controls.Add(this.btnTrsKRPP);
            this.panelTransaksi.Location = new System.Drawing.Point(30, 527);
            this.panelTransaksi.Margin = new System.Windows.Forms.Padding(2);
            this.panelTransaksi.Name = "panelTransaksi";
            this.panelTransaksi.Size = new System.Drawing.Size(377, 63);
            this.panelTransaksi.TabIndex = 18;
            // 
            // btnTrsKRPP
            // 
            this.btnTrsKRPP.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnTrsKRPP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTrsKRPP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTrsKRPP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTrsKRPP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTrsKRPP.FillColor = System.Drawing.Color.Transparent;
            this.btnTrsKRPP.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrsKRPP.ForeColor = System.Drawing.Color.White;
            this.btnTrsKRPP.Location = new System.Drawing.Point(0, 10);
            this.btnTrsKRPP.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrsKRPP.Name = "btnTrsKRPP";
            this.btnTrsKRPP.Size = new System.Drawing.Size(375, 45);
            this.btnTrsKRPP.TabIndex = 2;
            this.btnTrsKRPP.Text = "KRPP Mahasiswa";
            this.btnTrsKRPP.Click += new System.EventHandler(this.btnTrsKRPP_Click);
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.Transparent;
            this.panelData.Controls.Add(this.btnJenisPrestasi);
            this.panelData.Controls.Add(this.btnPengumuman);
            this.panelData.Controls.Add(this.btnMatakuliah);
            this.panelData.Location = new System.Drawing.Point(28, 228);
            this.panelData.Margin = new System.Windows.Forms.Padding(2);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(377, 158);
            this.panelData.TabIndex = 17;
            // 
            // btnJenisPrestasi
            // 
            this.btnJenisPrestasi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnJenisPrestasi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnJenisPrestasi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnJenisPrestasi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnJenisPrestasi.FillColor = System.Drawing.Color.Transparent;
            this.btnJenisPrestasi.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJenisPrestasi.ForeColor = System.Drawing.Color.White;
            this.btnJenisPrestasi.Location = new System.Drawing.Point(2, 60);
            this.btnJenisPrestasi.Margin = new System.Windows.Forms.Padding(2);
            this.btnJenisPrestasi.Name = "btnJenisPrestasi";
            this.btnJenisPrestasi.Size = new System.Drawing.Size(375, 45);
            this.btnJenisPrestasi.TabIndex = 6;
            this.btnJenisPrestasi.Text = "Jenis Prestasi";
            // 
            // btnPengumuman
            // 
            this.btnPengumuman.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPengumuman.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPengumuman.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPengumuman.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPengumuman.FillColor = System.Drawing.Color.Transparent;
            this.btnPengumuman.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPengumuman.ForeColor = System.Drawing.Color.White;
            this.btnPengumuman.Location = new System.Drawing.Point(2, 109);
            this.btnPengumuman.Margin = new System.Windows.Forms.Padding(2);
            this.btnPengumuman.Name = "btnPengumuman";
            this.btnPengumuman.Size = new System.Drawing.Size(375, 37);
            this.btnPengumuman.TabIndex = 4;
            this.btnPengumuman.Text = "Pengumuman";
            // 
            // btnMatakuliah
            // 
            this.btnMatakuliah.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMatakuliah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMatakuliah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMatakuliah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMatakuliah.FillColor = System.Drawing.Color.Transparent;
            this.btnMatakuliah.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatakuliah.ForeColor = System.Drawing.Color.White;
            this.btnMatakuliah.Location = new System.Drawing.Point(2, 11);
            this.btnMatakuliah.Margin = new System.Windows.Forms.Padding(2);
            this.btnMatakuliah.Name = "btnMatakuliah";
            this.btnMatakuliah.Size = new System.Drawing.Size(375, 45);
            this.btnMatakuliah.TabIndex = 4;
            this.btnMatakuliah.Text = "Mata Kuliah";
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.Animated = true;
            this.btnTransaksi.BackColor = System.Drawing.Color.Transparent;
            this.btnTransaksi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTransaksi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTransaksi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTransaksi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTransaksi.FillColor = System.Drawing.Color.Transparent;
            this.btnTransaksi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTransaksi.ForeColor = System.Drawing.Color.White;
            this.btnTransaksi.Location = new System.Drawing.Point(30, 479);
            this.btnTransaksi.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new System.Drawing.Size(189, 54);
            this.btnTransaksi.TabIndex = 16;
            this.btnTransaksi.UseTransparentBackground = true;
            this.btnTransaksi.Click += new System.EventHandler(this.btnTransaksi_Click);
            // 
            // btnData
            // 
            this.btnData.Animated = true;
            this.btnData.BackColor = System.Drawing.Color.Transparent;
            this.btnData.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnData.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnData.FillColor = System.Drawing.Color.Transparent;
            this.btnData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnData.ForeColor = System.Drawing.Color.White;
            this.btnData.Location = new System.Drawing.Point(27, 169);
            this.btnData.Margin = new System.Windows.Forms.Padding(2);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(152, 54);
            this.btnData.TabIndex = 15;
            this.btnData.UseTransparentBackground = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // timerData
            // 
            this.timerData.Interval = 10;
            this.timerData.Tick += new System.EventHandler(this.timerData_Tick);
            // 
            // timerTRS
            // 
            this.timerTRS.Interval = 10;
            this.timerTRS.Tick += new System.EventHandler(this.timerTRS_Tick);
            // 
            // btnKembali
            // 
            this.btnKembali.Animated = true;
            this.btnKembali.AutoRoundedCorners = true;
            this.btnKembali.BackColor = System.Drawing.Color.Transparent;
            this.btnKembali.BorderRadius = 28;
            this.btnKembali.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKembali.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKembali.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKembali.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKembali.FillColor = System.Drawing.Color.Transparent;
            this.btnKembali.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKembali.ForeColor = System.Drawing.Color.White;
            this.btnKembali.Location = new System.Drawing.Point(70, 972);
            this.btnKembali.Margin = new System.Windows.Forms.Padding(2);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(370, 58);
            this.btnKembali.TabIndex = 19;
            this.btnKembali.UseTransparentBackground = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Location = new System.Drawing.Point(523, 27);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1392, 1033);
            this.panelMain.TabIndex = 20;
            // 
            // DashboardMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJECT_PRG2.Properties.Resources.Dashboard_Mahasiswa;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.panelTransaksi);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.btnTransaksi);
            this.Controls.Add(this.btnData);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardMahasiswa";
            this.Text = "DashboardMahasiswa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTransaksi.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTransaksi;
        private Guna.UI2.WinForms.Guna2Button btnTrsKRPP;
        private System.Windows.Forms.Panel panelData;
        private Guna.UI2.WinForms.Guna2Button btnJenisPrestasi;
        private Guna.UI2.WinForms.Guna2Button btnPengumuman;
        private Guna.UI2.WinForms.Guna2Button btnMatakuliah;
        private Guna.UI2.WinForms.Guna2Button btnTransaksi;
        private Guna.UI2.WinForms.Guna2Button btnData;
        private System.Windows.Forms.Timer timerData;
        private System.Windows.Forms.Timer timerTRS;
        private Guna.UI2.WinForms.Guna2Button btnKembali;
        private System.Windows.Forms.Panel panelMain;
    }
}