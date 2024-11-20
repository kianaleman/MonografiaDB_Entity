namespace Registro_MonografiaDB
{
    partial class FormProfesor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProfesor = new System.Windows.Forms.DataGridView();
            this.btnCancelarModificacion = new System.Windows.Forms.Button();
            this.btnEliminarProfesor = new System.Windows.Forms.Button();
            this.btnModificarProfesor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbIdentificacionProfesorABuscar = new System.Windows.Forms.TextBox();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.dtpAnioProfesor = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.mtbTelefonoProfesor = new System.Windows.Forms.MaskedTextBox();
            this.tbApellidosProfesor = new System.Windows.Forms.TextBox();
            this.tbDireccionProfesor = new System.Windows.Forms.TextBox();
            this.tbNombreProfesor = new System.Windows.Forms.TextBox();
            this.tbIdentificacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProfesor
            // 
            this.dgvProfesor.AllowUserToAddRows = false;
            this.dgvProfesor.AllowUserToDeleteRows = false;
            this.dgvProfesor.AllowUserToResizeColumns = false;
            this.dgvProfesor.AllowUserToResizeRows = false;
            this.dgvProfesor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProfesor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProfesor.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvProfesor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProfesor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProfesor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesor.EnableHeadersVisualStyles = false;
            this.dgvProfesor.GridColor = System.Drawing.Color.Black;
            this.dgvProfesor.Location = new System.Drawing.Point(944, 201);
            this.dgvProfesor.MultiSelect = false;
            this.dgvProfesor.Name = "dgvProfesor";
            this.dgvProfesor.ReadOnly = true;
            this.dgvProfesor.RowHeadersVisible = false;
            this.dgvProfesor.RowHeadersWidth = 51;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProfesor.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvProfesor.RowTemplate.Height = 24;
            this.dgvProfesor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfesor.Size = new System.Drawing.Size(827, 423);
            this.dgvProfesor.TabIndex = 92;
            // 
            // btnCancelarModificacion
            // 
            this.btnCancelarModificacion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCancelarModificacion.Location = new System.Drawing.Point(1201, 671);
            this.btnCancelarModificacion.Name = "btnCancelarModificacion";
            this.btnCancelarModificacion.Size = new System.Drawing.Size(201, 50);
            this.btnCancelarModificacion.TabIndex = 91;
            this.btnCancelarModificacion.Text = "Cancelar";
            this.btnCancelarModificacion.UseVisualStyleBackColor = true;
            this.btnCancelarModificacion.Click += new System.EventHandler(this.btnCancelarModificacion_Click);
            // 
            // btnEliminarProfesor
            // 
            this.btnEliminarProfesor.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnEliminarProfesor.Location = new System.Drawing.Point(1201, 671);
            this.btnEliminarProfesor.Name = "btnEliminarProfesor";
            this.btnEliminarProfesor.Size = new System.Drawing.Size(201, 50);
            this.btnEliminarProfesor.TabIndex = 90;
            this.btnEliminarProfesor.Text = "Eliminar";
            this.btnEliminarProfesor.UseVisualStyleBackColor = true;
            this.btnEliminarProfesor.Click += new System.EventHandler(this.btnEliminarProfesor_Click);
            // 
            // btnModificarProfesor
            // 
            this.btnModificarProfesor.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnModificarProfesor.Location = new System.Drawing.Point(944, 671);
            this.btnModificarProfesor.Name = "btnModificarProfesor";
            this.btnModificarProfesor.Size = new System.Drawing.Size(201, 50);
            this.btnModificarProfesor.TabIndex = 89;
            this.btnModificarProfesor.Text = "Modificar";
            this.btnModificarProfesor.UseVisualStyleBackColor = true;
            this.btnModificarProfesor.Click += new System.EventHandler(this.btnModificarProfesor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1362, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(409, 18);
            this.label8.TabIndex = 88;
            this.label8.Text = "Ingresar Nombre o Identificacion de Profesor a Buscar";
            // 
            // tbIdentificacionProfesorABuscar
            // 
            this.tbIdentificacionProfesorABuscar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbIdentificacionProfesorABuscar.Location = new System.Drawing.Point(1365, 133);
            this.tbIdentificacionProfesorABuscar.Name = "tbIdentificacionProfesorABuscar";
            this.tbIdentificacionProfesorABuscar.Size = new System.Drawing.Size(406, 32);
            this.tbIdentificacionProfesorABuscar.TabIndex = 87;
            this.tbIdentificacionProfesorABuscar.TextChanged += new System.EventHandler(this.tbIdentificacionProfesorABuscar_TextChanged);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnGuardarCambios.Location = new System.Drawing.Point(55, 537);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(261, 50);
            this.btnGuardarCambios.TabIndex = 86;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // dtpAnioProfesor
            // 
            this.dtpAnioProfesor.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dtpAnioProfesor.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAnioProfesor.Location = new System.Drawing.Point(59, 430);
            this.dtpAnioProfesor.Name = "dtpAnioProfesor";
            this.dtpAnioProfesor.Size = new System.Drawing.Size(200, 32);
            this.dtpAnioProfesor.TabIndex = 85;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnGuardar.Location = new System.Drawing.Point(55, 537);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(201, 50);
            this.btnGuardar.TabIndex = 84;
            this.btnGuardar.Text = "Registrar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // mtbTelefonoProfesor
            // 
            this.mtbTelefonoProfesor.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.mtbTelefonoProfesor.Location = new System.Drawing.Point(437, 322);
            this.mtbTelefonoProfesor.Mask = "0000-0000";
            this.mtbTelefonoProfesor.Name = "mtbTelefonoProfesor";
            this.mtbTelefonoProfesor.Size = new System.Drawing.Size(245, 32);
            this.mtbTelefonoProfesor.TabIndex = 83;
            this.mtbTelefonoProfesor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbTelefonoProfesor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbTelefonoProfesor.TextChanged += new System.EventHandler(this.mtbTelefonoProfesor_TextChanged);
            // 
            // tbApellidosProfesor
            // 
            this.tbApellidosProfesor.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbApellidosProfesor.Location = new System.Drawing.Point(437, 227);
            this.tbApellidosProfesor.Name = "tbApellidosProfesor";
            this.tbApellidosProfesor.Size = new System.Drawing.Size(245, 32);
            this.tbApellidosProfesor.TabIndex = 82;
            this.tbApellidosProfesor.TextChanged += new System.EventHandler(this.tbApellidosProfesor_TextChanged);
            // 
            // tbDireccionProfesor
            // 
            this.tbDireccionProfesor.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbDireccionProfesor.Location = new System.Drawing.Point(62, 322);
            this.tbDireccionProfesor.Name = "tbDireccionProfesor";
            this.tbDireccionProfesor.Size = new System.Drawing.Size(245, 32);
            this.tbDireccionProfesor.TabIndex = 81;
            this.tbDireccionProfesor.TextChanged += new System.EventHandler(this.tbDireccionProfesor_TextChanged);
            // 
            // tbNombreProfesor
            // 
            this.tbNombreProfesor.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbNombreProfesor.Location = new System.Drawing.Point(59, 227);
            this.tbNombreProfesor.Name = "tbNombreProfesor";
            this.tbNombreProfesor.Size = new System.Drawing.Size(245, 32);
            this.tbNombreProfesor.TabIndex = 80;
            this.tbNombreProfesor.TextChanged += new System.EventHandler(this.tbNombreProfesor_TextChanged);
            // 
            // tbIdentificacion
            // 
            this.tbIdentificacion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbIdentificacion.Location = new System.Drawing.Point(59, 120);
            this.tbIdentificacion.Name = "tbIdentificacion";
            this.tbIdentificacion.Size = new System.Drawing.Size(245, 32);
            this.tbIdentificacion.TabIndex = 79;
            this.tbIdentificacion.TextChanged += new System.EventHandler(this.tbIdentificacion_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 23);
            this.label5.TabIndex = 78;
            this.label5.Text = "Año de Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(433, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 77;
            this.label6.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 76;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(433, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 75;
            this.label4.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 74;
            this.label2.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 73;
            this.label1.Text = "Identificacion";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1789, 792);
            this.Controls.Add(this.dgvProfesor);
            this.Controls.Add(this.btnCancelarModificacion);
            this.Controls.Add(this.btnEliminarProfesor);
            this.Controls.Add(this.btnModificarProfesor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbIdentificacionProfesorABuscar);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.dtpAnioProfesor);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.mtbTelefonoProfesor);
            this.Controls.Add(this.tbApellidosProfesor);
            this.Controls.Add(this.tbDireccionProfesor);
            this.Controls.Add(this.tbNombreProfesor);
            this.Controls.Add(this.tbIdentificacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProfesor";
            this.Text = "FormProfesor";
            this.Load += new System.EventHandler(this.FormProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProfesor;
        private System.Windows.Forms.Button btnCancelarModificacion;
        private System.Windows.Forms.Button btnEliminarProfesor;
        private System.Windows.Forms.Button btnModificarProfesor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbIdentificacionProfesorABuscar;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.DateTimePicker dtpAnioProfesor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.MaskedTextBox mtbTelefonoProfesor;
        private System.Windows.Forms.TextBox tbApellidosProfesor;
        private System.Windows.Forms.TextBox tbDireccionProfesor;
        private System.Windows.Forms.TextBox tbNombreProfesor;
        private System.Windows.Forms.TextBox tbIdentificacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}