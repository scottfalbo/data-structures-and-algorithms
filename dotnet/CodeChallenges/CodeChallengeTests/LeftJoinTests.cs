using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DataStructures;
using Challenges;

namespace CodeChallengeTests
{
    public class LeftJoinTests
    {
        [Fact]
        public void Successfully_Left_Join_The_Shared_Keys_Of_Two_HashMaps()
        {
            HashMap<string> leftTable = LeftTable();
            HashMap<string> rightTable = RightTable();
            List<ReturnObject> list = LeftJoin.Join(leftTable, rightTable);
            List<string> actual = ObjectListToString(list);
            List<string> expected = new List<string>() { 
                "fond", "enamored", "averse", "wrath", "anger", "delight", "diligent",
                "emplyed", "idle", "outfit", "garb", null, "guide", "usher", "follow" };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Throw_Exception_If_Left_Table_Is_Empty()
        {
            HashMap<string> leftTable = new HashMap<string>(1024);
            HashMap<string> rightTable = RightTable();

            Assert.Throws<ArgumentException>(() =>
                LeftJoin.Join(leftTable, rightTable));
        }

        private List<string> ObjectListToString(List<ReturnObject> objectList)
        {
            List<string> newList = new List<string>();
            foreach (ReturnObject item in objectList){
                newList.Add(item.Key);
                newList.Add(item.LeftValue);
                newList.Add(item.RightValue);
            }
            return newList;
        }

        private HashMap<string> LeftTable()
        {
            HashMap<string> leftTable = new HashMap<string>(1024);
            leftTable.Set("fond", "enamored");
            leftTable.Set("wrath", "anger");
            leftTable.Set("diligent", "employed");
            leftTable.Set("outfit", "garb");
            leftTable.Set("guide", "usher");
            return leftTable;
        }
        private HashMap<string> RightTable()
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
