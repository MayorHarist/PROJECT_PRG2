﻿namespace PROJECT_PRG2.Laporan
{
    partial class LaporanKRS_KRPP
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.fINDSMART_MABRESDataSet1 = new PROJECT_PRG2.FINDSMART_MABRESDataSet1();
            this.mahasiswaBerprestasiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaBerprestasiTableAdapter = new PROJECT_PRG2.FINDSMART_MABRESDataSet1TableAdapters.MahasiswaBerprestasiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMART_MABRESDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBerprestasiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFilter
            // 
            this.cbFilter.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(985, 96);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(193, 31);
            this.cbFilter.TabIndex = 21;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(944, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(525, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "Prestasi Mahasiswa Smart";
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.mahasiswaBerprestasiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PROJECT_PRG2.MahasiswaBreprestasi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(57, 134);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1120, 432);
            this.reportViewer1.TabIndex = 18;
            // 
            // fINDSMART_MABRESDataSet1
            // 
            this.fINDSMART_MABRESDataSet1.DataSetName = "FINDSMART_MABRESDataSet1";
            this.fINDSMART_MABRESDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahasiswaBerprestasiBindingSource
            // 
            this.mahasiswaBerprestasiBindingSource.DataMember = "MahasiswaBerprestasi";
            this.mahasiswaBerprestasiBindingSource.DataSource = this.fINDSMART_MABRESDataSet1;
            // 
            // mahasiswaBerprestasiTableAdapter
            // 
            this.mahasiswaBerprestasiTableAdapter.ClearBeforeFill = true;
            // 
            // LaporanKRS_KRPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1265, 606);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LaporanKRS_KRPP";
            this.Text = "KRS_KRPP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LaporanKRS_KRPP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMART_MABRESDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBerprestasiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FINDSMART_MABRESDataSet1 fINDSMART_MABRESDataSet1;
        private System.Windows.Forms.BindingSource mahasiswaBerprestasiBindingSource;
        private FINDSMART_MABRESDataSet1TableAdapters.MahasiswaBerprestasiTableAdapter mahasiswaBerprestasiTableAdapter;
    }
}