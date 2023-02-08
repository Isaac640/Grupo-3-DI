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

        private void cargarDatos()
        {
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
            if (string.IsNullOrEmpty(filtro)) {
                lblFiltro.Text = "Sin filtro";
                return;
            }

            lblFiltro.Text = $"Filtrado por {filtro}";            

            return;
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            FrmGuardia fGuardia = new FrmGuardia();
            fGuardia.ShowDialog();
        }
    }
}
