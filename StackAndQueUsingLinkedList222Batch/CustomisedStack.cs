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
        //defining a global Node "top"
        private Node top;
        public CustomisedStack()                //initializing top to null using constructor
        {
            this.top = null;
        }
        //Push method is used for adding values to stack
        internal void Push(int value)
        {
            Node node = new Node(value);         //new Node "node" of value is created
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} pushed to stack ", value);
        }
        //Peek method returns the top value of the stack
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the top of the stack ", this.top.data);
        }
        //Pop method is used to delete the values from stack
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty, Deletion is not possible");
                return;
            }
            Console.WriteLine("Value popped is {0} ", this.top.data);
            this.top = this.top.next;
        }
        //Display method is used to display the values of stack
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
        //IsEmpty method checks whether the stack is empty or not
        public void IsEmpty()
        {
            bool flag = false;
            if (this.top == null)
            {
                flag = true;
            }
            else
            {
                while (this.top != null)
                {
                    Peek();
                    Pop();
                }
            }
            Console.WriteLine("isEmpty : "+flag); 
        }
    }
}
