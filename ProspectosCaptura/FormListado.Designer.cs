namespace CapturaDeProspectos
{
    partial class FormListado
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
            this.flpContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpContainer
            // 
            this.flpContainer.AutoScroll = true;
            this.flpContainer.AutoSize = true;
            this.flpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpContainer.Location = new System.Drawing.Point(0, 0);
            this.flpContainer.Name = "flpContainer";
            this.flpContainer.Size = new System.Drawing.Size(800, 450);
            this.flpContainer.TabIndex = 0;
            // 
            // btSalir
            // 
            this.btSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(0, 427);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(800, 23);
            this.btSalir.TabIndex = 1;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // FormListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.flpContainer);
            this.Name = "FormListado";
            this.Text = "FormListado";
            this.Load += new System.EventHandler(this.FormListado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpContainer;
        private System.Windows.Forms.Button btSalir;
    }
}