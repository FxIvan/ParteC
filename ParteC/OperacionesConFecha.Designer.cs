namespace ParteC
{
    partial class OperacionesConFecha
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdias = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Resultado";
            // 
            // txtdias
            // 
            this.txtdias.Location = new System.Drawing.Point(112, 85);
            this.txtdias.Name = "txtdias";
            this.txtdias.Size = new System.Drawing.Size(209, 20);
            this.txtdias.TabIndex = 4;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(112, 127);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(209, 20);
            this.txtresultado.TabIndex = 5;
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(26, 199);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(123, 22);
            this.btnSumar.TabIndex = 6;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(198, 199);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(123, 22);
            this.btnRestar.TabIndex = 7;
            this.btnRestar.Text = "Restar";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(103, 239);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 22);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // OperacionesConFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 291);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtdias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "OperacionesConFecha";
            this.Text = "OperacionesConFecha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdias;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnSalir;
    }
}