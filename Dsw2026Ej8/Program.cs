namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p6 = new Problema6();

            var resultado = p6.NormalizarCodigoProducto(" ab 123 x ");

            Console.WriteLine(resultado);
            Console.WriteLine("Hello, World!");
        }
    }
}
