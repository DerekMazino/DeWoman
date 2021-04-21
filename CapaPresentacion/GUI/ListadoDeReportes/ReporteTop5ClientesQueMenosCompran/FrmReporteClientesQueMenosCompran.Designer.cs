namespace ProyectoInte.GUI.ListadoDeReportes.ReporteTop5ClientesQueMenosCompran
{
    partial class FrmReporteClientesQueMenosCompran
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
            this.ReporteTop5ClientesQueMenosCompran = new ProyectoInte.GUI.ListadoDeReportes.ReporteTop5ClientesQueMenosCompran.ReporteTop5ClientesQueMenosCompran();
            this.RClientesQueMenosCompranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RClientesQueMenosCompranTableAdapter = new ProyectoInte.GUI.ListadoDeReportes.ReporteTop5ClientesQueMenosCompran.ReporteTop5ClientesQueMenosCompranTableAdapters.RClientesQueMenosCompranTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteTop5ClientesQueMenosCompran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RClientesQueMenosCompranBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RClientesQueMenosCompranBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoInte.GUI.ListadoDeReportes.ReporteTop5ClientesQueMenosCompran.Report1Clie" +
    "ntesQueMnosCompran.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(973, 376);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReporteTop5ClientesQueMenosCompran
            // 
            this.ReporteTop5ClientesQueMenosCompran.DataSetName = "ReporteTop5ClientesQueMenosCompran";
            this.ReporteTop5ClientesQueMenosCompran.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RClientesQueMenosCompranBindingSource
            // 
            this.RClientesQueMenosCompranBindingSource.DataMember = "RClientesQueMenosCompran";
            this.RClientesQueMenosCompranBindingSource.DataSource = this.ReporteTop5ClientesQueMenosCompran;
            // 
            // RClientesQueMenosCompranTableAdapter
            // 
            this.RClientesQueMenosCompranTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteClientesQueMenosCompran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 376);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteClientesQueMenosCompran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReporteClientesQueMenosCompran";
            this.Load += new System.EventHandler(this.FrmReporteClientesQueMenosCompran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteTop5ClientesQueMenosCompran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RClientesQueMenosCompranBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RClientesQueMenosCompranBindingSource;
        private ReporteTop5ClientesQueMenosCompran ReporteTop5ClientesQueMenosCompran;
        private ReporteTop5ClientesQueMenosCompranTableAdapters.RClientesQueMenosCompranTableAdapter RClientesQueMenosCompranTableAdapter;
    }
}