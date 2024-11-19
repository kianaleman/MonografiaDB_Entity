using CapaDatos;
using CapaNegocio.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.MetodosCN
{
    public class EstudianteMCN
    {
        private readonly EstudianteMCD _metodos;

        public EstudianteMCN()
        {
            _metodos = new EstudianteMCD();
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
            return _metodos.InsertarEstudiante(est2);
        }


        public int ObtenerIdEstudiante(string carnet)
        {
            return _metodos.ObtenerIdEstudiante(carnet);
        }

        public DataTable ListarEstudiantes() 
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("CARNET");
            dt.Columns.Add("NOMBRES");
            dt.Columns.Add("APELLIDOS");
            dt.Columns.Add("DIRECCION");
            dt.Columns.Add("TELEFONO");
            dt.Columns.Add("AÑO DE NACIMIENTO");

            _metodos.ListarTodosEstudiantes().ForEach(x =>
            {
                dt.Rows.Add(x.IdEstudiante, x.Carnet, x.Nombres, x.Apellidos, x.Direccion, x.Telefono, x.AnioNacimiento);
            });

            return dt;
        }

        public List<Estudiante> BuscarEstudiantePorNombre(string carnetNombre)
        {
            return _metodos.BuscarEstudiantePorNombre(carnetNombre);
        }

        public bool ModificarEstudiante(EstudianteCN est)
        {
            Estudiante eOriginal = new Estudiante
            {
                Nombres = est.Nombres,
                Apellidos = est.Apellidos,
                AnioNacimiento = est.AnioNacimiento,
                Direccion = est.Direccion,
                Telefono = est.Telefono,
            };
            return _metodos.ModificarEstudiante(eOriginal);
        }

        public bool EliminarEstudiante(string carnet)
        {
            return _metodos.EliminarEstudiante(carnet);
        }

    }
}
