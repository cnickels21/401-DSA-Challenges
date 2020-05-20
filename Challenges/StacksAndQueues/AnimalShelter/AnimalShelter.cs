using System;
using System.Text;
using DataStructures.Queue;

namespace Challenges.StacksAndQueues.AnimalShelter
{
    public class AnimalShelter<T>
    {

        private Node front;
        private Node rear;

        // This is my enqueue method
        public void ArriveAtShelter(T animal)
        {
            Node newRearNode = new Node(animal);

            if (rear == null)
            {
                front = rear = newRearNode;
            }

            rear.Next = newRearNode;
            rear = newRearNode;
        }

        // This is my dequeue method
        public TAnimal TakeHome<TAnimal>()
            where TAnimal : Animal
        {
            if (front == null)
                throw new QueueEmptyException();

            while (front != null)
            {
                if (front.Value is TAnimal animal)
                {
                    front = front.Next;

                    if (front == null)
                        rear = null;

                    return animal;
                }
                else
                {
                    front = front.Next;
                }
            }
            
            return null;
            
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
