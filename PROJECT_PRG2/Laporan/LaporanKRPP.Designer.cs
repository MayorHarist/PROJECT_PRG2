namespace PROJECT_PRG2.Laporan
{
    partial class LaporanKRPP
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.laporanMahasiswaBerprestasiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repKRSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repKRS = new PROJECT_PRG2.RepKRS();
            this.laporanMahasiswaBerprestasiTableAdapter = new PROJECT_PRG2.RepKRSTableAdapters.LaporanMahasiswaBerprestasiTableAdapter();
            this.laporanMahasiswaKRPPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repKRPP = new PROJECT_PRG2.RepKRPP();
            this.repKRPPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laporanMahasiswaKRPPTableAdapter = new PROJECT_PRG2.RepKRPPTableAdapters.LaporanMahasiswaKRPPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.laporanMahasiswaBerprestasiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repKRSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repKRS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporanMahasiswaKRPPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repKRPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repKRPPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFilter
            // 
            this.cbFilter.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(1022, 80);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(193, 31);
            this.cbFilter.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(981, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Realisasi Pencapaian Prestasi Mahasiswa";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.laporanMahasiswaKRPPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PROJECT_PRG2.ReportKRPP.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(46, 118);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1171, 432);
            this.reportViewer1.TabIndex = 6;
            // 
            // laporanMahasiswaBerprestasiBindingSource
            // 
            this.laporanMahasiswaBerprestasiBindingSource.DataMember = "LaporanMahasiswaBerprestasi";
            this.laporanMahasiswaBerprestasiBindingSource.DataSource = this.repKRSBindingSource;
            // 
            // repKRSBindingSource
            // 
            this.repKRSBindingSource.DataSource = this.repKRS;
            this.repKRSBindingSource.Position = 0;
            // 
            // repKRS
            // 
            this.repKRS.DataSetName = "RepKRS";
            this.repKRS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // laporanMahasiswaBerprestasiTableAdapter
            // 
            this.laporanMahasiswaBerprestasiTableAdapter.ClearBeforeFill = true;
            // 
            // laporanMahasiswaKRPPBindingSource
            // 
            this.laporanMahasiswaKRPPBindingSource.DataMember = "LaporanMahasiswaKRPP";
            this.laporanMahasiswaKRPPBindingSource.DataSource = this.repKRPP;
            // 
            // repKRPP
            // 
            this.repKRPP.DataSetName = "RepKRPP";
            this.repKRPP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repKRPPBindingSource
            // 
            this.repKRPPBindingSource.DataSource = this.repKRPP;
            this.repKRPPBindingSource.Position = 0;
            // 
            // laporanMahasiswaKRPPTableAdapter
            // 
            this.laporanMahasiswaKRPPTableAdapter.ClearBeforeFill = true;
            // 
            // LaporanKRPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 606);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "LaporanKRPP";
            this.Text = "KRPP";
            this.Load += new System.EventHandler(this.KRPP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.laporanMahasiswaBerprestasiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repKRSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repKRS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporanMahasiswaKRPPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repKRPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repKRPPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource repKRPPBindingSource;
        private RepKRPP repKRPP;
        private RepKRS repKRS;
        private System.Windows.Forms.BindingSource repKRSBindingSource;
        private System.Windows.Forms.BindingSource laporanMahasiswaKRPPBindingSource;
        private RepKRPPTableAdapters.LaporanMahasiswaKRPPTableAdapter laporanMahasiswaKRPPTableAdapter;
        private System.Windows.Forms.BindingSource laporanMahasiswaBerprestasiBindingSource;
        private RepKRSTableAdapters.LaporanMahasiswaBerprestasiTableAdapter laporanMahasiswaBerprestasiTableAdapter;
    }
}