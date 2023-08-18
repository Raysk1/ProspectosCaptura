using CapturaDeProspectos.Controllers;
using CapturaDeProspectos.Models;
using System;
using System.Windows.Forms;

namespace CapturaDeProspectos
{
    public partial class FormEvaluacion : CapturaDeProspectos.FormInfo
    {
        public FormEvaluacion(Prospecto prospecto) : base(prospecto)
        {
            InitializeComponent();
            tbObservaciones.Visible = true;
            lbObservaciones.Visible = true;
            tbObservaciones.ReadOnly = false;
            lbTitle.Text = "Evaluacion del prospecto";
        }

        public FormEvaluacion() : base()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            prospecto.Status = "Autorizado";
            ProspectoController.Update(prospecto);
            lbStatus.Text = prospecto.Status;
            btAceptar.Enabled = false;
            btRechazar.Enabled = false;
            tbObservaciones.Enabled = false;
        }

        private void btRechazar_Click(object sender, EventArgs e)
        {
            if (tbObservaciones.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debe agregar las observaciones");
                return;
            }
            prospecto.Status = "Rechazado";
            prospecto.Observaciones = tbObservaciones.Text;
            ProspectoController.Update(prospecto);
            lbStatus.Text = prospecto.Status;
            btAceptar.Enabled = false;
            btRechazar.Enabled = false;
            tbObservaciones.Enabled = false;
        }
    }
}
