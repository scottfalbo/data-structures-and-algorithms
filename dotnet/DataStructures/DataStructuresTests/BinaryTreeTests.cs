using System;
using System.Text;
using Xunit;
using DataStructures;
using DataStructures.Trees;


namespace DataStructuresTests
{
    public class BinaryTreeTests
    {
        [Fact]
        public void Can_Transverse_A_Binary_Tree_In_PreOrder()
        {
            BinaryTree<char> testTree = PopulateBinaryTree();
            char[] expected = new char[6] { 'A', 'B', 'D', 'E', 'C', 'F' };
            char[] result = testTree.PreOrder(testTree.Root);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Can_Transverse_A_Binary_Tree_InOrder()
        {
            BinaryTree<char> testTree = PopulateBinaryTree();
            char[] expected = new char[6] { 'D', 'B', 'E', 'A', 'F', 'C' };
            char[] result = testTree.InOrder(testTree.Root);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Can_Transverse_A_Binary_Tree_In_PostOrder()
        {
            BinaryTree<char> testTree = PopulateBinaryTree();
            char[] expected = new char[6] { 'D', 'E', 'B', 'F', 'C', 'A' };
            char[] result = testTree.PostOrder(testTree.Root);
            Assert.Equal(expected, result);
        }

        private BinaryTree<char> PopulateBinaryTree()
        {
            BinaryTree<char> newTree = new BinaryTree<char>();

            DataStructures.Trees.Node<char> nodeA = new DataStructures.Trees.Node<char>('A');
            DataStructures.Trees.Node<char> nodeB = new DataStructures.Trees.Node<char>('B');
            DataStructures.Trees.Node<char> nodeC = new DataStructures.Trees.Node<char>('C');
            DataStructures.Trees.Node<char> nodeD = new DataStructures.Trees.Node<char>('D');
            DataStructures.Trees.Node<char> nodeE = new DataStructures.Trees.Node<char>('E');
            DataStructures.Trees.Node<char> nodeF = new DataStructures.Trees.Node<char>('F');

            nodeA.Left = nodeB;
            nodeA.Right = nodeC;
            nodeB.Left = nodeD;
            nodeB.Right = nodeE;
            nodeC.Left = nodeF;

            newTree.Root = nodeA;
            return newTree;
        }
    }
}
