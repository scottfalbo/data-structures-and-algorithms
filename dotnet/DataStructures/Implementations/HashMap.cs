using DataStructures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class HashMap<T>
    {
        public DataStructures.LinkedList<KeyValuePair<T, T>>[] Map { get; set; }

        public int counter = 0;

        public HashMap(int size)
        {
            Map = new DataStructures.LinkedList<KeyValuePair<T, T>>[size];
        }

        /// <summary>
        /// Hashes a key into an integer within range of the Map
        /// </summary>
        /// <param name="key"> key value to be hashed </param>
        /// <returns> integer index value </returns>
        public int Hash (T key)
        {
            int hashValue = 0;

            char[] letters = (key.ToString()).ToCharArray();
            for (int i = 0; i < letters.Length; i++)
            {
                hashValue += letters[i];
            }
            hashValue = (hashValue * 997) % Map.Length;

            return hashValue;
        }

        /// <summary>
        /// Puts a key:value pair into a bucket at the hashed index of key
        /// </summary>
        /// <param name="key"> key </param>
        /// <param name="value"> value </param>
        public void Set(T key, T value)
        {
            int hashKey = Hash(key);
            if (Map[hashKey] == null)
            {
                Map[hashKey] = new DataStructures.LinkedList<KeyValuePair<T, T>>();
            }
            KeyValuePair<T, T> entry = new KeyValuePair<T, T>(key, value);

            Map[hashKey].Insert(entry);
            counter++;
        }

        /// <summary>
        /// Retrieve a Node with a KeyPairValue by key, or null of key does not exist.
        /// </summary>
        /// <param name="key"> key value </param>
        /// <returns> Node with Value of KeyPairValue </returns>
        public Node<KeyValuePair<T, T>> Get (T key)
        {
            int index = Hash(key);

            if (!Contains(key))
                return null;
            else
            {
                var bucket = Map[index];
                Node<KeyValuePair<T, T>> current = bucket.Head;
                while (current != null)
                {
                    if (current.Value.Key.Equals(key))
                        return current;
                    current = current.Next;
                }
            }
            throw new Exception("Something has gone amiss");
        }

        /// <summary>
        /// Checks to see if a key is in the HashMap and returns true:false
        /// </summary>
        /// <param name="key"> key value </param>
        /// <returns> true : false</returns>
        public bool Contains (T key)
        {
            for (int i = 0; i < Map.Length; i++)
            {
                if (Map[i] != null)
                {
                    Node<KeyValuePair<T, T>> current = Map[i].Head;
                    while (current != null)
                    {
                        if (current.Value.Key.Equals(key))
                            return true;
                        current = current.Next;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Remove the Node object with the KeyPairValue of key
        /// </summary>
        /// <param name="key"> key value </param>
        public void Remove (T key)
        {
            int index = Hash(key);

            if (Contains(key))
            {
                Node<KeyValuePair<T, T>> current = Map[index].Head;
                while (current != null)
                {
                    if (current.Value.Key.Equals(key))
                    {
                        Map[index].RemoveNode(current.Value);
                        break;
                    }
                    current = current.Next;
                }
                counter--;
            }
        }

        /// <summary>
        /// Print the values of the HashMap to the terminal
        /// </summary>
        public void Print()
        {
            for (int i =0; i < Map.Length; i++)
            {
                if (Map[i] != null)
                {
                    Console.Write($"bucket {i}: ");
                    Node<KeyValuePair<T, T>> current = Map[i].Head;

                    while (current != null)
                    {
                        Console.Write($"[{current.Value.Key} : {current.Value.Value}] => ");
                        current = current.Next;
                    }
                    Console.WriteLine("");
                }
                else
                    Console.WriteLine($"bucket {i}: empty");
            }
        }
    }
}
