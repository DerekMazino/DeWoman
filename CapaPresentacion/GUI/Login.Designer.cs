namespace ProyectoInte
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcIngresar = new System.Windows.Forms.PictureBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnMini = new System.Windows.Forms.PictureBox();
            this.btnOff = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcIngresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOff)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ProyectoInte.Properties.Resources.login2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnOff);
            this.panel1.Controls.Add(this.btnMini);
            this.panel1.Controls.Add(this.pcIngresar);
            this.panel1.Controls.Add(this.txtClave);
            this.panel1.Controls.Add(this.txtuser);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Location = new System.Drawing.Point(130, 88);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(500, 280);
            this.panel1.TabIndex = 8;
            // 
            // pcIngresar
            // 
            this.pcIngresar.BackgroundImage = global::ProyectoInte.Properties.Resources.ingre;
            this.pcIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcIngresar.Location = new System.Drawing.Point(380, 106);
            this.pcIngresar.Name = "pcIngresar";
            this.pcIngresar.Size = new System.Drawing.Size(70, 60);
            this.pcIngresar.TabIndex = 9;
            this.pcIngresar.TabStop = false;
            this.pcIngresar.Click += new System.EventHandler(this.pcIngresar_Click);
            this.pcIngresar.MouseLeave += new System.EventHandler(this.pcIngresar_MouseLeave);
            this.pcIngresar.MouseHover += new System.EventHandler(this.pcIngresar_MouseHover);
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.SkyBlue;
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtClave.Location = new System.Drawing.Point(120, 156);
            this.txtClave.Name = "txtClave";
            this.txtClave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClave.Size = new System.Drawing.Size(224, 19);
            this.txtClave.TabIndex = 8;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.SkyBlue;
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtuser.Location = new System.Drawing.Point(120, 105);
            this.txtuser.Name = "txtuser";
            this.txtuser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtuser.Size = new System.Drawing.Size(224, 19);
            this.txtuser.TabIndex = 7;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.lblFecha.Location = new System.Drawing.Point(198, 234);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFecha.Size = new System.Drawing.Size(59, 20);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMini
            // 
            this.btnMini.BackgroundImage = global::ProyectoInte.Properties.Resources.minimi;
            this.btnMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMini.Location = new System.Drawing.Point(24, 223);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(36, 34);
            this.btnMini.TabIndex = 10;
            this.btnMini.TabStop = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            this.btnMini.MouseLeave += new System.EventHandler(this.btnMini_MouseLeave);
            this.btnMini.MouseHover += new System.EventHandler(this.btnMini_MouseHover);
            // 
            // btnOff
            // 
            this.btnOff.BackgroundImage = global::ProyectoInte.Properties.Resources.off;
            this.btnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOff.Location = new System.Drawing.Point(62, 224);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(36, 34);
            this.btnOff.TabIndex = 11;
            this.btnOff.TabStop = false;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            this.btnOff.MouseLeave += new System.EventHandler(this.btnOff_MouseLeave);
            this.btnOff.MouseHover += new System.EventHandler(this.btnOff_MouseHover);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoInte.Properties.Resources.Fondox;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 441);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login ~ ShoeSoft";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcIngresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.PictureBox pcIngresar;
        private System.Windows.Forms.PictureBox btnOff;
        private System.Windows.Forms.PictureBox btnMini;
    }
}