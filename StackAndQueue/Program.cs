using System;
namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedListStack linkedListStack = new LinkedListStack();
            //linkedListStack.Push(70);
            //linkedListStack.Push(30);
            //linkedListStack.Push(56);
            //linkedListStack.Display();
            //linkedListStack.IsEmpty();
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            Console.WriteLine("Please enter: 1 if you want to add element into the dequeue from the front, and 2 if you want to add element from the back");
            string input = Console.ReadLine();
            int choice = Convert.ToInt32(input);
            linkedListQueue.Enqueue(56, choice);
            linkedListQueue.Enqueue(30, choice);
            linkedListQueue.Enqueue(70, choice);
            linkedListQueue.Display();
            Console.ReadKey();
        }
    }
}
