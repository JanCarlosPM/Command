using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace Datos
{
    public class AltaStockDbCommand : DbCommand
    {
        public AltaStockDbCommand(ProductoReceiver producto, double cantidad, SqlConnection connection) : base(producto, cantidad, connection)
        {
        }

        public override void Ejecutar()
        {
            EjecutarConsulta();
        }

        public override void EjecutarConsulta()
        {
            
            if (_producto.AltaStock != 0)
            {
                SqlCommand command = new SqlCommand();
                command.Connection = _connection;
                command.CommandText = "UPDATE computadora SET Cantidad = Cantidad + @AltaStock, AltaStock = @AltaStock WHERE Id = @Id";
                command.Parameters.AddWithValue("@Cantidad", _cantidad);
                command.Parameters.AddWithValue("@AltaStock", _producto.AltaStock);
                command.Parameters.AddWithValue("@Id", _producto.Id);
                command.ExecuteNonQuery();
            }
        }
    }
}