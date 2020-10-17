namespace CosteGastosDeEnvio
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
            this.checkedListBoxEnvio = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxNotificacion = new System.Windows.Forms.CheckedListBox();
            this.labelTipoDeEnvio = new System.Windows.Forms.Label();
            this.labelTipoDeNotificacion = new System.Windows.Forms.Label();
            this.botonRealizarPedido = new System.Windows.Forms.Button();
            this.labelPrecioDelEnvio = new System.Windows.Forms.Label();
            this.labelResultadoPrecioTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBoxEnvio
            // 
            this.checkedListBoxEnvio.CheckOnClick = true;
            this.checkedListBoxEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxEnvio.FormattingEnabled = true;
            this.checkedListBoxEnvio.Items.AddRange(new object[] {
            "Correo normal  +1,90€",
            "Paquetería normal  +2,99€",
            "Paquetería urgente  +4,99€"});
            this.checkedListBoxEnvio.Location = new System.Drawing.Point(40, 92);
            this.checkedListBoxEnvio.Name = "checkedListBoxEnvio";
            this.checkedListBoxEnvio.Size = new System.Drawing.Size(189, 55);
            this.checkedListBoxEnvio.TabIndex = 3;
            // 
            // checkedListBoxNotificacion
            // 
            this.checkedListBoxNotificacion.CheckOnClick = true;
            this.checkedListBoxNotificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxNotificacion.FormattingEnabled = true;
            this.checkedListBoxNotificacion.Items.AddRange(new object[] {
            "Email  +0,50€",
            "Teléfono  +0.70€",
            "Fax  +1.00€"});
            this.checkedListBoxNotificacion.Location = new System.Drawing.Point(283, 92);
            this.checkedListBoxNotificacion.Name = "checkedListBoxNotificacion";
            this.checkedListBoxNotificacion.Size = new System.Drawing.Size(157, 55);
            this.checkedListBoxNotificacion.TabIndex = 4;
            // 
            // labelTipoDeEnvio
            // 
            this.labelTipoDeEnvio.AutoSize = true;
            this.labelTipoDeEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoDeEnvio.Location = new System.Drawing.Point(36, 52);
            this.labelTipoDeEnvio.Name = "labelTipoDeEnvio";
            this.labelTipoDeEnvio.Size = new System.Drawing.Size(53, 20);
            this.labelTipoDeEnvio.TabIndex = 5;
            this.labelTipoDeEnvio.Text = "Envío";
            // 
            // labelTipoDeNotificacion
            // 
            this.labelTipoDeNotificacion.AutoSize = true;
            this.labelTipoDeNotificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoDeNotificacion.Location = new System.Drawing.Point(280, 52);
            this.labelTipoDeNotificacion.Name = "labelTipoDeNotificacion";
            this.labelTipoDeNotificacion.Size = new System.Drawing.Size(103, 20);
            this.labelTipoDeNotificacion.TabIndex = 6;
            this.labelTipoDeNotificacion.Text = "Notificación";
            this.labelTipoDeNotificacion.Click += new System.EventHandler(this.label2_Click);
            // 
            // botonRealizarPedido
            // 
            this.botonRealizarPedido.Location = new System.Drawing.Point(40, 225);
            this.botonRealizarPedido.Name = "botonRealizarPedido";
            this.botonRealizarPedido.Size = new System.Drawing.Size(112, 23);
            this.botonRealizarPedido.TabIndex = 7;
            this.botonRealizarPedido.Text = "Realizar pedido";
            this.botonRealizarPedido.UseVisualStyleBackColor = true;
            this.botonRealizarPedido.Click += new System.EventHandler(this.botonRealizarPedido_Click);
            // 
            // labelPrecioDelEnvio
            // 
            this.labelPrecioDelEnvio.AutoSize = true;
            this.labelPrecioDelEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioDelEnvio.Location = new System.Drawing.Point(37, 182);
            this.labelPrecioDelEnvio.Name = "labelPrecioDelEnvio";
            this.labelPrecioDelEnvio.Size = new System.Drawing.Size(84, 15);
            this.labelPrecioDelEnvio.TabIndex = 8;
            this.labelPrecioDelEnvio.Text = "Precio total:";
            // 
            // labelResultadoPrecioTotal
            // 
            this.labelResultadoPrecioTotal.AutoSize = true;
            this.labelResultadoPrecioTotal.Location = new System.Drawing.Point(127, 184);
            this.labelResultadoPrecioTotal.Name = "labelResultadoPrecioTotal";
            this.labelResultadoPrecioTotal.Size = new System.Drawing.Size(0, 13);
            this.labelResultadoPrecioTotal.TabIndex = 9;
            // 
            // VistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 270);
            this.Controls.Add(this.labelResultadoPrecioTotal);
            this.Controls.Add(this.labelPrecioDelEnvio);
            this.Controls.Add(this.botonRealizarPedido);
            this.Controls.Add(this.labelTipoDeNotificacion);
            this.Controls.Add(this.labelTipoDeEnvio);
            this.Controls.Add(this.checkedListBoxNotificacion);
            this.Controls.Add(this.checkedListBoxEnvio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurador paquetería";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxEnvio;
        private System.Windows.Forms.CheckedListBox checkedListBoxNotificacion;
        private System.Windows.Forms.Label labelTipoDeEnvio;
        private System.Windows.Forms.Label labelTipoDeNotificacion;
        private System.Windows.Forms.Button botonRealizarPedido;
        private System.Windows.Forms.Label labelPrecioDelEnvio;
        private System.Windows.Forms.Label labelResultadoPrecioTotal;
    }
}

