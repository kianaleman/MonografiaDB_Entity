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
            dt.Columns.Add("IdMonografia");

            _metodosEstudiantes.ListarTodosEstudiantes()
                .ForEach(e =>
                {
                    dt.Rows.Add(e.IdEstudiante, e.Carnet, e.Nombres, e.Apellidos, e.Telefono, e.Direccion, e.AnioNacimiento, e.Id_Monografia);
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
                    Id_Monografia = -1
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
    }
}
