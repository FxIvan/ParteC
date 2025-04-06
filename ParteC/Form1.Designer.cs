namespace ParteC
{
    partial class btnTipoDeFecha
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnOperacionsFecha = new System.Windows.Forms.Button();
            this.btnOperacionesConFecha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "Tipos de fecha";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOperacionsFecha
            // 
            this.btnOperacionsFecha.Location = new System.Drawing.Point(12, 77);
            this.btnOperacionsFecha.Name = "btnOperacionsFecha";
            this.btnOperacionsFecha.Size = new System.Drawing.Size(189, 31);
            this.btnOperacionsFecha.TabIndex = 15;
            this.btnOperacionsFecha.Text = "Operacions Fecha";
            this.btnOperacionsFecha.UseVisualStyleBackColor = true;
            this.btnOperacionsFecha.Click += new System.EventHandler(this.btnOperacionsFecha_Click);
            // 
            // btnOperacionesConFecha
            // 
            this.btnOperacionesConFecha.Location = new System.Drawing.Point(12, 146);
            this.btnOperacionesConFecha.Name = "btnOperacionesConFecha";
            this.btnOperacionesConFecha.Size = new System.Drawing.Size(189, 31);
            this.btnOperacionesConFecha.TabIndex = 16;
            this.btnOperacionesConFecha.Text = "Operacions con Fecha";
            this.btnOperacionesConFecha.UseVisualStyleBackColor = true;
            this.btnOperacionesConFecha.Click += new System.EventHandler(this.btnOperacionesConFecha_Click);
            // 
            // btnTipoDeFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 208);
            this.Controls.Add(this.btnOperacionesConFecha);
            this.Controls.Add(this.btnOperacionsFecha);
            this.Controls.Add(this.button1);
            this.Name = "btnTipoDeFecha";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOperacionsFecha;
        private System.Windows.Forms.Button btnOperacionesConFecha;
    }
}

