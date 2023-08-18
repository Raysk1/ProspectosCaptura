
using System;
using System.Windows.Forms;

namespace CapturaDeProspectos
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btCapturar_Click(object sender, EventArgs e)
        {
            var form = this.Tag as FormPrincipal;
            form.AbrirForm(new FormCaptura());
        }

        private void btListado_Click(object sender, EventArgs e)
        {
            var form = this.Tag as FormPrincipal;
            form.AbrirForm(new FormListado());
        }
    }
}
