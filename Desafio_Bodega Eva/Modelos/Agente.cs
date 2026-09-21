using System;

namespace Desafio_Bodega_Eva.Modelos
{
    // Representa un agente o punto de respaldo disponible
    // para mantener la conectividad de Bodega Eva.
    public class Agente
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public bool Disponible { get; set; }

        // Constructor del agente.
        public Agente(
            int codigo,
            string nombre,
            string ubicacion,
            bool disponible)
        {
            Codigo = codigo;
            Nombre = nombre;
            Ubicacion = ubicacion;
            Disponible = disponible;
        }

        // Permite mostrar la información del agente.
        public override string ToString()
        {
            string estado = Disponible ? "Disponible" : "No disponible";

            return $"{Codigo} - {Nombre} - {Ubicacion} - {estado}";
        }
    }
}

/*
 * CONTEXTO DE IMPLEMENTACIÓN:
 *
 * Este archivo define el modelo Agente, utilizado para representar los
 * puntos de respaldo que forman parte del grafo de conectividad de
 * Bodega Eva.
 *
 * Cada agente posee un código identificador, un nombre, una ubicación
 * y un estado que indica si se encuentra disponible para atender una
 * situación de conectividad intermitente.
 *
 * El objeto Agente constituye la información almacenada dentro de los
 * nodos del grafo. Las conexiones y distancias entre los agentes serán
 * administradas posteriormente mediante NodoGrafo.cs y GrafoAgente.cs.
 *
 * Esta implementación responde al diseño del proyecto, donde el grafo
 * permite representar las relaciones entre Bodega Eva y diferentes
 * agentes o puntos de respaldo mediante conexiones ponderadas por
 * distancia.
 *
 * Aporte: Usuario 2 - Implementación del modelo Agente para el
 * Grafo de conectividad y respaldo.
 */