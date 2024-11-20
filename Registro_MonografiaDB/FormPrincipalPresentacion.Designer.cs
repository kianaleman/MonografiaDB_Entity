namespace Registro_MonografiaDB
{
    partial class FormPrincipalPresentacion
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
            this.panelSeleccion = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.BtnEstudiante = new System.Windows.Forms.Button();
            this.BtnProfesor = new System.Windows.Forms.Button();
            this.BtnMonografia = new System.Windows.Forms.Button();
            this.panelSeleccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSeleccion
            // 
            this.panelSeleccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panelSeleccion.Controls.Add(this.BtnMonografia);
            this.panelSeleccion.Controls.Add(this.BtnProfesor);
            this.panelSeleccion.Controls.Add(this.BtnEstudiante);
            this.panelSeleccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSeleccion.Location = new System.Drawing.Point(0, 0);
            this.panelSeleccion.Name = "panelSeleccion";
            this.panelSeleccion.Size = new System.Drawing.Size(1789, 92);
            this.panelSeleccion.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 92);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1789, 792);
            this.panelContenedor.TabIndex = 1;
            // 
            // BtnEstudiante
            // 
            this.BtnEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.BtnEstudiante.FlatAppearance.BorderSize = 0;
            this.BtnEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEstudiante.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEstudiante.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEstudiante.Location = new System.Drawing.Point(6, 10);
            this.BtnEstudiante.Name = "BtnEstudiante";
            this.BtnEstudiante.Size = new System.Drawing.Size(590, 75);
            this.BtnEstudiante.TabIndex = 0;
            this.BtnEstudiante.Text = "Estudiante";
            this.BtnEstudiante.UseVisualStyleBackColor = false;
            this.BtnEstudiante.Click += new System.EventHandler(this.BtnEstudiante_Click);
            // 
            // BtnProfesor
            // 
            this.BtnProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.BtnProfesor.FlatAppearance.BorderSize = 0;
            this.BtnProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProfesor.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProfesor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnProfesor.Location = new System.Drawing.Point(599, 10);
            this.BtnProfesor.Name = "BtnProfesor";
            this.BtnProfesor.Size = new System.Drawing.Size(590, 75);
            this.BtnProfesor.TabIndex = 1;
            this.BtnProfesor.Text = "Profesor";
            this.BtnProfesor.UseVisualStyleBackColor = false;
            this.BtnProfesor.Click += new System.EventHandler(this.BtnProfesor_Click);
            // 
            // BtnMonografia
            // 
            this.BtnMonografia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.BtnMonografia.FlatAppearance.BorderSize = 0;
            this.BtnMonografia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMonografia.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMonografia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnMonografia.Location = new System.Drawing.Point(1192, 10);
            this.BtnMonografia.Name = "BtnMonografia";
            this.BtnMonografia.Size = new System.Drawing.Size(590, 75);
            this.BtnMonografia.TabIndex = 1;
            this.BtnMonografia.Text = "Monografia";
            this.BtnMonografia.UseVisualStyleBackColor = false;
            this.BtnMonografia.Click += new System.EventHandler(this.BtnMonografia_Click);
            // 
            // FormPrincipalPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1789, 884);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelSeleccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipalPresentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.panelSeleccion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSeleccion;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button BtnMonografia;
        private System.Windows.Forms.Button BtnProfesor;
        private System.Windows.Forms.Button BtnEstudiante;
    }
}

