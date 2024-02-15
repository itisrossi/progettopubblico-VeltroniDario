using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Matrix
{
    internal class DoubleLinkedList
    {
        internal DNode head;
        internal void InsertFront(DoubleLinkedList doubleLinkedList, int data)
        {
            DNode newNode = new DNode(data);
            newNode.next = doubleLinkedList.head;
            newNode.prev = null;
            if (doubleLinkedList.head != null)
            {
                doubleLinkedList.head.prev = newNode;
            }
            doubleLinkedList.head = newNode;
        }

        internal void InsertLast(DoubleLinkedList doubleLinkedList, int data)
        {
            DNode newNode = new DNode(data);
            if (doubleLinkedList.head == null)
            {
                newNode.prev = null;
                doubleLinkedList.head = newNode;
                return;
            }
            DNode lastNode = GetLastNode(doubleLinkedList);
            lastNode.next = newNode;
            newNode.prev = lastNode;
        }

        internal DNode GetLastNode(DoubleLinkedList singlyList)
        {
            DNode temp = singlyList.head;
            while (temp.next != null)
            {
               temp = temp.next;
            }
            return temp;
        }
    }
    

}

