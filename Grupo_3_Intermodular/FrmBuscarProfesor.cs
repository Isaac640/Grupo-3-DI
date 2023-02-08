using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_3_Intermodular
{
    public partial class FrmBuscarProfesor : Form
    {
        //Profesor prof;
        public FrmBuscarProfesor()//Profesor prof
        {
            
            InitializeComponent();
            //this.prof = prof;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }


        private void btnDni_Click(object sender, EventArgs e)
        {
            for(; ; )//Comprobar si lo escrito en txt coincide con el DNI de algun profesor
            {
                if (true) //p.DNI.Contains(txtBuscar.Text)
                {
                    //ListViewItem lviProf;
                    //lviProf.Column[0] = p.DNI;
                    //lviProf.Column[1] = p.Nombre;
                    //lviProf.Column[2] = p.Apellido1;
                    //lviProf.Column[3] = p.Apellido2;
                    //lvLista.add(lviProf);
                }
            }
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            for (; ; )//Comprobar si lo escrito en txt coincide con el Nombre de algun profesor
            {
                if (true) //p.nombre.Contains(txtBuscar.Text)
                {
                    //ListViewItem lviProf;
                    //lviProf.Column[0] = p.DNI;
                    //lviProf.Column[1] = p.Nombre;
                    //lviProf.Column[2] = p.Apellido1;
                    //lviProf.Column[3] = p.Apellido2;
                    //lvLista.add(lviProf);
                }
            }
        }

        private void cargarProfesores() //Tiene que devolver un array Profesor[]
        {
            //localhost/api/profesores : Profesor[]
            //localhost/api/profesor/dni/722 : Profesor
            //localhost/api/profesor/nombre/Manolo : Profesor

            //Profesor p;
            //Arraylist<Profesor> profesores;
            //Query pidiendo Id, DNI, Nombre, Apellido 1 y Apellido 2
            //for("yo que se bro, lo que salga de la query")
            //{
            //  p.Id = x.id;
            //  p.DNI = x.DNI
            //  p.Nombre = x.Nombre;
            //  p.Apellido1 = x.Apellido1;
            //  p.Apellido2 = x.Apellido2;
            //
            //  profesores.add(p)
            //}
            //
            //return profesores.toArray()
        }

        private void lvProfesores_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //prof =//localhost/api/profesor/id/( lvProfesores.SelectedItems[0].Tag.ToString() ) : Profesor
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
