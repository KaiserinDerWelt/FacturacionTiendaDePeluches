using System;

namespace FacturacionTiendaDePeluches
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenid@ a Peluchilandia");
            Console.WriteLine("Sistema de Facturacion Peluchilandia");
            Console.WriteLine("Sigue los pasos indicados para crear tu Peluchi-Factura");
            Console.WriteLine("Ingresa el numero de piezas");
            var piezaInput = Console.ReadLine();
            Console.WriteLine("Describe tu producto");
            var descripcionInput = Console.ReadLine();
            Console.WriteLine("Indica cuantas piezas vas a ordenar:");
            var cantidadPeluchesInput = Console.ReadLine();
            Console.WriteLine("Indica el precio:");
            var precioListaPeluche = Console.ReadLine();
            Console.WriteLine("Tu total a pagar es de:" + "MXN");
        }
    }
}
