using Desafio_Bodega_Eva.Modelos;

namespace Desafio_Bodega_Eva.Estructuras
{
    // Representa un nodo de la lista enlazada de operaciones.
    // Cada nodo almacena una operación y referencia al siguiente nodo.
    internal class NodoLista
    {
        public Operacion Dato { get; set; }
        public NodoLista Siguiente { get; set; }

        // Constructor del nodo.
        public NodoLista(Operacion dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}

/*
 * CONTEXTO DE IMPLEMENTACIÓN:
 * 
 * Este archivo define el nodo utilizado por la lista enlazada de operaciones.
 * Cada nodo almacena un objeto de tipo Operacion y mantiene una referencia
 * hacia el siguiente nodo mediante la propiedad Siguiente.
 * 
 * Se implementó de esta manera para permitir que el registro de operaciones
 * crezca dinámicamente sin depender de un tamaño fijo como ocurriría con
 * un arreglo. Esta clase constituye la unidad básica que será administrada
 * posteriormente por ListaOperaciones.cs.
 *
 * Aporte: Usuario 2 - Implementación de la estructura de Lista Enlazada.
 */