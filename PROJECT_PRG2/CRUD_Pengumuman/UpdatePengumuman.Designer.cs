namespace PROJECT_PRG2.CRUD_Pengumuman
{
    partial class UpdatePengumuman
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
            this.cbIDTendik = new System.Windows.Forms.ComboBox();
            this.btnHapusPengumuman = new Guna.UI2.WinForms.Guna2Button();
            this.btnTambah = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdatePengumuman = new Guna.UI2.WinForms.Guna2Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDeskripsi = new Guna.UI2.WinForms.Guna2TextBox();
            this.tglPengumuman = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtPengumuman = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDPengumuman = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCari = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idPengumumanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTKNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pengumumanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fINDSMARTDataSet7 = new PROJECT_PRG2.FINDSMARTDataSet7();
            this.pengumumanTableAdapter = new PROJECT_PRG2.FINDSMARTDataSet7TableAdapters.PengumumanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengumumanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // cbIDTendik
            // 
            this.cbIDTendik.DataSource = this.pengumumanBindingSource;
            this.cbIDTendik.DisplayMember = "Nama";
            this.cbIDTendik.FormattingEnabled = true;
            this.cbIDTendik.ItemHeight = 16;
            this.cbIDTendik.Location = new System.Drawing.Point(752, 578);
            this.cbIDTendik.Name = "cbIDTendik";
            this.cbIDTendik.Size = new System.Drawing.Size(255, 24);
            this.cbIDTendik.TabIndex = 131;
            this.cbIDTendik.ValueMember = "No_Pegawai";
            // 
            // btnHapusPengumuman
            // 
            this.btnHapusPengumuman.AutoRoundedCorners = true;
            this.btnHapusPengumuman.BorderRadius = 21;
            this.btnHapusPengumuman.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHapusPengumuman.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHapusPengumuman.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHapusPengumuman.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHapusPengumuman.FillColor = System.Drawing.Color.HotPink;
            this.btnHapusPengumuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapusPengumuman.ForeColor = System.Drawing.Color.White;
            this.btnHapusPengumuman.Location = new System.Drawing.Point(853, 674);
            this.btnHapusPengumuman.Name = "btnHapusPengumuman";
            this.btnHapusPengumuman.Size = new System.Drawing.Size(149, 44);
            this.btnHapusPengumuman.TabIndex = 130;
            this.btnHapusPengumuman.Text = "Hapus";
            // 
            // btnTambah
            // 
            this.btnTambah.AutoRoundedCorners = true;
            this.btnTambah.BorderRadius = 21;
            this.btnTambah.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTambah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTambah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTambah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTambah.FillColor = System.Drawing.Color.HotPink;
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(548, 674);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(149, 44);
            this.btnTambah.TabIndex = 129;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnUpdatePengumuman
            // 
            this.btnUpdatePengumuman.AutoRoundedCorners = true;
            this.btnUpdatePengumuman.BorderRadius = 21;
            this.btnUpdatePengumuman.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdatePengumuman.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdatePengumuman.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdatePengumuman.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdatePengumuman.FillColor = System.Drawing.Color.HotPink;
            this.btnUpdatePengumuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePengumuman.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePengumuman.Location = new System.Drawing.Point(368, 674);
            this.btnUpdatePengumuman.Name = "btnUpdatePengumuman";
            this.btnUpdatePengumuman.Size = new System.Drawing.Size(149, 44);
            this.btnUpdatePengumuman.TabIndex = 128;
            this.btnUpdatePengumuman.Text = "Perbarui";
            this.btnUpdatePengumuman.Click += new System.EventHandler(this.btnUpdatePengumuman_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(188, 484);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 18);
            this.label10.TabIndex = 126;
            this.label10.Text = "Nama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(188, 530);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 125;
            this.label7.Text = "Tanggal ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(650, 578);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 124;
            this.label5.Text = "Tendik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(650, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 123;
            this.label4.Text = "Deskripsi";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(254, 484);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel1.TabIndex = 119;
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
            this.txtDeskripsi.Location = new System.Drawing.Point(749, 486);
            this.txtDeskripsi.Margin = new System.Windows.Forms.Padding(5);
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.PasswordChar = '\0';
            this.txtDeskripsi.PlaceholderText = "";
            this.txtDeskripsi.SelectedText = "";
            this.txtDeskripsi.Size = new System.Drawing.Size(255, 83);
            this.txtDeskripsi.TabIndex = 117;
            // 
            // tglPengumuman
            // 
            this.tglPengumuman.Animated = true;
            this.tglPengumuman.AutoRoundedCorners = true;
            this.tglPengumuman.BackColor = System.Drawing.Color.Transparent;
            this.tglPengumuman.BorderRadius = 19;
            this.tglPengumuman.Checked = true;
            this.tglPengumuman.FillColor = System.Drawing.Color.HotPink;
            this.tglPengumuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tglPengumuman.ForeColor = System.Drawing.Color.Black;
            this.tglPengumuman.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tglPengumuman.Location = new System.Drawing.Point(343, 530);
            this.tglPengumuman.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tglPengumuman.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tglPengumuman.Name = "tglPengumuman";
            this.tglPengumuman.Size = new System.Drawing.Size(255, 41);
            this.tglPengumuman.TabIndex = 116;
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
            this.txtPengumuman.Location = new System.Drawing.Point(343, 484);
            this.txtPengumuman.Margin = new System.Windows.Forms.Padding(5);
            this.txtPengumuman.Name = "txtPengumuman";
            this.txtPengumuman.PasswordChar = '\0';
            this.txtPengumuman.PlaceholderText = "";
            this.txtPengumuman.SelectedText = "";
            this.txtPengumuman.Size = new System.Drawing.Size(255, 39);
            this.txtPengumuman.TabIndex = 115;
            this.txtPengumuman.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPengumuman_KeyPress);
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
            this.txtIDPengumuman.Location = new System.Drawing.Point(495, 43);
            this.txtIDPengumuman.Margin = new System.Windows.Forms.Padding(5);
            this.txtIDPengumuman.Name = "txtIDPengumuman";
            this.txtIDPengumuman.PasswordChar = '\0';
            this.txtIDPengumuman.PlaceholderText = "";
            this.txtIDPengumuman.SelectedText = "";
            this.txtIDPengumuman.Size = new System.Drawing.Size(286, 39);
            this.txtIDPengumuman.TabIndex = 114;
            // 
            // btnCari
            // 
            this.btnCari.AutoRoundedCorners = true;
            this.btnCari.BorderRadius = 21;
            this.btnCari.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCari.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCari.FillColor = System.Drawing.Color.HotPink;
            this.btnCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.Location = new System.Drawing.Point(390, 38);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(97, 44);
            this.btnCari.TabIndex = 132;
            this.btnCari.Text = "Cari";
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 18;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPengumumanDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn,
            this.deskripsiDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.idTKNDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.pengumumanBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(182, 125);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(914, 205);
            this.guna2DataGridView1.TabIndex = 133;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 18;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // idPengumumanDataGridViewTextBoxColumn
            // 
            this.idPengumumanDataGridViewTextBoxColumn.DataPropertyName = "Id_Pengumuman";
            this.idPengumumanDataGridViewTextBoxColumn.HeaderText = "Id_Pengumuman";
            this.idPengumumanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPengumumanDataGridViewTextBoxColumn.Name = "idPengumumanDataGridViewTextBoxColumn";
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // tanggalDataGridViewTextBoxColumn
            // 
            this.tanggalDataGridViewTextBoxColumn.DataPropertyName = "Tanggal";
            this.tanggalDataGridViewTextBoxColumn.HeaderText = "Tanggal";
            this.tanggalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggalDataGridViewTextBoxColumn.Name = "tanggalDataGridViewTextBoxColumn";
            // 
            // deskripsiDataGridViewTextBoxColumn
            // 
            this.deskripsiDataGridViewTextBoxColumn.DataPropertyName = "Deskripsi";
            this.deskripsiDataGridViewTextBoxColumn.HeaderText = "Deskripsi";
            this.deskripsiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deskripsiDataGridViewTextBoxColumn.Name = "deskripsiDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // idTKNDataGridViewTextBoxColumn
            // 
            this.idTKNDataGridViewTextBoxColumn.DataPropertyName = "Id_TKN";
            this.idTKNDataGridViewTextBoxColumn.HeaderText = "Id_TKN";
            this.idTKNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idTKNDataGridViewTextBoxColumn.Name = "idTKNDataGridViewTextBoxColumn";
            // 
            // pengumumanBindingSource
            // 
            this.pengumumanBindingSource.DataMember = "Pengumuman";
            this.pengumumanBindingSource.DataSource = this.fINDSMARTDataSet7;
            // 
            // fINDSMARTDataSet7
            // 
            this.fINDSMARTDataSet7.DataSetName = "FINDSMARTDataSet7";
            this.fINDSMARTDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pengumumanTableAdapter
            // 
            this.pengumumanTableAdapter.ClearBeforeFill = true;
            // 
            // UpdatePengumuman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 1016);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.cbIDTendik);
            this.Controls.Add(this.btnHapusPengumuman);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnUpdatePengumuman);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.tglPengumuman);
            this.Controls.Add(this.txtPengumuman);
            this.Controls.Add(this.txtIDPengumuman);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdatePengumuman";
            this.Text = "UpdatePengumuman";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UpdatePengumuman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengumumanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbIDTendik;
        private Guna.UI2.WinForms.Guna2Button btnHapusPengumuman;
        private Guna.UI2.WinForms.Guna2Button btnTambah;
        private Guna.UI2.WinForms.Guna2Button btnUpdatePengumuman;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtDeskripsi;
        private Guna.UI2.WinForms.Guna2DateTimePicker tglPengumuman;
        private Guna.UI2.WinForms.Guna2TextBox txtPengumuman;
        private Guna.UI2.WinForms.Guna2TextBox txtIDPengumuman;
        private Guna.UI2.WinForms.Guna2Button btnCari;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private FINDSMARTDataSet7 fINDSMARTDataSet7;
        private System.Windows.Forms.BindingSource pengumumanBindingSource;
        private FINDSMARTDataSet7TableAdapters.PengumumanTableAdapter pengumumanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPengumumanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTKNDataGridViewTextBoxColumn;
    }
}