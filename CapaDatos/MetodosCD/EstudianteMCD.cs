﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class EstudianteMCD
    {
        // Insertar Estudiante
        public bool InsertarEstudiante(Estudiante est)
        {
            using (var db = new RMEntities()) 
            {
                var es = db.Estudiante.FirstOrDefault(x => x.Carnet == est.Carnet);
                if(es != null)
                    return false;

                db.Estudiante.Add(est);
                db.SaveChanges();
                return true;
            }
        }

        // Agregar monografia
        public bool AgregarMonografia(Estudiante est)
        {
            using (var db = new RMEntities())
            {
                var es = db.Estudiante.FirstOrDefault(x => x.Carnet == est.Carnet);
                if (es == null)
                    return false;

                es.Id_Monografia = est.Id_Monografia;
                //db.Entry(es).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }

        // Obtener Id de Estudiante
        public int ObtenerIdEstudiante(string carnet)
        {
            using (var db = new RMEntities())
            {
                Estudiante est = db.Estudiante.FirstOrDefault(x => x.Carnet == carnet);
                if (est == null)
                    return -1;

                return est.IdEstudiante;
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

        // Listar Monografia Dado un Estudiante
        public Monografia MonografiaDadoUnEstudiante(int idEstudiante)
        {
            using (var db = new RMEntities())
            {
                var consulta = (from est in db.Estudiante
                                join mon in db.Monografia
                                on est.Id_Monografia equals mon.IdMonografia
                                where est.IdEstudiante == idEstudiante
                                select mon).FirstOrDefault();
                return consulta;
            }
        }

        // Verificar si posee o no monografia
        public int? VerificarExistenciaMonografia(string carnet)
        {
            using (var db = new RMEntities())
            {
                return (from e in db.Estudiante
                               where e.Carnet == carnet
                               select e.Id_Monografia).FirstOrDefault();
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
                var consulta = db.Estudiante.FirstOrDefault(x => x.Carnet == est.Carnet);

                if (consulta == null)
                    return false;

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
                var consulta = db.Estudiante.FirstOrDefault(x => x.Carnet == carnet);
                if (consulta == null)
                    return false;

                db.Estudiante.Remove(consulta);
                db.SaveChanges();
                return true;
            }
        }

    }
}
