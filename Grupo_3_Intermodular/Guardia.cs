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
        public int id { get; set; }
        public string aula { get; set; }
        public int dia_semana { get; set; }
        public Estado estado { get; set; }
        public DateTime fecha { get; set; }
        public string grupo { get; set; }
        public int hora { get; set; }
        public string observaciones { get; set; }
        public Horario horario { get; set; }
        public Profesor profFalta { get; set; }
        public Profesor profGuardia { get; set; }

    }

    public enum Estado
    {
        R,
        C,
        A
    }
}
