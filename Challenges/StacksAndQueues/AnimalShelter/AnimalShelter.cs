using System;
using System.Text;
using DataStructures.Queue;

namespace Challenges.StacksAndQueues.AnimalShelter
{
    public class AnimalShelter<T>
    {

        private Node front;
        private Node rear;

        public void ArriveAtShelter<TAnimal>(T animal)
            where TAnimal : Animal
        {
            Node newRearNode = new Node(animal);

            if (rear == null)
            {
                front = rear = newRearNode;
            }

            rear.Next = newRearNode;
            rear = newRearNode;
        }

        public T Peek()
        {
            if (front == null)
                throw new QueueEmptyException();

            return front.Value;
        }

        public class Node
        {

            public Node(T value)
            {
                Value = value;
                Next = null;
            }

            public Node Next { get; set; }
            public T Value { get; set; }
        }
    }
}
