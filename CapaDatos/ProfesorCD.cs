using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ProfesorCD
    {
        // Insertar Profesor
        public bool InsertarProfesor(Profesor pro)
        {
            using (var db = new RMEntities())
            {
                db.Profesor.Add(pro);
                db.SaveChanges();
                return true;
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

        // Buscar Profesor por nombre o carnet
        public List<Profesor> BuscarEstudiantePorNombre(string identificacionNombre)
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
                var consulta = db.Profesor.Find(pro.Identificacion);
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
                db.Profesor.Remove(consulta);
                db.SaveChanges();
                return true;
            }
        }
    }
}
