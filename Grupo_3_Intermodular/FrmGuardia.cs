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
        public Guardia guardia { get; }
        private Profesor profAus = new Profesor();
        private Profesor profSus = new Profesor();
        public FrmGuardia(Guardia guardia)
        {
            InitializeComponent();
            this.guardia = guardia;
            if (guardia.id!=0)
            {
                rellenarCampos(guardia);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnExaminarAusente_Click(object sender, EventArgs e)
        {

            FrmBuscarProfesor profAusente = new FrmBuscarProfesor();
            if (profAusente.ShowDialog() == DialogResult.OK)
            {
                profAus = await Negocio.ObtenerProfesor(profAusente.ProfesorId); 
                txtAusente.Text = profAus.nombre + " " + profAus.ape1 + " " + profAus.ape2;
                
            }
        }

        private async void btnExaminarSustituto_Click(object sender, EventArgs e)
        {

            FrmBuscarProfesor profSustituto = new FrmBuscarProfesor();
            if (profSustituto.ShowDialog() == DialogResult.OK)
            {
                profSus = await Negocio.ObtenerProfesor(profSustituto.ProfesorId);
                txtSustituto.Text = profSus.nombre + " " + profSus.ape1 + " " + profSus.ape2;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (comprobarCampos())
            {

                guardia.profFalta = profAus;
                guardia.profGuardia = profSus;
                guardia.fecha = dtpFecha.Value;
                guardia.hora = int.Parse(cbHoras.SelectedItem.ToString());
                guardia.aula = txtAula.Text;
                guardia.grupo = txtGrupo.Text;
                guardia.observaciones = txtObservaciones.Text;
                if (rbtnRealizada.Checked) guardia.estado = Estado.R;
                if (rbtnConfirmada.Checked) guardia.estado = Estado.C;
                if (rbtnAnulada.Checked) guardia.estado = Estado.A;
                this.DialogResult = DialogResult.OK;
                
                guardia.horario = null;

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
            if (txtAula.Text.Equals(String.Empty))
            {
                txtAula.Focus();
                mostrarAviso("Debes escoger un aula");
                return false;
            }
            if (txtGrupo.Text.Equals(String.Empty))
            {
                txtGrupo.Focus();
                mostrarAviso("Debes escoger un grupo");
                return false;
            }
            if (rbtnAnulada.Checked == false && rbtnConfirmada.Checked == false && rbtnRealizada.Checked == false)
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

        private void rellenarCampos(Guardia guardia)
        {
            profAus = guardia.profFalta;
            txtAusente.Text=profAus.nombre + " " + profAus.ape1 + " " + profAus.ape2;
            if (guardia.profGuardia != null)
            {
                profSus = guardia.profGuardia;
                txtSustituto.Text = profSus.nombre + " " + profSus.ape1 + " " + profSus.ape2;
            }
            dtpFecha.Value = guardia.fecha;
            cbHoras.Text = guardia.hora.ToString();
            if (guardia.aula!=null)
            {
                txtAula.Text = guardia.aula;
            }
            if (guardia.grupo!=null)
            {
                txtGrupo.Text = guardia.grupo;
            }
            if (guardia.observaciones!=null)
            {
                txtObservaciones.Text = guardia.observaciones;
            }
            switch (guardia.estado)
            {
                case Estado.R:
                    rbtnRealizada.Checked = true;
                    break;
                case Estado.C:
                    rbtnConfirmada.Checked = true;
                    break;
                case Estado.A:
                    rbtnAnulada.Checked = true;
                    break;
            }
        }

    }
}
