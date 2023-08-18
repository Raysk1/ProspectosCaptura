namespace CapturaDeProspectos
{
    partial class FormMenu
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
            btCapturar = new Button();
            btListado = new Button();
            SuspendLayout();
            // 
            // btCapturar
            // 
            btCapturar.BackgroundImage = ProspectosCaptura.Properties.Resources.nuevo_usuario;
            btCapturar.BackgroundImageLayout = ImageLayout.Zoom;
            btCapturar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btCapturar.Location = new Point(396, 14);
            btCapturar.Margin = new Padding(4, 3, 4, 3);
            btCapturar.Name = "btCapturar";
            btCapturar.Size = new Size(160, 209);
            btCapturar.TabIndex = 0;
            btCapturar.Text = "Capturar";
            btCapturar.TextAlign = ContentAlignment.BottomCenter;
            btCapturar.UseVisualStyleBackColor = true;
            btCapturar.Click += btCapturar_Click;
            // 
            // btListado
            // 
            btListado.BackgroundImage = ProspectosCaptura.Properties.Resources.cliente;
            btListado.BackgroundImageLayout = ImageLayout.Zoom;
            btListado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btListado.Location = new Point(396, 246);
            btListado.Margin = new Padding(4, 3, 4, 3);
            btListado.Name = "btListado";
            btListado.Size = new Size(160, 213);
            btListado.TabIndex = 1;
            btListado.Text = "Listado";
            btListado.TextAlign = ContentAlignment.BottomCenter;
            btListado.UseVisualStyleBackColor = true;
            btListado.Click += btListado_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(btListado);
            Controls.Add(btCapturar);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMenu";
            Text = "FormMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btCapturar;
        private Button btListado;
    }
}