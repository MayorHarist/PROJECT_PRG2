namespace PROJECT_PRG2.CRUD_Prodi
{
    partial class View_Prodi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTampilkan = new Guna.UI2.WinForms.Guna2Button();
            this.fINDSMART = new PROJECT_PRG2.FINDSMART();
            this.programStudiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programStudiTableAdapter = new PROJECT_PRG2.FINDSMARTTableAdapters.ProgramStudiTableAdapter();
            this.idProdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenjangPendidikanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.akreditasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fINDSMARTDataSet3 = new PROJECT_PRG2.FINDSMARTDataSet3();
            this.programStudiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.programStudiTableAdapter1 = new PROJECT_PRG2.FINDSMARTDataSet3TableAdapters.ProgramStudiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMART)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdiDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.jenjangPendidikanDataGridViewTextBoxColumn,
            this.akreditasiDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.programStudiBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(404, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Animated = true;
            this.btnTampilkan.AutoRoundedCorners = true;
            this.btnTampilkan.BorderRadius = 21;
            this.btnTampilkan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTampilkan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTampilkan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTampilkan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTampilkan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTampilkan.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.btnTampilkan.ForeColor = System.Drawing.Color.White;
            this.btnTampilkan.Location = new System.Drawing.Point(558, 349);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(180, 45);
            this.btnTampilkan.TabIndex = 1;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // fINDSMART
            // 
            this.fINDSMART.DataSetName = "FINDSMART";
            this.fINDSMART.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // programStudiBindingSource
            // 
            this.programStudiBindingSource.DataMember = "ProgramStudi";
            this.programStudiBindingSource.DataSource = this.fINDSMART;
            // 
            // programStudiTableAdapter
            // 
            this.programStudiTableAdapter.ClearBeforeFill = true;
            // 
            // idProdiDataGridViewTextBoxColumn
            // 
            this.idProdiDataGridViewTextBoxColumn.DataPropertyName = "Id_Prodi";
            this.idProdiDataGridViewTextBoxColumn.HeaderText = "Id_Prodi";
            this.idProdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idProdiDataGridViewTextBoxColumn.Name = "idProdiDataGridViewTextBoxColumn";
            this.idProdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.Width = 125;
            // 
            // jenjangPendidikanDataGridViewTextBoxColumn
            // 
            this.jenjangPendidikanDataGridViewTextBoxColumn.DataPropertyName = "Jenjang_Pendidikan";
            this.jenjangPendidikanDataGridViewTextBoxColumn.HeaderText = "Jenjang_Pendidikan";
            this.jenjangPendidikanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jenjangPendidikanDataGridViewTextBoxColumn.Name = "jenjangPendidikanDataGridViewTextBoxColumn";
            this.jenjangPendidikanDataGridViewTextBoxColumn.Width = 125;
            // 
            // akreditasiDataGridViewTextBoxColumn
            // 
            this.akreditasiDataGridViewTextBoxColumn.DataPropertyName = "Akreditasi";
            this.akreditasiDataGridViewTextBoxColumn.HeaderText = "Akreditasi";
            this.akreditasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.akreditasiDataGridViewTextBoxColumn.Name = "akreditasiDataGridViewTextBoxColumn";
            this.akreditasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // fINDSMARTDataSet3
            // 
            this.fINDSMARTDataSet3.DataSetName = "FINDSMARTDataSet3";
            this.fINDSMARTDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // programStudiBindingSource1
            // 
            this.programStudiBindingSource1.DataMember = "ProgramStudi";
            this.programStudiBindingSource1.DataSource = this.fINDSMARTDataSet3;
            // 
            // programStudiTableAdapter1
            // 
            this.programStudiTableAdapter1.ClearBeforeFill = true;
            // 
            // View_Prodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.dataGridView1);
            this.Name = "View_Prodi";
            this.Text = "View_Prodi";
            this.Load += new System.EventHandler(this.View_Prodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMART)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button btnTampilkan;
        private FINDSMART fINDSMART;
        private System.Windows.Forms.BindingSource programStudiBindingSource;
        private FINDSMARTTableAdapters.ProgramStudiTableAdapter programStudiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenjangPendidikanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn akreditasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private FINDSMARTDataSet3 fINDSMARTDataSet3;
        private System.Windows.Forms.BindingSource programStudiBindingSource1;
        private FINDSMARTDataSet3TableAdapters.ProgramStudiTableAdapter programStudiTableAdapter1;
    }
}