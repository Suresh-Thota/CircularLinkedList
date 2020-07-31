using System;
using System.Collections.Generic;
using System.Text;

namespace C_ircularLinnkedList
{
    class Demo
    {
        static void Main(String[] args)
        {
            int choice, data, x;
            CircularLinkedList list = new CircularLinkedList();
            list.CreateList();
            while (true)
            {
                Console.WriteLine("1.Display List");
                Console.WriteLine("2.Insert in Empty list");
                Console.WriteLine("3.Insert in the begining");
                Console.WriteLine("4.Insert at the end");
                Console.WriteLine("5.Insert after a node");
                Console.WriteLine("6.Delete first node");
                Console.WriteLine("7.Delerte last node");
                Console.WriteLine("8.Delete any node");
                Console.WriteLine("9.Concatinate two circularLists");
                Console.WriteLine("10.quit");

                Console.WriteLine(" enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 9)
                    break;

                switch (choice)
                {
                    case 1:
                        list.DisplayList();
                        break;
                    case 2:
                        Console.Write(" Enter the element to be inserted :");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertInEmptyList(data);
                        break;
                    case 3:
                        Console.Write(" Enter the element to be insertd :");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertInBegining(data);
                        break;
                    case 4:
                        Console.Write(" Enter the element to be insertd :");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(data);
                        break;
                    case 5:
                        Console.Write(" Enter the element to be insertd :");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("enter the element after which to insert :");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfter(data, x);
                        break;
                    case 6:
                        list.DeleteFirstNode();
                        break;
                    case 7:
                        list.DeleteLastNode();
                        break;
                    case 8:
                        Console.Write(" Enter the element to be Deleted :");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNode(data);
                        break;
                    case 9:
                        CircularLinkedList list1 = new CircularLinkedList();
                        CircularLinkedList list2 = new CircularLinkedList();
                        Console.WriteLine("Enter first List :");
                        list1.CreateList();
                        Console.WriteLine("Enter second List :");
                        list2.CreateList();

                        Console.Write(" first :");
                        list1.DisplayList();

                        Console.Write(" Second ");
                        list2.DisplayList();

                        list1.Concatenate(list2);
                        Console.Write(" first :");
                        list1.DisplayList();
                        break;

                    default:
                        Console.WriteLine(" Wrong choice");
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Exiting ");
        }
    }
}
