using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class RegAerolinea : Form
    {
        DatosAerouned enlaceDB;
        public RegAerolinea()
        {
            InitializeComponent();
            enlaceDB = new DatosAerouned();
        }

        private void btnRALCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void GuardarAerolinea()
        {
            // Primero se chequea que no esten los espacios en blanco
            if (txtRALId.Text.Equals("") || txtRALNombre.Text.Equals("") || txtRALTelefono.Text.Equals(""))
            {
                MessageBox.Show("¡Debe llenar todos los campos!");
            }
            else
            {
                // Se debe revisar si en los dato actuales se encuentra el ID
                List<Aerolinea> aerolineas = enlaceDB.ConsultarAerolineas();
                if (aerolineas.Count == 0)
                {
                    bool estado = cmbRALEstado.Text == "Activo";
                    Aerolinea aeroAgregar = new Aerolinea
                    {
                        id = int.Parse(txtRALId.Text),
                        nombre = txtRALNombre.Text,
                        telefono = txtRALTelefono.Text,
                        estado = estado
                    };
                    enlaceDB.AgregarAerolinea(aeroAgregar);
                    MessageBox.Show("¡Guardado Correctamente!");
                    LimpiarCuadrosTexto();
                }
                else
                {
                    bool flag = true;
                    foreach (Aerolinea aero in aerolineas)
                    {
                        if (aero.id == int.Parse(txtRALId.Text)) 
                        {
                            MessageBox.Show("¡El ID ya se encuentra Registrado!");
                            flag = false;
                            break;
                        }
                    }
                    if (flag) 
                    {
                        bool estado = cmbRALEstado.Text == "Activo";
                        Aerolinea aeroAgregar = new Aerolinea 
                        {
                            id = int.Parse(txtRALId.Text),
                            nombre = txtRALNombre.Text,
                            telefono = txtRALTelefono.Text,
                            estado = estado
                        };
                            
                        enlaceDB.AgregarAerolinea(aeroAgregar);
                        MessageBox.Show("¡Guardado Correctamente!");
                        LimpiarCuadrosTexto();
                    }
                }
            }
        }
        private void LimpiarCuadrosTexto() 
        {
            txtRALId.Text = txtRALNombre.Text = txtRALTelefono.Text = "";
            cmbRALEstado.Text = "Activo";
        }

        private void btnRALAceptar_Click(object sender, EventArgs e)
        {
            GuardarAerolinea();
        }

        private void txtRALId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Se chequea que lo ingresado en el ID solo sean numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
