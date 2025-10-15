using System;
using System.Xml.Linq;

namespace NodeStackssForms
{
    internal class MyStack
    {
        private Node? top;
        private int count;

        public MyStack()
        {
            top = null;
            count = 0;
        }

        public void Push(Contact value)
        {
            Node nuevo = new Node(value);
            nuevo.Next = top;
            top = nuevo;
            count++;
        }

        public Contact Pop()
        {
            if (IsEmpty())
            {

                throw new InvalidOperationException("La pila está vacía.");
            }

            Contact val = top!.Value;
            top = top.Next;
            count--;
            return val;
        }
        //
        public Contact Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("La pila está vacía.");

            return top!.Value;
        }


        public bool Contains(Contact value)
        {
            Node? current = top;

            while (current != null)
            {
                // Comparamos por ID
                if (current.Value.Id == value.Id)
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }




        public bool IsEmpty() => top == null;

        public int Count => count;

        public void Clear()
        {
            top = null;
            count = 0;
        }

        public override string ToString()
        {
            Node? current = top;
            string result = "";
            while (current != null)
            {
                result += current.ToString() + "\n";
                current = current.Next;
            }
            return result;
        }
    }
}
