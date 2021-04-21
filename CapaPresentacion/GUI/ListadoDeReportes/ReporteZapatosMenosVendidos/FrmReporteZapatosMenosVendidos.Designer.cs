namespace ProyectoInte.GUI.ListadoDeReportes.ReporteZapatosMenosVendidos
{
    partial class FrmReporteZapatosMenosVendidos
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
            this.RZapatosMenosVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteZapatosMenosVendidos = new ProyectoInte.GUI.ListadoDeReportes.ReporteZapatosMenosVendidos.ReporteZapatosMenosVendidos();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RZapatosMenosVendidosTableAdapter = new ProyectoInte.GUI.ListadoDeReportes.ReporteZapatosMenosVendidos.ReporteZapatosMenosVendidosTableAdapters.RZapatosMenosVendidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RZapatosMenosVendidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteZapatosMenosVendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // RZapatosMenosVendidosBindingSource
            // 
            this.RZapatosMenosVendidosBindingSource.DataMember = "RZapatosMenosVendidos";
            this.RZapatosMenosVendidosBindingSource.DataSource = this.ReporteZapatosMenosVendidos;
            // 
            // ReporteZapatosMenosVendidos
            // 
            this.ReporteZapatosMenosVendidos.DataSetName = "ReporteZapatosMenosVendidos";
            this.ReporteZapatosMenosVendidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RZapatosMenosVendidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoInte.GUI.ListadoDeReportes.ReporteZapatosMenosVendidos.Report2ListadoZapa" +
    "tosMenosVendidos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(795, 390);
            this.reportViewer1.TabIndex = 0;
            // 
            // RZapatosMenosVendidosTableAdapter
            // 
            this.RZapatosMenosVendidosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteZapatosMenosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 390);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteZapatosMenosVendidos";
            this.Text = "FrmReporteZapatosMenosVendidos";
            this.Load += new System.EventHandler(this.FrmReporteZapatosMenosVendidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RZapatosMenosVendidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteZapatosMenosVendidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RZapatosMenosVendidosBindingSource;
        private ReporteZapatosMenosVendidos ReporteZapatosMenosVendidos;
        private ReporteZapatosMenosVendidosTableAdapters.RZapatosMenosVendidosTableAdapter RZapatosMenosVendidosTableAdapter;
    }
}