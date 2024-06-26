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
            this.btnBatal = new Guna.UI2.WinForms.Guna2Button();
            this.btnHapus = new Guna.UI2.WinForms.Guna2Button();
            this.btnUbah = new Guna.UI2.WinForms.Guna2Button();
            this.btnCari = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtAkreditasi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtJenjangPendidikan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdProdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtgProdi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.fINDSMARTDataSet7 = new PROJECT_PRG2.FINDSMARTDataSet7();
            this.programStudiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programStudiTableAdapter = new PROJECT_PRG2.FINDSMARTDataSet7TableAdapters.ProgramStudiTableAdapter();
            this.idProdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenjangPendidikanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.akreditasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBatal
            // 
            this.btnBatal.AutoRoundedCorners = true;
            this.btnBatal.BackColor = System.Drawing.Color.Transparent;
            this.btnBatal.BorderRadius = 21;
            this.btnBatal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBatal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBatal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBatal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBatal.FillColor = System.Drawing.Color.HotPink;
            this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(309, 658);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(149, 44);
            this.btnBatal.TabIndex = 199;
            this.btnBatal.Text = "Batal";
            // 
            // btnHapus
            // 
            this.btnHapus.AutoRoundedCorners = true;
            this.btnHapus.BackColor = System.Drawing.Color.Transparent;
            this.btnHapus.BorderRadius = 21;
            this.btnHapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHapus.FillColor = System.Drawing.Color.HotPink;
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(491, 658);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(149, 44);
            this.btnHapus.TabIndex = 198;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.AutoRoundedCorners = true;
            this.btnUbah.BackColor = System.Drawing.Color.Transparent;
            this.btnUbah.BorderRadius = 21;
            this.btnUbah.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUbah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUbah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUbah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUbah.FillColor = System.Drawing.Color.HotPink;
            this.btnUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.ForeColor = System.Drawing.Color.White;
            this.btnUbah.Location = new System.Drawing.Point(125, 658);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(149, 44);
            this.btnUbah.TabIndex = 197;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnCari
            // 
            this.btnCari.AutoRoundedCorners = true;
            this.btnCari.BackColor = System.Drawing.Color.Transparent;
            this.btnCari.BorderRadius = 21;
            this.btnCari.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCari.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCari.FillColor = System.Drawing.Color.HotPink;
            this.btnCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.Location = new System.Drawing.Point(463, 224);
            this.btnCari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(100, 44);
            this.btnCari.TabIndex = 196;
            this.btnCari.Text = "Cari";
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(122, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 26);
            this.label3.TabIndex = 194;
            this.label3.Text = "Nama";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(123, 365);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 26);
            this.label14.TabIndex = 188;
            this.label14.Text = "Jenjang Pendidikan";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(123, 437);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 26);
            this.label15.TabIndex = 187;
            this.label15.Text = "Akreditasi";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(122, 229);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 26);
            this.label17.TabIndex = 185;
            this.label17.Text = "Id Prodi";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(163, 229);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel3.TabIndex = 184;
            this.guna2HtmlLabel3.Text = null;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(163, 229);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel4.TabIndex = 183;
            this.guna2HtmlLabel4.Text = null;
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
            this.txtAkreditasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtAkreditasi.ForeColor = System.Drawing.Color.Black;
            this.txtAkreditasi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAkreditasi.Location = new System.Drawing.Point(309, 437);
            this.txtAkreditasi.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtAkreditasi.Name = "txtAkreditasi";
            this.txtAkreditasi.PasswordChar = '\0';
            this.txtAkreditasi.PlaceholderText = "";
            this.txtAkreditasi.SelectedText = "";
            this.txtAkreditasi.Size = new System.Drawing.Size(255, 38);
            this.txtAkreditasi.TabIndex = 181;
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
            this.txtJenjangPendidikan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtJenjangPendidikan.ForeColor = System.Drawing.Color.Black;
            this.txtJenjangPendidikan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJenjangPendidikan.Location = new System.Drawing.Point(309, 365);
            this.txtJenjangPendidikan.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtJenjangPendidikan.Name = "txtJenjangPendidikan";
            this.txtJenjangPendidikan.PasswordChar = '\0';
            this.txtJenjangPendidikan.PlaceholderText = "";
            this.txtJenjangPendidikan.SelectedText = "";
            this.txtJenjangPendidikan.Size = new System.Drawing.Size(255, 38);
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
            this.txtNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNama.ForeColor = System.Drawing.Color.Black;
            this.txtNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.Location = new System.Drawing.Point(309, 296);
            this.txtNama.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtNama.Name = "txtNama";
            this.txtNama.PasswordChar = '\0';
            this.txtNama.PlaceholderText = "";
            this.txtNama.SelectedText = "";
            this.txtNama.Size = new System.Drawing.Size(255, 38);
            this.txtNama.TabIndex = 173;
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
            this.txtIdProdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtIdProdi.ForeColor = System.Drawing.Color.Black;
            this.txtIdProdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdProdi.Location = new System.Drawing.Point(309, 229);
            this.txtIdProdi.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtIdProdi.Name = "txtIdProdi";
            this.txtIdProdi.PasswordChar = '\0';
            this.txtIdProdi.PlaceholderText = "";
            this.txtIdProdi.SelectedText = "";
            this.txtIdProdi.Size = new System.Drawing.Size(148, 38);
            this.txtIdProdi.TabIndex = 172;
            // 
            // dtgProdi
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgProdi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgProdi.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProdi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgProdi.ColumnHeadersHeight = 18;
            this.dtgProdi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgProdi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdiDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.jenjangPendidikanDataGridViewTextBoxColumn,
            this.akreditasiDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dtgProdi.DataSource = this.programStudiBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgProdi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgProdi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgProdi.Location = new System.Drawing.Point(670, 224);
            this.dtgProdi.Name = "dtgProdi";
            this.dtgProdi.RowHeadersVisible = false;
            this.dtgProdi.RowHeadersWidth = 51;
            this.dtgProdi.RowTemplate.Height = 24;
            this.dtgProdi.Size = new System.Drawing.Size(1098, 489);
            this.dtgProdi.TabIndex = 200;
            this.dtgProdi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgProdi.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgProdi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgProdi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgProdi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgProdi.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgProdi.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgProdi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgProdi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgProdi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgProdi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgProdi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgProdi.ThemeStyle.HeaderStyle.Height = 18;
            this.dtgProdi.ThemeStyle.ReadOnly = false;
            this.dtgProdi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgProdi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgProdi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgProdi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgProdi.ThemeStyle.RowsStyle.Height = 24;
            this.dtgProdi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgProdi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // fINDSMARTDataSet7
            // 
            this.fINDSMARTDataSet7.DataSetName = "FINDSMARTDataSet7";
            this.fINDSMARTDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // programStudiBindingSource
            // 
            this.programStudiBindingSource.DataMember = "ProgramStudi";
            this.programStudiBindingSource.DataSource = this.fINDSMARTDataSet7;
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
            this.jenjangPendidikanDataGridViewTextBoxColumn.HeaderText = "Jenjang_Pendidikan";
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
            // 
            // UpDelet_Prodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJECT_PRG2.Properties.Resources.formProdi;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.dtgProdi);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.txtAkreditasi);
            this.Controls.Add(this.txtJenjangPendidikan);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtIdProdi);
            this.Name = "UpDelet_Prodi";
            this.Text = "UpDelet_Prodi";
            this.Load += new System.EventHandler(this.UpDelet_Prodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnBatal;
        private Guna.UI2.WinForms.Guna2Button btnHapus;
        private Guna.UI2.WinForms.Guna2Button btnUbah;
        private Guna.UI2.WinForms.Guna2Button btnCari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txtAkreditasi;
        private Guna.UI2.WinForms.Guna2TextBox txtJenjangPendidikan;
        private Guna.UI2.WinForms.Guna2TextBox txtNama;
        private Guna.UI2.WinForms.Guna2TextBox txtIdProdi;
        private Guna.UI2.WinForms.Guna2DataGridView dtgProdi;
        private FINDSMARTDataSet7 fINDSMARTDataSet7;
        private System.Windows.Forms.BindingSource programStudiBindingSource;
        private FINDSMARTDataSet7TableAdapters.ProgramStudiTableAdapter programStudiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenjangPendidikanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn akreditasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}