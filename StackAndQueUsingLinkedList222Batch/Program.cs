using System;

namespace StackAndQueUsingLinkedList222Batch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue");
            Console.WriteLine("Choose the below option to execute the program\n1:Create a stack of 56->30->70\n2:Peek and Pop from stack\n3:Create a Queue of 56->30->70\n4:Dequeue from begining\n");
            int option=int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CustomisedStack cstack=new CustomisedStack();
                    cstack.Push(70);
                    cstack.Push(30);
                    cstack.Push(56);
                    cstack.Display();
                    break;
                case 2:
                    CustomisedStack customisedStack=new CustomisedStack();
                    customisedStack.Push(70);
                    customisedStack.Push(30);
                    customisedStack.Push(56);
                    customisedStack.Display();
                    customisedStack.Peek();
                    customisedStack.Pop();
                    customisedStack.IsEmpty();
                    break;
                case 3:
                    CustomisedQueue customisedQueue=new CustomisedQueue();
                    customisedQueue.Enqueue(56);
                    customisedQueue.Enqueue(30);
                    customisedQueue.Enqueue(70);
                    customisedQueue.Display();
                    break;
                case 4:
                    CustomisedQueue customisedQueue1 = new CustomisedQueue();
                    customisedQueue1.Enqueue(56);
                    customisedQueue1.Enqueue(30);
                    customisedQueue1.Enqueue(70);
                    customisedQueue1.Display();
                    customisedQueue1.Dequeu();
                    customisedQueue1.Display();
                    customisedQueue1.Dequeu();
                    customisedQueue1.Display();
                    break;
                default:
                    break;
            }
        }
    }
}
