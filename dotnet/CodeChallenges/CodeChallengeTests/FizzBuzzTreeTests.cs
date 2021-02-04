using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DataStructures;
using DataStructures.Trees;

namespace CodeChallengeTests
{
    public class FizzBuzzTreeTests
    {

        [Fact]
        public void Can_Populate_A_Fizz_Buzz_Tree()
        {
            KAryTree<int> testTree = MakeFizzTree();
            List<int> results = testTree.BreadthFirst();
            List<int> expected = new List<int>() { 3, 4, 5, 15, 7, 13, 30, 10, 3, 8, 6 };
            Assert.Equal(expected, results);
        }

        /// <summary>
        /// Helper method to build a tree to run fizz buzz on
        /// </summary>
        /// <returns></returns>
        private KAryTree<int> MakeFizzTree()
        {
            // last leaves
            KNode<int> n1 = new KNode<int>(7);
            KNode<int> n2 = new KNode<int>(13);
            KNode<int> n3 = new KNode<int>(30);
            KNode<int> n4 = new KNode<int>(10);
            KNode<int> n5 = new KNode<int>(3);
            KNode<int> n6 = new KNode<int>(8);
            KNode<int> n7 = new KNode<int>(8);

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
