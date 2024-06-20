namespace PROJECT_PRG2.CRUD_Dosen
{
    partial class ViewDosen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDosen = new Guna.UI2.WinForms.Guna2DataGridView();
            this.noPegawaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIDNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidangKompetensiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendidikanTerakhirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalLahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisKelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teleponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fINDSMARTDataSet = new PROJECT_PRG2.FINDSMARTDataSet();
            this.dosenTableAdapter = new PROJECT_PRG2.FINDSMARTDataSetTableAdapters.DosenTableAdapter();
            this.btnTampil = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDosen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDosen
            // 
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            this.dgvDosen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvDosen.AutoGenerateColumns = false;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDosen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvDosen.ColumnHeadersHeight = 45;
            this.dgvDosen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDosen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noPegawaiDataGridViewTextBoxColumn,
            this.nIDNDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.bidangKompetensiDataGridViewTextBoxColumn,
            this.pendidikanTerakhirDataGridViewTextBoxColumn,
            this.tanggalLahirDataGridViewTextBoxColumn,
            this.jenisKelaminDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.teleponDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvDosen.DataSource = this.dosenBindingSource;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDosen.DefaultCellStyle = dataGridViewCellStyle44;
            this.dgvDosen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDosen.Location = new System.Drawing.Point(248, 222);
            this.dgvDosen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDosen.Name = "dgvDosen";
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle45.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDosen.RowHeadersDefaultCellStyle = dataGridViewCellStyle45;
            this.dgvDosen.RowHeadersVisible = false;
            this.dgvDosen.RowHeadersWidth = 62;
            this.dgvDosen.RowTemplate.Height = 28;
            this.dgvDosen.Size = new System.Drawing.Size(1551, 581);
            this.dgvDosen.TabIndex = 0;
            this.dgvDosen.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDosen.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDosen.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDosen.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDosen.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDosen.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDosen.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDosen.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDosen.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDosen.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDosen.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDosen.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDosen.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvDosen.ThemeStyle.ReadOnly = false;
            this.dgvDosen.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDosen.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDosen.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDosen.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDosen.ThemeStyle.RowsStyle.Height = 28;
            this.dgvDosen.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDosen.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // noPegawaiDataGridViewTextBoxColumn
            // 
            this.noPegawaiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noPegawaiDataGridViewTextBoxColumn.DataPropertyName = "No_Pegawai";
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noPegawaiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle33;
            this.noPegawaiDataGridViewTextBoxColumn.HeaderText = "No Pegawai";
            this.noPegawaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.noPegawaiDataGridViewTextBoxColumn.Name = "noPegawaiDataGridViewTextBoxColumn";
            // 
            // nIDNDataGridViewTextBoxColumn
            // 
            this.nIDNDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nIDNDataGridViewTextBoxColumn.DataPropertyName = "NIDN";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nIDNDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle34;
            this.nIDNDataGridViewTextBoxColumn.HeaderText = "NIDN";
            this.nIDNDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nIDNDataGridViewTextBoxColumn.Name = "nIDNDataGridViewTextBoxColumn";
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle35;
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // bidangKompetensiDataGridViewTextBoxColumn
            // 
            this.bidangKompetensiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bidangKompetensiDataGridViewTextBoxColumn.DataPropertyName = "Bidang_Kompetensi";
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bidangKompetensiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle36;
            this.bidangKompetensiDataGridViewTextBoxColumn.HeaderText = "Bidang Kompetensi";
            this.bidangKompetensiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bidangKompetensiDataGridViewTextBoxColumn.Name = "bidangKompetensiDataGridViewTextBoxColumn";
            // 
            // pendidikanTerakhirDataGridViewTextBoxColumn
            // 
            this.pendidikanTerakhirDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pendidikanTerakhirDataGridViewTextBoxColumn.DataPropertyName = "Pendidikan_Terakhir";
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendidikanTerakhirDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle37;
            this.pendidikanTerakhirDataGridViewTextBoxColumn.HeaderText = "Pendidikan Terakhir";
            this.pendidikanTerakhirDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pendidikanTerakhirDataGridViewTextBoxColumn.Name = "pendidikanTerakhirDataGridViewTextBoxColumn";
            // 
            // tanggalLahirDataGridViewTextBoxColumn
            // 
            this.tanggalLahirDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tanggalLahirDataGridViewTextBoxColumn.DataPropertyName = "Tanggal_Lahir";
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggalLahirDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle38;
            this.tanggalLahirDataGridViewTextBoxColumn.HeaderText = "Tanggal Lahir";
            this.tanggalLahirDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tanggalLahirDataGridViewTextBoxColumn.Name = "tanggalLahirDataGridViewTextBoxColumn";
            // 
            // jenisKelaminDataGridViewTextBoxColumn
            // 
            this.jenisKelaminDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jenisKelaminDataGridViewTextBoxColumn.DataPropertyName = "Jenis_Kelamin";
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jenisKelaminDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle39;
            this.jenisKelaminDataGridViewTextBoxColumn.HeaderText = "Jenis Kelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jenisKelaminDataGridViewTextBoxColumn.Name = "jenisKelaminDataGridViewTextBoxColumn";
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle40;
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle41;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // teleponDataGridViewTextBoxColumn
            // 
            this.teleponDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teleponDataGridViewTextBoxColumn.DataPropertyName = "Telepon";
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teleponDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle42;
            this.teleponDataGridViewTextBoxColumn.HeaderText = "Telepon";
            this.teleponDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.teleponDataGridViewTextBoxColumn.Name = "teleponDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle43;
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // dosenBindingSource
            // 
            this.dosenBindingSource.DataMember = "Dosen";
            this.dosenBindingSource.DataSource = this.fINDSMARTDataSet;
            // 
            // fINDSMARTDataSet
            // 
            this.fINDSMARTDataSet.DataSetName = "FINDSMARTDataSet";
            this.fINDSMARTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dosenTableAdapter
            // 
            this.dosenTableAdapter.ClearBeforeFill = true;
            // 
            // btnTampil
            // 
            this.btnTampil.AutoRoundedCorners = true;
            this.btnTampil.BackColor = System.Drawing.Color.Transparent;
            this.btnTampil.BorderRadius = 25;
            this.btnTampil.BorderThickness = -1;
            this.btnTampil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTampil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTampil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTampil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTampil.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTampil.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.btnTampil.ForeColor = System.Drawing.Color.White;
            this.btnTampil.Location = new System.Drawing.Point(935, 849);
            this.btnTampil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(174, 52);
            this.btnTampil.TabIndex = 20;
            this.btnTampil.Text = "Tampilkan";
            this.btnTampil.UseTransparentBackground = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // ViewDosen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJECT_PRG2.Properties.Resources.Lihat_Dosen_FIND_SMART;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.dgvDosen);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewDosen";
            this.Text = "View Dosen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewDosen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDosen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvDosen;
        private FINDSMARTDataSet fINDSMARTDataSet;
        private System.Windows.Forms.BindingSource dosenBindingSource;
        private FINDSMARTDataSetTableAdapters.DosenTableAdapter dosenTableAdapter;
        private Guna.UI2.WinForms.Guna2Button btnTampil;
        private System.Windows.Forms.DataGridViewTextBoxColumn noPegawaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIDNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidangKompetensiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendidikanTerakhirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalLahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisKelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teleponDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}