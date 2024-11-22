namespace Registro_MonografiaDB
{
    partial class FormBuscarMonografia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbConsultas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.TbBusqueda = new System.Windows.Forms.TextBox();
            this.indicativo = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.btnBuscarRangoFechas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbConsultas
            // 
            this.cbConsultas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConsultas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConsultas.FormattingEnabled = true;
            this.cbConsultas.Items.AddRange(new object[] {
            "TODAS LAS MONOGRAFIAS",
            "REALIZADAS POR UN TUTOR",
            "MONOGRAFIAS REALIZADAS EN UN RANGO DE FECHA",
            "MONOGRAFIAS REALIZADAS POR UN TUTOR EN UN RANGO DE FECHA",
            "BUSCAR MONOGRAFIA DADO UN ESTUDIANTE"});
            this.cbConsultas.Location = new System.Drawing.Point(273, 42);
            this.cbConsultas.Name = "cbConsultas";
            this.cbConsultas.Size = new System.Drawing.Size(643, 31);
            this.cbConsultas.TabIndex = 0;
            this.cbConsultas.SelectedIndexChanged += new System.EventHandler(this.cbConsultas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Monografia Por";
            // 
            // BtnExit
            // 
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(1203, 3);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(44, 41);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.AllowUserToAddRows = false;
            this.dgvConsultas.AllowUserToDeleteRows = false;
            this.dgvConsultas.AllowUserToResizeColumns = false;
            this.dgvConsultas.AllowUserToResizeRows = false;
            this.dgvConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvConsultas.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvConsultas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.EnableHeadersVisualStyles = false;
            this.dgvConsultas.GridColor = System.Drawing.Color.Black;
            this.dgvConsultas.Location = new System.Drawing.Point(20, 183);
            this.dgvConsultas.MultiSelect = false;
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.ReadOnly = true;
            this.dgvConsultas.RowHeadersVisible = false;
            this.dgvConsultas.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvConsultas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsultas.RowTemplate.Height = 24;
            this.dgvConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultas.Size = new System.Drawing.Size(1218, 419);
            this.dgvConsultas.TabIndex = 72;
            this.dgvConsultas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultas_CellContentClick);
            // 
            // TbBusqueda
            // 
            this.TbBusqueda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbBusqueda.Location = new System.Drawing.Point(20, 145);
            this.TbBusqueda.Name = "TbBusqueda";
            this.TbBusqueda.Size = new System.Drawing.Size(472, 32);
            this.TbBusqueda.TabIndex = 73;
            this.TbBusqueda.TextChanged += new System.EventHandler(this.BtnBusqueda_TextChanged);
            // 
            // indicativo
            // 
            this.indicativo.AutoSize = true;
            this.indicativo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicativo.Location = new System.Drawing.Point(16, 115);
            this.indicativo.Name = "indicativo";
            this.indicativo.Size = new System.Drawing.Size(228, 23);
            this.indicativo.TabIndex = 74;
            this.indicativo.Text = "Buscar Monografia Por";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(528, 141);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 32);
            this.dtpFechaInicio.TabIndex = 75;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(754, 141);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 32);
            this.dtpFechaFin.TabIndex = 76;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(524, 115);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(127, 23);
            this.lblFechaInicio.TabIndex = 77;
            this.lblFechaInicio.Text = "Fecha Inicio";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.Location = new System.Drawing.Point(750, 115);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(103, 23);
            this.lblFechaFin.TabIndex = 78;
            this.lblFechaFin.Text = "Fecha Fin";
            // 
            // btnBuscarRangoFechas
            // 
            this.btnBuscarRangoFechas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarRangoFechas.Location = new System.Drawing.Point(983, 135);
            this.btnBuscarRangoFechas.Name = "btnBuscarRangoFechas";
            this.btnBuscarRangoFechas.Size = new System.Drawing.Size(143, 42);
            this.btnBuscarRangoFechas.TabIndex = 79;
            this.btnBuscarRangoFechas.Text = "Buscar";
            this.btnBuscarRangoFechas.UseVisualStyleBackColor = true;
            this.btnBuscarRangoFechas.Click += new System.EventHandler(this.btnBuscarRangoFechas_Click);
            // 
            // FormBuscarMonografia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1250, 630);
            this.Controls.Add(this.btnBuscarRangoFechas);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.indicativo);
            this.Controls.Add(this.TbBusqueda);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbConsultas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBuscarMonografia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBuscarMonografia";
            this.Load += new System.EventHandler(this.FormBuscarMonografia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbConsultas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.TextBox TbBusqueda;
        private System.Windows.Forms.Label indicativo;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Button btnBuscarRangoFechas;
    }
}