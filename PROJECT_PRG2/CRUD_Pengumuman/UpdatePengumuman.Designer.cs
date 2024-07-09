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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePengumuman));
            this.cbIDTendik = new System.Windows.Forms.ComboBox();
            this.tenagaKependidikanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fINDSMART_MABRESDsAll = new PROJECT_PRG2.FINDSMART_MABRESDsAll();
            this.tenagaKependidikanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fINDSMARTDataSet7 = new PROJECT_PRG2.FINDSMARTDataSet7();
            this.pengumumanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDeskripsi = new Guna.UI2.WinForms.Guna2TextBox();
            this.tglPengumuman = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtPengumuman = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCariPM = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idPengumumanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTKNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pengumumanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pengumumanTableAdapter = new PROJECT_PRG2.FINDSMARTDataSet7TableAdapters.PengumumanTableAdapter();
            this.tenagaKependidikanTableAdapter = new PROJECT_PRG2.FINDSMARTDataSet7TableAdapters.TenagaKependidikanTableAdapter();
            this.btnCari_ = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHapusPM = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnUpPengumuman = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnTambahPengumuman = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDPM = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBatal = new Guna.UI2.WinForms.Guna2Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tooltipupdate = new System.Windows.Forms.ToolTip(this.components);
            this.tooltipHapus = new System.Windows.Forms.ToolTip(this.components);
            this.btnRefersh = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pengumumanTableAdapter1 = new PROJECT_PRG2.FINDSMART_MABRESDsAllTableAdapters.PengumumanTableAdapter();
            this.tenagaKependidikanTableAdapter1 = new PROJECT_PRG2.FINDSMART_MABRESDsAllTableAdapters.TenagaKependidikanTableAdapter();
            this.tTipRefreshPengumuman = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tenagaKependidikanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMART_MABRESDsAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenagaKependidikanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengumumanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengumumanBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbIDTendik
            // 
            this.cbIDTendik.DataSource = this.tenagaKependidikanBindingSource1;
            this.cbIDTendik.DisplayMember = "Nama";
            this.cbIDTendik.FormattingEnabled = true;
            this.cbIDTendik.ItemHeight = 13;
            this.cbIDTendik.Location = new System.Drawing.Point(886, 552);
            this.cbIDTendik.Margin = new System.Windows.Forms.Padding(2);
            this.cbIDTendik.Name = "cbIDTendik";
            this.cbIDTendik.Size = new System.Drawing.Size(220, 21);
            this.cbIDTendik.TabIndex = 131;
            this.cbIDTendik.ValueMember = "Id_TKN";
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
            // pengumumanBindingSource
            // 
            this.pengumumanBindingSource.DataMember = "Pengumuman";
            this.pengumumanBindingSource.DataSource = this.fINDSMARTDataSet7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(284, 626);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 126;
            this.label10.Text = "Nama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(585, 522);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 125;
            this.label7.Text = "Tanggal ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(898, 522);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 124;
            this.label5.Text = "Tendik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(585, 626);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 123;
            this.label4.Text = "Deskripsi";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(500, 607);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2);
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
            this.txtDeskripsi.Location = new System.Drawing.Point(569, 654);
            this.txtDeskripsi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.PasswordChar = '\0';
            this.txtDeskripsi.PlaceholderText = "";
            this.txtDeskripsi.SelectedText = "";
            this.txtDeskripsi.Size = new System.Drawing.Size(192, 81);
            this.txtDeskripsi.TabIndex = 117;
            // 
            // tglPengumuman
            // 
            this.tglPengumuman.Animated = true;
            this.tglPengumuman.AutoRoundedCorners = true;
            this.tglPengumuman.BackColor = System.Drawing.Color.Transparent;
            this.tglPengumuman.BorderRadius = 19;
            this.tglPengumuman.Checked = true;
            this.tglPengumuman.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.tglPengumuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tglPengumuman.ForeColor = System.Drawing.Color.White;
            this.tglPengumuman.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tglPengumuman.Location = new System.Drawing.Point(569, 551);
            this.tglPengumuman.Margin = new System.Windows.Forms.Padding(2);
            this.tglPengumuman.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tglPengumuman.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tglPengumuman.Name = "tglPengumuman";
            this.tglPengumuman.Size = new System.Drawing.Size(243, 41);
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
            this.txtPengumuman.Location = new System.Drawing.Point(271, 654);
            this.txtPengumuman.Margin = new System.Windows.Forms.Padding(4);
            this.txtPengumuman.Name = "txtPengumuman";
            this.txtPengumuman.PasswordChar = '\0';
            this.txtPengumuman.PlaceholderText = "";
            this.txtPengumuman.SelectedText = "";
            this.txtPengumuman.Size = new System.Drawing.Size(243, 41);
            this.txtPengumuman.TabIndex = 115;
            this.txtPengumuman.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPengumuman_KeyPress);
            // 
            // txtCariPM
            // 
            this.txtCariPM.Animated = true;
            this.txtCariPM.BackColor = System.Drawing.Color.Transparent;
            this.txtCariPM.BorderColor = System.Drawing.Color.Black;
            this.txtCariPM.BorderRadius = 10;
            this.txtCariPM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCariPM.DefaultText = "Cari Data Pengumuman";
            this.txtCariPM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCariPM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCariPM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCariPM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCariPM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCariPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCariPM.ForeColor = System.Drawing.Color.Gray;
            this.txtCariPM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCariPM.Location = new System.Drawing.Point(580, 39);
            this.txtCariPM.Margin = new System.Windows.Forms.Padding(4);
            this.txtCariPM.Name = "txtCariPM";
            this.txtCariPM.PasswordChar = '\0';
            this.txtCariPM.PlaceholderText = "";
            this.txtCariPM.SelectedText = "";
            this.txtCariPM.Size = new System.Drawing.Size(362, 36);
            this.txtCariPM.TabIndex = 114;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
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
            this.idTKNDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.pengumumanBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(57, 138);
            this.guna2DataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1247, 298);
            this.guna2DataGridView1.TabIndex = 133;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 18;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
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
            // idTKNDataGridViewTextBoxColumn
            // 
            this.idTKNDataGridViewTextBoxColumn.DataPropertyName = "Id_TKN";
            this.idTKNDataGridViewTextBoxColumn.HeaderText = "Id_TKN";
            this.idTKNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idTKNDataGridViewTextBoxColumn.Name = "idTKNDataGridViewTextBoxColumn";
            // 
            // pengumumanBindingSource1
            // 
            this.pengumumanBindingSource1.DataMember = "Pengumuman";
            this.pengumumanBindingSource1.DataSource = this.fINDSMART_MABRESDsAll;
            // 
            // pengumumanTableAdapter
            // 
            this.pengumumanTableAdapter.ClearBeforeFill = true;
            // 
            // tenagaKependidikanTableAdapter
            // 
            this.tenagaKependidikanTableAdapter.ClearBeforeFill = true;
            // 
            // btnCari_
            // 
            this.btnCari_.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCari_.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCari_.Image = global::PROJECT_PRG2.Properties.Resources.cari;
            this.btnCari_.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCari_.ImageRotate = 0F;
            this.btnCari_.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCari_.Location = new System.Drawing.Point(534, 36);
            this.btnCari_.Name = "btnCari_";
            this.btnCari_.PressedState.ImageRotate = 3F;
            this.btnCari_.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCari_.Size = new System.Drawing.Size(39, 39);
            this.btnCari_.TabIndex = 166;
            this.btnCari_.Click += new System.EventHandler(this.btnCari__Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(898, 626);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 175;
            this.label2.Text = "Aksi";
            // 
            // btnHapusPM
            // 
            this.btnHapusPM.BackColor = System.Drawing.Color.Transparent;
            this.btnHapusPM.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnHapusPM.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnHapusPM.Image = ((System.Drawing.Image)(resources.GetObject("btnHapusPM.Image")));
            this.btnHapusPM.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnHapusPM.ImageRotate = 0F;
            this.btnHapusPM.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHapusPM.Location = new System.Drawing.Point(1012, 659);
            this.btnHapusPM.Margin = new System.Windows.Forms.Padding(2);
            this.btnHapusPM.Name = "btnHapusPM";
            this.btnHapusPM.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnHapusPM.Size = new System.Drawing.Size(38, 39);
            this.btnHapusPM.TabIndex = 173;
            this.tooltipHapus.SetToolTip(this.btnHapusPM, "Hapus Data");
            this.btnHapusPM.UseTransparentBackground = true;
            this.btnHapusPM.Click += new System.EventHandler(this.btnHapusPM_Click);
            // 
            // btnUpPengumuman
            // 
            this.btnUpPengumuman.BackColor = System.Drawing.Color.Transparent;
            this.btnUpPengumuman.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnUpPengumuman.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnUpPengumuman.Image = ((System.Drawing.Image)(resources.GetObject("btnUpPengumuman.Image")));
            this.btnUpPengumuman.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnUpPengumuman.ImageRotate = 0F;
            this.btnUpPengumuman.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpPengumuman.Location = new System.Drawing.Point(951, 661);
            this.btnUpPengumuman.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpPengumuman.Name = "btnUpPengumuman";
            this.btnUpPengumuman.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnUpPengumuman.Size = new System.Drawing.Size(43, 32);
            this.btnUpPengumuman.TabIndex = 172;
            this.tooltipupdate.SetToolTip(this.btnUpPengumuman, "Perbarui Data");
            this.btnUpPengumuman.UseTransparentBackground = true;
            this.btnUpPengumuman.Click += new System.EventHandler(this.btnUpPengumuman_Click);
            // 
            // btnTambahPengumuman
            // 
            this.btnTambahPengumuman.BackColor = System.Drawing.Color.Transparent;
            this.btnTambahPengumuman.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnTambahPengumuman.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnTambahPengumuman.Image = ((System.Drawing.Image)(resources.GetObject("btnTambahPengumuman.Image")));
            this.btnTambahPengumuman.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnTambahPengumuman.ImageRotate = 0F;
            this.btnTambahPengumuman.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTambahPengumuman.Location = new System.Drawing.Point(906, 662);
            this.btnTambahPengumuman.Margin = new System.Windows.Forms.Padding(2);
            this.btnTambahPengumuman.Name = "btnTambahPengumuman";
            this.btnTambahPengumuman.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnTambahPengumuman.Size = new System.Drawing.Size(27, 32);
            this.btnTambahPengumuman.TabIndex = 171;
            this.toolTip1.SetToolTip(this.btnTambahPengumuman, "Tambah Data\r\n");
            this.btnTambahPengumuman.UseTransparentBackground = true;
            this.btnTambahPengumuman.Click += new System.EventHandler(this.btnTambahPengumuman_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox1.BorderRadius = 10;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(878, 659);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(192, 37);
            this.guna2TextBox1.TabIndex = 174;
            // 
            // txtIDPM
            // 
            this.txtIDPM.Animated = true;
            this.txtIDPM.BackColor = System.Drawing.Color.Transparent;
            this.txtIDPM.BorderColor = System.Drawing.Color.Black;
            this.txtIDPM.BorderRadius = 10;
            this.txtIDPM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDPM.DefaultText = "";
            this.txtIDPM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDPM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDPM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDPM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDPM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtIDPM.ForeColor = System.Drawing.Color.Black;
            this.txtIDPM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDPM.Location = new System.Drawing.Point(271, 551);
            this.txtIDPM.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDPM.Name = "txtIDPM";
            this.txtIDPM.PasswordChar = '\0';
            this.txtIDPM.PlaceholderText = "";
            this.txtIDPM.ReadOnly = true;
            this.txtIDPM.SelectedText = "";
            this.txtIDPM.Size = new System.Drawing.Size(243, 41);
            this.txtIDPM.TabIndex = 176;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 522);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 177;
            this.label1.Text = "ID Pengumuman";
            // 
            // btnBatal
            // 
            this.btnBatal.AutoRoundedCorners = true;
            this.btnBatal.BackColor = System.Drawing.Color.Transparent;
            this.btnBatal.BorderRadius = 13;
            this.btnBatal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBatal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBatal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBatal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(1196, 730);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(108, 28);
            this.btnBatal.TabIndex = 178;
            this.btnBatal.Text = "Batal";
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnRefersh
            // 
            this.btnRefersh.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnRefersh.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnRefersh.Image = global::PROJECT_PRG2.Properties.Resources.refresh_594822;
            this.btnRefersh.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnRefersh.ImageRotate = 0F;
            this.btnRefersh.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefersh.Location = new System.Drawing.Point(1259, 490);
            this.btnRefersh.Name = "btnRefersh";
            this.btnRefersh.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnRefersh.Size = new System.Drawing.Size(45, 51);
            this.btnRefersh.TabIndex = 250;
            this.tTipRefreshPengumuman.SetToolTip(this.btnRefersh, "Refresh Data");
            this.btnRefersh.Click += new System.EventHandler(this.btnRefersh_Click);
            // 
            // pengumumanTableAdapter1
            // 
            this.pengumumanTableAdapter1.ClearBeforeFill = true;
            // 
            // tenagaKependidikanTableAdapter1
            // 
            this.tenagaKependidikanTableAdapter1.ClearBeforeFill = true;
            // 
            // UpdatePengumuman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1376, 1033);
            this.Controls.Add(this.btnRefersh);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDPM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHapusPM);
            this.Controls.Add(this.btnUpPengumuman);
            this.Controls.Add(this.btnTambahPengumuman);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.btnCari_);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.cbIDTendik);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.tglPengumuman);
            this.Controls.Add(this.txtPengumuman);
            this.Controls.Add(this.txtCariPM);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdatePengumuman";
            this.Text = "UpdatePengumuman";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UpdatePengumuman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tenagaKependidikanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMART_MABRESDsAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenagaKependidikanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengumumanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengumumanBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbIDTendik;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtDeskripsi;
        private Guna.UI2.WinForms.Guna2DateTimePicker tglPengumuman;
        private Guna.UI2.WinForms.Guna2TextBox txtPengumuman;
        private Guna.UI2.WinForms.Guna2TextBox txtCariPM;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private FINDSMARTDataSet7 fINDSMARTDataSet7;
        private System.Windows.Forms.BindingSource pengumumanBindingSource;
        private FINDSMARTDataSet7TableAdapters.PengumumanTableAdapter pengumumanTableAdapter;
        private System.Windows.Forms.BindingSource tenagaKependidikanBindingSource;
        private FINDSMARTDataSet7TableAdapters.TenagaKependidikanTableAdapter tenagaKependidikanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPengumumanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTKNDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2ImageButton btnCari_;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton btnHapusPM;
        private Guna.UI2.WinForms.Guna2ImageButton btnUpPengumuman;
        private Guna.UI2.WinForms.Guna2ImageButton btnTambahPengumuman;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtIDPM;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnBatal;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip tooltipupdate;
        private System.Windows.Forms.ToolTip tooltipHapus;
        private Guna.UI2.WinForms.Guna2ImageButton btnRefersh;
        private FINDSMART_MABRESDsAll fINDSMART_MABRESDsAll;
        private System.Windows.Forms.BindingSource pengumumanBindingSource1;
        private FINDSMART_MABRESDsAllTableAdapters.PengumumanTableAdapter pengumumanTableAdapter1;
        private System.Windows.Forms.BindingSource tenagaKependidikanBindingSource1;
        private FINDSMART_MABRESDsAllTableAdapters.TenagaKependidikanTableAdapter tenagaKependidikanTableAdapter1;
        private System.Windows.Forms.ToolTip tTipRefreshPengumuman;
    }
}