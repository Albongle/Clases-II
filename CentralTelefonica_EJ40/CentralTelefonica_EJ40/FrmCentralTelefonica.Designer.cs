namespace CentralTelefonica_EJ40
{
    partial class FrmCentralTelefonica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCentralTelefonica));
            this.btnGenerarLLamada = new System.Windows.Forms.Button();
            this.btnFacturacionTotal = new System.Windows.Forms.Button();
            this.btnFacturacionLocal = new System.Windows.Forms.Button();
            this.btnFacturacionProvincial = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarLLamada
            // 
            this.btnGenerarLLamada.Location = new System.Drawing.Point(12, 12);
            this.btnGenerarLLamada.Name = "btnGenerarLLamada";
            this.btnGenerarLLamada.Size = new System.Drawing.Size(196, 49);
            this.btnGenerarLLamada.TabIndex = 0;
            this.btnGenerarLLamada.Text = "Generar LLamada";
            this.btnGenerarLLamada.UseVisualStyleBackColor = true;
            this.btnGenerarLLamada.Click += new System.EventHandler(this.btnGenerarLLamada_Click);
            // 
            // btnFacturacionTotal
            // 
            this.btnFacturacionTotal.Location = new System.Drawing.Point(12, 67);
            this.btnFacturacionTotal.Name = "btnFacturacionTotal";
            this.btnFacturacionTotal.Size = new System.Drawing.Size(196, 49);
            this.btnFacturacionTotal.TabIndex = 1;
            this.btnFacturacionTotal.Text = "Facturacion Total";
            this.btnFacturacionTotal.UseVisualStyleBackColor = true;
            this.btnFacturacionTotal.Click += new System.EventHandler(this.btnFacturacionTotal_Click);
            // 
            // btnFacturacionLocal
            // 
            this.btnFacturacionLocal.Location = new System.Drawing.Point(12, 122);
            this.btnFacturacionLocal.Name = "btnFacturacionLocal";
            this.btnFacturacionLocal.Size = new System.Drawing.Size(196, 49);
            this.btnFacturacionLocal.TabIndex = 2;
            this.btnFacturacionLocal.Text = "Facturacion Local";
            this.btnFacturacionLocal.UseVisualStyleBackColor = true;
            this.btnFacturacionLocal.Click += new System.EventHandler(this.btnFacturacionLocal_Click);
            // 
            // btnFacturacionProvincial
            // 
            this.btnFacturacionProvincial.Location = new System.Drawing.Point(12, 177);
            this.btnFacturacionProvincial.Name = "btnFacturacionProvincial";
            this.btnFacturacionProvincial.Size = new System.Drawing.Size(196, 49);
            this.btnFacturacionProvincial.TabIndex = 3;
            this.btnFacturacionProvincial.Text = "Facturacion Provincial";
            this.btnFacturacionProvincial.UseVisualStyleBackColor = true;
            this.btnFacturacionProvincial.Click += new System.EventHandler(this.btnFacturacionProvincial_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 232);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(196, 49);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmCentralTelefonica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 296);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFacturacionProvincial);
            this.Controls.Add(this.btnFacturacionLocal);
            this.Controls.Add(this.btnFacturacionTotal);
            this.Controls.Add(this.btnGenerarLLamada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCentralTelefonica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central Telefonica";
            this.Load += new System.EventHandler(this.frmCentralTelefonica_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarLLamada;
        private System.Windows.Forms.Button btnFacturacionTotal;
        private System.Windows.Forms.Button btnFacturacionLocal;
        private System.Windows.Forms.Button btnFacturacionProvincial;
        private System.Windows.Forms.Button btnSalir;
    }
}

