namespace login
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblsalir = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnentrar = new System.Windows.Forms.Button();
            this.txrcontraseña = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.checkbxmostrar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblsalir
            // 
            this.lblsalir.AutoSize = true;
            this.lblsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblsalir.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalir.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblsalir.Location = new System.Drawing.Point(117, 333);
            this.lblsalir.Name = "lblsalir";
            this.lblsalir.Size = new System.Drawing.Size(28, 13);
            this.lblsalir.TabIndex = 43;
            this.lblsalir.Text = "salir";
            this.lblsalir.Click += new System.EventHandler(this.lblsalir_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(84, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "no tienes cuenta";
            // 
            // btnentrar
            // 
            this.btnentrar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnentrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnentrar.FlatAppearance.BorderSize = 0;
            this.btnentrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnentrar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentrar.ForeColor = System.Drawing.Color.White;
            this.btnentrar.Location = new System.Drawing.Point(25, 264);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(216, 35);
            this.btnentrar.TabIndex = 41;
            this.btnentrar.Text = "ENTRAR";
            this.btnentrar.UseVisualStyleBackColor = false;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // txrcontraseña
            // 
            this.txrcontraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txrcontraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txrcontraseña.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txrcontraseña.Location = new System.Drawing.Point(25, 202);
            this.txrcontraseña.Multiline = true;
            this.txrcontraseña.Name = "txrcontraseña";
            this.txrcontraseña.PasswordChar = '*';
            this.txrcontraseña.Size = new System.Drawing.Size(216, 28);
            this.txrcontraseña.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "contraseña";
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuario.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(25, 122);
            this.txtusuario.Multiline = true;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(216, 28);
            this.txtusuario.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 20);
            this.label13.TabIndex = 37;
            this.label13.Text = "usuario";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label14.Location = new System.Drawing.Point(12, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 37);
            this.label14.TabIndex = 36;
            this.label14.Text = "INICIAR";
            // 
            // checkbxmostrar
            // 
            this.checkbxmostrar.AutoSize = true;
            this.checkbxmostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkbxmostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkbxmostrar.Location = new System.Drawing.Point(128, 236);
            this.checkbxmostrar.Name = "checkbxmostrar";
            this.checkbxmostrar.Size = new System.Drawing.Size(113, 17);
            this.checkbxmostrar.TabIndex = 44;
            this.checkbxmostrar.Text = "mostrar contraseña";
            this.checkbxmostrar.UseVisualStyleBackColor = true;
            this.checkbxmostrar.CheckedChanged += new System.EventHandler(this.checkbxmostrar_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(266, 358);
            this.Controls.Add(this.checkbxmostrar);
            this.Controls.Add(this.lblsalir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.txrcontraseña);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblsalir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.TextBox txrcontraseña;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkbxmostrar;
    }
}

