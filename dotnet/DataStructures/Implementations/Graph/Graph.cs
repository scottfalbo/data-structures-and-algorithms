using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    public class Graph<T>
    {
        public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }
        public int counter = 0;

        public Graph()
        {
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
        }

        /// <summary>
        /// Instatiates a vertex object with the given value and adds it to the graph.
        /// </summary>
        /// <param name="value"> T value </param>
        /// <returns> new Vertex object </returns>
        public Vertex<T> AddVertex(T value)
        {
            Vertex<T> node = new Vertex<T>(value);
            AdjacencyList.Add(node, new List<Edge<T>>());
            counter++;
            return node;
        }

        /// <summary>
        /// Add a directional edge between two vertices
        /// </summary>
        /// <param name="a"> Vertex object source </param>
        /// <param name="b"> Vertex object target </param>
        public Edge<T> AddDirectedEdge(Vertex<T> a, Vertex<T> b)
        {

            Edge < T > newEdge = new Edge<T>
            {
                Weight = 0,
                Vertex = b
            };
            AdjacencyList[a].Add(newEdge);
            return newEdge;
        }

        /// <summary>
        /// Create an undirected edge between two vertices
        /// </summary>
        /// <param name="a"> Vertex object </param>
        /// <param name="b"> Vertex object </param>
        public void AddUndirectedEdge(Vertex<T> a, Vertex<T> b)
        {
            AddDirectedEdge(a, b);
            AddDirectedEdge(b, a);
        }

        /// <summary>
        /// Gets a given vertices neighbors
        /// </summary>
        /// <param name="home"> Vertex vertex </param>
        /// <returns> List of Edges </returns>
        public List<Edge<T>> GetNeighbors(Vertex<T> home) =>
            AdjacencyList[home];

        /// <summary>
        /// Prints the Adjacency list of the graph to consol
        /// </summary>
        public void PrintGraph()
        {
            foreach (var item in AdjacencyList)
            {
                Console.Write($"{item.Key.Value}: ");
                foreach (var edge in item.Value)
                {
                    Console.Write($"{edge.Vertex.Value} ->");
                }
                Console.WriteLine("");
            }
        }

        /// <summary>
        /// Returns a Dictionary object of all of the nodes
        /// </summary>
        /// <returns> Dictionary of Lists </returns>
        public Dictionary<Vertex<T>, List<Edge<T>>> GetNodes()
        {
            if (counter > 0)
                return AdjacencyList;
            else
                return null;
        }
            

        /// <summary>
        /// Returns the size of the graph
        /// </summary>
        /// <returns> counter prop, int value total nodes </returns>
        public int Size() => counter;

        public List<Vertex<T>> BreadthFirst(Vertex<T> vertex)
        {
            List<Vertex<T>> nodes = new List<Vertex<T>>();
            List<Vertex<T>> visited = new List<Vertex<T>>
            {
                vertex
            };

            Queue<Vertex<T>> q = new Queue<Vertex<T>>();
            q.Enqueue(vertex);

            while (q.counter > 0)
            {
                Vertex<T> current = q.Dequeue();
                nodes.Add(current);

                if (AdjacencyList.ContainsKey(current))
                {
                    foreach (var neighbor in AdjacencyList[current].Where(x => !visited.Contains(x.Vertex)))
                    {
                        visited.Add(neighbor.Vertex);
                        q.Enqueue(neighbor.Vertex);
                    }
                }
            }
            return nodes;
        }
    }


}
