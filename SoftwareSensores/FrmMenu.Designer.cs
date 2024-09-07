namespace SoftwareSensores
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.optUsuarios = new System.Windows.Forms.ToolStripButton();
            this.optSensores = new System.Windows.Forms.ToolStripButton();
            this.optTemperaturas = new System.Windows.Forms.ToolStripButton();
            this.optSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optUsuarios,
            this.optSensores,
            this.optTemperaturas,
            this.optSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(600, 103);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // optUsuarios
            // 
            this.optUsuarios.AutoSize = false;
            this.optUsuarios.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("optUsuarios.Image")));
            this.optUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optUsuarios.Name = "optUsuarios";
            this.optUsuarios.Size = new System.Drawing.Size(100, 100);
            this.optUsuarios.Text = "Usuarios";
            this.optUsuarios.Click += new System.EventHandler(this.optUsuarios_Click);
            // 
            // optSensores
            // 
            this.optSensores.AutoSize = false;
            this.optSensores.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.optSensores.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optSensores.Image = ((System.Drawing.Image)(resources.GetObject("optSensores.Image")));
            this.optSensores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optSensores.Name = "optSensores";
            this.optSensores.Size = new System.Drawing.Size(100, 100);
            this.optSensores.Text = "Sensores";
            this.optSensores.Click += new System.EventHandler(this.optSensores_Click);
            // 
            // optTemperaturas
            // 
            this.optTemperaturas.AutoSize = false;
            this.optTemperaturas.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.optTemperaturas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optTemperaturas.Image = ((System.Drawing.Image)(resources.GetObject("optTemperaturas.Image")));
            this.optTemperaturas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optTemperaturas.Name = "optTemperaturas";
            this.optTemperaturas.Size = new System.Drawing.Size(100, 100);
            this.optTemperaturas.Text = "Temperaturas";
            this.optTemperaturas.Click += new System.EventHandler(this.optTemperaturas_Click);
            // 
            // optSalir
            // 
            this.optSalir.AutoSize = false;
            this.optSalir.BackColor = System.Drawing.Color.Red;
            this.optSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optSalir.Image = ((System.Drawing.Image)(resources.GetObject("optSalir.Image")));
            this.optSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optSalir.Name = "optSalir";
            this.optSalir.Size = new System.Drawing.Size(100, 100);
            this.optSalir.Text = "Salir";
            this.optSalir.Click += new System.EventHandler(this.optSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton optUsuarios;
        private System.Windows.Forms.ToolStripButton optSensores;
        private System.Windows.Forms.ToolStripButton optTemperaturas;
        private System.Windows.Forms.ToolStripButton optSalir;
    }
}