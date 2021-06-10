using System;

namespace FacturacionTiendaDePeluches
{
    class Program
    {
        static void Main(string[] args)
        {   // Instanciar clase FACTURA
            FACTURA factura = new FACTURA();
            Console.WriteLine("Bienvenid@ a Peluchilandia");
            Console.WriteLine("Sistema de Facturacion Peluchilandia");
            Console.WriteLine("Sigue los pasos indicados para crear tu Peluchi-Factura");
            Console.WriteLine("Ingresa el numero de serie de la pieza");
            var piezaInput = Console.ReadLine();
            Console.WriteLine("Describe tu producto");
            var descripcionInput = Console.ReadLine();
            Console.WriteLine("Indica cuantas piezas vas a ordenar:");
            var cantidadPeluchesInput = Console.ReadLine();
            int cantidadParced = int.Parse(cantidadPeluchesInput);
            Console.WriteLine("Indica el precio:");
            var precioListaPeluche = Console.ReadLine();
            double precioParced = double.Parse(precioListaPeluche);
            var MontoPreliminar = factura.importeFactura(precioParced, cantidadParced);
            var Preliminar = factura.importeFactura(precioParced, cantidadParced,299);

            Console.WriteLine("***************RESUMEN DE VENTA*****************");
            Console.WriteLine("************PELUCHILANDIA S.A de C.V");
            Console.WriteLine("Numero de serie:" + piezaInput);
            Console.WriteLine("Descripcion: " + descripcionInput);
            Console.WriteLine("Cantidad: " + cantidadPeluchesInput);
            Console.WriteLine("Precio: $" + precioListaPeluche);
            Console.WriteLine("Tu total a pagar es de: $" + MontoPreliminar + " MXN");
            Console.WriteLine("Total a pagar por membresia de nuevo distribuidor mayorista" + "$" + Preliminar + "MXN");
        }
    }
}
