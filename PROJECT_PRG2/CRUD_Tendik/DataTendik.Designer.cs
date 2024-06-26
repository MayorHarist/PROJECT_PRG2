﻿using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace PROJECT_PRG2.CRUD_Tendik
{
    partial class DataTendik
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
            this.btnTambahTendik = new Guna.UI2.WinForms.Guna2Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TelpTendik = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmailTendik = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAlmatTendik = new Guna.UI2.WinForms.Guna2TextBox();
            this.rbPuan = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbLaki = new Guna.UI2.WinForms.Guna2RadioButton();
            this.tglLahirTendik = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtPassTendik = new Guna.UI2.WinForms.Guna2TextBox();
            this.userNmTendik = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNamaTendik = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDTendik = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBatalTendik = new Guna.UI2.WinForms.Guna2Button();
            this.btnKembali = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnTambahTendik
            // 
            this.btnTambahTendik.AutoRoundedCorners = true;
            this.btnTambahTendik.BorderRadius = 17;
            this.btnTambahTendik.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTambahTendik.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTambahTendik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTambahTendik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTambahTendik.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.btnTambahTendik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahTendik.ForeColor = System.Drawing.Color.White;
            this.btnTambahTendik.Location = new System.Drawing.Point(584, 368);
            this.btnTambahTendik.Margin = new System.Windows.Forms.Padding(2);
            this.btnTambahTendik.Name = "btnTambahTendik";
            this.btnTambahTendik.Size = new System.Drawing.Size(112, 36);
            this.btnTambahTendik.TabIndex = 83;
            this.btnTambahTendik.Text = "Simpan";
            this.btnTambahTendik.Click += new System.EventHandler(this.btnTambahTendik_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(263, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(269, 20);
            this.label11.TabIndex = 82;
            this.label11.Text = "DATA TENAGA KEPENDIDIKAN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(104, 163);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 81;
            this.label10.Text = "Nama";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(431, 200);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 80;
            this.label9.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(431, 238);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 79;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(104, 200);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 15);
            this.label7.TabIndex = 78;
            this.label7.Text = "Tanggal Lahir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 77;
            this.label6.Text = "Jenis Kelamin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(104, 276);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 76;
            this.label5.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(431, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 75;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(431, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 74;
            this.label3.Text = "Telepon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 72;
            this.label1.Text = "ID TKDN";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(135, 125);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel2.TabIndex = 71;
            this.guna2HtmlLabel2.Text = null;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(135, 125);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel1.TabIndex = 70;
            this.guna2HtmlLabel1.Text = null;
            // 
            // TelpTendik
            // 
            this.TelpTendik.Animated = true;
            this.TelpTendik.BackColor = System.Drawing.Color.Transparent;
            this.TelpTendik.BorderColor = System.Drawing.Color.Black;
            this.TelpTendik.BorderRadius = 10;
            this.TelpTendik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TelpTendik.DefaultText = "";
            this.TelpTendik.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TelpTendik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TelpTendik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TelpTendik.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TelpTendik.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TelpTendik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TelpTendik.ForeColor = System.Drawing.Color.Black;
            this.TelpTendik.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TelpTendik.Location = new System.Drawing.Point(505, 163);
            this.TelpTendik.Margin = new System.Windows.Forms.Padding(4);
            this.TelpTendik.Name = "TelpTendik";
            this.TelpTendik.PasswordChar = '\0';
            this.TelpTendik.PlaceholderText = "";
            this.TelpTendik.SelectedText = "";
            this.TelpTendik.Size = new System.Drawing.Size(191, 31);
            this.TelpTendik.TabIndex = 68;
            this.TelpTendik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelpTendik_KeyPress);
            // 
            // txtEmailTendik
            // 
            this.txtEmailTendik.Animated = true;
            this.txtEmailTendik.BackColor = System.Drawing.Color.Transparent;
            this.txtEmailTendik.BorderColor = System.Drawing.Color.Black;
            this.txtEmailTendik.BorderRadius = 10;
            this.txtEmailTendik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailTendik.DefaultText = "";
            this.txtEmailTendik.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmailTendik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmailTendik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailTendik.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailTendik.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailTendik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtEmailTendik.ForeColor = System.Drawing.Color.Black;
            this.txtEmailTendik.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailTendik.Location = new System.Drawing.Point(505, 125);
            this.txtEmailTendik.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailTendik.Name = "txtEmailTendik";
            this.txtEmailTendik.PasswordChar = '\0';
            this.txtEmailTendik.PlaceholderText = "";
            this.txtEmailTendik.SelectedText = "";
            this.txtEmailTendik.Size = new System.Drawing.Size(191, 31);
            this.txtEmailTendik.TabIndex = 67;
            // 
            // txtAlmatTendik
            // 
            this.txtAlmatTendik.Animated = true;
            this.txtAlmatTendik.BackColor = System.Drawing.Color.Transparent;
            this.txtAlmatTendik.BorderColor = System.Drawing.Color.Black;
            this.txtAlmatTendik.BorderRadius = 10;
            this.txtAlmatTendik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlmatTendik.DefaultText = "";
            this.txtAlmatTendik.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAlmatTendik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAlmatTendik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAlmatTendik.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAlmatTendik.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAlmatTendik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtAlmatTendik.ForeColor = System.Drawing.Color.Black;
            this.txtAlmatTendik.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAlmatTendik.Location = new System.Drawing.Point(221, 268);
            this.txtAlmatTendik.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlmatTendik.Multiline = true;
            this.txtAlmatTendik.Name = "txtAlmatTendik";
            this.txtAlmatTendik.PasswordChar = '\0';
            this.txtAlmatTendik.PlaceholderText = "";
            this.txtAlmatTendik.SelectedText = "";
            this.txtAlmatTendik.Size = new System.Drawing.Size(191, 69);
            this.txtAlmatTendik.TabIndex = 66;
            // 
            // rbPuan
            // 
            this.rbPuan.AutoSize = true;
            this.rbPuan.BackColor = System.Drawing.Color.Transparent;
            this.rbPuan.CheckedState.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.rbPuan.CheckedState.BorderThickness = 0;
            this.rbPuan.CheckedState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.rbPuan.CheckedState.InnerColor = System.Drawing.SystemColors.MenuHighlight;
            this.rbPuan.CheckedState.InnerOffset = -4;
            this.rbPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbPuan.ForeColor = System.Drawing.Color.Black;
            this.rbPuan.Location = new System.Drawing.Point(305, 240);
            this.rbPuan.Margin = new System.Windows.Forms.Padding(2);
            this.rbPuan.Name = "rbPuan";
            this.rbPuan.Size = new System.Drawing.Size(90, 19);
            this.rbPuan.TabIndex = 65;
            this.rbPuan.Text = "Perempuan";
            this.rbPuan.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbPuan.UncheckedState.BorderThickness = 2;
            this.rbPuan.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbPuan.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbPuan.UseVisualStyleBackColor = false;
            // 
            // rbLaki
            // 
            this.rbLaki.AutoSize = true;
            this.rbLaki.BackColor = System.Drawing.Color.Transparent;
            this.rbLaki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rbLaki.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbLaki.CheckedState.BorderThickness = 0;
            this.rbLaki.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbLaki.CheckedState.InnerColor = System.Drawing.SystemColors.MenuHighlight;
            this.rbLaki.CheckedState.InnerOffset = -4;
            this.rbLaki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbLaki.ForeColor = System.Drawing.Color.Black;
            this.rbLaki.Location = new System.Drawing.Point(221, 240);
            this.rbLaki.Margin = new System.Windows.Forms.Padding(2);
            this.rbLaki.Name = "rbLaki";
            this.rbLaki.Size = new System.Drawing.Size(77, 19);
            this.rbLaki.TabIndex = 64;
            this.rbLaki.Text = "Laki - laki";
            this.rbLaki.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbLaki.UncheckedState.BorderThickness = 2;
            this.rbLaki.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbLaki.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbLaki.UseVisualStyleBackColor = false;
            // 
            // tglLahirTendik
            // 
            this.tglLahirTendik.Animated = true;
            this.tglLahirTendik.AutoRoundedCorners = true;
            this.tglLahirTendik.BackColor = System.Drawing.Color.Transparent;
            this.tglLahirTendik.BorderRadius = 16;
            this.tglLahirTendik.Checked = true;
            this.tglLahirTendik.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.tglLahirTendik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tglLahirTendik.ForeColor = System.Drawing.Color.White;
            this.tglLahirTendik.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tglLahirTendik.Location = new System.Drawing.Point(221, 200);
            this.tglLahirTendik.Margin = new System.Windows.Forms.Padding(2);
            this.tglLahirTendik.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tglLahirTendik.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tglLahirTendik.Name = "tglLahirTendik";
            this.tglLahirTendik.Size = new System.Drawing.Size(191, 34);
            this.tglLahirTendik.TabIndex = 63;
            this.tglLahirTendik.Value = new System.DateTime(2024, 6, 15, 22, 37, 28, 314);
            // 
            // txtPassTendik
            // 
            this.txtPassTendik.Animated = true;
            this.txtPassTendik.BackColor = System.Drawing.Color.Transparent;
            this.txtPassTendik.BorderColor = System.Drawing.Color.Black;
            this.txtPassTendik.BorderRadius = 10;
            this.txtPassTendik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassTendik.DefaultText = "";
            this.txtPassTendik.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassTendik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassTendik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassTendik.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassTendik.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassTendik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtPassTendik.ForeColor = System.Drawing.Color.Black;
            this.txtPassTendik.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassTendik.Location = new System.Drawing.Point(505, 237);
            this.txtPassTendik.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassTendik.Name = "txtPassTendik";
            this.txtPassTendik.PasswordChar = '\0';
            this.txtPassTendik.PlaceholderText = "";
            this.txtPassTendik.SelectedText = "";
            this.txtPassTendik.Size = new System.Drawing.Size(191, 31);
            this.txtPassTendik.TabIndex = 62;
            // 
            // userNmTendik
            // 
            this.userNmTendik.Animated = true;
            this.userNmTendik.BackColor = System.Drawing.Color.Transparent;
            this.userNmTendik.BorderColor = System.Drawing.Color.Black;
            this.userNmTendik.BorderRadius = 10;
            this.userNmTendik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNmTendik.DefaultText = "";
            this.userNmTendik.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userNmTendik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userNmTendik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNmTendik.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNmTendik.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNmTendik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.userNmTendik.ForeColor = System.Drawing.Color.Black;
            this.userNmTendik.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNmTendik.Location = new System.Drawing.Point(507, 199);
            this.userNmTendik.Margin = new System.Windows.Forms.Padding(4);
            this.userNmTendik.Name = "userNmTendik";
            this.userNmTendik.PasswordChar = '\0';
            this.userNmTendik.PlaceholderText = "";
            this.userNmTendik.SelectedText = "";
            this.userNmTendik.Size = new System.Drawing.Size(191, 31);
            this.userNmTendik.TabIndex = 61;
            // 
            // txtNamaTendik
            // 
            this.txtNamaTendik.Animated = true;
            this.txtNamaTendik.BackColor = System.Drawing.Color.Transparent;
            this.txtNamaTendik.BorderColor = System.Drawing.Color.Black;
            this.txtNamaTendik.BorderRadius = 10;
            this.txtNamaTendik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamaTendik.DefaultText = "";
            this.txtNamaTendik.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNamaTendik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNamaTendik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaTendik.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaTendik.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaTendik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNamaTendik.ForeColor = System.Drawing.Color.Black;
            this.txtNamaTendik.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaTendik.Location = new System.Drawing.Point(221, 163);
            this.txtNamaTendik.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamaTendik.Name = "txtNamaTendik";
            this.txtNamaTendik.PasswordChar = '\0';
            this.txtNamaTendik.PlaceholderText = "";
            this.txtNamaTendik.SelectedText = "";
            this.txtNamaTendik.Size = new System.Drawing.Size(191, 31);
            this.txtNamaTendik.TabIndex = 60;
            this.txtNamaTendik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamaTendik_KeyPress);
            // 
            // txtIDTendik
            // 
            this.txtIDTendik.Animated = true;
            this.txtIDTendik.BackColor = System.Drawing.Color.Transparent;
            this.txtIDTendik.BorderColor = System.Drawing.Color.Black;
            this.txtIDTendik.BorderRadius = 10;
            this.txtIDTendik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDTendik.DefaultText = "";
            this.txtIDTendik.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDTendik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDTendik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDTendik.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDTendik.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDTendik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtIDTendik.ForeColor = System.Drawing.Color.Black;
            this.txtIDTendik.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDTendik.Location = new System.Drawing.Point(221, 125);
            this.txtIDTendik.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDTendik.Name = "txtIDTendik";
            this.txtIDTendik.PasswordChar = '\0';
            this.txtIDTendik.PlaceholderText = "";
            this.txtIDTendik.SelectedText = "";
            this.txtIDTendik.Size = new System.Drawing.Size(191, 31);
            this.txtIDTendik.TabIndex = 59;
            // 
            // btnBatalTendik
            // 
            this.btnBatalTendik.AutoRoundedCorners = true;
            this.btnBatalTendik.BorderRadius = 17;
            this.btnBatalTendik.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBatalTendik.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBatalTendik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBatalTendik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBatalTendik.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.btnBatalTendik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatalTendik.ForeColor = System.Drawing.Color.White;
            this.btnBatalTendik.Location = new System.Drawing.Point(221, 368);
            this.btnBatalTendik.Margin = new System.Windows.Forms.Padding(2);
            this.btnBatalTendik.Name = "btnBatalTendik";
            this.btnBatalTendik.Size = new System.Drawing.Size(112, 36);
            this.btnBatalTendik.TabIndex = 84;
            this.btnBatalTendik.Text = "Batal";
            this.btnBatalTendik.Click += new System.EventHandler(this.btnBatalTendik_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.AutoRoundedCorners = true;
            this.btnKembali.BorderRadius = 17;
            this.btnKembali.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKembali.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKembali.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKembali.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKembali.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.ForeColor = System.Drawing.Color.White;
            this.btnKembali.Location = new System.Drawing.Point(409, 368);
            this.btnKembali.Margin = new System.Windows.Forms.Padding(2);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(112, 36);
            this.btnKembali.TabIndex = 87;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // DataTendik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 736);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnBatalTendik);
            this.Controls.Add(this.btnTambahTendik);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.TelpTendik);
            this.Controls.Add(this.txtEmailTendik);
            this.Controls.Add(this.txtAlmatTendik);
            this.Controls.Add(this.rbPuan);
            this.Controls.Add(this.rbLaki);
            this.Controls.Add(this.tglLahirTendik);
            this.Controls.Add(this.txtPassTendik);
            this.Controls.Add(this.userNmTendik);
            this.Controls.Add(this.txtNamaTendik);
            this.Controls.Add(this.txtIDTendik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataTendik";
            this.Text = "DataTendik";
            this.Load += new System.EventHandler(this.DataTendik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnTambahTendik;

        public DataTendik(Guna2Button btnTambahTendik)
        {
            this.btnTambahTendik = btnTambahTendik;
        }

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;

        public DataTendik(Label label5)
        {
            this.label5 = label5;
        }

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox TelpTendik;
        private Guna.UI2.WinForms.Guna2TextBox txtEmailTendik;
        private Guna.UI2.WinForms.Guna2TextBox txtAlmatTendik;
        private Guna.UI2.WinForms.Guna2RadioButton rbPuan;
        private Guna.UI2.WinForms.Guna2RadioButton rbLaki;
        private Guna.UI2.WinForms.Guna2DateTimePicker tglLahirTendik;
        private Guna.UI2.WinForms.Guna2TextBox txtPassTendik;
        private Guna.UI2.WinForms.Guna2TextBox userNmTendik;
        private Guna.UI2.WinForms.Guna2TextBox txtNamaTendik;
        private Guna.UI2.WinForms.Guna2TextBox txtIDTendik;
        private Guna.UI2.WinForms.Guna2Button btnBatalTendik;
        private Guna2Button btnKembali;
    }
}