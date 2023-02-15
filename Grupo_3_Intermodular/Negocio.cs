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

            //DATO DE PRUEBAS
            Profesor prueba1 = new Profesor();
            prueba1.id = 15;
            prueba1.nombre = "Pedro";
            prueba1.ape1 = "Higuera";
            prueba1.ape2 = "Colino";
            prueba1.dni = "72158865E";
            profesores.Add(prueba1);

            Profesor prueba2 = new Profesor();
            prueba2.id = 23;
            prueba2.nombre = "Samuel";
            prueba2.ape1 = "Rodriguez";
            prueba2.ape2 = "Camus";
            prueba2.dni = "12345665P";
            profesores.Add(prueba2);

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
            return await consumer.GetAsync<List<Guardia>>("/guardias/todos");
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
