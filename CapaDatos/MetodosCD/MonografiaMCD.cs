using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class MonografiaMCD
    {
        // Insertar Monografia
        public bool InsertarMonografia(Monografia mon, Pro_Mon[] profesores)
        {
            using (var db = new RMEntities())
            {
                var m = db.Monografia.FirstOrDefault(x => x.CodigoMonografia == mon.CodigoMonografia);
                if (m != null)
                    return false;
             
                db.Monografia.Add(mon);
                db.SaveChanges();

                int idMonografia = mon.IdMonografia;

                foreach (var relacion in profesores)
                {
                    relacion.Id_Monografia = idMonografia;
                    db.Pro_Mon.Add(relacion);
                }

                db.SaveChanges();
                return true;
            }
        }


        // Obtener Id de Monografia
        public int ObtenerIdMonografia(string cod)
        {
            using (var db = new RMEntities())
            {
                Monografia mon= db.Monografia.FirstOrDefault(x => x.CodigoMonografia == cod);
                if (mon == null)
                    return -1;

                return mon.IdMonografia;
            }
        }

        // Listar Todas las Monografias

        public List<Monografia> ListarTodosMonografias()
        {
            using (var db = new RMEntities())
            {
                var consulta = (from m in db.Monografia select m).ToList();
                return consulta;
            }
        }

        // Listar Monografia por Rango de fecha
        public List<Monografia> ListarMonografiaRangoFecha(DateTime fechaInicio, DateTime fechaFinal)
        {
            // Lista de Monografia
            var monografiaFiltradaPorRangoFecha = ListarTodosMonografias().
                                                    Where(m => m.FechaDefendida >= fechaInicio && m.FechaDefendida <= fechaFinal).ToList();
            return monografiaFiltradaPorRangoFecha;
        }

        // Listar TituloMonografia - Tutor - Fecha - Estudiantes
        public IEnumerable<dynamic> FiltrarDatosMonografia(DateTime fechaInicio, DateTime fechaFinal)
        {
            using (var db = new RMEntities())
            {
                var consultaFiltrada =
                    from mon in db.Monografia
                    join proMon in db.Pro_Mon
                    on mon.IdMonografia equals proMon.Id_Monografia
                    join pro in db.Profesor
                    on proMon.Id_Profesor equals pro.IdProfesor
                    where mon.FechaDefendida >= fechaInicio && mon.FechaDefendida <= fechaFinal
                    && proMon.Rol == "Tutor"
                    select new {
                        TituloMonografia = mon.Titulo,
                        Tutor = pro.Nombres,
                        FechaD = mon.FechaDefendida,
                        NombreEstudiantes = db.Estudiante
                        .Where(est => est.Id_Monografia == mon.IdMonografia)
                        .Take(3)
                        .Select(est => est.Nombres)
                        .DefaultIfEmpty("")
                        .Aggregate((current, next) => $"{current}, {next}")
                    };
                return consultaFiltrada.ToList();
            }
        }

        // Filtrar monografias por su nombre o codigo

        public List<Monografia> BuscarMonografiaPorCodigo(string titleCode)
        {
            using (var db = new RMEntities())
            {
                return db.Monografia
                    .Where(m => m.CodigoMonografia.Contains(titleCode) || m.Titulo.Contains(titleCode))
                    .ToList();
            }
        }

        // Modificar Monografia
        public bool ModificarMonografia(Monografia mon)
        {
            using (var db = new RMEntities())
            {
                var consulta = db.Monografia.FirstOrDefault(x => x.CodigoMonografia == mon.CodigoMonografia);
                consulta.Titulo = mon.Titulo;
                consulta.FechaDefendida = mon.FechaDefendida;
                consulta.NotaDefensa = mon.NotaDefensa;
                consulta.TiempoOtorgado = mon.TiempoOtorgado;
                consulta.TiempoDeDefensa = mon.TiempoDeDefensa;
                consulta.TiempoPreguntaYRespuesta= mon.TiempoPreguntaYRespuesta;
                db.Entry(consulta).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }


        // Eliminar una Monografia dado un codigo de Monografia
        public bool EliminarMonografia(string cod)
        {
            using (var db = new RMEntities())
            {
                var consulta = db.Monografia.FirstOrDefault(x => x.CodigoMonografia == cod);

                // Eliminar monografia de la tabla promon, se elimina la relacion en promon
                var eliminarPromon = db.Pro_Mon
                    .Where(pm => pm.Id_Monografia == consulta.IdMonografia).ToList();

                db.Pro_Mon.RemoveRange(eliminarPromon);

                db.Monografia.Remove(consulta);
                db.SaveChanges();
                return true;
            }
        }
    }
}
