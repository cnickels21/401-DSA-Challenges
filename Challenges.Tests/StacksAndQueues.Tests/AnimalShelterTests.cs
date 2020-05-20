﻿using System;
using System.Text;
using Challenges.StacksAndQueues;
using Challenges.StacksAndQueues.AnimalShelter;
using DataStructures.Queue;
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

        [Fact]
        public void Can_throw_exception_if_queue_is_empty()
        {
            // Arrange
            AnimalShelter<Animal> testQueue = new AnimalShelter<Animal>();

            // Assert
            Assert.Throws<QueueEmptyException>(() =>
            {
                // Act
                testQueue.TakeHome<Dog>();
            });
        }

        [Fact]
        public void Can_dequeue_selected_animal_is_not_at_front()
        {
            // Arrange
            AnimalShelter<Animal> testQueue = new AnimalShelter<Animal>();
            Dog newDog = new Dog();

            testQueue.ArriveAtShelter<Dog>(newDog);
            testQueue.ArriveAtShelter<Dog>(newDog);
            testQueue.ArriveAtShelter<Cat>(newDog);

            // Act
            Animal result = testQueue.TakeHome<Cat>();

            //Assert
            Assert.Equal("cat", actual: result.Type);
        }
    }
}
