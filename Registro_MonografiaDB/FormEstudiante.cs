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
    public partial class FormEstudiante : Form
    {

        private readonly EstudianteMCN _metodosEstudiantes;

        public FormEstudiante()
        {
            InitializeComponent();
            _metodosEstudiantes = new EstudianteMCN();
        }

        public void LimpiarTb()
        {
            tbCarnetEstudiante.Clear();
            tbNombreEstudiante.Clear();
            tbApellidosEstudiante.Clear();
            tbDireccionEstudiante.Clear();
            mtbTelefonoEstudiante.Clear();
        }

        public void LimpiarErrores()
        {
            errorProvider1.SetError(tbCarnetEstudiante, "");
            errorProvider1.SetError(tbNombreEstudiante, "");
            errorProvider1.SetError(tbApellidosEstudiante, "");
            errorProvider1.SetError(mtbTelefonoEstudiante, "");
            errorProvider1.SetError(tbDireccionEstudiante, "");
        }

        public bool TbVacios()
        {
            // Retornar true si estan vacios, false si tienen contenido
            var campos = new[]
            {
                tbCarnetEstudiante.Text,
                tbNombreEstudiante.Text,
                tbApellidosEstudiante.Text,
                tbDireccionEstudiante.Text,
                mtbTelefonoEstudiante.Text,
                dtpAnioEstudiante.Text
            };

            return campos.All(campo => !string.IsNullOrWhiteSpace(campo));
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

        public DataTable Lista_DT_Estudiantes()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Carnet");
            dt.Columns.Add("Nombres");
            dt.Columns.Add("Apellidos");
            dt.Columns.Add("Telefono");
            dt.Columns.Add("Direccion");
            dt.Columns.Add("Año de Nacimiento");

            _metodosEstudiantes.ListarTodosEstudiantes()
                .ForEach(e =>
                {
                    dt.Rows.Add(e.IdEstudiante, e.Carnet, e.Nombres, e.Apellidos, e.Telefono, e.Direccion, e.AnioNacimiento);
                });

            return dt;
        }

        public void CargarDgv()
        {
            dgvEstudiantes.DataSource = null;

            dgvEstudiantes.DataSource = Lista_DT_Estudiantes();
        }

        private void FormEstudiante_Load(object sender, EventArgs e)
        {
            tbCarnetEstudiante.Enabled = true;
            btnCancelarModificacion.Visible = false;
            btnGuardar.Visible = true;
            btnGuardarCambios.Visible = false;
            CargarDgv();
        }


        private void tbCarnetEstudiante_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbCarnetEstudiante.Text))
            {
                errorProvider1.SetError(tbCarnetEstudiante, "Este campo no puede estar vacio.");
            }
            else
            {
                errorProvider1.SetError(tbCarnetEstudiante, "");
            }
        }

        private void tbNombreEstudiante_TextChanged(object sender, EventArgs e)
        {
            int error = Utilidades.Utilities.ValidarTextBox(tbNombreEstudiante.Text);
            switch (error)
            {
                case 1:
                    errorProvider1.SetError(tbNombreEstudiante, "Este campo no puede quedar vacio.");
                    break;
                case 2:
                    errorProvider1.SetError(tbNombreEstudiante, "Solo se permiten letras.");
                    break;
                default:
                    errorProvider1.SetError(tbNombreEstudiante, string.Empty);
                    break;
            }
        }

        private void tbDireccionEstudiante_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbDireccionEstudiante.Text))
            {
                errorProvider1.SetError(tbDireccionEstudiante, "Este campo no puede estar vacio.");
            }
            else
            {
                errorProvider1.SetError(tbDireccionEstudiante, "");
            }
        }

        private void tbApellidosEstudiante_TextChanged(object sender, EventArgs e)
        {
            int error = Utilidades.Utilities.ValidarTextBox(tbApellidosEstudiante.Text);
            switch (error)
            {
                case 1:
                    errorProvider1.SetError(tbApellidosEstudiante, "Este campo no puede quedar vacio.");
                    break;
                case 2:
                    errorProvider1.SetError(tbApellidosEstudiante, "Solo se permiten letras.");
                    break;
                default:
                    errorProvider1.SetError(tbApellidosEstudiante, string.Empty);
                    break;
            }
        }

        private void mtbTelefonoEstudiante_TextChanged(object sender, EventArgs e)
        {
            if (!mtbTelefonoEstudiante.MaskFull)
            {
                errorProvider1.SetError(mtbTelefonoEstudiante, "Este campo no puede estar vacio.");
            }
            else
            {
                errorProvider1.SetError(mtbTelefonoEstudiante, "");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (TbVacios() && !ErroresActivos())
            {
                EstudianteCN es = new EstudianteCN
                {
                    Carnet = tbCarnetEstudiante.Text,
                    Nombres = tbNombreEstudiante.Text,
                    Apellidos = tbApellidosEstudiante.Text,
                    Direccion = tbDireccionEstudiante.Text,
                    Telefono = int.Parse(mtbTelefonoEstudiante.Text),
                    AnioNacimiento = dtpAnioEstudiante.Value,
                    Id_Monografia = null
                };

                bool res = _metodosEstudiantes.InsertarEstudiante(es);
                if (res)
                {
                    MessageBox.Show("Estudiante ingresado con Exito");
                    CargarDgv();
                    LimpiarTb();
                    LimpiarErrores();
                }
                else { MessageBox.Show("Fallo en la operacion: Estudiante ya existente"); }
            }
            else
            {
                MessageBox.Show("Compruebe que los campos hayan sido ingresados correctamente.");
            }
        }

        private void tbCarnetABuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            List<EstudianteCN> list = _metodosEstudiantes.BuscarEstudiantePorNombre(tbCarnetABuscar.Text);
            dt.Columns.Add("ID");
            dt.Columns.Add("Carnet");
            dt.Columns.Add("Nombres");
            dt.Columns.Add("Apellidos");
            dt.Columns.Add("Telefono");
            dt.Columns.Add("Direccion");
            dt.Columns.Add("Año de Nacimiento");

            list.ForEach(t =>
                {
                    dt.Rows.Add(t.IdEstudiante, t.Carnet, t.Nombres, t.Apellidos, t.Telefono, t.Direccion, t.AnioNacimiento);
                });
            dgvEstudiantes.DataSource = null;
            dgvEstudiantes.DataSource = dt;
        }

        private void btnModificarEstudiante_Click(object sender, EventArgs e)
        {
            if (dgvEstudiantes.Rows.Count > 0)
            {
                if (dgvEstudiantes.SelectedRows.Count > 0)
                {
                    tbCarnetEstudiante.Enabled = false;
                    btnEliminarEstudiante.Visible = false;
                    btnCancelarModificacion.Visible = true;
                    btnGuardar.Visible = false;
                    btnGuardarCambios.Visible = true;
                    tbCarnetEstudiante.Text = dgvEstudiantes.CurrentRow.Cells[1].Value.ToString();
                    tbNombreEstudiante.Text = dgvEstudiantes.CurrentRow.Cells[2].Value.ToString();
                    tbApellidosEstudiante.Text = dgvEstudiantes.CurrentRow.Cells[3].Value.ToString();
                    mtbTelefonoEstudiante.Text = dgvEstudiantes.CurrentRow.Cells[4].Value.ToString();
                    tbDireccionEstudiante.Text = dgvEstudiantes.CurrentRow.Cells[5].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una fila primero.");
                }
            }
            else
            {
                MessageBox.Show("No hay estudiantes para modificar.");
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (TbVacios() && !ErroresActivos())
            {
                EstudianteCN es = new EstudianteCN
                {
                    Carnet = tbCarnetEstudiante.Text,
                    Nombres = tbNombreEstudiante.Text,
                    Apellidos = tbApellidosEstudiante.Text,
                    Direccion = tbDireccionEstudiante.Text,
                    Telefono = int.Parse(mtbTelefonoEstudiante.Text),
                    AnioNacimiento = dtpAnioEstudiante.Value
                };

                bool res = _metodosEstudiantes.ModificarEstudiante(es);
                if (res)
                {
                    MessageBox.Show("Estudiante Modificado con Exito");
                    tbCarnetEstudiante.Enabled = true;
                    CargarDgv();
                    LimpiarTb();
                    LimpiarErrores();
                    btnGuardarCambios.Visible = false;
                    btnGuardar.Visible = true;
                    btnCancelarModificacion.Visible = false;
                    btnEliminarEstudiante.Visible = true;
                }
                else { MessageBox.Show("Fallo en la operacion: Error al modificar estudiante."); }
            }
            else
            {
                MessageBox.Show("Compruebe que los campos hayan sido ingresados correctamente.");
            }
        }

        private void btnEliminarEstudiante_Click(object sender, EventArgs e)
        {
            if (dgvEstudiantes.Rows.Count > 0)
            {
                if (dgvEstudiantes.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("¿Seguro de eliminar al estudiante?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        if (_metodosEstudiantes.EliminarEstudiante(dgvEstudiantes.CurrentRow.Cells[1].Value.ToString()))
                        {
                            MessageBox.Show("Estudiante eliminado correctamente.");
                            CargarDgv();
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
                MessageBox.Show("No hay estudiantes para eliminar.");
            }
        }

        private void btnCancelarModificacion_Click(object sender, EventArgs e)
        {
            LimpiarTb();
            LimpiarErrores();
            tbCarnetEstudiante.Enabled = true;
            btnCancelarModificacion.Visible = false;
            btnEliminarEstudiante.Visible = true;
            btnGuardar.Visible = true;
            btnGuardarCambios.Visible = false;
        }
    }
}
