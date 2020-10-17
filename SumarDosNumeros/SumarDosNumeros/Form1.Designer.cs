namespace SumarDosNumeros
{
    partial class SumarNumeros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SumarNumeros));
            this.botonSumar = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.cajaNumero1 = new System.Windows.Forms.TextBox();
            this.cajaNumero2 = new System.Windows.Forms.TextBox();
            this.labelNumero1 = new System.Windows.Forms.Label();
            this.labelSegundoNumero = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.labelResultadoFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonSumar
            // 
            this.botonSumar.Location = new System.Drawing.Point(65, 152);
            this.botonSumar.Name = "botonSumar";
            this.botonSumar.Size = new System.Drawing.Size(75, 23);
            this.botonSumar.TabIndex = 0;
            this.botonSumar.Text = "Sumar";
            this.botonSumar.UseVisualStyleBackColor = true;
            this.botonSumar.Click += new System.EventHandler(this.botonSumar_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(155, 152);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 1;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // cajaNumero1
            // 
            this.cajaNumero1.Location = new System.Drawing.Point(130, 33);
            this.cajaNumero1.Name = "cajaNumero1";
            this.cajaNumero1.Size = new System.Drawing.Size(100, 20);
            this.cajaNumero1.TabIndex = 2;
            // 
            // cajaNumero2
            // 
            this.cajaNumero2.Location = new System.Drawing.Point(130, 85);
            this.cajaNumero2.Name = "cajaNumero2";
            this.cajaNumero2.Size = new System.Drawing.Size(100, 20);
            this.cajaNumero2.TabIndex = 3;
            // 
            // labelNumero1
            // 
            this.labelNumero1.AutoSize = true;
            this.labelNumero1.Location = new System.Drawing.Point(62, 33);
            this.labelNumero1.Name = "labelNumero1";
            this.labelNumero1.Size = new System.Drawing.Size(53, 13);
            this.labelNumero1.TabIndex = 4;
            this.labelNumero1.Text = "Número 1";
            // 
            // labelSegundoNumero
            // 
            this.labelSegundoNumero.AutoSize = true;
            this.labelSegundoNumero.Location = new System.Drawing.Point(62, 88);
            this.labelSegundoNumero.Name = "labelSegundoNumero";
            this.labelSegundoNumero.Size = new System.Drawing.Size(53, 13);
            this.labelSegundoNumero.TabIndex = 5;
            this.labelSegundoNumero.Text = "Número 2";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(297, 33);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(149, 25);
            this.labelResultado.TabIndex = 6;
            this.labelResultado.Text = "RESULTADO";
            // 
            // labelResultadoFinal
            // 
            this.labelResultadoFinal.AutoSize = true;
            this.labelResultadoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultadoFinal.Location = new System.Drawing.Point(294, 97);
            this.labelResultadoFinal.Name = "labelResultadoFinal";
            this.labelResultadoFinal.Size = new System.Drawing.Size(0, 55);
            this.labelResultadoFinal.TabIndex = 7;
            // 
            // SumarNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 211);
            this.Controls.Add(this.labelResultadoFinal);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelSegundoNumero);
            this.Controls.Add(this.labelNumero1);
            this.Controls.Add(this.cajaNumero2);
            this.Controls.Add(this.cajaNumero1);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonSumar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SumarNumeros";
            this.Text = "Sumar números";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonSumar;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.TextBox cajaNumero1;
        private System.Windows.Forms.TextBox cajaNumero2;
        private System.Windows.Forms.Label labelNumero1;
        private System.Windows.Forms.Label labelSegundoNumero;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label labelResultadoFinal;
    }
}

