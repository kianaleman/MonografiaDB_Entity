namespace Registro_MonografiaDB
{
    partial class FormEstudiante
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.dtpAnioEstudiante = new System.Windows.Forms.DateTimePicker();
            this.btnCancelarModificacion = new System.Windows.Forms.Button();
            this.btnEliminarEstudiante = new System.Windows.Forms.Button();
            this.btnModificarEstudiante = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCarnetABuscar = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.mtbTelefonoEstudiante = new System.Windows.Forms.MaskedTextBox();
            this.tbApellidosEstudiante = new System.Windows.Forms.TextBox();
            this.tbDireccionEstudiante = new System.Windows.Forms.TextBox();
            this.tbNombreEstudiante = new System.Windows.Forms.TextBox();
            this.tbCarnetEstudiante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnGuardarCambios.Location = new System.Drawing.Point(261, 603);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(261, 50);
            this.btnGuardarCambios.TabIndex = 72;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.AllowUserToAddRows = false;
            this.dgvEstudiantes.AllowUserToDeleteRows = false;
            this.dgvEstudiantes.AllowUserToResizeColumns = false;
            this.dgvEstudiantes.AllowUserToResizeRows = false;
            this.dgvEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstudiantes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEstudiantes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvEstudiantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEstudiantes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstudiantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.EnableHeadersVisualStyles = false;
            this.dgvEstudiantes.GridColor = System.Drawing.Color.Black;
            this.dgvEstudiantes.Location = new System.Drawing.Point(1030, 150);
            this.dgvEstudiantes.MultiSelect = false;
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.ReadOnly = true;
            this.dgvEstudiantes.RowHeadersVisible = false;
            this.dgvEstudiantes.RowHeadersWidth = 51;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEstudiantes.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvEstudiantes.RowTemplate.Height = 24;
            this.dgvEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudiantes.Size = new System.Drawing.Size(720, 501);
            this.dgvEstudiantes.TabIndex = 71;
            // 
            // dtpAnioEstudiante
            // 
            this.dtpAnioEstudiante.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dtpAnioEstudiante.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAnioEstudiante.Location = new System.Drawing.Point(44, 448);
            this.dtpAnioEstudiante.Name = "dtpAnioEstudiante";
            this.dtpAnioEstudiante.Size = new System.Drawing.Size(200, 32);
            this.dtpAnioEstudiante.TabIndex = 70;
            // 
            // btnCancelarModificacion
            // 
            this.btnCancelarModificacion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCancelarModificacion.Location = new System.Drawing.Point(1488, 678);
            this.btnCancelarModificacion.Name = "btnCancelarModificacion";
            this.btnCancelarModificacion.Size = new System.Drawing.Size(201, 50);
            this.btnCancelarModificacion.TabIndex = 69;
            this.btnCancelarModificacion.Text = "Cancelar";
            this.btnCancelarModificacion.UseVisualStyleBackColor = true;
            // 
            // btnEliminarEstudiante
            // 
            this.btnEliminarEstudiante.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnEliminarEstudiante.Location = new System.Drawing.Point(1268, 678);
            this.btnEliminarEstudiante.Name = "btnEliminarEstudiante";
            this.btnEliminarEstudiante.Size = new System.Drawing.Size(201, 50);
            this.btnEliminarEstudiante.TabIndex = 68;
            this.btnEliminarEstudiante.Text = "Eliminar";
            this.btnEliminarEstudiante.UseVisualStyleBackColor = true;
            // 
            // btnModificarEstudiante
            // 
            this.btnModificarEstudiante.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnModificarEstudiante.Location = new System.Drawing.Point(1030, 678);
            this.btnModificarEstudiante.Name = "btnModificarEstudiante";
            this.btnModificarEstudiante.Size = new System.Drawing.Size(201, 50);
            this.btnModificarEstudiante.TabIndex = 67;
            this.btnModificarEstudiante.Text = "Modificar";
            this.btnModificarEstudiante.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1402, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(348, 23);
            this.label8.TabIndex = 66;
            this.label8.Text = "Ingrese Nombre o Carnet a Buscar";
            // 
            // tbCarnetABuscar
            // 
            this.tbCarnetABuscar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbCarnetABuscar.Location = new System.Drawing.Point(1406, 96);
            this.tbCarnetABuscar.Name = "tbCarnetABuscar";
            this.tbCarnetABuscar.Size = new System.Drawing.Size(344, 32);
            this.tbCarnetABuscar.TabIndex = 65;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnGuardar.Location = new System.Drawing.Point(43, 601);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(201, 50);
            this.btnGuardar.TabIndex = 64;
            this.btnGuardar.Text = "Registrar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // mtbTelefonoEstudiante
            // 
            this.mtbTelefonoEstudiante.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.mtbTelefonoEstudiante.Location = new System.Drawing.Point(409, 334);
            this.mtbTelefonoEstudiante.Mask = "0000-0000";
            this.mtbTelefonoEstudiante.Name = "mtbTelefonoEstudiante";
            this.mtbTelefonoEstudiante.Size = new System.Drawing.Size(245, 32);
            this.mtbTelefonoEstudiante.TabIndex = 63;
            this.mtbTelefonoEstudiante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbTelefonoEstudiante.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbTelefonoEstudiante.TextChanged += new System.EventHandler(this.mtbTelefonoEstudiante_TextChanged);
            // 
            // tbApellidosEstudiante
            // 
            this.tbApellidosEstudiante.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbApellidosEstudiante.Location = new System.Drawing.Point(409, 227);
            this.tbApellidosEstudiante.Name = "tbApellidosEstudiante";
            this.tbApellidosEstudiante.Size = new System.Drawing.Size(245, 32);
            this.tbApellidosEstudiante.TabIndex = 62;
            this.tbApellidosEstudiante.TextChanged += new System.EventHandler(this.tbApellidosEstudiante_TextChanged);
            // 
            // tbDireccionEstudiante
            // 
            this.tbDireccionEstudiante.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbDireccionEstudiante.Location = new System.Drawing.Point(44, 334);
            this.tbDireccionEstudiante.Name = "tbDireccionEstudiante";
            this.tbDireccionEstudiante.Size = new System.Drawing.Size(245, 32);
            this.tbDireccionEstudiante.TabIndex = 61;
            this.tbDireccionEstudiante.TextChanged += new System.EventHandler(this.tbDireccionEstudiante_TextChanged);
            // 
            // tbNombreEstudiante
            // 
            this.tbNombreEstudiante.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbNombreEstudiante.Location = new System.Drawing.Point(43, 227);
            this.tbNombreEstudiante.Name = "tbNombreEstudiante";
            this.tbNombreEstudiante.Size = new System.Drawing.Size(245, 32);
            this.tbNombreEstudiante.TabIndex = 60;
            this.tbNombreEstudiante.TextChanged += new System.EventHandler(this.tbNombreEstudiante_TextChanged);
            // 
            // tbCarnetEstudiante
            // 
            this.tbCarnetEstudiante.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbCarnetEstudiante.Location = new System.Drawing.Point(38, 138);
            this.tbCarnetEstudiante.Name = "tbCarnetEstudiante";
            this.tbCarnetEstudiante.Size = new System.Drawing.Size(245, 32);
            this.tbCarnetEstudiante.TabIndex = 59;
            this.tbCarnetEstudiante.TextChanged += new System.EventHandler(this.tbCarnetEstudiante_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 23);
            this.label5.TabIndex = 58;
            this.label5.Text = "Año de Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(405, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 57;
            this.label6.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 56;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 55;
            this.label4.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 54;
            this.label2.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 53;
            this.label1.Text = "Carnet";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1789, 792);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.dgvEstudiantes);
            this.Controls.Add(this.dtpAnioEstudiante);
            this.Controls.Add(this.btnCancelarModificacion);
            this.Controls.Add(this.btnEliminarEstudiante);
            this.Controls.Add(this.btnModificarEstudiante);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbCarnetABuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.mtbTelefonoEstudiante);
            this.Controls.Add(this.tbApellidosEstudiante);
            this.Controls.Add(this.tbDireccionEstudiante);
            this.Controls.Add(this.tbNombreEstudiante);
            this.Controls.Add(this.tbCarnetEstudiante);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEstudiante";
            this.Text = "FormEstudiante";
            this.Load += new System.EventHandler(this.FormEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.DateTimePicker dtpAnioEstudiante;
        private System.Windows.Forms.Button btnCancelarModificacion;
        private System.Windows.Forms.Button btnEliminarEstudiante;
        private System.Windows.Forms.Button btnModificarEstudiante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCarnetABuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.MaskedTextBox mtbTelefonoEstudiante;
        private System.Windows.Forms.TextBox tbApellidosEstudiante;
        private System.Windows.Forms.TextBox tbDireccionEstudiante;
        private System.Windows.Forms.TextBox tbNombreEstudiante;
        private System.Windows.Forms.TextBox tbCarnetEstudiante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}