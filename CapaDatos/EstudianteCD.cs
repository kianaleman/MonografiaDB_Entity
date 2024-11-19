using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class EstudianteCD
    {
        // Insertar Estudiante
        public bool InsertarEstudiante(Estudiante est)
        {
            using (var db = new RMEntities()) 
            {
                db.Estudiante.Add(est);
                db.SaveChanges();
                return true;
            }
        }

        // Listar Todos los Estudiantes

        public List<Estudiante> ListarTodosEstudiantes()
        {
            using (var db = new RMEntities())
            {
                var consulta = (from e in db.Estudiante select e).ToList();
                return consulta;
            }
        }

        // Buscar Estudiante por nombre o carnet
        public List<Estudiante> BuscarEstudiantePorNombre(string carnetNombre)
        {
            using (var db = new RMEntities())
            {
                return db.Estudiante
                    .Where(es => es.Carnet.Contains(carnetNombre) || es.Nombres.Contains(carnetNombre))
                    .ToList();
            }
        }


        // Modificar estudiante
        public bool ModificarEstudiante(Estudiante est)
        {
            using (var db = new RMEntities())
            {
                var consulta = db.Estudiante.Find(est.Carnet);
                consulta.Nombres = est.Nombres;
                consulta.Apellidos = est.Apellidos;
                consulta.AnioNacimiento = est.AnioNacimiento;
                consulta.Direccion = est.Direccion;
                consulta.Telefono = est.Telefono;
                db.Entry(consulta).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }


        // Eliminar un estudiante dado un carnet
        public bool EliminarEstudiante(string carnet)
        {
            using (var db = new RMEntities())
            {
                var consulta = db.Estudiante.Find(carnet);
                db.Estudiante.Remove(consulta);
                db.SaveChanges();
                return true;
            }
        }

    }
}
