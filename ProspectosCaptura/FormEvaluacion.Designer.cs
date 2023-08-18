namespace CapturaDeProspectos
{
    partial class FormEvaluacion
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
            this.btAceptar = new System.Windows.Forms.Button();
            this.btRechazar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(703, 106);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 28;
            this.btAceptar.Text = "Autorizar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btRechazar
            // 
            this.btRechazar.Location = new System.Drawing.Point(703, 154);
            this.btRechazar.Name = "btRechazar";
            this.btRechazar.Size = new System.Drawing.Size(75, 23);
            this.btRechazar.TabIndex = 29;
            this.btRechazar.Text = "Rechazar";
            this.btRechazar.UseVisualStyleBackColor = true;
            this.btRechazar.Click += new System.EventHandler(this.btRechazar_Click);
            // 
            // FormEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.btRechazar);
            this.Controls.Add(this.btAceptar);
            this.Name = "FormEvaluacion";
            this.Controls.SetChildIndex(this.btAceptar, 0);
            this.Controls.SetChildIndex(this.btRechazar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btRechazar;
    }
}
