using System;

namespace Desafio_Bodega_Eva.Modelos
{
    // Representa una operación registrada durante la actividad diaria de la bodega.
    public class Operacion
    {
        public int Codigo { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public string Responsable { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }

        // Constructor de la operación.
        public Operacion(
            int codigo,
            string tipo,
            string descripcion,
            string responsable,
            decimal monto)
        {
            Codigo = codigo;
            Tipo = tipo;
            Descripcion = descripcion;
            Responsable = responsable;
            Monto = monto;
            Fecha = DateTime.Now;
        }

        // Permite mostrar la información de la operación.
        public override string ToString()
        {
            return $"{Codigo} - {Tipo} - {Descripcion} - " +
                   $"{Responsable} - S/ {Monto:F2} - " +
                   $"{Fecha:dd/MM/yyyy HH:mm}";
        }
    }
}

/*
 * CONTEXTO DE IMPLEMENTACIÓN:
 *
 * Este archivo define el modelo Operacion, que representa la información
 * de cada operación registrada durante la actividad diaria de Bodega Eva.
 *
 * La información será almacenada en una lista enlazada mediante NodoLista
 * y administrada por ListaOperaciones.
 *
 * Se incluyeron los datos necesarios para identificar la operación,
 * describirla, registrar al responsable, almacenar el monto y conservar
 * automáticamente la fecha y hora en que fue creada.
 *
 * La propiedad Codigo permite identificar cada operación y facilita su
 * búsqueda dentro de la lista enlazada.
 *
 * Este modelo constituye la unidad de información que será almacenada
 * posteriormente en los nodos de la estructura de datos.
 *
 * Aporte: Usuario 2 - Implementación del modelo de Operacion.
 */
