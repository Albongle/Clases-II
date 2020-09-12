namespace Ejercicio_N23
{
    partial class FormConversor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConversor));
            this.labelEuro_F = new System.Windows.Forms.Label();
            this.labelDolar_F = new System.Windows.Forms.Label();
            this.labelPeso_F = new System.Windows.Forms.Label();
            this.labelCotizacion = new System.Windows.Forms.Label();
            this.textCotizacionEuro = new System.Windows.Forms.TextBox();
            this.textCotizacionDolar = new System.Windows.Forms.TextBox();
            this.textCotizacionPeso = new System.Windows.Forms.TextBox();
            this.labelEuro_C = new System.Windows.Forms.Label();
            this.labelDolar_C = new System.Windows.Forms.Label();
            this.labelPeso_C = new System.Windows.Forms.Label();
            this.txtEuroEuro = new System.Windows.Forms.TextBox();
            this.txtEuroDolar = new System.Windows.Forms.TextBox();
            this.txtEuroPeso = new System.Windows.Forms.TextBox();
            this.txtDolarEuro = new System.Windows.Forms.TextBox();
            this.txtDolarDolar = new System.Windows.Forms.TextBox();
            this.txtDolarPeso = new System.Windows.Forms.TextBox();
            this.txtPesoEuro = new System.Windows.Forms.TextBox();
            this.txtPesoDolar = new System.Windows.Forms.TextBox();
            this.txtPesoPeso = new System.Windows.Forms.TextBox();
            this.btnEuroConvert = new System.Windows.Forms.Button();
            this.btnDolarConvert = new System.Windows.Forms.Button();
            this.btnPesoConvert = new System.Windows.Forms.Button();
            this.txtCantidadEuro = new System.Windows.Forms.TextBox();
            this.txtCantidadDolar = new System.Windows.Forms.TextBox();
            this.txtCantidadPeso = new System.Windows.Forms.TextBox();
            this.buttonLockCotizacion = new System.Windows.Forms.Button();
            this.imglCandados = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // labelEuro_F
            // 
            this.labelEuro_F.AutoSize = true;
            this.labelEuro_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEuro_F.Location = new System.Drawing.Point(3, 99);
            this.labelEuro_F.Name = "labelEuro_F";
            this.labelEuro_F.Size = new System.Drawing.Size(47, 20);
            this.labelEuro_F.TabIndex = 1;
            this.labelEuro_F.Text = "Euro";
            // 
            // labelDolar_F
            // 
            this.labelDolar_F.AutoSize = true;
            this.labelDolar_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDolar_F.Location = new System.Drawing.Point(3, 133);
            this.labelDolar_F.Name = "labelDolar_F";
            this.labelDolar_F.Size = new System.Drawing.Size(52, 20);
            this.labelDolar_F.TabIndex = 2;
            this.labelDolar_F.Text = "Dolar";
            // 
            // labelPeso_F
            // 
            this.labelPeso_F.AutoSize = true;
            this.labelPeso_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeso_F.Location = new System.Drawing.Point(3, 165);
            this.labelPeso_F.Name = "labelPeso_F";
            this.labelPeso_F.Size = new System.Drawing.Size(49, 20);
            this.labelPeso_F.TabIndex = 3;
            this.labelPeso_F.Text = "Peso";
            // 
            // labelCotizacion
            // 
            this.labelCotizacion.AutoSize = true;
            this.labelCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCotizacion.Location = new System.Drawing.Point(52, 30);
            this.labelCotizacion.Name = "labelCotizacion";
            this.labelCotizacion.Size = new System.Drawing.Size(93, 20);
            this.labelCotizacion.TabIndex = 4;
            this.labelCotizacion.Text = "Cotizacion";
            // 
            // textCotizacionEuro
            // 
            this.textCotizacionEuro.Location = new System.Drawing.Point(242, 29);
            this.textCotizacionEuro.Name = "textCotizacionEuro";
            this.textCotizacionEuro.Size = new System.Drawing.Size(80, 20);
            this.textCotizacionEuro.TabIndex = 5;
            this.textCotizacionEuro.Leave += new System.EventHandler(this.textEuro_Leave);
            // 
            // textCotizacionDolar
            // 
            this.textCotizacionDolar.Location = new System.Drawing.Point(328, 29);
            this.textCotizacionDolar.Name = "textCotizacionDolar";
            this.textCotizacionDolar.Size = new System.Drawing.Size(80, 20);
            this.textCotizacionDolar.TabIndex = 6;
            this.textCotizacionDolar.Leave += new System.EventHandler(this.textCotizacionDolar_Leave);
            // 
            // textCotizacionPeso
            // 
            this.textCotizacionPeso.Location = new System.Drawing.Point(414, 29);
            this.textCotizacionPeso.Name = "textCotizacionPeso";
            this.textCotizacionPeso.Size = new System.Drawing.Size(80, 20);
            this.textCotizacionPeso.TabIndex = 7;
            this.textCotizacionPeso.Leave += new System.EventHandler(this.textCotizacionPeso_Leave);
            // 
            // labelEuro_C
            // 
            this.labelEuro_C.AutoSize = true;
            this.labelEuro_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEuro_C.Location = new System.Drawing.Point(257, 80);
            this.labelEuro_C.Name = "labelEuro_C";
            this.labelEuro_C.Size = new System.Drawing.Size(47, 20);
            this.labelEuro_C.TabIndex = 8;
            this.labelEuro_C.Text = "Euro";
            // 
            // labelDolar_C
            // 
            this.labelDolar_C.AutoSize = true;
            this.labelDolar_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDolar_C.Location = new System.Drawing.Point(341, 80);
            this.labelDolar_C.Name = "labelDolar_C";
            this.labelDolar_C.Size = new System.Drawing.Size(52, 20);
            this.labelDolar_C.TabIndex = 9;
            this.labelDolar_C.Text = "Dolar";
            // 
            // labelPeso_C
            // 
            this.labelPeso_C.AutoSize = true;
            this.labelPeso_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeso_C.Location = new System.Drawing.Point(431, 80);
            this.labelPeso_C.Name = "labelPeso_C";
            this.labelPeso_C.Size = new System.Drawing.Size(49, 20);
            this.labelPeso_C.TabIndex = 10;
            this.labelPeso_C.Text = "Peso";
            // 
            // txtEuroEuro
            // 
            this.txtEuroEuro.Enabled = false;
            this.txtEuroEuro.Location = new System.Drawing.Point(242, 99);
            this.txtEuroEuro.Name = "txtEuroEuro";
            this.txtEuroEuro.Size = new System.Drawing.Size(80, 20);
            this.txtEuroEuro.TabIndex = 11;
            // 
            // txtEuroDolar
            // 
            this.txtEuroDolar.Enabled = false;
            this.txtEuroDolar.Location = new System.Drawing.Point(328, 99);
            this.txtEuroDolar.Name = "txtEuroDolar";
            this.txtEuroDolar.Size = new System.Drawing.Size(80, 20);
            this.txtEuroDolar.TabIndex = 12;
            // 
            // txtEuroPeso
            // 
            this.txtEuroPeso.Enabled = false;
            this.txtEuroPeso.Location = new System.Drawing.Point(414, 99);
            this.txtEuroPeso.Name = "txtEuroPeso";
            this.txtEuroPeso.Size = new System.Drawing.Size(80, 20);
            this.txtEuroPeso.TabIndex = 13;
            // 
            // txtDolarEuro
            // 
            this.txtDolarEuro.Enabled = false;
            this.txtDolarEuro.Location = new System.Drawing.Point(242, 132);
            this.txtDolarEuro.Name = "txtDolarEuro";
            this.txtDolarEuro.Size = new System.Drawing.Size(80, 20);
            this.txtDolarEuro.TabIndex = 14;
            // 
            // txtDolarDolar
            // 
            this.txtDolarDolar.Enabled = false;
            this.txtDolarDolar.Location = new System.Drawing.Point(328, 132);
            this.txtDolarDolar.Name = "txtDolarDolar";
            this.txtDolarDolar.Size = new System.Drawing.Size(80, 20);
            this.txtDolarDolar.TabIndex = 15;
            // 
            // txtDolarPeso
            // 
            this.txtDolarPeso.Enabled = false;
            this.txtDolarPeso.Location = new System.Drawing.Point(414, 132);
            this.txtDolarPeso.Name = "txtDolarPeso";
            this.txtDolarPeso.Size = new System.Drawing.Size(80, 20);
            this.txtDolarPeso.TabIndex = 16;
            // 
            // txtPesoEuro
            // 
            this.txtPesoEuro.Enabled = false;
            this.txtPesoEuro.Location = new System.Drawing.Point(242, 164);
            this.txtPesoEuro.Name = "txtPesoEuro";
            this.txtPesoEuro.Size = new System.Drawing.Size(80, 20);
            this.txtPesoEuro.TabIndex = 17;
            // 
            // txtPesoDolar
            // 
            this.txtPesoDolar.Enabled = false;
            this.txtPesoDolar.Location = new System.Drawing.Point(328, 164);
            this.txtPesoDolar.Name = "txtPesoDolar";
            this.txtPesoDolar.Size = new System.Drawing.Size(80, 20);
            this.txtPesoDolar.TabIndex = 18;
            // 
            // txtPesoPeso
            // 
            this.txtPesoPeso.Enabled = false;
            this.txtPesoPeso.Location = new System.Drawing.Point(414, 164);
            this.txtPesoPeso.Name = "txtPesoPeso";
            this.txtPesoPeso.Size = new System.Drawing.Size(80, 20);
            this.txtPesoPeso.TabIndex = 19;
            // 
            // btnEuroConvert
            // 
            this.btnEuroConvert.Location = new System.Drawing.Point(151, 98);
            this.btnEuroConvert.Name = "btnEuroConvert";
            this.btnEuroConvert.Size = new System.Drawing.Size(85, 19);
            this.btnEuroConvert.TabIndex = 20;
            this.btnEuroConvert.Text = "->";
            this.btnEuroConvert.UseVisualStyleBackColor = true;
            this.btnEuroConvert.Click += new System.EventHandler(this.btnEuroConvert_Click);
            // 
            // btnDolarConvert
            // 
            this.btnDolarConvert.Location = new System.Drawing.Point(151, 133);
            this.btnDolarConvert.Name = "btnDolarConvert";
            this.btnDolarConvert.Size = new System.Drawing.Size(85, 19);
            this.btnDolarConvert.TabIndex = 21;
            this.btnDolarConvert.Text = "->";
            this.btnDolarConvert.UseVisualStyleBackColor = true;
            this.btnDolarConvert.Click += new System.EventHandler(this.btnDolarConvert_Click);
            // 
            // btnPesoConvert
            // 
            this.btnPesoConvert.Location = new System.Drawing.Point(151, 165);
            this.btnPesoConvert.Name = "btnPesoConvert";
            this.btnPesoConvert.Size = new System.Drawing.Size(85, 19);
            this.btnPesoConvert.TabIndex = 22;
            this.btnPesoConvert.Text = "->";
            this.btnPesoConvert.UseVisualStyleBackColor = true;
            this.btnPesoConvert.Click += new System.EventHandler(this.btnPesoConvert_Click);
            // 
            // txtCantidadEuro
            // 
            this.txtCantidadEuro.Location = new System.Drawing.Point(56, 99);
            this.txtCantidadEuro.Name = "txtCantidadEuro";
            this.txtCantidadEuro.Size = new System.Drawing.Size(80, 20);
            this.txtCantidadEuro.TabIndex = 23;
            // 
            // txtCantidadDolar
            // 
            this.txtCantidadDolar.Location = new System.Drawing.Point(56, 132);
            this.txtCantidadDolar.Name = "txtCantidadDolar";
            this.txtCantidadDolar.Size = new System.Drawing.Size(80, 20);
            this.txtCantidadDolar.TabIndex = 24;
            // 
            // txtCantidadPeso
            // 
            this.txtCantidadPeso.Location = new System.Drawing.Point(56, 164);
            this.txtCantidadPeso.Name = "txtCantidadPeso";
            this.txtCantidadPeso.Size = new System.Drawing.Size(80, 20);
            this.txtCantidadPeso.TabIndex = 25;
            // 
            // buttonLockCotizacion
            // 
            this.buttonLockCotizacion.AutoSize = true;
            this.buttonLockCotizacion.FlatAppearance.BorderSize = 0;
            this.buttonLockCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLockCotizacion.ImageIndex = 1;
            this.buttonLockCotizacion.ImageList = this.imglCandados;
            this.buttonLockCotizacion.Location = new System.Drawing.Point(151, 11);
            this.buttonLockCotizacion.Name = "buttonLockCotizacion";
            this.buttonLockCotizacion.Size = new System.Drawing.Size(54, 54);
            this.buttonLockCotizacion.TabIndex = 0;
            this.buttonLockCotizacion.UseVisualStyleBackColor = true;
            this.buttonLockCotizacion.Click += new System.EventHandler(this.buttonLockCotizacion_Click);
            // 
            // imglCandados
            // 
            this.imglCandados.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglCandados.ImageStream")));
            this.imglCandados.TransparentColor = System.Drawing.Color.Transparent;
            this.imglCandados.Images.SetKeyName(0, "Bloqueado.png");
            this.imglCandados.Images.SetKeyName(1, "Des Bloqueado.png");
            // 
            // FormConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 207);
            this.Controls.Add(this.txtCantidadPeso);
            this.Controls.Add(this.txtCantidadDolar);
            this.Controls.Add(this.txtCantidadEuro);
            this.Controls.Add(this.btnPesoConvert);
            this.Controls.Add(this.btnDolarConvert);
            this.Controls.Add(this.btnEuroConvert);
            this.Controls.Add(this.txtPesoPeso);
            this.Controls.Add(this.txtPesoDolar);
            this.Controls.Add(this.txtPesoEuro);
            this.Controls.Add(this.txtDolarPeso);
            this.Controls.Add(this.txtDolarDolar);
            this.Controls.Add(this.txtDolarEuro);
            this.Controls.Add(this.txtEuroPeso);
            this.Controls.Add(this.txtEuroDolar);
            this.Controls.Add(this.txtEuroEuro);
            this.Controls.Add(this.labelPeso_C);
            this.Controls.Add(this.labelDolar_C);
            this.Controls.Add(this.labelEuro_C);
            this.Controls.Add(this.textCotizacionPeso);
            this.Controls.Add(this.textCotizacionDolar);
            this.Controls.Add(this.textCotizacionEuro);
            this.Controls.Add(this.labelCotizacion);
            this.Controls.Add(this.labelPeso_F);
            this.Controls.Add(this.labelDolar_F);
            this.Controls.Add(this.labelEuro_F);
            this.Controls.Add(this.buttonLockCotizacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConversor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLockCotizacion;
        private System.Windows.Forms.Label labelEuro_F;
        private System.Windows.Forms.Label labelDolar_F;
        private System.Windows.Forms.Label labelPeso_F;
        private System.Windows.Forms.Label labelCotizacion;
        private System.Windows.Forms.TextBox textCotizacionEuro;
        private System.Windows.Forms.TextBox textCotizacionDolar;
        private System.Windows.Forms.TextBox textCotizacionPeso;
        private System.Windows.Forms.Label labelEuro_C;
        private System.Windows.Forms.Label labelDolar_C;
        private System.Windows.Forms.Label labelPeso_C;
        private System.Windows.Forms.TextBox txtEuroEuro;
        private System.Windows.Forms.TextBox txtEuroDolar;
        private System.Windows.Forms.TextBox txtEuroPeso;
        private System.Windows.Forms.TextBox txtDolarEuro;
        private System.Windows.Forms.TextBox txtDolarDolar;
        private System.Windows.Forms.TextBox txtDolarPeso;
        private System.Windows.Forms.TextBox txtPesoEuro;
        private System.Windows.Forms.TextBox txtPesoDolar;
        private System.Windows.Forms.TextBox txtPesoPeso;
        private System.Windows.Forms.Button btnEuroConvert;
        private System.Windows.Forms.Button btnDolarConvert;
        private System.Windows.Forms.Button btnPesoConvert;
        private System.Windows.Forms.TextBox txtCantidadEuro;
        private System.Windows.Forms.TextBox txtCantidadDolar;
        private System.Windows.Forms.TextBox txtCantidadPeso;
        private System.Windows.Forms.ImageList imglCandados;
    }
}

