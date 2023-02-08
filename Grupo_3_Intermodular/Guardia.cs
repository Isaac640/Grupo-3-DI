using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Grupo_3_Intermodular
{
    public class Guardia
    {
        public int id { get; }
        public int prof_falta { get; set; }
        public int prof_hace_guardia { get; set; }
        public estado estado { get; set; }
        public DateTime fecha { get; set; }
        public int horario { get; set; }
        public int dia_semana { get; set; }
        public int hora { get; set; }
        public int aviso { get; set; }
        public string grupo { get; set; }
        public string aula { get; set; }
        public string observaciones { get; set; }

    }

    public enum estado
    {
        R,
        C,
        A
    }
}
