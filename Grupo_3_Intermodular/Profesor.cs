using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_3_Intermodular
{
    public class Profesor
    {

        public int id { get; set; }
        public string dni { get; set; }
        public string user { get; set; }
        public string nombre { get; set; }
        public string ape1 { get; set; }
        public string ape2 { get; set; }
        public string tfno { get; set; }
        public int baja { get; set; }
        public int activo { get; set; }
        public int id_sustituye { get; set; }
    }
}
