namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p2 = new Problema2();

            var resultado = p2.CrearResumenVenta(1, "Teclado", 2, 1000);

            Console.WriteLine(resultado);
            Console.WriteLine("Hello, World!");
        }
    }
}
