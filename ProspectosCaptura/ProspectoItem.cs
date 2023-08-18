using CapturaDeProspectos.Models;
using System;
using System.Windows.Forms;

namespace CapturaDeProspectos
{
    public partial class ProspectoItem : UserControl
    {
        private Prospecto prospecto;
        public ProspectoItem(Prospecto prospecto)
        {
            InitializeComponent();
            this.prospecto = prospecto;
            this.lbNombre.Text = $"{prospecto.Nombre} {prospecto.ApellidoPaterno} {prospecto.ApellidoMaterno}";
            this.lbStatus.Text = prospecto.Status;
            if (prospecto.Status != "Enviado")
            {
                flpBtContainer.Controls.Remove(this.btEvaluar);
            }
        }

        private void btInfo_Click(object sender, EventArgs e)
        {
            var parent = this.Tag as Form;
            var principal = parent.Tag as FormPrincipal;
            principal.AbrirForm(new FormInfo(prospecto) { Tag = principal });
            parent.Close();

        }

        private void btEvaluar_Click(object sender, EventArgs e)
        {
            var parent = this.Tag as Form;
            var principal = parent.Tag as FormPrincipal;
            principal.AbrirForm(new FormEvaluacion(prospecto) { Tag = principal });
            parent.Close();
        }
    }
}
