using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_3_Intermodular
{
    public partial class FrmLogin : Form
    {
        /// <summary>
        /// Inicio de sesión del administrador
        /// </summary>
        public FrmLogin()
        {
            InitializeComponent();
        }

        private async void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            //Si alguno del los campos estan vacios, se mostrara un MensajeBox mencionandolo
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasenia.Text))
            {
                MessageBox.Show("Uno de los campos esta vacío", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //encriptacion de contraseña a MD5
            string contraEncr = EncriptadorMD5(txtContrasenia.Text);
            /*Si funciona, verifica que los campos esten rellenados y que el usuario exista
            *Usa la API, avanza al siguiente formulario y cierra la ventana de login.
            *El metodo que hay en Program.cs hace que si hay mas ventanas por aparecer, cierra la ventana y sigue a la siguiente
            *La siguiente ventana sera Mantenimientos de Guardias. SOLO ADMINISTRADORES PUEDEN ACCEDER
            */

            if (await Negocio.IniciarSesion(txtUsuario.Text, contraEncr) != 0)
            {
                //Abrimos el formulario de mantenimiento de guardias y cerramos esta ventana
                MantenimientoGuardias mGuardias = new MantenimientoGuardias();
                mGuardias.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
        public static string EncriptadorMD5(string contraseña)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //calcular hash a partir de los bytes de texto
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(contraseña));

            //obtiene el resultado de hash despues de calcularlo
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //cambiarlo a 2 digitos hexadecimales por cada byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }
}
