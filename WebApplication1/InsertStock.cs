using Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class InsertStock : DbCommand
    {
        public InsertStock(ProductoReceiver producto, double cantidad, SqlConnection connection) : base(producto, cantidad, connection)
        {

        }

        public override void Ejecutar()
        {
            EjecutarConsulta();
        }

        public override void EjecutarConsulta()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = _connection;
            command.CommandText = "INSERT INTO computadora(Marca, Modelo, Procesador, MemoriaRam, Almacenamiento, SistemaOperativo, Cantidad, AltaStock, BajaStock) VALUES(@Marca, @Modelo, @Procesador, @MemoriaRam, @Almacenamiento, @SistemaOperativo, @Cantidad, @AltaStock, @BajaStock)";
            command.Parameters.AddWithValue("@Marca", _producto.Marca);
            command.Parameters.AddWithValue("@Modelo", _producto.Modelo);
            command.Parameters.AddWithValue("@Procesador", _producto.Procesador);
            command.Parameters.AddWithValue("@MemoriaRam", _producto.MemoriaRam);
            command.Parameters.AddWithValue("@Almacenamiento", _producto.Almacenamiento);
            command.Parameters.AddWithValue("@SistemaOperativo", _producto.SistemaOperativo);
            command.Parameters.AddWithValue("@Cantidad", _producto.Cantidad);
            command.Parameters.AddWithValue("@AltaStock", _producto.AltaStock);
            command.Parameters.AddWithValue("@BajaStock", _producto.BajaStock);
            command.ExecuteNonQuery();
        }
    }
}