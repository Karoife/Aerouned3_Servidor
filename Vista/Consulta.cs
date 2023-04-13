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
    public partial class Consulta : Form
    {
        DatosAerouned enlaceDB;
        public Consulta(String tipo)
        {
            InitializeComponent();
            enlaceDB = new DatosAerouned();
            if (tipo.Equals("Clientes"))
            {
                mostrarClientes();
            }
            else if (tipo.Equals("Aeropuertos"))
            {
                mostrarAeropuertos();
            }
            else if (tipo.Equals("Aerolineas"))
            {
                mostrarAerolineas();
            }
            else if (tipo.Equals("Vuelos"))
            {
                mostrarVuelos();
            }
            else if (tipo.Equals("Boletos"))
            {
                mostrarBoletos();
            }
        }

        private void mostrarClientes() 
        {
            // Titulos
            titulo.Text = "Consulta de Clientes";
            tablaFinal.ColumnCount = 6;
            tablaFinal.Columns[0].Name = "ID";
            tablaFinal.Columns[1].Name = "Nombre";
            tablaFinal.Columns[2].Name = "Primer Apellido";
            tablaFinal.Columns[3].Name = "Segundo Apellido";
            tablaFinal.Columns[4].Name = "Fecha de Nacimiento";
            tablaFinal.Columns[5].Name = "Genero";
            // Revisa si puede mostrar en las filas
            try 
            {
                List<Cliente> clientes = enlaceDB.ConsultarClientes();
                String genero = "No Especifica";
                foreach (Cliente cliente in clientes) 
                {
                    genero = "No Especifica";
                    if (cliente.genero.Equals('M'))
                    {
                        genero = "Masculino";
                    }
                    else if (cliente.genero.Equals('F'))
                    {
                        genero = "Femenino";
                    }
                    string[] Row = new string[] { cliente.id, cliente.nombre, cliente.primApell, cliente.segApell, cliente.dataNaci.ToString("d"), genero };
                    tablaFinal.Rows.Add(Row);
                }
                
            }
            catch (Exception) 
            {
                // Do nothing
            }
        }

        private void mostrarAeropuertos()
        {
            // Titulos
            titulo.Text = "Consulta de Aeropuertos";
            tablaFinal.ColumnCount = 6;
            tablaFinal.Columns[0].Name = "Código";
            tablaFinal.Columns[1].Name = "Nombre";
            tablaFinal.Columns[2].Name = "País";
            tablaFinal.Columns[3].Name = "Ciudad";
            tablaFinal.Columns[4].Name = "Telefono";
            tablaFinal.Columns[5].Name = "Estado";
            // Revisa si puede mostrar en las filas
            try
            {
                String Estado = "Inactivo";
                List<Aeropuerto> aeropuertos = enlaceDB.ConsultarAeropuertos();
                foreach (Aeropuerto aero in aeropuertos)
                {
                    Estado = "Inactivo";
                    if (aero.estado)
                    {
                        Estado = "Activo";
                    }
                    string[] Row = new string[] { aero.id, aero.nombre, aero.pais, aero.ciudad, aero.telefono, Estado };
                    tablaFinal.Rows.Add(Row);
                }
            }
            catch (Exception)
            {
                // Do Nothing
            }
        }
        // Funcion para mostrar aerolineas
        private void mostrarAerolineas() 
        {
            // Titulos
            titulo.Text = "Consulta de Aeroíneas";
            tablaFinal.ColumnCount = 4;
            tablaFinal.Columns[0].Name = "ID";
            tablaFinal.Columns[1].Name = "Nombre";
            tablaFinal.Columns[2].Name = "Telefono";
            tablaFinal.Columns[3].Name = "Estado";
            // Revisa si puede mostrar en las filas
            try
            {
                String Estado = "Inactivo";
                List<Aerolinea> aerolineas = enlaceDB.ConsultarAerolineas();
                foreach (Aerolinea aero in aerolineas)
                {
                    Estado = "Inactivo";
                    if (aero.estado)
                    {
                        Estado = "Activo";
                    }
                    string[] Row = new string[] { aero.id.ToString(), aero.nombre, aero.telefono, Estado };
                    tablaFinal.Rows.Add(Row);
                }
            }
            catch (Exception) 
            {
                // Do Nothing
            }
        }
        // Funcion para mostrar vuelos.
        private void mostrarVuelos() 
        {
            // Titulos
            titulo.Text = "Consulta de Vuelos";
            tablaFinal.ColumnCount = 6;
            tablaFinal.Columns[0].Name = "Número";
            tablaFinal.Columns[1].Name = "Aerolínea";
            tablaFinal.Columns[2].Name = "Origen";
            tablaFinal.Columns[3].Name = "Destino";
            tablaFinal.Columns[4].Name = "Duración";
            tablaFinal.Columns[5].Name = "Capacidad";
            // Revisa si puede mostrar en las filas
            try
            {
                List<Vuelo> vuelos = enlaceDB.ConsultarVuelos();
                foreach (Vuelo vuelo in vuelos) 
                {
                    string[] Row = new[] { vuelo.id.ToString(), vuelo.aerolinea.nombre, vuelo.origen.ciudad, vuelo.destino.ciudad, vuelo.duracion.ToString("HH:mm"), vuelo.capacidad.ToString() };
                    tablaFinal.Rows.Add(Row);
                }

            }
            catch (Exception) 
            {
                // Do Nothing
            }
        }
        // Funcion para mostrar Boletos
        private void mostrarBoletos() 
        {
            // Titulos
            titulo.Text = "Consulta de Boletos";
            tablaFinal.ColumnCount = 5;
            tablaFinal.Columns[0].Name = "Número";
            tablaFinal.Columns[1].Name = "Vuelo";
            tablaFinal.Columns[2].Name = "Fecha";
            tablaFinal.Columns[3].Name = "Cliente";
            tablaFinal.Columns[4].Name = "Asientos";
            // Revisa si puede mostrar en las filas
            try 
            {
                List<Boleto> boletos = enlaceDB.ConsultarBoletos();
                foreach (Boleto boleto in boletos)
                {
                    string[] Row = new[] { boleto.numero.ToString(), boleto.vuelo.id + "-" + boleto.vuelo.origen.ciudad + "-" + boleto.vuelo.destino.ciudad, boleto.fecha.ToString("d"), boleto.cliente.nombre + " " + boleto.cliente.primApell + " " + boleto.cliente.segApell, boleto.asientos.ToString() };
                    tablaFinal.Rows.Add(Row);
                }
            }
            catch (Exception)
            {
                // Do Nothing
            }

        }
    }
}
