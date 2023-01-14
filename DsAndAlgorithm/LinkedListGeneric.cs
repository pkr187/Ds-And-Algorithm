using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsAndAlgorithm
{
    internal class LinkedListGenerics<T> where T : IComparable<T>
    {
        public Node<T> head;
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        internal void AddInReverseOrder(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node<T> temp = this.head;
                head = newNode;
                head.next = temp;
            }
        }
        public void Appending(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<T> node1 = head;
                while (node1.next != null)
                {
                    node1 = node1.next;
                }
                node1.next = node;
            }
            Console.WriteLine("{0} appended into linked list", node.data);
        }
        public Node<T> InsertAtRequiredPosition(int position, T data)
        {
            Node<T> node = new Node<T>(data);
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node<T> temp = head;
                while (position > 2)
                {
                    temp = temp.next;
                    position--;
                }
                node.next = temp.next;
                temp.next = node;
            }
            Console.WriteLine("{0} Insert At Required Position into linked list", node.data);
            return head;
        }
        public Node<T> DeletingFirstPosition()
        {
            Node<T> node = head;
            if (head == null)
            {
                Console.WriteLine("Linked List is empty: ");
            }
            else
            {
                head = head.next;
            }
            Console.WriteLine("{0} is the Deleted first Position element from linked list", node.data);
            return node;
        }
        public void DeletingLastPosition()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            else
            {
                Node<T> n = head;
                while (n.next.next != null)
                {
                    n = n.next;
                }
                Node<T> removeNode = n.next;
                n.next = null;
                Console.WriteLine("{0} is the Deleted Last Position element from linked list", removeNode.data);
            }
        }
        public int Search(T data)
        {
            int count = 1;
            Node<T> temp = head;
            if (this.head == null)
            {
                return 0;
            }
            while (temp != null)
            {
                if (temp.data.Equals(data))
                {
                    Console.WriteLine("{0} is the available in linked list", temp.data);
                    return count;
                }
                temp = temp.next;
                count++;
            }
            return 0;
        }
        public void InsertNodeAfterParticularNode(T data, T dataToSearch)
        {
            int position = Search(dataToSearch);
            if (position == 0)
            {
                Console.WriteLine("No such element found");
                return;
            }
            Node<T> node = new Node<T>(data);
            Node<T> temp = this.head;
            for (int i = 1; i < position; i++)
            {
                temp = temp.next;
            }
            node.next = temp.next;
            temp.next = node;
            Console.WriteLine("{0} is the Added into linked list", node.data);
        }
        internal void DeleteNodeAtParticularPosition(int position)
        {
            if (this.head == null)
            {
                Console.WriteLine("LinkedList is Empty");
                return;
            }
            Node<T> temp = this.head;
            if (position == 0)
            {
                this.head = temp.next;
                return;
            }
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }
            if (temp == null || temp.next == null)
            {
                return;
            }
            Node<T> next = temp.next.next;
            temp.next = next;
        }
        internal void Size()
        {
            Node<T> temp = this.head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
            count++;
            Console.WriteLine("Length of LinkedList is :-" + " " + count);
        }
        public void AscendingOrderSort(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> temp;
            if (head == null || (head.data.CompareTo(node.data)) < 0)
            {
                node.next = head;
                head = node;
            }
            else
            {
                temp = head;
                while (temp.next != null && (temp.next.data.CompareTo(node.data)) < 0)
                {
                    temp = temp.next;
                    node.next = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("Data inserted " + node.data);
        }

        internal void Display()    // Adding method for Display
        {

            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " currently available elements in list ");
                temp = temp.next;
            }
        }
    }
}
