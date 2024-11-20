using CapaNegocio.MetodosCN;
using CapaNegocio.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_MonografiaDB
{
    public partial class FormProfesor : Form
    {
        private readonly ProfesorMCN _metodosProfesor;
        public FormProfesor()
        {
            InitializeComponent();
            _metodosProfesor = new ProfesorMCN();
        }

        public DataTable Lista_DT_Profesores()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Identificacion");
            dt.Columns.Add("Nombres");
            dt.Columns.Add("Apellidos");
            dt.Columns.Add("Telefono");
            dt.Columns.Add("Direccion");
            dt.Columns.Add("Año de Nacimiento", typeof(DateTime));

            _metodosProfesor.ListarTodosProfesores().ForEach(e =>
            {
                dt.Rows.Add(e.IdProfesor, e.Identificacion, e.Nombres, e.Apellidos, e.Telefono, e.Direccion, e.AnioNacimiento);
            });

            return dt;
        }

        private bool ErroresActivos()
        {
            foreach (Control control in this.Controls)
            {
                // Verifica si el control es un TextBox (o cualquier otro control relevante)
                if (control is TextBox || control is ComboBox || control is DateTimePicker || control is MaskedTextBox)
                {
                    // Verifica si hay un error asociado con el control
                    if (errorProvider1.GetError(control) != string.Empty)
                    {
                        return true;  // Hay al menos un error
                    }
                }
            }

            return false;  // No hay errores
        }

        public void CargarDgvProfesor()
        {
            dgvProfesor.DataSource = null;

            dgvProfesor.DataSource = Lista_DT_Profesores();
        }

        public void LimpiarTb()
        {
            tbIdentificacion.Clear();
            tbNombreProfesor.Clear();
            tbApellidosProfesor.Clear();
            tbDireccionProfesor.Clear();
            mtbTelefonoProfesor.Clear();
        }

        public void LimpiarErrores()
        {
            errorProvider1.SetError(tbIdentificacion, "");
            errorProvider1.SetError(tbNombreProfesor, "");
            errorProvider1.SetError(tbApellidosProfesor, "");
            errorProvider1.SetError(mtbTelefonoProfesor, "");
            errorProvider1.SetError(tbDireccionProfesor, "");
        }

        public bool TbVacios()
        {
            // Retornar true si estan vacios, false si tienen contenido
            var campos = new[]
            {
                tbIdentificacion.Text,
                tbNombreProfesor.Text,
                tbApellidosProfesor.Text,
                tbDireccionProfesor.Text,
                mtbTelefonoProfesor.Text,
                dtpAnioProfesor.Text
            };

            return campos.All(campo => !string.IsNullOrWhiteSpace(campo));
        }


        private void FormProfesor_Load(object sender, EventArgs e)
        {
            tbIdentificacion.Enabled = true;
            btnCancelarModificacion.Visible = false;
            btnGuardar.Visible = true;
            btnGuardarCambios.Visible = false;
            CargarDgvProfesor();
            dgvProfesor.Columns["Año de Nacimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (TbVacios() && !ErroresActivos())
            {
                ProfesorCN pro = new ProfesorCN
                {
                    Identificacion = tbIdentificacion.Text,
                    Nombres = tbNombreProfesor.Text,
                    Apellidos = tbApellidosProfesor.Text,
                    Direccion = tbDireccionProfesor.Text,
                    Telefono = int.Parse(mtbTelefonoProfesor.Text),
                    AnioNacimiento = dtpAnioProfesor.Value,
                };

                bool res = _metodosProfesor.InsertarProfesor(pro);
                if (res)
                {
                    MessageBox.Show("Profesor ingresado con Exito");
                    CargarDgvProfesor();
                    LimpiarTb();
                    LimpiarErrores();
                }
                else { MessageBox.Show("Fallo en la operacion: Profesor ya existente"); }
            }
            else
            {
                MessageBox.Show("Compruebe que los campos hayan sido ingresados correctamente.");
            }
        }

        private void btnModificarProfesor_Click(object sender, EventArgs e)
        {
            if (dgvProfesor.Rows.Count > 0)
            {
                if (dgvProfesor.SelectedRows.Count > 0)
                {
                    tbIdentificacion.Enabled = false;
                    btnEliminarProfesor.Visible = false;
                    btnCancelarModificacion.Visible = true;
                    btnGuardar.Visible = false;
                    btnGuardarCambios.Visible = true;
                    tbIdentificacion.Text = dgvProfesor.CurrentRow.Cells[1].Value.ToString();
                    tbNombreProfesor.Text = dgvProfesor.CurrentRow.Cells[2].Value.ToString();
                    tbApellidosProfesor.Text = dgvProfesor.CurrentRow.Cells[3].Value.ToString();
                    mtbTelefonoProfesor.Text = dgvProfesor.CurrentRow.Cells[4].Value.ToString();
                    tbDireccionProfesor.Text = dgvProfesor.CurrentRow.Cells[5].Value.ToString();
                    dtpAnioProfesor.Value = Convert.ToDateTime(dgvProfesor.CurrentRow.Cells[6].Value);
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una fila primero.");
                }
            }
            else
            {
                MessageBox.Show("No hay profesores para modificar.");
            }
        }

        private void btnCancelarModificacion_Click(object sender, EventArgs e)
        {
            LimpiarTb();
            LimpiarErrores();
            tbIdentificacion.Enabled = true;
            btnCancelarModificacion.Visible = false;
            btnEliminarProfesor.Visible = true;
            btnGuardar.Visible = true;
            btnGuardarCambios.Visible = false;
        }

        private void tbIdentificacion_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbIdentificacion.Text))
            {
                errorProvider1.SetError(tbIdentificacion, "Este campo no puede estar vacio.");
            }
            else
            {
                errorProvider1.SetError(tbIdentificacion, "");
            }
        }

        private void tbNombreProfesor_TextChanged(object sender, EventArgs e)
        {
            int error = Utilidades.Utilities.ValidarTextBox(tbNombreProfesor.Text);
            switch (error)
            {
                case 1:
                    errorProvider1.SetError(tbNombreProfesor, "Este campo no puede quedar vacio.");
                    break;
                case 2:
                    errorProvider1.SetError(tbNombreProfesor, "Solo se permiten letras.");
                    break;
                default:
                    errorProvider1.SetError(tbNombreProfesor, string.Empty);
                    break;
            }
        }

        private void tbDireccionProfesor_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbDireccionProfesor.Text))
            {
                errorProvider1.SetError(tbDireccionProfesor, "Este campo no puede estar vacio.");
            }
            else
            {
                errorProvider1.SetError(tbDireccionProfesor, "");
            }
        }

        private void tbApellidosProfesor_TextChanged(object sender, EventArgs e)
        {
            int error = Utilidades.Utilities.ValidarTextBox(tbApellidosProfesor.Text);
            switch (error)
            {
                case 1:
                    errorProvider1.SetError(tbApellidosProfesor, "Este campo no puede quedar vacio.");
                    break;
                case 2:
                    errorProvider1.SetError(tbApellidosProfesor, "Solo se permiten letras.");
                    break;
                default:
                    errorProvider1.SetError(tbApellidosProfesor, string.Empty);
                    break;
            }
        }

        private void mtbTelefonoProfesor_TextChanged(object sender, EventArgs e)
        {
            if (!mtbTelefonoProfesor.MaskFull)
            {
                errorProvider1.SetError(mtbTelefonoProfesor, "Este campo no puede estar vacio.");
            }
            else
            {
                errorProvider1.SetError(mtbTelefonoProfesor, "");
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (TbVacios() && !ErroresActivos())
            {
                ProfesorCN pro = new ProfesorCN
                {
                    Identificacion = tbIdentificacion.Text,
                    Nombres = tbNombreProfesor.Text,
                    Apellidos = tbApellidosProfesor.Text,
                    Direccion = tbDireccionProfesor.Text,
                    Telefono = int.Parse(mtbTelefonoProfesor.Text),
                    AnioNacimiento = dtpAnioProfesor.Value
                };

                bool res = _metodosProfesor.ModificarProfesor(pro);
                if (res)
                {
                    MessageBox.Show("Profesor Modificado con Exito");
                    tbIdentificacion.Enabled = true;
                    CargarDgvProfesor();
                    LimpiarTb();
                    LimpiarErrores();
                }
                else { MessageBox.Show("Fallo en la operacion: Error al modificar profesor."); }
            }
            else
            {
                MessageBox.Show("Compruebe que los campos hayan sido ingresados correctamente.");
            }
        }

        private void btnEliminarProfesor_Click(object sender, EventArgs e)
        {
            if (dgvProfesor.Rows.Count > 0)
            {
                if (dgvProfesor.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("¿Seguro de eliminar al Profesor?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        if (_metodosProfesor.EliminarProfesor(dgvProfesor.CurrentRow.Cells[1].Value.ToString()))
                        {
                            MessageBox.Show("Profesor eliminado correctamente.");
                            CargarDgvProfesor();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una fila primero.");
                }
            }
            else
            {
                MessageBox.Show("No hay Profesores para eliminar.");
            }
        }

        private void tbIdentificacionProfesorABuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            List<ProfesorCN> list = _metodosProfesor.BuscarProfesorPorNombreOIdentificacion(tbIdentificacionProfesorABuscar.Text);
            dt.Columns.Add("ID");
            dt.Columns.Add("Carnet");
            dt.Columns.Add("Nombres");
            dt.Columns.Add("Apellidos");
            dt.Columns.Add("Telefono");
            dt.Columns.Add("Direccion");
            dt.Columns.Add("Año de Nacimiento", typeof(DateTime));
            

            list.ForEach(t =>
            {
                dt.Rows.Add(t.IdProfesor, t.Identificacion, t.Nombres, t.Apellidos, t.Telefono, t.Direccion, t.AnioNacimiento);
            });
            dgvProfesor.DataSource = null;
            dgvProfesor.DataSource = dt;
        }
    }
}
