using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace utStore.PagoDeuda
{
    public partial class PagoDeudaForm : Form
    {
        utStore.Library.Config cfg;

        SqlConnection conexion;
        SqlTransaction transaccion;
        SqlCommand comando;
        SqlDataAdapter adaptador;
        DataTable tabla;

        private int cliente_id;
        private string cliente;
        private decimal deuda_maxima;
        private decimal deuda_actual;
        private decimal pago;

        public PagoDeudaForm()
        {
            InitializeComponent();
        }

        private void PagoDeudaForm_Load(object sender, EventArgs e)
        {
            restoreVariables();
            cfg = new utStore.Library.Config();
            conexion = new SqlConnection(cfg.GetConnectionString("tienda"));
        }

        private void ClienteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(ClienteTextBox.Text.Trim()))
                    throw new Exception("No puedes dejar la busqueda de clientes con campo vacio. Por favor proporcione un criterio de busqueda.");
                if(!utStore.Library.Validation.IsValid(Library.Validation.ValidTypeEnum.Alpha,ClienteTextBox.Text.Trim()))
                    throw new Exception("El criterio de busqueda de cliente solo acepta letras.");
                
                buscarCliente(ClienteTextBox.Text.Trim());

                DeudaActualValorLabel.Text = deuda_actual.ToString();
                DeudaMaximaValorLabel.Text = deuda_maxima.ToString();
                PagoGroupBox.Enabled = true;

                PagoTransaccionProgressBar.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "utStore PagoDeuda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PagarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(PagoTextBox.Text.Trim()))
                    throw new Exception("No puedes dejar el campo pago vacio. Por favor indique su pago.");
                if (!utStore.Library.Validation.IsValid(Library.Validation.ValidTypeEnum.Decimal, PagoTextBox.Text.Trim()))
                    throw new Exception("La cantidad del pago solo acepta numeros y centavos.");
                
                realizarPago(PagoTextBox.Text.Trim());

                DeudaActualValorLabel.Text = deuda_actual.ToString();
                PagoTextBox.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"utStore PagoDeuda",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        #region Funciones Internas

        private void restoreVariables()
        {
            cliente_id = 0;
            cliente = string.Empty;
            deuda_maxima = 0;
            deuda_actual = 0;
            pago = 0;
        }

        /// <summary>
        /// Funcion que busca los clientes
        /// </summary>
        /// <param name="cadenaBusqueda">Palabra a buscar los nombres con las coincidencias</param>
        private void buscarCliente(string cadenaBusqueda)
        {
            try
            {
                conexion.Open();
                PagoTransaccionProgressBar.Value = 40;

                tabla = new DataTable();
                comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT TOP 1 * FROM Clientes WHERE nombre LIKE '%'+@criterio+'%'";
                comando.Parameters.Add("@criterio", SqlDbType.VarChar);
                comando.Parameters["@criterio"].Value = cadenaBusqueda;
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);
                PagoTransaccionProgressBar.Value = 80;

                conexion.Close();
                if (tabla.Rows.Count == 0)
                {
                    throw new Exception("Su criterio de busqueda " + cadenaBusqueda + " no coincide con los registros de la base de datos");
                }
                else
                {
                    cliente_id = tabla.Rows[0].Field<int>("id_cliente");
                    cliente = tabla.Rows[0].Field<string>("nombre");
                    deuda_actual = tabla.Rows[0].Field<decimal>("deuda");
                    deuda_maxima = tabla.Rows[0].Field<decimal>("deuda_max");
                    PagoTransaccionProgressBar.Value = 100;
                }
            }
            catch (Exception ex)
            {
                PagoTransaccionProgressBar.Value = 0;

                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Función que realiza la transacción para el pago del adeudo, actualizando la deuda actual del cliente.
        /// </summary>
        /// <param name="valor">Cantidad del pago</param>
        private void realizarPago(string valor)
        {
            string comandoInsertPago = string.Empty;
            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                PagoTransaccionProgressBar.Value = 10;

                pago = Convert.ToDecimal(valor);

                if (pago==0)
                    if (deuda_actual == 0)
                        throw new Exception("No estás realizando un pago y tampoco tienes deuda!");
                    else
                        throw new Exception("No estás realizando un pago!");
                
                PagoTransaccionProgressBar.Value = 25;

                // Comando SQL para insertar el pago
                comandoInsertPago += " SET NOCOUNT ON DECLARE @max int SELECT @max=(isnull(max(id_pago),0))+1 FROM Pago WITH (HOLDLOCK, TABLOCKX) ";
                comandoInsertPago += " INSERT INTO Pago VALUES(@max,@cliente_id,@pagocantidad) ";
                PagoTransaccionProgressBar.Value = 30;

                SqlCommand comandoPago1 = new SqlCommand();
                comandoPago1.Connection = conexion;
                comandoPago1.CommandText = comandoInsertPago;
                comandoPago1.Parameters.Add("@cliente_id", SqlDbType.VarChar);
                comandoPago1.Parameters.Add("@pagocantidad", SqlDbType.Int);
                comandoPago1.Parameters["@cliente_id"].Value = cliente_id;
                comandoPago1.Parameters["@pagocantidad"].Value = pago;
                comandoPago1.Transaction = transaccion;
                comandoPago1.ExecuteNonQuery();
                PagoTransaccionProgressBar.Value = 60;

                // Actualiza la Deuda del Cliente
                SqlCommand comandoPago2 = new SqlCommand();
                comandoPago2.Connection = conexion;
                comandoPago2.CommandText = "UPDATE Clientes SET deuda=@deudacantidad WHERE id_cliente=@cliente_id";
                comandoPago2.Parameters.Add("@deudacantidad", SqlDbType.Money);
                comandoPago2.Parameters.Add("@cliente_id", SqlDbType.Int);
                comandoPago2.Parameters["@deudacantidad"].Value = deuda_actual-pago;
                comandoPago2.Parameters["@cliente_id"].Value = cliente_id;
                comandoPago2.Transaction = transaccion;
                comandoPago2.ExecuteNonQuery();
                PagoTransaccionProgressBar.Value = 80;

                transaccion.Commit();
                deuda_actual -= pago;
                PagoTransaccionProgressBar.Value = 100;

                MessageBox.Show("El pago de la deuda se ha efectuado.", "utStore PagoDeuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PagoTransaccionProgressBar.Value = 0;
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                pago = 0;
                PagoTransaccionProgressBar.Value = 0;

                if (ex.Message.ToString().IndexOf("CK_Clientes_DeudaMayorQueDeudaMax") >= 0)
                    throw new Exception("La deuda es mayor que la deuda maxima");
                else if (ex.Message.ToString().IndexOf("CK_Clientes_Deuda") >= 0)
                    throw new Exception("La deuda actual del cliente es menor al pago que deseas aportar. Verifique por favor.");
                else
                    throw new Exception(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        #endregion

    }
}
