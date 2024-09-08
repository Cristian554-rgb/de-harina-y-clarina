namespace SoftwareSensores
{
    partial class FrmSensores
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnActivar = new System.Windows.Forms.Button();
            this.btnActivar2 = new System.Windows.Forms.Button();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.btnDesactivar2 = new System.Windows.Forms.Button();
            this.timerSensor1 = new System.Windows.Forms.Timer(this.components);
            this.timerSensor2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sensor2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sensor1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // btnActivar
            // 
            this.btnActivar.Location = new System.Drawing.Point(157, 142);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(116, 56);
            this.btnActivar.TabIndex = 4;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // btnActivar2
            // 
            this.btnActivar2.Location = new System.Drawing.Point(397, 142);
            this.btnActivar2.Name = "btnActivar2";
            this.btnActivar2.Size = new System.Drawing.Size(116, 56);
            this.btnActivar2.TabIndex = 5;
            this.btnActivar2.Text = "Activar";
            this.btnActivar2.UseVisualStyleBackColor = true;
            this.btnActivar2.Click += new System.EventHandler(this.btnActivar2_Click);
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.Location = new System.Drawing.Point(144, 234);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(140, 56);
            this.btnDesactivar.TabIndex = 6;
            this.btnDesactivar.Text = "Desactivar";
            this.btnDesactivar.UseVisualStyleBackColor = true;
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // btnDesactivar2
            // 
            this.btnDesactivar2.Location = new System.Drawing.Point(381, 234);
            this.btnDesactivar2.Name = "btnDesactivar2";
            this.btnDesactivar2.Size = new System.Drawing.Size(149, 56);
            this.btnDesactivar2.TabIndex = 7;
            this.btnDesactivar2.Text = "Desactivar";
            this.btnDesactivar2.UseVisualStyleBackColor = true;
            this.btnDesactivar2.Click += new System.EventHandler(this.btnDesactivar2_Click);
            // 
            // timerSensor1
            // 
            this.timerSensor1.Interval = 1000;
            this.timerSensor1.Tick += new System.EventHandler(this.timerSensor1_Tick);
            // 
            // timerSensor2
            // 
            this.timerSensor2.Interval = 1000;
            this.timerSensor2.Tick += new System.EventHandler(this.timerSensor2_Tick);
            // 
            // FrmSensores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 382);
            this.Controls.Add(this.btnDesactivar2);
            this.Controls.Add(this.btnDesactivar);
            this.Controls.Add(this.btnActivar2);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmSensores";
            this.Text = "FrmSensores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Button btnActivar2;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Button btnDesactivar2;
        private System.Windows.Forms.Timer timerSensor1;
        private System.Windows.Forms.Timer timerSensor2;
    }
}