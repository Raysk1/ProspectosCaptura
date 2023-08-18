using CapturaDeProspectos.Controllers;
using System;
using System.Windows.Forms;

namespace CapturaDeProspectos
{
    public partial class FormListado : Form
    {
        public FormListado()
        {
            InitializeComponent();
        }

        private void LlenarContainer()
        {

            foreach (var prospecto in ProspectoController.All())
            {
                var item = new ProspectoItem(prospecto)
                {
                    Tag = this
                };
                flpContainer.Controls.Add(item);
            }

        }

        private void FormListado_Load(object sender, EventArgs e)
        {
            LlenarContainer();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            var parent = this.Tag as FormPrincipal;
            parent.AbrirForm(new FormMenu());
            this.Close();
        }
    }

}
