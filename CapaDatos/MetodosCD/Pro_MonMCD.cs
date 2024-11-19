using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Pro_MonMCD
    {
        public bool InsertarProMon(Pro_Mon pm)
        {
            using (var db = new RMEntities())
            {
                db.Pro_Mon.Add(pm);
                db.SaveChanges();
                return true;
            }
        }


        // Titulos de trabajos monograficos realizados por un tutor
        public List<Monografia> MonografiasPorTutor(int idTutor)
        {
            using (var db = new RMEntities())
            {
                return (from proMon in db.Pro_Mon
                            join mon in db.Monografia
                            on proMon.Id_Monografia equals mon.IdMonografia
                            join pro in db.Profesor
                            on proMon.Id_Profesor equals pro.IdProfesor
                            where pro.IdProfesor == idTutor && proMon.Rol == "Tutor"
                            select mon).ToList();
            }
        }

        // Monografias de un tutor hechas en un rango de fechas
        public List<Monografia> RangoDeFechaMonografiaTutor(int idTutor, DateTime fechaInicio, DateTime fechaFinal)
        {
            using (var db = new RMEntities())
            {
                return (from proMon in db.Pro_Mon
                        join pro in db.Profesor
                        on proMon.Id_Profesor equals pro.IdProfesor
                        join mon in db.Monografia
                        on proMon.Id_Monografia equals mon.IdMonografia
                        where pro.IdProfesor == idTutor && proMon.Rol == "Tutor"
                        && mon.FechaDefendida >= fechaInicio && mon.FechaDefendida <= fechaFinal
                        select mon).ToList();
            }
        }
    }
}
