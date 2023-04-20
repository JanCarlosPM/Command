using System;

namespace Datos
{
    public class ProductoReceiver
    {
        // Producto
        public double Cantidad { get; set; }
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Procesador { get; set; }
        public int MemoriaRam { get; set; }
        public int Almacenamiento { get; set; }
        public string SistemaOperativo { get; set; }
        public int AltaStock { get; set; }
        public int BajaStock { get; set; }

        // Operaciones propias del producto

        /*public void RestarStock()
        {
            Cantidad = Cantidad + AltaStock - BajaStock;
        }

        /*public void SumarStock(double cant)
        {
            Cantidad = Cantidad + cant;
        }*/
    }
}