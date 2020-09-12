namespace Ejercicio_N24
{
    partial class FormTemperartura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTemperartura));
            this.lblFilaFahrenheit = new System.Windows.Forms.Label();
            this.lblFilaKelvin = new System.Windows.Forms.Label();
            this.lblFilaCelcius = new System.Windows.Forms.Label();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.txtCelcius = new System.Windows.Forms.TextBox();
            this.txtKelvin = new System.Windows.Forms.TextBox();
            this.btnFahrenheit = new System.Windows.Forms.Button();
            this.btnCelcius = new System.Windows.Forms.Button();
            this.btnKelvin = new System.Windows.Forms.Button();
            this.lblColumnaFahrenheit = new System.Windows.Forms.Label();
            this.lblColumnaCelcius = new System.Windows.Forms.Label();
            this.lblColumnaKelvin = new System.Windows.Forms.Label();
            this.txtFahFah = new System.Windows.Forms.TextBox();
            this.txtFahCelcius = new System.Windows.Forms.TextBox();
            this.txtFahKelvin = new System.Windows.Forms.TextBox();
            this.txtCelciusFah = new System.Windows.Forms.TextBox();
            this.txtCelCel = new System.Windows.Forms.TextBox();
            this.txtCelKelvin = new System.Windows.Forms.TextBox();
            this.txtKelvinFah = new System.Windows.Forms.TextBox();
            this.txtKelvinCel = new System.Windows.Forms.TextBox();
            this.txtKelKel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFilaFahrenheit
            // 
            this.lblFilaFahrenheit.AutoSize = true;
            this.lblFilaFahrenheit.Location = new System.Drawing.Point(10, 23);
            this.lblFilaFahrenheit.Name = "lblFilaFahrenheit";
            this.lblFilaFahrenheit.Size = new System.Drawing.Size(57, 13);
            this.lblFilaFahrenheit.TabIndex = 0;
            this.lblFilaFahrenheit.Text = "Fahrenheit";
            // 
            // lblFilaKelvin
            // 
            this.lblFilaKelvin.AutoSize = true;
            this.lblFilaKelvin.Location = new System.Drawing.Point(12, 88);
            this.lblFilaKelvin.Name = "lblFilaKelvin";
            this.lblFilaKelvin.Size = new System.Drawing.Size(36, 13);
            this.lblFilaKelvin.TabIndex = 1;
            this.lblFilaKelvin.Text = "Kelvin";
            // 
            // lblFilaCelcius
            // 
            this.lblFilaCelcius.AutoSize = true;
            this.lblFilaCelcius.Location = new System.Drawing.Point(10, 57);
            this.lblFilaCelcius.Name = "lblFilaCelcius";
            this.lblFilaCelcius.Size = new System.Drawing.Size(41, 13);
            this.lblFilaCelcius.TabIndex = 2;
            this.lblFilaCelcius.Text = "Celcius";
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(73, 16);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(49, 20);
            this.txtFahrenheit.TabIndex = 3;
            this.txtFahrenheit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFahrenheit_KeyPress);
            // 
            // txtCelcius
            // 
            this.txtCelcius.Location = new System.Drawing.Point(73, 50);
            this.txtCelcius.Name = "txtCelcius";
            this.txtCelcius.Size = new System.Drawing.Size(49, 20);
            this.txtCelcius.TabIndex = 4;
            this.txtCelcius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelcius_KeyPress);
            // 
            // txtKelvin
            // 
            this.txtKelvin.Location = new System.Drawing.Point(73, 81);
            this.txtKelvin.Name = "txtKelvin";
            this.txtKelvin.Size = new System.Drawing.Size(49, 20);
            this.txtKelvin.TabIndex = 5;
            this.txtKelvin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKelvin_KeyPress);
            // 
            // btnFahrenheit
            // 
            this.btnFahrenheit.Location = new System.Drawing.Point(128, 14);
            this.btnFahrenheit.Name = "btnFahrenheit";
            this.btnFahrenheit.Size = new System.Drawing.Size(77, 23);
            this.btnFahrenheit.TabIndex = 6;
            this.btnFahrenheit.Text = "->";
            this.btnFahrenheit.UseVisualStyleBackColor = true;
            this.btnFahrenheit.Click += new System.EventHandler(this.btnFahrenheit_Click);
            // 
            // btnCelcius
            // 
            this.btnCelcius.Location = new System.Drawing.Point(128, 48);
            this.btnCelcius.Name = "btnCelcius";
            this.btnCelcius.Size = new System.Drawing.Size(77, 23);
            this.btnCelcius.TabIndex = 7;
            this.btnCelcius.Text = "->";
            this.btnCelcius.UseVisualStyleBackColor = true;
            this.btnCelcius.Click += new System.EventHandler(this.btnCelcius_Click);
            // 
            // btnKelvin
            // 
            this.btnKelvin.Location = new System.Drawing.Point(128, 79);
            this.btnKelvin.Name = "btnKelvin";
            this.btnKelvin.Size = new System.Drawing.Size(77, 23);
            this.btnKelvin.TabIndex = 8;
            this.btnKelvin.Text = "->";
            this.btnKelvin.UseVisualStyleBackColor = true;
            this.btnKelvin.Click += new System.EventHandler(this.btnKelvin_Click);
            // 
            // lblColumnaFahrenheit
            // 
            this.lblColumnaFahrenheit.AutoSize = true;
            this.lblColumnaFahrenheit.Location = new System.Drawing.Point(249, 0);
            this.lblColumnaFahrenheit.Name = "lblColumnaFahrenheit";
            this.lblColumnaFahrenheit.Size = new System.Drawing.Size(57, 13);
            this.lblColumnaFahrenheit.TabIndex = 9;
            this.lblColumnaFahrenheit.Text = "Fahrenheit";
            // 
            // lblColumnaCelcius
            // 
            this.lblColumnaCelcius.AutoSize = true;
            this.lblColumnaCelcius.Location = new System.Drawing.Point(319, 0);
            this.lblColumnaCelcius.Name = "lblColumnaCelcius";
            this.lblColumnaCelcius.Size = new System.Drawing.Size(41, 13);
            this.lblColumnaCelcius.TabIndex = 10;
            this.lblColumnaCelcius.Text = "Celcius";
            // 
            // lblColumnaKelvin
            // 
            this.lblColumnaKelvin.AutoSize = true;
            this.lblColumnaKelvin.Location = new System.Drawing.Point(388, 0);
            this.lblColumnaKelvin.Name = "lblColumnaKelvin";
            this.lblColumnaKelvin.Size = new System.Drawing.Size(36, 13);
            this.lblColumnaKelvin.TabIndex = 11;
            this.lblColumnaKelvin.Text = "Kelvin";
            // 
            // txtFahFah
            // 
            this.txtFahFah.Enabled = false;
            this.txtFahFah.Location = new System.Drawing.Point(252, 16);
            this.txtFahFah.Name = "txtFahFah";
            this.txtFahFah.Size = new System.Drawing.Size(54, 20);
            this.txtFahFah.TabIndex = 12;
            // 
            // txtFahCelcius
            // 
            this.txtFahCelcius.Enabled = false;
            this.txtFahCelcius.Location = new System.Drawing.Point(322, 16);
            this.txtFahCelcius.Name = "txtFahCelcius";
            this.txtFahCelcius.Size = new System.Drawing.Size(54, 20);
            this.txtFahCelcius.TabIndex = 13;
            // 
            // txtFahKelvin
            // 
            this.txtFahKelvin.Enabled = false;
            this.txtFahKelvin.Location = new System.Drawing.Point(391, 16);
            this.txtFahKelvin.Name = "txtFahKelvin";
            this.txtFahKelvin.Size = new System.Drawing.Size(54, 20);
            this.txtFahKelvin.TabIndex = 14;
            // 
            // txtCelciusFah
            // 
            this.txtCelciusFah.Enabled = false;
            this.txtCelciusFah.Location = new System.Drawing.Point(252, 50);
            this.txtCelciusFah.Name = "txtCelciusFah";
            this.txtCelciusFah.Size = new System.Drawing.Size(54, 20);
            this.txtCelciusFah.TabIndex = 15;
            // 
            // txtCelCel
            // 
            this.txtCelCel.Enabled = false;
            this.txtCelCel.Location = new System.Drawing.Point(322, 50);
            this.txtCelCel.Name = "txtCelCel";
            this.txtCelCel.Size = new System.Drawing.Size(54, 20);
            this.txtCelCel.TabIndex = 16;
            // 
            // txtCelKelvin
            // 
            this.txtCelKelvin.Enabled = false;
            this.txtCelKelvin.Location = new System.Drawing.Point(391, 50);
            this.txtCelKelvin.Name = "txtCelKelvin";
            this.txtCelKelvin.Size = new System.Drawing.Size(54, 20);
            this.txtCelKelvin.TabIndex = 17;
            // 
            // txtKelvinFah
            // 
            this.txtKelvinFah.Enabled = false;
            this.txtKelvinFah.Location = new System.Drawing.Point(252, 81);
            this.txtKelvinFah.Name = "txtKelvinFah";
            this.txtKelvinFah.Size = new System.Drawing.Size(54, 20);
            this.txtKelvinFah.TabIndex = 18;
            // 
            // txtKelvinCel
            // 
            this.txtKelvinCel.Enabled = false;
            this.txtKelvinCel.Location = new System.Drawing.Point(322, 82);
            this.txtKelvinCel.Name = "txtKelvinCel";
            this.txtKelvinCel.Size = new System.Drawing.Size(54, 20);
            this.txtKelvinCel.TabIndex = 19;
            // 
            // txtKelKel
            // 
            this.txtKelKel.Enabled = false;
            this.txtKelKel.Location = new System.Drawing.Point(391, 82);
            this.txtKelKel.Name = "txtKelKel";
            this.txtKelKel.Size = new System.Drawing.Size(54, 20);
            this.txtKelKel.TabIndex = 20;
            // 
            // FormTemperartura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 109);
            this.Controls.Add(this.txtKelKel);
            this.Controls.Add(this.txtKelvinCel);
            this.Controls.Add(this.txtKelvinFah);
            this.Controls.Add(this.txtCelKelvin);
            this.Controls.Add(this.txtCelCel);
            this.Controls.Add(this.txtCelciusFah);
            this.Controls.Add(this.txtFahKelvin);
            this.Controls.Add(this.txtFahCelcius);
            this.Controls.Add(this.txtFahFah);
            this.Controls.Add(this.lblColumnaKelvin);
            this.Controls.Add(this.lblColumnaCelcius);
            this.Controls.Add(this.lblColumnaFahrenheit);
            this.Controls.Add(this.btnKelvin);
            this.Controls.Add(this.btnCelcius);
            this.Controls.Add(this.btnFahrenheit);
            this.Controls.Add(this.txtKelvin);
            this.Controls.Add(this.txtCelcius);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.lblFilaCelcius);
            this.Controls.Add(this.lblFilaKelvin);
            this.Controls.Add(this.lblFilaFahrenheit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTemperartura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilaFahrenheit;
        private System.Windows.Forms.Label lblFilaKelvin;
        private System.Windows.Forms.Label lblFilaCelcius;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.TextBox txtCelcius;
        private System.Windows.Forms.TextBox txtKelvin;
        private System.Windows.Forms.Button btnFahrenheit;
        private System.Windows.Forms.Button btnCelcius;
        private System.Windows.Forms.Button btnKelvin;
        private System.Windows.Forms.Label lblColumnaFahrenheit;
        private System.Windows.Forms.Label lblColumnaCelcius;
        private System.Windows.Forms.Label lblColumnaKelvin;
        private System.Windows.Forms.TextBox txtFahFah;
        private System.Windows.Forms.TextBox txtFahCelcius;
        private System.Windows.Forms.TextBox txtFahKelvin;
        private System.Windows.Forms.TextBox txtCelciusFah;
        private System.Windows.Forms.TextBox txtCelCel;
        private System.Windows.Forms.TextBox txtCelKelvin;
        private System.Windows.Forms.TextBox txtKelvinFah;
        private System.Windows.Forms.TextBox txtKelvinCel;
        private System.Windows.Forms.TextBox txtKelKel;
    }
}

