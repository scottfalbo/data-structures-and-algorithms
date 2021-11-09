using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DataStructures.Trees;
using Practice;

namespace PracticeTests
{
    public class BinaryTreePracticeTests
    {
        [Fact]
        public void CanReturnCorrectTotalValue()
        {
            BinaryTree<int> tree = MakeTree();
            int expected = 39;
            int actual = BinaryTreePractice.FindValue(tree);
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Instantiate and popluate a BinaryTree object
        /// </summary>
        /// <returns> BinaryTree<int> tree </returns>
        /*
                        (6)
                       /   \
                     (5)   (8)
                   /      /   \
                 (4)    (7)   (9)
        */
        private BinaryTree<int> MakeTree()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            Node<int> node1 = new Node<int>(6);
            Node<int> node2 = new Node<int>(5);
            Node<int> node3 = new Node<int>(8);
            Node<int> node4 = new Node<int>(4);
            Node<int> node5 = new Node<int>(7);
            Node<int> node6 = new Node<int>(9);
            node1.Left = node2;
            node1.Right = node3;
            node2.Left = node4;
            node3.Left = node5;
            node3.Right = node6;
            tree.Root = node1;
            return tree;
        }
        
    }
}
