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

        structIngresos[] vecIngresos = new structIngresos[3];
        public int varIndice;
      
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
            lstOrigen.Items.Clear();
            lstMarca.Items.Clear(); 
            txtNroRepuesto.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int varIndice = 0;
            int varIndice2 = 0;
            if (btnRegistrar.Enabled)
            {
                btnConsultar.Enabled = true;
            }
            else
            {
                btnConsultar.Enabled = false;
            }

            while (varIndice <= vecIngresos.Length)      
            {
                if (vecIngresos[varIndice].varNroRepuesto == vecIngresos[varIndice + 1].varNroRepuesto)
                {
                    MessageBox.Show("CACA");
                }
                vecIngresos[varIndice].varMarca = lstMarca.Text;
                vecIngresos[varIndice].varOrigen = lstOrigen.Text;
                vecIngresos[varIndice].varNroRepuesto = int.Parse(txtNroRepuesto.Text);
                vecIngresos[varIndice].varDescripcion = txtDescripcion.Text;
                vecIngresos[varIndice].varPrecio = int.Parse(txtPrecio.Text);
                varIndice++;
                varIndice2++;
            }
            if (varIndice == 10)
            {
                btnRegistrar.Enabled = false;
            }

            while (varIndice2 <= 4)
            {

            }
                
                
            


            limpiarControles();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            lisDatos.Items.Clear();
            varIndice = 0;
            while (varIndice < vecIngresos.Length)
            {
                lisDatos.Items.Add(vecIngresos[varIndice]);
                varIndice++;
            }
        }
    }
}
