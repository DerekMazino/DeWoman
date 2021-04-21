namespace ProyectoInte.GUI.CLIENTES
{
    partial class FrmPagarCredito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagarCredito));
            this.txtDocIdentidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombresCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCan = new System.Windows.Forms.PictureBox();
            this.btnAcep = new System.Windows.Forms.PictureBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnCan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAcep)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDocIdentidad
            // 
            this.txtDocIdentidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocIdentidad.Location = new System.Drawing.Point(137, 49);
            this.txtDocIdentidad.Name = "txtDocIdentidad";
            this.txtDocIdentidad.ReadOnly = true;
            this.txtDocIdentidad.Size = new System.Drawing.Size(172, 20);
            this.txtDocIdentidad.TabIndex = 8;
            this.txtDocIdentidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(42, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cedula:";
            // 
            // txtNombresCliente
            // 
            this.txtNombresCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombresCliente.Location = new System.Drawing.Point(137, 76);
            this.txtNombresCliente.Name = "txtNombresCliente";
            this.txtNombresCliente.ReadOnly = true;
            this.txtNombresCliente.Size = new System.Drawing.Size(271, 20);
            this.txtNombresCliente.TabIndex = 6;
            this.txtNombresCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(42, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sr(a): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(42, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Saldo:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaldo.Location = new System.Drawing.Point(137, 104);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(107, 20);
            this.txtSaldo.TabIndex = 11;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAbono
            // 
            this.txtAbono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAbono.Location = new System.Drawing.Point(318, 109);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(108, 20);
            this.txtAbono.TabIndex = 1;
            this.txtAbono.Text = "0";
            this.txtAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAbono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAbono_KeyPress);
            this.txtAbono.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtAbono_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(250, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Abonar:";
            // 
            // btnCan
            // 
            this.btnCan.BackColor = System.Drawing.Color.Transparent;
            this.btnCan.BackgroundImage = global::ProyectoInte.Properties.Resources.cancelar;
            this.btnCan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCan.Location = new System.Drawing.Point(232, 143);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(71, 58);
            this.btnCan.TabIndex = 22;
            this.btnCan.TabStop = false;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            this.btnCan.MouseLeave += new System.EventHandler(this.btnCan_MouseLeave);
            this.btnCan.MouseHover += new System.EventHandler(this.btnCan_MouseHover);
            // 
            // btnAcep
            // 
            this.btnAcep.BackColor = System.Drawing.Color.Transparent;
            this.btnAcep.BackgroundImage = global::ProyectoInte.Properties.Resources.acptar;
            this.btnAcep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAcep.Location = new System.Drawing.Point(150, 143);
            this.btnAcep.Name = "btnAcep";
            this.btnAcep.Size = new System.Drawing.Size(71, 58);
            this.btnAcep.TabIndex = 21;
            this.btnAcep.TabStop = false;
            this.btnAcep.Click += new System.EventHandler(this.btnAcep_Click);
            this.btnAcep.MouseLeave += new System.EventHandler(this.btnAcep_MouseLeave);
            this.btnAcep.MouseHover += new System.EventHandler(this.btnAcep_MouseHover);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(538, 24);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(10, 20);
            this.txtIdCliente.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProyectoInte.Properties.Resources.barra_azul;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Titulo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 42);
            this.panel1.TabIndex = 24;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Titulo.Location = new System.Drawing.Point(114, 4);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(227, 37);
            this.Titulo.TabIndex = 8;
            this.Titulo.Text = "Pagar Credito";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ProyectoInte.Properties.Resources.cerrar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(411, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 23);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmPagarCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoInte.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(453, 216);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.btnAcep);
            this.Controls.Add(this.txtAbono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDocIdentidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombresCliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPagarCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmPagarCredito";
            ((System.ComponentModel.ISupportInitialize)(this.btnCan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAcep)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnCan;
        private System.Windows.Forms.PictureBox btnAcep;
        public System.Windows.Forms.TextBox txtDocIdentidad;
        public System.Windows.Forms.TextBox txtNombresCliente;
        public System.Windows.Forms.TextBox txtSaldo;
        public System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}