using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsAndAlgorithm
{
    internal class LinkedListStack<T>
    {
        private Node<T> top;
        public LinkedListStack()
        {
            this.top = null;
        }
        internal void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack", value);
        }
        internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine("\n{0} is in the top of the Stack", this.top.data);
        }
        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty,Deletion is not possible");
                return;
            }
            Console.WriteLine("Value Popped is {0}", this.top.data);
            this.top = this.top.next;
        }
        internal void Display()
        {
            Node<T> temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}