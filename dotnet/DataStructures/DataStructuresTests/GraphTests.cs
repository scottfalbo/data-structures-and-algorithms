using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DataStructures;

namespace DataStructuresTests
{
    public class GraphTests
    {
        [Fact]
        public void Node_Can_Successfully_Be_Added_To_Graph()
        {
            Graph<int> testGraph = new Graph<int>();
            testGraph.AddVertex(6);

            int actual = testGraph.counter;
            int expected = 1;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void An_Edge_Can_Successfully_Be_Added_To_The_Graph()
        {
            Graph<int> testGraph = new Graph<int>();
            Vertex<int> nodeA = testGraph.AddVertex(6);
            Vertex<int> nodeB = testGraph.AddVertex(3);
            testGraph.AddUndirectedEdge(nodeA, nodeB);
            List<Edge<int>> testEdge = testGraph.GetNeighbors(nodeA);
            Vertex<int> actual = testEdge[0].Vertex;
            Vertex<int> expected = nodeB;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Collection_Of_Nodes_Can_Be_Retrieved()
        {
            Graph<int> testGraph = PopulateGraph();
            var actual = testGraph.GetNodes();
            var expected = testGraph.AdjacencyList;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Can_Retrieve_A_Vertices_Neighbors()
        {
            Graph<int> testGraph = PopulateGraph();
            Vertex<int> testNodeA = testGraph.AddVertex(11);
            Vertex<int> testNodeB = testGraph.AddVertex(12);
            Vertex<int> testNodeC = testGraph.AddVertex(3);
            Edge<int> edgeB = testGraph.AddDirectedEdge(testNodeA, testNodeB);
            Edge<int> edgeC = testGraph.AddDirectedEdge(testNodeA, testNodeC);

            List<Edge<int>> actual = testGraph.GetNeighbors(testNodeA);
            List<Edge<int>> expected = new List<Edge<int>>();
            expected.Add(edgeB);
            expected.Add(edgeC);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Can_Return_The_Total_Count_Of_Vertices_In_The_Graph()
        {
            Graph<int> testGraph = PopulateGraph();

            int actual = testGraph.counter;
            int expected = 6;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void An_Empty_Graph_Properly_Returns_Null()
        {
            Graph<int> testGraph = new Graph<int>();
            Assert.Null(testGraph.GetNodes());
        }

        [Fact]


        public Graph<int> PopulateGraph()
        {
            Graph<int> testGraph = new Graph<int>();
            Vertex<int> nodeA = testGraph.AddVertex(6);
            Vertex<int> nodeB = testGraph.AddVertex(3);
            Vertex<int> nodeC = testGraph.AddVertex(5);
            Vertex<int> nodeD = testGraph.AddVertex(9);
            Vertex<int> nodeE = testGraph.AddVertex(1);
            Vertex<int> nodeF = testGraph.AddVertex(4);
            testGraph.AddUndirectedEdge(nodeA, nodeB);
            testGraph.AddUndirectedEdge(nodeB, nodeC);
            testGraph.AddUndirectedEdge(nodeA, nodeD);
            testGraph.AddUndirectedEdge(nodeD, nodeF);
            testGraph.AddUndirectedEdge(nodeE, nodeA);
            return testGraph;
        }
    }
}
