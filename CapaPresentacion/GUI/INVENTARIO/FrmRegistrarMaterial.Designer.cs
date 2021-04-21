namespace ProyectoInte.GUI.INVENTARIO
{
    partial class FrmRegistrarMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarMaterial));
            this.btnCan = new System.Windows.Forms.PictureBox();
            this.btnAcep = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnCan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAcep)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCan
            // 
            this.btnCan.BackgroundImage = global::ProyectoInte.Properties.Resources.cancelar;
            this.btnCan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCan.Location = new System.Drawing.Point(462, 48);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(71, 58);
            this.btnCan.TabIndex = 18;
            this.btnCan.TabStop = false;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            this.btnCan.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            this.btnCan.MouseHover += new System.EventHandler(this.btnCancelar_MouseHover);
            // 
            // btnAcep
            // 
            this.btnAcep.BackgroundImage = global::ProyectoInte.Properties.Resources.acptar;
            this.btnAcep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAcep.Location = new System.Drawing.Point(385, 48);
            this.btnAcep.Name = "btnAcep";
            this.btnAcep.Size = new System.Drawing.Size(71, 58);
            this.btnAcep.TabIndex = 17;
            this.btnAcep.TabStop = false;
            this.btnAcep.Click += new System.EventHandler(this.btnAcep_Click);
            this.btnAcep.MouseLeave += new System.EventHandler(this.btnAceptar_MouseLeave);
            this.btnAcep.MouseHover += new System.EventHandler(this.btnAceptar_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnCan);
            this.groupBox1.Controls.Add(this.txtMat);
            this.groupBox1.Controls.Add(this.btnAcep);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 151);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Materiales";
            // 
            // txtMat
            // 
            this.txtMat.Location = new System.Drawing.Point(126, 68);
            this.txtMat.MaxLength = 50;
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(239, 20);
            this.txtMat.TabIndex = 8;
            this.txtMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMat_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(34, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Material :";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProyectoInte.Properties.Resources.barra_azul;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(-8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 48);
            this.panel1.TabIndex = 12;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(566, 54);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(10, 20);
            this.txtId.TabIndex = 19;
            this.txtId.Visible = false;
            // 
            // FrmRegistrarMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoInte.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(576, 221);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistrarMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materiales";
            ((System.ComponentModel.ISupportInitialize)(this.btnCan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAcep)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnCan;
        private System.Windows.Forms.PictureBox btnAcep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtMat;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}