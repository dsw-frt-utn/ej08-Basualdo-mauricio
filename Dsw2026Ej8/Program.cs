namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var helper = new ProductHelper();
            var resultado = helper.ObtenerEtiquetaProducto(123, "Mouse", 1500);

            Console.WriteLine(resultado);
        }
    }
}
