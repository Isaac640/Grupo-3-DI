﻿namespace Grupo_3_Intermodular
{
    partial class MantenimientoGuardias
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
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnNueva = new System.Windows.Forms.Button();
            this.lvGuardias = new System.Windows.Forms.ListView();
            this.chFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProfFalta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProfSusti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(12, 12);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(379, 20);
            this.txtFiltro.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(397, 10);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnNueva
            // 
            this.btnNueva.Location = new System.Drawing.Point(537, 9);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(75, 23);
            this.btnNueva.TabIndex = 2;
            this.btnNueva.Text = "Nueva";
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // lvGuardias
            // 
            this.lvGuardias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFecha,
            this.chHora,
            this.chProfFalta,
            this.chProfSusti,
            this.chEstado});
            this.lvGuardias.GridLines = true;
            this.lvGuardias.HideSelection = false;
            this.lvGuardias.Location = new System.Drawing.Point(12, 49);
            this.lvGuardias.MultiSelect = false;
            this.lvGuardias.Name = "lvGuardias";
            this.lvGuardias.Size = new System.Drawing.Size(600, 275);
            this.lvGuardias.TabIndex = 3;
            this.lvGuardias.UseCompatibleStateImageBehavior = false;
            this.lvGuardias.View = System.Windows.Forms.View.Details;
            // 
            // chFecha
            // 
            this.chFecha.Text = "Fecha";
            this.chFecha.Width = 160;
            // 
            // chHora
            // 
            this.chHora.Text = "Hora";
            this.chHora.Width = 50;
            // 
            // chProfFalta
            // 
            this.chProfFalta.Text = "Falta";
            this.chProfFalta.Width = 160;
            // 
            // chProfSusti
            // 
            this.chProfSusti.Text = "Sustituye";
            this.chProfSusti.Width = 160;
            // 
            // chEstado
            // 
            this.chEstado.Text = "Estado";
            this.chEstado.Width = 50;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(12, 340);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(44, 13);
            this.lblFiltro.TabIndex = 4;
            this.lblFiltro.Text = "Sin filtro";
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Location = new System.Drawing.Point(557, 340);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(55, 13);
            this.lblRegistros.TabIndex = 5;
            this.lblRegistros.Text = "6 registros";
            // 
            // MantenimientoGuardias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 362);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.lvGuardias);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtFiltro);
            this.Name = "MantenimientoGuardias";
            this.Text = " Mantenimiento guardias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.ListView lvGuardias;
        private System.Windows.Forms.ColumnHeader chFecha;
        private System.Windows.Forms.ColumnHeader chHora;
        private System.Windows.Forms.ColumnHeader chProfFalta;
        private System.Windows.Forms.ColumnHeader chProfSusti;
        private System.Windows.Forms.ColumnHeader chEstado;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblRegistros;
    }
}