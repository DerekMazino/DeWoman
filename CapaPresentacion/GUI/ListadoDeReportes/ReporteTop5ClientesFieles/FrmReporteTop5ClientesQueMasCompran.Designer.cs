namespace ProyectoInte.GUI.ListadoDeReportes.ReporteTop5ClientesFieles
{
    partial class FrmReporteTop5ClientesQueMasCompran
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
            this.ReporteTop5ClientesFieles = new ProyectoInte.GUI.ListadoDeReportes.ReporteTop5ClientesFieles.ReporteTop5ClientesFieles();
            this.RClientesQueMasCompranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RClientesQueMasCompranTableAdapter = new ProyectoInte.GUI.ListadoDeReportes.ReporteTop5ClientesFieles.ReporteTop5ClientesFielesTableAdapters.RClientesQueMasCompranTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteTop5ClientesFieles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RClientesQueMasCompranBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RClientesQueMasCompranBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoInte.GUI.ListadoDeReportes.ReporteTop5ClientesFieles.Report4Top5ClientesF" +
    "ieles.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(973, 376);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReporteTop5ClientesFieles
            // 
            this.ReporteTop5ClientesFieles.DataSetName = "ReporteTop5ClientesFieles";
            this.ReporteTop5ClientesFieles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RClientesQueMasCompranBindingSource
            // 
            this.RClientesQueMasCompranBindingSource.DataMember = "RClientesQueMasCompran";
            this.RClientesQueMasCompranBindingSource.DataSource = this.ReporteTop5ClientesFieles;
            // 
            // RClientesQueMasCompranTableAdapter
            // 
            this.RClientesQueMasCompranTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteTop5ClientesQueMasCompran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 376);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteTop5ClientesQueMasCompran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReporteTop5ClientesQueMasCompran";
            this.Load += new System.EventHandler(this.FrmReporteTop5ClientesQueMasCompran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteTop5ClientesFieles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RClientesQueMasCompranBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RClientesQueMasCompranBindingSource;
        private ReporteTop5ClientesFieles ReporteTop5ClientesFieles;
        private ReporteTop5ClientesFielesTableAdapters.RClientesQueMasCompranTableAdapter RClientesQueMasCompranTableAdapter;
    }
}