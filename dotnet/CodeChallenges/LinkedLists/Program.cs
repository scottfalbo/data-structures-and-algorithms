using System;
using DataStructures;

namespace Challenges
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            FifoAnimalShelter Paws = new FifoAnimalShelter();
            Dog Pickles = new Dog("Pickles", "dog");
            Cat Lucipurr = new Cat("Lucipurr", "cat");
            Cat Ethel = new Cat("Ethel", "cat");
            Dog Apple = new Dog("Apple", "dog");
            Paws.Enqueue(Pickles);
            Paws.Enqueue(Lucipurr);
            Paws.Enqueue(Ethel);
            Paws.Enqueue(Apple);
            //Animal result = Paws.Dequeue("dog");
            //string name = result.Name;
            while (!Paws.AnimalList.IsEmpty())
            {
                Console.WriteLine(Paws.AnimalList.Front.Value.Name);
                Paws.AnimalList.Dequeue();
            }
                
            //Console.WriteLine(name);
            */
        }

        public static bool BracketValidation(string input) => 
            MultiBracketValidation.Validate(input);

    }
}
