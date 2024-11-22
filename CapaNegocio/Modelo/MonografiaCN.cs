using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Modelo
{
    public class MonografiaCN
    {
        public int IdMonografia { get; set; }
        public string CodigoMonografia { get; set; }
        public string Titulo { get; set; }
        public DateTime? FechaDefendida { get; set; }
        public int? NotaDefensa { get; set; }
        public int? TiempoOtorgado { get; set; }
        public int? TiempoDeDefensa { get; set; }
        public int? TiempoPreguntaYRespuesta { get; set; }
    }
}
