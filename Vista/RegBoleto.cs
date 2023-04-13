using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class RegBoleto : Form
    {
        DatosAerouned enlaceDB;
        List<Cliente> clientes;
        List<Vuelo> vuelos;
        public RegBoleto()
        {
            InitializeComponent();
            enlaceDB = new DatosAerouned();
            clientes = enlaceDB.ConsultarClientes();
            vuelos = enlaceDB.ConsultarVuelos();
            initComboBox();
        }

        private void initComboBox()
        {
            try
            {
                foreach (Cliente cliente in clientes)
                {
                    cmbCBCliente.Items.Add(cliente.id + "-" + cliente.nombre);
                }
                foreach (Vuelo vuelo in vuelos)
                {
                    cmbCBVuelo.Items.Add(vuelo.id.ToString() + "-" + vuelo.origen.nombre + "-" + vuelo.destino.nombre);
                }
            }
            catch (Exception)
            {
                // Do nothing
            }
        }

        private void txtCBNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Se chequea que lo ingresado en el ID solo sean numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCBCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GuardarBoleto()
        {
            // Primero se revisan los campos en blanco
            if (txtCBNumero.Text.Equals("") || cmbCBVuelo.Text.Equals("") || cmbCBCliente.Equals(""))
            {
                MessageBox.Show("¡Debe llenar todos los campos!");
            }
            else
            {
                List<Boleto> boletos = enlaceDB.ConsultarBoletos();
                if (boletos.Count == 0)
                {
                    Vuelo vueloA = vuelos[cmbCBVuelo.SelectedIndex];
                    Cliente clientA = clientes[cmbCBCliente.SelectedIndex];
                    Boleto boleto = new Boleto 
                    {
                        numero = int.Parse(txtCBNumero.Text),
                        vuelo = vueloA,
                        fecha = dtpCBFecha.Value,
                        cliente = clientA,
                        asientos = Decimal.ToInt32(numCBAsientos.Value)
                    }; 
                    enlaceDB.AgregarBoleto(boleto);
                    MessageBox.Show("¡Guardado Correctamente!");
                    LimpiarCuadrosTexto();
                }
                else
                {
                    bool falg = true;
                    foreach (Boleto boleto in boletos)
                    {
                        if (boleto.numero == int.Parse(txtCBNumero.Text))
                        {
                            MessageBox.Show("¡El numero se encuentra registrado!");
                            falg = false;
                            break;
                        }
                    }
                    if (falg)
                    {
                        Vuelo vueloA = vuelos[cmbCBVuelo.SelectedIndex];
                        Cliente clientA = clientes[cmbCBCliente.SelectedIndex];
                        Boleto boleto = new Boleto
                        {
                            numero = int.Parse(txtCBNumero.Text),
                            vuelo = vueloA,
                            fecha = dtpCBFecha.Value,
                            cliente = clientA,
                            asientos = Decimal.ToInt32(numCBAsientos.Value)
                        };
                        enlaceDB.AgregarBoleto(boleto);
                        MessageBox.Show("¡Guardado Correctamente!");
                        LimpiarCuadrosTexto();
                    }
                }

            }
        }

        private void LimpiarCuadrosTexto()
        {
            txtCBNumero.Text = cmbCBCliente.Text = cmbCBVuelo.Text = "";
            dtpCBFecha.Value = DateTime.Now;
            numCBAsientos.Value = 1;
        }

        private void btnCBAceptar_Click(object sender, EventArgs e)
        {
            GuardarBoleto();
        }
    }
}
