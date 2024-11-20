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

        public List<Profesor> ListarTodosProfesores()
        {
            return _metodosProfesor.ListarTodosProfesores();
        }

        public List<Profesor> BuscarProfesorPorNombreOIdentificacion(string idname)
        {
            return _metodosProfesor.BuscarProfesorPorNombreOIdentifacion(idname);
        }

        public bool ModificarProfesor(ProfesorCN pro)
        {
            Profesor profesorOriginal = new Profesor
            {
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
