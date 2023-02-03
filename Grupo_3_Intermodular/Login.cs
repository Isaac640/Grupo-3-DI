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
        public FrmLogin()
        {
            InitializeComponent();
            //Centrar la ventana a la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //Si alguno del los campos estan vacios, se mostrara un MensajeBox diciendolo
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasenia.Text))
            {
                MessageBox.Show("Uno de los campos esta vacio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (verificacionUsuario() == true)
            {
                Application.Exit();
            }

        }

        public bool verificacionUsuario()
        {
            bool valido = false;
            string usu = "isaac";
            string con = "1234";

            //Si el usuario y contraseña coinciden se pondra a true
            //Si no Mostrará un texto di que es incorrecto
            if (txtUsuario.Text.Equals(usu) && txtContrasenia.Text.Equals(con))
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
