namespace PrimerParcial
{
    partial class FrmBar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.lblGente = new System.Windows.Forms.Label();
            this.btnInforme = new System.Windows.Forms.Button();
            this.nUpDEmpleado = new System.Windows.Forms.NumericUpDown();
            this.nUpDGente = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDGente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Location = new System.Drawing.Point(27, 24);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(59, 13);
            this.lblEmpleados.TabIndex = 0;
            this.lblEmpleados.Text = "Empleados";
            // 
            // lblGente
            // 
            this.lblGente.AutoSize = true;
            this.lblGente.Location = new System.Drawing.Point(27, 54);
            this.lblGente.Name = "lblGente";
            this.lblGente.Size = new System.Drawing.Size(36, 13);
            this.lblGente.TabIndex = 1;
            this.lblGente.Text = "Gente";
            // 
            // btnInforme
            // 
            this.btnInforme.Location = new System.Drawing.Point(128, 91);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(120, 33);
            this.btnInforme.TabIndex = 2;
            this.btnInforme.Text = "informe";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // nUpDEmpleado
            // 
            this.nUpDEmpleado.Location = new System.Drawing.Point(128, 17);
            this.nUpDEmpleado.Name = "nUpDEmpleado";
            this.nUpDEmpleado.Size = new System.Drawing.Size(120, 20);
            this.nUpDEmpleado.TabIndex = 3;
            this.nUpDEmpleado.ValueChanged += new System.EventHandler(this.nUpDEmpleado_ValueChanged);
            // 
            // nUpDGente
            // 
            this.nUpDGente.Location = new System.Drawing.Point(128, 52);
            this.nUpDGente.Name = "nUpDGente";
            this.nUpDGente.Size = new System.Drawing.Size(120, 20);
            this.nUpDGente.TabIndex = 4;
            this.nUpDGente.ValueChanged += new System.EventHandler(this.nUpDGente_ValueChanged);
            // 
            // FrmBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(428, 165);
            this.Controls.Add(this.nUpDGente);
            this.Controls.Add(this.nUpDEmpleado);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.lblGente);
            this.Controls.Add(this.lblEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador Alejandro Bongioanni";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUpDEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDGente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.Label lblGente;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.NumericUpDown nUpDEmpleado;
        private System.Windows.Forms.NumericUpDown nUpDGente;
    }
}

