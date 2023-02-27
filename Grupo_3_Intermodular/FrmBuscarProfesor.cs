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


        private async void btnDni_Click(object sender, EventArgs e)
        {
            lvProfesores.Items.Clear();
            foreach (Profesor p in await Negocio.ObtenerProfesores())
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

        private async void btnNombre_Click(object sender, EventArgs e)
        {
            lvProfesores.Items.Clear();
            foreach (Profesor p in await Negocio.ObtenerProfesores())
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

        private void lvProfesores_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            profesorId = int.Parse(lvProfesores.SelectedItems[0].Tag.ToString());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public int ProfesorId { get { return profesorId;} }
    }
}
