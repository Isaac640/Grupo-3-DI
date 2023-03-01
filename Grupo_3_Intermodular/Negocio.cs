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
        private static int profesorId;
        private static WebConsumer consumer;


        static Negocio()
        {
            consumer = new WebConsumer("http://10.0.13.101:8080"); //Modificar según la ip de la API

        }

        public static async Task<bool> AnadirGuardia(Guardia guardia)
        {
            return await consumer.PostAsync<bool>("/guardia/add", guardia);
        }

        public async static Task<Guardia> ObtenerGuardia(int id)
        {
            return await consumer.GetAsync<Guardia>("/guardia/buscar?id=" + id);
        }
        public async static Task<Profesor> ObtenerProfesor(int id)
        {
            return await consumer.GetAsync<Profesor>("/profesor/buscar?id=" + id);
        }

        public async static Task<List<Guardia>> ObtenerGuardias()
        {
            return await consumer.GetAsync<List<Guardia>>("/guardia");
        }
        public async static Task<List<Profesor>> ObtenerProfesores()
        {
            return await consumer.GetAsync<List<Profesor>>("/profesor");
        }
        public async static Task<bool> BorrarGuardia(int id)
        {
            return await consumer.DeleteAsync<bool>("/guardia/eliminar", id);
        }

        public async static Task<bool> ActualizarGuardia(Guardia guardia)
        {
            return await consumer.PostAsync<bool>("/guardia/actualizar", guardia);
        }
        public async static Task<int> IniciarSesion(string user, string passwd)
        {
            int id = await consumer.PostAsync<int>("/login", new Dictionary<string, string>() { { "user", user }, { "passwd", passwd } });
            profesorId = id;

            return id;
        }
    }
}
