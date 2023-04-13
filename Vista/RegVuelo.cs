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
    public partial class RegVuelo : Form
    {
        DatosAerouned enlaceDB;
        List<Aerolinea> aerolineas;
        List<Aeropuerto> aeropuertos;
        public RegVuelo()
        {
            InitializeComponent();
            enlaceDB = new DatosAerouned();
            aerolineas = enlaceDB.ConsultarAerolineas();
            aeropuertos = enlaceDB.ConsultarAeropuertos();
            llenarCmbAerolineas();
            llenarCmbAeropuertos();
        }
        // Funcion para llenar el comboBox de Aerolineas
        private void llenarCmbAerolineas()
        {
            try
            {
                foreach (Aerolinea aerolin in aerolineas)
                {
                    cmbRVAerolinea.Items.Add(aerolin.nombre);
                }

            }
            catch (Exception)
            {
                // Do Nothing
            }

        }

        // Funcion para llenar el comboBox de Origen y Destino
        private void llenarCmbAeropuertos()
        {
            try
            {
                foreach (Aeropuerto aeropue in aeropuertos)
                {
                    cmbRVDestino.Items.Add(aeropue.nombre);
                    cmbRVOrigen.Items.Add(aeropue.nombre);
                }
            }
            catch (Exception)
            {
                // Do Nothing
            }
        }


        private void btnRVCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtRVNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Se chequea que lo ingresado en el ID solo sean numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // Revisa el destino y cambia lo que se muestra en origen
        // 
        private void RevisarDestino()
        {
            if (cmbRVOrigen.Items.Count != aeropuertos.Count)
            {
                foreach (Aeropuerto aero in aeropuertos)
                {
                    if (!cmbRVOrigen.Items.Contains(aero.nombre))
                    {
                        cmbRVOrigen.Items.Add(aero.nombre);
                    }
                }
                if (!cmbRVDestino.Text.Equals(""))
                {
                    cmbRVOrigen.Items.Remove(cmbRVDestino.Text);
                }
            }
            else
            {
                if (!cmbRVDestino.Text.Equals(""))
                {
                    cmbRVOrigen.Items.Remove(cmbRVDestino.Text);
                }
            }
        }
        // Revisa el origen y cambia lo que se muestra en destino
        // 
        private void RevisarOrigen()
        {
            if (cmbRVDestino.Items.Count != aeropuertos.Count)
            {
                foreach (Aeropuerto aero in aeropuertos)
                {
                    if (!cmbRVDestino.Items.Contains(aero.nombre))
                    {
                        cmbRVDestino.Items.Add(aero.nombre);
                    }
                }
                if (!cmbRVOrigen.Text.Equals(""))
                {
                    cmbRVDestino.Items.Remove(cmbRVOrigen.Text);
                }
            }
            else
            {
                if (!cmbRVOrigen.Text.Equals(""))
                {
                    cmbRVDestino.Items.Remove(cmbRVOrigen.Text);
                }
            }
        }


        private void cmbRVDestino_DropDown(object sender, EventArgs e)
        {
            RevisarOrigen();
        }

        private void cmbRVOrigen_DropDown(object sender, EventArgs e)
        {
            RevisarDestino();
        }
        // Funcion para Guardar los datos del vuelo
        private void GuardarVuelo()
        {
            if (txtRVNumero.Text.Equals("") || cmbRVAerolinea.Text.Equals("") || cmbRVOrigen.Text.Equals("") || cmbRVDestino.Text.Equals(""))
            {
                MessageBox.Show("¡Debe llenar todos los campos!");
            }
            else
            {
                // Primero se debe chequear si el ID no se encuentra
                List<Vuelo> vuelos = enlaceDB.ConsultarVuelos();
                if (vuelos.Count == 0)
                {
                    Aerolinea aerolin = aerolineas[cmbRVAerolinea.SelectedIndex];
                    Aeropuerto? origen = null;
                    Aeropuerto? destino = null;
                    foreach (Aeropuerto aero in aeropuertos)
                    {
                        if (cmbRVOrigen.Text.Equals(aero.nombre)) { origen = aero; }
                        else if (cmbRVDestino.Text.Equals(aero.nombre)) { destino = aero; }
                    }
                    Vuelo vueloF = new Vuelo
                    {
                        id = int.Parse(txtRVNumero.Text),
                        aerolinea = aerolin,
                        origen = origen,
                        destino = destino,
                        duracion = dtpRVDuracion.Value,
                        capacidad = Decimal.ToInt32(numRVCapacidad.Value)
                    };
                    enlaceDB.AgregarVuelo(vueloF);
                    MessageBox.Show("¡Guardado Correctamente!");
                    LimpiarCuadrosTexto();
                }
                else
                {
                    // Ahora se debe comparar el ID
                    bool flag = true;
                    foreach (Vuelo vuelo in vuelos)
                    {
                        if (vuelo.id == int.Parse(txtRVNumero.Text))
                        {
                            MessageBox.Show("¡El ID ya se encuentra Registrado!");
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        Aerolinea aerolin = aerolineas[cmbRVAerolinea.SelectedIndex];
                        Aeropuerto? origen = null;
                        Aeropuerto? destino = null;
                        foreach (Aeropuerto aero in aeropuertos)
                        {
                            if (cmbRVOrigen.Text.Equals(aero.nombre)) { origen = aero; }
                            else if (cmbRVDestino.Text.Equals(aero.nombre)) { destino = aero; }
                        }
                        Vuelo vueloF = new Vuelo
                        {
                            id = int.Parse(txtRVNumero.Text),
                            aerolinea = aerolin,
                            origen = origen,
                            destino = destino,
                            duracion = dtpRVDuracion.Value,
                            capacidad = Decimal.ToInt32(numRVCapacidad.Value)
                        };
                        enlaceDB.AgregarVuelo(vueloF);
                        MessageBox.Show("¡Guardado Correctamente!");
                        LimpiarCuadrosTexto();
                    }
                }
            }
        }
        // Limpiar cuadros de texto
        private void LimpiarCuadrosTexto()
        {
            txtRVNumero.Text = cmbRVAerolinea.Text = cmbRVOrigen.Text = cmbRVDestino.Text = "";
            numRVCapacidad.Value = 1;
            dtpRVDuracion.Value = new DateTime(2023, 4, 6);

        }

        private void btnRVAceptar_Click(object sender, EventArgs e)
        {
            GuardarVuelo();
        }
    }
}
