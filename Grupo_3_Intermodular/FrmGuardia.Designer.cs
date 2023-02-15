namespace Grupo_3_Intermodular
{
    partial class FrmGuardia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGuardia));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAusente = new System.Windows.Forms.TextBox();
            this.txtSustituto = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.rbtnRealizada = new System.Windows.Forms.RadioButton();
            this.rbtnConfirmada = new System.Windows.Forms.RadioButton();
            this.rbtnAnulada = new System.Windows.Forms.RadioButton();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnAutorrellenar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExaminarAusente = new System.Windows.Forms.Button();
            this.btnExaminarSustituto = new System.Windows.Forms.Button();
            this.cbHoras = new System.Windows.Forms.ComboBox();
            this.cbAula = new System.Windows.Forms.ComboBox();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profesor ausente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Observaciones:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Grupo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hora:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Profesor sustituto:";
            // 
            // txtAusente
            // 
            this.txtAusente.Location = new System.Drawing.Point(110, 13);
            this.txtAusente.Name = "txtAusente";
            this.txtAusente.ReadOnly = true;
            this.txtAusente.Size = new System.Drawing.Size(210, 20);
            this.txtAusente.TabIndex = 8;
            // 
            // txtSustituto
            // 
            this.txtSustituto.Location = new System.Drawing.Point(491, 10);
            this.txtSustituto.Name = "txtSustituto";
            this.txtSustituto.ReadOnly = true;
            this.txtSustituto.Size = new System.Drawing.Size(186, 20);
            this.txtSustituto.TabIndex = 11;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Checked = false;
            this.dtpFecha.Location = new System.Drawing.Point(110, 35);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(210, 20);
            this.dtpFecha.TabIndex = 14;
            // 
            // rbtnRealizada
            // 
            this.rbtnRealizada.AutoSize = true;
            this.rbtnRealizada.Location = new System.Drawing.Point(491, 103);
            this.rbtnRealizada.Name = "rbtnRealizada";
            this.rbtnRealizada.Size = new System.Drawing.Size(72, 17);
            this.rbtnRealizada.TabIndex = 15;
            this.rbtnRealizada.TabStop = true;
            this.rbtnRealizada.Text = "Realizada";
            this.rbtnRealizada.UseVisualStyleBackColor = true;
            // 
            // rbtnConfirmada
            // 
            this.rbtnConfirmada.AutoSize = true;
            this.rbtnConfirmada.Location = new System.Drawing.Point(491, 140);
            this.rbtnConfirmada.Name = "rbtnConfirmada";
            this.rbtnConfirmada.Size = new System.Drawing.Size(136, 17);
            this.rbtnConfirmada.TabIndex = 16;
            this.rbtnConfirmada.TabStop = true;
            this.rbtnConfirmada.Text = "Confirmada y pendiente";
            this.rbtnConfirmada.UseVisualStyleBackColor = true;
            // 
            // rbtnAnulada
            // 
            this.rbtnAnulada.AutoSize = true;
            this.rbtnAnulada.Location = new System.Drawing.Point(491, 180);
            this.rbtnAnulada.Name = "rbtnAnulada";
            this.rbtnAnulada.Size = new System.Drawing.Size(64, 17);
            this.rbtnAnulada.TabIndex = 17;
            this.rbtnAnulada.TabStop = true;
            this.rbtnAnulada.Text = "Anulada";
            this.rbtnAnulada.UseVisualStyleBackColor = true;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(12, 119);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(382, 151);
            this.txtObservaciones.TabIndex = 18;
            // 
            // btnAutorrellenar
            // 
            this.btnAutorrellenar.Location = new System.Drawing.Point(436, 244);
            this.btnAutorrellenar.Name = "btnAutorrellenar";
            this.btnAutorrellenar.Size = new System.Drawing.Size(75, 23);
            this.btnAutorrellenar.TabIndex = 19;
            this.btnAutorrellenar.Text = "Autorrellenar";
            this.btnAutorrellenar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(552, 244);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(662, 244);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExaminarAusente
            // 
            this.btnExaminarAusente.Location = new System.Drawing.Point(319, 13);
            this.btnExaminarAusente.Name = "btnExaminarAusente";
            this.btnExaminarAusente.Size = new System.Drawing.Size(75, 20);
            this.btnExaminarAusente.TabIndex = 22;
            this.btnExaminarAusente.Text = "Examinar";
            this.btnExaminarAusente.UseVisualStyleBackColor = true;
            this.btnExaminarAusente.Click += new System.EventHandler(this.btnExaminarAusente_Click);
            // 
            // btnExaminarSustituto
            // 
            this.btnExaminarSustituto.Location = new System.Drawing.Point(673, 10);
            this.btnExaminarSustituto.Name = "btnExaminarSustituto";
            this.btnExaminarSustituto.Size = new System.Drawing.Size(75, 20);
            this.btnExaminarSustituto.TabIndex = 23;
            this.btnExaminarSustituto.Text = "Examinar";
            this.btnExaminarSustituto.UseVisualStyleBackColor = true;
            this.btnExaminarSustituto.Click += new System.EventHandler(this.btnExaminarSustituto_Click);
            // 
            // cbHoras
            // 
            this.cbHoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHoras.FormattingEnabled = true;
            this.cbHoras.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbHoras.Location = new System.Drawing.Point(491, 31);
            this.cbHoras.Name = "cbHoras";
            this.cbHoras.Size = new System.Drawing.Size(140, 21);
            this.cbHoras.TabIndex = 24;
            // 
            // cbAula
            // 
            this.cbAula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAula.FormattingEnabled = true;
            this.cbAula.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbAula.Location = new System.Drawing.Point(110, 58);
            this.cbAula.Name = "cbAula";
            this.cbAula.Size = new System.Drawing.Size(133, 21);
            this.cbAula.TabIndex = 25;
            // 
            // cbGrupo
            // 
            this.cbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbGrupo.Location = new System.Drawing.Point(491, 57);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(140, 21);
            this.cbGrupo.TabIndex = 26;
            // 
            // FrmGuardia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 279);
            this.Controls.Add(this.cbGrupo);
            this.Controls.Add(this.cbAula);
            this.Controls.Add(this.cbHoras);
            this.Controls.Add(this.btnExaminarSustituto);
            this.Controls.Add(this.btnExaminarAusente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAutorrellenar);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.rbtnAnulada);
            this.Controls.Add(this.rbtnConfirmada);
            this.Controls.Add(this.rbtnRealizada);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtSustituto);
            this.Controls.Add(this.txtAusente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGuardia";
            this.Text = "Modificar guardia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAusente;
        private System.Windows.Forms.TextBox txtSustituto;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.RadioButton rbtnRealizada;
        private System.Windows.Forms.RadioButton rbtnConfirmada;
        private System.Windows.Forms.RadioButton rbtnAnulada;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnAutorrellenar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExaminarAusente;
        private System.Windows.Forms.Button btnExaminarSustituto;
        private System.Windows.Forms.ComboBox cbHoras;
        private System.Windows.Forms.ComboBox cbAula;
        private System.Windows.Forms.ComboBox cbGrupo;
    }
}