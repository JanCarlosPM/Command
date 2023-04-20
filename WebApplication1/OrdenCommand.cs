
namespace Datos
{
    public abstract class OrdenCommand
    {
        public abstract void Ejecutar();

      
        protected ProductoReceiver _producto;
        protected double _cantidad;

        // Constructor parametrizado (Definir o implementar la agregación y la cantidad)
        public OrdenCommand(ProductoReceiver producto, double cantidad)
        {
           
            _producto = producto;
            _cantidad = cantidad;
        }
    }
}