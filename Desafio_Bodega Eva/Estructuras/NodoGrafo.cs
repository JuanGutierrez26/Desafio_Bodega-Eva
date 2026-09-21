using Desafio_Bodega_Eva.Modelos;
using System.Collections.Generic;

namespace Desafio_Bodega_Eva.Estructuras
{
    // Representa un nodo del grafo de agentes.
    // Cada nodo almacena un agente y sus conexiones con otros nodos.
    internal class NodoGrafo
    {
        public Agente Dato { get; set; }

        public List<Conexion> Conexiones { get; set; }

        // Constructor del nodo.
        public NodoGrafo(Agente dato)
        {
            Dato = dato;
            Conexiones = new List<Conexion>();
        }

        // Representa una conexión entre dos nodos del grafo.
        public class Conexion
        {
            public NodoGrafo Destino { get; set; }
            public double Distancia { get; set; }

            // Constructor de la conexión.
            public Conexion(
                NodoGrafo destino,
                double distancia)
            {
                Destino = destino;
                Distancia = distancia;
            }
        }
    }
}

/*
 * CONTEXTO DE IMPLEMENTACIÓN:
 *
 * Este archivo define el nodo utilizado por el grafo de agentes de
 * Bodega Eva. Cada NodoGrafo almacena un objeto Agente y una lista
 * de conexiones con otros nodos.
 *
 * Cada conexión contiene el nodo de destino y el peso de la conexión,
 * representado mediante una distancia en kilómetros. De esta manera,
 * el grafo puede representar tanto los puntos de respaldo como las
 * relaciones existentes entre ellos.
 *
 * La utilización de una lista de conexiones permite que cada agente
 * pueda relacionarse con uno o varios puntos del grafo sin establecer
 * una cantidad fija de conexiones.
 *
 * Este nodo será administrado posteriormente por GrafoAgente.cs, donde
 * se implementarán las operaciones para agregar agentes, establecer
 * conexiones y determinar el agente disponible más cercano.
 *
 * Aporte: Usuario 2 - Implementación del nodo y las conexiones
 * ponderadas del Grafo de Agentes.
 */