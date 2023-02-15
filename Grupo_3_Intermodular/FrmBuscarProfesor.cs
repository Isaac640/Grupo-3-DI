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
        private int profesorId; //Habria que buscar como quitar el set
        public FrmBuscarProfesor()
        {

            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        private void btnDni_Click(object sender, EventArgs e)
        {
            lvProfesores.Items.Clear();
            foreach (Profesor p in Negocio.ObtenerProfesores())
            {
                if (p.dni.Contains(txtBuscar.Text))
                {

                    string[] profesor = new string[4];
                    profesor[0] = p.dni;
                    profesor[1] = p.nombre;
                    profesor[2] = p.ape1;
                    profesor[3] = p.ape2;
                    ListViewItem lviProf = new ListViewItem(profesor);
                    lviProf.Tag = p.id;
                    lvProfesores.Items.Add(lviProf);
                }
            }
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            lvProfesores.Items.Clear();
            foreach (Profesor p in Negocio.ObtenerProfesores())
            {
                if (p.nombre.Contains(txtBuscar.Text) || p.ape1.Contains(txtBuscar.Text) || p.ape2.Contains(txtBuscar.Text))
                {
                    string[] profesor = new string[4];
                    profesor[0] = p.dni;
                    profesor[1] = p.nombre;
                    profesor[2] = p.ape1;
                    profesor[3] = p.ape2;
                    ListViewItem lviProf = new ListViewItem(profesor);
                    lviProf.Tag = p.id;
                    lvProfesores.Items.Add(lviProf);
                }
            }
        }

        private void cargarProfesores() //Tiene que devolver un array Profesor[]
        {
            //localhost/api/profesores : Profesor[]
            //localhost/api/profesor/dni/722 : Profesor
            //localhost/api/profesor/nombre/Manolo : Profesor

            //Profesor p;
            //List<Profesor> profesores;
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
            //return profesores;
        }

        private void lvProfesores_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //prof =//localhost/api/profesor/id/( lvProfesores.SelectedItems[0].Tag.ToString() ) : Profesor
            profesorId = int.Parse(lvProfesores.SelectedItems[0].Tag.ToString());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public int ProfesorId { get { return profesorId;} }
    }
}
