namespace SumaParcialesListBox
{
    partial class VistaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.listaSumas = new System.Windows.Forms.ListBox();
            this.updownNumeroIntroducido = new System.Windows.Forms.NumericUpDown();
            this.checkBoxVerResultadosParciales = new System.Windows.Forms.CheckBox();
            this.botonCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updownNumeroIntroducido)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular suma desde 1 hasta: ";
            // 
            // listaSumas
            // 
            this.listaSumas.FormattingEnabled = true;
            this.listaSumas.Location = new System.Drawing.Point(42, 100);
            this.listaSumas.Name = "listaSumas";
            this.listaSumas.Size = new System.Drawing.Size(292, 186);
            this.listaSumas.TabIndex = 1;
            // 
            // updownNumeroIntroducido
            // 
            this.updownNumeroIntroducido.Location = new System.Drawing.Point(214, 30);
            this.updownNumeroIntroducido.Name = "updownNumeroIntroducido";
            this.updownNumeroIntroducido.Size = new System.Drawing.Size(120, 20);
            this.updownNumeroIntroducido.TabIndex = 2;
            // 
            // checkBoxVerResultadosParciales
            // 
            this.checkBoxVerResultadosParciales.AutoSize = true;
            this.checkBoxVerResultadosParciales.Location = new System.Drawing.Point(42, 67);
            this.checkBoxVerResultadosParciales.Name = "checkBoxVerResultadosParciales";
            this.checkBoxVerResultadosParciales.Size = new System.Drawing.Size(138, 17);
            this.checkBoxVerResultadosParciales.TabIndex = 3;
            this.checkBoxVerResultadosParciales.Text = "Ver resultados parciales";
            this.checkBoxVerResultadosParciales.UseVisualStyleBackColor = true;
            // 
            // botonCalcular
            // 
            this.botonCalcular.Location = new System.Drawing.Point(143, 316);
            this.botonCalcular.Name = "botonCalcular";
            this.botonCalcular.Size = new System.Drawing.Size(75, 23);
            this.botonCalcular.TabIndex = 4;
            this.botonCalcular.Text = "Calcular";
            this.botonCalcular.UseVisualStyleBackColor = true;
            this.botonCalcular.Click += new System.EventHandler(this.botonCalcular_Click);
            // 
            // VistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 368);
            this.Controls.Add(this.botonCalcular);
            this.Controls.Add(this.checkBoxVerResultadosParciales);
            this.Controls.Add(this.updownNumeroIntroducido);
            this.Controls.Add(this.listaSumas);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sumas de 1 a N";
            ((System.ComponentModel.ISupportInitialize)(this.updownNumeroIntroducido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listaSumas;
        private System.Windows.Forms.NumericUpDown updownNumeroIntroducido;
        private System.Windows.Forms.CheckBox checkBoxVerResultadosParciales;
        private System.Windows.Forms.Button botonCalcular;
    }
}

