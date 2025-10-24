using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeStackssForms
{
    public class Contact
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public Contact(int id, string nombre, string telefono)
        {
            Id = id; // asigna el id
            Nombre = nombre; // asigna el nombre
            Telefono = telefono; // asigna el telefono
        }

        public override string ToString()
        {
            return $"{Id} - {Nombre} - {Telefono}";
        }


        
    }

}

