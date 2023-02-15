namespace Grupo_3_Intermodular
{
    partial class ContenedorMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContenedorMDI));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGuardias = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMantenimientos});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(800, 24);
            this.msMenu.TabIndex = 1;
            this.msMenu.Text = "Menu";
            // 
            // tsmiMantenimientos
            // 
            this.tsmiMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGuardias});
            this.tsmiMantenimientos.Name = "tsmiMantenimientos";
            this.tsmiMantenimientos.Size = new System.Drawing.Size(106, 20);
            this.tsmiMantenimientos.Text = "Mantenimientos";
            // 
            // tsmiGuardias
            // 
            this.tsmiGuardias.Name = "tsmiGuardias";
            this.tsmiGuardias.Size = new System.Drawing.Size(180, 22);
            this.tsmiGuardias.Text = "Guardias";
            this.tsmiGuardias.Click += new System.EventHandler(this.tsmiGuardias_Click);
            // 
            // ContenedorMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenu;
            this.Name = "ContenedorMDI";
            this.Text = "Gestión de faltas";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem tsmiGuardias;
    }
}