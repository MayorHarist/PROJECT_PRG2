﻿namespace PROJECT_PRG2.CRUD_MataKuliah
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMatkul));
            this.gdvMatkul = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idMatkulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahSKSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Prodi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_Pegawai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mataKuliahBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dATASETDEANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dATASET_DEAN = new PROJECT_PRG2.DATASET_DEAN();
            this.mataKuliahBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fINDSMART_MABRESDataSet1 = new PROJECT_PRG2.FINDSMART_MABRESDataSet1();
            this.mataKuliahBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fINDSMART_MABRESDsAll = new PROJECT_PRG2.FINDSMART_MABRESDsAll();
            this.mataKuliahBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fINDSMARTDataSet7 = new PROJECT_PRG2.FINDSMARTDataSet7();
            this.txtCari = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCari = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSemester = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtJenis = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSKS = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdMatkul = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHapus = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnTambah = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbPegawai = new System.Windows.Forms.ComboBox();
            this.dosenBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dosenBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dosenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dosenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbProdi = new System.Windows.Forms.ComboBox();
            this.programStudiBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.programStudiBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.programStudiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.programStudiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programStudiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnBatal = new Guna.UI2.WinForms.Guna2Button();
            this.mataKuliahTableAdapter = new PROJECT_PRG2.FINDSMARTDataSet7TableAdapters.MataKuliahTableAdapter();
            this.dosenTableAdapter = new PROJECT_PRG2.FINDSMARTDataSet7TableAdapters.DosenTableAdapter();
            this.programStudiTableAdapter = new PROJECT_PRG2.FINDSMARTDataSet7TableAdapters.ProgramStudiTableAdapter();
            this.btnRefersh = new Guna.UI2.WinForms.Guna2ImageButton();
            this.mataKuliahTableAdapter1 = new PROJECT_PRG2.FINDSMART_MABRESDsAllTableAdapters.MataKuliahTableAdapter();
            this.programStudiTableAdapter1 = new PROJECT_PRG2.FINDSMART_MABRESDsAllTableAdapters.ProgramStudiTableAdapter();
            this.dosenTableAdapter1 = new PROJECT_PRG2.FINDSMART_MABRESDsAllTableAdapters.DosenTableAdapter();
            this.mataKuliahTableAdapter2 = new PROJECT_PRG2.FINDSMART_MABRESDataSet1TableAdapters.MataKuliahTableAdapter();
            this.programStudiTableAdapter2 = new PROJECT_PRG2.FINDSMART_MABRESDataSet1TableAdapters.ProgramStudiTableAdapter();
            this.dosenTableAdapter2 = new PROJECT_PRG2.FINDSMART_MABRESDataSet1TableAdapters.DosenTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKelas = new Guna.UI2.WinForms.Guna2TextBox();
            this.mataKuliahTableAdapter3 = new PROJECT_PRG2.DATASET_DEANTableAdapters.MataKuliahTableAdapter();
            this.programStudiTableAdapter3 = new PROJECT_PRG2.DATASET_DEANTableAdapters.ProgramStudiTableAdapter();
            this.dosenTableAdapter3 = new PROJECT_PRG2.DATASET_DEANTableAdapters.DosenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMatkul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataKuliahBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATASETDEANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATASET_DEAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataKuliahBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMART_MABRESDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataKuliahBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMART_MABRESDsAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataKuliahBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosenBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosenBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosenBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvMatkul
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.gdvMatkul.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.gdvMatkul.AutoGenerateColumns = false;
            this.gdvMatkul.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvMatkul.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gdvMatkul.ColumnHeadersHeight = 30;
            this.gdvMatkul.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMatkulDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.jumlahSKSDataGridViewTextBoxColumn,
            this.jenisDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn,
            this.Kelas,
            this.Id_Prodi,
            this.No_Pegawai});
            this.gdvMatkul.DataSource = this.mataKuliahBindingSource2;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvMatkul.DefaultCellStyle = dataGridViewCellStyle13;
            this.gdvMatkul.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.gdvMatkul.Location = new System.Drawing.Point(45, 106);
            this.gdvMatkul.Margin = new System.Windows.Forms.Padding(2);
            this.gdvMatkul.Name = "gdvMatkul";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvMatkul.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.gdvMatkul.RowHeadersVisible = false;
            this.gdvMatkul.RowHeadersWidth = 62;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvMatkul.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.gdvMatkul.RowTemplate.Height = 28;
            this.gdvMatkul.Size = new System.Drawing.Size(1279, 382);
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
            this.gdvMatkul.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
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
            this.idMatkulDataGridViewTextBoxColumn.HeaderText = "Id Matkul";
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
            this.jumlahSKSDataGridViewTextBoxColumn.HeaderText = "Jumlah SKS";
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
            // Kelas
            // 
            this.Kelas.DataPropertyName = "Kelas";
            this.Kelas.HeaderText = "Kelas";
            this.Kelas.Name = "Kelas";
            // 
            // Id_Prodi
            // 
            this.Id_Prodi.DataPropertyName = "Id_Prodi";
            this.Id_Prodi.HeaderText = "Id Prodi";
            this.Id_Prodi.Name = "Id_Prodi";
            // 
            // No_Pegawai
            // 
            this.No_Pegawai.DataPropertyName = "No_Pegawai";
            this.No_Pegawai.HeaderText = "No Pegawai";
            this.No_Pegawai.Name = "No_Pegawai";
            // 
            // mataKuliahBindingSource3
            // 
            this.mataKuliahBindingSource3.DataMember = "MataKuliah";
            this.mataKuliahBindingSource3.DataSource = this.dATASETDEANBindingSource;
            // 
            // dATASETDEANBindingSource
            // 
            this.dATASETDEANBindingSource.DataSource = this.dATASET_DEAN;
            this.dATASETDEANBindingSource.Position = 0;
            // 
            // dATASET_DEAN
            // 
            this.dATASET_DEAN.DataSetName = "DATASET_DEAN";
            this.dATASET_DEAN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mataKuliahBindingSource2
            // 
            this.mataKuliahBindingSource2.DataMember = "MataKuliah";
            this.mataKuliahBindingSource2.DataSource = this.fINDSMART_MABRESDataSet1;
            // 
            // fINDSMART_MABRESDataSet1
            // 
            this.fINDSMART_MABRESDataSet1.DataSetName = "FINDSMART_MABRESDataSet1";
            this.fINDSMART_MABRESDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mataKuliahBindingSource1
            // 
            this.mataKuliahBindingSource1.DataMember = "MataKuliah";
            this.mataKuliahBindingSource1.DataSource = this.fINDSMART_MABRESDsAll;
            // 
            // fINDSMART_MABRESDsAll
            // 
            this.fINDSMART_MABRESDsAll.DataSetName = "FINDSMART_MABRESDsAll";
            this.fINDSMART_MABRESDsAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.txtCari.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCari.ForeColor = System.Drawing.Color.Black;
            this.txtCari.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.Location = new System.Drawing.Point(557, 24);
            this.txtCari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCari.Name = "txtCari";
            this.txtCari.PasswordChar = '\0';
            this.txtCari.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCari.PlaceholderText = "Cari Data Mata Kuliah";
            this.txtCari.SelectedText = "";
            this.txtCari.Size = new System.Drawing.Size(362, 36);
            this.txtCari.TabIndex = 98;
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.Transparent;
            this.btnCari.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCari.HoverState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnCari.Image = global::PROJECT_PRG2.Properties.Resources.magnifying_glass_10977492;
            this.btnCari.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCari.ImageRotate = 0F;
            this.btnCari.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCari.Location = new System.Drawing.Point(509, 17);
            this.btnCari.Margin = new System.Windows.Forms.Padding(2);
            this.btnCari.Name = "btnCari";
            this.btnCari.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnCari.Size = new System.Drawing.Size(43, 44);
            this.btnCari.TabIndex = 99;
            this.btnCari.UseTransparentBackground = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(149, 657);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 28);
            this.label11.TabIndex = 113;
            this.label11.Text = "Nama";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(437, 557);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 28);
            this.label10.TabIndex = 112;
            this.label10.Text = "Jumlah SKS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1012, 557);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 28);
            this.label2.TabIndex = 115;
            this.label2.Text = "Program Studi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(437, 660);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 28);
            this.label9.TabIndex = 111;
            this.label9.Text = "Jenis";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(729, 557);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 28);
            this.label8.TabIndex = 110;
            this.label8.Text = "Semester";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1011, 663);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 28);
            this.label6.TabIndex = 108;
            this.label6.Text = "Dosen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 557);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
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
            this.txtSemester.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSemester.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemester.ForeColor = System.Drawing.Color.Black;
            this.txtSemester.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSemester.Location = new System.Drawing.Point(711, 591);
            this.txtSemester.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.PasswordChar = '\0';
            this.txtSemester.PlaceholderText = "";
            this.txtSemester.SelectedText = "";
            this.txtSemester.Size = new System.Drawing.Size(243, 41);
            this.txtSemester.TabIndex = 104;
            this.txtSemester.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSemester_KeyPress);
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
            this.txtJenis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJenis.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJenis.ForeColor = System.Drawing.Color.Black;
            this.txtJenis.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJenis.Location = new System.Drawing.Point(419, 691);
            this.txtJenis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJenis.Name = "txtJenis";
            this.txtJenis.PasswordChar = '\0';
            this.txtJenis.PlaceholderText = "";
            this.txtJenis.SelectedText = "";
            this.txtJenis.Size = new System.Drawing.Size(243, 41);
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
            this.txtSKS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSKS.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSKS.ForeColor = System.Drawing.Color.Black;
            this.txtSKS.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSKS.Location = new System.Drawing.Point(419, 591);
            this.txtSKS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSKS.Name = "txtSKS";
            this.txtSKS.PasswordChar = '\0';
            this.txtSKS.PlaceholderText = "";
            this.txtSKS.SelectedText = "";
            this.txtSKS.Size = new System.Drawing.Size(243, 41);
            this.txtSKS.TabIndex = 102;
            this.txtSKS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSKS_KeyPress);
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
            this.txtNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.ForeColor = System.Drawing.Color.Black;
            this.txtNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.Location = new System.Drawing.Point(130, 691);
            this.txtNama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNama.Name = "txtNama";
            this.txtNama.PasswordChar = '\0';
            this.txtNama.PlaceholderText = "";
            this.txtNama.SelectedText = "";
            this.txtNama.Size = new System.Drawing.Size(243, 41);
            this.txtNama.TabIndex = 101;
            this.txtNama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNama_KeyPress);
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
            this.txtIdMatkul.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdMatkul.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMatkul.ForeColor = System.Drawing.Color.Black;
            this.txtIdMatkul.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdMatkul.Location = new System.Drawing.Point(130, 591);
            this.txtIdMatkul.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdMatkul.Name = "txtIdMatkul";
            this.txtIdMatkul.PasswordChar = '\0';
            this.txtIdMatkul.PlaceholderText = "";
            this.txtIdMatkul.ReadOnly = true;
            this.txtIdMatkul.SelectedText = "";
            this.txtIdMatkul.Size = new System.Drawing.Size(243, 41);
            this.txtIdMatkul.TabIndex = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1012, 781);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 28);
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
            this.btnHapus.Location = new System.Drawing.Point(1154, 811);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnHapus.Size = new System.Drawing.Size(44, 41);
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
            this.btnUpdate.Location = new System.Drawing.Point(1092, 813);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnUpdate.Size = new System.Drawing.Size(38, 36);
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
            this.btnTambah.Location = new System.Drawing.Point(1023, 813);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(2);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnTambah.Size = new System.Drawing.Size(37, 37);
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
            this.guna2TextBox1.Location = new System.Drawing.Point(1015, 813);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(194, 37);
            this.guna2TextBox1.TabIndex = 126;
            // 
            // cbPegawai
            // 
            this.cbPegawai.DataSource = this.dosenBindingSource2;
            this.cbPegawai.DisplayMember = "Nama";
            this.cbPegawai.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPegawai.FormattingEnabled = true;
            this.cbPegawai.Location = new System.Drawing.Point(1006, 694);
            this.cbPegawai.Name = "cbPegawai";
            this.cbPegawai.Size = new System.Drawing.Size(217, 36);
            this.cbPegawai.TabIndex = 128;
            this.cbPegawai.ValueMember = "No_Pegawai";
            // 
            // dosenBindingSource3
            // 
            this.dosenBindingSource3.DataMember = "Dosen";
            this.dosenBindingSource3.DataSource = this.dATASETDEANBindingSource;
            // 
            // dosenBindingSource2
            // 
            this.dosenBindingSource2.DataMember = "Dosen";
            this.dosenBindingSource2.DataSource = this.fINDSMART_MABRESDataSet1;
            // 
            // dosenBindingSource1
            // 
            this.dosenBindingSource1.DataMember = "Dosen";
            this.dosenBindingSource1.DataSource = this.fINDSMART_MABRESDsAll;
            // 
            // dosenBindingSource
            // 
            this.dosenBindingSource.DataMember = "Dosen";
            this.dosenBindingSource.DataSource = this.fINDSMARTDataSet7;
            // 
            // cbProdi
            // 
            this.cbProdi.DataSource = this.programStudiBindingSource3;
            this.cbProdi.DisplayMember = "Nama";
            this.cbProdi.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProdi.FormattingEnabled = true;
            this.cbProdi.IntegralHeight = false;
            this.cbProdi.ItemHeight = 28;
            this.cbProdi.Location = new System.Drawing.Point(1006, 591);
            this.cbProdi.Name = "cbProdi";
            this.cbProdi.Size = new System.Drawing.Size(217, 36);
            this.cbProdi.TabIndex = 129;
            this.cbProdi.ValueMember = "Id_Prodi";
            // 
            // programStudiBindingSource4
            // 
            this.programStudiBindingSource4.DataMember = "ProgramStudi";
            this.programStudiBindingSource4.DataSource = this.dATASETDEANBindingSource;
            // 
            // programStudiBindingSource3
            // 
            this.programStudiBindingSource3.DataMember = "ProgramStudi";
            this.programStudiBindingSource3.DataSource = this.fINDSMART_MABRESDataSet1;
            // 
            // programStudiBindingSource2
            // 
            this.programStudiBindingSource2.DataMember = "ProgramStudi";
            this.programStudiBindingSource2.DataSource = this.fINDSMART_MABRESDsAll;
            // 
            // programStudiBindingSource
            // 
            this.programStudiBindingSource.DataMember = "ProgramStudi";
            this.programStudiBindingSource.DataSource = this.fINDSMARTDataSet7;
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
            this.btnBatal.Location = new System.Drawing.Point(1172, 518);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(95, 28);
            this.btnBatal.TabIndex = 130;
            this.btnBatal.Text = "Batal";
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // mataKuliahTableAdapter
            // 
            this.mataKuliahTableAdapter.ClearBeforeFill = true;
            // 
            // dosenTableAdapter
            // 
            this.dosenTableAdapter.ClearBeforeFill = true;
            // 
            // programStudiTableAdapter
            // 
            this.programStudiTableAdapter.ClearBeforeFill = true;
            // 
            // btnRefersh
            // 
            this.btnRefersh.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnRefersh.HoverState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnRefersh.Image = global::PROJECT_PRG2.Properties.Resources.refresh_594822;
            this.btnRefersh.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnRefersh.ImageRotate = 0F;
            this.btnRefersh.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefersh.Location = new System.Drawing.Point(1279, 506);
            this.btnRefersh.Name = "btnRefersh";
            this.btnRefersh.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnRefersh.Size = new System.Drawing.Size(45, 51);
            this.btnRefersh.TabIndex = 249;
            this.btnRefersh.Click += new System.EventHandler(this.btnRefersh_Click);
            // 
            // mataKuliahTableAdapter1
            // 
            this.mataKuliahTableAdapter1.ClearBeforeFill = true;
            // 
            // programStudiTableAdapter1
            // 
            this.programStudiTableAdapter1.ClearBeforeFill = true;
            // 
            // dosenTableAdapter1
            // 
            this.dosenTableAdapter1.ClearBeforeFill = true;
            // 
            // mataKuliahTableAdapter2
            // 
            this.mataKuliahTableAdapter2.ClearBeforeFill = true;
            // 
            // programStudiTableAdapter2
            // 
            this.programStudiTableAdapter2.ClearBeforeFill = true;
            // 
            // dosenTableAdapter2
            // 
            this.dosenTableAdapter2.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(729, 660);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 28);
            this.label4.TabIndex = 251;
            this.label4.Text = "Kelas";
            // 
            // txtKelas
            // 
            this.txtKelas.Animated = true;
            this.txtKelas.BackColor = System.Drawing.Color.Transparent;
            this.txtKelas.BorderColor = System.Drawing.Color.Black;
            this.txtKelas.BorderRadius = 10;
            this.txtKelas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKelas.DefaultText = "";
            this.txtKelas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKelas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKelas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKelas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKelas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKelas.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKelas.ForeColor = System.Drawing.Color.Black;
            this.txtKelas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKelas.Location = new System.Drawing.Point(711, 691);
            this.txtKelas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKelas.Name = "txtKelas";
            this.txtKelas.PasswordChar = '\0';
            this.txtKelas.PlaceholderText = "";
            this.txtKelas.SelectedText = "";
            this.txtKelas.Size = new System.Drawing.Size(243, 41);
            this.txtKelas.TabIndex = 250;
            // 
            // mataKuliahTableAdapter3
            // 
            this.mataKuliahTableAdapter3.ClearBeforeFill = true;
            // 
            // programStudiTableAdapter3
            // 
            this.programStudiTableAdapter3.ClearBeforeFill = true;
            // 
            // dosenTableAdapter3
            // 
            this.dosenTableAdapter3.ClearBeforeFill = true;
            // 
            // ViewMatkul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1376, 1033);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKelas);
            this.Controls.Add(this.btnRefersh);
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
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
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
            ((System.ComponentModel.ISupportInitialize)(this.mataKuliahBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATASETDEANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATASET_DEAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataKuliahBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMART_MABRESDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataKuliahBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMART_MABRESDsAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataKuliahBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosenBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosenBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosenBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView gdvMatkul;
        private Guna.UI2.WinForms.Guna2TextBox txtCari;
        private Guna.UI2.WinForms.Guna2ImageButton btnCari;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSemester;
        private Guna.UI2.WinForms.Guna2TextBox txtJenis;
        private Guna.UI2.WinForms.Guna2TextBox txtSKS;
        private Guna.UI2.WinForms.Guna2TextBox txtNama;
        private Guna.UI2.WinForms.Guna2TextBox txtIdMatkul;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ImageButton btnHapus;
        private Guna.UI2.WinForms.Guna2ImageButton btnUpdate;
        private Guna.UI2.WinForms.Guna2ImageButton btnTambah;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.ComboBox cbPegawai;
        private System.Windows.Forms.ComboBox cbProdi;
        private System.Windows.Forms.BindingSource programStudiBindingSource1;
        private Guna.UI2.WinForms.Guna2Button btnBatal;
        private FINDSMARTDataSet7 fINDSMARTDataSet7;
        private System.Windows.Forms.BindingSource mataKuliahBindingSource;
        private FINDSMARTDataSet7TableAdapters.MataKuliahTableAdapter mataKuliahTableAdapter;
        private System.Windows.Forms.BindingSource dosenBindingSource;
        private FINDSMARTDataSet7TableAdapters.DosenTableAdapter dosenTableAdapter;
        private System.Windows.Forms.BindingSource programStudiBindingSource;
        private FINDSMARTDataSet7TableAdapters.ProgramStudiTableAdapter programStudiTableAdapter;
        private Guna.UI2.WinForms.Guna2ImageButton btnRefersh;
        private FINDSMART_MABRESDsAll fINDSMART_MABRESDsAll;
        private System.Windows.Forms.BindingSource mataKuliahBindingSource1;
        private FINDSMART_MABRESDsAllTableAdapters.MataKuliahTableAdapter mataKuliahTableAdapter1;
        private System.Windows.Forms.BindingSource programStudiBindingSource2;
        private FINDSMART_MABRESDsAllTableAdapters.ProgramStudiTableAdapter programStudiTableAdapter1;
        private System.Windows.Forms.BindingSource dosenBindingSource1;
        private FINDSMART_MABRESDsAllTableAdapters.DosenTableAdapter dosenTableAdapter1;
        private FINDSMART_MABRESDataSet1 fINDSMART_MABRESDataSet1;
        private System.Windows.Forms.BindingSource mataKuliahBindingSource2;
        private FINDSMART_MABRESDataSet1TableAdapters.MataKuliahTableAdapter mataKuliahTableAdapter2;
        private System.Windows.Forms.BindingSource programStudiBindingSource3;
        private FINDSMART_MABRESDataSet1TableAdapters.ProgramStudiTableAdapter programStudiTableAdapter2;
        private System.Windows.Forms.BindingSource dosenBindingSource2;
        private FINDSMART_MABRESDataSet1TableAdapters.DosenTableAdapter dosenTableAdapter2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtKelas;
        private System.Windows.Forms.BindingSource dATASETDEANBindingSource;
        private DATASET_DEAN dATASET_DEAN;
        private System.Windows.Forms.BindingSource mataKuliahBindingSource3;
        private DATASET_DEANTableAdapters.MataKuliahTableAdapter mataKuliahTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMatkulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahSKSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Prodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_Pegawai;
        private System.Windows.Forms.BindingSource programStudiBindingSource4;
        private DATASET_DEANTableAdapters.ProgramStudiTableAdapter programStudiTableAdapter3;
        private System.Windows.Forms.BindingSource dosenBindingSource3;
        private DATASET_DEANTableAdapters.DosenTableAdapter dosenTableAdapter3;
    }
}