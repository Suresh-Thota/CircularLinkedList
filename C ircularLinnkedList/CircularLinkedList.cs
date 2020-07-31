using System;
using System.Collections.Generic;
using System.Text;

namespace C_ircularLinnkedList
{
    class CircularLinkedList
    {
        private Node last;

        public CircularLinkedList()
        {
            last = null;
        }
        public void DisplayList()
        {
            if (last==null)
            {
                Console.WriteLine(" list is Empty\n");
                return;
            }
            Node p = last.link;
            do
            {
                Console.WriteLine(p.info + " ");
                p = p.link;
            } while (p != last.link);
            Console.WriteLine();
        }
        public void InsertInBegining(int data)
        {
            Node temp = new Node(data);
            temp.link = last.link;
            last.link = temp;
        }
        public void InsertInEmptyList(int data)
        {
            Node temp = new Node(data);
            last = temp;
            last.link = last;
        }
        public void InsertAtEnd(int data)
        {
            Node temp = new Node(data);
            temp.link = last.link;
            last.link = temp;
            last = temp;
        }
        public void CreateList()
        {
            int i, n, data;
            Console.Write("ennter the number of nodes :");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
            {
                return;
            }
            Console.Write(" Enter the Element to be Inserted :");
            data = Convert.ToInt32(Console.ReadLine());
            InsertInEmptyList(data);

            for( i = 2; i <= n; i++)
            {
                Console.WriteLine("Enter the element to be inserted :");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }
        public void InsertAfter(int data,int x)
        {
            Node p = last.link;
            do
            {
                if (p.info == x)
                    break;
                p = p.link;
            } while (p != last.link);
            if (p == last.link && p.info != x)
            {
                Console.WriteLine(x + " is not present in the circular lisgt");
            }
            else
            {
                Node temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
                if (p == last)
                    last = temp;
            }
        }
        public void DeleteFirstNode()
        {
            if (last == null)
                return;
            if (last.link == last)
            {
                last = null;
                return;
            }
            last.link = last.link.link;
        }
        public void DeleteLastNode()
        {
            if (last == null)
                return;
            if (last.link == last)
            {
                last = null;
                return;
            }
            Node p = last.link;
            while (p.link != last)
            {
                p = p.link;

            }
            p.link = last.link;
            last = p;
        }
        public void DeleteNode(int x)
        {
            if (last == null)
                return;
            if (last.link == last && last.info == x)
            {
                last = null;
                return;
            }
            if (last.link.info == x)
            {
                last.link = last.link.link;
                return;
            }
            Node p = last.link;
            while (p.link != last.link)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }
            if (p.link != last.link)
            {
                Console.Write(x + " not found in the list");
            }
            else
            {
                p.link = p.link.link;
                if (last.info == x)
                    last = p;
            }
        }
        public void Concatenate(CircularLinkedList list)
        {
            if (last == null)
            {
                last = list.last;
                return;
            }
            if (list.last == null)
                return;
            Node p = last.link;
            last.link = list.last.link;
            list.last.link = p;
            last = list.last; 
        }
    }
}
