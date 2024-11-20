using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ProfesorMCD
    {
        // Insertar Profesor
        public bool InsertarProfesor(Profesor pro)
        {
            using (var db = new RMEntities())
            {
                var pr = db.Profesor.FirstOrDefault(x => x.Identificacion == pro.Identificacion);
                if (pr != null)
                    return false;
                db.Profesor.Add(pro);
                db.SaveChanges();
                return true;
            }
        }

        // Obtener Id de Profesor
        public int ObtenerIdProfesor(string identificacion)
        {
            using (var db = new RMEntities())
            {
                Profesor pro = db.Profesor.FirstOrDefault(x => x.Identificacion == identificacion);
                if (pro == null)
                    return -1;

                return pro.IdProfesor;
            }
        }

        // Listar Todos los Profesores

        public List<Profesor> ListarTodosProfesores()
        {
            using (var db = new RMEntities())
            {
                var consulta = (from p in db.Profesor select p).ToList();
                return consulta;
            }
        }

        // Buscar Profesor por nombre o identificacion
        public List<Profesor> BuscarProfesorPorNombreOIdentifacion(string identificacionNombre)
        {
            using (var db = new RMEntities())
            {
                return db.Profesor
                    .Where(pro => pro.Identificacion.Contains(identificacionNombre) || pro.Nombres.Contains(identificacionNombre))
                    .ToList();
            }
        }


        // Modificar profesor
        public bool ModificarProfesor(Profesor pro)
        {
            using (var db = new RMEntities())
            {
                var consulta = db.Profesor.FirstOrDefault(x => x.Identificacion == pro.Identificacion);
                
                if (consulta == null)
                    return false;
                
                consulta.Nombres = pro.Nombres;
                consulta.Apellidos = pro.Apellidos;
                consulta.AnioNacimiento = pro.AnioNacimiento;
                consulta.Direccion = pro.Direccion;
                consulta.Telefono = pro.Telefono;
                db.Entry(consulta).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }


        // Eliminar un profesor dada su identificacion
        public bool EliminarProfesor(string identificacion)
        {
            using (var db = new RMEntities())
            {
                var consulta = db.Profesor.Find(identificacion);
                if (consulta == null)
                    return false;

                db.Profesor.Remove(consulta);
                db.SaveChanges();
                return true;
            }
        }
    }
}
