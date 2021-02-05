using DataStructures.Trees;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges
{
    public class FizzBuzzTree
    {
        public KAryTree<string> FizzBuzzer(KAryTree<int> inputTree)
        {
            KAryTree<string> outputTree = new KAryTree<string>(3);

            KNode<string> outputRoot = new KNode<string>();
            outputTree.Root = outputRoot;
            KNode<int> inputRoot = inputTree.Root;
            Traversal(inputRoot, outputRoot);

            return outputTree;
        }

        private void Traversal(KNode<int> inputRoot, KNode<string> outputRoot)
        {
            if (inputRoot.Value % 15 == 0)
                outputRoot.Value = "Fizzbuzz";
            else if (inputRoot.Value % 5 == 0)
                outputRoot.Value = "Buzz";
            else if (inputRoot.Value % 3 == 0)
                outputRoot.Value = "Fizz";
            else
                outputRoot.Value = inputRoot.Value.ToString();

            if (inputRoot.Children != null)
            {
                foreach (var child in inputRoot.Children)
                {
                    KNode<string> newNode = new KNode<string>("");
                    outputRoot.Children.Add(newNode);
                    Traversal(child, newNode);
                }
 
            }
        }
    }
}
