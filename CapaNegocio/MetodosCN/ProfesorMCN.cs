using CapaDatos;
using CapaNegocio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.MetodosCN
{
    public class ProfesorMCN
    {
        private readonly ProfesorMCD _metodosProfesor;

        public ProfesorMCN()
        {
            _metodosProfesor = new ProfesorMCD();
        }

        public bool InsertarProfesor(ProfesorCN pro)
        {
            Profesor profesorOriginal = new Profesor 
            {
                Identificacion = pro.Identificacion,
                Nombres = pro.Nombres,
                Apellidos = pro.Apellidos,
                AnioNacimiento = pro.AnioNacimiento,
                Direccion = pro.Direccion,
                Telefono = pro.Telefono
            };
            return _metodosProfesor.InsertarProfesor(profesorOriginal);
        }

        public int ObtenerIdProfesor(string identificacion)
        {
            return _metodosProfesor.ObtenerIdProfesor(identificacion);
        }

        public List<ProfesorCN> ListarTodosProfesores()
        {
            var consulta = _metodosProfesor.ListarTodosProfesores()
                .Select(x => new ProfesorCN
                {
                    IdProfesor = x.IdProfesor,
                    Identificacion = x.Identificacion,
                    Nombres = x.Nombres,
                    Apellidos = x.Apellidos,
                    Direccion = x.Direccion,
                    Telefono =  x.Telefono,
                    AnioNacimiento = x.AnioNacimiento
                }).ToList();
            return consulta;
        }

        public List<ProfesorCN> BuscarProfesorPorNombreOIdentificacion(string idname)
        {
            var consulta = _metodosProfesor.BuscarProfesorPorNombreOIdentifacion(idname)
                .Select(x => new ProfesorCN
                {
                    IdProfesor = x.IdProfesor,
                    Identificacion = x.Identificacion,
                    Nombres = x.Nombres,
                    Apellidos = x.Apellidos,
                    Direccion = x.Direccion,
                    Telefono = x.Telefono,
                    AnioNacimiento = x.AnioNacimiento
                }).ToList();

            return consulta;
        }

        public bool ModificarProfesor(ProfesorCN pro)
        {
            Profesor profesorOriginal = new Profesor
            {
                Identificacion = pro.Identificacion,
                Nombres = pro.Nombres,
                Apellidos = pro.Apellidos,
                AnioNacimiento = pro.AnioNacimiento,
                Direccion = pro.Direccion,
                Telefono = pro.Telefono,
            };

            return _metodosProfesor.ModificarProfesor(profesorOriginal);
        }

        public bool EliminarProfesor(string identificacion)
        {
            return _metodosProfesor.EliminarProfesor(identificacion);
        }


    }
}
