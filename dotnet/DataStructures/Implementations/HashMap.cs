using DataStructures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    public class HashMap<T>
    {
        private DataStructures.LinkedList<KeyValuePair<T, T>>[] Map { get; set; }

        public HashMap(int size)
        {
            Map = new DataStructures.LinkedList<KeyValuePair<T, T>>[size];
        }

        private int Hash (T key)
        {
            int hashValue = 0;

            char[] letters = (key.ToString()).ToCharArray();
            for (int i = 0; i < letters.Length; i++)
            {
                hashValue += letters[i];
            }
            hashValue = (hashValue * 999) % Map.Length;

            return hashValue;
        }

        // set a keyvalue pair
        public void Set(T key, T value)
        {
            int hashKey = Hash(key);
            if (Map[hashKey] == null)
            {
                Map[hashKey] = new DataStructures.LinkedList<KeyValuePair<T, T>>();
            }
            KeyValuePair<T, T> entry = new KeyValuePair<T, T>(key, value);

            Map[hashKey].Insert(entry);
        }

        // get a value by key
        public T Get (T key)
        {
            return key;
        }

        // bool, contains the key
        public bool Contains (T key)
        {
            return false;
        }

        // remove a keyvalue pair
        public void Remove (T key)
        {

        }

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
                {
                    Console.WriteLine($"bucket {i}: empty");
                }
            }
        }
    }
}
