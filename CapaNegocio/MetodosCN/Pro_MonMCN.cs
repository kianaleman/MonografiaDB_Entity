using CapaDatos;
using CapaNegocio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.MetodosCN
{
    public class Pro_MonMCN
    {
        private readonly Pro_MonMCD _metodosProMon;

        public Pro_MonMCN()
        {
            _metodosProMon= new Pro_MonMCD();
        }

        public bool InsertarProMon(Pro_MonCN pm)
        {
            Pro_Mon pmOriginal = new Pro_Mon 
            {
                Id_Monografia = pm.Id_Monografia,
                Id_Profesor = pm.Id_Profesor,
                Rol = pm.Rol,
            };
            return _metodosProMon.InsertarProMon(pmOriginal);
        }

        public List<Monografia> MonografiasPorTutor(int idTutor)
        {
            return _metodosProMon.MonografiasPorTutor(idTutor);
        }

        public List<Monografia> RangoDeFechaMonografiaTutor(int idTutor, DateTime fechaInicio, DateTime fechaFin)
        {
            return _metodosProMon.RangoDeFechaMonografiaTutor(idTutor, fechaInicio, fechaFin);
        }

    }
}
