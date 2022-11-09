using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPozzoEJxResolver
{
    public partial class frmInicio : Form
    {
        public struct structIngresos
        {
            public string varMarca;
            public string varOrigen;
            public int varNroRepuesto;
            public string varDescripcion;
            public float varPrecio;
        }

        structIngresos[] vecIngresos = new structIngresos[100];
        public int varIndice;
        public int varIndice2;

        public frmInicio()
        {
            InitializeComponent();
        }

        private void lstMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMarca.SelectedIndex != -1)
            {
                lstOrigen.Enabled = true;
            }
            else
            {
                lstOrigen.Enabled = false;
            }
        }

        private void lstOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

            {
                if (lstOrigen.SelectedIndex != -1)
                {
                    txtNroRepuesto.Enabled = true;
                }
                else
                {
                    txtNroRepuesto.Enabled = false;
                }
            }

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != "")
            {
                txtPrecio.Enabled = true;
            }
            else
            {
                txtPrecio.Enabled = false;
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecio.Text != "")
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }

        private void txtNroRepuesto_TextChanged(object sender, EventArgs e)
        {

            if (txtNroRepuesto.Text != "")
            {
                txtDescripcion.Enabled = true;
            }
            else
            {
                txtDescripcion.Enabled = false;
            }

        }

        private void txtNroRepuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && !char.IsControl(e.KeyChar)) // se borrarán las teclas fuera del rango '0' al '9' menos todos las teclas que sean controles.
            {
                e.Handled = true; // borrar la tecla ingresada
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && !char.IsControl(e.KeyChar)) // se borrarán las teclas fuera del rango '0' al '9' menos todos las teclas que sean controles.
            {
                e.Handled = true; // borrar la tecla ingresada
            }
        }


        private void limpiarControles()
        {
            lstOrigen.SelectedIndex = -1;
            lstMarca.SelectedIndex = -1;
            txtNroRepuesto.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (btnRegistrar.Enabled)
            {
                btnConsultar.Enabled = true;
            }
            else
            {
                btnConsultar.Enabled = false;
            }
            vecIngresos[varIndice].varMarca = lstMarca.Text;
            vecIngresos[varIndice].varOrigen = lstOrigen.Text;
            vecIngresos[varIndice].varNroRepuesto = int.Parse(txtNroRepuesto.Text);
            vecIngresos[varIndice].varDescripcion = txtDescripcion.Text;
            vecIngresos[varIndice].varPrecio = int.Parse(txtPrecio.Text);
            varIndice++;
            limpiarControles();

            varIndice = 0;
            bool existeRepuesto = false;
            while (varIndice < vecIngresos.Length)
            {
                if (vecIngresos[varIndice].varNroRepuesto == int.Parse(txtNroRepuesto.Text))
                {
                    existeRepuesto = true;
                    MessageBox.Show("El Numero de repuesto ingresado ya es existente");
                    btnRegistrar.Enabled = false;
                }
                else
                {
                    existeRepuesto = false;

                }
                varIndice++;
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            lisDatos.Items.Clear();
            varIndice2 = 0;
            while (varIndice2 < vecIngresos.Length)
            {
                if (vecIngresos[varIndice2].varMarca == lstMarcaConsulta.Text)
                {

                    if (optNacional.Checked == true && vecIngresos[varIndice2].varOrigen == "Nacional")
                    {
                        lisDatos.Items.Add("Nro Repuesto: " + vecIngresos[varIndice2].varNroRepuesto);
                        lisDatos.Items.Add("Descripcion: " + vecIngresos[varIndice2].varDescripcion);
                        lisDatos.Items.Add("Precio: $" + vecIngresos[varIndice2].varPrecio);
                    }
                    else
                    {
                        lisDatos.Items.Add("Nro Repuesto: " + vecIngresos[varIndice2].varNroRepuesto);
                        lisDatos.Items.Add("Descripcion: " + vecIngresos[varIndice2].varDescripcion);
                        lisDatos.Items.Add("Precio: $" + vecIngresos[varIndice2].varPrecio);
                    }
                }
                varIndice2++;
            }
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
