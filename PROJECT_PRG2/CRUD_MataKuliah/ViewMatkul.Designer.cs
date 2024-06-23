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
            this.gdvMatkul = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnTampil = new Guna.UI2.WinForms.Guna2Button();
            this.fINDSMARTDataSet6 = new PROJECT_PRG2.FINDSMARTDataSet6();
            this.mataKuliahBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mataKuliahTableAdapter = new PROJECT_PRG2.FINDSMARTDataSet6TableAdapters.MataKuliahTableAdapter();
            this.idMatkulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahSKSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noPegawaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMatkul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataKuliahBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvMatkul
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gdvMatkul.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdvMatkul.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvMatkul.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdvMatkul.ColumnHeadersHeight = 25;
            this.gdvMatkul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvMatkul.DefaultCellStyle = dataGridViewCellStyle3;
            this.gdvMatkul.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdvMatkul.Location = new System.Drawing.Point(344, 252);
            this.gdvMatkul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gdvMatkul.Name = "gdvMatkul";
            this.gdvMatkul.RowHeadersVisible = false;
            this.gdvMatkul.RowHeadersWidth = 62;
            this.gdvMatkul.RowTemplate.Height = 28;
            this.gdvMatkul.Size = new System.Drawing.Size(1362, 567);
            this.gdvMatkul.TabIndex = 0;
            this.gdvMatkul.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gdvMatkul.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gdvMatkul.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gdvMatkul.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gdvMatkul.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gdvMatkul.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gdvMatkul.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdvMatkul.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gdvMatkul.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gdvMatkul.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvMatkul.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdvMatkul.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdvMatkul.ThemeStyle.HeaderStyle.Height = 25;
            this.gdvMatkul.ThemeStyle.ReadOnly = false;
            this.gdvMatkul.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdvMatkul.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvMatkul.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvMatkul.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdvMatkul.ThemeStyle.RowsStyle.Height = 28;
            this.gdvMatkul.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdvMatkul.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnTampil
            // 
            this.btnTampil.AutoRoundedCorners = true;
            this.btnTampil.BackColor = System.Drawing.Color.Transparent;
            this.btnTampil.BorderRadius = 25;
            this.btnTampil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTampil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTampil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTampil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTampil.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTampil.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.btnTampil.ForeColor = System.Drawing.Color.White;
            this.btnTampil.Location = new System.Drawing.Point(914, 902);
            this.btnTampil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(225, 53);
            this.btnTampil.TabIndex = 21;
            this.btnTampil.Text = "Tampilkan";
            this.btnTampil.UseTransparentBackground = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // fINDSMARTDataSet6
            // 
            this.fINDSMARTDataSet6.DataSetName = "FINDSMARTDataSet6";
            this.fINDSMARTDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mataKuliahBindingSource
            // 
            this.mataKuliahBindingSource.DataMember = "MataKuliah";
            this.mataKuliahBindingSource.DataSource = this.fINDSMARTDataSet6;
            // 
            // mataKuliahTableAdapter
            // 
            this.mataKuliahTableAdapter.ClearBeforeFill = true;
            // 
            // idMatkulDataGridViewTextBoxColumn
            // 
            this.idMatkulDataGridViewTextBoxColumn.DataPropertyName = "Id_Matkul";
            this.idMatkulDataGridViewTextBoxColumn.HeaderText = "Id_Matkul";
            this.idMatkulDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idMatkulDataGridViewTextBoxColumn.Name = "idMatkulDataGridViewTextBoxColumn";
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // jumlahSKSDataGridViewTextBoxColumn
            // 
            this.jumlahSKSDataGridViewTextBoxColumn.DataPropertyName = "Jumlah_SKS";
            this.jumlahSKSDataGridViewTextBoxColumn.HeaderText = "Jumlah_SKS";
            this.jumlahSKSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jumlahSKSDataGridViewTextBoxColumn.Name = "jumlahSKSDataGridViewTextBoxColumn";
            // 
            // jenisDataGridViewTextBoxColumn
            // 
            this.jenisDataGridViewTextBoxColumn.DataPropertyName = "Jenis";
            this.jenisDataGridViewTextBoxColumn.HeaderText = "Jenis";
            this.jenisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jenisDataGridViewTextBoxColumn.Name = "jenisDataGridViewTextBoxColumn";
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Semester";
            this.semesterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // noPegawaiDataGridViewTextBoxColumn
            // 
            this.noPegawaiDataGridViewTextBoxColumn.DataPropertyName = "No_Pegawai";
            this.noPegawaiDataGridViewTextBoxColumn.HeaderText = "No_Pegawai";
            this.noPegawaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noPegawaiDataGridViewTextBoxColumn.Name = "noPegawaiDataGridViewTextBoxColumn";
            // 
            // idProdiDataGridViewTextBoxColumn
            // 
            this.idProdiDataGridViewTextBoxColumn.DataPropertyName = "Id_Prodi";
            this.idProdiDataGridViewTextBoxColumn.HeaderText = "Id_Prodi";
            this.idProdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idProdiDataGridViewTextBoxColumn.Name = "idProdiDataGridViewTextBoxColumn";
            // 
            // ViewMatkul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJECT_PRG2.Properties.Resources.Lihat_Matkul_FIND_SMART;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.gdvMatkul);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewMatkul";
            this.Text = "ViewMatkul";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewMatkul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvMatkul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataKuliahBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView gdvMatkul;
        private Guna.UI2.WinForms.Guna2Button btnTampil;
        private FINDSMARTDataSet6 fINDSMARTDataSet6;
        private System.Windows.Forms.BindingSource mataKuliahBindingSource;
        private FINDSMARTDataSet6TableAdapters.MataKuliahTableAdapter mataKuliahTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMatkulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahSKSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noPegawaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdiDataGridViewTextBoxColumn;
    }
}