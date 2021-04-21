namespace ProyectoInte.GUI.COMPRAS
{
    partial class Compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnElim = new System.Windows.Forms.PictureBox();
            this.btnBusc = new System.Windows.Forms.PictureBox();
            this.btnModif = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.PictureBox();
            this.btnCan = new System.Windows.Forms.PictureBox();
            this.btnAcep = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnElim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBusc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAcep)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 5;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Titulo.Location = new System.Drawing.Point(296, 13);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(177, 37);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "COMPRAS";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = global::ProyectoInte.Properties.Resources.cerrar;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.Location = new System.Drawing.Point(737, 17);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 23);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            this.btnCerrar.MouseHover += new System.EventHandler(this.btnCerrar_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.groupBox1.Location = new System.Drawing.Point(101, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 201);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Compra";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(210, 103);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(205, 20);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(210, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(203, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(210, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(210, 131);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(205, 20);
            this.textBox3.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(95, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor Total : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(865, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Proveedor : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(878, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Proveedor : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label3.Location = new System.Drawing.Point(104, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(103, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producto : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(91, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor : ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnCan);
            this.groupBox2.Controls.Add(this.btnElim);
            this.groupBox2.Controls.Add(this.btnAcep);
            this.groupBox2.Controls.Add(this.btnBusc);
            this.groupBox2.Controls.Add(this.btnModif);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.groupBox2.Location = new System.Drawing.Point(101, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 90);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // btnElim
            // 
            this.btnElim.BackgroundImage = global::ProyectoInte.Properties.Resources.compras_elim;
            this.btnElim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnElim.Location = new System.Drawing.Point(302, 20);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(73, 58);
            this.btnElim.TabIndex = 3;
            this.btnElim.TabStop = false;
            this.btnElim.Click += new System.EventHandler(this.btnElim_Click);
            this.btnElim.MouseLeave += new System.EventHandler(this.btnEliminar_MouseLeave);
            this.btnElim.MouseHover += new System.EventHandler(this.btnEliminar_MouseHover);
            // 
            // btnBusc
            // 
            this.btnBusc.BackgroundImage = global::ProyectoInte.Properties.Resources.compras_busc;
            this.btnBusc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBusc.Location = new System.Drawing.Point(212, 20);
            this.btnBusc.Name = "btnBusc";
            this.btnBusc.Size = new System.Drawing.Size(73, 58);
            this.btnBusc.TabIndex = 2;
            this.btnBusc.TabStop = false;
            this.btnBusc.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnBusc.MouseLeave += new System.EventHandler(this.btnBuscar_MouseLeave);
            this.btnBusc.MouseHover += new System.EventHandler(this.btnBuscar_MouseHover);
            // 
            // btnModif
            // 
            this.btnModif.BackgroundImage = global::ProyectoInte.Properties.Resources.compras_modf;
            this.btnModif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModif.Location = new System.Drawing.Point(124, 20);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(73, 58);
            this.btnModif.TabIndex = 1;
            this.btnModif.TabStop = false;
            this.btnModif.Click += new System.EventHandler(this.btnModificar_Click);
            this.btnModif.MouseLeave += new System.EventHandler(this.btnModificar_MouseLeave);
            this.btnModif.MouseHover += new System.EventHandler(this.btnModificar_MouseHover);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::ProyectoInte.Properties.Resources.compras_agg;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.Location = new System.Drawing.Point(40, 20);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(73, 58);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnGuardar.MouseLeave += new System.EventHandler(this.btnAgregar_MouseLeave);
            this.btnGuardar.MouseHover += new System.EventHandler(this.btnAgregar_MouseHover);
            // 
            // btnCan
            // 
            this.btnCan.BackColor = System.Drawing.Color.Transparent;
            this.btnCan.BackgroundImage = global::ProyectoInte.Properties.Resources.cancelar;
            this.btnCan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCan.Location = new System.Drawing.Point(478, 19);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(71, 58);
            this.btnCan.TabIndex = 20;
            this.btnCan.TabStop = false;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            this.btnCan.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            this.btnCan.MouseHover += new System.EventHandler(this.btnCancelar_MouseHover);
            // 
            // btnAcep
            // 
            this.btnAcep.BackColor = System.Drawing.Color.Transparent;
            this.btnAcep.BackgroundImage = global::ProyectoInte.Properties.Resources.acptar;
            this.btnAcep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAcep.Location = new System.Drawing.Point(396, 19);
            this.btnAcep.Name = "btnAcep";
            this.btnAcep.Size = new System.Drawing.Size(71, 58);
            this.btnAcep.TabIndex = 19;
            this.btnAcep.TabStop = false;
            this.btnAcep.Click += new System.EventHandler(this.btnAcep_Click);
            this.btnAcep.MouseLeave += new System.EventHandler(this.btnAgregar_MouseLeave);
            this.btnAcep.MouseHover += new System.EventHandler(this.btnAceptar_MouseHover);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoInte.Properties.Resources.wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 489);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Compras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnElim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBusc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAcep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox btnModif;
        private System.Windows.Forms.PictureBox btnGuardar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox btnElim;
        private System.Windows.Forms.PictureBox btnBusc;
        private System.Windows.Forms.PictureBox btnCan;
        private System.Windows.Forms.PictureBox btnAcep;
    }
}