using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;
using WebApplication1;

namespace Command_Prototype
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }
        private static List<ProductoReceiver> Computadoras { get; set; } = new List<ProductoReceiver>();

        private void BindGrid()
        {
            gvComputadoras.DataSource = Computadoras;
            gvComputadoras.DataBind();
        }

       

        protected void Hecho_Click(object sender, EventArgs e)
        {
            var cantidadAlta = Int32.Parse(txtAlta.Text);
            var cantidadBaja = Int32.Parse(txtBaja.Text);
            var cantidad = Int32.Parse(txtCantidadProducto.Text);

            // Conexión a la base de datos
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);
            connection.Open();

            //Instancia de la Empresa
            EmpresaInvoker empresa = new EmpresaInvoker(connection);
            var producto = new ProductoReceiver
            {
                //Id = Convert.ToInt32(txtId.Text),
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                Procesador = txtProcesador.Text,
                MemoriaRam = Convert.ToInt32(txtMemoriaRam.Text),
                Almacenamiento = Convert.ToInt32(txtAlmacenamiento.Text),
                SistemaOperativo = txtSistemaOperativo.Text,
                AltaStock = Int32.Parse(txtAlta.Text),
                BajaStock = Int32.Parse(txtBaja.Text),
                Cantidad = int.Parse(txtCantidadProducto.Text)
            };
           
            BindGrid();
            var ordenInsert = new InsertStock(producto, cantidad, connection);
            empresa.TomarOrden(ordenInsert);
            //var ordenAlta = new AltaStockDbCommand(producto, cantidadAlta, connection);
            //empresa.TomarOrden(ordenAlta);
            //var ordenBaja = new BajaStockDbCommand(producto, cantidadBaja, connection);
            //empresa.TomarOrden(ordenBaja);
            empresa.ProcesarOrdenes();
            
            // Cierre de la conexión a la base de datos
            connection.Close();

            lblAltaStock.Text = $"Agregando { cantidadAlta } de Computadoras";
            lblAltaStock.Visible = true;
            lblBajaStok.Text = $"Quitando { cantidadBaja } de Computadoras";
            lblBajaStok.Visible = true;
            // Imprime la cantidad disponible del producto
            lblResultado.Text = $"Total de computadoras es { producto.Cantidad }";
            lblResultado.Visible = true;
        }

        protected void Actualizar_Click(object sender, EventArgs e)
        {
            var cantidadAlta = Int32.Parse(txtAlta.Text);
            var cantidadBaja = Int32.Parse(txtBaja.Text);

            // Conexión a la base de datos
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);
            connection.Open();

            //Instancia de la Empresa
            EmpresaInvoker empresa = new EmpresaInvoker(connection);
            var producto = new ProductoReceiver
            {
                //Cantidad = int.Parse(txtCantidadProducto.Text),
                Id = Convert.ToInt32(txtId.Text),
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                Procesador = txtProcesador.Text,
                MemoriaRam = Convert.ToInt32(txtMemoriaRam.Text),
                Almacenamiento = Convert.ToInt32(txtAlmacenamiento.Text),
                SistemaOperativo = txtSistemaOperativo.Text,
                AltaStock = Int32.Parse(txtAlta.Text),
                BajaStock = Int32.Parse(txtBaja.Text)

            };

            var ordenAlta = new AltaStockDbCommand(producto, cantidadAlta, connection);
            empresa.TomarOrden(ordenAlta);
            var ordenBaja = new BajaStockDbCommand(producto, cantidadBaja, connection);
            empresa.TomarOrden(ordenBaja);
            empresa.ProcesarOrdenes();


            // Cierre de la conexión a la base de datos
            connection.Close();

            lblAltaStock.Text = $"Agregando { cantidadAlta } de Computadoras";
            lblAltaStock.Visible = true;
            lblBajaStok.Text = $"Quitando { cantidadBaja } de Computadoras";
            lblBajaStok.Visible = true;
            // Imprime la cantidad disponible del producto
            lblResultado.Text = $"Total de computadoras es { producto.Cantidad }";
            lblResultado.Visible = true;
        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {   

            Button btnSeleccionar = (Button)sender;
            int index = Convert.ToInt32(btnSeleccionar.CommandArgument);
            GridViewRow row = gvComputadoras.Rows[index];
            
            txtMarca.Text = row.Cells[1].Text;
            txtModelo.Text = row.Cells[2].Text;
            txtProcesador.Text = row.Cells[3].Text;
            txtMemoriaRam.Text = row.Cells[4].Text;
            txtAlmacenamiento.Text = row.Cells[5].Text;
            txtSistemaOperativo.Text = row.Cells[6].Text;
            txtAlta.Text = row.Cells[7].Text;
            txtBaja.Text = row.Cells[8].Text;
            txtCantidadProducto.Text = row.Cells[9].Text;
        }

    }
}
