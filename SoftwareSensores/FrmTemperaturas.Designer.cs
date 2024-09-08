namespace SoftwareSensores
{
    partial class FrmTemperaturas
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
            this.lblTemperatura1 = new System.Windows.Forms.Label();
            this.lblTemperatura2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHt = new System.Windows.Forms.Button();
            this.dtgvHt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTemperatura1
            // 
            this.lblTemperatura1.AutoSize = true;
            this.lblTemperatura1.Location = new System.Drawing.Point(198, 25);
            this.lblTemperatura1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTemperatura1.Name = "lblTemperatura1";
            this.lblTemperatura1.Size = new System.Drawing.Size(79, 29);
            this.lblTemperatura1.TabIndex = 0;
            this.lblTemperatura1.Text = "label1";
            // 
            // lblTemperatura2
            // 
            this.lblTemperatura2.AutoSize = true;
            this.lblTemperatura2.Location = new System.Drawing.Point(570, 25);
            this.lblTemperatura2.Name = "lblTemperatura2";
            this.lblTemperatura2.Size = new System.Drawing.Size(79, 29);
            this.lblTemperatura2.TabIndex = 1;
            this.lblTemperatura2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sensor1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sensor2";
            // 
            // btnHt
            // 
            this.btnHt.Location = new System.Drawing.Point(129, 76);
            this.btnHt.Name = "btnHt";
            this.btnHt.Size = new System.Drawing.Size(502, 47);
            this.btnHt.TabIndex = 4;
            this.btnHt.Text = "Mostrar historial de temperaturas";
            this.btnHt.UseVisualStyleBackColor = true;
            this.btnHt.Click += new System.EventHandler(this.btnHt_Click);
            // 
            // dtgvHt
            // 
            this.dtgvHt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHt.Location = new System.Drawing.Point(75, 129);
            this.dtgvHt.Name = "dtgvHt";
            this.dtgvHt.RowHeadersWidth = 51;
            this.dtgvHt.RowTemplate.Height = 24;
            this.dtgvHt.Size = new System.Drawing.Size(649, 372);
            this.dtgvHt.TabIndex = 5;
            // 
            // FrmTemperaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 528);
            this.Controls.Add(this.dtgvHt);
            this.Controls.Add(this.btnHt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTemperatura2);
            this.Controls.Add(this.lblTemperatura1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmTemperaturas";
            this.Text = "FrmTemperaturas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemperatura1;
        private System.Windows.Forms.Label lblTemperatura2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHt;
        private System.Windows.Forms.DataGridView dtgvHt;
    }
}