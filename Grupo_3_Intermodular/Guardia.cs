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
        public string aula { get; set; }
        public int dia_semana { get; set; }
        public Estado estado { get; set; }
        public DateTime fecha { get; set; }
        public string grupo { get; set; }
        public int hora { get; set; }
        public string observaciones { get; set; }
        public Horario horario { get; set; }
        public int prof_falta { get; set; }
        public int prof_hace_guardia { get; set; }

    }

    public enum Estado
    {
        R,
        C,
        A
    }
}
