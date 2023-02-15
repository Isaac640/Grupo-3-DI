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
    public partial class MantenimientoGuardias : Form
    {
        public MantenimientoGuardias()
        {
            InitializeComponent();

            cargarDatos();
        }

        private async void cargarDatos()
        {
            List<Guardia> guardias = await Negocio.ObtenerGuardias();
            foreach (Guardia x in guardias)
            {
                string[] lvItem = new string[5];
                lvItem[0] = x.fecha.ToString();
                lvItem[1] = x.hora.ToString();
                lvItem[2] = x.profFalta.nombre + " " + x.profFalta.ape1 + " " + x.profFalta.ape2;
                if (x.profGuardia != null)
                {
                    lvItem[3] = x.profGuardia.nombre + " " + x.profGuardia.ape1 + " " + x.profGuardia.ape2;
                }
                else
                {
                    lvItem[3] = "NO HAY";
                }
                switch (x.estado)
                {
                    case Estado.R:
                        lvItem[4] = "Realizada";
                        break;
                    case Estado.C:
                        lvItem[4] = "Confirmada";
                        break;
                    case Estado.A:
                        lvItem[4] = "Anulada";
                        break;
                }

                ListViewItem lviGuardia = new ListViewItem(lvItem);
                lviGuardia.Tag = x.id;

                if (x.profGuardia == null) lviGuardia.BackColor = Color.OrangeRed;

                lvGuardias.Items.Add(lviGuardia);

            }

            actualizarRegistro();
        }

        private void actualizarRegistro()
        {
            int registros = lvGuardias.Items.Count;

            lblRegistros.Text = lvGuardias.Items.Count.ToString();
            lblRegistros.Text += registros != 1 ? " registros" : " registro";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string filtro = txtFiltro.Text;
            if (string.IsNullOrEmpty(filtro))
            {
                lblFiltro.Text = "Sin filtro";
                actualizarRegistro();
                return;
            }

            lblFiltro.Text = $"Filtrado por {filtro}";
            actualizarRegistro();


            return;
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            crearGuardia();
        }

        private void cmsGuardias_Opening(object sender, CancelEventArgs e)
        {
            this.tsmiModificar.Enabled = false;
            this.tsmiEliminar.Enabled = false;

            if (this.lvGuardias.SelectedItems.Count == 1)
            {
                this.tsmiModificar.Enabled = true;
                this.tsmiEliminar.Enabled = true;
            }
        }

        private void tsmiNueva_Click(object sender, EventArgs e)
        {
            crearGuardia();
        }

        private void tsmiModificar_Click(object sender, EventArgs e)
        {
            modificarGuardia();
        }

        private void tsmiEliminar_Click(object sender, EventArgs e)
        {
            eliminarGuardia();
        }

        private void lvGuardias_DoubleClick(object sender, EventArgs e)
        {
            modificarGuardia();
        }

        private void crearGuardia()
        {
            Guardia guardia = new Guardia();
            FrmGuardia fGuardia = new FrmGuardia(guardia);
            if (fGuardia.ShowDialog() == DialogResult.OK)
            {
                cargarGuardia(fGuardia.guardia);
            }
        }
        private void modificarGuardia()
        {
            ; //Recupero el objeto guardia según el tag y se lo enchufo al propiedades
            Guardia guardia = Negocio.ObtenerGuardia((int)lvGuardias.SelectedItems[0].Tag);
            FrmGuardia fGuardia = new FrmGuardia(guardia);
            if (fGuardia.ShowDialog() == DialogResult.OK)
            {

                cargarGuardia(fGuardia.guardia);
            }
        }
        private void eliminarGuardia()
        {
            string message = "¿Desea eliminar la guardia?";
            string caption = "Eliminar guardia";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                Negocio.BorrarGuardia(int.Parse(lvGuardias.SelectedItems[0].Tag.ToString()));
                cargarDatos();
            }
        }

        private void cargarGuardia(Guardia guardia)
        {
            //Si la guardia ya existe la modifica en la API, si no existe la añade
            //Actualizar el ListView
            actualizarRegistro();
        }

        
    }
}
