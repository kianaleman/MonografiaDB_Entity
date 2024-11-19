using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Modelo
{
    public class EstudianteCN
    {
        public int IdEstudiante { get; set; }
        public string Carnet { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public DateTime AnioNacimiento { get; set; }
        public int Id_Monografia { get; set; }
    }
}
