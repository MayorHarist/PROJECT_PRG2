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
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDeskripsi = new Guna.UI2.WinForms.Guna2TextBox();
            this.tglPengumuman = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtPengumuman = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDPengumuman = new Guna.UI2.WinForms.Guna2TextBox();
            this.fINDSMART_MABRESDataSet1 = new PROJECT_PRG2.FINDSMART_MABRESDataSet1();
            this.tenagaKependidikanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fINDSMART_MABRESDsAll = new PROJECT_PRG2.FINDSMART_MABRESDsAll();
            this.tenagaKependidikanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fINDSMARTDataSet7 = new PROJECT_PRG2.FINDSMARTDataSet7();
            this.btnTambahPengumuman = new Guna.UI2.WinForms.Guna2Button();
            this.btnKembali = new Guna.UI2.WinForms.Guna2Button();
            this.tenagaKependidikanTableAdapter = new PROJECT_PRG2.FINDSMARTDataSet7TableAdapters.TenagaKependidikanTableAdapter();
            this.tenagaKependidikanTableAdapter1 = new PROJECT_PRG2.FINDSMART_MABRESDsAllTableAdapters.TenagaKependidikanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMART_MABRESDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenagaKependidikanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMART_MABRESDsAll)).BeginInit();
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
            this.btnBatalPengumuman.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBatalPengumuman.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatalPengumuman.ForeColor = System.Drawing.Color.White;
            this.btnBatalPengumuman.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnBatalPengumuman.ImageOffset = new System.Drawing.Point(20, 20);
            this.btnBatalPengumuman.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBatalPengumuman.Location = new System.Drawing.Point(489, 560);
            this.btnBatalPengumuman.Margin = new System.Windows.Forms.Padding(2);
            this.btnBatalPengumuman.Name = "btnBatalPengumuman";
            this.btnBatalPengumuman.Size = new System.Drawing.Size(112, 36);
            this.btnBatalPengumuman.TabIndex = 111;
            this.btnBatalPengumuman.Text = "Batal";
            this.btnBatalPengumuman.Click += new System.EventHandler(this.btnBatalPengumuman_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(168, 256);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 28);
            this.label10.TabIndex = 108;
            this.label10.Text = "Nama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(168, 292);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 28);
            this.label7.TabIndex = 105;
            this.label7.Text = "Tanggal ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(168, 341);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 28);
            this.label4.TabIndex = 102;
            this.label4.Text = "Deskripsi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(168, 217);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 99;
            this.label1.Text = "ID Pengumuman";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(266, 217);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(2);
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
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(266, 217);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2);
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
            this.txtDeskripsi.BorderRadius = 13;
            this.txtDeskripsi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeskripsi.DefaultText = "";
            this.txtDeskripsi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDeskripsi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDeskripsi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeskripsi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeskripsi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeskripsi.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeskripsi.ForeColor = System.Drawing.Color.Black;
            this.txtDeskripsi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeskripsi.Location = new System.Drawing.Point(351, 341);
            this.txtDeskripsi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.PasswordChar = '\0';
            this.txtDeskripsi.PlaceholderText = "";
            this.txtDeskripsi.SelectedText = "";
            this.txtDeskripsi.Size = new System.Drawing.Size(191, 93);
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
            this.tglPengumuman.Location = new System.Drawing.Point(351, 292);
            this.tglPengumuman.Margin = new System.Windows.Forms.Padding(2);
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
            this.txtPengumuman.BorderRadius = 13;
            this.txtPengumuman.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPengumuman.DefaultText = "";
            this.txtPengumuman.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPengumuman.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPengumuman.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPengumuman.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPengumuman.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPengumuman.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPengumuman.ForeColor = System.Drawing.Color.Black;
            this.txtPengumuman.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPengumuman.Location = new System.Drawing.Point(351, 256);
            this.txtPengumuman.Margin = new System.Windows.Forms.Padding(4);
            this.txtPengumuman.Name = "txtPengumuman";
            this.txtPengumuman.PasswordChar = '\0';
            this.txtPengumuman.PlaceholderText = "";
            this.txtPengumuman.SelectedText = "";
            this.txtPengumuman.Size = new System.Drawing.Size(191, 31);
            this.txtPengumuman.TabIndex = 87;
            this.txtPengumuman.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPengumuman_KeyPress);
            // 
            // txtIDPengumuman
            // 
            this.txtIDPengumuman.Animated = true;
            this.txtIDPengumuman.BackColor = System.Drawing.Color.Transparent;
            this.txtIDPengumuman.BorderColor = System.Drawing.Color.Black;
            this.txtIDPengumuman.BorderRadius = 13;
            this.txtIDPengumuman.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDPengumuman.DefaultText = "";
            this.txtIDPengumuman.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDPengumuman.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDPengumuman.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDPengumuman.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDPengumuman.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDPengumuman.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPengumuman.ForeColor = System.Drawing.Color.Black;
            this.txtIDPengumuman.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDPengumuman.Location = new System.Drawing.Point(351, 217);
            this.txtIDPengumuman.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDPengumuman.Name = "txtIDPengumuman";
            this.txtIDPengumuman.PasswordChar = '\0';
            this.txtIDPengumuman.PlaceholderText = "";
            this.txtIDPengumuman.ReadOnly = true;
            this.txtIDPengumuman.SelectedText = "";
            this.txtIDPengumuman.Size = new System.Drawing.Size(191, 31);
            this.txtIDPengumuman.TabIndex = 86;
            // 
            // fINDSMART_MABRESDataSet1
            // 
            this.fINDSMART_MABRESDataSet1.DataSetName = "FINDSMART_MABRESDataSet1";
            this.fINDSMART_MABRESDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tenagaKependidikanBindingSource1
            // 
            this.tenagaKependidikanBindingSource1.DataMember = "TenagaKependidikan";
            this.tenagaKependidikanBindingSource1.DataSource = this.fINDSMART_MABRESDsAll;
            // 
            // fINDSMART_MABRESDsAll
            // 
            this.fINDSMART_MABRESDsAll.DataSetName = "FINDSMART_MABRESDsAll";
            this.fINDSMART_MABRESDsAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnTambahPengumuman.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTambahPengumuman.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahPengumuman.ForeColor = System.Drawing.Color.White;
            this.btnTambahPengumuman.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTambahPengumuman.ImageOffset = new System.Drawing.Point(20, 20);
            this.btnTambahPengumuman.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTambahPengumuman.Location = new System.Drawing.Point(328, 560);
            this.btnTambahPengumuman.Margin = new System.Windows.Forms.Padding(2);
            this.btnTambahPengumuman.Name = "btnTambahPengumuman";
            this.btnTambahPengumuman.Size = new System.Drawing.Size(112, 36);
            this.btnTambahPengumuman.TabIndex = 114;
            this.btnTambahPengumuman.Text = "Simpan";
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
            this.btnKembali.FillColor = System.Drawing.Color.White;
            this.btnKembali.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.ForeColor = System.Drawing.Color.Black;
            this.btnKembali.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnKembali.ImageOffset = new System.Drawing.Point(20, 20);
            this.btnKembali.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKembali.Location = new System.Drawing.Point(172, 560);
            this.btnKembali.Margin = new System.Windows.Forms.Padding(2);
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
            // tenagaKependidikanTableAdapter1
            // 
            this.tenagaKependidikanTableAdapter1.ClearBeforeFill = true;
            // 
            // Pengumuman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJECT_PRG2.Properties.Resources.DESIGN_Pengumuman;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 775);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnTambahPengumuman);
            this.Controls.Add(this.btnBatalPengumuman);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.tglPengumuman);
            this.Controls.Add(this.txtPengumuman);
            this.Controls.Add(this.txtIDPengumuman);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pengumuman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pengumuman";
            this.Load += new System.EventHandler(this.Pengumuman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMART_MABRESDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenagaKependidikanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMART_MABRESDsAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenagaKependidikanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnBatalPengumuman;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtDeskripsi;
        private Guna.UI2.WinForms.Guna2DateTimePicker tglPengumuman;
        private Guna.UI2.WinForms.Guna2TextBox txtPengumuman;
        private Guna.UI2.WinForms.Guna2TextBox txtIDPengumuman;
        private Guna.UI2.WinForms.Guna2Button btnTambahPengumuman;
        private Guna.UI2.WinForms.Guna2Button btnKembali;
        private FINDSMARTDataSet7 fINDSMARTDataSet7;
        private System.Windows.Forms.BindingSource tenagaKependidikanBindingSource;
        private FINDSMARTDataSet7TableAdapters.TenagaKependidikanTableAdapter tenagaKependidikanTableAdapter;
        private FINDSMART_MABRESDsAll fINDSMART_MABRESDsAll;
        private System.Windows.Forms.BindingSource tenagaKependidikanBindingSource1;
        private FINDSMART_MABRESDsAllTableAdapters.TenagaKependidikanTableAdapter tenagaKependidikanTableAdapter1;
        private FINDSMART_MABRESDataSet1 fINDSMART_MABRESDataSet1;
    }
}