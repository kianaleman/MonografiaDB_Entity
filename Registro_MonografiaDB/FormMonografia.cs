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
    public partial class FormMonografia : Form
    {
        private readonly ProfesorMCN _metodosProfesor;
        private readonly EstudianteMCN _metodosEstudiantes;
        private readonly MonografiaMCN _metodosMonografia;
        public FormMonografia()
        {
            InitializeComponent();
            _metodosProfesor = new ProfesorMCN();
            _metodosEstudiantes = new EstudianteMCN();
            _metodosMonografia = new MonografiaMCN();
        }

        private void LimpiarTextBoxes()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
            }
        }


        private void tbIdentificacionTutor_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            List<ProfesorCN> list = _metodosProfesor.BuscarProfesorPorNombreOIdentificacion(tbIdentificacionTutor.Text);
            dt.Columns.Add("Identificacion");
            dt.Columns.Add("Nombres");
            dt.Columns.Add("Apellidos");


            list.ForEach(t =>
            {
                dt.Rows.Add(t.Identificacion, t.Nombres, t.Apellidos);
            });
            dgvTutor.DataSource = null;
            dgvTutor.DataSource = dt;
        }

        private void tbCarnetEstudiante0_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            List<EstudianteCN> list = _metodosEstudiantes.BuscarEstudiantePorNombre(tbCarnetEstudiante0.Text);
            dt.Columns.Add("Carnet");
            dt.Columns.Add("Nombres");
            dt.Columns.Add("Apellidos");


            list.ForEach(t =>
            {
                dt.Rows.Add(t.Carnet, t.Nombres, t.Apellidos);
            });
            dgvEstudiante0.DataSource = null;
            dgvEstudiante0.DataSource = dt;
        }

        private void tbCarnetEstudiante1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            List<EstudianteCN> list = _metodosEstudiantes.BuscarEstudiantePorNombre(tbCarnetEstudiante1.Text);
            dt.Columns.Add("Carnet");
            dt.Columns.Add("Nombres");
            dt.Columns.Add("Apellidos");


            list.ForEach(t =>
            {
                dt.Rows.Add(t.Carnet, t.Nombres, t.Apellidos);
            });
            dgvEstudiante1.DataSource = null;
            dgvEstudiante1.DataSource = dt;
        }

        private void tbCarnetEstudiante2_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            List<EstudianteCN> list = _metodosEstudiantes.BuscarEstudiantePorNombre(tbCarnetEstudiante2.Text);
            dt.Columns.Add("Carnet");
            dt.Columns.Add("Nombres");
            dt.Columns.Add("Apellidos");


            list.ForEach(t =>
            {
                dt.Rows.Add(t.Carnet, t.Nombres, t.Apellidos);
            });
            dgvEstudiante2.DataSource = null;
            dgvEstudiante2.DataSource = dt;
        }

        private void tbJurado0_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            List<ProfesorCN> list = _metodosProfesor.BuscarProfesorPorNombreOIdentificacion(tbJurado0.Text);
            dt.Columns.Add("Identificacion");
            dt.Columns.Add("Nombres");
            dt.Columns.Add("Apellidos");


            list.ForEach(t =>
            {
                dt.Rows.Add(t.Identificacion, t.Nombres, t.Apellidos);
            });
            dgvJurado0.DataSource = null;
            dgvJurado0.DataSource = dt;
        }

        private void tbJurado1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            List<ProfesorCN> list = _metodosProfesor.BuscarProfesorPorNombreOIdentificacion(tbJurado1.Text);
            dt.Columns.Add("Identificacion");
            dt.Columns.Add("Nombres");
            dt.Columns.Add("Apellidos");


            list.ForEach(t =>
            {
                dt.Rows.Add(t.Identificacion, t.Nombres, t.Apellidos);
            });
            dgvJurado1.DataSource = null;
            dgvJurado1.DataSource = dt;
        }

        private void tbJurado2_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            List<ProfesorCN> list = _metodosProfesor.BuscarProfesorPorNombreOIdentificacion(tbJurado2.Text);
            dt.Columns.Add("Identificacion");
            dt.Columns.Add("Nombres");
            dt.Columns.Add("Apellidos");


            list.ForEach(t =>
            {
                dt.Rows.Add(t.Identificacion, t.Nombres, t.Apellidos);
            });
            dgvJurado2.DataSource = null;
            dgvJurado2.DataSource = dt;
        }

        private void btnRegistrarMonografia_Click(object sender, EventArgs e)
        {
            MonografiaCN mon = new MonografiaCN 
            {
                CodigoMonografia = tbCodigoMonografia.Text,
                Titulo = tbTituloMonografia.Text,
                FechaDefendida = dtpFechaDefendida.Value,
                NotaDefensa = int.Parse(tbNotaDefensa.Text),
                TiempoOtorgado = int.Parse(tbTiempoOtorgado.Text),
                TiempoDeDefensa = int.Parse(tbTiempoDefensa.Text),
                TiempoPreguntaYRespuesta = int.Parse(tbTiempoPreguntasRespuestas.Text)
            };

            List<Pro_MonCN> promonList = new List<Pro_MonCN>();

            // Tutor
            promonList.Add(new Pro_MonCN
            {
                Id_Profesor = _metodosProfesor.ObtenerIdProfesor(dgvTutor.CurrentRow.Cells[0].Value.ToString()),
                Rol = "Tutor"
            });

            // Jurado 0
            if (dgvJurado0.CurrentRow != null)
            {
                promonList.Add(new Pro_MonCN
                {
                    Id_Profesor = _metodosProfesor.ObtenerIdProfesor(dgvJurado0.CurrentRow.Cells[0].Value.ToString()),
                    Rol = "Jurado"
                });
            }

            // Jurado 1
            if (dgvJurado1.CurrentRow != null)
            {
                promonList.Add(new Pro_MonCN
                {
                    Id_Profesor = _metodosProfesor.ObtenerIdProfesor(dgvJurado1.CurrentRow.Cells[0].Value.ToString()),
                    Rol = "Jurado"
                });
            }

            // Jurado 2
            if (dgvJurado2.CurrentRow != null)
            {
                promonList.Add(new Pro_MonCN
                {
                    Id_Profesor = _metodosProfesor.ObtenerIdProfesor(dgvJurado2.CurrentRow.Cells[0].Value.ToString()),
                    Rol = "Jurado"
                });
            }

            // Convertir la lista en arreglo
            Pro_MonCN[] promon = promonList.ToArray();


            if (_metodosMonografia.InsertarMonografia(mon, promon))
            {
                // Verificar si se ha seleccionado un estudiante antes de agregar
                if (dgvEstudiante0.CurrentRow != null)
                {
                    EstudianteCN temp = new EstudianteCN
                    {
                        Carnet = dgvEstudiante0.CurrentRow.Cells[0].Value.ToString(),
                        Id_Monografia = _metodosMonografia.ObtenerIdMonografia(tbCodigoMonografia.Text)
                    };
                    _metodosEstudiantes.AgregarMonografia(temp);
                }

                if (dgvEstudiante1.CurrentRow != null)
                {
                    EstudianteCN temp = new EstudianteCN
                    {
                        Carnet = dgvEstudiante1.CurrentRow.Cells[0].Value.ToString(),
                        Id_Monografia = _metodosMonografia.ObtenerIdMonografia(tbCodigoMonografia.Text)
                    };
                    _metodosEstudiantes.AgregarMonografia(temp);
                }

                if (dgvEstudiante2.CurrentRow != null)
                {
                    EstudianteCN temp = new EstudianteCN
                    {
                        Carnet = dgvEstudiante2.CurrentRow.Cells[0].Value.ToString(),
                        Id_Monografia = _metodosMonografia.ObtenerIdMonografia(tbCodigoMonografia.Text)
                    };
                    _metodosEstudiantes.AgregarMonografia(temp);
                }

                MessageBox.Show("Monografia Registrada Con exito");
                LimpiarTextBoxes();
            }
            else
            {
                MessageBox.Show("Error Al registrar Monografia");
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscarMonografia_Click(object sender, EventArgs e)
        {
            FormBuscarMonografia openForm = new FormBuscarMonografia();
            openForm.ShowDialog();
            openForm.Hide();
        }
    }
}
