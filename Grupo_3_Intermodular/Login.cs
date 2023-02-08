using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_3_Intermodular
{
    public partial class FrmLogin : Form
    {
        string usu = "isaac";
        string con = "1234";
        public FrmLogin()
        {
            InitializeComponent();
            //Centrar la ventana a la pantalla al iniciar la aplicaciòn
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //Si alguno del los campos estan vacios, se mostrara un MensajeBox mencionandolo
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasenia.Text))
            {
                MessageBox.Show("Uno de los campos esta vacío", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (verificarUsuario() == true)
            {
                //Si va, tira la API y avanza al siguiente formulario, y cierra la ventana de login
                //la siguiente ventana sera el listado de profesores SOLO ADMINS PUEDEN ACCEDER
                
                MantenimientoGuardias mGuardias = new MantenimientoGuardias();
                mGuardias.Show();

                this.Close();
            }

        }

        public bool verificarUsuario()
        {
            bool valido = false;

            //Si el usuario y contraseña coinciden se pondra a true
            //Si no, mostrará un texto di que es incorrecto
            if (txtUsuario.Text.ToLower().Equals(usu) && txtContrasenia.Text.Equals(con))
            {
                valido = true;
            }
            else
            {
                lblError.Text = "El Usuario o Contraseña son incorrectos";
            }

            return valido;
        }
    }
}
