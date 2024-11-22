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

        public bool TbNoVacio()
        {
            if (String.IsNullOrWhiteSpace(tbCodigoMonografia.Text)
                || String.IsNullOrWhiteSpace(tbNotaDefensa.Text)
                || String.IsNullOrWhiteSpace(tbTiempoOtorgado.Text)
                || String.IsNullOrWhiteSpace(tbTiempoDefensa.Text)
                || String.IsNullOrWhiteSpace(tbTiempoPreguntasRespuestas.Text)
                || String.IsNullOrWhiteSpace(tbTituloMonografia.Text))
                return false;

            return true;
        }

        // Funcion para verificar si un estudiante ya fue seleccionado
        public bool EstudianteYaExiste(List<string> lista, string carnet)
        {
            return lista.Contains(carnet);
        }

        // Funcion Para verificar que no se repita la seleccion de profesor
        public bool ProfesorYaExiste(List<Pro_MonCN> lista, int idProfesor)
        {
            return lista.Any(p => p.Id_Profesor == idProfesor);
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
            dgvEstudiante0.ClearSelection();
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
            dgvEstudiante1.ClearSelection();
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
            dgvEstudiante2.ClearSelection();
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
            if (!TbNoVacio())
            {
                MessageBox.Show("Favor Llenar todos los campos");
                return;
            }

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
            int idTutor = _metodosProfesor.ObtenerIdProfesor(dgvTutor.CurrentRow.Cells[0].Value.ToString());
            if (!ProfesorYaExiste(promonList, idTutor))
            {
                promonList.Add(new Pro_MonCN
                {
                    Id_Profesor = idTutor,
                    Rol = "Tutor"
                });
            }
            else 
            {
                MessageBox.Show("Revisar que ningun Profesor se repita");
                return;
            }

            // Jurado 0
            if (dgvJurado0.CurrentRow != null)
            {
                int idJurado0 = _metodosProfesor.ObtenerIdProfesor(dgvJurado0.CurrentRow.Cells[0].Value.ToString());
                if (!ProfesorYaExiste(promonList, idJurado0))
                {
                    promonList.Add(new Pro_MonCN
                    {
                        Id_Profesor = idJurado0,
                        Rol = "Jurado"
                    });
                }
                else
                {
                    MessageBox.Show("Revisar que ningun Profesor se repita");
                    return;
                }
            }

            // Jurado 1
            if (dgvJurado1.CurrentRow != null)
            {
                int idJurado1 = _metodosProfesor.ObtenerIdProfesor(dgvJurado1.CurrentRow.Cells[0].Value.ToString());
                if (!ProfesorYaExiste(promonList, idJurado1))
                {
                    promonList.Add(new Pro_MonCN
                    {
                        Id_Profesor = idJurado1,
                        Rol = "Jurado"
                    });
                }
                else
                {
                    MessageBox.Show("Revisar que ningun Profesor se repita");
                    return;
                }
            }

            // Jurado 2
            if (dgvJurado2.CurrentRow != null)
            {
                int idJurado2 = _metodosProfesor.ObtenerIdProfesor(dgvJurado2.CurrentRow.Cells[0].Value.ToString());
                if (!ProfesorYaExiste(promonList, idJurado2))
                {
                    promonList.Add(new Pro_MonCN
                    {
                        Id_Profesor = idJurado2,
                        Rol = "Jurado"
                    });
                }
                else
                {
                    MessageBox.Show("Revisar que ningun Profesor se repita");
                    return;
                }
            }

            // Convertir la lista en arreglo
            Pro_MonCN[] promon = promonList.ToArray();


            if (_metodosMonografia.InsertarMonografia(mon, promon))
            {
                // Lista para almacenar los carnets de estudiantes seleccionados
                List<string> estudiantesProcesados = new List<string>();

                // Estudiante 0
                if (dgvEstudiante0.CurrentRow != null)
                {
                    string carnet0 = dgvEstudiante0.CurrentRow.Cells[0].Value.ToString();
                    if (!EstudianteYaExiste(estudiantesProcesados, carnet0))
                    {
                        EstudianteCN temp = new EstudianteCN
                        {
                            Carnet = carnet0,
                            Id_Monografia = _metodosMonografia.ObtenerIdMonografia(tbCodigoMonografia.Text)
                        };
                        _metodosEstudiantes.AgregarMonografia(temp);
                        estudiantesProcesados.Add(carnet0);
                    }
                    else
                    {
                        MessageBox.Show("Revisar que ningun Estudiante se repita");
                        return;
                    }
                }


                // Estudiante 1
                if (dgvEstudiante1.CurrentRow != null)
                {
                    string carnet1 = dgvEstudiante1.CurrentRow.Cells[0].Value.ToString();
                    if (!EstudianteYaExiste(estudiantesProcesados, carnet1))
                    {
                        EstudianteCN temp = new EstudianteCN
                        {
                            Carnet = carnet1,
                            Id_Monografia = _metodosMonografia.ObtenerIdMonografia(tbCodigoMonografia.Text)
                        };
                        _metodosEstudiantes.AgregarMonografia(temp);
                        estudiantesProcesados.Add(carnet1);
                    }
                    else
                    {
                        MessageBox.Show("Revisar que ningun Estudiante se repita");
                        return;
                    }
                }

                // Estudiante 2
                if (dgvEstudiante2.CurrentRow != null)
                {
                    string carnet2 = dgvEstudiante2.CurrentRow.Cells[0].Value.ToString();
                    if (!EstudianteYaExiste(estudiantesProcesados, carnet2))
                    {
                        EstudianteCN temp = new EstudianteCN
                        {
                            Carnet = carnet2,
                            Id_Monografia = _metodosMonografia.ObtenerIdMonografia(tbCodigoMonografia.Text)
                        };
                        _metodosEstudiantes.AgregarMonografia(temp);
                        estudiantesProcesados.Add(carnet2);
                    }
                    else
                    {
                        MessageBox.Show("Revisar que ningun Estudiante se repita");
                        return;
                    }
                }

                MessageBox.Show("Monografia Registrada Con exito");
                LimpiarTextBoxes();
            }
            else
            {
                MessageBox.Show("Error Al registrar Monografia");
            }
        }

        private void BtnBuscarMonografia_Click(object sender, EventArgs e)
        {
            FormBuscarMonografia openForm = new FormBuscarMonografia();
            openForm.ShowDialog();
            openForm.Hide();
        }

        private void dgvEstudiante0_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string carnet = dgvEstudiante0.CurrentRow.Cells[0].Value.ToString();
            if (_metodosEstudiantes.VerificarExistenciaMonografia(carnet) != null)
            {
                MessageBox.Show("Este Estudiante ya Posee Una Monografia");
                dgvEstudiante0.ClearSelection();
                return;
            }
        }

        private void dgvEstudiante1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string carnet = dgvEstudiante1.CurrentRow.Cells[0].Value.ToString();
            if (_metodosEstudiantes.VerificarExistenciaMonografia(carnet) != null)
            {
                MessageBox.Show("Este Estudiante ya Posee Una Monografia");
                dgvEstudiante1.ClearSelection();
                return;
            }
        }

        private void dgvEstudiante2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string carnet = dgvEstudiante2.CurrentRow.Cells[0].Value.ToString();
            if (_metodosEstudiantes.VerificarExistenciaMonografia(carnet) != null)
            {
                MessageBox.Show("Este Estudiante ya Posee Una Monografia");
                dgvEstudiante2.ClearSelection();
                return;
            }
        }
    }
}
