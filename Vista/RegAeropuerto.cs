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
    public partial class RegAeropuerto : Form
    {
        DatosAerouned enlaceDB;
        public RegAeropuerto()
        {
            InitializeComponent();
            enlaceDB = new DatosAerouned();
        }

        private void btnRAPCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void GuardarAeropuerto()
        {
            // Revisa que se incluyan los datos
            if (txtRAPCodigo.Text.Equals("") || txtRAPNombre.Text.Equals("") || txtRAPPais.Text.Equals("") || txtRAPCiudad.Text.Equals("") || txtRAPTelefono.Text.Equals(""))
            {
                MessageBox.Show("¡Debe llenar todos los campos!");
            }
            else if (txtRAPCodigo.Text.Length != 4)
            {
                MessageBox.Show("¡El ID debe ser de 4 caracteres!");
            }
            else
            {
                // Se debe comprobar el ID
                List<Aeropuerto> aeropuertos = enlaceDB.ConsultarAeropuertos();
                if (aeropuertos.Count == 0)
                {
                    bool estado = cmbRAPEstado.Text == "Activo";
                    Aeropuerto aeropuertoAgregar = new Aeropuerto 
                    {
                        id = txtRAPCodigo.Text,
                        nombre = txtRAPNombre.Text,
                        pais = txtRAPPais.Text,
                        ciudad = txtRAPCiudad.Text,
                        telefono = txtRAPTelefono.Text,
                        estado = estado
                    };
                    enlaceDB.AgregarAeropuerto(aeropuertoAgregar);
                    MessageBox.Show("¡Guardado Correctamente!");
                    LimpiarCuadrosTexto();
                }
                else
                {
                    bool flag = true;
                    foreach (Aeropuerto aeropuerto in aeropuertos)
                    {
                        if (aeropuerto.id.Equals(txtRAPCodigo.Text))
                        {
                            MessageBox.Show("¡El Código ya se encuentra registrado!");
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        bool estado = cmbRAPEstado.Text == "Activo";
                        Aeropuerto aeropuertoAgregar = new Aeropuerto
                        {
                            id = txtRAPCodigo.Text,
                            nombre = txtRAPNombre.Text,
                            pais = txtRAPPais.Text,
                            ciudad = txtRAPCiudad.Text,
                            telefono = txtRAPTelefono.Text,
                            estado = estado
                        };
                        enlaceDB.AgregarAeropuerto(aeropuertoAgregar);
                        MessageBox.Show("¡Guardado Correctamente!");
                        LimpiarCuadrosTexto();
                    }

                }

            }
        }
        private void LimpiarCuadrosTexto()
        {
            txtRAPCodigo.Text = txtRAPNombre.Text = txtRAPPais.Text = txtRAPCiudad.Text = txtRAPTelefono.Text = "";
            cmbRAPEstado.Text = "Activo";
        }

        private void btnRAPAceptar_Click(object sender, EventArgs e)
        {
            GuardarAeropuerto();
        }
    }
}
