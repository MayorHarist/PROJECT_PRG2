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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDosen));
            this.dosenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fINDSMARTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fINDSMART = new PROJECT_PRG2.FINDSMART();
            this.btnTampil = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.dosenTableAdapter = new PROJECT_PRG2.FINDSMARTTableAdapters.DosenTableAdapter();
            this.btnKembali = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvDosen = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dosenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dosenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMART)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDosen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosenBindingSource1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dosenBindingSource
            // 
            this.dosenBindingSource.DataMember = "Dosen";
            this.dosenBindingSource.DataSource = this.fINDSMARTBindingSource;
            // 
            // fINDSMARTBindingSource
            // 
            this.fINDSMARTBindingSource.DataSource = this.fINDSMART;
            this.fINDSMARTBindingSource.Position = 0;
            // 
            // fINDSMART
            // 
            this.fINDSMART.DataSetName = "FINDSMART";
            this.fINDSMART.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTampil
            // 
            this.btnTampil.AutoRoundedCorners = true;
            this.btnTampil.BackColor = System.Drawing.Color.Transparent;
            this.btnTampil.BorderRadius = 31;
            this.btnTampil.BorderThickness = -1;
            this.btnTampil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTampil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTampil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTampil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTampil.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTampil.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.btnTampil.ForeColor = System.Drawing.Color.White;
            this.btnTampil.Location = new System.Drawing.Point(931, 297);
            this.btnTampil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(196, 65);
            this.btnTampil.TabIndex = 20;
            this.btnTampil.Text = "Tampilkan";
            this.btnTampil.UseTransparentBackground = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.BorderColor = System.Drawing.Color.AliceBlue;
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(2481, 694);
            this.guna2VScrollBar1.Minimum = 1;
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 26;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(26, 454);
            this.guna2VScrollBar1.TabIndex = 33;
            this.guna2VScrollBar1.Value = 1;
            this.guna2VScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScroll_Scroll);
            // 
            // dosenTableAdapter
            // 
            this.dosenTableAdapter.ClearBeforeFill = true;
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.Transparent;
            this.btnKembali.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKembali.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKembali.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKembali.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKembali.FillColor = System.Drawing.Color.Transparent;
            this.btnKembali.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKembali.ForeColor = System.Drawing.Color.White;
            this.btnKembali.Location = new System.Drawing.Point(73, 993);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(369, 66);
            this.btnKembali.TabIndex = 35;
            this.btnKembali.UseTransparentBackground = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 30;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(1357, 747);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 62;
            this.guna2DataGridView1.RowTemplate.Height = 31;
            this.guna2DataGridView1.Size = new System.Drawing.Size(240, 150);
            this.guna2DataGridView1.TabIndex = 36;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(192)))));
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 30;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 31;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dgvDosen
            // 
            this.dgvDosen.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDosen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDosen.AutoGenerateColumns = false;
            this.dgvDosen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDosen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDosen.ColumnHeadersHeight = 30;
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
            this.teleponDataGridViewTextBoxColumn});
            this.dgvDosen.DataSource = this.dosenBindingSource1;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDosen.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvDosen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDosen.Location = new System.Drawing.Point(0, 0);
            this.dgvDosen.Name = "dgvDosen";
            this.dgvDosen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDosen.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvDosen.RowHeadersVisible = false;
            this.dgvDosen.RowHeadersWidth = 62;
            this.dgvDosen.RowTemplate.Height = 31;
            this.dgvDosen.Size = new System.Drawing.Size(1261, 340);
            this.dgvDosen.TabIndex = 37;
            this.dgvDosen.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDosen.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDosen.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvDosen.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDosen.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDosen.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(192)))));
            this.dgvDosen.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDosen.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDosen.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDosen.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDosen.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDosen.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDosen.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvDosen.ThemeStyle.ReadOnly = false;
            this.dgvDosen.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDosen.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDosen.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDosen.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDosen.ThemeStyle.RowsStyle.Height = 31;
            this.dgvDosen.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDosen.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dosenBindingSource1
            // 
            this.dosenBindingSource1.DataMember = "Dosen";
            this.dosenBindingSource1.DataSource = this.fINDSMARTBindingSource;
            // 
            // noPegawaiDataGridViewTextBoxColumn
            // 
            this.noPegawaiDataGridViewTextBoxColumn.DataPropertyName = "No_Pegawai";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.noPegawaiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.noPegawaiDataGridViewTextBoxColumn.HeaderText = "No Pegawai";
            this.noPegawaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.noPegawaiDataGridViewTextBoxColumn.Name = "noPegawaiDataGridViewTextBoxColumn";
            // 
            // nIDNDataGridViewTextBoxColumn
            // 
            this.nIDNDataGridViewTextBoxColumn.DataPropertyName = "NIDN";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nIDNDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.nIDNDataGridViewTextBoxColumn.HeaderText = "NIDN";
            this.nIDNDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nIDNDataGridViewTextBoxColumn.Name = "nIDNDataGridViewTextBoxColumn";
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.namaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // bidangKompetensiDataGridViewTextBoxColumn
            // 
            this.bidangKompetensiDataGridViewTextBoxColumn.DataPropertyName = "Bidang_Kompetensi";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.bidangKompetensiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.bidangKompetensiDataGridViewTextBoxColumn.HeaderText = "Bidang Kompetensi";
            this.bidangKompetensiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bidangKompetensiDataGridViewTextBoxColumn.Name = "bidangKompetensiDataGridViewTextBoxColumn";
            // 
            // pendidikanTerakhirDataGridViewTextBoxColumn
            // 
            this.pendidikanTerakhirDataGridViewTextBoxColumn.DataPropertyName = "Pendidikan_Terakhir";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.pendidikanTerakhirDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.pendidikanTerakhirDataGridViewTextBoxColumn.HeaderText = "Pendidikan Terakhir";
            this.pendidikanTerakhirDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pendidikanTerakhirDataGridViewTextBoxColumn.Name = "pendidikanTerakhirDataGridViewTextBoxColumn";
            // 
            // tanggalLahirDataGridViewTextBoxColumn
            // 
            this.tanggalLahirDataGridViewTextBoxColumn.DataPropertyName = "Tanggal_Lahir";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tanggalLahirDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.tanggalLahirDataGridViewTextBoxColumn.HeaderText = "Tanggal Lahir";
            this.tanggalLahirDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tanggalLahirDataGridViewTextBoxColumn.Name = "tanggalLahirDataGridViewTextBoxColumn";
            // 
            // jenisKelaminDataGridViewTextBoxColumn
            // 
            this.jenisKelaminDataGridViewTextBoxColumn.DataPropertyName = "Jenis_Kelamin";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.jenisKelaminDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.jenisKelaminDataGridViewTextBoxColumn.HeaderText = "Jenis Kelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jenisKelaminDataGridViewTextBoxColumn.Name = "jenisKelaminDataGridViewTextBoxColumn";
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.alamatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.emailDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // teleponDataGridViewTextBoxColumn
            // 
            this.teleponDataGridViewTextBoxColumn.DataPropertyName = "Telepon";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.teleponDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.teleponDataGridViewTextBoxColumn.HeaderText = "Telepon";
            this.teleponDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.teleponDataGridViewTextBoxColumn.Name = "teleponDataGridViewTextBoxColumn";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.dgvDosen);
            this.guna2Panel1.Location = new System.Drawing.Point(610, 680);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1261, 340);
            this.guna2Panel1.TabIndex = 38;
            // 
            // ViewDosen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnTampil);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewDosen";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "View Dosen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewDosen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dosenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMART)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDosen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosenBindingSource1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnTampil;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private System.Windows.Forms.BindingSource fINDSMARTBindingSource;
        private FINDSMART fINDSMART;
        private System.Windows.Forms.BindingSource dosenBindingSource;
        private FINDSMARTTableAdapters.DosenTableAdapter dosenTableAdapter;
        private Guna.UI2.WinForms.Guna2Button btnKembali;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDosen;
        private System.Windows.Forms.BindingSource dosenBindingSource1;
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
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}