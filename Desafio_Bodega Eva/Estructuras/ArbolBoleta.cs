using Desafio_Bodega_Eva.Modelos;

namespace Desafio_Bodega_Eva.Estructuras
{
    // Implementa un Árbol Binario de Búsqueda (BST)
    // para almacenar y consultar boletas mediante su código.
    public class ArbolBoleta
    {
        private NodoArbol raiz;
        private int cantidad;

        // Constructor del árbol.
        public ArbolBoleta()
        {
            raiz = null;
            cantidad = 0;
        }

        // Inserta una nueva boleta en el árbol.
        public bool Insertar(Boleta boleta)
        {
            if (boleta == null)
            {
                return false;
            }

            if (Buscar(boleta.Codigo) != null)
            {
                return false;
            }

            raiz = InsertarRecursivo(raiz, boleta);
            cantidad++;

            return true;
        }

        // Realiza la inserción de forma recursiva.
        private NodoArbol InsertarRecursivo(
            NodoArbol nodo,
            Boleta boleta)
        {
            if (nodo == null)
            {
                return new NodoArbol(boleta.Codigo, boleta);
            }

            int comparacion = string.Compare(
                boleta.Codigo,
                nodo.Clave,
                StringComparison.OrdinalIgnoreCase);

            if (comparacion < 0)
            {
                nodo.Izquierdo =
                    InsertarRecursivo(nodo.Izquierdo, boleta);
            }
            else if (comparacion > 0)
            {
                nodo.Derecho =
                    InsertarRecursivo(nodo.Derecho, boleta);
            }

            return nodo;
        }

        // Busca una boleta mediante su código.
        public Boleta Buscar(string codigo)
        {
            NodoArbol actual = raiz;

            while (actual != null)
            {
                int comparacion = string.Compare(
                    codigo,
                    actual.Clave,
                    StringComparison.OrdinalIgnoreCase);

                if (comparacion == 0)
                {
                    return actual.Dato;
                }

                if (comparacion < 0)
                {
                    actual = actual.Izquierdo;
                }
                else
                {
                    actual = actual.Derecho;
                }
            }

            return null;
        }

        // Devuelve la cantidad de boletas almacenadas.
        public int Contar()
        {
            return cantidad;
        }

        // Verifica si el árbol está vacío.
        public bool EstaVacio()
        {
            return raiz == null;
        }

        // Realiza un recorrido Inorden del árbol.
        // Devuelve las boletas ordenadas por código.
        public string MostrarInorden()
        {
            if (EstaVacio())
            {
                return "No hay boletas registradas.";
            }

            List<string> resultados = new List<string>();

            RecorrerInorden(raiz, resultados);

            return string.Join(
                Environment.NewLine,
                resultados);
        }

        // Recorre el árbol de izquierda a derecha.
        private void RecorrerInorden(
            NodoArbol nodo,
            List<string> resultados)
        {
            if (nodo == null)
            {
                return;
            }

            RecorrerInorden(nodo.Izquierdo, resultados);

            resultados.Add(nodo.Dato.ToString());

            RecorrerInorden(nodo.Derecho, resultados);
        }
    }
}

/*
 * CONTEXTO DE IMPLEMENTACIÓN:
 *
 * Este archivo implementa la lógica principal del Árbol Binario de Búsqueda
 * utilizado para organizar y consultar las boletas de Bodega Eva mediante
 * su código.
 *
 * La operación Insertar() coloca cada boleta en la posición correspondiente
 * según la comparación de su código. Los códigos menores se ubican hacia
 * el subárbol izquierdo y los códigos mayores hacia el subárbol derecho.
 *
 * La operación Buscar() permite localizar una boleta siguiendo únicamente
 * la rama correspondiente del árbol, evitando recorrer registros que no
 * son necesarios para la búsqueda.
 *
 * También se implementó un recorrido Inorden para mostrar las boletas
 * ordenadas por código, además de métodos para conocer la cantidad de
 * registros y verificar si el árbol se encuentra vacío.
 *
 * La implementación responde al diseño lógico del proyecto, donde se
 * seleccionó un Árbol Binario de Búsqueda para realizar consultas de
 * boletas y registros de fiado mediante un código identificador.
 *
 * Aporte: Usuario 2 - Implementación de la lógica del Árbol Binario
 * de Búsqueda para boletas.
 */