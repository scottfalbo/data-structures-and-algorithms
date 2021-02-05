using System;
using System.Text;
using DataStructures;

namespace Challenges
{
    public class FifoAnimalShelter
    {
        public Queue<Animal> AnimalList { get; set; }

        public FifoAnimalShelter()
        {
            AnimalList = new Queue<Animal>();
        }
        /// <summary>
        /// Verify that the object type if that of Cat or Dog.
        /// Then puts the object in the shelter using Queue.Enqueue
        /// </summary>
        /// <param name="animal"> Animal object (Cat or Dog) </param>
        public void Enqueue(Animal animal)
        {
            if (animal is Cat || animal is Dog)
                AnimalList.Enqueue(animal);
            else throw new ArgumentException("This shelter only takes cats and dogs.");     
        }

        /// <summary>
        /// Return the first cat or dog in line based on preference input
        /// </summary>
        /// <param name="pref"> string, "cat" or "dog" </param>
        /// <returns></returns>
        public Animal Dequeue(string pref)
        {
            pref = pref.ToLower();
            if (pref != "cat" && pref != "dog")
                throw new ArgumentException("We only have cats and dogs");

            Queue<Animal> holdingQ = new Queue<Animal>();
            bool foundOne = false;
            Animal adoptMe = new Animal();
            while (!AnimalList.IsEmpty())
            {
                Animal checker = AnimalList.Dequeue();
                if (checker.Type == pref && !foundOne)
                {
                    adoptMe = checker;
                    foundOne = true;
                }
                else if (!AnimalList.IsEmpty())
                    holdingQ.Enqueue(AnimalList.Dequeue());
            }
            AnimalList = holdingQ;

            if (!foundOne)
                throw new ArgumentOutOfRangeException($"Sorry, we have no {pref}s");
            return adoptMe;
        }
    }


    /// <summary>
    /// Animal base class for cats and dogs objects
    /// </summary>
    public class Animal
    {
        public virtual string Name { get; set; }
        public virtual string Type { get; set; }
    }

    /// <summary>
    /// Cat class derived from Animal to create cat objects for the AnimalShelter
    /// </summary>
    public class Cat : Animal
    {
        public override string Name { get; set; }
        public override string Type { get; set; }

        public Cat() { }
        public Cat(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }

    /// <summary>
    /// Dog class derived from Animal to create dog objects for the AnimalShelter
    /// </summary>
    public class Dog : Animal
    {
        public override string Name { get; set; }
        public override string Type { get; set; }

        public Dog () { }
        public Dog(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }

}
