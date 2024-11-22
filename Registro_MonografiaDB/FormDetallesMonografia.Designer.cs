namespace Registro_MonografiaDB
{
    partial class FormDetallesMonografia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDetallesMonografia = new System.Windows.Forms.DataGridView();
            this.BtnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesMonografia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetallesMonografia
            // 
            this.dgvDetallesMonografia.AllowUserToAddRows = false;
            this.dgvDetallesMonografia.AllowUserToDeleteRows = false;
            this.dgvDetallesMonografia.AllowUserToResizeColumns = false;
            this.dgvDetallesMonografia.AllowUserToResizeRows = false;
            this.dgvDetallesMonografia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetallesMonografia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetallesMonografia.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDetallesMonografia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetallesMonografia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetallesMonografia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetallesMonografia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesMonografia.EnableHeadersVisualStyles = false;
            this.dgvDetallesMonografia.GridColor = System.Drawing.Color.Black;
            this.dgvDetallesMonografia.Location = new System.Drawing.Point(12, 29);
            this.dgvDetallesMonografia.MultiSelect = false;
            this.dgvDetallesMonografia.Name = "dgvDetallesMonografia";
            this.dgvDetallesMonografia.ReadOnly = true;
            this.dgvDetallesMonografia.RowHeadersVisible = false;
            this.dgvDetallesMonografia.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDetallesMonografia.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetallesMonografia.RowTemplate.Height = 24;
            this.dgvDetallesMonografia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetallesMonografia.Size = new System.Drawing.Size(1485, 203);
            this.dgvDetallesMonografia.TabIndex = 72;
            // 
            // BtnExit
            // 
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(1503, 109);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(44, 41);
            this.BtnExit.TabIndex = 73;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FormDetallesMonografia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 269);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.dgvDetallesMonografia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDetallesMonografia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDetallesMonografia";
            this.Load += new System.EventHandler(this.FormDetallesMonografia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesMonografia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetallesMonografia;
        private System.Windows.Forms.Button BtnExit;
    }
}