using System;

namespace NodeStackssForms
{
    internal class Node
    {
        private Contact value;
        private Node? next;

        public Contact Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public Node? Next
        {
            get { return next; }
            set { next = value; }
        }

        // Constructor vacío
        public Node()
        {
            this.value = null!;
            this.next = null;
        }

        // Constructor con valor
        public Node(Contact value)
        {
            this.value = value;
            this.next = null;
        }

        // Constructor con valor y siguiente nodo
        public Node(Contact value, Node next)
        {
            this.value = value;
            this.next = next;
        }

        public override string ToString()
        {
            return $"ID:{value.Id}, Nombre:{value.Nombre}, Tel:{value.Telefono}";
        }
    }
}
