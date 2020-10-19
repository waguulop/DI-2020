namespace POOWindowsForm
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.labelNumCuenta = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.labelTipoInteres = new System.Windows.Forms.Label();
            this.labelCuotaMantenimiento = new System.Windows.Forms.Label();
            this.labelResNumCuenta = new System.Windows.Forms.Label();
            this.labelResNombre = new System.Windows.Forms.Label();
            this.labelResSaldo = new System.Windows.Forms.Label();
            this.labelResTipoInteres = new System.Windows.Forms.Label();
            this.labelResCuotaMantenimiento = new System.Windows.Forms.Label();
            this.buttonAdelante = new System.Windows.Forms.Button();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumCuenta
            // 
            this.labelNumCuenta.AutoSize = true;
            this.labelNumCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumCuenta.Location = new System.Drawing.Point(57, 42);
            this.labelNumCuenta.Name = "labelNumCuenta";
            this.labelNumCuenta.Size = new System.Drawing.Size(134, 18);
            this.labelNumCuenta.TabIndex = 0;
            this.labelNumCuenta.Text = "Numero de cuenta:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(57, 75);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(66, 18);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldo.Location = new System.Drawing.Point(57, 107);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(50, 18);
            this.labelSaldo.TabIndex = 2;
            this.labelSaldo.Text = "Saldo:";
            // 
            // labelTipoInteres
            // 
            this.labelTipoInteres.AutoSize = true;
            this.labelTipoInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoInteres.Location = new System.Drawing.Point(57, 142);
            this.labelTipoInteres.Name = "labelTipoInteres";
            this.labelTipoInteres.Size = new System.Drawing.Size(89, 18);
            this.labelTipoInteres.TabIndex = 3;
            this.labelTipoInteres.Text = "Tipo interés:";
            // 
            // labelCuotaMantenimiento
            // 
            this.labelCuotaMantenimiento.AutoSize = true;
            this.labelCuotaMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuotaMantenimiento.Location = new System.Drawing.Point(57, 173);
            this.labelCuotaMantenimiento.Name = "labelCuotaMantenimiento";
            this.labelCuotaMantenimiento.Size = new System.Drawing.Size(50, 18);
            this.labelCuotaMantenimiento.TabIndex = 4;
            this.labelCuotaMantenimiento.Text = "label1:";
            // 
            // labelResNumCuenta
            // 
            this.labelResNumCuenta.AutoSize = true;
            this.labelResNumCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResNumCuenta.Location = new System.Drawing.Point(197, 42);
            this.labelResNumCuenta.Name = "labelResNumCuenta";
            this.labelResNumCuenta.Size = new System.Drawing.Size(0, 18);
            this.labelResNumCuenta.TabIndex = 5;
            // 
            // labelResNombre
            // 
            this.labelResNombre.AutoSize = true;
            this.labelResNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResNombre.Location = new System.Drawing.Point(197, 75);
            this.labelResNombre.Name = "labelResNombre";
            this.labelResNombre.Size = new System.Drawing.Size(0, 18);
            this.labelResNombre.TabIndex = 6;
            this.labelResNombre.Click += new System.EventHandler(this.labelResNombre_Click);
            // 
            // labelResSaldo
            // 
            this.labelResSaldo.AutoSize = true;
            this.labelResSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResSaldo.Location = new System.Drawing.Point(197, 107);
            this.labelResSaldo.Name = "labelResSaldo";
            this.labelResSaldo.Size = new System.Drawing.Size(0, 18);
            this.labelResSaldo.TabIndex = 7;
            // 
            // labelResTipoInteres
            // 
            this.labelResTipoInteres.AutoSize = true;
            this.labelResTipoInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResTipoInteres.Location = new System.Drawing.Point(197, 142);
            this.labelResTipoInteres.Name = "labelResTipoInteres";
            this.labelResTipoInteres.Size = new System.Drawing.Size(0, 18);
            this.labelResTipoInteres.TabIndex = 8;
            // 
            // labelResCuotaMantenimiento
            // 
            this.labelResCuotaMantenimiento.AutoSize = true;
            this.labelResCuotaMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResCuotaMantenimiento.Location = new System.Drawing.Point(197, 173);
            this.labelResCuotaMantenimiento.Name = "labelResCuotaMantenimiento";
            this.labelResCuotaMantenimiento.Size = new System.Drawing.Size(0, 18);
            this.labelResCuotaMantenimiento.TabIndex = 9;
            // 
            // buttonAdelante
            // 
            this.buttonAdelante.Location = new System.Drawing.Point(143, 245);
            this.buttonAdelante.Name = "buttonAdelante";
            this.buttonAdelante.Size = new System.Drawing.Size(75, 23);
            this.buttonAdelante.TabIndex = 10;
            this.buttonAdelante.Text = "Adelante";
            this.buttonAdelante.UseVisualStyleBackColor = true;
            this.buttonAdelante.Click += new System.EventHandler(this.buttonAdelante_Click);
            // 
            // buttonAtras
            // 
            this.buttonAtras.Location = new System.Drawing.Point(47, 245);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(75, 23);
            this.buttonAtras.TabIndex = 11;
            this.buttonAtras.Text = "Atrás";
            this.buttonAtras.UseVisualStyleBackColor = true;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 287);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.buttonAdelante);
            this.Controls.Add(this.labelResCuotaMantenimiento);
            this.Controls.Add(this.labelResTipoInteres);
            this.Controls.Add(this.labelResSaldo);
            this.Controls.Add(this.labelResNombre);
            this.Controls.Add(this.labelResNumCuenta);
            this.Controls.Add(this.labelCuotaMantenimiento);
            this.Controls.Add(this.labelTipoInteres);
            this.Controls.Add(this.labelSaldo);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelNumCuenta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaPrincipal";
            this.Text = "Banco";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumCuenta;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Label labelTipoInteres;
        private System.Windows.Forms.Label labelCuotaMantenimiento;
        private System.Windows.Forms.Label labelResNumCuenta;
        private System.Windows.Forms.Label labelResNombre;
        private System.Windows.Forms.Label labelResSaldo;
        private System.Windows.Forms.Label labelResTipoInteres;
        private System.Windows.Forms.Label labelResCuotaMantenimiento;
        private System.Windows.Forms.Button buttonAdelante;
        private System.Windows.Forms.Button buttonAtras;
    }
}

