namespace PROJECT_PRG2.CRUD_JenisPrestasi
{
    partial class UDJepres
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UDJepres));
            this.txtCari = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idJenisPrestasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penyelenggaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisPrestasiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fINDSMART_MABRESDataSet1 = new PROJECT_PRG2.FINDSMART_MABRESDataSet1();
            this.jenisPrestasiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fINDSMART_MABRESDsAll = new PROJECT_PRG2.FINDSMART_MABRESDsAll();
            this.jenisPrestasiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fINDSMARTDataSet7 = new PROJECT_PRG2.FINDSMARTDataSet7();
            this.btnBatal = new Guna.UI2.WinForms.Guna2Button();
            this.txtPoint = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPenyelenggara = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPeran = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdJenisPrestasi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCari = new Guna.UI2.WinForms.Guna2Button();
            this.jenisPrestasiTableAdapter1 = new PROJECT_PRG2.FINDSMARTDataSet7TableAdapters.JenisPrestasiTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHapusJP = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnUpdateJP = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnTambahJP = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRefersh = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.jenisPrestasiTableAdapter = new PROJECT_PRG2.FINDSMART_MABRESDsAllTableAdapters.JenisPrestasiTableAdapter();
            this.jenisPrestasiTableAdapter2 = new PROJECT_PRG2.FINDSMART_MABRESDataSet1TableAdapters.JenisPrestasiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisPrestasiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMART_MABRESDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisPrestasiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMART_MABRESDsAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisPrestasiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCari
            // 
            this.txtCari.AutoRoundedCorners = true;
            this.txtCari.BackColor = System.Drawing.Color.Transparent;
            this.txtCari.BorderColor = System.Drawing.Color.Black;
            this.txtCari.BorderRadius = 17;
            this.txtCari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCari.DefaultText = "Cari Data Jenis Prestasi";
            this.txtCari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCari.ForeColor = System.Drawing.Color.Gray;
            this.txtCari.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.Location = new System.Drawing.Point(528, 30);
            this.txtCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCari.Name = "txtCari";
            this.txtCari.PasswordChar = '\0';
            this.txtCari.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtCari.PlaceholderText = "";
            this.txtCari.SelectedText = "";
            this.txtCari.Size = new System.Drawing.Size(362, 36);
            this.txtCari.TabIndex = 0;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 30;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idJenisPrestasiDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.peranDataGridViewTextBoxColumn,
            this.penyelenggaraDataGridViewTextBoxColumn,
            this.pointDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.jenisPrestasiBindingSource2;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(53, 121);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 62;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1268, 322);
            this.guna2DataGridView1.TabIndex = 1;
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
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 30;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // idJenisPrestasiDataGridViewTextBoxColumn
            // 
            this.idJenisPrestasiDataGridViewTextBoxColumn.DataPropertyName = "Id_JenisPrestasi";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idJenisPrestasiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.idJenisPrestasiDataGridViewTextBoxColumn.HeaderText = "ID Jenis Prestasi";
            this.idJenisPrestasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idJenisPrestasiDataGridViewTextBoxColumn.Name = "idJenisPrestasiDataGridViewTextBoxColumn";
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // peranDataGridViewTextBoxColumn
            // 
            this.peranDataGridViewTextBoxColumn.DataPropertyName = "Peran";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peranDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.peranDataGridViewTextBoxColumn.HeaderText = "Peran";
            this.peranDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.peranDataGridViewTextBoxColumn.Name = "peranDataGridViewTextBoxColumn";
            // 
            // penyelenggaraDataGridViewTextBoxColumn
            // 
            this.penyelenggaraDataGridViewTextBoxColumn.DataPropertyName = "Penyelenggara";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penyelenggaraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.penyelenggaraDataGridViewTextBoxColumn.HeaderText = "Penyelenggara";
            this.penyelenggaraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.penyelenggaraDataGridViewTextBoxColumn.Name = "penyelenggaraDataGridViewTextBoxColumn";
            // 
            // pointDataGridViewTextBoxColumn
            // 
            this.pointDataGridViewTextBoxColumn.DataPropertyName = "Point";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.pointDataGridViewTextBoxColumn.HeaderText = "Point";
            this.pointDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pointDataGridViewTextBoxColumn.Name = "pointDataGridViewTextBoxColumn";
            // 
            // jenisPrestasiBindingSource2
            // 
            this.jenisPrestasiBindingSource2.DataMember = "JenisPrestasi";
            this.jenisPrestasiBindingSource2.DataSource = this.fINDSMART_MABRESDataSet1;
            // 
            // fINDSMART_MABRESDataSet1
            // 
            this.fINDSMART_MABRESDataSet1.DataSetName = "FINDSMART_MABRESDataSet1";
            this.fINDSMART_MABRESDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jenisPrestasiBindingSource
            // 
            this.jenisPrestasiBindingSource.DataMember = "JenisPrestasi";
            this.jenisPrestasiBindingSource.DataSource = this.fINDSMART_MABRESDsAll;
            // 
            // fINDSMART_MABRESDsAll
            // 
            this.fINDSMART_MABRESDsAll.DataSetName = "FINDSMART_MABRESDsAll";
            this.fINDSMART_MABRESDsAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jenisPrestasiBindingSource1
            // 
            this.jenisPrestasiBindingSource1.DataMember = "JenisPrestasi";
            this.jenisPrestasiBindingSource1.DataSource = this.fINDSMARTDataSet7;
            // 
            // fINDSMARTDataSet7
            // 
            this.fINDSMARTDataSet7.DataSetName = "FINDSMARTDataSet7";
            this.fINDSMARTDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnBatal.Location = new System.Drawing.Point(1213, 663);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(108, 28);
            this.btnBatal.TabIndex = 27;
            this.btnBatal.Text = "Batal";
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // txtPoint
            // 
            this.txtPoint.AutoRoundedCorners = true;
            this.txtPoint.BackColor = System.Drawing.Color.Transparent;
            this.txtPoint.BorderRadius = 19;
            this.txtPoint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPoint.DefaultText = "";
            this.txtPoint.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPoint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPoint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPoint.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPoint.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPoint.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoint.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPoint.Location = new System.Drawing.Point(887, 547);
            this.txtPoint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.PasswordChar = '\0';
            this.txtPoint.PlaceholderText = "";
            this.txtPoint.SelectedText = "";
            this.txtPoint.Size = new System.Drawing.Size(243, 41);
            this.txtPoint.TabIndex = 25;
            this.txtPoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPoint_KeyPress);
            // 
            // txtPenyelenggara
            // 
            this.txtPenyelenggara.AutoRoundedCorners = true;
            this.txtPenyelenggara.BackColor = System.Drawing.Color.Transparent;
            this.txtPenyelenggara.BorderRadius = 19;
            this.txtPenyelenggara.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPenyelenggara.DefaultText = "";
            this.txtPenyelenggara.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPenyelenggara.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPenyelenggara.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPenyelenggara.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPenyelenggara.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPenyelenggara.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenyelenggara.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPenyelenggara.Location = new System.Drawing.Point(554, 650);
            this.txtPenyelenggara.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPenyelenggara.Name = "txtPenyelenggara";
            this.txtPenyelenggara.PasswordChar = '\0';
            this.txtPenyelenggara.PlaceholderText = "";
            this.txtPenyelenggara.SelectedText = "";
            this.txtPenyelenggara.Size = new System.Drawing.Size(243, 41);
            this.txtPenyelenggara.TabIndex = 24;
            // 
            // txtPeran
            // 
            this.txtPeran.AutoRoundedCorners = true;
            this.txtPeran.BackColor = System.Drawing.Color.Transparent;
            this.txtPeran.BorderRadius = 19;
            this.txtPeran.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPeran.DefaultText = "";
            this.txtPeran.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPeran.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPeran.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPeran.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPeran.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPeran.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeran.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPeran.Location = new System.Drawing.Point(553, 547);
            this.txtPeran.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPeran.Name = "txtPeran";
            this.txtPeran.PasswordChar = '\0';
            this.txtPeran.PlaceholderText = "";
            this.txtPeran.SelectedText = "";
            this.txtPeran.Size = new System.Drawing.Size(243, 41);
            this.txtPeran.TabIndex = 23;
            // 
            // txtNama
            // 
            this.txtNama.AutoRoundedCorners = true;
            this.txtNama.BackColor = System.Drawing.Color.Transparent;
            this.txtNama.BorderColor = System.Drawing.Color.Black;
            this.txtNama.BorderRadius = 19;
            this.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNama.DefaultText = "";
            this.txtNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.Font = new System.Drawing.Font("Poppins", 9F);
            this.txtNama.ForeColor = System.Drawing.Color.Black;
            this.txtNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.Location = new System.Drawing.Point(247, 650);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNama.Name = "txtNama";
            this.txtNama.PasswordChar = '\0';
            this.txtNama.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtNama.PlaceholderText = "";
            this.txtNama.SelectedText = "";
            this.txtNama.Size = new System.Drawing.Size(243, 41);
            this.txtNama.TabIndex = 22;
            this.txtNama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNama_KeyPress);
            // 
            // txtIdJenisPrestasi
            // 
            this.txtIdJenisPrestasi.AutoRoundedCorners = true;
            this.txtIdJenisPrestasi.BackColor = System.Drawing.Color.Transparent;
            this.txtIdJenisPrestasi.BorderColor = System.Drawing.Color.Black;
            this.txtIdJenisPrestasi.BorderRadius = 19;
            this.txtIdJenisPrestasi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdJenisPrestasi.DefaultText = "";
            this.txtIdJenisPrestasi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdJenisPrestasi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdJenisPrestasi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdJenisPrestasi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdJenisPrestasi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdJenisPrestasi.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdJenisPrestasi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdJenisPrestasi.Location = new System.Drawing.Point(247, 547);
            this.txtIdJenisPrestasi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdJenisPrestasi.Name = "txtIdJenisPrestasi";
            this.txtIdJenisPrestasi.PasswordChar = '\0';
            this.txtIdJenisPrestasi.PlaceholderText = "";
            this.txtIdJenisPrestasi.ReadOnly = true;
            this.txtIdJenisPrestasi.SelectedText = "";
            this.txtIdJenisPrestasi.Size = new System.Drawing.Size(243, 41);
            this.txtIdJenisPrestasi.TabIndex = 21;
            this.txtIdJenisPrestasi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdJenisPrestasi_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(906, 514);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Point";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(569, 617);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "Penyelenggara";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(569, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "Peran";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 617);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID Jenis Prestasi";
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.Transparent;
            this.btnCari.BackgroundImage = global::PROJECT_PRG2.Properties.Resources.magnifying_glass_10977492;
            this.btnCari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCari.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCari.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCari.FillColor = System.Drawing.Color.Transparent;
            this.btnCari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCari.ForeColor = System.Drawing.Color.Transparent;
            this.btnCari.Location = new System.Drawing.Point(487, 30);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(34, 36);
            this.btnCari.TabIndex = 31;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // jenisPrestasiTableAdapter1
            // 
            this.jenisPrestasiTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(906, 617);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 28);
            this.label1.TabIndex = 100;
            this.label1.Text = "Aksi";
            // 
            // btnHapusJP
            // 
            this.btnHapusJP.BackColor = System.Drawing.Color.Transparent;
            this.btnHapusJP.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnHapusJP.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnHapusJP.Image = ((System.Drawing.Image)(resources.GetObject("btnHapusJP.Image")));
            this.btnHapusJP.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnHapusJP.ImageRotate = 0F;
            this.btnHapusJP.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHapusJP.Location = new System.Drawing.Point(1048, 651);
            this.btnHapusJP.Margin = new System.Windows.Forms.Padding(2);
            this.btnHapusJP.Name = "btnHapusJP";
            this.btnHapusJP.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnHapusJP.Size = new System.Drawing.Size(35, 35);
            this.btnHapusJP.TabIndex = 98;
            this.btnHapusJP.UseTransparentBackground = true;
            this.btnHapusJP.Click += new System.EventHandler(this.btnHapusJP_Click);
            // 
            // btnUpdateJP
            // 
            this.btnUpdateJP.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateJP.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnUpdateJP.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnUpdateJP.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateJP.Image")));
            this.btnUpdateJP.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnUpdateJP.ImageRotate = 0F;
            this.btnUpdateJP.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdateJP.Location = new System.Drawing.Point(981, 652);
            this.btnUpdateJP.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateJP.Name = "btnUpdateJP";
            this.btnUpdateJP.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnUpdateJP.Size = new System.Drawing.Size(29, 31);
            this.btnUpdateJP.TabIndex = 97;
            this.btnUpdateJP.UseTransparentBackground = true;
            this.btnUpdateJP.Click += new System.EventHandler(this.btnUpdateJP_Click);
            // 
            // btnTambahJP
            // 
            this.btnTambahJP.BackColor = System.Drawing.Color.Transparent;
            this.btnTambahJP.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnTambahJP.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnTambahJP.Image = ((System.Drawing.Image)(resources.GetObject("btnTambahJP.Image")));
            this.btnTambahJP.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnTambahJP.ImageRotate = 0F;
            this.btnTambahJP.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTambahJP.Location = new System.Drawing.Point(913, 651);
            this.btnTambahJP.Margin = new System.Windows.Forms.Padding(2);
            this.btnTambahJP.Name = "btnTambahJP";
            this.btnTambahJP.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnTambahJP.Size = new System.Drawing.Size(27, 32);
            this.btnTambahJP.TabIndex = 96;
            this.btnTambahJP.UseTransparentBackground = true;
            this.btnTambahJP.Click += new System.EventHandler(this.btnTambahJP_Click);
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
            this.guna2TextBox1.Location = new System.Drawing.Point(890, 649);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(217, 37);
            this.guna2TextBox1.TabIndex = 99;
            // 
            // btnRefersh
            // 
            this.btnRefersh.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnRefersh.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnRefersh.Image = global::PROJECT_PRG2.Properties.Resources.refresh_594822;
            this.btnRefersh.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnRefersh.ImageRotate = 0F;
            this.btnRefersh.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefersh.Location = new System.Drawing.Point(1276, 462);
            this.btnRefersh.Name = "btnRefersh";
            this.btnRefersh.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnRefersh.Size = new System.Drawing.Size(45, 51);
            this.btnRefersh.TabIndex = 134;
            this.btnRefersh.Click += new System.EventHandler(this.btnRefersh_Click);
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.AutoRoundedCorners = true;
            this.guna2TextBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox2.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox2.BorderRadius = 19;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Poppins", 9F);
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(553, 547);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(243, 41);
            this.guna2TextBox2.TabIndex = 23;
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.AutoRoundedCorners = true;
            this.guna2TextBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox3.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox3.BorderRadius = 19;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Location = new System.Drawing.Point(554, 650);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderText = "";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(243, 41);
            this.guna2TextBox3.TabIndex = 24;
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.AutoRoundedCorners = true;
            this.guna2TextBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox4.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox4.BorderRadius = 19;
            this.guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox4.DefaultText = "";
            this.guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.Location = new System.Drawing.Point(887, 547);
            this.guna2TextBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PasswordChar = '\0';
            this.guna2TextBox4.PlaceholderText = "";
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.Size = new System.Drawing.Size(243, 41);
            this.guna2TextBox4.TabIndex = 25;
            this.guna2TextBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPoint_KeyPress);
            // 
            // jenisPrestasiTableAdapter
            // 
            this.jenisPrestasiTableAdapter.ClearBeforeFill = true;
            // 
            // jenisPrestasiTableAdapter2
            // 
            this.jenisPrestasiTableAdapter2.ClearBeforeFill = true;
            // 
            // UDJepres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1376, 1033);
            this.Controls.Add(this.btnRefersh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHapusJP);
            this.Controls.Add(this.btnUpdateJP);
            this.Controls.Add(this.btnTambahJP);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.guna2TextBox4);
            this.Controls.Add(this.guna2TextBox3);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.txtPenyelenggara);
            this.Controls.Add(this.txtPeran);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtIdJenisPrestasi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.txtCari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UDJepres";
            this.Text = "UDJepres";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UDJepres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisPrestasiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMART_MABRESDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisPrestasiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMART_MABRESDsAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisPrestasiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtCari;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Button btnBatal;
        private Guna.UI2.WinForms.Guna2TextBox txtPoint;
        private Guna.UI2.WinForms.Guna2TextBox txtPenyelenggara;
        private Guna.UI2.WinForms.Guna2TextBox txtPeran;
        private Guna.UI2.WinForms.Guna2TextBox txtNama;
        private Guna.UI2.WinForms.Guna2TextBox txtIdJenisPrestasi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnCari;
        private FINDSMARTDataSet7 fINDSMARTDataSet7;
        private System.Windows.Forms.BindingSource jenisPrestasiBindingSource1;
        private FINDSMARTDataSet7TableAdapters.JenisPrestasiTableAdapter jenisPrestasiTableAdapter1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton btnHapusJP;
        private Guna.UI2.WinForms.Guna2ImageButton btnUpdateJP;
        private Guna.UI2.WinForms.Guna2ImageButton btnTambahJP;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idJenisPrestasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penyelenggaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2ImageButton btnRefersh;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private FINDSMART_MABRESDsAll fINDSMART_MABRESDsAll;
        private System.Windows.Forms.BindingSource jenisPrestasiBindingSource;
        private FINDSMART_MABRESDsAllTableAdapters.JenisPrestasiTableAdapter jenisPrestasiTableAdapter;
        private FINDSMART_MABRESDataSet1 fINDSMART_MABRESDataSet1;
        private System.Windows.Forms.BindingSource jenisPrestasiBindingSource2;
        private FINDSMART_MABRESDataSet1TableAdapters.JenisPrestasiTableAdapter jenisPrestasiTableAdapter2;
    }
}