namespace ProyectoInte.GUI.PROVEEDORES.ReporteListadoProoveedores
{
    partial class FrmReporteListadoProveedores
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
            this.ListarProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteListadoProveedores = new ProyectoInte.GUI.PROVEEDORES.ReporteListadoProoveedores.ReporteListadoProveedores();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ListarProveedoresTableAdapter = new ProyectoInte.GUI.PROVEEDORES.ReporteListadoProoveedores.ReporteListadoProveedoresTableAdapters.ListarProveedoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ListarProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteListadoProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // ListarProveedoresBindingSource
            // 
            this.ListarProveedoresBindingSource.DataMember = "ListarProveedores";
            this.ListarProveedoresBindingSource.DataSource = this.ReporteListadoProveedores;
            // 
            // ReporteListadoProveedores
            // 
            this.ReporteListadoProveedores.DataSetName = "ReporteListadoProveedores";
            this.ReporteListadoProveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ListarProveedoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoInte.GUI.PROVEEDORES.ReporteListadoProoveedores.ReportListadoProveedores." +
    "rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(887, 431);
            this.reportViewer1.TabIndex = 0;
            // 
            // ListarProveedoresTableAdapter
            // 
            this.ListarProveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteListadoProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 431);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteListadoProveedores";
            this.Text = "FrmReporteListadoProveedores";
            this.Load += new System.EventHandler(this.FrmReporteListadoProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListarProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteListadoProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ListarProveedoresBindingSource;
        private ReporteListadoProveedores ReporteListadoProveedores;
        private ReporteListadoProveedoresTableAdapters.ListarProveedoresTableAdapter ListarProveedoresTableAdapter;
    }
}