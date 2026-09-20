using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Bodega_Eva.Modelos
{
    // Representa una venta realizada en la bodega.
    public class Venta
    {
        public int Codigo { get; set; }
        public string Cliente { get; set; }
        public string Productos { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }

        public Venta(int codigo, string cliente, string productos, int cantidad, decimal total)
        {
            Codigo = codigo;
            Cliente = cliente;
            Productos = productos;
            Cantidad = cantidad;
            Total = total;
        }

        public override string ToString()
        {
            return $"{Codigo} - {Cliente} - {Productos} - Cantidad: {Cantidad} - S/ {Total:F2}";
        }
    }
}
