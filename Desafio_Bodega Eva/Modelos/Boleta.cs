using System;

namespace Desafio_Bodega_Eva.Modelos
{
    // Representa una boleta registrada en Bodega Eva.
    // La información será almacenada y consultada mediante
    // un Árbol Binario de Búsqueda.
    public class Boleta
    {
        public string Codigo { get; set; }
        public string Cliente { get; set; }
        public string Productos { get; set; }
        public decimal Total { get; set; }
        public bool EsFiado { get; set; }
        public DateTime Fecha { get; set; }

        // Constructor de la boleta.
        public Boleta(
            string codigo,
            string cliente,
            string productos,
            decimal total,
            bool esFiado)
        {
            Codigo = codigo;
            Cliente = cliente;
            Productos = productos;
            Total = total;
            EsFiado = esFiado;
            Fecha = DateTime.Now;
        }

        // Permite mostrar la información de la boleta.
        public override string ToString()
        {
            string tipo = EsFiado ? "Fiado" : "Venta";

            return $"{Codigo} - {Cliente} - {Productos} - " +
                   $"S/ {Total:F2} - {tipo} - " +
                   $"{Fecha:dd/MM/yyyy HH:mm}";
        }
    }
}

/*
 * CONTEXTO DE IMPLEMENTACIÓN:
 *
 * Este archivo define el modelo Boleta, que representa la información
 * de cada boleta o registro de fiado que será almacenado en el Árbol
 * Binario de Búsqueda de Bodega Eva.
 *
 * La propiedad Codigo se utiliza como clave de búsqueda dentro del árbol,
 * mientras que las demás propiedades permiten conservar la información
 * asociada a la boleta, como cliente, productos, monto, tipo de operación
 * y fecha de registro.
 *
 * Se incorporó la propiedad EsFiado para diferenciar una venta normal de
 * un registro realizado al crédito. La fecha se genera automáticamente
 * al momento de crear la boleta.
 *
 * Este modelo constituye la información que posteriormente será almacenada
 * dentro de NodoArbol.cs y administrada por ArbolBoleta.cs.
 *
 * Aporte: Usuario 2 - Implementación del modelo de Boleta para el
 * Árbol Binario de Búsqueda.
 */