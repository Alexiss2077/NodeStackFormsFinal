using System;
using System.Xml.Linq;

namespace NodeStackssForms
{
    internal class MyStack
    {
        private Node? top; // Apuntador al nodo superior de la pila
        private int t; // Contador de elementos en la pila

        public MyStack()
        {
            top = null; // inicializa la pila vacía
            t = 0; // inicializa el contador en 0
        }

        // AGREGAR UN ELEMENTO A LA PILA
        public void Push(Contact value)
        {
            Node n = new Node(value); // crea un nuevo nodo
            n.Prev = top; // conecta con el nodo anterior
            top = n; // actualiza el tope de la pila
            t++; // incrementa el contador
        }

        // ELIMINAR Y DEVUELVE EL ELEMENTO SUPERIOR DE LA PILA
        public Contact Pop()
        {
            // Verifica si la pila está vacía
            if (IsEmpty())
            {                
                throw new InvalidOperationException("La pila está vacía.");
            }

            Contact val = top!.Value; // guarda el valor del top
            top = top.Prev; //mueve el top al nodo anterior
            t--; // decrementa el contador
            return val; // devuelve el valor eliminado
        }

        // DEVUELVE EL ELEMENTO SUPERIOR SIN ELIMINARLO
        public Contact Peek()
        {
            // verifica si la pila está vacía
            if (IsEmpty())
                throw new InvalidOperationException("La pila está vacía.");

            // devuelve el valor del top sin eliminarlo
            return top!.Value;
        }

        // VERIFICA SI LA PILA CONTIENE UN CONTACTO ESPECÍFICO
        public bool Contains(Contact value)
        {
            Node? t = top; // empezamos desde el tope
            while (t != null)
            {
                if (t.Value.Id == value.Id) // comparación directa por Id
                    return true;

                t = t.Prev; // avanzar al nodo anterior
            }
            return false; // si no se encuentra, devolver false
        }

        // devuelve true si la pila está vacía        
        public bool IsEmpty() => top == null;

        // devuelve la cantidad de elementos en la pila
        public int Count => t;

        // ELIMINA TODOS LOS ELEMENTOS DE LA PILA
        public void Clear()
        {
            top = null; // elimina la referencia al top
            t = 0; // reinicia el contador
        }

        // representa la pila como una cadena de texto
        public override string ToString()
        {
            Node? t = top; // nodo temporal
            string result = ""; //almacena la cadena resultante
            while (t != null)
            {
                result += t.ToString() + "\n"; //añade info del nodo
                t = t.Prev; // sigue al nodo anterior
            }
            return result;
        }
    }
}
