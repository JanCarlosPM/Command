
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Datos
{

    public class BajaStockDbCommand : DbCommand
    {
        public BajaStockDbCommand(ProductoReceiver producto, double cantidad, SqlConnection connection) : base(producto, cantidad, connection)
        {
        }

        public override void Ejecutar()
        {
            EjecutarConsulta();
        }

        public override void EjecutarConsulta()
        {
           
            if (_producto.BajaStock != 0)
            {
                SqlCommand command = new SqlCommand();
                command.Connection = _connection;
                command.CommandText = "UPDATE computadora SET Cantidad = Cantidad - @BajaStock, BajaStock = @BajaStock WHERE Id = @Id";
                command.Parameters.AddWithValue("@Cantidad", _cantidad);
                command.Parameters.AddWithValue("@BajaStock", _producto.BajaStock);
                command.Parameters.AddWithValue("@Id", _producto.Id);
                command.ExecuteNonQuery();
            } 
        }
    }
}