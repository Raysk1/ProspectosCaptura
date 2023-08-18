using System.Windows.Forms;

namespace CapturaDeProspectos
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            AbrirForm(new FormMenu());
        }

        //Funcion que cambia de Form en la pantalla principal
        public void AbrirForm(Form form)
        {

            if (this.contenedor.Controls.Count > 0)
            {
                this.contenedor.Controls.RemoveAt(0);
            }

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.contenedor.Controls.Add(form);
            form.Tag = this;
            form.Show();
        }
    }
}
