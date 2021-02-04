﻿using System;
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
            var temp = testTree.Root.Children[2];
            int result = temp.Children[1].Value;
            int expected = 8;
            Assert.Equal(expected, result);
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