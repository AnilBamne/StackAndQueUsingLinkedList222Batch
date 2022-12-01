using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueUsingLinkedList222Batch
{
    public class CustomisedQueue
    {
        //globally deefining Node and initializing "head" as null.
        Node head = null;
        //Enqueue method is used to add elements to queue
        public void Enqueue(int data)           //UC3:Enqueue method
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                //node.next = head;
            }
            Console.WriteLine("{0} inserted into queue ", node.data);
        }
        //Display method is used to display the queue elements.
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)                        //Iterating and printing elements
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
