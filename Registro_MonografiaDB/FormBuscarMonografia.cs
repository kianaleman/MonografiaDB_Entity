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
    public partial class FormBuscarMonografia : Form
    {
        private readonly MonografiaMCN _metodosMonografia;
        private readonly Pro_MonMCN _metodosProMon;
        private readonly ProfesorMCN _metodosProfesor;
        private readonly EstudianteMCN _metodosEstudiante;
        public FormBuscarMonografia()
        {
            InitializeComponent();
            _metodosMonografia = new MonografiaMCN();
            _metodosProMon = new Pro_MonMCN();
            _metodosProfesor = new ProfesorMCN();
            _metodosEstudiante = new EstudianteMCN();
        }

        public void CargarTodasLasMonografias()
        {
            DataTable dt = new DataTable();
            List<MonografiaCN> list = _metodosMonografia.ListarTodosMonografias();
            dt.Columns.Add("ID");
            dt.Columns.Add("Codigo Monografia");
            dt.Columns.Add("Titulo");
            dt.Columns.Add("Fecha Defendida", typeof(DateTime));
            dt.Columns.Add("Nota Defensa");
            dt.Columns.Add("Tiempo Otorgado");
            dt.Columns.Add("Tiempo Defensa");
            dt.Columns.Add("Tiempo PR");


            list.ForEach(t =>
            {
                dt.Rows.Add(t.IdMonografia, t.CodigoMonografia, t.Titulo, t.FechaDefendida, t.NotaDefensa, t.TiempoOtorgado, t.TiempoDeDefensa, t.TiempoPreguntaYRespuesta);
            });
            dgvConsultas.DataSource = null;
            dgvConsultas.DataSource = dt;
            dgvConsultas.Columns["Fecha Defendida"].DefaultCellStyle.Format = "dd/MM/yyyy";
            return;
        }

        public void MonografiasRealizadasPorUnTutor()
        {
            DataTable dt = new DataTable();
            List<MonografiaCN> list = _metodosProMon.MonografiasPorTutor(_metodosProfesor.ObtenerIdProfesor(TbBusqueda.Text));
            dt.Columns.Add("ID");
            dt.Columns.Add("Codigo Monografia");
            dt.Columns.Add("Titulo");
            dt.Columns.Add("Fecha Defendida", typeof(DateTime));
            dt.Columns.Add("Nota Defensa");
            dt.Columns.Add("Tiempo Otorgado");
            dt.Columns.Add("Tiempo Defensa");
            dt.Columns.Add("Tiempo PR");


            list.ForEach(t =>
            {
                dt.Rows.Add(t.IdMonografia, t.CodigoMonografia, t.Titulo, t.FechaDefendida, t.NotaDefensa, t.TiempoOtorgado, t.TiempoDeDefensa, t.TiempoPreguntaYRespuesta);
            });
            dgvConsultas.DataSource = null;
            dgvConsultas.DataSource = dt;
            dgvConsultas.Columns["Fecha Defendida"].DefaultCellStyle.Format = "dd/MM/yyyy";
            return;
        }

        public void MonografiasRealizadasEnUnRangoDeFecha()
        {
            DataTable dt = new DataTable();
            var list = _metodosMonografia.ListarMonografiaRangoDeFecha(dtpFechaInicio.Value, dtpFechaFin.Value);
            dt.Columns.Add("ID");
            dt.Columns.Add("Codigo Monografia");
            dt.Columns.Add("Titulo");
            dt.Columns.Add("Fecha Defendida", typeof(DateTime));
            dt.Columns.Add("Nota Defensa");
            dt.Columns.Add("Tiempo Otorgado");
            dt.Columns.Add("Tiempo Defensa");
            dt.Columns.Add("Tiempo PR");


            foreach (var t in list)
            {
                dt.Rows.Add(
                    t.IdMonografia,
                    t.CodigoMonografia,
                    t.Titulo,
                    t.FechaDefendida,
                    t.NotaDefensa,
                    t.TiempoOtorgado,
                    t.TiempoDeDefensa,
                    t.TiempoPreguntaYRespuesta
                );
            }
            dgvConsultas.DataSource = null;
            dgvConsultas.DataSource = dt;
            dgvConsultas.Columns["Fecha Defendida"].DefaultCellStyle.Format = "dd/MM/yyyy";
            return;
        }

        public void MonografiasDeUnTutorEnUnRangoDeFecha()
        {
            DataTable dt = new DataTable();
            List<MonografiaCN> list = _metodosProMon.RangoDeFechaMonografiaTutor(_metodosProfesor.ObtenerIdProfesor(TbBusqueda.Text),dtpFechaInicio.Value, dtpFechaFin.Value);
            dt.Columns.Add("ID");
            dt.Columns.Add("Codigo Monografia");
            dt.Columns.Add("Titulo");
            dt.Columns.Add("Fecha Defendida", typeof(DateTime));
            dt.Columns.Add("Nota Defensa");
            dt.Columns.Add("Tiempo Otorgado");
            dt.Columns.Add("Tiempo Defensa");
            dt.Columns.Add("Tiempo PR");


            list.ForEach(t =>
            {
                dt.Rows.Add(t.IdMonografia, t.CodigoMonografia, t.Titulo, t.FechaDefendida, t.NotaDefensa, t.TiempoOtorgado, t.TiempoDeDefensa, t.TiempoPreguntaYRespuesta);
            });
            dgvConsultas.DataSource = null;
            dgvConsultas.DataSource = dt;
            dgvConsultas.Columns["Fecha Defendida"].DefaultCellStyle.Format = "dd/MM/yyyy";
            return;
        }

        public void MonografiaDadoUnEstudiante()
        {
            TbBusqueda.Visible = true;
            indicativo.Visible = true;
            btnBuscarRangoFechas.Visible = false;
            dtpFechaInicio.Visible = false;
            dtpFechaFin.Visible = false;
            lblFechaFin.Visible = false;
            lblFechaInicio.Visible = false;

            DataTable dt = new DataTable();
            indicativo.Text = "Ingrese Carnet De Estudiante";
            MonografiaCN mon = _metodosEstudiante.ListarMonografiaDadoUnEstudiante(TbBusqueda.Text);
            if (mon != null)
            {
                dt.Columns.Add("ID");
                dt.Columns.Add("Codigo Monografia");
                dt.Columns.Add("Titulo");
                dt.Columns.Add("Fecha Defendida", typeof(DateTime));
                dt.Columns.Add("Nota Defensa");
                dt.Columns.Add("Tiempo Otorgado");
                dt.Columns.Add("Tiempo Defensa");
                dt.Columns.Add("Tiempo PR");

                dt.Rows.Add(mon.IdMonografia, mon.CodigoMonografia, mon.Titulo, mon.FechaDefendida
                    , mon.NotaDefensa, mon.TiempoOtorgado, mon.TiempoDeDefensa, mon.TiempoPreguntaYRespuesta);

                dgvConsultas.DataSource = null;
                dgvConsultas.DataSource = dt;
            }
            else if(TbBusqueda.Text.Length > 0)
            {
                dt.Columns.Add("NO HAY MONOGRAFIAS RELACIONADAS");
                dgvConsultas.DataSource = dt;
            }
        }

        public void BuscarMonografiaPorNombreOCodigo()
        {
            DataTable dt = new DataTable();
            List<MonografiaCN> list = _metodosMonografia.BuscarMonografiaPorNombreOCodigo(TbBusqueda.Text);
            dt.Columns.Add("ID");
            dt.Columns.Add("Codigo Monografia");
            dt.Columns.Add("Titulo");
            dt.Columns.Add("Fecha Defendida", typeof(DateTime));
            dt.Columns.Add("Nota Defensa");
            dt.Columns.Add("Tiempo Otorgado");
            dt.Columns.Add("Tiempo Defensa");
            dt.Columns.Add("Tiempo PR");


            list.ForEach(t =>
            {
                dt.Rows.Add(t.IdMonografia, t.CodigoMonografia, t.Titulo, t.FechaDefendida, t.NotaDefensa, t.TiempoOtorgado, t.TiempoDeDefensa, t.TiempoPreguntaYRespuesta);
            });
            dgvConsultas.DataSource = null;
            dgvConsultas.DataSource = dt;
            dgvConsultas.Columns["Fecha Defendida"].DefaultCellStyle.Format = "dd/MM/yyyy";
            return;
        }

        private void FormBuscarMonografia_Load(object sender, EventArgs e)
        {
            btnBuscarRangoFechas.Visible = false;
            lblFechaFin.Visible = false;
            lblFechaInicio.Visible = false;
            dtpFechaFin.Visible = false;
            dtpFechaInicio.Visible = false;
            TbBusqueda.Visible = false;
            indicativo.Visible = false;
            CargarTodasLasMonografias();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSeleccionado = cbConsultas.SelectedIndex;
            if (indiceSeleccionado != -1)
            {
                switch (indiceSeleccionado)
                {
                    // Cargar todas las monografias
                    case 0:
                        btnBuscarRangoFechas.Visible = false;
                        TbBusqueda.Visible = true;
                        indicativo.Visible = true;
                        indicativo.Text = "Ingrese Nombre o Codigo de Monografia a Buscar";
                        lblFechaFin.Visible = false;
                        lblFechaInicio.Visible = false;
                        dtpFechaFin.Visible = false;
                        dtpFechaInicio.Visible = false;
                        CargarTodasLasMonografias();
                        break;

                        // Hechas por un tutor
                    case 1:
                        btnBuscarRangoFechas.Visible = false;
                        lblFechaFin.Visible = false;
                        lblFechaInicio.Visible = false;
                        dtpFechaFin.Visible = false;
                        dtpFechaInicio.Visible = false;
                        TbBusqueda.Visible = true;
                        indicativo.Visible = true;
                        indicativo.Text = "Ingrese Identificacion";
                        break;

                        // Monografias en un rango de fecha
                    case 2:
                        btnBuscarRangoFechas.Visible = true;
                        TbBusqueda.Visible = false;
                        indicativo.Visible=false;
                        lblFechaFin.Visible = true;
                        lblFechaInicio.Visible = true;
                        dtpFechaFin.Visible = true;
                        dtpFechaInicio.Visible = true;
                        break;
                    case 3:
                        // Monografias Hechas por un tutor en un rango de fecha
                        btnBuscarRangoFechas.Visible = true;
                        TbBusqueda.Visible = true;
                        indicativo.Visible = true;
                        lblFechaFin.Visible = true;
                        lblFechaInicio.Visible = true;
                        dtpFechaFin.Visible = true;
                        dtpFechaInicio.Visible = true;
                        break;
                    case 4:
                        // Mostrar Monografia Dado el carnet de un estudiante
                        MonografiaDadoUnEstudiante();
                        break;
                }
            }
        }

        private void BtnBusqueda_TextChanged(object sender, EventArgs e)
        {
            switch (cbConsultas.SelectedIndex)
            {
                case 0: BuscarMonografiaPorNombreOCodigo();
                        break;
                case 1: MonografiasRealizadasPorUnTutor();
                        break;
                case 3: MonografiasDeUnTutorEnUnRangoDeFecha(); 
                        break;
                case 4: MonografiaDadoUnEstudiante();
                        break;
            }
        }

        private void btnBuscarRangoFechas_Click(object sender, EventArgs e)
        {
            if (cbConsultas.SelectedIndex == 2)
            {
                MonografiasRealizadasEnUnRangoDeFecha();
            }
            else if (cbConsultas.SelectedIndex == 3)
            {
                MonografiasDeUnTutorEnUnRangoDeFecha();
            }

        }

        private void dgvConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Título");
            dt.Columns.Add("Tutor");
            dt.Columns.Add("Jurado");
            dt.Columns.Add("Estudiantes");

            // Obtener detalles de la monografia
            int idMonografia = int.Parse(dgvConsultas.CurrentRow.Cells[0].Value.ToString());
            var detalles = _metodosMonografia.ObtenerDetallesDeMonografia(idMonografia);

            // Unir los jurados y estudiantes en cadenas separadas por comas
            string jurado = string.Join(", ", detalles.Jurado);
            string estudiantes = string.Join(", ", detalles.Estudiantes);

            // Agregar una fila al DataTable
            dt.Rows.Add(detalles.Titulo, detalles.Tutor, jurado, estudiantes);

            FormDetallesMonografia openF = new FormDetallesMonografia(dt);
            openF.ShowDialog();
            openF.Close();
        }
    }
}
