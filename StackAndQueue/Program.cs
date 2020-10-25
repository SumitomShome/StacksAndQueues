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
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();
            Console.ReadKey();
        }
    }
}
