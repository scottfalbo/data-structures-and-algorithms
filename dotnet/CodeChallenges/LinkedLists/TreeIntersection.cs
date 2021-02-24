using System;
using System.Collections.Generic;
using System.Text;
using DataStructures;
using DataStructures.Trees;

namespace Challenges
{
    public class TreeIntersection
    {
        /// <summary>
        /// Driver method to call traveral methods
        /// </summary>
        /// <param name="tree1"> binary tree</param>
        /// <param name="tree2"> another binary tree</param>
        /// <returns> list of intersecting values </returns>
        public static List<int> Intersection(BinaryTree<int> tree1, BinaryTree<int> tree2)
        {
            if (tree1.Root == null || tree2.Root == null)
                throw new ArgumentNullException("Null argument");

            HashMap<int> hashMap = HashTableTree1(tree1.Root, new HashMap<int>(1024));
            return CompareTree2(tree2.Root, hashMap, new List<int>());
        }

        /// <summary>
        /// Traverse the first binary tree and put the value of each node into a hashmap
        /// </summary>
        /// <param name="root"> tree1 root node </param>
        /// <param name="hashMap"> new hashmap </param>
        /// <returns></returns>
        public static HashMap<int> HashTableTree1(DataStructures.Trees.Node<int> root, HashMap<int> hashMap)
        {
            hashMap.Set(root.Value, root.Value);
            if (root.Left != null)
                HashTableTree1(root.Left, hashMap);
            if (root.Right != null)
                HashTableTree1(root.Right, hashMap);
            return hashMap;
        }

        /// <summary>
        /// Traverse the second binary tree.  If collision occurs put double value into a list
        /// </summary>
        /// <param name="root"> tree 2 root node </param>
        /// <param name="hashMap"> hashMap with values from tree 1 </param>
        /// <param name="list"> empty list </param>
        /// <returns></returns>
        public static List<int> CompareTree2(DataStructures.Trees.Node<int> root, HashMap<int> hashMap, List<int> list)
        {
            if (hashMap.Contains(root.Value))
                list.Add(root.Value);
            if (root.Left != null)
                CompareTree2(root.Left, hashMap, list);
            if (root.Right != null)
                CompareTree2(root.Right, hashMap, list);
            return list;
        }
    }
}
