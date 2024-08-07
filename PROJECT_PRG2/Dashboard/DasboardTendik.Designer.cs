﻿namespace PROJECT_PRG2
{
    partial class DasboardTendik
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
            this.timerLaporan = new System.Windows.Forms.Timer(this.components);
            this.btnLaporanKRPP = new Guna.UI2.WinForms.Guna2Button();
            this.btnLaporanKRS = new Guna.UI2.WinForms.Guna2Button();
            this.panelLaporan = new System.Windows.Forms.Panel();
            this.btnMabres = new Guna.UI2.WinForms.Guna2Button();
            this.btnJenisPrestasi = new Guna.UI2.WinForms.Guna2Button();
            this.btnPosisiPrestasi = new Guna.UI2.WinForms.Guna2Button();
            this.btnPengumuman = new Guna.UI2.WinForms.Guna2Button();
            this.btnMatakuliah = new Guna.UI2.WinForms.Guna2Button();
            this.btnDosen = new Guna.UI2.WinForms.Guna2Button();
            this.btnMahasiswa = new Guna.UI2.WinForms.Guna2Button();
            this.timerTRS = new System.Windows.Forms.Timer(this.components);
            this.btnTrsKRPP = new Guna.UI2.WinForms.Guna2Button();
            this.btnTrsKRS = new Guna.UI2.WinForms.Guna2Button();
            this.btnProdi = new Guna.UI2.WinForms.Guna2Button();
            this.timerData = new System.Windows.Forms.Timer(this.components);
            this.btnKembali = new Guna.UI2.WinForms.Guna2Button();
            this.panelTransaksi = new System.Windows.Forms.Panel();
            this.panelData = new System.Windows.Forms.Panel();
            this.btnLaporan = new Guna.UI2.WinForms.Guna2Button();
            this.btnTransaksi = new Guna.UI2.WinForms.Guna2Button();
            this.btnData = new Guna.UI2.WinForms.Guna2Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelLaporan.SuspendLayout();
            this.panelTransaksi.SuspendLayout();
            this.panelData.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerLaporan
            // 
            this.timerLaporan.Interval = 10;
            this.timerLaporan.Tick += new System.EventHandler(this.timerLaporan_Tick);
            // 
            // btnLaporanKRPP
            // 
            this.btnLaporanKRPP.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnLaporanKRPP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLaporanKRPP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLaporanKRPP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLaporanKRPP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLaporanKRPP.FillColor = System.Drawing.Color.Transparent;
            this.btnLaporanKRPP.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporanKRPP.ForeColor = System.Drawing.Color.White;
            this.btnLaporanKRPP.Location = new System.Drawing.Point(0, 45);
            this.btnLaporanKRPP.Margin = new System.Windows.Forms.Padding(2);
            this.btnLaporanKRPP.Name = "btnLaporanKRPP";
            this.btnLaporanKRPP.Size = new System.Drawing.Size(375, 45);
            this.btnLaporanKRPP.TabIndex = 2;
            this.btnLaporanKRPP.Text = "Laporan KRPP Mahasiswa";
            this.btnLaporanKRPP.Click += new System.EventHandler(this.btnLaporanKRPP_Click);
            // 
            // btnLaporanKRS
            // 
            this.btnLaporanKRS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLaporanKRS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLaporanKRS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLaporanKRS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLaporanKRS.FillColor = System.Drawing.Color.Transparent;
            this.btnLaporanKRS.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporanKRS.ForeColor = System.Drawing.Color.White;
            this.btnLaporanKRS.Location = new System.Drawing.Point(-2, 6);
            this.btnLaporanKRS.Margin = new System.Windows.Forms.Padding(2);
            this.btnLaporanKRS.Name = "btnLaporanKRS";
            this.btnLaporanKRS.Size = new System.Drawing.Size(375, 45);
            this.btnLaporanKRS.TabIndex = 0;
            this.btnLaporanKRS.Text = "Laporan KRS Mahasiswa";
            this.btnLaporanKRS.Click += new System.EventHandler(this.btnLaporanKRS_Click);
            // 
            // panelLaporan
            // 
            this.panelLaporan.BackColor = System.Drawing.Color.Transparent;
            this.panelLaporan.Controls.Add(this.btnMabres);
            this.panelLaporan.Controls.Add(this.btnLaporanKRPP);
            this.panelLaporan.Controls.Add(this.btnLaporanKRS);
            this.panelLaporan.Location = new System.Drawing.Point(25, 832);
            this.panelLaporan.Margin = new System.Windows.Forms.Padding(2);
            this.panelLaporan.Name = "panelLaporan";
            this.panelLaporan.Size = new System.Drawing.Size(377, 122);
            this.panelLaporan.TabIndex = 15;
            // 
            // btnMabres
            // 
            this.btnMabres.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnMabres.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMabres.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMabres.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMabres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMabres.FillColor = System.Drawing.Color.Transparent;
            this.btnMabres.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMabres.ForeColor = System.Drawing.Color.White;
            this.btnMabres.Location = new System.Drawing.Point(0, 81);
            this.btnMabres.Margin = new System.Windows.Forms.Padding(2);
            this.btnMabres.Name = "btnMabres";
            this.btnMabres.Size = new System.Drawing.Size(375, 45);
            this.btnMabres.TabIndex = 3;
            this.btnMabres.Text = "Laporan Mahasiswa Berprestasi";
            this.btnMabres.Click += new System.EventHandler(this.btnMabres_Click);
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
            this.btnJenisPrestasi.Location = new System.Drawing.Point(0, 173);
            this.btnJenisPrestasi.Margin = new System.Windows.Forms.Padding(2);
            this.btnJenisPrestasi.Name = "btnJenisPrestasi";
            this.btnJenisPrestasi.Size = new System.Drawing.Size(375, 45);
            this.btnJenisPrestasi.TabIndex = 6;
            this.btnJenisPrestasi.Text = "Jenis Prestasi";
            this.btnJenisPrestasi.Click += new System.EventHandler(this.btnJenisPrestasi_Click);
            // 
            // btnPosisiPrestasi
            // 
            this.btnPosisiPrestasi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPosisiPrestasi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPosisiPrestasi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPosisiPrestasi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPosisiPrestasi.FillColor = System.Drawing.Color.Transparent;
            this.btnPosisiPrestasi.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosisiPrestasi.ForeColor = System.Drawing.Color.White;
            this.btnPosisiPrestasi.Location = new System.Drawing.Point(0, 214);
            this.btnPosisiPrestasi.Margin = new System.Windows.Forms.Padding(2);
            this.btnPosisiPrestasi.Name = "btnPosisiPrestasi";
            this.btnPosisiPrestasi.Size = new System.Drawing.Size(375, 45);
            this.btnPosisiPrestasi.TabIndex = 5;
            this.btnPosisiPrestasi.Text = "Posisi Prestasi";
            this.btnPosisiPrestasi.Click += new System.EventHandler(this.btnPosisiPrestasi_Click);
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
            this.btnPengumuman.Location = new System.Drawing.Point(0, 258);
            this.btnPengumuman.Margin = new System.Windows.Forms.Padding(2);
            this.btnPengumuman.Name = "btnPengumuman";
            this.btnPengumuman.Size = new System.Drawing.Size(375, 37);
            this.btnPengumuman.TabIndex = 4;
            this.btnPengumuman.Text = "Pengumuman";
            this.btnPengumuman.Click += new System.EventHandler(this.btnPengumuman_Click);
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
            this.btnMatakuliah.Location = new System.Drawing.Point(0, 89);
            this.btnMatakuliah.Margin = new System.Windows.Forms.Padding(2);
            this.btnMatakuliah.Name = "btnMatakuliah";
            this.btnMatakuliah.Size = new System.Drawing.Size(375, 45);
            this.btnMatakuliah.TabIndex = 4;
            this.btnMatakuliah.Text = "Mata Kuliah";
            this.btnMatakuliah.Click += new System.EventHandler(this.btnMatakuliah_Click);
            // 
            // btnDosen
            // 
            this.btnDosen.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnDosen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDosen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDosen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDosen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDosen.FillColor = System.Drawing.Color.Transparent;
            this.btnDosen.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDosen.ForeColor = System.Drawing.Color.White;
            this.btnDosen.Location = new System.Drawing.Point(0, 48);
            this.btnDosen.Margin = new System.Windows.Forms.Padding(2);
            this.btnDosen.Name = "btnDosen";
            this.btnDosen.Size = new System.Drawing.Size(375, 45);
            this.btnDosen.TabIndex = 2;
            this.btnDosen.Text = "Dosen";
            this.btnDosen.Click += new System.EventHandler(this.btnDosen_Click);
            // 
            // btnMahasiswa
            // 
            this.btnMahasiswa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMahasiswa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMahasiswa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMahasiswa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMahasiswa.FillColor = System.Drawing.Color.Transparent;
            this.btnMahasiswa.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMahasiswa.ForeColor = System.Drawing.Color.White;
            this.btnMahasiswa.Location = new System.Drawing.Point(0, 130);
            this.btnMahasiswa.Margin = new System.Windows.Forms.Padding(2);
            this.btnMahasiswa.Name = "btnMahasiswa";
            this.btnMahasiswa.Size = new System.Drawing.Size(375, 45);
            this.btnMahasiswa.TabIndex = 1;
            this.btnMahasiswa.Text = "Mahasiswa";
            this.btnMahasiswa.Click += new System.EventHandler(this.btnMahasiswa_Click);
            // 
            // timerTRS
            // 
            this.timerTRS.Interval = 10;
            this.timerTRS.Tick += new System.EventHandler(this.timerTRS_Tick);
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
            this.btnTrsKRPP.Location = new System.Drawing.Point(0, 48);
            this.btnTrsKRPP.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrsKRPP.Name = "btnTrsKRPP";
            this.btnTrsKRPP.Size = new System.Drawing.Size(375, 45);
            this.btnTrsKRPP.TabIndex = 2;
            this.btnTrsKRPP.Text = "KRPP Mahasiswa";
            this.btnTrsKRPP.Click += new System.EventHandler(this.btnTrsKRPP_Click);
            // 
            // btnTrsKRS
            // 
            this.btnTrsKRS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTrsKRS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTrsKRS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTrsKRS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTrsKRS.FillColor = System.Drawing.Color.Transparent;
            this.btnTrsKRS.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrsKRS.ForeColor = System.Drawing.Color.White;
            this.btnTrsKRS.Location = new System.Drawing.Point(-2, 6);
            this.btnTrsKRS.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrsKRS.Name = "btnTrsKRS";
            this.btnTrsKRS.Size = new System.Drawing.Size(375, 45);
            this.btnTrsKRS.TabIndex = 0;
            this.btnTrsKRS.Text = "KRS Mahasiswa";
            this.btnTrsKRS.Click += new System.EventHandler(this.btnTrsKRS_Click);
            // 
            // btnProdi
            // 
            this.btnProdi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProdi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProdi.FillColor = System.Drawing.Color.Transparent;
            this.btnProdi.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdi.ForeColor = System.Drawing.Color.White;
            this.btnProdi.Location = new System.Drawing.Point(-2, 6);
            this.btnProdi.Margin = new System.Windows.Forms.Padding(2);
            this.btnProdi.Name = "btnProdi";
            this.btnProdi.Size = new System.Drawing.Size(375, 45);
            this.btnProdi.TabIndex = 0;
            this.btnProdi.Text = "Program Studi";
            this.btnProdi.Click += new System.EventHandler(this.btnProdi_Click);
            // 
            // timerData
            // 
            this.timerData.Interval = 10;
            this.timerData.Tick += new System.EventHandler(this.timerData_Tick);
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
            this.btnKembali.Location = new System.Drawing.Point(71, 973);
            this.btnKembali.Margin = new System.Windows.Forms.Padding(2);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(370, 59);
            this.btnKembali.TabIndex = 16;
            this.btnKembali.UseTransparentBackground = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // panelTransaksi
            // 
            this.panelTransaksi.BackColor = System.Drawing.Color.Transparent;
            this.panelTransaksi.Controls.Add(this.btnTrsKRPP);
            this.panelTransaksi.Controls.Add(this.btnTrsKRS);
            this.panelTransaksi.Location = new System.Drawing.Point(25, 672);
            this.panelTransaksi.Margin = new System.Windows.Forms.Padding(2);
            this.panelTransaksi.Name = "panelTransaksi";
            this.panelTransaksi.Size = new System.Drawing.Size(377, 84);
            this.panelTransaksi.TabIndex = 14;
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.Transparent;
            this.panelData.Controls.Add(this.btnJenisPrestasi);
            this.panelData.Controls.Add(this.btnPosisiPrestasi);
            this.panelData.Controls.Add(this.btnPengumuman);
            this.panelData.Controls.Add(this.btnMatakuliah);
            this.panelData.Controls.Add(this.btnDosen);
            this.panelData.Controls.Add(this.btnMahasiswa);
            this.panelData.Controls.Add(this.btnProdi);
            this.panelData.Location = new System.Drawing.Point(25, 234);
            this.panelData.Margin = new System.Windows.Forms.Padding(2);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(377, 289);
            this.panelData.TabIndex = 13;
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
            this.btnLaporan.Location = new System.Drawing.Point(23, 780);
            this.btnLaporan.Margin = new System.Windows.Forms.Padding(2);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(189, 54);
            this.btnLaporan.TabIndex = 12;
            this.btnLaporan.UseTransparentBackground = true;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
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
            this.btnTransaksi.Location = new System.Drawing.Point(25, 624);
            this.btnTransaksi.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new System.Drawing.Size(189, 54);
            this.btnTransaksi.TabIndex = 11;
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
            this.btnData.Location = new System.Drawing.Point(24, 175);
            this.btnData.Margin = new System.Windows.Forms.Padding(2);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(152, 54);
            this.btnData.TabIndex = 10;
            this.btnData.UseTransparentBackground = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Location = new System.Drawing.Point(523, 27);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1376, 1033);
            this.panelMain.TabIndex = 17;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // DasboardTendik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJECT_PRG2.Properties.Resources.dasboard_tendik;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelLaporan);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.panelTransaksi);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.btnLaporan);
            this.Controls.Add(this.btnTransaksi);
            this.Controls.Add(this.btnData);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DasboardTendik";
            this.Text = "DasboardTendik";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelLaporan.ResumeLayout(false);
            this.panelTransaksi.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerLaporan;
        private Guna.UI2.WinForms.Guna2Button btnLaporanKRPP;
        private Guna.UI2.WinForms.Guna2Button btnLaporanKRS;
        private System.Windows.Forms.Panel panelLaporan;
        private Guna.UI2.WinForms.Guna2Button btnJenisPrestasi;
        private Guna.UI2.WinForms.Guna2Button btnPosisiPrestasi;
        private Guna.UI2.WinForms.Guna2Button btnPengumuman;
        private Guna.UI2.WinForms.Guna2Button btnMatakuliah;
        private Guna.UI2.WinForms.Guna2Button btnDosen;
        private Guna.UI2.WinForms.Guna2Button btnMahasiswa;
        private System.Windows.Forms.Timer timerTRS;
        private Guna.UI2.WinForms.Guna2Button btnTrsKRPP;
        private Guna.UI2.WinForms.Guna2Button btnTrsKRS;
        private Guna.UI2.WinForms.Guna2Button btnProdi;
        private System.Windows.Forms.Timer timerData;
        private Guna.UI2.WinForms.Guna2Button btnKembali;
        private System.Windows.Forms.Panel panelTransaksi;
        private System.Windows.Forms.Panel panelData;
        private Guna.UI2.WinForms.Guna2Button btnLaporan;
        private Guna.UI2.WinForms.Guna2Button btnTransaksi;
        private Guna.UI2.WinForms.Guna2Button btnData;
        private System.Windows.Forms.Panel panelMain;
        private Guna.UI2.WinForms.Guna2Button btnMabres;
    }
}