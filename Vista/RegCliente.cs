using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidades;

namespace Vista
{
    public partial class RegCliente : Form
    {
        DatosAerouned enlaceDB;
        public RegCliente()
        {
            InitializeComponent();
            enlaceDB = new DatosAerouned();
        }

        private void btnRCCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GuardarCliente()
        {
            if (txtRCID.Text.Equals("") || txtRCNombre.Text.Equals("") || txtRCApellido1.Text.Equals("") || txtRCApellido2.Text.Equals(""))
            {
                MessageBox.Show("¡Debe llenar todos los campos!");
            }
            else
            {
                // Primero se debe chequear si el ID no se encuentra
                List<Cliente> clientes = enlaceDB.ConsultarClientes();
                if (clientes.Count == 0)
                {
                    Cliente clienteAgregar = new Cliente 
                    { 
                        id = txtRCID.Text,
                        nombre = txtRCNombre.Text, 
                        primApell = txtRCApellido1.Text, 
                        segApell = txtRCApellido2.Text, 
                        genero = cmbRCGenero.Text[0], 
                        dataNaci = dtpRCData.Value 
                    };
                    enlaceDB.AgregarCliente(clienteAgregar);
                    MessageBox.Show("¡Guardado Correctamente!");
                    LimpiarCuadrosTexto();
                }
                else
                {
                    // Se debe comprobar que no este el ID
                    bool flag = true;
                    foreach (Cliente cliente in clientes)
                    {
                        if (cliente.id.Equals(txtRCID.Text))
                        {
                            MessageBox.Show("¡El ID ya se encuentra Registrado!");
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        Cliente clienteAgregar = new Cliente
                        {
                            id = txtRCID.Text,
                            nombre = txtRCNombre.Text,
                            primApell = txtRCApellido1.Text,
                            segApell = txtRCApellido2.Text,
                            genero = cmbRCGenero.Text[0],
                            dataNaci = dtpRCData.Value
                        };
                        enlaceDB.AgregarCliente(clienteAgregar);
                        MessageBox.Show("¡Guardado Correctamente!");
                        LimpiarCuadrosTexto();
                    }
                }

            }
        }
        private void LimpiarCuadrosTexto()
        {
            txtRCID.Text = txtRCApellido1.Text = txtRCApellido2.Text = txtRCNombre.Text = "";
            cmbRCGenero.Text = "No Especifica";
        }

        private void btnRCAceptar_Click(object sender, EventArgs e)
        {
            GuardarCliente();
        }
    }
}
