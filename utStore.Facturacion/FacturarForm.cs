using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace utStore.Facturacion
{
    public partial class FacturarForm : Form
    {
        utStore.Library.Config cfg;

        SqlConnection conexion;
        SqlTransaction transaccion;
        SqlCommand comando;
        SqlDataAdapter adaptador;
        DataTable tabla;

        private int cliente_id;
        private decimal deuda_maxima;
        private decimal deuda_actual;

        private int articulo_id;
        private int articulo_existencias;
        private decimal articulo_precio;

        private int empleado_id;
        private float empleado_porcentaje_comision;
        private decimal empleado_comision;

        private decimal monto_total;

        private int articulo_cantidad;

        public FacturarForm()
        {
            InitializeComponent();
        }

        private void FacturarForm_Load(object sender, EventArgs e)
        {
            restoreVariables();
            cfg = new utStore.Library.Config();
            conexion = new SqlConnection(cfg.GetConnectionString("tienda"));

            try
            {
                conexion.Open();
                tabla = new DataTable();
                comando = new SqlCommand();
                comando.Connection = conexion;

                // Cargar Clientes
                comando.CommandText = "SELECT * FROM Clientes";
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);
                ClienteComboBox.DataSource = tabla;
                ClienteComboBox.DisplayMember = "nombre";
                ClienteComboBox.ValueMember="id_cliente";

                // Cargar Articulos
                tabla = new DataTable();
                comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT * FROM Articulo";
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);

                ArticuloComboBox.DataSource = tabla;
                ArticuloComboBox.DisplayMember = "nombre";
                ArticuloComboBox.ValueMember = "id_articulo";

                // Cargar Empleados
                tabla = new DataTable();
                comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT * FROM Empleado";
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);

                EmpleadoComboBox.DataSource = tabla;
                EmpleadoComboBox.DisplayMember = "nombre";
                EmpleadoComboBox.ValueMember = "id_empleado";


                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "utStore Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ClienteBuscarButton_Click(object sender, EventArgs e)
        {
            cliente_id = Convert.ToInt32(ClienteComboBox.SelectedValue.ToString());
            conexion.Open();
            tabla = new DataTable();
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "SELECT TOP 1 * FROM Clientes WHERE id_cliente=@id";
            comando.Parameters.Add("@id", SqlDbType.Int);
            comando.Parameters["@id"].Value = cliente_id;
            adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tabla);
            conexion.Close();
            if (tabla.Rows.Count == 0)
            {
                throw new Exception("La informacion del cliente no se encuentra disponible");
            }
            else
            {
                cliente_id = tabla.Rows[0].Field<int>("id_cliente");
                deuda_actual = tabla.Rows[0].Field<decimal>("deuda");
                deuda_maxima = tabla.Rows[0].Field<decimal>("deuda_max");
            }
            DeudaActualValorLabel.Text = deuda_actual.ToString().Trim();
            DeudaMaximaValorLabel.Text = deuda_maxima.ToString().Trim();
        }

        private void ArticuloBuscarButton_Click(object sender, EventArgs e)
        {
            articulo_id = Convert.ToInt32(ArticuloComboBox.SelectedValue.ToString());
            conexion.Open();
            tabla = new DataTable();
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "SELECT TOP 1 * FROM Articulo WHERE id_articulo=@id";
            comando.Parameters.Add("@id", SqlDbType.Int);
            comando.Parameters["@id"].Value = articulo_id;
            adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tabla);
            conexion.Close();
            if (tabla.Rows.Count == 0)
            {
                throw new Exception("La informacion del articulo no se encuentra disponible");
            }
            else
            {
                articulo_id = tabla.Rows[0].Field<int>("id_articulo");
                articulo_existencias = tabla.Rows[0].Field<int>("existencia");
                articulo_precio = tabla.Rows[0].Field<decimal>("precio_sugerido");
            }
            ArticuloExistenciasValorLabel.Text = articulo_existencias.ToString().Trim();
            ArticuloPrecioSugeridoValorLabel.Text = articulo_precio.ToString().Trim();
        }

        private void FacturaButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(ArticuloCantidadTextBox.Text.Trim()))
                    throw new Exception("No puedes dejar la cantidad de articulos a pedir con campo vacio. Por favor proporcione una cantidad.");
                if (!utStore.Library.Validation.IsValid(Library.Validation.ValidTypeEnum.Numeric, ArticuloCantidadTextBox.Text.Trim()))
                    throw new Exception("La cantidad de articulos pedidos solo acepta numeros.");
                
                realizarFactura();
                
                DeudaActualValorLabel.Text = deuda_actual.ToString();
                DeudaMaximaValorLabel.Text = deuda_maxima.ToString();
                ArticuloPrecioSugeridoValorLabel.Text = articulo_precio.ToString();
                ArticuloExistenciasValorLabel.Text = articulo_existencias.ToString();
                ArticuloCantidadTextBox.Text = string.Empty;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "utStore Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Funciones Internas

        private void restoreVariables()
        {
            cliente_id = 0;
            deuda_maxima = 0;
            deuda_actual = 0;

            articulo_id = 0;
            articulo_existencias = 0;
            articulo_precio = 0;

            empleado_id = 0;
            empleado_porcentaje_comision = 0;
            empleado_comision = 0;

            monto_total = 0;
        }

        /// <summary>
        /// Realizar la facturacion usando transacciones
        /// </summary>
        private void realizarFactura()
        {
            string comandoInsertFactura = string.Empty;
            try
            {
                conexion.Open();

                empleado_id = Convert.ToInt32(EmpleadoComboBox.SelectedValue.ToString());
                tabla = new DataTable();
                comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT TOP 1 * FROM Empleado WHERE id_empleado=@id";
                comando.Parameters.Add("@id", SqlDbType.Int);
                comando.Parameters["@id"].Value = empleado_id;
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);
                if (tabla.Rows.Count == 0)
                {
                    throw new Exception("La informacion del empleado no se encuentra disponible");
                }
                else
                {
                    empleado_id = tabla.Rows[0].Field<int>("id_empleado");
                    empleado_porcentaje_comision = Convert.ToSingle(tabla.Rows[0].Field<double>("porcentaje_comision"));
                    empleado_comision = tabla.Rows[0].Field<decimal>("comision");
                }

                articulo_cantidad = Convert.ToInt32(ArticuloCantidadTextBox.Text.Trim());
                monto_total = Convert.ToDecimal(articulo_cantidad * articulo_precio);

                transaccion = conexion.BeginTransaction();
                FacturaTransaccionProgressBar.Value = 20;

                // Insertar Factura y los detalles
                comandoInsertFactura += " SET NOCOUNT ON DECLARE @newid int SELECT @newid=(isnull(max(no_factura),0))+1 FROM Factura WITH (HOLDLOCK, TABLOCKX)  ";
                comandoInsertFactura += " INSERT INTO Factura VALUES(@newid,@cli_id,@emp_id,@monto_total) ";
                comandoInsertFactura += " INSERT INTO Detalle_Factura VALUES(@newid,@art_id,@art_cantidad,@art_precio) ";

                SqlCommand comandoFactura1 = new SqlCommand();
                comandoFactura1.Connection = conexion;
                comandoFactura1.CommandText = comandoInsertFactura;
                comandoFactura1.Parameters.Add("@cli_id", SqlDbType.Int);
                comandoFactura1.Parameters.Add("@emp_id", SqlDbType.Int);
                comandoFactura1.Parameters.Add("@art_id", SqlDbType.Int);
                comandoFactura1.Parameters.Add("@art_cantidad", SqlDbType.Int);
                comandoFactura1.Parameters.Add("@art_precio", SqlDbType.Money);
                comandoFactura1.Parameters.Add("@monto_total", SqlDbType.Money);
                comandoFactura1.Parameters["@cli_id"].Value = cliente_id;
                comandoFactura1.Parameters["@emp_id"].Value = empleado_id;
                comandoFactura1.Parameters["@art_id"].Value = articulo_id;
                comandoFactura1.Parameters["@art_cantidad"].Value = articulo_cantidad;
                comandoFactura1.Parameters["@art_precio"].Value = articulo_precio;
                comandoFactura1.Parameters["@monto_total"].Value = monto_total;
                comandoFactura1.Transaction = transaccion;
                comandoFactura1.ExecuteNonQuery();
                FacturaTransaccionProgressBar.Value = 40;

                // Actualizar Existencia Articulo
                SqlCommand comandoFactura2 = new SqlCommand();
                comandoFactura2.Connection = conexion;
                comandoFactura2.CommandText = "UPDATE Articulo SET existencia=@art_exist_actual WHERE id_articulo=@articulo_id";
                comandoFactura2.Parameters.Add("@articulo_id", SqlDbType.Int);
                comandoFactura2.Parameters.Add("@art_exist_actual", SqlDbType.Int);
                comandoFactura2.Parameters["@articulo_id"].Value = articulo_id;
                comandoFactura2.Parameters["@art_exist_actual"].Value = articulo_existencias - articulo_cantidad;
                comandoFactura2.Transaction = transaccion;
                comandoFactura2.ExecuteNonQuery();
                FacturaTransaccionProgressBar.Value = 60;

                // Aumentar deuda en Cliente
                SqlCommand comandoFactura3 = new SqlCommand();
                comandoFactura3.Connection = conexion;
                comandoFactura3.CommandText = "UPDATE Clientes SET deuda=@deuda_actual WHERE id_cliente=@cliente_id";
                comandoFactura3.Parameters.Add("@cliente_id", SqlDbType.Int);
                comandoFactura3.Parameters.Add("@deuda_actual", SqlDbType.Money);
                comandoFactura3.Parameters["@cliente_id"].Value = cliente_id;
                comandoFactura3.Parameters["@deuda_actual"].Value = deuda_actual + monto_total;
                comandoFactura3.Transaction = transaccion;
                comandoFactura3.ExecuteNonQuery();
                FacturaTransaccionProgressBar.Value = 70;

                // Calcular y actualizar comision empleado
                SqlCommand comandoFactura4 = new SqlCommand();
                comandoFactura4.Connection = conexion;
                comandoFactura4.CommandText = "UPDATE Empleado SET comision=@comision WHERE id_empleado=@empleado_id";
                comandoFactura4.Parameters.Add("@empleado_id", SqlDbType.Int);
                comandoFactura4.Parameters.Add("@comision", SqlDbType.Money);
                comandoFactura4.Parameters["@empleado_id"].Value = empleado_id;
                comandoFactura4.Parameters["@comision"].Value = empleado_comision + (monto_total / Convert.ToDecimal(empleado_porcentaje_comision));
                comandoFactura4.Transaction = transaccion;
                comandoFactura4.ExecuteNonQuery();
                FacturaTransaccionProgressBar.Value = 80;

                transaccion.Commit();
                FacturaTransaccionProgressBar.Value = 90;

                // Actualizacion de las variables
                articulo_existencias -= articulo_cantidad;
                deuda_actual += monto_total;
                empleado_comision += (monto_total / Convert.ToDecimal(empleado_porcentaje_comision));
                FacturaTransaccionProgressBar.Value = 100;

                MessageBox.Show("La facturacion se ha efectuado.", "utStore Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FacturaTransaccionProgressBar.Value = 0;

            }
            catch (Exception ex)
            {
                if(transaccion != null)
                    transaccion.Rollback();

                FacturaTransaccionProgressBar.Value = 0;

                if (ex.Message.ToString().IndexOf("CK_Articulo_Existencias") >= 0)
                    throw new Exception("El articulo solicitado tiene menor cantidad de existencias a lo pedido. "+Environment.NewLine+"Ingrese una cantidad menor a las existencias actuales del articulo.");
                else if (ex.Message.ToString().IndexOf("CK_Clientes_Deuda") >= 0)
                    throw new Exception("La deuda actual del cliente es menor al cero. Verifique por favor.");
                else if (ex.Message.ToString().IndexOf("CK_Clientes_DeudaMayorQueDeudaMax") >= 0)
                    throw new Exception("La deuda actual del cliente es mayor la deuda maxima permitida.");
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
