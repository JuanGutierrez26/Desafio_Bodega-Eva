using Desafio_Bodega_Eva.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Bodega_Eva.Estructuras
{
    // Implementa una estructura Pila (LIFO) para gestionar
    // las ventas que pueden ser reversadas.
    // La última venta registrada es la primera que se puede reversar.
    public class PilaVentas
    {
        private NodoPila cima;
        private int cantidad;

        // Constructor de la pila.
        public PilaVentas()
        {
            cima = null;
            cantidad = 0;
        }

        // Agrega una venta en la cima de la pila.
        public void Apilar(Venta venta)
        {
            NodoPila nuevoNodo = new NodoPila(venta);

            nuevoNodo.Siguiente = cima;
            cima = nuevoNodo;

            cantidad++;
        }

        // Retira y devuelve la venta que está en la cima.
        public Venta Desapilar()
        {
            if (EstaVacia())
            {
                return null;
            }

            Venta venta = cima.Dato;

            cima = cima.Siguiente;

            cantidad--;

            return venta;
        }

        // Verifica si la pila está vacía.
        public bool EstaVacia()
        {
            return cima == null;
        }

        // Devuelve la cantidad de ventas almacenadas.
        public int Contar()
        {
            return cantidad;
        }

        // Muestra las ventas desde la cima hasta el fondo.
        public string Mostrar()
        {
            if (EstaVacia())
            {
                return "No hay ventas registradas.";
            }

            string resultado = "";
            NodoPila actual = cima;

            while (actual != null)
            {
                resultado += actual.Dato.ToString() + Environment.NewLine;
                actual = actual.Siguiente;
            }

            return resultado;
        }
    }
}
