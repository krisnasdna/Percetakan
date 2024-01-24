namespace Percetakan
{
    partial class Report
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.transaksiData = new Percetakan.transaksiData();
            this.dataTableTransaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableTransaksiTableAdapter = new Percetakan.transaksiDataTableAdapters.DataTableTransaksiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableTransaksiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTableTransaksiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Percetakan.ReportTransaksi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // transaksiData
            // 
            this.transaksiData.DataSetName = "transaksiData";
            this.transaksiData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableTransaksiBindingSource
            // 
            this.dataTableTransaksiBindingSource.DataMember = "DataTableTransaksi";
            this.dataTableTransaksiBindingSource.DataSource = this.transaksiData;
            // 
            // dataTableTransaksiTableAdapter
            // 
            this.dataTableTransaksiTableAdapter.ClearBeforeFill = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transaksiData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableTransaksiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private transaksiData transaksiData;
        private System.Windows.Forms.BindingSource dataTableTransaksiBindingSource;
        private transaksiDataTableAdapters.DataTableTransaksiTableAdapter dataTableTransaksiTableAdapter;
    }
}