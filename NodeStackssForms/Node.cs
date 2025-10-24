using System;

namespace NodeStackssForms
{
    internal class Node
    {
        private Contact value; //Almacena el dato del nodo
        private Node? prev; //Apuntador al nodo anterior

        public Contact Value
        {
            get { return value; } //obtener el valor del nodo
            set { this.value = value; } //asignar un valor al nodo
        }

        public Node? Prev
        {
            get { return prev; } // obtener el nodo anterior
            set { prev = value; } // asignar el nodo anterior
        }

        // Constructor vacío
        public Node()
        {
            // inicializar con null
            this.value = null!; 
            this.prev = null;
        }

        // Constructor con valor
        public Node(Contact value)
        {
            this.value = value; //asigna el contacto al nodo
            this.prev = null; // inicializa prev como null
        }

        // Constructor con valor y siguiente nodo
        public Node(Contact value, Node prev)
        {
            this.value = value; // asigna el contacto al nodo
            this.prev = prev; // conecta el nodo anterior
        }

        public override string ToString()
        {
            return $"ID:{value.Id}, Nombre:{value.Nombre}, Tel:{value.Telefono}";
        }
    }
}
