using System;
using System.Threading;
using System.Transactions;

namespace Data_Structures {
    public class LinkedListNode {
        public string Data;
        public LinkedListNode Next;
       


        public LinkedListNode(string data, LinkedListNode next) {
            this.Data = data;
            this.Next = null;
        }
    }

    public class LinkedList {
        public LinkedListNode Head;

        public LinkedList() {
            Head = null;
        }

        public void AddToEnd(string newData) {

            if (Head == null) {
                Head = new LinkedListNode(newData, null);
                return;
            } 
            
            LinkedListNode current = Head;

            while (current.Next != null) {
                current = current.Next;
            }
            current.Next = new LinkedListNode(newData, null);

        }
        
        public LinkedListNode GetNodeAt(int index) {
            int count = 0;

            if (index < 0) {
                return null;
            }
            
            LinkedListNode current = Head;
            while (count < index) {
                if (current.Next != null) {
                    current = current.Next;
                } else {
                    return null;
                }
                count++;
            }

            return current;
        }

        public bool Find(string searchTerm) {
            LinkedListNode current = Head;

            while (current != null) {
                if (current.Data == searchTerm) {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        /// <summary>
        /// Returns the number of nodes in the Linked List
        /// </summary>
        /// <returns>int: count</returns>
        public int Count() {

            var count = 0;
            var current = Head;

            while (current != null)
            {
                current = current.Next;
                count++;
            }

            return count;
        }

        /// <summary>
        /// Adds a node to the start of the list.
        /// </summary>
        /// <param name="data"></param>
        /// <returns>success: true</returns>
        public bool AddToStart(string data) {

            var newNode = new LinkedListNode(data, null);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                var current = Head;
                Head = newNode;
                newNode.Next = current;

            }
            return true;
        }

        public bool AddNodeAt(string data, int index) {
            
            int currentIndex = 0;
            var currentNode = Head;
            var newNode = new LinkedListNode(data, null);

            if (index >= 0)
            {
                while (currentNode != null && currentIndex <= index)
                {
                    if (currentIndex == index - 1)
                    {
                        var tempNode = currentNode.Next;

                        currentNode.Next = newNode;

                        newNode.Next = tempNode;

                    }
                    currentIndex++;
                    currentNode = currentNode.Next;
                }
                
            }

            return true;
            
        }

        public bool DeleteNodeAt(int index) {
            int currentIndex = 0;
            var currentNode = Head;

            if (index >= 0)
            {
                while (currentNode != null && currentIndex <= index)
                {
                    if (currentIndex == index - 1)
                    {
                        currentNode.Next = currentNode.Next.Next;
                    }
                    currentIndex++;
                    currentNode = currentNode.Next;
                }
            }
            return true;
        }

    }
}