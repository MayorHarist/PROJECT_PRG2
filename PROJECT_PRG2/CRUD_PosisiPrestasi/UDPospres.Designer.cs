namespace PROJECT_PRG2.CRUD_PosisiPrestasi
{
    partial class UDPospres
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UDPospres));
            this.btnCari = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnBatal = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posisiPrestasiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fINDSMARTDataSet71 = new PROJECT_PRG2.FINDSMARTDataSet7();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCari = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDeskripsi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdPosisiPrestasi = new Guna.UI2.WinForms.Guna2TextBox();
            this.posisiPrestasiTableAdapter = new PROJECT_PRG2.FINDSMARTDataSet7TableAdapters.PosisiPrestasiTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHapusPP = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnUpdatePP = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnTambahPP = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posisiPrestasiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet71)).BeginInit();
            this.SuspendLayout();
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
            this.btnCari.Location = new System.Drawing.Point(194, 18);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(35, 36);
            this.btnCari.TabIndex = 49;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
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
            this.btnRefresh.Location = new System.Drawing.Point(809, 394);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(133, 28);
            this.btnRefresh.TabIndex = 48;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.btnBatal.Location = new System.Drawing.Point(256, 668);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(124, 28);
            this.btnBatal.TabIndex = 45;
            this.btnBatal.Text = "Batal";
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowDrop = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView1.ColumnHeadersHeight = 29;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.statusDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.posisiPrestasiBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(39, 104);
            this.guna2DataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.Size = new System.Drawing.Size(881, 264);
            this.guna2DataGridView1.TabIndex = 53;
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
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 29;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_PosisiPrestasi";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_PosisiPrestasi";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nama";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nama";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Deskripsi";
            this.dataGridViewTextBoxColumn3.HeaderText = "Deskripsi";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // posisiPrestasiBindingSource
            // 
            this.posisiPrestasiBindingSource.DataMember = "PosisiPrestasi";
            this.posisiPrestasiBindingSource.DataSource = this.fINDSMARTDataSet71;
            // 
            // fINDSMARTDataSet71
            // 
            this.fINDSMARTDataSet71.DataSetName = "FINDSMARTDataSet7";
            this.fINDSMARTDataSet71.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(571, 520);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Deskripsi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 560);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "ID Posisi Prestasi";
            // 
            // txtCari
            // 
            this.txtCari.AutoRoundedCorners = true;
            this.txtCari.BackColor = System.Drawing.Color.Transparent;
            this.txtCari.BorderColor = System.Drawing.Color.Gray;
            this.txtCari.BorderRadius = 17;
            this.txtCari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCari.DefaultText = "";
            this.txtCari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCari.ForeColor = System.Drawing.Color.Black;
            this.txtCari.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.Location = new System.Drawing.Point(235, 18);
            this.txtCari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCari.Name = "txtCari";
            this.txtCari.PasswordChar = '\0';
            this.txtCari.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtCari.PlaceholderText = "";
            this.txtCari.SelectedText = "";
            this.txtCari.Size = new System.Drawing.Size(491, 36);
            this.txtCari.TabIndex = 32;
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeskripsi.DefaultText = "";
            this.txtDeskripsi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDeskripsi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDeskripsi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeskripsi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeskripsi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeskripsi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDeskripsi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeskripsi.Location = new System.Drawing.Point(696, 520);
            this.txtDeskripsi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.PasswordChar = '\0';
            this.txtDeskripsi.PlaceholderText = "";
            this.txtDeskripsi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDeskripsi.SelectedText = "";
            this.txtDeskripsi.Size = new System.Drawing.Size(245, 99);
            this.txtDeskripsi.TabIndex = 52;
            // 
            // txtNama
            // 
            this.txtNama.AutoRoundedCorners = true;
            this.txtNama.BorderRadius = 13;
            this.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNama.DefaultText = "";
            this.txtNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.Location = new System.Drawing.Point(292, 560);
            this.txtNama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNama.Name = "txtNama";
            this.txtNama.PasswordChar = '\0';
            this.txtNama.PlaceholderText = "";
            this.txtNama.SelectedText = "";
            this.txtNama.Size = new System.Drawing.Size(245, 28);
            this.txtNama.TabIndex = 51;
            // 
            // txtIdPosisiPrestasi
            // 
            this.txtIdPosisiPrestasi.AutoRoundedCorners = true;
            this.txtIdPosisiPrestasi.BorderRadius = 13;
            this.txtIdPosisiPrestasi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdPosisiPrestasi.DefaultText = "";
            this.txtIdPosisiPrestasi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdPosisiPrestasi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdPosisiPrestasi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPosisiPrestasi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPosisiPrestasi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPosisiPrestasi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdPosisiPrestasi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPosisiPrestasi.Location = new System.Drawing.Point(292, 520);
            this.txtIdPosisiPrestasi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdPosisiPrestasi.Name = "txtIdPosisiPrestasi";
            this.txtIdPosisiPrestasi.PasswordChar = '\0';
            this.txtIdPosisiPrestasi.PlaceholderText = "";
            this.txtIdPosisiPrestasi.ReadOnly = true;
            this.txtIdPosisiPrestasi.SelectedText = "";
            this.txtIdPosisiPrestasi.Size = new System.Drawing.Size(175, 28);
            this.txtIdPosisiPrestasi.TabIndex = 50;
            this.txtIdPosisiPrestasi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdPosisiPrestasi_KeyPress);
            // 
            // posisiPrestasiTableAdapter
            // 
            this.posisiPrestasiTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(817, 637);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Aksi";
            // 
            // btnHapusPP
            // 
            this.btnHapusPP.BackColor = System.Drawing.Color.Transparent;
            this.btnHapusPP.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnHapusPP.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnHapusPP.Image = ((System.Drawing.Image)(resources.GetObject("btnHapusPP.Image")));
            this.btnHapusPP.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnHapusPP.ImageRotate = 0F;
            this.btnHapusPP.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHapusPP.Location = new System.Drawing.Point(919, 668);
            this.btnHapusPP.Margin = new System.Windows.Forms.Padding(2);
            this.btnHapusPP.Name = "btnHapusPP";
            this.btnHapusPP.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnHapusPP.Size = new System.Drawing.Size(23, 25);
            this.btnHapusPP.TabIndex = 98;
            this.btnHapusPP.UseTransparentBackground = true;
            this.btnHapusPP.Click += new System.EventHandler(this.btnHapusPP_Click);
            // 
            // btnUpdatePP
            // 
            this.btnUpdatePP.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdatePP.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnUpdatePP.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnUpdatePP.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdatePP.Image")));
            this.btnUpdatePP.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnUpdatePP.ImageRotate = 0F;
            this.btnUpdatePP.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdatePP.Location = new System.Drawing.Point(869, 665);
            this.btnUpdatePP.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdatePP.Name = "btnUpdatePP";
            this.btnUpdatePP.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnUpdatePP.Size = new System.Drawing.Size(29, 31);
            this.btnUpdatePP.TabIndex = 97;
            this.btnUpdatePP.UseTransparentBackground = true;
            this.btnUpdatePP.Click += new System.EventHandler(this.btnUpdatePP_Click);
            // 
            // btnTambahPP
            // 
            this.btnTambahPP.BackColor = System.Drawing.Color.Transparent;
            this.btnTambahPP.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnTambahPP.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnTambahPP.Image = ((System.Drawing.Image)(resources.GetObject("btnTambahPP.Image")));
            this.btnTambahPP.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnTambahPP.ImageRotate = 0F;
            this.btnTambahPP.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTambahPP.Location = new System.Drawing.Point(823, 664);
            this.btnTambahPP.Margin = new System.Windows.Forms.Padding(2);
            this.btnTambahPP.Name = "btnTambahPP";
            this.btnTambahPP.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnTambahPP.Size = new System.Drawing.Size(27, 32);
            this.btnTambahPP.TabIndex = 96;
            this.btnTambahPP.UseTransparentBackground = true;
            this.btnTambahPP.Click += new System.EventHandler(this.btnTambahPP_Click);
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
            this.guna2TextBox1.Location = new System.Drawing.Point(809, 662);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(145, 37);
            this.guna2TextBox1.TabIndex = 99;
            // 
            // UDPospres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1020, 826);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHapusPP);
            this.Controls.Add(this.btnUpdatePP);
            this.Controls.Add(this.btnTambahPP);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtIdPosisiPrestasi);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UDPospres";
            this.Text = "UDPospres";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UDPospres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posisiPrestasiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet71)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCari;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnBatal;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtCari;
        private Guna.UI2.WinForms.Guna2TextBox txtDeskripsi;
        private Guna.UI2.WinForms.Guna2TextBox txtNama;
        private Guna.UI2.WinForms.Guna2TextBox txtIdPosisiPrestasi;
        private FINDSMARTDataSet7 fINDSMARTDataSet7;
        private System.Windows.Forms.BindingSource posisiPrestasiBindingSource1;
        private FINDSMARTDataSet7TableAdapters.PosisiPrestasiTableAdapter posisiPrestasiTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPosisiPrestasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsiDataGridViewTextBoxColumn;
        private FINDSMARTDataSet7 fINDSMARTDataSet71;
        private System.Windows.Forms.BindingSource posisiPrestasiBindingSource;
        private FINDSMARTDataSet7TableAdapters.PosisiPrestasiTableAdapter posisiPrestasiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton btnHapusPP;
        private Guna.UI2.WinForms.Guna2ImageButton btnUpdatePP;
        private Guna.UI2.WinForms.Guna2ImageButton btnTambahPP;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}