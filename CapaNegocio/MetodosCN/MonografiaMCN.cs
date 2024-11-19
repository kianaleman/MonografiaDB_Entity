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
    }
}
