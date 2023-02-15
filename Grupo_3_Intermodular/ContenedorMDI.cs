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
    public partial class ContenedorMDI : Form
    {
        public ContenedorMDI()
        {
            InitializeComponent();
        }

        private void tsmiGuardias_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (typeof(MantenimientoGuardias) == form.GetType())
                {
                    form.Activate();
                    return;
                }
            }
            MantenimientoGuardias manGuardias = new MantenimientoGuardias();
            manGuardias.MdiParent = this;
            manGuardias.Show();

        }
    }
}
