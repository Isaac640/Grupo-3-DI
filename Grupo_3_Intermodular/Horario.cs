using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_3_Intermodular
{
    internal class Horario
    {
        public int id { get;}
        public int profesor { get; }
        public int dia_semana { get; }
        public int hora { get; }
        public string aula { get; }
        public string grupo { get; }
        public string materia { get; }
        public int genera_guardia { get; }
    }
}
