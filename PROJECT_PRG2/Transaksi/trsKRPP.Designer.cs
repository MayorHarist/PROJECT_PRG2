namespace PROJECT_PRG2.Transaksi
{
    partial class trsKRPP
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
            this.dgKRPP = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnTambah = new Guna.UI2.WinForms.Guna2Button();
            this.btnCari = new Guna.UI2.WinForms.Guna2Button();
            this.txtCari = new Guna.UI2.WinForms.Guna2TextBox();
            this.fINDSMART_MABRESDsAll = new PROJECT_PRG2.FINDSMART_MABRESDsAll();
            this.transaksiPengajuanKRPPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaksiPengajuanKRPPTableAdapter = new PROJECT_PRG2.FINDSMART_MABRESDsAllTableAdapters.TransaksiPengajuanKRPPTableAdapter();
            this.idTransKRPPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPrestasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uraianSingkatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lembagaPelaksanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalPrestasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalPengisianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTKNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idJenisPrestasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPosisiPrestasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgKRPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMART_MABRESDsAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiPengajuanKRPPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgKRPP
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgKRPP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgKRPP.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgKRPP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgKRPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKRPP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTransKRPPDataGridViewTextBoxColumn,
            this.namaPrestasiDataGridViewTextBoxColumn,
            this.uraianSingkatDataGridViewTextBoxColumn,
            this.lembagaPelaksanaDataGridViewTextBoxColumn,
            this.tanggalPrestasiDataGridViewTextBoxColumn,
            this.tanggalPengisianDataGridViewTextBoxColumn,
            this.pointDataGridViewTextBoxColumn,
            this.nIMDataGridViewTextBoxColumn,
            this.idTKNDataGridViewTextBoxColumn,
            this.idJenisPrestasiDataGridViewTextBoxColumn,
            this.idPosisiPrestasiDataGridViewTextBoxColumn,
            this.idProdiDataGridViewTextBoxColumn});
            this.dgKRPP.DataSource = this.transaksiPengajuanKRPPBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgKRPP.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgKRPP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgKRPP.Location = new System.Drawing.Point(43, 202);
            this.dgKRPP.Name = "dgKRPP";
            this.dgKRPP.RowHeadersVisible = false;
            this.dgKRPP.Size = new System.Drawing.Size(1283, 625);
            this.dgKRPP.TabIndex = 0;
            this.dgKRPP.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgKRPP.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgKRPP.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgKRPP.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgKRPP.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgKRPP.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgKRPP.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgKRPP.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgKRPP.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgKRPP.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgKRPP.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgKRPP.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKRPP.ThemeStyle.HeaderStyle.Height = 15;
            this.dgKRPP.ThemeStyle.ReadOnly = false;
            this.dgKRPP.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgKRPP.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgKRPP.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgKRPP.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgKRPP.ThemeStyle.RowsStyle.Height = 22;
            this.dgKRPP.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgKRPP.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnTambah
            // 
            this.btnTambah.AutoRoundedCorners = true;
            this.btnTambah.BorderRadius = 21;
            this.btnTambah.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTambah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTambah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTambah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(43, 138);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(180, 45);
            this.btnTambah.TabIndex = 1;
            this.btnTambah.Text = "Tambah Baru";
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
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
            this.btnCari.Location = new System.Drawing.Point(498, 36);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(40, 36);
            this.btnCari.TabIndex = 33;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // txtCari
            // 
            this.txtCari.AutoRoundedCorners = true;
            this.txtCari.BackColor = System.Drawing.Color.Transparent;
            this.txtCari.BorderColor = System.Drawing.Color.Black;
            this.txtCari.BorderRadius = 17;
            this.txtCari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCari.DefaultText = "Cari Data Mahasiswa Prestasi";
            this.txtCari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCari.ForeColor = System.Drawing.Color.Gray;
            this.txtCari.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.Location = new System.Drawing.Point(545, 36);
            this.txtCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCari.Name = "txtCari";
            this.txtCari.PasswordChar = '\0';
            this.txtCari.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtCari.PlaceholderText = "";
            this.txtCari.SelectedText = "";
            this.txtCari.Size = new System.Drawing.Size(362, 36);
            this.txtCari.TabIndex = 32;
            // 
            // fINDSMART_MABRESDsAll
            // 
            this.fINDSMART_MABRESDsAll.DataSetName = "FINDSMART_MABRESDsAll";
            this.fINDSMART_MABRESDsAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transaksiPengajuanKRPPBindingSource
            // 
            this.transaksiPengajuanKRPPBindingSource.DataMember = "TransaksiPengajuanKRPP";
            this.transaksiPengajuanKRPPBindingSource.DataSource = this.fINDSMART_MABRESDsAll;
            // 
            // transaksiPengajuanKRPPTableAdapter
            // 
            this.transaksiPengajuanKRPPTableAdapter.ClearBeforeFill = true;
            // 
            // idTransKRPPDataGridViewTextBoxColumn
            // 
            this.idTransKRPPDataGridViewTextBoxColumn.DataPropertyName = "Id_TransKRPP";
            this.idTransKRPPDataGridViewTextBoxColumn.HeaderText = "Id_TransKRPP";
            this.idTransKRPPDataGridViewTextBoxColumn.Name = "idTransKRPPDataGridViewTextBoxColumn";
            // 
            // namaPrestasiDataGridViewTextBoxColumn
            // 
            this.namaPrestasiDataGridViewTextBoxColumn.DataPropertyName = "Nama_Prestasi";
            this.namaPrestasiDataGridViewTextBoxColumn.HeaderText = "Nama_Prestasi";
            this.namaPrestasiDataGridViewTextBoxColumn.Name = "namaPrestasiDataGridViewTextBoxColumn";
            // 
            // uraianSingkatDataGridViewTextBoxColumn
            // 
            this.uraianSingkatDataGridViewTextBoxColumn.DataPropertyName = "Uraian_Singkat";
            this.uraianSingkatDataGridViewTextBoxColumn.HeaderText = "Uraian_Singkat";
            this.uraianSingkatDataGridViewTextBoxColumn.Name = "uraianSingkatDataGridViewTextBoxColumn";
            // 
            // lembagaPelaksanaDataGridViewTextBoxColumn
            // 
            this.lembagaPelaksanaDataGridViewTextBoxColumn.DataPropertyName = "Lembaga_Pelaksana";
            this.lembagaPelaksanaDataGridViewTextBoxColumn.HeaderText = "Lembaga_Pelaksana";
            this.lembagaPelaksanaDataGridViewTextBoxColumn.Name = "lembagaPelaksanaDataGridViewTextBoxColumn";
            // 
            // tanggalPrestasiDataGridViewTextBoxColumn
            // 
            this.tanggalPrestasiDataGridViewTextBoxColumn.DataPropertyName = "Tanggal_Prestasi";
            this.tanggalPrestasiDataGridViewTextBoxColumn.HeaderText = "Tanggal_Prestasi";
            this.tanggalPrestasiDataGridViewTextBoxColumn.Name = "tanggalPrestasiDataGridViewTextBoxColumn";
            // 
            // tanggalPengisianDataGridViewTextBoxColumn
            // 
            this.tanggalPengisianDataGridViewTextBoxColumn.DataPropertyName = "Tanggal_Pengisian";
            this.tanggalPengisianDataGridViewTextBoxColumn.HeaderText = "Tanggal_Pengisian";
            this.tanggalPengisianDataGridViewTextBoxColumn.Name = "tanggalPengisianDataGridViewTextBoxColumn";
            // 
            // pointDataGridViewTextBoxColumn
            // 
            this.pointDataGridViewTextBoxColumn.DataPropertyName = "Point";
            this.pointDataGridViewTextBoxColumn.HeaderText = "Point";
            this.pointDataGridViewTextBoxColumn.Name = "pointDataGridViewTextBoxColumn";
            // 
            // nIMDataGridViewTextBoxColumn
            // 
            this.nIMDataGridViewTextBoxColumn.DataPropertyName = "NIM";
            this.nIMDataGridViewTextBoxColumn.HeaderText = "NIM";
            this.nIMDataGridViewTextBoxColumn.Name = "nIMDataGridViewTextBoxColumn";
            // 
            // idTKNDataGridViewTextBoxColumn
            // 
            this.idTKNDataGridViewTextBoxColumn.DataPropertyName = "Id_TKN";
            this.idTKNDataGridViewTextBoxColumn.HeaderText = "Id_TKN";
            this.idTKNDataGridViewTextBoxColumn.Name = "idTKNDataGridViewTextBoxColumn";
            // 
            // idJenisPrestasiDataGridViewTextBoxColumn
            // 
            this.idJenisPrestasiDataGridViewTextBoxColumn.DataPropertyName = "Id_JenisPrestasi";
            this.idJenisPrestasiDataGridViewTextBoxColumn.HeaderText = "Id_JenisPrestasi";
            this.idJenisPrestasiDataGridViewTextBoxColumn.Name = "idJenisPrestasiDataGridViewTextBoxColumn";
            // 
            // idPosisiPrestasiDataGridViewTextBoxColumn
            // 
            this.idPosisiPrestasiDataGridViewTextBoxColumn.DataPropertyName = "Id_PosisiPrestasi";
            this.idPosisiPrestasiDataGridViewTextBoxColumn.HeaderText = "Id_PosisiPrestasi";
            this.idPosisiPrestasiDataGridViewTextBoxColumn.Name = "idPosisiPrestasiDataGridViewTextBoxColumn";
            // 
            // idProdiDataGridViewTextBoxColumn
            // 
            this.idProdiDataGridViewTextBoxColumn.DataPropertyName = "Id_Prodi";
            this.idProdiDataGridViewTextBoxColumn.HeaderText = "Id_Prodi";
            this.idProdiDataGridViewTextBoxColumn.Name = "idProdiDataGridViewTextBoxColumn";
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoRoundedCorners = true;
            this.btnRefresh.BorderRadius = 21;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(593, 870);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(180, 45);
            this.btnRefresh.TabIndex = 34;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // trsKRPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 994);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dgKRPP);
            this.Name = "trsKRPP";
            this.Text = "trsKRPP";
            this.Load += new System.EventHandler(this.trsKRPP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKRPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMART_MABRESDsAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiPengajuanKRPPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgKRPP;
        private Guna.UI2.WinForms.Guna2Button btnTambah;
        private Guna.UI2.WinForms.Guna2Button btnCari;
        private Guna.UI2.WinForms.Guna2TextBox txtCari;
        private FINDSMART_MABRESDsAll fINDSMART_MABRESDsAll;
        private System.Windows.Forms.BindingSource transaksiPengajuanKRPPBindingSource;
        private FINDSMART_MABRESDsAllTableAdapters.TransaksiPengajuanKRPPTableAdapter transaksiPengajuanKRPPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTransKRPPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPrestasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uraianSingkatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lembagaPelaksanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalPrestasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalPengisianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTKNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idJenisPrestasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPosisiPrestasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdiDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}