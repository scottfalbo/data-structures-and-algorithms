﻿using DataStructures;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace DataStructuresTests
{
    public class HashMapTests
    {
        [Fact]
        public void Add_A_Value_To_Hash_Map_And_Prove_Its_There()
        {
            HashMap<string> testMap = PopulatedHashMap();
            Assert.True(testMap.Contains("Ethel"));
        }

        [Fact]
        public void Retrieve_The_Correct_Item_Based_On_Key()
        {
            HashMap<string> testMap = PopulatedHashMap();
            var actual = testMap.Get("Spaceghost");
            string expected = "More like SpaceLoaf";
            Assert.Equal(expected, actual.Value.Value);
        }

        [Fact]
        public void Successfully_Return_Null_If_Key_Does_Not_Exist_In_Hash_Map()
        {
            HashMap<string> testMap = PopulatedHashMap();
            Assert.Null(testMap.Get("ManBearPig"));
        }

        [Fact]
        public void Successfully_Handle_Colision_Within_The_Hash_Map()
        {
            HashMap<string> testMap = PopulatedHashMap();
            testMap.Set("lehtE", "Colision is a happening");
            int index = testMap.Hash("lehtE");
            int actual = testMap.Map[index].counter;
            int expected = 2;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Successfully_Retrieve_A_Value_From_A_Bucket_With_Colision()
        {
            HashMap<string> testMap = PopulatedHashMap();
            testMap.Set("lehtE", "Colision is a happening");
            var actual = testMap.Get("Ethel");
            string expected = "The boss";
            Assert.Equal(expected, actual.Value.Value);
        }

        [Fact]
        public void Successfully_Hash_A_Key_To_An_In_Range_Value()
        {
            HashMap<string> testMap = new HashMap<string>(1024);
            int actual = testMap.Hash("Spaceghost");
            int expected = 565;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Successfully_Remove_A_Key_And_Value_From_A_HashMap()
        {
            HashMap<string> testMap = PopulatedHashMap();
            testMap.Remove("Spaceghost");
            Assert.Null(testMap.Get("Spaceghost"));
        }

        [Fact]
        public void Successfully_Remove_A_Key_Pair_Value_From_A_Bucket_With_Colision()
        {
            HashMap<string> testMap = PopulatedHashMap();
            testMap.Set("arHry", "Making some colisions");
            testMap.Set("arrHy", "Making some colisions");
            testMap.Set("rarHy", "Delete me");
            testMap.Set("rHrya", "Making some colisions");

            testMap.Remove("rarHy");
            int index = testMap.Hash("Harry");

            Assert.Equal(4, testMap.Map[index].counter);
        }

        /// <summary>
        /// Helper method to instantiate and populate a HashMap object
        /// </summary>
        /// <returns> Populated HashMap() </returns>
        private HashMap<string> PopulatedHashMap()
        {
            HashMap<string> newHashMap = new HashMap<string>(1024);

            newHashMap.Set("Spaceghost", "More like SpaceLoaf");
            newHashMap.Set("Harry", "Handsome monkey boy");
            newHashMap.Set("Lucipurr", "She's so sweet");
            newHashMap.Set("Ethel", "The boss");

            return newHashMap;
        }
    }
}
