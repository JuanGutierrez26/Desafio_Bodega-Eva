using Desafio_Bodega_Eva.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Bodega_Eva.Estructuras
{
    // Implementa una estructura Cola (FIFO) para gestionar
    // los pedidos recibidos mediante WhatsApp.
    // El primer pedido que llega es el primero que se atiende.
    public class ColaPedidos
    {
        private NodoCola frente;
        private NodoCola final;
        private int cantidad;

        // Constructor de la cola.
        public ColaPedidos()
        {
            frente = null;
            final = null;
            cantidad = 0;
        }

        // Agrega un pedido al final de la cola.
        public void Encolar(Pedido pedido)
        {
            NodoCola nuevoNodo = new NodoCola(pedido);

            if (frente == null)
            {
                frente = nuevoNodo;
                final = nuevoNodo;
            }
            else
            {
                final.Siguiente = nuevoNodo;
                final = nuevoNodo;
            }

            cantidad++;
        }

        // Retira y devuelve el primer pedido de la cola.
        public Pedido Desencolar()
        {
            if (EstaVacia())
            {
                return null;
            }

            Pedido pedido = frente.Dato;

            frente = frente.Siguiente;

            if (frente == null)
            {
                final = null;
            }

            cantidad--;

            return pedido;
        }

        // Verifica si la cola está vacía.
        public bool EstaVacia()
        {
            return frente == null;
        }

        // Devuelve la cantidad de pedidos almacenados.
        public int Contar()
        {
            return cantidad;
        }

        // Muestra los pedidos desde el primero hasta el último.
        public string Mostrar()
        {
            if (EstaVacia())
            {
                return "No hay pedidos en espera.";
            }

            string resultado = "";
            NodoCola actual = frente;

            while (actual != null)
            {
                resultado += actual.Dato.ToString() + Environment.NewLine;
                actual = actual.Siguiente;
            }

            return resultado;
        }
    }
}
