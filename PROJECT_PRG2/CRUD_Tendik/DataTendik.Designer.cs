using Guna.UI2.WinForms;
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
            this.btnTambahTendik.BackColor = System.Drawing.Color.Transparent;
            this.btnTambahTendik.BorderRadius = 17;
            this.btnTambahTendik.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTambahTendik.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTambahTendik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTambahTendik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTambahTendik.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTambahTendik.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahTendik.ForeColor = System.Drawing.Color.White;
            this.btnTambahTendik.Location = new System.Drawing.Point(459, 538);
            this.btnTambahTendik.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTambahTendik.Name = "btnTambahTendik";
            this.btnTambahTendik.Size = new System.Drawing.Size(128, 36);
            this.btnTambahTendik.TabIndex = 83;
            this.btnTambahTendik.Text = "Simpan";
            this.btnTambahTendik.Click += new System.EventHandler(this.btnTambahTendik_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(106, 238);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 28);
            this.label10.TabIndex = 81;
            this.label10.Text = "Nama";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(488, 292);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 28);
            this.label9.TabIndex = 80;
            this.label9.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(488, 348);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 28);
            this.label8.TabIndex = 79;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(106, 292);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 28);
            this.label7.TabIndex = 78;
            this.label7.Text = "Tanggal Lahir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(106, 351);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 28);
            this.label6.TabIndex = 77;
            this.label6.Text = "Jenis Kelamin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(106, 403);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 28);
            this.label5.TabIndex = 76;
            this.label5.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(488, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 28);
            this.label4.TabIndex = 75;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(488, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 28);
            this.label3.TabIndex = 74;
            this.label3.Text = "Telepon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(106, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 28);
            this.label1.TabIndex = 72;
            this.label1.Text = "ID TKDN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(158, 183);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(158, 183);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.TelpTendik.BorderRadius = 13;
            this.TelpTendik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TelpTendik.DefaultText = "";
            this.TelpTendik.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TelpTendik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TelpTendik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TelpTendik.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TelpTendik.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TelpTendik.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelpTendik.ForeColor = System.Drawing.Color.Black;
            this.TelpTendik.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TelpTendik.Location = new System.Drawing.Point(589, 238);
            this.TelpTendik.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TelpTendik.Name = "TelpTendik";
            this.TelpTendik.PasswordChar = '\0';
            this.TelpTendik.PlaceholderText = "";
            this.TelpTendik.SelectedText = "";
            this.TelpTendik.Size = new System.Drawing.Size(223, 32);
            this.TelpTendik.TabIndex = 68;
            this.TelpTendik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelpTendik_KeyPress);
            // 
            // txtEmailTendik
            // 
            this.txtEmailTendik.Animated = true;
            this.txtEmailTendik.BackColor = System.Drawing.Color.Transparent;
            this.txtEmailTendik.BorderColor = System.Drawing.Color.Black;
            this.txtEmailTendik.BorderRadius = 13;
            this.txtEmailTendik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailTendik.DefaultText = "";
            this.txtEmailTendik.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmailTendik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmailTendik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailTendik.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailTendik.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailTendik.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailTendik.ForeColor = System.Drawing.Color.Black;
            this.txtEmailTendik.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailTendik.Location = new System.Drawing.Point(589, 183);
            this.txtEmailTendik.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtEmailTendik.Name = "txtEmailTendik";
            this.txtEmailTendik.PasswordChar = '\0';
            this.txtEmailTendik.PlaceholderText = "";
            this.txtEmailTendik.SelectedText = "";
            this.txtEmailTendik.Size = new System.Drawing.Size(223, 31);
            this.txtEmailTendik.TabIndex = 67;
            // 
            // txtAlmatTendik
            // 
            this.txtAlmatTendik.Animated = true;
            this.txtAlmatTendik.BackColor = System.Drawing.Color.Transparent;
            this.txtAlmatTendik.BorderColor = System.Drawing.Color.Black;
            this.txtAlmatTendik.BorderRadius = 13;
            this.txtAlmatTendik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlmatTendik.DefaultText = "";
            this.txtAlmatTendik.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAlmatTendik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAlmatTendik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAlmatTendik.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAlmatTendik.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAlmatTendik.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlmatTendik.ForeColor = System.Drawing.Color.Black;
            this.txtAlmatTendik.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAlmatTendik.Location = new System.Drawing.Point(258, 392);
            this.txtAlmatTendik.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtAlmatTendik.Multiline = true;
            this.txtAlmatTendik.Name = "txtAlmatTendik";
            this.txtAlmatTendik.PasswordChar = '\0';
            this.txtAlmatTendik.PlaceholderText = "";
            this.txtAlmatTendik.SelectedText = "";
            this.txtAlmatTendik.Size = new System.Drawing.Size(223, 101);
            this.txtAlmatTendik.TabIndex = 66;
            // 
            // rbPuan
            // 
            this.rbPuan.AutoSize = true;
            this.rbPuan.BackColor = System.Drawing.Color.Transparent;
            this.rbPuan.CheckedState.BorderColor = System.Drawing.Color.Lime;
            this.rbPuan.CheckedState.BorderThickness = 0;
            this.rbPuan.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.rbPuan.CheckedState.InnerColor = System.Drawing.Color.DarkGreen;
            this.rbPuan.CheckedState.InnerOffset = -4;
            this.rbPuan.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.rbPuan.ForeColor = System.Drawing.Color.White;
            this.rbPuan.Location = new System.Drawing.Point(356, 351);
            this.rbPuan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbPuan.Name = "rbPuan";
            this.rbPuan.Size = new System.Drawing.Size(104, 27);
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
            this.rbLaki.CheckedState.BorderColor = System.Drawing.Color.Lime;
            this.rbLaki.CheckedState.BorderThickness = 0;
            this.rbLaki.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.rbLaki.CheckedState.InnerColor = System.Drawing.Color.DarkGreen;
            this.rbLaki.CheckedState.InnerOffset = -4;
            this.rbLaki.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.rbLaki.ForeColor = System.Drawing.Color.White;
            this.rbLaki.Location = new System.Drawing.Point(258, 351);
            this.rbLaki.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbLaki.Name = "rbLaki";
            this.rbLaki.Size = new System.Drawing.Size(88, 27);
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
            this.tglLahirTendik.BorderRadius = 18;
            this.tglLahirTendik.Checked = true;
            this.tglLahirTendik.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.tglLahirTendik.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tglLahirTendik.ForeColor = System.Drawing.Color.White;
            this.tglLahirTendik.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tglLahirTendik.Location = new System.Drawing.Point(258, 292);
            this.tglLahirTendik.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tglLahirTendik.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tglLahirTendik.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tglLahirTendik.Name = "tglLahirTendik";
            this.tglLahirTendik.Size = new System.Drawing.Size(223, 38);
            this.tglLahirTendik.TabIndex = 63;
            this.tglLahirTendik.Value = new System.DateTime(2024, 6, 15, 22, 37, 28, 314);
            // 
            // txtPassTendik
            // 
            this.txtPassTendik.Animated = true;
            this.txtPassTendik.BackColor = System.Drawing.Color.Transparent;
            this.txtPassTendik.BorderColor = System.Drawing.Color.Black;
            this.txtPassTendik.BorderRadius = 13;
            this.txtPassTendik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassTendik.DefaultText = "";
            this.txtPassTendik.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassTendik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassTendik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassTendik.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassTendik.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassTendik.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassTendik.ForeColor = System.Drawing.Color.Black;
            this.txtPassTendik.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassTendik.Location = new System.Drawing.Point(589, 346);
            this.txtPassTendik.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPassTendik.Name = "txtPassTendik";
            this.txtPassTendik.PasswordChar = '\0';
            this.txtPassTendik.PlaceholderText = "";
            this.txtPassTendik.SelectedText = "";
            this.txtPassTendik.Size = new System.Drawing.Size(223, 36);
            this.txtPassTendik.TabIndex = 62;
            // 
            // userNmTendik
            // 
            this.userNmTendik.Animated = true;
            this.userNmTendik.BackColor = System.Drawing.Color.Transparent;
            this.userNmTendik.BorderColor = System.Drawing.Color.Black;
            this.userNmTendik.BorderRadius = 13;
            this.userNmTendik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNmTendik.DefaultText = "";
            this.userNmTendik.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userNmTendik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userNmTendik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNmTendik.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNmTendik.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNmTendik.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNmTendik.ForeColor = System.Drawing.Color.Black;
            this.userNmTendik.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNmTendik.Location = new System.Drawing.Point(589, 291);
            this.userNmTendik.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.userNmTendik.Name = "userNmTendik";
            this.userNmTendik.PasswordChar = '\0';
            this.userNmTendik.PlaceholderText = "";
            this.userNmTendik.SelectedText = "";
            this.userNmTendik.Size = new System.Drawing.Size(226, 31);
            this.userNmTendik.TabIndex = 61;
            // 
            // txtNamaTendik
            // 
            this.txtNamaTendik.Animated = true;
            this.txtNamaTendik.BackColor = System.Drawing.Color.Transparent;
            this.txtNamaTendik.BorderColor = System.Drawing.Color.Black;
            this.txtNamaTendik.BorderRadius = 13;
            this.txtNamaTendik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamaTendik.DefaultText = "";
            this.txtNamaTendik.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNamaTendik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNamaTendik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaTendik.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaTendik.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaTendik.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaTendik.ForeColor = System.Drawing.Color.Black;
            this.txtNamaTendik.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaTendik.Location = new System.Drawing.Point(258, 238);
            this.txtNamaTendik.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNamaTendik.Name = "txtNamaTendik";
            this.txtNamaTendik.PasswordChar = '\0';
            this.txtNamaTendik.PlaceholderText = "";
            this.txtNamaTendik.SelectedText = "";
            this.txtNamaTendik.Size = new System.Drawing.Size(223, 32);
            this.txtNamaTendik.TabIndex = 60;
            this.txtNamaTendik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamaTendik_KeyPress);
            // 
            // txtIDTendik
            // 
            this.txtIDTendik.Animated = true;
            this.txtIDTendik.BackColor = System.Drawing.Color.Transparent;
            this.txtIDTendik.BorderColor = System.Drawing.Color.Black;
            this.txtIDTendik.BorderRadius = 13;
            this.txtIDTendik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDTendik.DefaultText = "";
            this.txtIDTendik.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDTendik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDTendik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDTendik.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDTendik.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDTendik.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDTendik.ForeColor = System.Drawing.Color.Black;
            this.txtIDTendik.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDTendik.Location = new System.Drawing.Point(258, 183);
            this.txtIDTendik.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtIDTendik.Name = "txtIDTendik";
            this.txtIDTendik.PasswordChar = '\0';
            this.txtIDTendik.PlaceholderText = "";
            this.txtIDTendik.ReadOnly = true;
            this.txtIDTendik.SelectedText = "";
            this.txtIDTendik.Size = new System.Drawing.Size(223, 31);
            this.txtIDTendik.TabIndex = 59;
            // 
            // btnBatalTendik
            // 
            this.btnBatalTendik.AutoRoundedCorners = true;
            this.btnBatalTendik.BackColor = System.Drawing.Color.Transparent;
            this.btnBatalTendik.BorderRadius = 17;
            this.btnBatalTendik.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBatalTendik.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBatalTendik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBatalTendik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBatalTendik.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBatalTendik.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatalTendik.ForeColor = System.Drawing.Color.White;
            this.btnBatalTendik.Location = new System.Drawing.Point(628, 538);
            this.btnBatalTendik.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBatalTendik.Name = "btnBatalTendik";
            this.btnBatalTendik.Size = new System.Drawing.Size(136, 36);
            this.btnBatalTendik.TabIndex = 84;
            this.btnBatalTendik.Text = "Batal";
            this.btnBatalTendik.Click += new System.EventHandler(this.btnBatalTendik_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.AutoRoundedCorners = true;
            this.btnKembali.BackColor = System.Drawing.Color.Transparent;
            this.btnKembali.BorderRadius = 17;
            this.btnKembali.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKembali.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKembali.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKembali.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKembali.FillColor = System.Drawing.Color.White;
            this.btnKembali.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.ForeColor = System.Drawing.Color.Black;
            this.btnKembali.Location = new System.Drawing.Point(285, 538);
            this.btnKembali.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(135, 36);
            this.btnKembali.TabIndex = 87;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // DataTendik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJECT_PRG2.Properties.Resources.DESIGN_Tendik1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(925, 702);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnBatalTendik);
            this.Controls.Add(this.btnTambahTendik);
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
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DataTendik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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