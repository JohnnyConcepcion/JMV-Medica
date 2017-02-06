namespace JMVMedica.App.Formularios
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.médicosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ubicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeFarmacosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem,
            this.mantenimientosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicamentosToolStripMenuItem,
            this.médicosToolStripMenuItem,
            this.pacientesToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicamentosToolStripMenuItem1,
            this.médicosToolStripMenuItem1,
            this.pacientesToolStripMenuItem1,
            this.marcasToolStripMenuItem,
            this.ubicacionesToolStripMenuItem,
            this.tipoDeFarmacosToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // medicamentosToolStripMenuItem
            // 
            this.medicamentosToolStripMenuItem.Name = "medicamentosToolStripMenuItem";
            this.medicamentosToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.medicamentosToolStripMenuItem.Text = "Medicamentos";
            // 
            // médicosToolStripMenuItem
            // 
            this.médicosToolStripMenuItem.Name = "médicosToolStripMenuItem";
            this.médicosToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.médicosToolStripMenuItem.Text = "Médicos";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // medicamentosToolStripMenuItem1
            // 
            this.medicamentosToolStripMenuItem1.Name = "medicamentosToolStripMenuItem1";
            this.medicamentosToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.medicamentosToolStripMenuItem1.Text = "Medicamentos";
            // 
            // médicosToolStripMenuItem1
            // 
            this.médicosToolStripMenuItem1.Name = "médicosToolStripMenuItem1";
            this.médicosToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.médicosToolStripMenuItem1.Text = "Médicos";
            // 
            // pacientesToolStripMenuItem1
            // 
            this.pacientesToolStripMenuItem1.Name = "pacientesToolStripMenuItem1";
            this.pacientesToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.pacientesToolStripMenuItem1.Text = "Pacientes";
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.marcasToolStripMenuItem.Text = "Marcas";
            // 
            // ubicacionesToolStripMenuItem
            // 
            this.ubicacionesToolStripMenuItem.Name = "ubicacionesToolStripMenuItem";
            this.ubicacionesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ubicacionesToolStripMenuItem.Text = "Ubicaciones";
            // 
            // tipoDeFarmacosToolStripMenuItem
            // 
            this.tipoDeFarmacosToolStripMenuItem.Name = "tipoDeFarmacosToolStripMenuItem";
            this.tipoDeFarmacosToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.tipoDeFarmacosToolStripMenuItem.Text = "Tipo de Farmacos";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "JMV-Medica";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamentosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem médicosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ubicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeFarmacosToolStripMenuItem;
    }
}