namespace PROJECT_PRG2.CRUD_MataKuliah
{
    partial class ViewMatkul
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMatkul));
            this.gdvMatkul = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idMatkulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahSKSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noPegawaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mataKuliahBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fINDSMARTDataSet7 = new PROJECT_PRG2.FINDSMARTDataSet7();
            this.txtCari = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCari = new Guna.UI2.WinForms.Guna2ImageButton();
            this.programStudiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fINDSMARTDataSet2 = new PROJECT_PRG2.FINDSMARTDataSet2();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dosenTableAdapter = new PROJECT_PRG2.FINDSMARTDataSet1TableAdapters.DosenTableAdapter();
            this.dosenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fINDSMARTDataSet1 = new PROJECT_PRG2.FINDSMARTDataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSemester = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtJenis = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSKS = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdMatkul = new Guna.UI2.WinForms.Guna2TextBox();
            this.programStudiTableAdapter = new PROJECT_PRG2.FINDSMARTDataSet2TableAdapters.ProgramStudiTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHapus = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnTambah = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbPegawai = new System.Windows.Forms.ComboBox();
            this.dosenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbProdi = new System.Windows.Forms.ComboBox();
            this.programStudiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mataKuliahTableAdapter = new PROJECT_PRG2.FINDSMARTDataSet7TableAdapters.MataKuliahTableAdapter();
            this.dosenTableAdapter1 = new PROJECT_PRG2.FINDSMARTDataSet7TableAdapters.DosenTableAdapter();
            this.programStudiTableAdapter1 = new PROJECT_PRG2.FINDSMARTDataSet7TableAdapters.ProgramStudiTableAdapter();
            this.btnBatal = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMatkul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataKuliahBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosenBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvMatkul
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.gdvMatkul.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdvMatkul.AutoGenerateColumns = false;
            this.gdvMatkul.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvMatkul.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdvMatkul.ColumnHeadersHeight = 30;
            this.gdvMatkul.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMatkulDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.jumlahSKSDataGridViewTextBoxColumn,
            this.jenisDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.noPegawaiDataGridViewTextBoxColumn,
            this.idProdiDataGridViewTextBoxColumn});
            this.gdvMatkul.DataSource = this.mataKuliahBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvMatkul.DefaultCellStyle = dataGridViewCellStyle3;
            this.gdvMatkul.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.gdvMatkul.Location = new System.Drawing.Point(99, 112);
            this.gdvMatkul.Margin = new System.Windows.Forms.Padding(2);
            this.gdvMatkul.Name = "gdvMatkul";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvMatkul.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gdvMatkul.RowHeadersVisible = false;
            this.gdvMatkul.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvMatkul.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gdvMatkul.RowTemplate.Height = 28;
            this.gdvMatkul.Size = new System.Drawing.Size(1158, 390);
            this.gdvMatkul.TabIndex = 0;
            this.gdvMatkul.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.gdvMatkul.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.gdvMatkul.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gdvMatkul.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gdvMatkul.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gdvMatkul.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gdvMatkul.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gdvMatkul.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.gdvMatkul.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.gdvMatkul.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gdvMatkul.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvMatkul.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdvMatkul.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gdvMatkul.ThemeStyle.HeaderStyle.Height = 30;
            this.gdvMatkul.ThemeStyle.ReadOnly = false;
            this.gdvMatkul.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.gdvMatkul.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvMatkul.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvMatkul.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gdvMatkul.ThemeStyle.RowsStyle.Height = 28;
            this.gdvMatkul.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.gdvMatkul.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gdvMatkul.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvMatkul_CellContentClick);
            // 
            // idMatkulDataGridViewTextBoxColumn
            // 
            this.idMatkulDataGridViewTextBoxColumn.DataPropertyName = "Id_Matkul";
            this.idMatkulDataGridViewTextBoxColumn.HeaderText = "Id_Matkul";
            this.idMatkulDataGridViewTextBoxColumn.Name = "idMatkulDataGridViewTextBoxColumn";
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // jumlahSKSDataGridViewTextBoxColumn
            // 
            this.jumlahSKSDataGridViewTextBoxColumn.DataPropertyName = "Jumlah_SKS";
            this.jumlahSKSDataGridViewTextBoxColumn.HeaderText = "Jumlah_SKS";
            this.jumlahSKSDataGridViewTextBoxColumn.Name = "jumlahSKSDataGridViewTextBoxColumn";
            // 
            // jenisDataGridViewTextBoxColumn
            // 
            this.jenisDataGridViewTextBoxColumn.DataPropertyName = "Jenis";
            this.jenisDataGridViewTextBoxColumn.HeaderText = "Jenis";
            this.jenisDataGridViewTextBoxColumn.Name = "jenisDataGridViewTextBoxColumn";
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Semester";
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // noPegawaiDataGridViewTextBoxColumn
            // 
            this.noPegawaiDataGridViewTextBoxColumn.DataPropertyName = "No_Pegawai";
            this.noPegawaiDataGridViewTextBoxColumn.HeaderText = "No_Pegawai";
            this.noPegawaiDataGridViewTextBoxColumn.Name = "noPegawaiDataGridViewTextBoxColumn";
            // 
            // idProdiDataGridViewTextBoxColumn
            // 
            this.idProdiDataGridViewTextBoxColumn.DataPropertyName = "Id_Prodi";
            this.idProdiDataGridViewTextBoxColumn.HeaderText = "Id_Prodi";
            this.idProdiDataGridViewTextBoxColumn.Name = "idProdiDataGridViewTextBoxColumn";
            // 
            // mataKuliahBindingSource
            // 
            this.mataKuliahBindingSource.DataMember = "MataKuliah";
            this.mataKuliahBindingSource.DataSource = this.fINDSMARTDataSet7;
            // 
            // fINDSMARTDataSet7
            // 
            this.fINDSMARTDataSet7.DataSetName = "FINDSMARTDataSet7";
            this.fINDSMARTDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCari
            // 
            this.txtCari.Animated = true;
            this.txtCari.BackColor = System.Drawing.Color.Transparent;
            this.txtCari.BorderColor = System.Drawing.Color.Black;
            this.txtCari.BorderRadius = 10;
            this.txtCari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCari.DefaultText = "";
            this.txtCari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtCari.ForeColor = System.Drawing.Color.Black;
            this.txtCari.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.Location = new System.Drawing.Point(557, 24);
            this.txtCari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCari.Name = "txtCari";
            this.txtCari.PasswordChar = '\0';
            this.txtCari.PlaceholderText = "";
            this.txtCari.SelectedText = "";
            this.txtCari.Size = new System.Drawing.Size(322, 31);
            this.txtCari.TabIndex = 98;
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.Transparent;
            this.btnCari.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCari.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnCari.Image = global::PROJECT_PRG2.Properties.Resources.magnifying_glass_10977492;
            this.btnCari.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCari.ImageRotate = 0F;
            this.btnCari.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCari.Location = new System.Drawing.Point(497, 11);
            this.btnCari.Margin = new System.Windows.Forms.Padding(2);
            this.btnCari.Name = "btnCari";
            this.btnCari.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnCari.Size = new System.Drawing.Size(55, 56);
            this.btnCari.TabIndex = 99;
            this.btnCari.UseTransparentBackground = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // programStudiBindingSource
            // 
            this.programStudiBindingSource.DataMember = "ProgramStudi";
            this.programStudiBindingSource.DataSource = this.fINDSMARTDataSet2;
            // 
            // fINDSMARTDataSet2
            // 
            this.fINDSMARTDataSet2.DataSetName = "FINDSMARTDataSet2";
            this.fINDSMARTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(322, 677);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 15);
            this.label11.TabIndex = 113;
            this.label11.Text = "Nama";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(322, 761);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 15);
            this.label10.TabIndex = 112;
            this.label10.Text = "Jumlah SKS";
            // 
            // dosenTableAdapter
            // 
            this.dosenTableAdapter.ClearBeforeFill = true;
            // 
            // dosenBindingSource
            // 
            this.dosenBindingSource.DataMember = "Dosen";
            this.dosenBindingSource.DataSource = this.fINDSMARTDataSet1;
            // 
            // fINDSMARTDataSet1
            // 
            this.fINDSMARTDataSet1.DataSetName = "FINDSMARTDataSet1";
            this.fINDSMARTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(877, 677);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 115;
            this.label2.Text = "Id Prodi";
            // 
            // txtStatus
            // 
            this.txtStatus.Animated = true;
            this.txtStatus.BackColor = System.Drawing.Color.Transparent;
            this.txtStatus.BorderColor = System.Drawing.Color.Black;
            this.txtStatus.BorderRadius = 10;
            this.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStatus.DefaultText = "";
            this.txtStatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStatus.Enabled = false;
            this.txtStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtStatus.ForeColor = System.Drawing.Color.Black;
            this.txtStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStatus.Location = new System.Drawing.Point(589, 785);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PasswordChar = '\0';
            this.txtStatus.PlaceholderText = "";
            this.txtStatus.SelectedText = "";
            this.txtStatus.Size = new System.Drawing.Size(190, 31);
            this.txtStatus.TabIndex = 114;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(584, 602);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 111;
            this.label9.Text = "Jenis";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(584, 677);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 110;
            this.label8.Text = "Semester";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(584, 761);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 109;
            this.label7.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(877, 602);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 108;
            this.label6.Text = "No Pegawai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 602);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 107;
            this.label1.Text = "Id Matkul";
            // 
            // txtSemester
            // 
            this.txtSemester.Animated = true;
            this.txtSemester.BackColor = System.Drawing.Color.Transparent;
            this.txtSemester.BorderColor = System.Drawing.Color.Black;
            this.txtSemester.BorderRadius = 10;
            this.txtSemester.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSemester.DefaultText = "";
            this.txtSemester.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSemester.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSemester.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSemester.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSemester.Enabled = false;
            this.txtSemester.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSemester.ForeColor = System.Drawing.Color.Black;
            this.txtSemester.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSemester.Location = new System.Drawing.Point(589, 701);
            this.txtSemester.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.PasswordChar = '\0';
            this.txtSemester.PlaceholderText = "";
            this.txtSemester.SelectedText = "";
            this.txtSemester.Size = new System.Drawing.Size(190, 31);
            this.txtSemester.TabIndex = 104;
            // 
            // txtJenis
            // 
            this.txtJenis.Animated = true;
            this.txtJenis.BackColor = System.Drawing.Color.Transparent;
            this.txtJenis.BorderColor = System.Drawing.Color.Black;
            this.txtJenis.BorderRadius = 10;
            this.txtJenis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJenis.DefaultText = "";
            this.txtJenis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtJenis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtJenis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJenis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJenis.Enabled = false;
            this.txtJenis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtJenis.ForeColor = System.Drawing.Color.Black;
            this.txtJenis.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJenis.Location = new System.Drawing.Point(589, 629);
            this.txtJenis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJenis.Name = "txtJenis";
            this.txtJenis.PasswordChar = '\0';
            this.txtJenis.PlaceholderText = "";
            this.txtJenis.SelectedText = "";
            this.txtJenis.Size = new System.Drawing.Size(190, 31);
            this.txtJenis.TabIndex = 103;
            // 
            // txtSKS
            // 
            this.txtSKS.Animated = true;
            this.txtSKS.BackColor = System.Drawing.Color.Transparent;
            this.txtSKS.BorderColor = System.Drawing.Color.Black;
            this.txtSKS.BorderRadius = 10;
            this.txtSKS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSKS.DefaultText = "";
            this.txtSKS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSKS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSKS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSKS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSKS.Enabled = false;
            this.txtSKS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSKS.ForeColor = System.Drawing.Color.Black;
            this.txtSKS.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSKS.Location = new System.Drawing.Point(313, 785);
            this.txtSKS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSKS.Name = "txtSKS";
            this.txtSKS.PasswordChar = '\0';
            this.txtSKS.PlaceholderText = "";
            this.txtSKS.SelectedText = "";
            this.txtSKS.Size = new System.Drawing.Size(190, 31);
            this.txtSKS.TabIndex = 102;
            // 
            // txtNama
            // 
            this.txtNama.Animated = true;
            this.txtNama.BackColor = System.Drawing.Color.Transparent;
            this.txtNama.BorderColor = System.Drawing.Color.Black;
            this.txtNama.BorderRadius = 10;
            this.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNama.DefaultText = "";
            this.txtNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.Enabled = false;
            this.txtNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNama.ForeColor = System.Drawing.Color.Black;
            this.txtNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.Location = new System.Drawing.Point(313, 701);
            this.txtNama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNama.Name = "txtNama";
            this.txtNama.PasswordChar = '\0';
            this.txtNama.PlaceholderText = "";
            this.txtNama.SelectedText = "";
            this.txtNama.Size = new System.Drawing.Size(190, 31);
            this.txtNama.TabIndex = 101;
            // 
            // txtIdMatkul
            // 
            this.txtIdMatkul.Animated = true;
            this.txtIdMatkul.BackColor = System.Drawing.Color.Transparent;
            this.txtIdMatkul.BorderColor = System.Drawing.Color.Black;
            this.txtIdMatkul.BorderRadius = 10;
            this.txtIdMatkul.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdMatkul.DefaultText = "";
            this.txtIdMatkul.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdMatkul.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdMatkul.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdMatkul.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdMatkul.Enabled = false;
            this.txtIdMatkul.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdMatkul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtIdMatkul.ForeColor = System.Drawing.Color.Black;
            this.txtIdMatkul.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdMatkul.Location = new System.Drawing.Point(313, 629);
            this.txtIdMatkul.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdMatkul.Name = "txtIdMatkul";
            this.txtIdMatkul.PasswordChar = '\0';
            this.txtIdMatkul.PlaceholderText = "";
            this.txtIdMatkul.SelectedText = "";
            this.txtIdMatkul.Size = new System.Drawing.Size(190, 31);
            this.txtIdMatkul.TabIndex = 100;
            // 
            // programStudiTableAdapter
            // 
            this.programStudiTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(896, 820);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 127;
            this.label3.Text = "Aksi";
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Transparent;
            this.btnHapus.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnHapus.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnHapus.Image = ((System.Drawing.Image)(resources.GetObject("btnHapus.Image")));
            this.btnHapus.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnHapus.ImageRotate = 0F;
            this.btnHapus.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHapus.Location = new System.Drawing.Point(1001, 851);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnHapus.Size = new System.Drawing.Size(23, 25);
            this.btnHapus.TabIndex = 125;
            this.btnHapus.UseTransparentBackground = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnUpdate.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnUpdate.ImageRotate = 0F;
            this.btnUpdate.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdate.Location = new System.Drawing.Point(952, 848);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnUpdate.Size = new System.Drawing.Size(29, 31);
            this.btnUpdate.TabIndex = 124;
            this.btnUpdate.UseTransparentBackground = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.Transparent;
            this.btnTambah.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnTambah.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnTambah.Image = ((System.Drawing.Image)(resources.GetObject("btnTambah.Image")));
            this.btnTambah.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnTambah.ImageRotate = 0F;
            this.btnTambah.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTambah.Location = new System.Drawing.Point(900, 846);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(2);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnTambah.Size = new System.Drawing.Size(27, 32);
            this.btnTambah.TabIndex = 123;
            this.btnTambah.UseTransparentBackground = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
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
            this.guna2TextBox1.Location = new System.Drawing.Point(892, 844);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(145, 37);
            this.guna2TextBox1.TabIndex = 126;
            // 
            // cbPegawai
            // 
            this.cbPegawai.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dosenBindingSource, "No_Pegawai", true));
            this.cbPegawai.DataSource = this.dosenBindingSource1;
            this.cbPegawai.DisplayMember = "Nama";
            this.cbPegawai.Enabled = false;
            this.cbPegawai.FormattingEnabled = true;
            this.cbPegawai.Location = new System.Drawing.Point(881, 629);
            this.cbPegawai.Name = "cbPegawai";
            this.cbPegawai.Size = new System.Drawing.Size(189, 21);
            this.cbPegawai.TabIndex = 128;
            this.cbPegawai.ValueMember = "No_Pegawai";
            // 
            // dosenBindingSource1
            // 
            this.dosenBindingSource1.DataMember = "Dosen";
            this.dosenBindingSource1.DataSource = this.fINDSMARTDataSet7;
            // 
            // cbProdi
            // 
            this.cbProdi.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.programStudiBindingSource, "Id_Prodi", true));
            this.cbProdi.DataSource = this.programStudiBindingSource1;
            this.cbProdi.DisplayMember = "Nama";
            this.cbProdi.Enabled = false;
            this.cbProdi.FormattingEnabled = true;
            this.cbProdi.IntegralHeight = false;
            this.cbProdi.ItemHeight = 13;
            this.cbProdi.Location = new System.Drawing.Point(881, 711);
            this.cbProdi.Name = "cbProdi";
            this.cbProdi.Size = new System.Drawing.Size(189, 21);
            this.cbProdi.TabIndex = 129;
            this.cbProdi.ValueMember = "Id_Prodi";
            // 
            // programStudiBindingSource1
            // 
            this.programStudiBindingSource1.DataMember = "ProgramStudi";
            this.programStudiBindingSource1.DataSource = this.fINDSMARTDataSet7;
            // 
            // mataKuliahTableAdapter
            // 
            this.mataKuliahTableAdapter.ClearBeforeFill = true;
            // 
            // dosenTableAdapter1
            // 
            this.dosenTableAdapter1.ClearBeforeFill = true;
            // 
            // programStudiTableAdapter1
            // 
            this.programStudiTableAdapter1.ClearBeforeFill = true;
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
            this.btnBatal.Location = new System.Drawing.Point(589, 851);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(133, 28);
            this.btnBatal.TabIndex = 130;
            this.btnBatal.Text = "Batal";
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoRoundedCorners = true;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BorderRadius = 13;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(892, 540);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(145, 28);
            this.btnRefresh.TabIndex = 131;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ViewMatkul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1376, 1033);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.cbProdi);
            this.Controls.Add(this.cbPegawai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSemester);
            this.Controls.Add(this.txtJenis);
            this.Controls.Add(this.txtSKS);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtIdMatkul);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.gdvMatkul);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewMatkul";
            this.Text = "ViewMatkul";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewMatkul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvMatkul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataKuliahBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosenBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView gdvMatkul;
        private Guna.UI2.WinForms.Guna2TextBox txtCari;
        private Guna.UI2.WinForms.Guna2ImageButton btnCari;
        private System.Windows.Forms.BindingSource programStudiBindingSource;
        private FINDSMARTDataSet2 fINDSMARTDataSet2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private FINDSMARTDataSet1TableAdapters.DosenTableAdapter dosenTableAdapter;
        private System.Windows.Forms.BindingSource dosenBindingSource;
        private FINDSMARTDataSet1 fINDSMARTDataSet1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSemester;
        private Guna.UI2.WinForms.Guna2TextBox txtJenis;
        private Guna.UI2.WinForms.Guna2TextBox txtSKS;
        private Guna.UI2.WinForms.Guna2TextBox txtNama;
        private Guna.UI2.WinForms.Guna2TextBox txtIdMatkul;
        private FINDSMARTDataSet2TableAdapters.ProgramStudiTableAdapter programStudiTableAdapter;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ImageButton btnHapus;
        private Guna.UI2.WinForms.Guna2ImageButton btnUpdate;
        private Guna.UI2.WinForms.Guna2ImageButton btnTambah;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.ComboBox cbPegawai;
        private System.Windows.Forms.ComboBox cbProdi;
        private FINDSMARTDataSet7 fINDSMARTDataSet7;
        private System.Windows.Forms.BindingSource mataKuliahBindingSource;
        private FINDSMARTDataSet7TableAdapters.MataKuliahTableAdapter mataKuliahTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMatkulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahSKSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noPegawaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dosenBindingSource1;
        private FINDSMARTDataSet7TableAdapters.DosenTableAdapter dosenTableAdapter1;
        private System.Windows.Forms.BindingSource programStudiBindingSource1;
        private FINDSMARTDataSet7TableAdapters.ProgramStudiTableAdapter programStudiTableAdapter1;
        private Guna.UI2.WinForms.Guna2Button btnBatal;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}