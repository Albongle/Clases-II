namespace CentralTelefonica_EJ40
{
    partial class FrmLlamador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLlamador));
            this.txtNroDestino = new System.Windows.Forms.TextBox();
            this.btnNumero1 = new System.Windows.Forms.Button();
            this.btnNumero2 = new System.Windows.Forms.Button();
            this.btnNumero3 = new System.Windows.Forms.Button();
            this.btnNumero4 = new System.Windows.Forms.Button();
            this.btnNumero5 = new System.Windows.Forms.Button();
            this.btnNumero6 = new System.Windows.Forms.Button();
            this.btnNumero7 = new System.Windows.Forms.Button();
            this.btnNumero8 = new System.Windows.Forms.Button();
            this.btnNumero9 = new System.Windows.Forms.Button();
            this.btnAsterisco = new System.Windows.Forms.Button();
            this.btnNumero0 = new System.Windows.Forms.Button();
            this.btnNumeral = new System.Windows.Forms.Button();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNroOrigen = new System.Windows.Forms.TextBox();
            this.cmbFranja = new System.Windows.Forms.ComboBox();
            this.gpbPanel = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gpbPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNroDestino
            // 
            this.txtNroDestino.Enabled = false;
            this.txtNroDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroDestino.Location = new System.Drawing.Point(12, 12);
            this.txtNroDestino.Name = "txtNroDestino";
            this.txtNroDestino.Size = new System.Drawing.Size(260, 31);
            this.txtNroDestino.TabIndex = 0;
            this.txtNroDestino.Text = "Nro Destino";
            this.txtNroDestino.TextChanged += new System.EventHandler(this.txtNroDestino_TextChanged);
            // 
            // btnNumero1
            // 
            this.btnNumero1.Location = new System.Drawing.Point(7, 32);
            this.btnNumero1.Name = "btnNumero1";
            this.btnNumero1.Size = new System.Drawing.Size(30, 30);
            this.btnNumero1.TabIndex = 2;
            this.btnNumero1.Text = "1";
            this.btnNumero1.UseVisualStyleBackColor = true;
            this.btnNumero1.Click += new System.EventHandler(this.btnNumero1_Click);
            // 
            // btnNumero2
            // 
            this.btnNumero2.Location = new System.Drawing.Point(43, 32);
            this.btnNumero2.Name = "btnNumero2";
            this.btnNumero2.Size = new System.Drawing.Size(30, 30);
            this.btnNumero2.TabIndex = 3;
            this.btnNumero2.Text = "2";
            this.btnNumero2.UseVisualStyleBackColor = true;
            this.btnNumero2.Click += new System.EventHandler(this.btnNumero2_Click);
            // 
            // btnNumero3
            // 
            this.btnNumero3.Location = new System.Drawing.Point(79, 32);
            this.btnNumero3.Name = "btnNumero3";
            this.btnNumero3.Size = new System.Drawing.Size(30, 30);
            this.btnNumero3.TabIndex = 4;
            this.btnNumero3.Text = "3";
            this.btnNumero3.UseVisualStyleBackColor = true;
            this.btnNumero3.Click += new System.EventHandler(this.btnNumero3_Click);
            // 
            // btnNumero4
            // 
            this.btnNumero4.Location = new System.Drawing.Point(7, 68);
            this.btnNumero4.Name = "btnNumero4";
            this.btnNumero4.Size = new System.Drawing.Size(30, 30);
            this.btnNumero4.TabIndex = 5;
            this.btnNumero4.Text = "4";
            this.btnNumero4.UseVisualStyleBackColor = true;
            this.btnNumero4.Click += new System.EventHandler(this.btnNumero4_Click);
            // 
            // btnNumero5
            // 
            this.btnNumero5.Location = new System.Drawing.Point(43, 68);
            this.btnNumero5.Name = "btnNumero5";
            this.btnNumero5.Size = new System.Drawing.Size(30, 30);
            this.btnNumero5.TabIndex = 6;
            this.btnNumero5.Text = "5";
            this.btnNumero5.UseVisualStyleBackColor = true;
            this.btnNumero5.Click += new System.EventHandler(this.btnNumero5_Click);
            // 
            // btnNumero6
            // 
            this.btnNumero6.Location = new System.Drawing.Point(79, 68);
            this.btnNumero6.Name = "btnNumero6";
            this.btnNumero6.Size = new System.Drawing.Size(30, 30);
            this.btnNumero6.TabIndex = 7;
            this.btnNumero6.Text = "6";
            this.btnNumero6.UseVisualStyleBackColor = true;
            this.btnNumero6.Click += new System.EventHandler(this.btnNumero6_Click);
            // 
            // btnNumero7
            // 
            this.btnNumero7.Location = new System.Drawing.Point(7, 104);
            this.btnNumero7.Name = "btnNumero7";
            this.btnNumero7.Size = new System.Drawing.Size(30, 30);
            this.btnNumero7.TabIndex = 8;
            this.btnNumero7.Text = "7";
            this.btnNumero7.UseVisualStyleBackColor = true;
            this.btnNumero7.Click += new System.EventHandler(this.btnNumero7_Click);
            // 
            // btnNumero8
            // 
            this.btnNumero8.Location = new System.Drawing.Point(43, 104);
            this.btnNumero8.Name = "btnNumero8";
            this.btnNumero8.Size = new System.Drawing.Size(30, 30);
            this.btnNumero8.TabIndex = 9;
            this.btnNumero8.Text = "8";
            this.btnNumero8.UseVisualStyleBackColor = true;
            this.btnNumero8.Click += new System.EventHandler(this.btnNumero8_Click);
            // 
            // btnNumero9
            // 
            this.btnNumero9.Location = new System.Drawing.Point(79, 104);
            this.btnNumero9.Name = "btnNumero9";
            this.btnNumero9.Size = new System.Drawing.Size(30, 30);
            this.btnNumero9.TabIndex = 10;
            this.btnNumero9.Text = "9";
            this.btnNumero9.UseVisualStyleBackColor = true;
            this.btnNumero9.Click += new System.EventHandler(this.btnNumero9_Click);
            // 
            // btnAsterisco
            // 
            this.btnAsterisco.Location = new System.Drawing.Point(7, 140);
            this.btnAsterisco.Name = "btnAsterisco";
            this.btnAsterisco.Size = new System.Drawing.Size(30, 30);
            this.btnAsterisco.TabIndex = 11;
            this.btnAsterisco.Text = "*";
            this.btnAsterisco.UseVisualStyleBackColor = true;
            this.btnAsterisco.Click += new System.EventHandler(this.btnAsterisco_Click);
            // 
            // btnNumero0
            // 
            this.btnNumero0.Location = new System.Drawing.Point(43, 140);
            this.btnNumero0.Name = "btnNumero0";
            this.btnNumero0.Size = new System.Drawing.Size(30, 30);
            this.btnNumero0.TabIndex = 12;
            this.btnNumero0.Text = "0";
            this.btnNumero0.UseVisualStyleBackColor = true;
            this.btnNumero0.Click += new System.EventHandler(this.btnNumero0_Click);
            // 
            // btnNumeral
            // 
            this.btnNumeral.Location = new System.Drawing.Point(79, 140);
            this.btnNumeral.Name = "btnNumeral";
            this.btnNumeral.Size = new System.Drawing.Size(30, 30);
            this.btnNumeral.TabIndex = 13;
            this.btnNumeral.Text = "#";
            this.btnNumeral.UseVisualStyleBackColor = true;
            this.btnNumeral.Click += new System.EventHandler(this.btnNumeral_Click);
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(141, 81);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(131, 30);
            this.btnLlamar.TabIndex = 14;
            this.btnLlamar.Text = "Llamar";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(141, 117);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(131, 30);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(141, 185);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(131, 30);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtNroOrigen
            // 
            this.txtNroOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroOrigen.Location = new System.Drawing.Point(141, 159);
            this.txtNroOrigen.Name = "txtNroOrigen";
            this.txtNroOrigen.Size = new System.Drawing.Size(131, 20);
            this.txtNroOrigen.TabIndex = 17;
            this.txtNroOrigen.Text = "Nro Origen";
            this.txtNroOrigen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroOrigen_KeyPress);
            // 
            // cmbFranja
            // 
            this.cmbFranja.Enabled = false;
            this.cmbFranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFranja.FormattingEnabled = true;
            this.cmbFranja.Location = new System.Drawing.Point(12, 248);
            this.cmbFranja.Name = "cmbFranja";
            this.cmbFranja.Size = new System.Drawing.Size(260, 21);
            this.cmbFranja.TabIndex = 18;
            this.cmbFranja.Text = "Franja";
            // 
            // gpbPanel
            // 
            this.gpbPanel.Controls.Add(this.btnNumeral);
            this.gpbPanel.Controls.Add(this.btnNumero0);
            this.gpbPanel.Controls.Add(this.btnAsterisco);
            this.gpbPanel.Controls.Add(this.btnNumero9);
            this.gpbPanel.Controls.Add(this.btnNumero8);
            this.gpbPanel.Controls.Add(this.btnNumero7);
            this.gpbPanel.Controls.Add(this.btnNumero6);
            this.gpbPanel.Controls.Add(this.btnNumero5);
            this.gpbPanel.Controls.Add(this.btnNumero4);
            this.gpbPanel.Controls.Add(this.btnNumero3);
            this.gpbPanel.Controls.Add(this.btnNumero2);
            this.gpbPanel.Controls.Add(this.btnNumero1);
            this.gpbPanel.Location = new System.Drawing.Point(5, 49);
            this.gpbPanel.Name = "gpbPanel";
            this.gpbPanel.Size = new System.Drawing.Size(121, 176);
            this.gpbPanel.TabIndex = 19;
            this.gpbPanel.TabStop = false;
            this.gpbPanel.Text = "Panel";
            // 
            // FrmLlamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 281);
            this.Controls.Add(this.gpbPanel);
            this.Controls.Add(this.cmbFranja);
            this.Controls.Add(this.txtNroOrigen);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.txtNroDestino);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLlamador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Llamador";
            this.Load += new System.EventHandler(this.FrmLlamador_Load);
            this.gpbPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNroDestino;
        private System.Windows.Forms.Button btnNumero1;
        private System.Windows.Forms.Button btnNumero2;
        private System.Windows.Forms.Button btnNumero3;
        private System.Windows.Forms.Button btnNumero4;
        private System.Windows.Forms.Button btnNumero5;
        private System.Windows.Forms.Button btnNumero6;
        private System.Windows.Forms.Button btnNumero7;
        private System.Windows.Forms.Button btnNumero8;
        private System.Windows.Forms.Button btnNumero9;
        private System.Windows.Forms.Button btnAsterisco;
        private System.Windows.Forms.Button btnNumero0;
        private System.Windows.Forms.Button btnNumeral;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNroOrigen;
        private System.Windows.Forms.ComboBox cmbFranja;
        private System.Windows.Forms.GroupBox gpbPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}