namespace Grupo_3_Intermodular
{
    partial class FrmBuscarProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarProfesor));
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDni = new System.Windows.Forms.Button();
            this.btnNombre = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lvProfesores = new System.Windows.Forms.ListView();
            this.chDNI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chApellido1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chApellido2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(13, 13);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(422, 20);
            this.txtBuscar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar por:";
            // 
            // btnDni
            // 
            this.btnDni.Location = new System.Drawing.Point(16, 55);
            this.btnDni.Name = "btnDni";
            this.btnDni.Size = new System.Drawing.Size(75, 23);
            this.btnDni.TabIndex = 3;
            this.btnDni.Text = "DNI";
            this.btnDni.UseVisualStyleBackColor = true;
            this.btnDni.Click += new System.EventHandler(this.btnDni_Click);
            // 
            // btnNombre
            // 
            this.btnNombre.Location = new System.Drawing.Point(97, 55);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.Size = new System.Drawing.Size(74, 23);
            this.btnNombre.TabIndex = 4;
            this.btnNombre.Text = "Nombre";
            this.btnNombre.UseVisualStyleBackColor = true;
            this.btnNombre.Click += new System.EventHandler(this.btnNombre_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(359, 56);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lvProfesores
            // 
            this.lvProfesores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDNI,
            this.chNombre,
            this.chApellido1,
            this.chApellido2});
            this.lvProfesores.FullRowSelect = true;
            this.lvProfesores.GridLines = true;
            this.lvProfesores.HideSelection = false;
            this.lvProfesores.Location = new System.Drawing.Point(12, 85);
            this.lvProfesores.MultiSelect = false;
            this.lvProfesores.Name = "lvProfesores";
            this.lvProfesores.Size = new System.Drawing.Size(423, 186);
            this.lvProfesores.TabIndex = 7;
            this.lvProfesores.UseCompatibleStateImageBehavior = false;
            this.lvProfesores.View = System.Windows.Forms.View.Details;
            this.lvProfesores.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvProfesores_MouseDoubleClick);
            // 
            // chDNI
            // 
            this.chDNI.Text = "DNI";
            this.chDNI.Width = 94;
            // 
            // chNombre
            // 
            this.chNombre.Text = "Nombre";
            this.chNombre.Width = 135;
            // 
            // chApellido1
            // 
            this.chApellido1.Text = "Apellido 1";
            this.chApellido1.Width = 98;
            // 
            // chApellido2
            // 
            this.chApellido2.Text = "Apellido 2";
            this.chApellido2.Width = 92;
            // 
            // FrmBuscarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 283);
            this.Controls.Add(this.lvProfesores);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNombre);
            this.Controls.Add(this.btnDni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBuscarProfesor";
            this.Text = "Seleccionar profesor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDni;
        private System.Windows.Forms.Button btnNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListView lvProfesores;
        private System.Windows.Forms.ColumnHeader chDNI;
        private System.Windows.Forms.ColumnHeader chNombre;
        private System.Windows.Forms.ColumnHeader chApellido1;
        private System.Windows.Forms.ColumnHeader chApellido2;
    }
}