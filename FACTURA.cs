using System;
using System.Collections.Generic;
using System.Text;

namespace FacturacionTiendaDePeluches
{
    class FACTURA
    {
        //Declaracion de datos miembro

        private string NoPieza;
        private string Descripcion;
        private int CantidadProductos = 0;
        private double PrecioProducto =0.0;

        //Constructor Factura
        public void Factura() { }

        // Uso de get set para el numero de pieza

        public string Pieza
        {
            get
            {
              return NoPieza;}
            set
            {
                NoPieza = value;
            }
               
            
        }

        // Uso de get set para la descripcion del peluche

        public string PelucheDescripcion
        {
            get
            {
                return Descripcion;
            }

            set
            {
                Descripcion = value;
            }
        }

        //Uso de get set para cantidad de productos

        public int PelucheCantidad
        {
            get
            {
                return CantidadProductos;
            }
            set{
                if (value <= 0)
                {
                    CantidadProductos = 0;
                }
                else
                {
                    CantidadProductos = value;
                }
            }
            
        }

        //Uso de Get set para precio

        public double PeluchePrecio
        {
            get
            {
                return PrecioProducto;
            }
            set
            {
                if (value < 0)
                {
                    PrecioProducto = 0.0;
                }
                else
                {
                    PrecioProducto = value;
                }
            }
        }

        ~FACTURA() {
            NoPieza = "";
            Descripcion = "";
            CantidadProductos = 0;
            PrecioProducto = 0.0;
        }

        // Metodo para facturar normalito
        public double importeFactura(double PrecioProducto, int CantidadProductos)
        {
         if(CantidadProductos < 0)
            {
                PrecioProducto = 0.0;
            }
            double MontoBruto = PrecioProducto * CantidadProductos;
            var IVA = 0.16;
            double CalculoIVA = PrecioProducto * IVA;
            double Total = CalculoIVA + MontoBruto;
            Console.WriteLine("Subtotal:" + MontoBruto) ;
            Console.WriteLine("I.V.A Calculado:" + CalculoIVA);
            return Total;
        }

        // Metodo para facturar sobrecargado
        public double importeFactura(double PrecioProducto, int CantidadProductos,double MembresiaAnual)
        {
            if (CantidadProductos < 0)
            {
                PrecioProducto = 0.0;
            }
            double MontoBruto = PrecioProducto * CantidadProductos;
            var IVA = 0.16;
            double CalculoIVA = PrecioProducto * IVA;
            double Total = CalculoIVA + MontoBruto;
            double CostoTotalParaNuevosClientes = Total + MembresiaAnual;
            return Total;
        }


    }
}
