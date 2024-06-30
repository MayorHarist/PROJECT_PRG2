
namespace PROJECT_PRG2
{
    partial class Dashboard_KepalaTendik
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
            this.btnKembali = new Guna.UI2.WinForms.Guna2Button();
            this.panelData = new System.Windows.Forms.Panel();
            this.btnProdi = new Guna.UI2.WinForms.Guna2Button();
            this.btnData = new Guna.UI2.WinForms.Guna2Button();
            this.panelLaporan = new System.Windows.Forms.Panel();
            this.btnLaporanKRPP = new Guna.UI2.WinForms.Guna2Button();
            this.btnLaporanKRS = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnLaporan = new Guna.UI2.WinForms.Guna2Button();
            this.timerData = new System.Windows.Forms.Timer(this.components);
            this.timerLaporan = new System.Windows.Forms.Timer(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelData.SuspendLayout();
            this.panelLaporan.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKembali
            // 
            this.btnKembali.AutoRoundedCorners = true;
            this.btnKembali.BackColor = System.Drawing.Color.Transparent;
            this.btnKembali.BorderRadius = 35;
            this.btnKembali.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKembali.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKembali.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKembali.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKembali.FillColor = System.Drawing.Color.White;
            this.btnKembali.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnKembali.Location = new System.Drawing.Point(99, 1196);
            this.btnKembali.Margin = new System.Windows.Forms.Padding(4);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(497, 73);
            this.btnKembali.TabIndex = 167;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseTransparentBackground = true;
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.Transparent;
            this.panelData.Controls.Add(this.btnProdi);
            this.panelData.Location = new System.Drawing.Point(0, 232);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(503, 64);
            this.panelData.TabIndex = 169;
            // 
            // btnProdi
            // 
            this.btnProdi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProdi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProdi.FillColor = System.Drawing.Color.Transparent;
            this.btnProdi.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdi.ForeColor = System.Drawing.Color.White;
            this.btnProdi.Location = new System.Drawing.Point(-2, 3);
            this.btnProdi.Name = "btnProdi";
            this.btnProdi.Size = new System.Drawing.Size(500, 55);
            this.btnProdi.TabIndex = 0;
            this.btnProdi.Text = "Tenaga Kependidikan";
            this.btnProdi.Click += new System.EventHandler(this.btnProdi_Click);
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
            this.btnData.Location = new System.Drawing.Point(-1, 155);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(203, 67);
            this.btnData.TabIndex = 168;
            this.btnData.UseTransparentBackground = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // panelLaporan
            // 
            this.panelLaporan.BackColor = System.Drawing.Color.Transparent;
            this.panelLaporan.Controls.Add(this.btnLaporanKRPP);
            this.panelLaporan.Controls.Add(this.btnLaporanKRS);
            this.panelLaporan.Location = new System.Drawing.Point(0, 347);
            this.panelLaporan.Name = "panelLaporan";
            this.panelLaporan.Size = new System.Drawing.Size(503, 103);
            this.panelLaporan.TabIndex = 171;
            // 
            // btnLaporanKRPP
            // 
            this.btnLaporanKRPP.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnLaporanKRPP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLaporanKRPP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLaporanKRPP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLaporanKRPP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLaporanKRPP.FillColor = System.Drawing.Color.Transparent;
            this.btnLaporanKRPP.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporanKRPP.ForeColor = System.Drawing.Color.White;
            this.btnLaporanKRPP.Location = new System.Drawing.Point(0, 59);
            this.btnLaporanKRPP.Name = "btnLaporanKRPP";
            this.btnLaporanKRPP.Size = new System.Drawing.Size(500, 55);
            this.btnLaporanKRPP.TabIndex = 2;
            this.btnLaporanKRPP.Text = "Laporan KRPP Mahasiswa";
            // 
            // btnLaporanKRS
            // 
            this.btnLaporanKRS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLaporanKRS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLaporanKRS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLaporanKRS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLaporanKRS.FillColor = System.Drawing.Color.Transparent;
            this.btnLaporanKRS.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporanKRS.ForeColor = System.Drawing.Color.White;
            this.btnLaporanKRS.Location = new System.Drawing.Point(-2, 7);
            this.btnLaporanKRS.Name = "btnLaporanKRS";
            this.btnLaporanKRS.Size = new System.Drawing.Size(500, 55);
            this.btnLaporanKRS.TabIndex = 0;
            this.btnLaporanKRS.Text = "Laporan KRS Mahasiswa";
            // 
            // btnBack
            // 
            this.btnBack.Animated = true;
            this.btnBack.AutoRoundedCorners = true;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderRadius = 30;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(68, 941);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(377, 62);
            this.btnBack.TabIndex = 172;
            this.btnBack.UseTransparentBackground = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.Animated = true;
            this.btnLaporan.BackColor = System.Drawing.Color.Transparent;
            this.btnLaporan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLaporan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLaporan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLaporan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLaporan.FillColor = System.Drawing.Color.Transparent;
            this.btnLaporan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLaporan.ForeColor = System.Drawing.Color.White;
            this.btnLaporan.Location = new System.Drawing.Point(-2, 282);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(252, 67);
            this.btnLaporan.TabIndex = 170;
            this.btnLaporan.UseTransparentBackground = true;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // timerData
            // 
            this.timerData.Interval = 10;
            this.timerData.Tick += new System.EventHandler(this.timerData_Tick);
            // 
            // timerLaporan
            // 
            this.timerLaporan.Interval = 10;
            this.timerLaporan.Tick += new System.EventHandler(this.timerLaporan_Tick);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Location = new System.Drawing.Point(548, 34);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1360, 1016);
            this.panelMain.TabIndex = 173;
            // 
            // Dashboard_KepalaTendik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJECT_PRG2.Properties.Resources.DESIGN_FINDSMART__1_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelLaporan);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLaporan);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.btnKembali);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard_KepalaTendik";
            this.Text = "Dashboard_KepalaTendik";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelData.ResumeLayout(false);
            this.panelLaporan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnKembali;
        private System.Windows.Forms.Panel panelData;
        private Guna.UI2.WinForms.Guna2Button btnProdi;
        private Guna.UI2.WinForms.Guna2Button btnData;
        private System.Windows.Forms.Panel panelLaporan;
        private Guna.UI2.WinForms.Guna2Button btnLaporanKRPP;
        private Guna.UI2.WinForms.Guna2Button btnLaporanKRS;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnLaporan;
        private System.Windows.Forms.Timer timerData;
        private System.Windows.Forms.Timer timerLaporan;
        private System.Windows.Forms.Panel panelMain;
    }
}