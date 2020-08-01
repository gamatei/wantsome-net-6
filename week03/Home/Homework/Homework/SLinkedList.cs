using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace Homework
{
    public class SLinkedList
    {
        public Node start;

        public void AddBeginning(SLinkedList list, int data)
        {
            Node newNode = new Node(data);
            newNode.next = list.start;
            list.start = newNode;
        }

        public void AddEnd(SLinkedList list, int data)
        {
            Node newNode = new Node(data);
            if (list.start == null)
            {
                list.start = newNode;
                return;
            }
            Node lastNode = LastNode(list);
            lastNode.next = newNode;
        }

        public Node LastNode(SLinkedList list)
        {
            Node current = list.start;
            while (current.next != null)
            {
                current = current.next;
            }

            return current;
        }                   
    }
}
