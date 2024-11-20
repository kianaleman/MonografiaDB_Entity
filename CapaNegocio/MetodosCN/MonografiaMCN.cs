using CapaDatos;
using CapaNegocio.Modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.MetodosCN
{
    public class MonografiaMCN
    {
        private readonly MonografiaMCD _metodosMonografia;

        public MonografiaMCN() 
        {
            _metodosMonografia = new MonografiaMCD();
        }

        public bool InsertarMonografia(MonografiaCN mon, Pro_MonCN[] promon)
        {
            Monografia monOriginal = new Monografia 
            {
                CodigoMonografia = mon.CodigoMonografia,
                Titulo = mon.Titulo,
                FechaDefendida = mon.FechaDefendida,
                NotaDefensa = mon.NotaDefensa,
                TiempoOtorgado = mon.TiempoOtorgado,
                TiempoDeDefensa = mon.TiempoDeDefensa,
                TiempoPreguntaYRespuesta = mon.TiempoPreguntaYRespuesta            
            };

            Pro_Mon[] promonOriginal = new Pro_Mon[promon.Length];
            for (int i = 0; i < promon.Length; i++) 
            {
                promonOriginal[i] = new Pro_Mon
                {
                    Id_Profesor = promon[i].Id_Profesor,
                    Id_Monografia = promon[i].Id_Monografia,
                    Rol = promon[i].Rol,
                };
            }

            return _metodosMonografia.InsertarMonografia(monOriginal, promonOriginal);

        }

        public int ObtenerIdMonografia(string cod)
        {
            return _metodosMonografia.ObtenerIdMonografia(cod);
        }

        public List<Monografia> ListarTodosMonografias()
        {
            return _metodosMonografia.ListarTodosMonografias();
        }

        public List<Monografia> ListarMonografiaRangoDeFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            return _metodosMonografia.ListarMonografiaRangoFecha(fechaInicio, fechaFin);
        }


        public IEnumerable<dynamic> FiltrarDatosDeMonografiaPorTutor(DateTime fechaInicio, DateTime fechaFinal)
        {
            return _metodosMonografia.FiltrarDatosMonografia(fechaInicio, fechaFinal);
        }

        public List<Monografia> BuscarMonografiaPorNombreOCodigo(string titleCode)
        {
            return _metodosMonografia.BuscarMonografiaPorNombreOCodigo(titleCode);
        }

        public bool ModificarMonografia(MonografiaCN mon)
        {
            Monografia monOriginal = new Monografia 
            {
                Titulo = mon.Titulo,
                FechaDefendida = mon.FechaDefendida,
                NotaDefensa = mon.NotaDefensa,
                TiempoOtorgado = mon.TiempoOtorgado,
                TiempoDeDefensa = mon.TiempoDeDefensa,
                TiempoPreguntaYRespuesta = mon.TiempoPreguntaYRespuesta
            };

            return _metodosMonografia.ModificarMonografia(monOriginal);
        }

        public bool EliminarMonografia(string cod)
        {
            return _metodosMonografia.EliminarMonografia(cod);
        }
    }


}
