using System;
using System.Windows.Forms;

namespace PROJECT_PRG2.CRUD_Prodi
{
    partial class UpDelet_Prodi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpDelet_Prodi));
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAkreditasi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtJenjangPendidikan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdProdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtgProdi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idProdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenjangPendidikanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.akreditasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programStudiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fINDSMART_MABRESDataSet1 = new PROJECT_PRG2.FINDSMART_MABRESDataSet1();
            this.programStudiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fINDSMART_MABRESDsAll = new PROJECT_PRG2.FINDSMART_MABRESDsAll();
            this.programStudiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fINDSMARTDataSet7 = new PROJECT_PRG2.FINDSMARTDataSet7();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnHapus = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnTambah = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnCari = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnBatal = new Guna.UI2.WinForms.Guna2Button();
            this.txtCari = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.programStudiTableAdapter = new PROJECT_PRG2.FINDSMARTDataSet7TableAdapters.ProgramStudiTableAdapter();
            this.programStudiTableAdapter1 = new PROJECT_PRG2.FINDSMART_MABRESDsAllTableAdapters.ProgramStudiTableAdapter();
            this.btnRefersh = new Guna.UI2.WinForms.Guna2ImageButton();
            this.programStudiTableAdapter2 = new PROJECT_PRG2.FINDSMART_MABRESDataSet1TableAdapters.ProgramStudiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMART_MABRESDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMART_MABRESDsAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(428, 625);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 28);
            this.label3.TabIndex = 194;
            this.label3.Text = "Nama";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(704, 626);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(178, 28);
            this.label14.TabIndex = 188;
            this.label14.Text = "Jenjang Pendidikan";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(973, 626);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 28);
            this.label15.TabIndex = 187;
            this.label15.Text = "Akreditasi";
            // 
            // txtAkreditasi
            // 
            this.txtAkreditasi.Animated = true;
            this.txtAkreditasi.BackColor = System.Drawing.Color.Transparent;
            this.txtAkreditasi.BorderColor = System.Drawing.Color.Black;
            this.txtAkreditasi.BorderRadius = 10;
            this.txtAkreditasi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAkreditasi.DefaultText = "";
            this.txtAkreditasi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAkreditasi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAkreditasi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAkreditasi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAkreditasi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAkreditasi.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAkreditasi.ForeColor = System.Drawing.Color.Black;
            this.txtAkreditasi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAkreditasi.Location = new System.Drawing.Point(968, 659);
            this.txtAkreditasi.Margin = new System.Windows.Forms.Padding(5);
            this.txtAkreditasi.Name = "txtAkreditasi";
            this.txtAkreditasi.PasswordChar = '\0';
            this.txtAkreditasi.PlaceholderText = "";
            this.txtAkreditasi.SelectedText = "";
            this.txtAkreditasi.Size = new System.Drawing.Size(243, 41);
            this.txtAkreditasi.TabIndex = 181;
            this.txtAkreditasi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAkreditasi_KeyPress_1);
            // 
            // txtJenjangPendidikan
            // 
            this.txtJenjangPendidikan.Animated = true;
            this.txtJenjangPendidikan.BackColor = System.Drawing.Color.Transparent;
            this.txtJenjangPendidikan.BorderColor = System.Drawing.Color.Black;
            this.txtJenjangPendidikan.BorderRadius = 10;
            this.txtJenjangPendidikan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJenjangPendidikan.DefaultText = "";
            this.txtJenjangPendidikan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtJenjangPendidikan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtJenjangPendidikan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJenjangPendidikan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJenjangPendidikan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJenjangPendidikan.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJenjangPendidikan.ForeColor = System.Drawing.Color.Black;
            this.txtJenjangPendidikan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJenjangPendidikan.Location = new System.Drawing.Point(699, 659);
            this.txtJenjangPendidikan.Margin = new System.Windows.Forms.Padding(5);
            this.txtJenjangPendidikan.Name = "txtJenjangPendidikan";
            this.txtJenjangPendidikan.PasswordChar = '\0';
            this.txtJenjangPendidikan.PlaceholderText = "";
            this.txtJenjangPendidikan.SelectedText = "";
            this.txtJenjangPendidikan.Size = new System.Drawing.Size(243, 41);
            this.txtJenjangPendidikan.TabIndex = 180;
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
            this.txtNama.Location = new System.Drawing.Point(423, 659);
            this.txtNama.Margin = new System.Windows.Forms.Padding(5);
            this.txtNama.Name = "txtNama";
            this.txtNama.PasswordChar = '\0';
            this.txtNama.PlaceholderText = "";
            this.txtNama.SelectedText = "";
            this.txtNama.Size = new System.Drawing.Size(243, 41);
            this.txtNama.TabIndex = 173;
            this.txtNama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNama_KeyPress_1);
            // 
            // txtIdProdi
            // 
            this.txtIdProdi.Animated = true;
            this.txtIdProdi.BackColor = System.Drawing.Color.Transparent;
            this.txtIdProdi.BorderColor = System.Drawing.Color.Black;
            this.txtIdProdi.BorderRadius = 10;
            this.txtIdProdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdProdi.DefaultText = "";
            this.txtIdProdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdProdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdProdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdProdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdProdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdProdi.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProdi.ForeColor = System.Drawing.Color.Black;
            this.txtIdProdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdProdi.Location = new System.Drawing.Point(146, 659);
            this.txtIdProdi.Margin = new System.Windows.Forms.Padding(5);
            this.txtIdProdi.Name = "txtIdProdi";
            this.txtIdProdi.PasswordChar = '\0';
            this.txtIdProdi.PlaceholderText = "";
            this.txtIdProdi.ReadOnly = true;
            this.txtIdProdi.SelectedText = "";
            this.txtIdProdi.Size = new System.Drawing.Size(243, 41);
            this.txtIdProdi.TabIndex = 172;
            // 
            // dtgProdi
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dtgProdi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgProdi.AutoGenerateColumns = false;
            this.dtgProdi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProdi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgProdi.ColumnHeadersHeight = 30;
            this.dtgProdi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgProdi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdiDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.jenjangPendidikanDataGridViewTextBoxColumn,
            this.akreditasiDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dtgProdi.DataSource = this.programStudiBindingSource2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgProdi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgProdi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dtgProdi.Location = new System.Drawing.Point(64, 93);
            this.dtgProdi.Margin = new System.Windows.Forms.Padding(2);
            this.dtgProdi.Name = "dtgProdi";
            this.dtgProdi.RowHeadersVisible = false;
            this.dtgProdi.RowHeadersWidth = 51;
            this.dtgProdi.RowTemplate.Height = 24;
            this.dtgProdi.Size = new System.Drawing.Size(1242, 442);
            this.dtgProdi.TabIndex = 200;
            this.dtgProdi.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.dtgProdi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dtgProdi.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgProdi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgProdi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgProdi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgProdi.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgProdi.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dtgProdi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.dtgProdi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dtgProdi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgProdi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgProdi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgProdi.ThemeStyle.HeaderStyle.Height = 30;
            this.dtgProdi.ThemeStyle.ReadOnly = false;
            this.dtgProdi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.dtgProdi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgProdi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgProdi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgProdi.ThemeStyle.RowsStyle.Height = 24;
            this.dtgProdi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.dtgProdi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // idProdiDataGridViewTextBoxColumn
            // 
            this.idProdiDataGridViewTextBoxColumn.DataPropertyName = "Id_Prodi";
            this.idProdiDataGridViewTextBoxColumn.HeaderText = "ID Prodi";
            this.idProdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idProdiDataGridViewTextBoxColumn.Name = "idProdiDataGridViewTextBoxColumn";
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // jenjangPendidikanDataGridViewTextBoxColumn
            // 
            this.jenjangPendidikanDataGridViewTextBoxColumn.DataPropertyName = "Jenjang_Pendidikan";
            this.jenjangPendidikanDataGridViewTextBoxColumn.HeaderText = "Jenjang Pendidikan";
            this.jenjangPendidikanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jenjangPendidikanDataGridViewTextBoxColumn.Name = "jenjangPendidikanDataGridViewTextBoxColumn";
            // 
            // akreditasiDataGridViewTextBoxColumn
            // 
            this.akreditasiDataGridViewTextBoxColumn.DataPropertyName = "Akreditasi";
            this.akreditasiDataGridViewTextBoxColumn.HeaderText = "Akreditasi";
            this.akreditasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.akreditasiDataGridViewTextBoxColumn.Name = "akreditasiDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // programStudiBindingSource2
            // 
            this.programStudiBindingSource2.DataMember = "ProgramStudi";
            this.programStudiBindingSource2.DataSource = this.fINDSMART_MABRESDataSet1;
            // 
            // fINDSMART_MABRESDataSet1
            // 
            this.fINDSMART_MABRESDataSet1.DataSetName = "FINDSMART_MABRESDataSet1";
            this.fINDSMART_MABRESDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // programStudiBindingSource1
            // 
            this.programStudiBindingSource1.DataMember = "ProgramStudi";
            this.programStudiBindingSource1.DataSource = this.fINDSMART_MABRESDsAll;
            // 
            // fINDSMART_MABRESDsAll
            // 
            this.fINDSMART_MABRESDsAll.DataSetName = "FINDSMART_MABRESDsAll";
            this.fINDSMART_MABRESDsAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // programStudiBindingSource
            // 
            this.programStudiBindingSource.DataMember = "ProgramStudi";
            this.programStudiBindingSource.DataSource = this.fINDSMARTDataSet7;
            // 
            // fINDSMARTDataSet7
            // 
            this.fINDSMARTDataSet7.DataSetName = "FINDSMARTDataSet7";
            this.fINDSMARTDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(982, 724);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 28);
            this.label2.TabIndex = 213;
            this.label2.Text = "Aksi";
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
            this.guna2TextBox1.Location = new System.Drawing.Point(979, 755);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(205, 43);
            this.guna2TextBox1.TabIndex = 212;
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
            this.btnHapus.Location = new System.Drawing.Point(1127, 758);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnHapus.Size = new System.Drawing.Size(36, 36);
            this.btnHapus.TabIndex = 211;
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
            this.btnUpdate.Location = new System.Drawing.Point(1058, 760);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnUpdate.Size = new System.Drawing.Size(37, 33);
            this.btnUpdate.TabIndex = 210;
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
            this.btnTambah.Location = new System.Drawing.Point(994, 758);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(2);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnTambah.Size = new System.Drawing.Size(36, 36);
            this.btnTambah.TabIndex = 209;
            this.btnTambah.UseTransparentBackground = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.Transparent;
            this.btnCari.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCari.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnCari.Image = global::PROJECT_PRG2.Properties.Resources.cari;
            this.btnCari.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCari.ImageRotate = 0F;
            this.btnCari.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCari.Location = new System.Drawing.Point(483, 20);
            this.btnCari.Margin = new System.Windows.Forms.Padding(2);
            this.btnCari.Name = "btnCari";
            this.btnCari.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnCari.Size = new System.Drawing.Size(42, 37);
            this.btnCari.TabIndex = 208;
            this.btnCari.UseTransparentBackground = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
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
            this.btnBatal.Location = new System.Drawing.Point(1173, 846);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(133, 28);
            this.btnBatal.TabIndex = 214;
            this.btnBatal.Text = "Batal";
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
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
            this.txtCari.Location = new System.Drawing.Point(532, 21);
            this.txtCari.Margin = new System.Windows.Forms.Padding(5);
            this.txtCari.Name = "txtCari";
            this.txtCari.PasswordChar = '\0';
            this.txtCari.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCari.PlaceholderText = "Cari Data Program Studi";
            this.txtCari.SelectedText = "";
            this.txtCari.Size = new System.Drawing.Size(362, 36);
            this.txtCari.TabIndex = 172;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(153, 627);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 28);
            this.label1.TabIndex = 215;
            this.label1.Text = "Id Prodi";
            // 
            // programStudiTableAdapter
            // 
            this.programStudiTableAdapter.ClearBeforeFill = true;
            // 
            // programStudiTableAdapter1
            // 
            this.programStudiTableAdapter1.ClearBeforeFill = true;
            // 
            // btnRefersh
            // 
            this.btnRefersh.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnRefersh.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnRefersh.Image = global::PROJECT_PRG2.Properties.Resources.refresh_594822;
            this.btnRefersh.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnRefersh.ImageRotate = 0F;
            this.btnRefersh.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefersh.Location = new System.Drawing.Point(1261, 558);
            this.btnRefersh.Name = "btnRefersh";
            this.btnRefersh.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnRefersh.Size = new System.Drawing.Size(45, 51);
            this.btnRefersh.TabIndex = 252;
            this.btnRefersh.Click += new System.EventHandler(this.btnRefersh_Click);
            // 
            // programStudiTableAdapter2
            // 
            this.programStudiTableAdapter2.ClearBeforeFill = true;
            // 
            // UpDelet_Prodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1376, 1033);
            this.Controls.Add(this.btnRefersh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.dtgProdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtAkreditasi);
            this.Controls.Add(this.txtJenjangPendidikan);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.txtIdProdi);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpDelet_Prodi";
            this.Text = "UpDelet_Prodi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UpDelet_Prodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMART_MABRESDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMART_MABRESDsAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void txtAkreditasi_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2TextBox txtAkreditasi;
        private Guna.UI2.WinForms.Guna2TextBox txtJenjangPendidikan;
        private Guna.UI2.WinForms.Guna2TextBox txtNama;
        private Guna.UI2.WinForms.Guna2TextBox txtIdProdi;
        private Guna.UI2.WinForms.Guna2DataGridView dtgProdi;
        private FINDSMARTDataSet7 fINDSMARTDataSet7;
        private System.Windows.Forms.BindingSource programStudiBindingSource;
        private FINDSMARTDataSet7TableAdapters.ProgramStudiTableAdapter programStudiTableAdapter;
        private DataGridViewTextBoxColumn idProdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jenjangPendidikanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn akreditasiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2ImageButton btnCari;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton btnHapus;
        private Guna.UI2.WinForms.Guna2ImageButton btnUpdate;
        private Guna.UI2.WinForms.Guna2ImageButton btnTambah;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button btnBatal;
        private Guna.UI2.WinForms.Guna2TextBox txtCari;
        private System.Windows.Forms.Label label1;
        private FINDSMART_MABRESDsAll fINDSMART_MABRESDsAll;
        private BindingSource programStudiBindingSource1;
        private FINDSMART_MABRESDsAllTableAdapters.ProgramStudiTableAdapter programStudiTableAdapter1;
        private Guna.UI2.WinForms.Guna2ImageButton btnRefersh;
        private FINDSMART_MABRESDataSet1 fINDSMART_MABRESDataSet1;
        private BindingSource programStudiBindingSource2;
        private FINDSMART_MABRESDataSet1TableAdapters.ProgramStudiTableAdapter programStudiTableAdapter2;
    }
}