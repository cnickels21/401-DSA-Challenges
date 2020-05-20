using System;
using System.Text;
using Challenges.StacksAndQueues;
using Challenges.StacksAndQueues.AnimalShelter;
using Xunit;

namespace Challenges.Tests.StacksAndQueues.Tests
{
    public class AnimalShelterTests
    {

        [Fact]
        public void Can_put_animals_into_shelter()
        {
            // Arrange
            AnimalShelter<Animal> testQueue = new AnimalShelter<Animal>();
            Dog newDog = new Dog();

            // Act
            testQueue.ArriveAtShelter<Dog>(newDog);

            Animal result = testQueue.Peek();

            //Assert
            Assert.Equal("dog", result.Type);
        }

        [Fact]
        public void Can_dequeue_selected_animal_is_at_front_node()
        {
            // Arrange
            AnimalShelter<Animal> testQueue = new AnimalShelter<Animal>();
            Dog newDog = new Dog();

            testQueue.ArriveAtShelter<Dog>(newDog);
            testQueue.ArriveAtShelter<Dog>(newDog);

            // Act
            Animal result = testQueue.TakeHome<Dog>();

            //Assert
            Assert.Equal("dog", result.Type);
        }
    }
}
