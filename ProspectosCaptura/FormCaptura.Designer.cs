namespace CapturaDeProspectos
{
    partial class FormCaptura
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
            label1 = new Label();
            tbNombre = new TextBox();
            label2 = new Label();
            tbApPaterno = new TextBox();
            label3 = new Label();
            tbCalle = new TextBox();
            label4 = new Label();
            tbNumero = new TextBox();
            label5 = new Label();
            tbRFC = new TextBox();
            label6 = new Label();
            tbTelefono = new TextBox();
            label7 = new Label();
            tbCP = new TextBox();
            label8 = new Label();
            tbColonia = new TextBox();
            label9 = new Label();
            tbApMaterno = new TextBox();
            label10 = new Label();
            label11 = new Label();
            lbDocumentos = new ListBox();
            btEnviar = new Button();
            btSalir = new Button();
            btAñadir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(54, 80);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // tbNombre
            // 
            tbNombre.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbNombre.Location = new Point(54, 103);
            tbNombre.Margin = new Padding(4, 3, 4, 3);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(193, 29);
            tbNombre.TabIndex = 1;
            tbNombre.KeyPress += textBoxLetras_KeyPress;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(933, 43);
            label2.TabIndex = 2;
            label2.Text = "Captura de prospecto";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbApPaterno
            // 
            tbApPaterno.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbApPaterno.Location = new Point(315, 103);
            tbApPaterno.Margin = new Padding(4, 3, 4, 3);
            tbApPaterno.Name = "tbApPaterno";
            tbApPaterno.Size = new Size(193, 29);
            tbApPaterno.TabIndex = 4;
            tbApPaterno.KeyPress += textBoxLetras_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(315, 80);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 17);
            label3.TabIndex = 3;
            label3.Text = "Apellido Paterno:";
            // 
            // tbCalle
            // 
            tbCalle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbCalle.Location = new Point(54, 174);
            tbCalle.Margin = new Padding(4, 3, 4, 3);
            tbCalle.Name = "tbCalle";
            tbCalle.Size = new Size(193, 29);
            tbCalle.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(54, 151);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(43, 17);
            label4.TabIndex = 5;
            label4.Text = "Calle:";
            // 
            // tbNumero
            // 
            tbNumero.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbNumero.Location = new Point(315, 174);
            tbNumero.Margin = new Padding(4, 3, 4, 3);
            tbNumero.Name = "tbNumero";
            tbNumero.Size = new Size(193, 29);
            tbNumero.TabIndex = 8;
            tbNumero.KeyPress += textBoxNumeros_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(315, 151);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 7;
            label5.Text = "Numero:";
            // 
            // tbRFC
            // 
            tbRFC.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbRFC.Location = new Point(315, 318);
            tbRFC.Margin = new Padding(4, 3, 4, 3);
            tbRFC.MaxLength = 13;
            tbRFC.Name = "tbRFC";
            tbRFC.Size = new Size(193, 29);
            tbRFC.TabIndex = 16;
            tbRFC.KeyPress += textBoxNumerosYLetras_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(315, 295);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(39, 17);
            label6.TabIndex = 15;
            label6.Text = "RFC:";
            // 
            // tbTelefono
            // 
            tbTelefono.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbTelefono.Location = new Point(54, 318);
            tbTelefono.Margin = new Padding(4, 3, 4, 3);
            tbTelefono.MaxLength = 10;
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(193, 29);
            tbTelefono.TabIndex = 14;
            tbTelefono.KeyPress += textBoxNumeros_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(54, 295);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(68, 17);
            label7.TabIndex = 13;
            label7.Text = "Telefono:";
            // 
            // tbCP
            // 
            tbCP.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbCP.Location = new Point(315, 247);
            tbCP.Margin = new Padding(4, 3, 4, 3);
            tbCP.MaxLength = 5;
            tbCP.Name = "tbCP";
            tbCP.Size = new Size(193, 29);
            tbCP.TabIndex = 12;
            tbCP.KeyPress += textBoxNumeros_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(315, 224);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(99, 17);
            label8.TabIndex = 11;
            label8.Text = "Codigo Postal:";
            // 
            // tbColonia
            // 
            tbColonia.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbColonia.Location = new Point(54, 247);
            tbColonia.Margin = new Padding(4, 3, 4, 3);
            tbColonia.Name = "tbColonia";
            tbColonia.Size = new Size(193, 29);
            tbColonia.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(54, 224);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(59, 17);
            label9.TabIndex = 9;
            label9.Text = "Colonia:";
            // 
            // tbApMaterno
            // 
            tbApMaterno.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbApMaterno.Location = new Point(561, 103);
            tbApMaterno.Margin = new Padding(4, 3, 4, 3);
            tbApMaterno.Name = "tbApMaterno";
            tbApMaterno.Size = new Size(193, 29);
            tbApMaterno.TabIndex = 18;
            tbApMaterno.KeyPress += textBoxLetras_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(561, 80);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(118, 17);
            label10.TabIndex = 17;
            label10.Text = "Apellido Materno:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(561, 151);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(91, 17);
            label11.TabIndex = 19;
            label11.Text = "Documentos:";
            // 
            // lbDocumentos
            // 
            lbDocumentos.FormattingEnabled = true;
            lbDocumentos.ItemHeight = 15;
            lbDocumentos.Location = new Point(561, 174);
            lbDocumentos.Margin = new Padding(4, 3, 4, 3);
            lbDocumentos.Name = "lbDocumentos";
            lbDocumentos.Size = new Size(193, 184);
            lbDocumentos.TabIndex = 20;
            lbDocumentos.MouseDoubleClick += lbDocumentos_MouseDoubleClick;
            // 
            // btEnviar
            // 
            btEnviar.Location = new Point(817, 103);
            btEnviar.Margin = new Padding(4, 3, 4, 3);
            btEnviar.Name = "btEnviar";
            btEnviar.Size = new Size(88, 27);
            btEnviar.TabIndex = 21;
            btEnviar.Text = "Enviar";
            btEnviar.UseVisualStyleBackColor = true;
            btEnviar.Click += btEnviar_Click;
            // 
            // btSalir
            // 
            btSalir.Location = new Point(817, 136);
            btSalir.Margin = new Padding(4, 3, 4, 3);
            btSalir.Name = "btSalir";
            btSalir.Size = new Size(88, 27);
            btSalir.TabIndex = 22;
            btSalir.Text = "Salir";
            btSalir.UseVisualStyleBackColor = true;
            btSalir.Click += btSalir_Click;
            // 
            // btAñadir
            // 
            btAñadir.BackgroundImage = ProspectosCaptura.Properties.Resources.boton_mas;
            btAñadir.BackgroundImageLayout = ImageLayout.Stretch;
            btAñadir.Location = new Point(722, 148);
            btAñadir.Margin = new Padding(4, 3, 4, 3);
            btAñadir.Name = "btAñadir";
            btAñadir.Size = new Size(33, 27);
            btAñadir.TabIndex = 23;
            btAñadir.UseVisualStyleBackColor = true;
            btAñadir.Click += btAñadir_Click;
            // 
            // FormCaptura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(btAñadir);
            Controls.Add(btSalir);
            Controls.Add(btEnviar);
            Controls.Add(lbDocumentos);
            Controls.Add(label11);
            Controls.Add(tbApMaterno);
            Controls.Add(label10);
            Controls.Add(tbRFC);
            Controls.Add(label6);
            Controls.Add(tbTelefono);
            Controls.Add(label7);
            Controls.Add(tbCP);
            Controls.Add(label8);
            Controls.Add(tbColonia);
            Controls.Add(label9);
            Controls.Add(tbNumero);
            Controls.Add(label5);
            Controls.Add(tbCalle);
            Controls.Add(label4);
            Controls.Add(tbApPaterno);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbNombre);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormCaptura";
            Text = "FormCaptura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbNombre;
        private Label label2;
        private TextBox tbApPaterno;
        private Label label3;
        private TextBox tbCalle;
        private Label label4;
        private TextBox tbNumero;
        private Label label5;
        private TextBox tbRFC;
        private Label label6;
        private TextBox tbTelefono;
        private Label label7;
        private TextBox tbCP;
        private Label label8;
        private TextBox tbColonia;
        private Label label9;
        private TextBox tbApMaterno;
        private Label label10;
        private Label label11;
        private ListBox lbDocumentos;
        private Button btEnviar;
        private Button btSalir;
        private Button btAñadir;
    }
}