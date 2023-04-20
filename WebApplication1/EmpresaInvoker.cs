using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Datos
{
    public class EmpresaInvoker
    {
        private SqlConnection _connection;
        // Lista de órdenes
        private List<OrdenCommand> ordenes = new List<OrdenCommand>();

        public EmpresaInvoker(SqlConnection connection)
        {
            _connection = connection;
        }

        // Llena la lista de ordenes
        public void TomarOrden(OrdenCommand cmd)
        {
            ordenes.Add(cmd);
        }

        // Recorre toda la lista de ordenes y por cada una ejecutarla
        public void ProcesarOrdenes()
        {
            foreach (var orden in ordenes)
                orden.Ejecutar();
            ordenes.Clear();
        }
    }
}