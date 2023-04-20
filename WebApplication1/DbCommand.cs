using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Datos
{
    public abstract class DbCommand : OrdenCommand
    {
        protected SqlConnection _connection;

        public DbCommand(ProductoReceiver producto, double cantidad, SqlConnection connection) : base(producto, cantidad)
        {
            _connection = connection;
        }
      
      
        public abstract void EjecutarConsulta();
    }

}