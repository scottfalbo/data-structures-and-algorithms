using System;
using System.Collections.Generic;
using System.Text;
using DataStructures;

namespace Challenges
{
    public class LeftJoin
    {
        //traverse first hashmap
            // if key is in second put both into a thing
        //return the thing
        public static List<ReturnObject> Join (HashMap<string> hash1, HashMap<string> hash2)
        {
            if (hash1 == null || hash2 == null)
                throw new ArgumentNullException("null argument given");
            if (hash1.counter == 0)
                throw new ArgumentException("leftTable has no key/value pairs");

            return Traverse(hash1, hash2);
        }

        public static List<ReturnObject> Traverse (HashMap<string> hash1, HashMap<string> hash2)
        {
            List<ReturnObject> list = new List<ReturnObject>();
            
            for (int i = 0; i < hash1.Map.Length; i++)
            {
                if (hash1.Map != null)
                {
                    Node<KeyValuePair<string, string>> current = hash1.Map[i].Head;
                    while (current != null)
                    {
                        if (hash2.Contains(current.Value.Key))
                        {
                            var rightValue = hash2.Get(current.Value.Key);
                            string value = rightValue.ToString();

                            ReturnObject holder = new ReturnObject(
                                current.Value.Key, current.Value.Value,
                                value);
                            list.Add(holder);
                        }
                        else
                        {
                            ReturnObject holder = new ReturnObject(
                                current.Value.Key, current.Value.Value,
                                null);
                            list.Add(holder);
                        }
                        current = current.Next;
                    }
                    return list;
                }
            }
            return list;
        }

    }

    /// <summary>
    /// Object to hold the left tables key, value pair, and the right tables value : null
    /// </summary>
    public class ReturnObject
    {
        public string Key { get; set; }
        public string LeftValue { get; set; }
        public string RightValue { get; set; }

        public ReturnObject (string key, string leftValue, string rightValue)
        {
            Key = key;
            LeftValue = leftValue;
            RightValue = rightValue;
        }
    }

}
