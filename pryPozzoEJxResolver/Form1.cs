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
    //Consultar sobre los bool, como ver el vector cargado

    public partial class frmInicio : Form
    {
        public struct structIngresos
        {
            public string varMarca;
            public string varOrigen;
            public int varNroRepuesto;
            public string varDescripcion;
            public int varPrecio;
        }

        structIngresos[] vecIngresos = new structIngresos[10];
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
            txtNroRepuesto.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
        }

        private bool validarDatos()
        {
            bool resultado = false;
            if (lstMarca.SelectedIndex != -1 && lstOrigen.SelectedIndex != -1 && txtNroRepuesto.Text != "" && txtDescripcion.Text != "" && txtPrecio.Text != "")
            {
                if (txtNroRepuesto.MaxLength < 6)
                {
                    MessageBox.Show("Ingrese bien el Numero de Repuesto");
                    resultado = false;
                }
                resultado = true;
            }
            else
            {
                MessageBox.Show("Datos mal ingresados");
            }
            return resultado;
        }

        private bool RepuestoRepetido(int numero)
        {
            bool repetido = false;
            int varIndice1 = 1;
            while (varIndice <= 100)
            {
                if (vecIngresos[varIndice].varNroRepuesto == vecIngresos[varIndice].varNroRepuesto)
                {
                    MessageBox.Show("Ya se ha registrado un Repuesto con ese numero");
                    repetido = true;

                }
                varIndice++;
                varIndice1++;
            }
            return repetido;
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            vecIngresos[varIndice].varMarca = txtDatosRepuestos.Text + "/";
            vecIngresos[varIndice].varOrigen = txtDatosRepuestos.Text + "/";
            vecIngresos[varIndice].varNroRepuesto = int.Parse(txtNroRepuesto.Text);
            vecIngresos[varIndice].varDescripcion = txtDatosRepuestos.Text + "/";
            //vecIngresos[varIndice].varPrecio = int.Parse(txtDatosRepuestos.Text);
            varIndice++;
            if (varIndice == 100)
            {
                MessageBox.Show("Se ha completado el Numero de Registros");
                btnRegistrar.Enabled = false;
            }
            limpiarControles();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            varIndice = 0;
            while (varIndice <= 100)
            {
                vecIngresos[varIndice] 
                varIndice++;

            }
        }
    }
}
