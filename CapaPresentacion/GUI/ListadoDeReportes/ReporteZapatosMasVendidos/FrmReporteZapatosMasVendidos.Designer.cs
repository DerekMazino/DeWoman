namespace ProyectoInte.GUI.ListadoDeReportes.ReporteZapatosMasVendidos
{
    partial class FrmReporteZapatosMasVendidos
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
            this.ReporteZapatosMasVendidos = new ProyectoInte.GUI.ListadoDeReportes.ReporteZapatosMasVendidos.ReporteZapatosMasVendidos();
            this.RZapatosMasVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RZapatosMasVendidosTableAdapter = new ProyectoInte.GUI.ListadoDeReportes.ReporteZapatosMasVendidos.ReporteZapatosMasVendidosTableAdapters.RZapatosMasVendidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteZapatosMasVendidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RZapatosMasVendidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RZapatosMasVendidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoInte.GUI.ListadoDeReportes.ReporteZapatosMasVendidos.Report1ZapatosMasVen" +
    "didos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(795, 390);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReporteZapatosMasVendidos
            // 
            this.ReporteZapatosMasVendidos.DataSetName = "ReporteZapatosMasVendidos";
            this.ReporteZapatosMasVendidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RZapatosMasVendidosBindingSource
            // 
            this.RZapatosMasVendidosBindingSource.DataMember = "RZapatosMasVendidos";
            this.RZapatosMasVendidosBindingSource.DataSource = this.ReporteZapatosMasVendidos;
            // 
            // RZapatosMasVendidosTableAdapter
            // 
            this.RZapatosMasVendidosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteZapatosMasVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 390);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteZapatosMasVendidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReporteZapatosMasVendidos";
            this.Load += new System.EventHandler(this.FrmReporteZapatosMasVendidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteZapatosMasVendidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RZapatosMasVendidosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RZapatosMasVendidosBindingSource;
        private ReporteZapatosMasVendidos ReporteZapatosMasVendidos;
        private ReporteZapatosMasVendidosTableAdapters.RZapatosMasVendidosTableAdapter RZapatosMasVendidosTableAdapter;
    }
}