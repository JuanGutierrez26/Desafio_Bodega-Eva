using Desafio_Bodega_Eva.Modelos;

namespace Desafio_Bodega_Eva.Estructuras
{
    // Implementa una lista enlazada simple para almacenar
    // las operaciones realizadas diariamente en la bodega.
    public class ListaOperaciones
    {
        private NodoLista cabeza;
        private NodoLista cola;
        private int cantidad;

        // Constructor de la lista.
        public ListaOperaciones()
        {
            cabeza = null;
            cola = null;
            cantidad = 0;
        }

        // Agrega una nueva operación al final de la lista.
        public void Agregar(Operacion operacion)
        {
            NodoLista nuevoNodo = new NodoLista(operacion);

            if (cabeza == null)
            {
                cabeza = nuevoNodo;
                cola = nuevoNodo;
            }
            else
            {
                cola.Siguiente = nuevoNodo;
                cola = nuevoNodo;
            }

            cantidad++;
        }

        // Verifica si la lista está vacía.
        public bool EstaVacia()
        {
            return cabeza == null;
        }

        // Devuelve la cantidad de operaciones registradas.
        public int Contar()
        {
            return cantidad;
        }

        // Busca una operación mediante su código.
        public Operacion Buscar(int codigo)
        {
            NodoLista actual = cabeza;

            while (actual != null)
            {
                if (actual.Dato.Codigo == codigo)
                {
                    return actual.Dato;
                }

                actual = actual.Siguiente;
            }

            return null;
        }

        // Muestra todas las operaciones almacenadas.
        public string Mostrar()
        {
            if (EstaVacia())
            {
                return "No hay operaciones registradas.";
            }

            string resultado = "";
            NodoLista actual = cabeza;

            while (actual != null)
            {
                resultado += actual.Dato.ToString() + Environment.NewLine;
                actual = actual.Siguiente;
            }

            return resultado;
        }
    }
}

/*
 * CONTEXTO DE IMPLEMENTACIÓN:
 *
 * Este archivo implementa la lista enlazada simple encargada de gestionar
 * el registro diario de operaciones de Bodega Eva.
 *
 * La estructura utiliza una referencia al primer nodo (cabeza) y otra al
 * último nodo (cola), permitiendo agregar nuevas operaciones al final de
 * manera eficiente. Cada elemento de la lista corresponde a un NodoLista,
 * que contiene una Operacion y una referencia hacia el siguiente nodo.
 *
 * También se incorporaron operaciones básicas para verificar si la lista
 * está vacía, conocer la cantidad de registros, buscar una operación por
 * código y mostrar todas las operaciones almacenadas.
 *
 * Esta implementación responde al diseño del proyecto, donde se seleccionó
 * una lista enlazada para gestionar un volumen de operaciones que puede
 * crecer dinámicamente durante la actividad diaria de la bodega.
 *
 * Aporte: Usuario 2 - Implementación de la Lista Enlazada de Operaciones.
 */