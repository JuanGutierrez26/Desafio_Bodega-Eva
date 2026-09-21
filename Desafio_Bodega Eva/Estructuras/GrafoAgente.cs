using Desafio_Bodega_Eva.Modelos;
using System;
using System.Collections.Generic;

namespace Desafio_Bodega_Eva.Estructuras
{
    // Implementa un grafo ponderado para representar las conexiones
    // entre Bodega Eva y sus agentes o puntos de respaldo.
    public class GrafoAgente
    {
        private List<NodoGrafo> nodos;

        // Constructor del grafo.
        public GrafoAgente()
        {
            nodos = new List<NodoGrafo>();
        }

        // Agrega un nuevo agente como nodo del grafo.
        public bool AgregarAgente(Agente agente)
        {
            if (agente == null)
            {
                return false;
            }

            if (BuscarNodo(agente.Codigo) != null)
            {
                return false;
            }

            nodos.Add(new NodoGrafo(agente));

            return true;
        }

        // Busca un nodo mediante el código del agente.
        private NodoGrafo BuscarNodo(int codigo)
        {
            foreach (NodoGrafo nodo in nodos)
            {
                if (nodo.Dato.Codigo == codigo)
                {
                    return nodo;
                }
            }

            return null;
        }

        // Crea una conexión ponderada entre dos agentes.
        public bool Conectar(
            int codigoOrigen,
            int codigoDestino,
            double distancia)
        {
            if (distancia < 0)
            {
                return false;
            }

            NodoGrafo origen = BuscarNodo(codigoOrigen);
            NodoGrafo destino = BuscarNodo(codigoDestino);

            if (origen == null || destino == null)
            {
                return false;
            }

            foreach (NodoGrafo.Conexion conexion in origen.Conexiones)
            {
                if (conexion.Destino == destino)
                {
                    return false;
                }
            }

            origen.Conexiones.Add(
                new NodoGrafo.Conexion(destino, distancia));

            return true;
        }

        // Busca el agente disponible más cercano desde un punto de origen.
        // Utiliza el algoritmo de Dijkstra para considerar las distancias.
        public Agente BuscarAgenteMasCercano(
            int codigoOrigen,
            out double distanciaTotal)
        {
            distanciaTotal = double.PositiveInfinity;

            NodoGrafo origen = BuscarNodo(codigoOrigen);

            if (origen == null)
            {
                return null;
            }

            Dictionary<NodoGrafo, double> distancias =
                new Dictionary<NodoGrafo, double>();

            HashSet<NodoGrafo> visitados =
                new HashSet<NodoGrafo>();

            foreach (NodoGrafo nodo in nodos)
            {
                distancias[nodo] = double.PositiveInfinity;
            }

            distancias[origen] = 0;

            while (visitados.Count < nodos.Count)
            {
                NodoGrafo actual = ObtenerNodoMenorDistancia(
                    distancias,
                    visitados);

                if (actual == null)
                {
                    break;
                }

                visitados.Add(actual);

                // El origen representa a Bodega Eva y no debe
                // considerarse como agente de respaldo.
                if (actual != origen && actual.Dato.Disponible)
                {
                    distanciaTotal = distancias[actual];

                    return actual.Dato;
                }

                foreach (NodoGrafo.Conexion conexion
                    in actual.Conexiones)
                {
                    NodoGrafo vecino = conexion.Destino;

                    if (visitados.Contains(vecino))
                    {
                        continue;
                    }

                    double nuevaDistancia =
                        distancias[actual] + conexion.Distancia;

                    if (nuevaDistancia < distancias[vecino])
                    {
                        distancias[vecino] = nuevaDistancia;
                    }
                }
            }

            return null;
        }

        // Obtiene el nodo no visitado con menor distancia acumulada.
        private NodoGrafo ObtenerNodoMenorDistancia(
            Dictionary<NodoGrafo, double> distancias,
            HashSet<NodoGrafo> visitados)
        {
            NodoGrafo menor = null;
            double menorDistancia = double.PositiveInfinity;

            foreach (NodoGrafo nodo in nodos)
            {
                if (visitados.Contains(nodo))
                {
                    continue;
                }

                if (distancias[nodo] < menorDistancia)
                {
                    menorDistancia = distancias[nodo];
                    menor = nodo;
                }
            }

            return menor;
        }

        // Devuelve la cantidad de agentes registrados.
        public int Contar()
        {
            return nodos.Count;
        }

        // Verifica si el grafo no contiene nodos.
        public bool EstaVacio()
        {
            return nodos.Count == 0;
        }

        // Muestra los agentes y sus conexiones.
        public string Mostrar()
        {
            if (EstaVacio())
            {
                return "No hay agentes registrados.";
            }

            string resultado = "";

            foreach (NodoGrafo nodo in nodos)
            {
                resultado += nodo.Dato.ToString()
                    + Environment.NewLine;

                foreach (NodoGrafo.Conexion conexion
                    in nodo.Conexiones)
                {
                    resultado += "   -> "
                        + conexion.Destino.Dato.Nombre
                        + " ("
                        + conexion.Distancia.ToString("F1")
                        + " km)"
                        + Environment.NewLine;
                }
            }

            return resultado;
        }
    }
}

/*
 * CONTEXTO DE IMPLEMENTACIÓN:
 *
 * Este archivo implementa la lógica principal del grafo ponderado utilizado
 * para representar las conexiones entre Bodega Eva y sus agentes o puntos
 * de respaldo.
 *
 * La estructura permite agregar agentes como nodos y establecer conexiones
 * entre ellos indicando una distancia en kilómetros como peso de cada
 * conexión.
 *
 * También se implementó la búsqueda del agente disponible más cercano
 * mediante el algoritmo de Dijkstra, considerando la distancia acumulada
 * desde el punto de origen. Esto permite identificar una alternativa de
 * respaldo cuando la conexión principal de Bodega Eva presenta
 * intermitencias.
 *
 * El método BuscarAgenteMasCercano() devuelve el agente disponible cuya
 * distancia total desde el origen es menor entre las rutas alcanzables.
 *
 * Esta implementación corresponde al diseño del proyecto, donde el grafo
 * permite modelar las relaciones de conectividad y encontrar un punto
 * de respaldo considerando las distancias entre los diferentes agentes.
 *
 * Aporte: Usuario 2 - Implementación de la lógica del Grafo Ponderado
 * para agentes de respaldo y conectividad.
 */