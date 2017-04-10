namespace LibraryManagementSystem
{
    partial class frmReprt
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
            this.LMSDataSet = new LibraryManagementSystem.LMSDataSet();
            this.tblReaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblReaderTableAdapter = new LibraryManagementSystem.LMSDataSetTableAdapters.tblReaderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReaderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetReport";
            reportDataSource1.Value = this.tblReaderBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LibraryManagementSystem.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(655, 508);
            this.reportViewer1.TabIndex = 0;
            // 
            // LMSDataSet
            // 
            this.LMSDataSet.DataSetName = "LMSDataSet";
            this.LMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblReaderBindingSource
            // 
            this.tblReaderBindingSource.DataMember = "tblReader";
            this.tblReaderBindingSource.DataSource = this.LMSDataSet;
            // 
            // tblReaderTableAdapter
            // 
            this.tblReaderTableAdapter.ClearBeforeFill = true;
            // 
            // frmReprt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 508);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReprt";
            this.Text = "frmReprt";
            this.Load += new System.EventHandler(this.frmReprt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReaderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblReaderBindingSource;
        private LMSDataSet LMSDataSet;
        private LMSDataSetTableAdapters.tblReaderTableAdapter tblReaderTableAdapter;
    }
}