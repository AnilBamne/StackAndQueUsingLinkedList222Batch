using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StackAndQueUsingLinkedList222Batch
{
    public class CustomisedStack
    {
        private Node top;
        public CustomisedStack()
        {
            this.top = null;
        }
        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} pushed to stack ", value);
        }
        public void Display()
        {
            Node temp = this.top;
            Console.WriteLine("Values in stack are : ");
            while (temp != null)
            {
                Console.Write(temp.data + " "); //56 30 70 
                temp = temp.next;
            }
        }
    }
}
