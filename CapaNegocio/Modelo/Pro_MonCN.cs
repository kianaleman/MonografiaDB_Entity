using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Modelo
{
    public class Pro_MonCN
    {
        public int IdPro_Mon { get; set; }
        public int Id_Profesor {  get; set; }
        public int Id_Monografia { get; set; }
        public string Rol { get; set; }
    }
}
