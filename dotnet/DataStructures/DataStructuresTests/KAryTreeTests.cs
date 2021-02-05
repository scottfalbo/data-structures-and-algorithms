using DataStructures.Trees;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructuresTests
{
    public class KAryTreeTests
    {

        [Fact]
        public void Can_Populate_A_Fizz_Buzz_Tree_And_Sort_Breadth_First()
        {
            KAryTree<int> testTree = PopulateTestTree();
            List<int> actual = testTree.BreadthFirst();
            List<int> expected = new List<int>() { 3, 4, 5, 15, 7, 13, 30, 10, 3, 8, 6 };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Can_Perform_PreOrder_Traversal_And_Return_List()
        {
            KAryTree<int> testTree = PopulateTestTree();
            List<int> actual = testTree.PreOrder();
            List<int> expected = new List<int>() { 3, 4, 7, 13, 30, 5, 10, 15, 3, 8, 6 };
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Helper method to build a tree to run fizz buzz on
        /// </summary>
        /// <returns></returns>
        private KAryTree<int> PopulateTestTree()
        {
            // last leaves
            KNode<int> n1 = new KNode<int>(7);
            KNode<int> n2 = new KNode<int>(13);
            KNode<int> n3 = new KNode<int>(30);
            KNode<int> n4 = new KNode<int>(10);
            KNode<int> n5 = new KNode<int>(3);
            KNode<int> n6 = new KNode<int>(8);
            KNode<int> n7 = new KNode<int>(6);

            // middle tier
            List<KNode<int>> children = new List<KNode<int>>() { n1, n2, n3 };
            KNode<int> n8 = new KNode<int>(4, children);

            children = new List<KNode<int>>() { n4 };
            KNode<int> n9 = new KNode<int>(5, children);

            children = new List<KNode<int>>() { n5, n6, n7 };
            KNode<int> n10 = new KNode<int>(15, children);

            //root
            children = new List<KNode<int>>() { n8, n9, n10 };
            KNode<int> n11 = new KNode<int>(3, children);

            KAryTree<int> newTree = new KAryTree<int>(3);
            newTree.Root = n11;

            return newTree;
        }
    }
}
