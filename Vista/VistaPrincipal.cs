using Entidades;
using Datos;
using System.Net;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading;
using Newtonsoft.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace Vista
{
    public partial class VistaPrincipal : Form
    {
        TcpListener tcpListener;
        Thread escuchaClientes;
        DatosAerouned enlaceAerouned;
        ModoficarListBoxDelegado modificarListBoxClientes;
        bool servidorIniciado;
        public VistaPrincipal()
        {
            InitializeComponent();
            enlaceAerouned = new DatosAerouned();
            modificarListBoxClientes = new ModoficarListBoxDelegado(ModificarListBox);
            servidorIniciado = false;
        }
        // Delegado
        private delegate void ModoficarListBoxDelegado(string texto, bool agregar);
        // Funcion para salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Funcion para modificar el textbox
        private void ModificarListBox(string texto, bool agregar)
        {
            if (agregar)
            {
                lstClientesConectados.Items.Add(texto);
            }
            else
            {
                lstClientesConectados.Items.Remove(texto);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegCliente fr = new RegCliente();
            fr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegAeropuerto fr = new RegAeropuerto();
            fr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegAerolinea fr = new RegAerolinea();
            fr.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegVuelo fr = new RegVuelo();
            fr.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Consulta fr = new Consulta("Clientes");
            fr.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Consulta fr = new Consulta("Aeropuertos");
            fr.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Consulta fr = new Consulta("Aerolineas");
            fr.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Consulta fr = new Consulta("Vuelos");
            fr.ShowDialog();
        }
        // funcion Para inicializar el servido
        private void IniciarServidor_Click(object sender, EventArgs e)
        {
            if (IniciarServidor.BackColor.Equals(Color.Red))
            {
                IniciarServidor.BackColor = Color.Green;
                IniciarParametros();
            }
            else
            {
                tcpListener.Stop();
                IniciarServidor.BackColor = Color.Red;
                servidorIniciado = false;
                labelDisponible.Text = "Desconectado";
                modificarBitacora("Desconexión");

            }
        }
        // Funcion para iniciar
        private void IniciarParametros()
        {
            IPAddress local = IPAddress.Parse("127.0.0.1");
            tcpListener = new TcpListener(local, 14100);
            servidorIniciado = true;
            escuchaClientes = new Thread(new ThreadStart(EscuchaClientes));
            escuchaClientes.Start();
            escuchaClientes.IsBackground = true;
            labelDisponible.Text = "Servidor Conectado";

            bitacoraServidor.Text = "Servidor Iniciado IP:127.0.0.1 Puerto: 14100";
            bitacoraServidor.AppendText(Environment.NewLine);
        }
        // Función para escuchar los clientes
        private void EscuchaClientes()
        {
            tcpListener.Start();
            try
            {
                while (servidorIniciado)
                {
                    TcpClient clienteTCP = tcpListener.AcceptTcpClient();
                    // Un Hilo por cliente
                    Thread clienteThread = new Thread(new ParameterizedThreadStart(ComunicacionCliente));
                    clienteThread.Start(clienteTCP);
                }
            }
            catch (Exception) { return; }
        }
        private void ComunicacionCliente(object clienteEscuchado)
        {
            TcpClient tcCliente = (TcpClient)clienteEscuchado;
            StreamReader reader = new StreamReader(tcCliente.GetStream());
            StreamWriter servidorStreamWriter = new StreamWriter(tcCliente.GetStream());
            while (servidorIniciado)
            {
                try
                {
                    var mensaje = reader.ReadLine();
                    MensajeSocket<object> mensajeRecibido = JsonConvert.DeserializeObject<MensajeSocket<object>>(mensaje); // Deserialización del objeto recibido
                    SeleccionarMetodo(mensajeRecibido.Metodo, mensaje, ref servidorStreamWriter);
                }
                catch (Exception) { break; }
            }
            tcCliente.Close();
        }
        private void SeleccionarMetodo(string pMetodo, string pMensaje, ref StreamWriter servidorStreamWriter)
        {
            switch (pMetodo)
            {
                case "Conectar":
                    MensajeSocket<string> mensajeConectar = JsonConvert.DeserializeObject<MensajeSocket<string>>(pMensaje);// Se deserializa el objeto recibido mediante json
                    Conectar(mensajeConectar.Entidad, ref servidorStreamWriter);
                    break;
                case "ObtenerCliente":
                    MensajeSocket<string> mensajeOCliente = JsonConvert.DeserializeObject<MensajeSocket<string>>(pMensaje);
                    EnviarCliente(mensajeOCliente.Entidad, ref servidorStreamWriter);
                    break;
                case "ComprarBoleto":
                    MensajeSocket<Boleto> mensajeCrearBoleto = JsonConvert.DeserializeObject<MensajeSocket<Boleto>>(pMensaje);
                    AgregarBoleto(mensajeCrearBoleto.Entidad);
                    break;
                case "ConsultarBoletos":
                    MensajeSocket<Cliente> mensajeObtBoletos = JsonConvert.DeserializeObject<MensajeSocket<Cliente>>(pMensaje);
                    EnviarBoletos(mensajeObtBoletos.Entidad, ref servidorStreamWriter);
                    break;
                case "TodosBoletos":
                    EnviarTodosBoletos(ref servidorStreamWriter);
                    break;
                case "ConsultarVuelos":
                    EnviarVuelos(ref servidorStreamWriter);
                    break;
                case "Desconectar":
                    MensajeSocket<string> mensajeDesconectar = JsonConvert.DeserializeObject<MensajeSocket<string>>(pMensaje);//Se deserializa el objeto recibido mediante json
                    Desconectar(mensajeDesconectar.Entidad);
                    break;
                default:
                    break;
            }
        }
        // Funcion para modificar biacora
        private void modificarBitacora(string texto)
        {
            bitacoraServidor.AppendText(DateTime.Now.ToString() + " - " + texto);
            bitacoraServidor.AppendText(Environment.NewLine);
        }


        // Funcion para desconectar
        private void Desconectar(string idCliente)
        {
            modificarBitacora(idCliente + " se ha desconectado!");
            lstClientesConectados.Invoke(modificarListBoxClientes, new object[] { idCliente, false });
        }
        // Funcion para conectar
        private void Conectar(string idCliente, ref StreamWriter servidorStreamWriter)
        {
            List<Cliente> clientes = enlaceAerouned.ConsultarClientes();

            foreach (Cliente cliente in clientes)
            {
                if (cliente.id.Equals(idCliente))
                {
                    modificarBitacora(idCliente + " se ha conectado!");
                    lstClientesConectados.Invoke(modificarListBoxClientes, new object[] { idCliente, true });
                    servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(true));
                    servidorStreamWriter.Flush();
                    return;
                }


            }
            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(false));
            servidorStreamWriter.Flush();


        }
        // Funcion para enviar vuelos
        private void EnviarVuelos(ref StreamWriter servidorStreamWriter)
        {
            List<Vuelo> vuelos = enlaceAerouned.ConsultarVuelos();
            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(vuelos));
            servidorStreamWriter.Flush();

        }
        // Funcion para enciar todos los boletos
        private void EnviarTodosBoletos(ref StreamWriter servidorStreamWriter)
        {
            List<Boleto> boletos = enlaceAerouned.ConsultarBoletos();
            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(boletos));
            servidorStreamWriter.Flush();
        }
        private void EnviarCliente(string idCliente, ref StreamWriter servidorStreamWriter)
        {
            List<Cliente> clientes = enlaceAerouned.ConsultarClientes();
            foreach (Cliente cliente in clientes)
            {

                if (cliente.id.Equals(idCliente))
                {
                    servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(cliente));
                    servidorStreamWriter.Flush();
                    return;
                }

            }
        }
        // Funcion para consultar Boletos 
        private void EnviarBoletos(Cliente clientito, ref StreamWriter servidorStreamWriter)
        {
            List<Boleto> boletos = enlaceAerouned.ConsultarBoletosDe(clientito);
            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(boletos));
            servidorStreamWriter.Flush();
        }
        // Funcion para agregar cliente
        private void AgregarBoleto(Boleto boleto)
        {
            enlaceAerouned.AgregarBoleto(boleto);
        }
        // Funcion para enviar Lista de Vuelos
        private void ObtenerVuelos(ref StreamWriter servidorStreamWriter)
        {
            List<Vuelo> vuelos = enlaceAerouned.ConsultarVuelos();
            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(vuelos));
            servidorStreamWriter.Flush();
        }
        private void ObtenerBoletos(Cliente Clientito, ref StreamWriter servidorStreamWriter)
        {
            List<Boleto> boletos = new List<Boleto>();
            boletos = enlaceAerouned.ConsultarBoletosDe(Clientito);
            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(boletos));
            servidorStreamWriter.Flush();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RegBoleto fr = new RegBoleto();
            fr.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Consulta fr = new Consulta("Boletos");
            fr.ShowDialog();
        }

        private void comprarBoletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegBoleto fr = new RegBoleto();
            fr.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegCliente fr = new RegCliente();
            fr.ShowDialog();
        }

        private void aeropuertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegAeropuerto fr = new RegAeropuerto();
            fr.ShowDialog();
        }

        private void aerolíneaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegAerolinea fr = new RegAerolinea();
            fr.ShowDialog();
        }

        private void vueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegVuelo fr = new RegVuelo();
            fr.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta fr = new Consulta("Clientes");
            fr.ShowDialog();
        }

        private void aeropuertosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta fr = new Consulta("Aeropuertos");
            fr.ShowDialog();
        }

        private void aerolíneasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta fr = new Consulta("Aerolineas");
            fr.ShowDialog();
        }

        private void vuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta fr = new Consulta("Vuelos");
            fr.ShowDialog();
        }

        private void boletosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta fr = new Consulta("Boletos");
            fr.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AeroUned3.0\nUNED Costa Rica\nJose Rodolfo Rojas Ocampo");
        }
    }
}