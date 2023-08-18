using CapturaDeProspectos.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CapturaDeProspectos
{

    public partial class FormInfo : Form
    {
        string[] archivosRuta;

        protected Prospecto prospecto;
        public FormInfo(Prospecto prospecto)
        {
            InitializeComponent();
            this.prospecto = prospecto;
            LlenarDatos();

        }

        public FormInfo()
        {
            InitializeComponent();
        }

        private void LlenarDatos()
        {
            lbNombre.Text = prospecto.Nombre;
            lbApPaterno.Text = prospecto.ApellidoPaterno;
            lbApMaterno.Text = prospecto.ApellidoMaterno;
            lbCalle.Text = prospecto.Calle;
            lbColonia.Text = prospecto.Colonia;
            lbCP.Text = prospecto.CP;
            lbNumero.Text = prospecto.Numero.ToString();
            lbRFC.Text = prospecto.RFC;
            lbStatus.Text = prospecto.Status;
            lbTelefono.Text = prospecto.Telefono;
            CargarDocumentos();

            if (this.prospecto.Status == "Rechazado")
            {
                tbObservaciones.Enabled = false;
                tbObservaciones.Text = prospecto.Observaciones;
            }
            else
            {
                tbObservaciones.Visible = false;
                lbObservaciones.Visible = false;
            }
        }


        //carga las rutas de los documentos correspodientes al prospecto
        private void CargarDocumentos()
        {
            List<String> archivosNombre = new List<String>();
            string ruta = Path.Combine(Environment.CurrentDirectory, "Prospectos", prospecto.Id.ToString());
            if (!Directory.Exists(ruta))
            {
                return;
            }
            archivosRuta = Directory.GetFiles(ruta);
            foreach (string archivo in archivosRuta)
            {
                archivosNombre.Add(Path.GetFileName(archivo));
            }

            this.lbDocumentos.Items.AddRange(archivosNombre.ToArray());

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            var parent = this.Tag as FormPrincipal;
            parent.AbrirForm(new FormListado());
            this.Close();
        }


        private void lbDocumentos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = lbDocumentos.IndexFromPoint(e.Location);
            if (selectedIndex != ListBox.NoMatches)
            {
                // Se capturó un doble clic en un elemento
                //Abre el documento seleccionado
                Process.Start(new ProcessStartInfo { FileName = archivosRuta[selectedIndex], UseShellExecute = true});
            }
        }
    }
}
