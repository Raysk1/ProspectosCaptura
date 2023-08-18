using CapturaDeProspectos.Controllers;
using CapturaDeProspectos.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CapturaDeProspectos
{
    public partial class FormCaptura : Form
    {
        private List<String> archivosRuta = new List<String>();
        private List<String> archivosNombre = new List<String>();

        public FormCaptura()
        {
            InitializeComponent();
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {

            if (!ValidarTextBoxes())
            {
                MessageBox.Show("Debe llenar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var prospecto = new Prospecto
            {
                Nombre = this.tbNombre.Text,
                ApellidoPaterno = this.tbApPaterno.Text,
                ApellidoMaterno = this.tbApMaterno.Text,
                Colonia = this.tbColonia.Text,
                Numero = Convert.ToInt32(this.tbNumero.Text),
                RFC = this.tbRFC.Text,
                Telefono = this.tbTelefono.Text,
                Calle = this.tbCalle.Text,
                CP = this.tbCP.Text,
                Status = "Enviado"
            };
            ProspectoController.Insert(prospecto);

            //copia los archivos a un directorio con el nombre del ID del prospecto
            foreach (string ruta in archivosRuta)
            {
                string nombreArchivo = Path.GetFileName(ruta);
                string rutaDestino = Path.Combine(Environment.CurrentDirectory, "Prospectos", prospecto.Id.ToString());
                if (!Directory.Exists(rutaDestino))
                {
                    Directory.CreateDirectory(rutaDestino);
                }
                rutaDestino = Path.Combine(rutaDestino, nombreArchivo);

                try
                {
                    File.Copy(ruta, rutaDestino);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al copiar el archivo: " + ex.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            VaciarTextBoxes();
            VaciarDocumentos();
            MessageBox.Show("Se ha guardado con exito");

        }

        private void VaciarDocumentos()
        {
            lbDocumentos.Items.Clear();
            archivosNombre.Clear();
            archivosRuta.Clear();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Al salir de esta pantalla todos los datos capturados seran eliminados", "¿Esta seguro de salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                var parent = this.Tag as FormPrincipal;
                parent.AbrirForm(new FormMenu());
                this.Close();
            }
        }

        private void btAñadir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true; // Permitir selección múltiple

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                archivosNombre.AddRange(openFileDialog.SafeFileNames);
                archivosRuta.AddRange(openFileDialog.FileNames);
                ActualizarListaArchivos();
            }
        }

        private bool ValidarTextBoxes()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox textBox)
                {
                    if (textBox.Text.Trim() == String.Empty && textBox != this.tbApMaterno)
                    {
                        return false;
                    }
                }

            }
            return true;
        }

        //Actualiza el listView con los nombres de los archivos
        private void ActualizarListaArchivos()
        {
            this.lbDocumentos.Items.Clear();
            lbDocumentos.Items.AddRange(archivosNombre.ToArray());
        }

        private void VaciarTextBoxes()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox textBox)
                {
                    textBox.Text = string.Empty; // Vaciar el TextBox
                }

            }
        }

        private void textBoxNumerosYLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número, letra o tecla especial de edición
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquear la tecla si no es un número, letra o tecla especial
            }
        }

        private void textBoxLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es una letra o tecla especial de edición
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Bloquear la tecla si no es una letra o tecla especial
            }
        }

        private void textBoxNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o teclas especiales de edición
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquear la tecla si no es un número o tecla especial
            }
        }

        private void lbDocumentos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = lbDocumentos.IndexFromPoint(e.Location);
            if (selectedIndex != ListBox.NoMatches)
            {
                // Se capturó un doble clic en un elemento
                //Abre el documento seleccionado
                Process.Start(new ProcessStartInfo { FileName = archivosRuta[selectedIndex], UseShellExecute = true });

            }
        }
    }
}
