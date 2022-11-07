using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            public decimal varPrecio;
        }
        
        structIngresos[] vecIngresos = new structIngresos[100];
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

        private void frmInicio_Load(object sender, EventArgs e)
        {

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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            vecIngresos[varIndice].varMarca = txtDatosRepuestos.Text;

        }
    }
}
