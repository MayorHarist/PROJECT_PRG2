namespace PROJECT_PRG2.CRUD_Pengumuman
{
    partial class Pengumuman
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
            this.btnBatalPengumuman = new Guna.UI2.WinForms.Guna2Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDeskripsi = new Guna.UI2.WinForms.Guna2TextBox();
            this.tglPengumuman = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtPengumuman = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDPengumuman = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbIDTendik = new System.Windows.Forms.ComboBox();
            this.tenagaKependidikanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fINDSMARTDataSet7 = new PROJECT_PRG2.FINDSMARTDataSet7();
            this.btnTambahPengumuman = new Guna.UI2.WinForms.Guna2Button();
            this.btnKembali = new Guna.UI2.WinForms.Guna2Button();
            this.tenagaKependidikanTableAdapter = new PROJECT_PRG2.FINDSMARTDataSet7TableAdapters.TenagaKependidikanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tenagaKependidikanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBatalPengumuman
            // 
            this.btnBatalPengumuman.AutoRoundedCorners = true;
            this.btnBatalPengumuman.BackColor = System.Drawing.Color.Transparent;
            this.btnBatalPengumuman.BorderRadius = 17;
            this.btnBatalPengumuman.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBatalPengumuman.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBatalPengumuman.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBatalPengumuman.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBatalPengumuman.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.btnBatalPengumuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatalPengumuman.ForeColor = System.Drawing.Color.White;
            this.btnBatalPengumuman.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnBatalPengumuman.ImageOffset = new System.Drawing.Point(20, 20);
            this.btnBatalPengumuman.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBatalPengumuman.Location = new System.Drawing.Point(337, 458);
            this.btnBatalPengumuman.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBatalPengumuman.Name = "btnBatalPengumuman";
            this.btnBatalPengumuman.Size = new System.Drawing.Size(112, 36);
            this.btnBatalPengumuman.TabIndex = 111;
            this.btnBatalPengumuman.Text = "Batal";
            this.btnBatalPengumuman.Click += new System.EventHandler(this.btnBatalPengumuman_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(316, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 20);
            this.label11.TabIndex = 109;
            this.label11.Text = "DATA PENGUMUMAN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(228, 166);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 108;
            this.label10.Text = "Nama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(228, 202);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 105;
            this.label7.Text = "Tanggal ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(228, 326);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 103;
            this.label5.Text = "Tendik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 251);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 102;
            this.label4.Text = "Deskripsi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 99;
            this.label1.Text = "ID Pengumuman";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(260, 127);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel2.TabIndex = 98;
            this.guna2HtmlLabel2.Text = null;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(260, 127);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel1.TabIndex = 97;
            this.guna2HtmlLabel1.Text = null;
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Animated = true;
            this.txtDeskripsi.BackColor = System.Drawing.Color.Transparent;
            this.txtDeskripsi.BorderColor = System.Drawing.Color.Black;
            this.txtDeskripsi.BorderRadius = 10;
            this.txtDeskripsi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeskripsi.DefaultText = "";
            this.txtDeskripsi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDeskripsi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDeskripsi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeskripsi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeskripsi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeskripsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtDeskripsi.ForeColor = System.Drawing.Color.Black;
            this.txtDeskripsi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeskripsi.Location = new System.Drawing.Point(345, 251);
            this.txtDeskripsi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.PasswordChar = '\0';
            this.txtDeskripsi.PlaceholderText = "";
            this.txtDeskripsi.SelectedText = "";
            this.txtDeskripsi.Size = new System.Drawing.Size(191, 67);
            this.txtDeskripsi.TabIndex = 94;
            // 
            // tglPengumuman
            // 
            this.tglPengumuman.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
            this.tglPengumuman.Animated = true;
            this.tglPengumuman.AutoRoundedCorners = true;
            this.tglPengumuman.BackColor = System.Drawing.Color.Transparent;
            this.tglPengumuman.BorderRadius = 16;
            this.tglPengumuman.Checked = true;
            this.tglPengumuman.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tglPengumuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tglPengumuman.ForeColor = System.Drawing.Color.Black;
            this.tglPengumuman.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tglPengumuman.Location = new System.Drawing.Point(345, 202);
            this.tglPengumuman.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tglPengumuman.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tglPengumuman.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tglPengumuman.Name = "tglPengumuman";
            this.tglPengumuman.Size = new System.Drawing.Size(191, 34);
            this.tglPengumuman.TabIndex = 90;
            this.tglPengumuman.Value = new System.DateTime(2024, 6, 15, 22, 37, 28, 314);
            // 
            // txtPengumuman
            // 
            this.txtPengumuman.Animated = true;
            this.txtPengumuman.BackColor = System.Drawing.Color.Transparent;
            this.txtPengumuman.BorderColor = System.Drawing.Color.Black;
            this.txtPengumuman.BorderRadius = 10;
            this.txtPengumuman.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPengumuman.DefaultText = "";
            this.txtPengumuman.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPengumuman.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPengumuman.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPengumuman.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPengumuman.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPengumuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtPengumuman.ForeColor = System.Drawing.Color.Black;
            this.txtPengumuman.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPengumuman.Location = new System.Drawing.Point(345, 166);
            this.txtPengumuman.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPengumuman.Name = "txtPengumuman";
            this.txtPengumuman.PasswordChar = '\0';
            this.txtPengumuman.PlaceholderText = "";
            this.txtPengumuman.SelectedText = "";
            this.txtPengumuman.Size = new System.Drawing.Size(191, 31);
            this.txtPengumuman.TabIndex = 87;
            // 
            // txtIDPengumuman
            // 
            this.txtIDPengumuman.Animated = true;
            this.txtIDPengumuman.BackColor = System.Drawing.Color.Transparent;
            this.txtIDPengumuman.BorderColor = System.Drawing.Color.Black;
            this.txtIDPengumuman.BorderRadius = 10;
            this.txtIDPengumuman.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDPengumuman.DefaultText = "";
            this.txtIDPengumuman.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDPengumuman.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDPengumuman.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDPengumuman.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDPengumuman.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDPengumuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtIDPengumuman.ForeColor = System.Drawing.Color.Black;
            this.txtIDPengumuman.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDPengumuman.Location = new System.Drawing.Point(345, 127);
            this.txtIDPengumuman.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDPengumuman.Name = "txtIDPengumuman";
            this.txtIDPengumuman.PasswordChar = '\0';
            this.txtIDPengumuman.PlaceholderText = "";
            this.txtIDPengumuman.SelectedText = "";
            this.txtIDPengumuman.Size = new System.Drawing.Size(191, 31);
            this.txtIDPengumuman.TabIndex = 86;
            // 
            // cbIDTendik
            // 
            this.cbIDTendik.DataSource = this.tenagaKependidikanBindingSource;
            this.cbIDTendik.DisplayMember = "Nama";
            this.cbIDTendik.FormattingEnabled = true;
            this.cbIDTendik.ItemHeight = 13;
            this.cbIDTendik.Location = new System.Drawing.Point(347, 326);
            this.cbIDTendik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbIDTendik.Name = "cbIDTendik";
            this.cbIDTendik.Size = new System.Drawing.Size(192, 21);
            this.cbIDTendik.TabIndex = 113;
            this.cbIDTendik.ValueMember = "Id_TKN";
            // 
            // tenagaKependidikanBindingSource
            // 
            this.tenagaKependidikanBindingSource.DataMember = "TenagaKependidikan";
            this.tenagaKependidikanBindingSource.DataSource = this.fINDSMARTDataSet7;
            // 
            // fINDSMARTDataSet7
            // 
            this.fINDSMARTDataSet7.DataSetName = "FINDSMARTDataSet7";
            this.fINDSMARTDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTambahPengumuman
            // 
            this.btnTambahPengumuman.AutoRoundedCorners = true;
            this.btnTambahPengumuman.BackColor = System.Drawing.Color.Transparent;
            this.btnTambahPengumuman.BorderRadius = 17;
            this.btnTambahPengumuman.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTambahPengumuman.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTambahPengumuman.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTambahPengumuman.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTambahPengumuman.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.btnTambahPengumuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahPengumuman.ForeColor = System.Drawing.Color.White;
            this.btnTambahPengumuman.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTambahPengumuman.ImageOffset = new System.Drawing.Point(20, 20);
            this.btnTambahPengumuman.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTambahPengumuman.Location = new System.Drawing.Point(176, 458);
            this.btnTambahPengumuman.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTambahPengumuman.Name = "btnTambahPengumuman";
            this.btnTambahPengumuman.Size = new System.Drawing.Size(112, 36);
            this.btnTambahPengumuman.TabIndex = 114;
            this.btnTambahPengumuman.Text = "Tambah";
            this.btnTambahPengumuman.Click += new System.EventHandler(this.btnTambahPengumuman_Click);
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
            this.btnKembali.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.btnKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.ForeColor = System.Drawing.Color.White;
            this.btnKembali.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnKembali.ImageOffset = new System.Drawing.Point(20, 20);
            this.btnKembali.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKembali.Location = new System.Drawing.Point(504, 458);
            this.btnKembali.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(112, 36);
            this.btnKembali.TabIndex = 115;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // tenagaKependidikanTableAdapter
            // 
            this.tenagaKependidikanTableAdapter.ClearBeforeFill = true;
            // 
            // Pengumuman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 775);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnTambahPengumuman);
            this.Controls.Add(this.cbIDTendik);
            this.Controls.Add(this.btnBatalPengumuman);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.tglPengumuman);
            this.Controls.Add(this.txtPengumuman);
            this.Controls.Add(this.txtIDPengumuman);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pengumuman";
            this.Text = "Pengumuman";
            this.Load += new System.EventHandler(this.Pengumuman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tenagaKependidikanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnBatalPengumuman;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtDeskripsi;
        private Guna.UI2.WinForms.Guna2DateTimePicker tglPengumuman;
        private Guna.UI2.WinForms.Guna2TextBox txtPengumuman;
        private Guna.UI2.WinForms.Guna2TextBox txtIDPengumuman;
        private System.Windows.Forms.ComboBox cbIDTendik;
        private Guna.UI2.WinForms.Guna2Button btnTambahPengumuman;
        private Guna.UI2.WinForms.Guna2Button btnKembali;
        private FINDSMARTDataSet7 fINDSMARTDataSet7;
        private System.Windows.Forms.BindingSource tenagaKependidikanBindingSource;
        private FINDSMARTDataSet7TableAdapters.TenagaKependidikanTableAdapter tenagaKependidikanTableAdapter;
    }
}