namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var producto = new Product();
            producto.SetDescription("Original");

            var p3 = new Problema3();

            var resultado = p3.CompararCopias(5, producto);

            Console.WriteLine(resultado);
            Console.WriteLine("Hello, World!");
        }
    }
}
