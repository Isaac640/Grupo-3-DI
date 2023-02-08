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
    public partial class FrmGuardia : Form
    {
        //Guardia guardia;
        public FrmGuardia() //Objeto guardia en contructor
        {
            InitializeComponent();
            //this.guardia=guardia
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExaminarAusente_Click(object sender, EventArgs e)
        {
            FrmBuscarProfesor prfAusente = new FrmBuscarProfesor();
            if (prfAusente.ShowDialog()==DialogResult.OK) //Meter profesor por contructor
            {
                
                //txtAusente.Text=profAus.getNombre()+prof.getApellido1()+ prof.getApellido2
            }
        }

        private void btnExaminarSustituto_Click(object sender, EventArgs e)
        {
            FrmBuscarProfesor prfSustituto = new FrmBuscarProfesor();
            if (prfSustituto.ShowDialog() == DialogResult.OK)
            {
                //txtSustituto.Text=profSus.getNombre()+prof.getApellido1()+ prof.getApellido2
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (comprobarCampos())
            {
                //guardia.ProfesorAusente=profAus;
                //guardia.ProfesorSustituto=profSus;
                //guardia.Fecha=dtpFecha.Text;
                //guardia.Hora=cbHora.SelectedItem.Text;
                //guardia.Aula=cbAula.SelectedItem.Text;
                //guardia.Grupo=cbGrupo.SelectedItem.Text;
                //guardia.Observaciones=txtObservaciones.Text;
                //if(rbtnRealizada.isSelected) guardia.Estado=Realizada;
                //if(rbtnPendiente.isSelected) guardia.Estado=Pendiente;
                //if(rbtnAnulada.isSelected) guardia.Estado=Anulada;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }



        private bool comprobarCampos()
        {
            if (txtAusente.Text.Equals(String.Empty))
            {
                mostrarAviso("Debes rellenar el profesor ausente");
                txtAusente.Focus();
                return false;
            }
            if (txtSustituto.Text.Equals(String.Empty))
            {
                txtSustituto.Focus();
                mostrarAviso("Debes rellenar el profesor sustituto");
                return false;
            }
            if (cbHoras.Text.Equals(String.Empty))
            {
                cbHoras.Focus();
                mostrarAviso("Debes escoger una hora");
                return false;
            }
            if (cbAula.Text.Equals(String.Empty))
            {
                cbAula.Focus();
                mostrarAviso("Debes escoger un aula");
                return false;
            }
            if (cbGrupo.Text.Equals(String.Empty))
            {
                cbGrupo.Focus();
                mostrarAviso("Debes escoger un grupo");
                return false;
            }
            if (rbtnAnulada.Checked==false && rbtnConfirmada.Checked==false && rbtnRealizada.Checked==false)
            {
                mostrarAviso("Debes escoger un estado");
                return false;
            }
            return true;
        }

        private void mostrarAviso(String aviso)
        {
            MessageBox.Show(aviso, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        
    }
}
