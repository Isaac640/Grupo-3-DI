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


        static Negocio()
        {
            consumer = new WebConsumer("http://10.0.13.101:8080");

        }

        public static void AnadirGuardia(Guardia guardia)
        {
            //guardias.Add(guardia);
        }

        public async static Task<Guardia> ObtenerGuardia(int id)
        {
            return await consumer.GetAsync<Guardia>("/guardia/buscarId?id=" + id);
        }
        public async static Task<Profesor> ObtenerProfesor(int id)
        {
            return await consumer.GetAsync<Profesor>("/profesor/buscarId?id=" + id);
        }

        public async static Task<List<Guardia>> ObtenerGuardias()
        {
            return await consumer.GetAsync<List<Guardia>>("/guardia");
        }
        public async static Task<List<Profesor>> ObtenerProfesores()
        {
            return await consumer.GetAsync<List<Profesor>>("/profesor");
        }

        public async static void BorrarGuardia(int id)
        {
            var borrar = await ObtenerGuardia(id);
            //guardias.Remove(borrar);
        }
    }
}
