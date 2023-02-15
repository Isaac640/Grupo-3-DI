using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_3_Intermodular
{
    public class Negocio
    {
        private static WebConsumer consumer;

        private static List<Guardia> guardias;
        private static List<Profesor> profesores;

        static Negocio()
        {
            consumer = new WebConsumer("http://10.0.13.101:8080");

            guardias = new List<Guardia>();
            profesores= new List<Profesor>();

        }

        public static void VaciarGuardia()
        {
            guardias.Clear();
        }
        public static void VaciarProfesores()
        {
            profesores.Clear();
        }

        public static void AnadirGuardia(Guardia guardia)
        {
            guardias.Add(guardia);
        }
        public static void AnadirProfesor(Profesor profesor)
        {
            profesores.Add(profesor);
        }

        public static Guardia ObtenerGuardia(int id)
        {
            return guardias.FirstOrDefault(x => x.id == id);
        }
        public static Profesor ObtenerProfesor(int id)
        {
            return profesores.FirstOrDefault(x => x.id == id);
        }

        public async static Task<List<Guardia>> ObtenerGuardias()
        {
            return await consumer.GetAsync<List<Guardia>>("/guardia");
        }
        public static List<Profesor> ObtenerProfesores()
        {
            return profesores;
        }

        public static void BorrarGuardia(int id)
        {
            var borrar = ObtenerGuardia(id);
            guardias.Remove(borrar);
        }
        public static void BorrarProfesor(int id)
        {
            var borrar = ObtenerProfesor(id);
            profesores.Remove(borrar);
        }
    }
}
