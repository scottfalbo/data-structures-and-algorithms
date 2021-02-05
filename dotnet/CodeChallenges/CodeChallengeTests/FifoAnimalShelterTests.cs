using System;
using Xunit;
using Challenges;
using DataStructures;

namespace CodeChallengeTests
{
    public class FifoAnimalShelterTests
    {
        [Fact]
        public void Can_Enqueue_An_Animal()
        {
            FifoAnimalShelter Paws = new FifoAnimalShelter();
            Cat Spaceghost = new Cat("Spaceghost", "cat");
            Paws.Enqueue(Spaceghost);
            Animal getName = Paws.AnimalList.Peek();
            Assert.Equal("Spaceghost", getName.Name);
        }

        [Fact]
        public void Can_Enqueue_Multiple_Animal_Objects()
        {
            FifoAnimalShelter Paws = new FifoAnimalShelter();
            Cat Spaceghost = new Cat("Spaceghost", "cat");
            Cat Harry = new Cat("Harry", "cat");
            Cat Lucipurr = new Cat("Lucipurr", "cat");
            Cat Ethel = new Cat("Ethel", "cat");
            Paws.Enqueue(Spaceghost);
            Paws.Enqueue(Harry);
            Paws.Enqueue(Lucipurr);
            Paws.Enqueue(Ethel);
            Assert.Equal(4, Paws.AnimalList.counter);
        }

        [Fact]
        public void Can_Dequeue_The_First_Dog_In_The_Line()
        {
            FifoAnimalShelter Paws = new FifoAnimalShelter();
            Dog Pickles = new Dog("Pickles", "dog");
            Cat Lucipurr = new Cat("Lucipurr", "cat");
            Cat Ethel = new Cat("Ethel", "cat");
            Dog Apple = new Dog("Apple", "dog");
            Paws.Enqueue(Pickles);
            Paws.Enqueue(Lucipurr);
            Paws.Enqueue(Ethel);
            Paws.Enqueue(Apple);
            Animal result = Paws.Dequeue("dog");
            string name = result.Name;
            Assert.Equal("Pickles", name);
        }

        [Fact]
        public void Cats_Only_we_Have_No_Dogs()
        {
            FifoAnimalShelter Paws = new FifoAnimalShelter();
            Cat Spaceghost = new Cat("Spaceghost", "cat");
            Cat Harry = new Cat("Harry", "cat");
            Cat Lucipurr = new Cat("Lucipurr", "cat");
            Cat Ethel = new Cat("Ethel", "cat");
            Paws.Enqueue(Spaceghost);
            Paws.Enqueue(Harry);
            Paws.Enqueue(Lucipurr);
            Paws.Enqueue(Ethel);
            Assert.Throws<ArgumentOutOfRangeException>(() => Paws.Dequeue("dog"));
        }
    }
}
