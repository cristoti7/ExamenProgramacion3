namespace ExamenProgramacion3
{
    partial class IngresoSistema
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTituloPro3 = new System.Windows.Forms.Label();
            this.PanelIngreso = new System.Windows.Forms.Panel();
            this.linkLabelIdioma = new System.Windows.Forms.LinkLabel();
            this.butonCerrar = new System.Windows.Forms.Button();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.labelClave = new System.Windows.Forms.Label();
            this.labelAccesoSistema = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.PanelIngreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTituloPro3
            // 
            this.labelTituloPro3.AutoSize = true;
            this.labelTituloPro3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloPro3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTituloPro3.Location = new System.Drawing.Point(12, 9);
            this.labelTituloPro3.Name = "labelTituloPro3";
            this.labelTituloPro3.Size = new System.Drawing.Size(269, 31);
            this.labelTituloPro3.TabIndex = 14;
            this.labelTituloPro3.Text = "PROGRAMACION3";
            // 
            // PanelIngreso
            // 
            this.PanelIngreso.BackColor = System.Drawing.Color.Navy;
            this.PanelIngreso.Controls.Add(this.linkLabelIdioma);
            this.PanelIngreso.Controls.Add(this.butonCerrar);
            this.PanelIngreso.Controls.Add(this.botonAceptar);
            this.PanelIngreso.Controls.Add(this.textBoxClave);
            this.PanelIngreso.Controls.Add(this.textBoxUsuario);
            this.PanelIngreso.Controls.Add(this.labelClave);
            this.PanelIngreso.Controls.Add(this.labelAccesoSistema);
            this.PanelIngreso.Controls.Add(this.labelUsuario);
            this.PanelIngreso.Location = new System.Drawing.Point(-7, 43);
            this.PanelIngreso.Name = "PanelIngreso";
            this.PanelIngreso.Size = new System.Drawing.Size(321, 301);
            this.PanelIngreso.TabIndex = 15;
            // 
            // linkLabelIdioma
            // 
            this.linkLabelIdioma.AutoSize = true;
            this.linkLabelIdioma.BackColor = System.Drawing.Color.White;
            this.linkLabelIdioma.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelIdioma.Location = new System.Drawing.Point(31, 209);
            this.linkLabelIdioma.Name = "linkLabelIdioma";
            this.linkLabelIdioma.Size = new System.Drawing.Size(47, 16);
            this.linkLabelIdioma.TabIndex = 4;
            this.linkLabelIdioma.TabStop = true;
            this.linkLabelIdioma.Text = "English";
            // 
            // butonCerrar
            // 
            this.butonCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonCerrar.ForeColor = System.Drawing.Color.Black;
            this.butonCerrar.Location = new System.Drawing.Point(158, 160);
            this.butonCerrar.Name = "butonCerrar";
            this.butonCerrar.Size = new System.Drawing.Size(99, 46);
            this.butonCerrar.TabIndex = 5;
            this.butonCerrar.Text = "CERRAR";
            this.butonCerrar.UseVisualStyleBackColor = true;
            // 
            // botonAceptar
            // 
            this.botonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAceptar.ForeColor = System.Drawing.Color.Black;
            this.botonAceptar.Location = new System.Drawing.Point(40, 160);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(101, 46);
            this.botonAceptar.TabIndex = 3;
            this.botonAceptar.Text = "ACEPTAR";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // textBoxClave
            // 
            this.textBoxClave.Location = new System.Drawing.Point(106, 106);
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.PasswordChar = '*';
            this.textBoxClave.Size = new System.Drawing.Size(151, 20);
            this.textBoxClave.TabIndex = 2;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(106, 60);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(151, 20);
            this.textBoxUsuario.TabIndex = 1;
            // 
            // labelClave
            // 
            this.labelClave.AutoSize = true;
            this.labelClave.BackColor = System.Drawing.Color.White;
            this.labelClave.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClave.Location = new System.Drawing.Point(37, 113);
            this.labelClave.Name = "labelClave";
            this.labelClave.Size = new System.Drawing.Size(38, 16);
            this.labelClave.TabIndex = 2;
            this.labelClave.Text = "Clave";
            // 
            // labelAccesoSistema
            // 
            this.labelAccesoSistema.AutoSize = true;
            this.labelAccesoSistema.BackColor = System.Drawing.Color.White;
            this.labelAccesoSistema.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccesoSistema.Location = new System.Drawing.Point(103, 32);
            this.labelAccesoSistema.Name = "labelAccesoSistema";
            this.labelAccesoSistema.Size = new System.Drawing.Size(114, 16);
            this.labelAccesoSistema.TabIndex = 0;
            this.labelAccesoSistema.Text = "Acceso al Sistema";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelUsuario.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(33, 63);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(51, 16);
            this.labelUsuario.TabIndex = 1;
            this.labelUsuario.Text = "Usuario";
            // 
            // IngresoSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 344);
            this.Controls.Add(this.PanelIngreso);
            this.Controls.Add(this.labelTituloPro3);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.Name = "IngresoSistema";
            this.Text = "Form1";
            this.PanelIngreso.ResumeLayout(false);
            this.PanelIngreso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloPro3;
        private System.Windows.Forms.Panel PanelIngreso;
        private System.Windows.Forms.LinkLabel linkLabelIdioma;
        private System.Windows.Forms.Button butonCerrar;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.TextBox textBoxClave;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label labelClave;
        private System.Windows.Forms.Label labelAccesoSistema;
        private System.Windows.Forms.Label labelUsuario;
    }
}

