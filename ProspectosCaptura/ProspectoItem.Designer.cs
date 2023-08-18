namespace CapturaDeProspectos
{
    partial class ProspectoItem
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.flpBtContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btEvaluar = new System.Windows.Forms.Button();
            this.btInfo = new System.Windows.Forms.Button();
            this.flpBtContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(3, 50);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(0, 26);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(311, 50);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 26);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpBtContainer
            // 
            this.flpBtContainer.AutoSize = true;
            this.flpBtContainer.Controls.Add(this.btEvaluar);
            this.flpBtContainer.Controls.Add(this.btInfo);
            this.flpBtContainer.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flpBtContainer.Location = new System.Drawing.Point(576, 17);
            this.flpBtContainer.Name = "flpBtContainer";
            this.flpBtContainer.Size = new System.Drawing.Size(240, 80);
            this.flpBtContainer.TabIndex = 5;
            // 
            // btEvaluar
            // 
            this.btEvaluar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btEvaluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEvaluar.Location = new System.Drawing.Point(3, 43);
            this.btEvaluar.Name = "btEvaluar";
            this.btEvaluar.Size = new System.Drawing.Size(153, 34);
            this.btEvaluar.TabIndex = 5;
            this.btEvaluar.Text = "Evaluar";
            this.btEvaluar.UseVisualStyleBackColor = true;
            this.btEvaluar.Click += new System.EventHandler(this.btEvaluar_Click);
            // 
            // btInfo
            // 
            this.btInfo.AutoSize = true;
            this.btInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInfo.Location = new System.Drawing.Point(3, 3);
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(153, 34);
            this.btInfo.TabIndex = 4;
            this.btInfo.Text = "Ver informacion";
            this.btInfo.UseVisualStyleBackColor = true;
            this.btInfo.Click += new System.EventHandler(this.btInfo_Click);
            // 
            // ProspectoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.flpBtContainer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNombre);
            this.Name = "ProspectoItem";
            this.Size = new System.Drawing.Size(790, 100);
            this.flpBtContainer.ResumeLayout(false);
            this.flpBtContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.FlowLayoutPanel flpBtContainer;
        private System.Windows.Forms.Button btEvaluar;
        private System.Windows.Forms.Button btInfo;
    }
}
