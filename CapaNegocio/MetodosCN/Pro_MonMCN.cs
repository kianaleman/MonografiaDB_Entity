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

        public List<MonografiaCN> MonografiasPorTutor(int idTutor)
        {
            var consulta = _metodosProMon.MonografiasPorTutor(idTutor)
               .Select(x => new MonografiaCN
               {
                   IdMonografia = x.IdMonografia,
                   CodigoMonografia = x.CodigoMonografia,
                   Titulo = x.Titulo,
                   FechaDefendida = x.FechaDefendida,
                   NotaDefensa = x.NotaDefensa,
                   TiempoOtorgado = x.TiempoOtorgado,
                   TiempoDeDefensa = x.TiempoDeDefensa,
                   TiempoPreguntaYRespuesta = x.TiempoPreguntaYRespuesta
               }).ToList();

            return consulta;
        }

        public List<MonografiaCN> RangoDeFechaMonografiaTutor(int idTutor, DateTime fechaInicio, DateTime fechaFin)
        {
            var consulta = _metodosProMon.RangoDeFechaMonografiaTutor(idTutor, fechaInicio, fechaFin)
               .Select(x => new MonografiaCN
               {
                   IdMonografia = x.IdMonografia,
                   CodigoMonografia = x.CodigoMonografia,
                   Titulo = x.Titulo,
                   FechaDefendida = x.FechaDefendida,
                   NotaDefensa = x.NotaDefensa,
                   TiempoOtorgado = x.TiempoOtorgado,
                   TiempoDeDefensa = x.TiempoDeDefensa,
                   TiempoPreguntaYRespuesta = x.TiempoPreguntaYRespuesta
               }).ToList();

            return consulta;
        }

    }
}
