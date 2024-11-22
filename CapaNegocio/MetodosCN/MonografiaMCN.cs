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

        public List<MonografiaCN> ListarTodosMonografias()
        {
            var consulta = _metodosMonografia.ListarTodosMonografias()
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

        public List<MonografiaCN> ListarMonografiaRangoDeFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            var consulta = _metodosMonografia.ListarMonografiaRangoFecha(fechaInicio, fechaFin)
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

        public (string Titulo, string Tutor, List<string> Jurado, List<string> Estudiantes) ObtenerDetallesDeMonografia(int idMonografia)
        {
            return _metodosMonografia.ObtenerDetallesDeMonografia(idMonografia);
        }


        public List<MonografiaCN> BuscarMonografiaPorNombreOCodigo(string titleCode)
        {
            var consulta = _metodosMonografia.BuscarMonografiaPorNombreOCodigo(titleCode)
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
