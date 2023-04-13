using Entidades;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
    
    public class DatosAerouned
    {
        // Cadena de conéxión se obtiene de la configuración
        private string cadenaConexion;
        // Constructor solamente agrega la cadena de conexión
        public DatosAerouned() 
        {
            this.cadenaConexion = ConfigurationManager.ConnectionStrings["conexionAerouned"].ConnectionString;
        }
        // -----------------------------------------------------------------------------------------------------
        // FUNCIONES PARA AGREGAR A LA BASE DE DATOS
        // -----------------------------------------------------------------------------------------------------
        // Funcion para agregar cliente
        public void AgregarCliente(Cliente cliente) 
        {
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            conexion = new SqlConnection(this.cadenaConexion);
            sentencia = "Insert Into Cliente (identificacion, nombre, apellido1, apellido2, fec_nacimiento, genero)" +
                        " Values (@identificacion, @nombre, @apellido1, @apellido2, @fec_nacimiento, @genero)";
            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            // Valores que se van a agregar
            comando.Parameters.AddWithValue("@identificacion", cliente.id);
            comando.Parameters.AddWithValue("@nombre", cliente.nombre);
            comando.Parameters.AddWithValue("@apellido1", cliente.primApell);
            comando.Parameters.AddWithValue("@apellido2", cliente.segApell);
            comando.Parameters.AddWithValue("@fec_nacimiento", cliente.dataNaci);
            comando.Parameters.AddWithValue("@genero", cliente.genero);
            // Realizar la conexión
            try 
            {
                conexion.Open();
                comando.ExecuteNonQuery(); // Aqui debería poner un try ya que no siempre va a lograr abrir la base de datos.
                conexion.Close();
            }
            catch (SqlException) 
            {
                // Mensaje de error
            }

        }
        // Funcion para agregar Aeropuerto
        public void AgregarAeropuerto(Aeropuerto aero) 
        {
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            conexion = new SqlConnection(this.cadenaConexion);
            sentencia = "Insert Into Aeropuerto (codigo, nombre, pais, ciudad, telefono, estado)" +
                        " Values (@codigo, @nombre, @pais, @ciudad, @telefono, @estado)";
            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            // Valores que se van a agregar
            comando.Parameters.AddWithValue("@codigo", aero.id);
            comando.Parameters.AddWithValue("@nombre", aero.nombre);
            comando.Parameters.AddWithValue("@pais", aero.pais);
            comando.Parameters.AddWithValue("@ciudad", aero.ciudad);
            comando.Parameters.AddWithValue("@telefono", aero.telefono);
            comando.Parameters.AddWithValue("@estado", aero.estado);
            // Realizar la conexión
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery(); // Aqui debería poner un try ya que no siempre va a lograr abrir la base de datos.
                conexion.Close();
            }
            catch (SqlException)
            {
                // Mensaje de error
            }
        }
        // Funcion para agregar Aerolinea
        public void AgregarAerolinea(Aerolinea aero) 
        {
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            conexion = new SqlConnection(this.cadenaConexion);
            sentencia = "Insert Into Aerolinea (id, nombre, telefono, estado)" +
                        " Values (@id, @nombre, @telefono, @estado)";
            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            // Valores que se van a agregar
            comando.Parameters.AddWithValue("@id", aero.id);
            comando.Parameters.AddWithValue("@nombre", aero.nombre);
            comando.Parameters.AddWithValue("@telefono", aero.telefono);
            comando.Parameters.AddWithValue("@estado", aero.estado);
            // Realizar la conexión
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery(); // Aqui debería poner un try ya que no siempre va a lograr abrir la base de datos.
                conexion.Close();
            }
            catch (SqlException)
            {
                // Mensaje de error
            }

        }
        // Funcion para agregar Vuelo
        public void AgregarVuelo(Vuelo vuelo) 
        {
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            conexion = new SqlConnection(this.cadenaConexion);
            sentencia = "Insert Into Vuelo (numero, id_aerolinea, cod_origen, cod_destino, duracion, capacidad)" +
                        " Values (@numero, @id_aerolinea, @cod_origen, @cod_destino, @duracion, @capacidad)";
            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            // Valores que se van a agregar
            comando.Parameters.AddWithValue("@numero", vuelo.id);
            comando.Parameters.AddWithValue("@id_aerolinea", vuelo.aerolinea.id);
            comando.Parameters.AddWithValue("@cod_origen", vuelo.origen.id);
            comando.Parameters.AddWithValue("@cod_destino", vuelo.destino.id);
            comando.Parameters.AddWithValue("@duracion", vuelo.duracion);
            comando.Parameters.AddWithValue("@capacidad", vuelo.capacidad);
            // Realizar la conexión
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery(); // Aqui debería poner un try ya que no siempre va a lograr abrir la base de datos.
                conexion.Close();
            }
            catch (SqlException)
            {
                // Mensaje de error
            }
        }
        // Funcion para agregar 
        public void AgregarBoleto(Boleto boleto) 
        {
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            conexion = new SqlConnection(this.cadenaConexion);
            sentencia = "Insert Into Boleto (numero, cod_vuelo, fec_compra, id_cliente, asientos)" +
                        " Values (@numero, @cod_vuelo, @fec_compra, @id_cliente, @asientos)";
            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            // Valores que se van a agregar
            comando.Parameters.AddWithValue("@numero", boleto.numero);
            comando.Parameters.AddWithValue("@cod_vuelo", boleto.vuelo.id);
            comando.Parameters.AddWithValue("@fec_compra", boleto.fecha);
            comando.Parameters.AddWithValue("@id_cliente", boleto.cliente.id);
            comando.Parameters.AddWithValue("@asientos", boleto.asientos);
            // Realizar la conexión
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery(); // Aqui debería poner un try ya que no siempre va a lograr abrir la base de datos.
                conexion.Close();
            }
            catch (SqlException)
            {
                // Mensaje de error
            }
        }
        // -----------------------------------------------------------------------------------------------------
        // FUNCIONES PARA CONSULTAR A LA BASE DE DATOS
        // -----------------------------------------------------------------------------------------------------
        // Funcion para consultar clientes
        public List<Cliente> ConsultarClientes() 
        {
            List<Cliente> clientes = new List<Cliente>(); // Lista que se devuelve con los clientes
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;

            conexion = new SqlConnection(this.cadenaConexion);
            sentencia = "Select identificacion, nombre, apellido1, apellido2, fec_nacimiento, genero From Cliente";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;

            conexion.Open() ;
            reader = comando.ExecuteReader();
            if (reader.HasRows) 
            {
                while (reader.Read()) 
                {
                    clientes.Add(new Cliente
                    {
                        id = reader.GetString(0),
                        nombre = reader.GetString(1),
                        primApell = reader.GetString(2),
                        segApell = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        genero = reader.GetString(5)[0],
                        dataNaci = reader.GetDateTime(4)

                    }); ;
                }
            }

            conexion.Close ();


            return clientes;

        }
        // Fucion para consultar Aeropuertos
        public List<Aeropuerto> ConsultarAeropuertos() 
        {
            List<Aeropuerto> aeropuertos = new List<Aeropuerto>(); // Lista que se devuelve con los aeropuertos
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;

            conexion = new SqlConnection(this.cadenaConexion);
            sentencia = "Select codigo, nombre, pais, ciudad, telefono, estado From Aeropuerto";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;


            conexion.Open();
            reader = comando.ExecuteReader();
            if (reader.HasRows) 
            {
                while (reader.Read()) 
                {
                    aeropuertos.Add(new Aeropuerto {
                            id = reader.GetString(0),
                            nombre = reader.GetString(1),
                            pais = reader.GetString(2),
                            ciudad = reader.GetString(3),
                            telefono = reader.GetString(4),
                            estado = reader.GetBoolean(5)

                        });
                }
            }

            conexion .Close ();
            return aeropuertos;

        }
        // Funcion para consultar Aerolineas
        public List<Aerolinea> ConsultarAerolineas() 
        {
            List<Aerolinea> aerolineas = new List<Aerolinea>(); // Lista que se devuelve con los Aerolinea
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;

            conexion = new SqlConnection(this.cadenaConexion);
            sentencia = "Select id, nombre, telefono, estado From Aerolinea";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;

            conexion.Open();
            reader = comando.ExecuteReader();
            if(reader.HasRows) 
            {
                while (reader.Read()) 
                {
                    aerolineas.Add(new Aerolinea {
                            id = Decimal.ToInt32(reader.GetDecimal(0)),
                            nombre = reader.GetString(1),
                            telefono = reader.GetString(2),
                            estado = reader.GetBoolean(3)

                        });
                }
            }
            conexion.Close ();
            return aerolineas;
        }
        // Funcion para consultar vuelos
        public List<Vuelo> ConsultarVuelos() 
        {
            List<Vuelo> vuelos = new List<Vuelo>(); // Lista que se devuelve con los Vuelo
            // Consulta de aerolineas y aeropuertos para agregarse en la clase
            
            List<Aerolinea> aerolineas = ConsultarAerolineas();
            List<Aeropuerto> aeropuertos = ConsultarAeropuertos();
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;

            conexion = new SqlConnection(this.cadenaConexion);
            sentencia = "Select numero, id_aerolinea, cod_origen, cod_destino, duracion, capacidad From Vuelo";
            
            
            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;

            conexion.Open();
            reader = comando.ExecuteReader();
            Aerolinea? aerolinTemp = null;
            Aeropuerto? origenTemp = null;
            Aeropuerto? destinoTemp = null;
            if (reader.HasRows) 
            {
                while (reader.Read()) 
                {
                    foreach (Aerolinea aero in aerolineas) 
                    {
                        if (aero.id == Decimal.ToInt32(reader.GetDecimal(1))) { aerolinTemp = aero; }
                    }
                    foreach (Aeropuerto aero in aeropuertos) 
                    {
                        if (aero.id.Equals(reader.GetString(2))) { origenTemp = aero; }
                        if (aero.id.Equals(reader.GetString(3))) { destinoTemp = aero; }
                    }
                    vuelos.Add(new Vuelo {
                            id = Decimal.ToInt32(reader.GetDecimal(0)),
                            aerolinea = aerolinTemp,
                            origen = origenTemp,
                            destino = destinoTemp,
                            duracion = reader.GetDateTime(4),
                            capacidad = Decimal.ToInt32(reader.GetDecimal(5))

                        });

                }
            }

            conexion.Close();
            return vuelos;

        }
        // Funcion para consultar boletos
        public List<Boleto> ConsultarBoletos() 
        {
            List<Boleto> boletos = new List<Boleto>(); // Lista que se devuelve con los Boletos
            // Consulta de vuelos y clientes para agregarse en la clase

            List<Cliente> clientes = ConsultarClientes();
            List<Vuelo> vuelos = ConsultarVuelos();
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;

            conexion = new SqlConnection(this.cadenaConexion);
            sentencia = "Select numero, cod_vuelo, fec_compra, id_cliente, asientos From Boleto";


            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;

            conexion.Open();
            reader = comando.ExecuteReader();
            Vuelo? vueloTempo = null;
            Cliente? clienteTempo = null;
            if (reader.HasRows) 
            {
                while (reader.Read()) 
                {
                    foreach (Cliente cliente in clientes) 
                    {
                        if (cliente.id.Equals(reader.GetString(3))) { clienteTempo = cliente; }
                    }
                    foreach (Vuelo vuelo in vuelos) 
                    {
                        if (vuelo.id == Decimal.ToInt32(reader.GetDecimal(1))) { vueloTempo = vuelo; }
                    }
                    boletos.Add(new Boleto {
                            numero = Decimal.ToInt32(reader.GetDecimal(0)),
                            vuelo = vueloTempo,
                            fecha = reader.GetDateTime(2),
                            cliente = clienteTempo,
                            asientos = Decimal.ToInt32(reader.GetDecimal(4))
                    });
                }
            }

            conexion.Close();
            return boletos;

        }
        // Funcion para consultar los boletos de un cliente
        public List<Boleto> ConsultarBoletosDe(Cliente cliente) 
        {
            List<Boleto> boletos = new List<Boleto>();
            List<Vuelo> vuelos = ConsultarVuelos();

            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;

            conexion = new SqlConnection(this.cadenaConexion);
            sentencia = "Select numero, cod_vuelo, fec_compra, id_cliente, asientos From Boleto Where id_cliente=@id_cliente";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            // Valores a agregar
            comando.Parameters.AddWithValue("@id_cliente", cliente.id);
            conexion.Open();
            reader = comando.ExecuteReader();
            Vuelo? vueloTempo = null;
            if (reader.HasRows) 
            {
                while (reader.Read()) 
                {
                    foreach (Vuelo vuelo in vuelos) 
                    {
                        if (vuelo.id == Decimal.ToInt32(reader.GetDecimal(1))) { vueloTempo = vuelo; }
                    }
                    boletos.Add(new Boleto {
                            numero = Decimal.ToInt32(reader.GetDecimal(0)),
                            vuelo = vueloTempo,
                            fecha = reader.GetDateTime(2),
                            cliente = cliente,
                            asientos = Decimal.ToInt32(reader.GetDecimal(4))
                        });
                }
            
            }

            conexion.Close();
            return boletos;
        }


    }
}