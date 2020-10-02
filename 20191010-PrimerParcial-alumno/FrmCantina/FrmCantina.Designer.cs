namespace FrmCantina
{
    partial class FrmCantina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCantina));
            this.grpbComandos = new System.Windows.Forms.GroupBox();
            this.rbCerveza = new System.Windows.Forms.RadioButton();
            this.rbAgua = new System.Windows.Forms.RadioButton();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblTipoBotella = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.cmbBotellaTipo = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.nUpDCapacidad = new System.Windows.Forms.NumericUpDown();
            this.nUpDContenido = new System.Windows.Forms.NumericUpDown();
            this.barra = new ControlCantina.Barra();
            this.grpbComandos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbComandos
            // 
            this.grpbComandos.Controls.Add(this.nUpDContenido);
            this.grpbComandos.Controls.Add(this.nUpDCapacidad);
            this.grpbComandos.Controls.Add(this.btnAgregar);
            this.grpbComandos.Controls.Add(this.cmbBotellaTipo);
            this.grpbComandos.Controls.Add(this.txtMarca);
            this.grpbComandos.Controls.Add(this.lblContenido);
            this.grpbComandos.Controls.Add(this.lblCapacidad);
            this.grpbComandos.Controls.Add(this.lblTipoBotella);
            this.grpbComandos.Controls.Add(this.lblMarca);
            this.grpbComandos.Controls.Add(this.rbAgua);
            this.grpbComandos.Controls.Add(this.rbCerveza);
            this.grpbComandos.Location = new System.Drawing.Point(12, 385);
            this.grpbComandos.Name = "grpbComandos";
            this.grpbComandos.Size = new System.Drawing.Size(566, 145);
            this.grpbComandos.TabIndex = 0;
            this.grpbComandos.TabStop = false;
            // 
            // rbCerveza
            // 
            this.rbCerveza.AutoSize = true;
            this.rbCerveza.Location = new System.Drawing.Point(10, 16);
            this.rbCerveza.Name = "rbCerveza";
            this.rbCerveza.Size = new System.Drawing.Size(64, 17);
            this.rbCerveza.TabIndex = 0;
            this.rbCerveza.TabStop = true;
            this.rbCerveza.Text = "Cerveza";
            this.rbCerveza.UseVisualStyleBackColor = true;
            // 
            // rbAgua
            // 
            this.rbAgua.AutoSize = true;
            this.rbAgua.Location = new System.Drawing.Point(10, 55);
            this.rbAgua.Name = "rbAgua";
            this.rbAgua.Size = new System.Drawing.Size(50, 17);
            this.rbAgua.TabIndex = 1;
            this.rbAgua.TabStop = true;
            this.rbAgua.Text = "Agua";
            this.rbAgua.UseVisualStyleBackColor = true;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(165, 18);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // lblTipoBotella
            // 
            this.lblTipoBotella.AutoSize = true;
            this.lblTipoBotella.Location = new System.Drawing.Point(370, 18);
            this.lblTipoBotella.Name = "lblTipoBotella";
            this.lblTipoBotella.Size = new System.Drawing.Size(63, 13);
            this.lblTipoBotella.TabIndex = 3;
            this.lblTipoBotella.Text = "Botella Tipo";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(165, 84);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lblCapacidad.TabIndex = 4;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(265, 84);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(55, 13);
            this.lblContenido.TabIndex = 5;
            this.lblContenido.Text = "Contenido";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(168, 34);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(134, 20);
            this.txtMarca.TabIndex = 6;
            // 
            // cmbBotellaTipo
            // 
            this.cmbBotellaTipo.FormattingEnabled = true;
            this.cmbBotellaTipo.Location = new System.Drawing.Point(373, 33);
            this.cmbBotellaTipo.Name = "cmbBotellaTipo";
            this.cmbBotellaTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbBotellaTipo.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(373, 92);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 28);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // nUpDCapacidad
            // 
            this.nUpDCapacidad.Location = new System.Drawing.Point(168, 100);
            this.nUpDCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nUpDCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDCapacidad.Name = "nUpDCapacidad";
            this.nUpDCapacidad.Size = new System.Drawing.Size(59, 20);
            this.nUpDCapacidad.TabIndex = 9;
            this.nUpDCapacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nUpDContenido
            // 
            this.nUpDContenido.Location = new System.Drawing.Point(268, 100);
            this.nUpDContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nUpDContenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDContenido.Name = "nUpDContenido";
            this.nUpDContenido.Size = new System.Drawing.Size(59, 20);
            this.nUpDContenido.TabIndex = 10;
            this.nUpDContenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // barra
            // 
            this.barra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra.BackgroundImage")));
            this.barra.Location = new System.Drawing.Point(11, 12);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(567, 360);
            this.barra.TabIndex = 1;
            // 
            // FrmCantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 542);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.grpbComandos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCantina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cantina Alejandro Bongioanni";
            this.Load += new System.EventHandler(this.FrmCantina_Load);
            this.grpbComandos.ResumeLayout(false);
            this.grpbComandos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDContenido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbComandos;
        private System.Windows.Forms.NumericUpDown nUpDContenido;
        private System.Windows.Forms.NumericUpDown nUpDCapacidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbBotellaTipo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblTipoBotella;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.RadioButton rbAgua;
        private System.Windows.Forms.RadioButton rbCerveza;
        private ControlCantina.Barra barra;
    }
}

