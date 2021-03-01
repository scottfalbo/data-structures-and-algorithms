using System;
using System.Collections.Generic;
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

        public Vertex<T> AddVertex(T value)
        {
            Vertex<T> node = new Vertex<T>(value);
            AdjacencyList.Add(node, new List<Edge<T>>());
            counter++;
            return node;
        }

        public void AddDirectedEdge(Vertex<T> a, Vertex<T> b)
        {
            AdjacencyList[a].Add(
                new Edge<T>
                {
                    Weight = 0,
                    Vertex = b
                });
        }

        public void AddUndirectedEdge(Vertex<T> a, Vertex<T> b)
        {
            AddDirectedEdge(a, b);
            AddDirectedEdge(b, a);
        }

        public List<Edge<T>> GetNeighbors(Vertex<T> home) =>
            AdjacencyList[home];

        public void PrintGraph()
        {
            foreach (var item in AdjacencyList)
            {
                Console.Write($"{item.Value}: ");
                foreach (var edge in item.Value)
                {
                    Console.Write($"{edge.Vertex.Value} ->");
                }
                Console.WriteLine("");
            }
        }

        public void BreadthFirst()
        {
            /*
             * 
             * Extend your graph object with a breadth-first traversal method that accepts a starting node. Without utilizing any of the built-in methods available to your language, return a collection of nodes in the order they were visited. Display the collection.
             */
        }

    }


}
