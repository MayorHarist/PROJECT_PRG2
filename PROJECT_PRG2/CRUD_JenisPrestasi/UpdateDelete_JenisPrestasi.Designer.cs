namespace PROJECT_PRG2.CRUD_JenisPrestasi
{
    partial class UpdateDelete_JenisPrestasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDelete_JenisPrestasi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.txtPenyelenggara = new System.Windows.Forms.TextBox();
            this.txtPeran = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtIdJenisPrestasi = new System.Windows.Forms.TextBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idJenisPrestasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penyelenggaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisPrestasiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fINDSMARTDataSet6 = new PROJECT_PRG2.FINDSMARTDataSet6();
            this.jenisPrestasiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fINDSMARTDataSet4 = new PROJECT_PRG2.FINDSMARTDataSet4();
            this.jenisPrestasiTableAdapter = new PROJECT_PRG2.FINDSMARTDataSet4TableAdapters.JenisPrestasiTableAdapter();
            this.jenisPrestasiTableAdapter1 = new PROJECT_PRG2.FINDSMARTDataSet6TableAdapters.JenisPrestasiTableAdapter();
            this.fINDSMARTDataSet7 = new PROJECT_PRG2.FINDSMARTDataSet7();
            this.jenisPrestasiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.jenisPrestasiTableAdapter2 = new PROJECT_PRG2.FINDSMARTDataSet7TableAdapters.JenisPrestasiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisPrestasiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisPrestasiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisPrestasiBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(996, 932);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(347, 54);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(996, 839);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(347, 54);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(1418, 839);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(386, 54);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(1418, 932);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(386, 54);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(308, 913);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(626, 54);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(1325, 759);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(589, 37);
            this.txtStatus.TabIndex = 19;
            // 
            // txtPoint
            // 
            this.txtPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoint.Location = new System.Drawing.Point(1325, 661);
            this.txtPoint.Margin = new System.Windows.Forms.Padding(4);
            this.txtPoint.Multiline = true;
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(589, 37);
            this.txtPoint.TabIndex = 18;
            this.txtPoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPoint_KeyPress);
            // 
            // txtPenyelenggara
            // 
            this.txtPenyelenggara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenyelenggara.Location = new System.Drawing.Point(1325, 543);
            this.txtPenyelenggara.Margin = new System.Windows.Forms.Padding(4);
            this.txtPenyelenggara.Multiline = true;
            this.txtPenyelenggara.Name = "txtPenyelenggara";
            this.txtPenyelenggara.Size = new System.Drawing.Size(589, 37);
            this.txtPenyelenggara.TabIndex = 17;
            // 
            // txtPeran
            // 
            this.txtPeran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeran.Location = new System.Drawing.Point(1325, 443);
            this.txtPeran.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeran.Multiline = true;
            this.txtPeran.Name = "txtPeran";
            this.txtPeran.Size = new System.Drawing.Size(589, 37);
            this.txtPeran.TabIndex = 16;
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(1325, 341);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4);
            this.txtNama.Multiline = true;
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(583, 37);
            this.txtNama.TabIndex = 15;
            // 
            // txtIdJenisPrestasi
            // 
            this.txtIdJenisPrestasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdJenisPrestasi.Location = new System.Drawing.Point(1325, 250);
            this.txtIdJenisPrestasi.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdJenisPrestasi.Multiline = true;
            this.txtIdJenisPrestasi.Name = "txtIdJenisPrestasi";
            this.txtIdJenisPrestasi.Size = new System.Drawing.Size(583, 37);
            this.txtIdJenisPrestasi.TabIndex = 14;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.guna2DataGridView1.ColumnHeadersHeight = 15;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idJenisPrestasiDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.peranDataGridViewTextBoxColumn,
            this.penyelenggaraDataGridViewTextBoxColumn,
            this.pointDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.jenisPrestasiBindingSource2;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle18;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(93, 211);
            this.guna2DataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.Size = new System.Drawing.Size(767, 520);
            this.guna2DataGridView1.TabIndex = 20;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 15;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // idJenisPrestasiDataGridViewTextBoxColumn
            // 
            this.idJenisPrestasiDataGridViewTextBoxColumn.DataPropertyName = "Id_JenisPrestasi";
            this.idJenisPrestasiDataGridViewTextBoxColumn.HeaderText = "Id Jenis Prestasi";
            this.idJenisPrestasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idJenisPrestasiDataGridViewTextBoxColumn.Name = "idJenisPrestasiDataGridViewTextBoxColumn";
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // peranDataGridViewTextBoxColumn
            // 
            this.peranDataGridViewTextBoxColumn.DataPropertyName = "Peran";
            this.peranDataGridViewTextBoxColumn.HeaderText = "Peran";
            this.peranDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.peranDataGridViewTextBoxColumn.Name = "peranDataGridViewTextBoxColumn";
            // 
            // penyelenggaraDataGridViewTextBoxColumn
            // 
            this.penyelenggaraDataGridViewTextBoxColumn.DataPropertyName = "Penyelenggara";
            this.penyelenggaraDataGridViewTextBoxColumn.HeaderText = "Penyelenggara";
            this.penyelenggaraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.penyelenggaraDataGridViewTextBoxColumn.Name = "penyelenggaraDataGridViewTextBoxColumn";
            // 
            // pointDataGridViewTextBoxColumn
            // 
            this.pointDataGridViewTextBoxColumn.DataPropertyName = "Point";
            this.pointDataGridViewTextBoxColumn.HeaderText = "Point";
            this.pointDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pointDataGridViewTextBoxColumn.Name = "pointDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // jenisPrestasiBindingSource1
            // 
            this.jenisPrestasiBindingSource1.DataMember = "JenisPrestasi";
            this.jenisPrestasiBindingSource1.DataSource = this.fINDSMARTDataSet6;
            // 
            // fINDSMARTDataSet6
            // 
            this.fINDSMARTDataSet6.DataSetName = "FINDSMARTDataSet6";
            this.fINDSMARTDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jenisPrestasiBindingSource
            // 
            this.jenisPrestasiBindingSource.DataMember = "JenisPrestasi";
            this.jenisPrestasiBindingSource.DataSource = this.fINDSMARTDataSet4;
            // 
            // fINDSMARTDataSet4
            // 
            this.fINDSMARTDataSet4.DataSetName = "FINDSMARTDataSet4";
            this.fINDSMARTDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jenisPrestasiTableAdapter
            // 
            this.jenisPrestasiTableAdapter.ClearBeforeFill = true;
            // 
            // jenisPrestasiTableAdapter1
            // 
            this.jenisPrestasiTableAdapter1.ClearBeforeFill = true;
            // 
            // fINDSMARTDataSet7
            // 
            this.fINDSMARTDataSet7.DataSetName = "FINDSMARTDataSet7";
            this.fINDSMARTDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jenisPrestasiBindingSource2
            // 
            this.jenisPrestasiBindingSource2.DataMember = "JenisPrestasi";
            this.jenisPrestasiBindingSource2.DataSource = this.fINDSMARTDataSet7;
            // 
            // jenisPrestasiTableAdapter2
            // 
            this.jenisPrestasiTableAdapter2.ClearBeforeFill = true;
            // 
            // UpdateDelete_JenisPrestasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.txtPenyelenggara);
            this.Controls.Add(this.txtPeran);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtIdJenisPrestasi);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateDelete_JenisPrestasi";
            this.Text = "Update & Delete Jenis Prestasi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UpdateDelete_JenisPrestasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisPrestasiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisPrestasiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisPrestasiBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.TextBox txtPenyelenggara;
        private System.Windows.Forms.TextBox txtPeran;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtIdJenisPrestasi;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private FINDSMARTDataSet4 fINDSMARTDataSet4;
        private System.Windows.Forms.BindingSource jenisPrestasiBindingSource;
        private FINDSMARTDataSet4TableAdapters.JenisPrestasiTableAdapter jenisPrestasiTableAdapter;
        private FINDSMARTDataSet6 fINDSMARTDataSet6;
        private System.Windows.Forms.BindingSource jenisPrestasiBindingSource1;
        private FINDSMARTDataSet6TableAdapters.JenisPrestasiTableAdapter jenisPrestasiTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idJenisPrestasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penyelenggaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private FINDSMARTDataSet7 fINDSMARTDataSet7;
        private System.Windows.Forms.BindingSource jenisPrestasiBindingSource2;
        private FINDSMARTDataSet7TableAdapters.JenisPrestasiTableAdapter jenisPrestasiTableAdapter2;
    }
}