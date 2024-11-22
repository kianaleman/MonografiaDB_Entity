using CapaDatos;
using CapaNegocio.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.MetodosCN
{
    public class EstudianteMCN
    {
        private readonly EstudianteMCD _metodosEstudiante;

        public EstudianteMCN()
        {
            _metodosEstudiante = new EstudianteMCD();
        }

        public bool InsertarEstudiante(EstudianteCN est)
        {
            Estudiante est2 = new Estudiante
            {
                Carnet = est.Carnet,
                Nombres = est.Nombres,
                Apellidos = est.Apellidos,
                Direccion = est.Direccion,
                Telefono = est.Telefono,
                AnioNacimiento = est.AnioNacimiento,
                Id_Monografia = est.Id_Monografia
            };
            return _metodosEstudiante.InsertarEstudiante(est2);
        }

        public bool AgregarMonografia(EstudianteCN est)
        {
            Estudiante estudianteOriginal = new Estudiante 
            {
                Carnet = est.Carnet,
                Id_Monografia = est.Id_Monografia,
            };
            return _metodosEstudiante.AgregarMonografia(estudianteOriginal);
        }
        public int ObtenerIdEstudiante(string carnet)
        {
            return _metodosEstudiante.ObtenerIdEstudiante(carnet);
        }

        //public DataTable ListarEstudiantes() 
        //{
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("ID");
        //    dt.Columns.Add("CARNET");
        //    dt.Columns.Add("NOMBRES");
        //    dt.Columns.Add("APELLIDOS");
        //    dt.Columns.Add("DIRECCION");
        //    dt.Columns.Add("TELEFONO");
        //    dt.Columns.Add("AÑO DE NACIMIENTO");

        //    _metodosEstudiante.ListarTodosEstudiantes().ForEach(x =>
        //    {
        //        dt.Rows.Add(x.IdEstudiante, x.Carnet, x.Nombres, x.Apellidos, x.Direccion, x.Telefono, x.AnioNacimiento);
        //    });

        //    return dt;
        //}

        public List<EstudianteCN> ListarTodosEstudiantes() 
        {
            var consulta = _metodosEstudiante.ListarTodosEstudiantes()
                .Select(x => new EstudianteCN
                {
                    IdEstudiante = x.IdEstudiante,
                    Carnet = x.Carnet,
                    Nombres = x.Nombres,
                    Apellidos = x.Apellidos,
                    Direccion = x.Direccion,
                    Telefono = x.Telefono,
                    Id_Monografia = x.Id_Monografia,
                    AnioNacimiento = x.AnioNacimiento
                }).ToList();
            return consulta;
        }

        public MonografiaCN ListarMonografiaDadoUnEstudiante(string carnet)
        {
            int idEstudiante = _metodosEstudiante.ObtenerIdEstudiante(carnet);
            if (idEstudiante == -1) return null;

            Monografia original = _metodosEstudiante.MonografiaDadoUnEstudiante(idEstudiante);
            if (original == null) return null;

            MonografiaCN copia = new MonografiaCN
            {
                IdMonografia = original.IdMonografia,
                CodigoMonografia = original.CodigoMonografia,
                Titulo = original.Titulo,
                FechaDefendida = original.FechaDefendida,
                NotaDefensa = original.NotaDefensa,
                TiempoOtorgado = original.TiempoOtorgado,
                TiempoDeDefensa = original.TiempoDeDefensa,
                TiempoPreguntaYRespuesta = original.TiempoPreguntaYRespuesta
            };

            return copia;
        }

        public List<EstudianteCN> BuscarEstudiantePorNombre(string carnetNombre)
        {
            var consulta = _metodosEstudiante.BuscarEstudiantePorNombre(carnetNombre)
                .Select(x => new EstudianteCN 
                {
                    IdEstudiante = x.IdEstudiante,
                    Carnet = x.Carnet,
                    Nombres = x.Nombres,
                    Apellidos = x.Apellidos,
                    Direccion = x.Direccion,
                    Telefono = x.Telefono,
                    Id_Monografia = x.Id_Monografia,
                    AnioNacimiento = x.AnioNacimiento
                }).ToList();
            return consulta;
        }

        public int? VerificarExistenciaMonografia(string carnet)
        {
            return _metodosEstudiante.VerificarExistenciaMonografia(carnet);
        }
        public bool ModificarEstudiante(EstudianteCN est)
        {
            Estudiante eOriginal = new Estudiante
            {
                Carnet = est.Carnet,
                Nombres = est.Nombres,
                Apellidos = est.Apellidos,
                AnioNacimiento = est.AnioNacimiento,
                Direccion = est.Direccion,
                Telefono = est.Telefono,
            };
            return _metodosEstudiante.ModificarEstudiante(eOriginal);
        }

        public bool EliminarEstudiante(string carnet)
        {
            return _metodosEstudiante.EliminarEstudiante(carnet);
        }

    }
}
