using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Modelo
{
    public class ProfesorCN
    {
        public int IdProfesor { get; set; }
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public DateTime AnioNacimiento { get; set; }
    }
}
