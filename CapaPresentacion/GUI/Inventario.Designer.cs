namespace ProyectoInte.GUI
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMate = new System.Windows.Forms.PictureBox();
            this.btnProduc = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProduc)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnMate);
            this.groupBox2.Controls.Add(this.btnProduc);
            this.groupBox2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.groupBox2.Location = new System.Drawing.Point(120, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(554, 127);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // btnMate
            // 
            this.btnMate.BackgroundImage = global::ProyectoInte.Properties.Resources.btnMateriales;
            this.btnMate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMate.Location = new System.Drawing.Point(356, 9);
            this.btnMate.Name = "btnMate";
            this.btnMate.Size = new System.Drawing.Size(109, 116);
            this.btnMate.TabIndex = 18;
            this.btnMate.TabStop = false;
            this.btnMate.Click += new System.EventHandler(this.btnMate_Click);
            this.btnMate.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            this.btnMate.MouseHover += new System.EventHandler(this.btnCancelar_MouseHover);
            // 
            // btnProduc
            // 
            this.btnProduc.BackgroundImage = global::ProyectoInte.Properties.Resources.btnProduc;
            this.btnProduc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProduc.Location = new System.Drawing.Point(112, 9);
            this.btnProduc.Name = "btnProduc";
            this.btnProduc.Size = new System.Drawing.Size(109, 116);
            this.btnProduc.TabIndex = 17;
            this.btnProduc.TabStop = false;
            this.btnProduc.Click += new System.EventHandler(this.btnProduc_Click);
            this.btnProduc.MouseLeave += new System.EventHandler(this.btnAceptar_MouseLeave);
            this.btnProduc.MouseHover += new System.EventHandler(this.btnAceptar_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProyectoInte.Properties.Resources.barra_azul;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Titulo);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Location = new System.Drawing.Point(-7, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 57);
            this.panel1.TabIndex = 9;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Titulo.Location = new System.Drawing.Point(290, 13);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(206, 37);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "INVENTARIO";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = global::ProyectoInte.Properties.Resources.cerrar;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.Location = new System.Drawing.Point(736, 15);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 23);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            this.btnCerrar.MouseHover += new System.EventHandler(this.btnCerrar_MouseHover);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoInte.Properties.Resources.wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 306);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProduc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMate;
        private System.Windows.Forms.PictureBox btnProduc;
    }
}