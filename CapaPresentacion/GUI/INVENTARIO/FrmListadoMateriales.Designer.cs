namespace ProyectoInte.GUI.INVENTARIO
{
    partial class FrmListadoMateriales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoMateriales));
            this.txtBuscarPro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnElim = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.btnAgg = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnElim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarPro
            // 
            this.txtBuscarPro.Location = new System.Drawing.Point(40, 104);
            this.txtBuscarPro.Name = "txtBuscarPro";
            this.txtBuscarPro.Size = new System.Drawing.Size(258, 20);
            this.txtBuscarPro.TabIndex = 23;
            this.txtBuscarPro.TextChanged += new System.EventHandler(this.txtBuscarPro_TextChanged);
            this.txtBuscarPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarPro_KeyPress);
            this.txtBuscarPro.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtBuscarPro_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(37, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Buscar por Nombre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProyectoInte.Properties.Resources.barra_azul;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Titulo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 46);
            this.panel1.TabIndex = 20;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Titulo.Location = new System.Drawing.Point(49, 6);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(221, 37);
            this.Titulo.TabIndex = 7;
            this.Titulo.Text = "MATERIALES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ProyectoInte.Properties.Resources.cerrar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(286, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 23);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnCerrar_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.btnCerrar_MouseHover);
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
            // 
            // btnElim
            // 
            this.btnElim.BackColor = System.Drawing.Color.Transparent;
            this.btnElim.BackgroundImage = global::ProyectoInte.Properties.Resources.material_elim;
            this.btnElim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnElim.Location = new System.Drawing.Point(208, 270);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(71, 67);
            this.btnElim.TabIndex = 27;
            this.btnElim.TabStop = false;
            this.btnElim.Click += new System.EventHandler(this.btnElim_Click);
            this.btnElim.MouseLeave += new System.EventHandler(this.btnEliminar_MouseLeave);
            this.btnElim.MouseHover += new System.EventHandler(this.btnEliminar_MouseHover);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundImage = global::ProyectoInte.Properties.Resources.material_modif;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.Location = new System.Drawing.Point(131, 270);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(71, 67);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.btnModificar_Click);
            this.btnEdit.MouseLeave += new System.EventHandler(this.btnModificar_MouseLeave);
            this.btnEdit.MouseHover += new System.EventHandler(this.btnModificar_MouseHover);
            // 
            // btnAgg
            // 
            this.btnAgg.BackColor = System.Drawing.Color.Transparent;
            this.btnAgg.BackgroundImage = global::ProyectoInte.Properties.Resources.material_agg;
            this.btnAgg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgg.Location = new System.Drawing.Point(54, 270);
            this.btnAgg.Name = "btnAgg";
            this.btnAgg.Size = new System.Drawing.Size(71, 67);
            this.btnAgg.TabIndex = 24;
            this.btnAgg.TabStop = false;
            this.btnAgg.Click += new System.EventHandler(this.btnAgg_Click);
            this.btnAgg.MouseLeave += new System.EventHandler(this.btnAgregar_MouseLeave);
            this.btnAgg.MouseHover += new System.EventHandler(this.btnAgregar_MouseHover);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Material,
            this.Stock});
            this.dataGridView1.Location = new System.Drawing.Point(40, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(258, 134);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IdM";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Material
            // 
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            this.Material.Width = 150;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 50;
            // 
            // FrmListadoMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoInte.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(327, 349);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnElim);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAgg);
            this.Controls.Add(this.txtBuscarPro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListadoMateriales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListadoMateriales";
            this.Activated += new System.EventHandler(this.FrmListadoMateriales_Activated);
            this.Load += new System.EventHandler(this.FrmListadoMateriales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnElim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnElim;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.PictureBox btnAgg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        public System.Windows.Forms.TextBox txtBuscarPro;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}