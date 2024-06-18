﻿using System.Windows.Forms;

namespace PROJECT_PRG2.CRUD_Tendik
{
    partial class UpdateTendik
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtStatusTendik = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.btnCariTendik = new Guna.UI2.WinForms.Guna2Button();
            this.btnUbahTendik = new Guna.UI2.WinForms.Guna2Button();
            this.btnHapusTendik = new Guna.UI2.WinForms.Guna2Button();
            this.btnBatalUpTendik = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tenagaKependidikanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTKNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalLahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisKelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teleponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fINDSMART = new PROJECT_PRG2.FINDSMART();
            this.tenagaKependidikanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tenagaKependidikanTableAdapter1 = new PROJECT_PRG2.FINDSMARTTableAdapters.TenagaKependidikanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenagaKependidikanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMART)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenagaKependidikanBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1151, 72);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(451, 32);
            this.label11.TabIndex = 106;
            this.label11.Text = "DATA TENAGA KEPENDIDIKAN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(812, 253);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 25);
            this.label10.TabIndex = 105;
            this.label10.Text = "Nama";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1437, 323);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 25);
            this.label9.TabIndex = 104;
            this.label9.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1437, 393);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 25);
            this.label8.TabIndex = 103;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(812, 321);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 25);
            this.label7.TabIndex = 102;
            this.label7.Text = "Tanggal Lahir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(812, 395);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 25);
            this.label6.TabIndex = 101;
            this.label6.Text = "Jenis Kelamin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(812, 462);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 100;
            this.label5.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1437, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 99;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1437, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 98;
            this.label3.Text = "Telepon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1437, 462);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 97;
            this.label2.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(812, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 96;
            this.label1.Text = "ID TKDN";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(869, 183);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel2.TabIndex = 95;
            this.guna2HtmlLabel2.Text = null;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(869, 183);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel1.TabIndex = 94;
            this.guna2HtmlLabel1.Text = null;
            // 
            // txtStatusTendik
            // 
            this.txtStatusTendik.Animated = true;
            this.txtStatusTendik.BackColor = System.Drawing.Color.Transparent;
            this.txtStatusTendik.BorderColor = System.Drawing.Color.Black;
            this.txtStatusTendik.BorderRadius = 10;
            this.txtStatusTendik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStatusTendik.DefaultText = "";
            this.txtStatusTendik.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStatusTendik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStatusTendik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStatusTendik.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStatusTendik.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStatusTendik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtStatusTendik.ForeColor = System.Drawing.Color.Black;
            this.txtStatusTendik.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStatusTendik.Location = new System.Drawing.Point(1593, 462);
            this.txtStatusTendik.Margin = new System.Windows.Forms.Padding(9);
            this.txtStatusTendik.Name = "txtStatusTendik";
            this.txtStatusTendik.PasswordChar = '\0';
            this.txtStatusTendik.PlaceholderText = "";
            this.txtStatusTendik.SelectedText = "";
            this.txtStatusTendik.Size = new System.Drawing.Size(350, 57);
            this.txtStatusTendik.TabIndex = 93;
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
            this.TelpTendik.Location = new System.Drawing.Point(1593, 257);
            this.TelpTendik.Margin = new System.Windows.Forms.Padding(9);
            this.TelpTendik.Name = "TelpTendik";
            this.TelpTendik.PasswordChar = '\0';
            this.TelpTendik.PlaceholderText = "";
            this.TelpTendik.SelectedText = "";
            this.TelpTendik.Size = new System.Drawing.Size(350, 57);
            this.TelpTendik.TabIndex = 92;
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
            this.txtEmailTendik.Location = new System.Drawing.Point(1593, 186);
            this.txtEmailTendik.Margin = new System.Windows.Forms.Padding(9);
            this.txtEmailTendik.Name = "txtEmailTendik";
            this.txtEmailTendik.PasswordChar = '\0';
            this.txtEmailTendik.PlaceholderText = "";
            this.txtEmailTendik.SelectedText = "";
            this.txtEmailTendik.Size = new System.Drawing.Size(350, 57);
            this.txtEmailTendik.TabIndex = 91;
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
            this.txtAlmatTendik.Location = new System.Drawing.Point(1027, 447);
            this.txtAlmatTendik.Margin = new System.Windows.Forms.Padding(9);
            this.txtAlmatTendik.Multiline = true;
            this.txtAlmatTendik.Name = "txtAlmatTendik";
            this.txtAlmatTendik.PasswordChar = '\0';
            this.txtAlmatTendik.PlaceholderText = "";
            this.txtAlmatTendik.SelectedText = "";
            this.txtAlmatTendik.Size = new System.Drawing.Size(350, 89);
            this.txtAlmatTendik.TabIndex = 90;
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
            this.rbPuan.Location = new System.Drawing.Point(1181, 395);
            this.rbPuan.Margin = new System.Windows.Forms.Padding(4);
            this.rbPuan.Name = "rbPuan";
            this.rbPuan.Size = new System.Drawing.Size(147, 29);
            this.rbPuan.TabIndex = 89;
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
            this.rbLaki.Location = new System.Drawing.Point(1027, 395);
            this.rbLaki.Margin = new System.Windows.Forms.Padding(4);
            this.rbLaki.Name = "rbLaki";
            this.rbLaki.Size = new System.Drawing.Size(129, 29);
            this.rbLaki.TabIndex = 88;
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
            this.tglLahirTendik.BorderRadius = 30;
            this.tglLahirTendik.Checked = true;
            this.tglLahirTendik.FillColor = System.Drawing.Color.HotPink;
            this.tglLahirTendik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tglLahirTendik.ForeColor = System.Drawing.Color.Black;
            this.tglLahirTendik.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tglLahirTendik.Location = new System.Drawing.Point(1027, 321);
            this.tglLahirTendik.Margin = new System.Windows.Forms.Padding(4);
            this.tglLahirTendik.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tglLahirTendik.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tglLahirTendik.Name = "tglLahirTendik";
            this.tglLahirTendik.Size = new System.Drawing.Size(350, 63);
            this.tglLahirTendik.TabIndex = 87;
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
            this.txtPassTendik.Location = new System.Drawing.Point(1593, 393);
            this.txtPassTendik.Margin = new System.Windows.Forms.Padding(9);
            this.txtPassTendik.Name = "txtPassTendik";
            this.txtPassTendik.PasswordChar = '\0';
            this.txtPassTendik.PlaceholderText = "";
            this.txtPassTendik.SelectedText = "";
            this.txtPassTendik.Size = new System.Drawing.Size(350, 57);
            this.txtPassTendik.TabIndex = 86;
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
            this.userNmTendik.Location = new System.Drawing.Point(1597, 323);
            this.userNmTendik.Margin = new System.Windows.Forms.Padding(9);
            this.userNmTendik.Name = "userNmTendik";
            this.userNmTendik.PasswordChar = '\0';
            this.userNmTendik.PlaceholderText = "";
            this.userNmTendik.SelectedText = "";
            this.userNmTendik.Size = new System.Drawing.Size(350, 57);
            this.userNmTendik.TabIndex = 85;
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
            this.txtNamaTendik.Location = new System.Drawing.Point(1027, 253);
            this.txtNamaTendik.Margin = new System.Windows.Forms.Padding(9);
            this.txtNamaTendik.Name = "txtNamaTendik";
            this.txtNamaTendik.PasswordChar = '\0';
            this.txtNamaTendik.PlaceholderText = "";
            this.txtNamaTendik.SelectedText = "";
            this.txtNamaTendik.Size = new System.Drawing.Size(350, 57);
            this.txtNamaTendik.TabIndex = 84;
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
            this.txtIDTendik.Location = new System.Drawing.Point(1027, 183);
            this.txtIDTendik.Margin = new System.Windows.Forms.Padding(9);
            this.txtIDTendik.Name = "txtIDTendik";
            this.txtIDTendik.PasswordChar = '\0';
            this.txtIDTendik.PlaceholderText = "";
            this.txtIDTendik.SelectedText = "";
            this.txtIDTendik.Size = new System.Drawing.Size(204, 57);
            this.txtIDTendik.TabIndex = 83;
            this.txtIDTendik.TextChanged += new System.EventHandler(this.txtIDTendik_TextChanged);
            // 
            // btnCariTendik
            // 
            this.btnCariTendik.AutoRoundedCorners = true;
            this.btnCariTendik.BorderRadius = 32;
            this.btnCariTendik.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCariTendik.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCariTendik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCariTendik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCariTendik.FillColor = System.Drawing.Color.HotPink;
            this.btnCariTendik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCariTendik.ForeColor = System.Drawing.Color.White;
            this.btnCariTendik.Location = new System.Drawing.Point(1239, 177);
            this.btnCariTendik.Margin = new System.Windows.Forms.Padding(4);
            this.btnCariTendik.Name = "btnCariTendik";
            this.btnCariTendik.Size = new System.Drawing.Size(138, 66);
            this.btnCariTendik.TabIndex = 107;
            this.btnCariTendik.Text = "Cari";
            this.btnCariTendik.Click += new System.EventHandler(this.btnCariTendik_Click);
            // 
            // btnUbahTendik
            // 
            this.btnUbahTendik.AutoRoundedCorners = true;
            this.btnUbahTendik.BorderRadius = 32;
            this.btnUbahTendik.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUbahTendik.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUbahTendik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUbahTendik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUbahTendik.FillColor = System.Drawing.Color.HotPink;
            this.btnUbahTendik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbahTendik.ForeColor = System.Drawing.Color.White;
            this.btnUbahTendik.Location = new System.Drawing.Point(986, 606);
            this.btnUbahTendik.Margin = new System.Windows.Forms.Padding(4);
            this.btnUbahTendik.Name = "btnUbahTendik";
            this.btnUbahTendik.Size = new System.Drawing.Size(205, 66);
            this.btnUbahTendik.TabIndex = 108;
            this.btnUbahTendik.Text = "Ubah";
            this.btnUbahTendik.Click += new System.EventHandler(this.btnUbahTendik_Click);
            // 
            // btnHapusTendik
            // 
            this.btnHapusTendik.AutoRoundedCorners = true;
            this.btnHapusTendik.BorderRadius = 32;
            this.btnHapusTendik.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHapusTendik.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHapusTendik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHapusTendik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHapusTendik.FillColor = System.Drawing.Color.HotPink;
            this.btnHapusTendik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapusTendik.ForeColor = System.Drawing.Color.White;
            this.btnHapusTendik.Location = new System.Drawing.Point(1634, 606);
            this.btnHapusTendik.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapusTendik.Name = "btnHapusTendik";
            this.btnHapusTendik.Size = new System.Drawing.Size(205, 66);
            this.btnHapusTendik.TabIndex = 109;
            this.btnHapusTendik.Text = "Hapus";
            this.btnHapusTendik.Click += new System.EventHandler(this.btnHapusTendik_Click);
            // 
            // btnBatalUpTendik
            // 
            this.btnBatalUpTendik.AutoRoundedCorners = true;
            this.btnBatalUpTendik.BorderRadius = 32;
            this.btnBatalUpTendik.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBatalUpTendik.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBatalUpTendik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBatalUpTendik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBatalUpTendik.FillColor = System.Drawing.Color.HotPink;
            this.btnBatalUpTendik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatalUpTendik.ForeColor = System.Drawing.Color.White;
            this.btnBatalUpTendik.Location = new System.Drawing.Point(1326, 606);
            this.btnBatalUpTendik.Margin = new System.Windows.Forms.Padding(4);
            this.btnBatalUpTendik.Name = "btnBatalUpTendik";
            this.btnBatalUpTendik.Size = new System.Drawing.Size(205, 66);
            this.btnBatalUpTendik.TabIndex = 110;
            this.btnBatalUpTendik.Text = "Batal";
            this.btnBatalUpTendik.Click += new System.EventHandler(this.btnBatalUpTendik_Click);
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTKNDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.tanggalLahirDataGridViewTextBoxColumn,
            this.jenisKelaminDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.teleponDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.tenagaKependidikanBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(506, 804);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 72;
            this.guna2DataGridView1.RowTemplate.Height = 31;
            this.guna2DataGridView1.Size = new System.Drawing.Size(835, 150);
            this.guna2DataGridView1.TabIndex = 111;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 27;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 31;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // idTKNDataGridViewTextBoxColumn
            // 
            this.idTKNDataGridViewTextBoxColumn.DataPropertyName = "Id_TKN";
            this.idTKNDataGridViewTextBoxColumn.HeaderText = "Id_TKN";
            this.idTKNDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.idTKNDataGridViewTextBoxColumn.Name = "idTKNDataGridViewTextBoxColumn";
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // tanggalLahirDataGridViewTextBoxColumn
            // 
            this.tanggalLahirDataGridViewTextBoxColumn.DataPropertyName = "Tanggal_Lahir";
            this.tanggalLahirDataGridViewTextBoxColumn.HeaderText = "Tanggal_Lahir";
            this.tanggalLahirDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.tanggalLahirDataGridViewTextBoxColumn.Name = "tanggalLahirDataGridViewTextBoxColumn";
            // 
            // jenisKelaminDataGridViewTextBoxColumn
            // 
            this.jenisKelaminDataGridViewTextBoxColumn.DataPropertyName = "Jenis_Kelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.HeaderText = "Jenis_Kelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.jenisKelaminDataGridViewTextBoxColumn.Name = "jenisKelaminDataGridViewTextBoxColumn";
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // teleponDataGridViewTextBoxColumn
            // 
            this.teleponDataGridViewTextBoxColumn.DataPropertyName = "Telepon";
            this.teleponDataGridViewTextBoxColumn.HeaderText = "Telepon";
            this.teleponDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.teleponDataGridViewTextBoxColumn.Name = "teleponDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // fINDSMART
            // 
            this.fINDSMART.DataSetName = "FINDSMART";
            this.fINDSMART.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tenagaKependidikanBindingSource1
            // 
            this.tenagaKependidikanBindingSource1.DataMember = "TenagaKependidikan";
            this.tenagaKependidikanBindingSource1.DataSource = this.fINDSMART;
            // 
            // tenagaKependidikanTableAdapter1
            // 
            this.tenagaKependidikanTableAdapter1.ClearBeforeFill = true;
            // 
            // UpdateTendik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1044);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.btnBatalUpTendik);
            this.Controls.Add(this.btnHapusTendik);
            this.Controls.Add(this.btnUbahTendik);
            this.Controls.Add(this.btnCariTendik);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtStatusTendik);
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
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UpdateTendik";
            this.Text = "UpdateTendik";
            this.Load += new System.EventHandler(this.UpdateTendik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenagaKependidikanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMART)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenagaKependidikanBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;

        public UpdateTendik(Label label9)
        {
            this.label9 = label9;
        }

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtStatusTendik;
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
        private Guna.UI2.WinForms.Guna2Button btnCariTendik;
        private Guna.UI2.WinForms.Guna2Button btnUbahTendik;
        private Guna.UI2.WinForms.Guna2Button btnHapusTendik;
        private Guna.UI2.WinForms.Guna2Button btnBatalUpTendik;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
    
        private BindingSource tenagaKependidikanBindingSource;
        private DataGridViewTextBoxColumn idTKNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tanggalLahirDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jenisKelaminDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn teleponDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private FINDSMART fINDSMART;
        private BindingSource tenagaKependidikanBindingSource1;
        private FINDSMARTTableAdapters.TenagaKependidikanTableAdapter tenagaKependidikanTableAdapter1;
    }
}