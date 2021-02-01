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
            char[] result = testTree.PreOrder();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Can_Transverse_A_Binary_Tree_InOrder()
        {
            BinaryTree<char> testTree = PopulateBinaryTree();
            char[] expected = new char[6] { 'D', 'B', 'E', 'A', 'F', 'C' };
            char[] result = testTree.InOrder();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Can_Transverse_A_Binary_Tree_In_PostOrder()
        {
            BinaryTree<char> testTree = PopulateBinaryTree();
            char[] expected = new char[6] { 'D', 'E', 'B', 'F', 'C', 'A' };
            char[] result = testTree.PostOrder();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Can_Add_Node_To_Binary_Search_Tree_In_Proper_Spot()
        {
            BinarySearchTree<int> testTree = PopulateBinarySearchTree();
            int[] testValues = testTree.PreOrder();
            int[] expected = new int[] { 9, 4, 3, 6, 5, 7, 17, 22, 20 };
            Assert.Equal(expected, testValues);
        }

        /// <summary>
        /// Helper method to create and populate a Binary Search Tree
        /// input <-- 9, 4, 17, 3, 6, 22, 5, 7, 20
        /// </summary>
        /// <returns> populated Binary Search Tree Object </returns>
        private BinarySearchTree<int> PopulateBinarySearchTree()
        {
            BinarySearchTree<int> newTree = new BinarySearchTree<int>();
            newTree.Add(newTree.Root, 9);
            newTree.Add(newTree.Root, 4);
            newTree.Add(newTree.Root, 17);
            newTree.Add(newTree.Root, 3);
            newTree.Add(newTree.Root, 6);
            newTree.Add(newTree.Root, 22);
            newTree.Add(newTree.Root, 5);
            newTree.Add(newTree.Root, 7);
            newTree.Add(newTree.Root, 20);
            return newTree;
        }

        /// <summary>
        /// Helper function to populate a BinaryTree object
        /// </summary>
        /// <returns> BinaryTree object </returns>
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
