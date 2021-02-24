using System;
using System.Text;
using Xunit;
using DataStructures;
using Challenges;
using DataStructures.Trees;
using System.Collections.Generic;

namespace CodeChallengeTests
{
    public class TreeIntersectionTests
    {
        [Fact]
        public void Successfully_Find_Intersecting_Values_Between_Two_Trees()
        {
            BinaryTree<int> testTree1 = MakeBinaryTestTree(
                new int[] { 150, 100, 250, 75, 160, 200, 350, 125, 175, 300, 500 });
            BinaryTree<int> testTree2 = MakeBinaryTestTree(
                new int[] { 42, 100, 600, 15, 160, 200, 350, 125, 175, 4, 500 });
            List<int> testList = TreeIntersection.Intersection(testTree1, testTree2);
            int[] actual = testList.ToArray();
            int[] expected = new int[] { 100, 160, 125, 175, 200, 350, 500 };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HashTableTree1_Method__Successfully_Populates_A_HashMap()
        {
            BinaryTree<int> testTree = MakeBinaryTestTree(
                new int[] { 150, 100, 250, 75, 160, 200, 350, 125, 175, 300, 500 });
            HashMap<int> testHashMap = TreeIntersection.HashTableTree1(testTree.Root, 
                new HashMap<int>(1024));
            int actual = testHashMap.counter;
            int expected = 11;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CompareTree2_Can_Successfully_Return_A_List_Of_Collisions()
        {
            BinaryTree<int> testTree = MakeBinaryTestTree(
                new int[] { 150, 100, 250, 75, 160, 200, 350, 125, 175, 300, 500 });
            HashMap<int> testHashMap = new HashMap<int>(1024);
            testHashMap.Set(160, 160);
            testHashMap.Set(150, 150);
            List<int> testList = TreeIntersection.CompareTree2(
                testTree.Root, testHashMap, new List<int>());
            int[] actual = testList.ToArray();
            int[] expected = new int[] { 150, 160 };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Successfully_Throw_Null_Arguement_Exception_If_Tree_Is_Empty()
        {
            BinaryTree<int> testTree = MakeBinaryTestTree(
                new int[] { 150, 100, 250, 75, 160, 200, 350, 125, 175, 300, 500 });
            BinaryTree<int> testTree2 = new BinaryTree<int>();
            Assert.Throws<ArgumentNullException>(()=> TreeIntersection.Intersection(testTree, testTree2));
        }

        /// <summary>
        /// Helper method to build binary trees for testing
        /// </summary>
        /// <param name="n"> array of integer values</param>
        /// <returns> populated binary tree </returns>
        private BinaryTree<int> MakeBinaryTestTree(int[] n)
        {
            BinaryTree<int> newTree = new BinaryTree<int>();
            DataStructures.Trees.Node<int> node1 = new DataStructures.Trees.Node<int>(n[0]);
            DataStructures.Trees.Node<int> node2 = new DataStructures.Trees.Node<int>(n[1]);
            DataStructures.Trees.Node<int> node3 = new DataStructures.Trees.Node<int>(n[2]);
            DataStructures.Trees.Node<int> node4 = new DataStructures.Trees.Node<int>(n[3]);
            DataStructures.Trees.Node<int> node5 = new DataStructures.Trees.Node<int>(n[4]);
            DataStructures.Trees.Node<int> node6 = new DataStructures.Trees.Node<int>(n[5]);
            DataStructures.Trees.Node<int> node7 = new DataStructures.Trees.Node<int>(n[6]);
            DataStructures.Trees.Node<int> node8 = new DataStructures.Trees.Node<int>(n[7]);
            DataStructures.Trees.Node<int> node9 = new DataStructures.Trees.Node<int>(n[8]);
            DataStructures.Trees.Node<int> node10 = new DataStructures.Trees.Node<int>(n[9]);
            DataStructures.Trees.Node<int> node11 = new DataStructures.Trees.Node<int>(n[10]);
            node1.Left = node2;
            node1.Right = node3;
            node2.Left = node4;
            node2.Right = node5;
            node3.Left = node6;
            node3.Right = node7;
            node5.Left = node8;
            node5.Right = node9;
            node7.Left = node10;
            node7.Right = node11;
            newTree.Root = node1;
            return newTree;
        }

    }
}
