using System;
using System.Collections.Generic;
using DataStructures;
using DataStructures.Trees;

namespace Challenges
{
    public class Program
    {
        static void Main(string[] args)
        {

            HashMap<string> left = LeftTable();
            HashMap<string> right = RightTable();
            List<ReturnObject> list = LeftJoin.Join(left, right);
            List<string> actual = ObjectListToString(list);
            foreach (string word in actual)
            {
                Console.WriteLine($"{word}, ");
            }

        }

        private static List<string> ObjectListToString(List<ReturnObject> objectList)
        {
            List<string> newList = new List<string>();
            foreach (ReturnObject item in objectList)
            {
                newList.Add(item.Key);
                newList.Add(item.LeftValue);
                newList.Add(item.RightValue);
            }
            return newList;
        }
        private static HashMap<string> LeftTable()
        {
            HashMap<string> leftTable = new HashMap<string>(1024);
            leftTable.Set("fond", "enamored");
            leftTable.Set("wrath", "anger");
            leftTable.Set("diligent", "employed");
            leftTable.Set("outfit", "garb");
            leftTable.Set("guide", "usher");
            return leftTable;
        }
        private static HashMap<string> RightTable()
        {
            HashMap<string> rightTable = new HashMap<string>(1024);
            rightTable.Set("fond", "averse");
            rightTable.Set("wrath", "delight");
            rightTable.Set("diligent", "idle");
            rightTable.Set("guide", "follow");
            rightTable.Set("flow", "jam");
            return rightTable;
        }
    }
}
