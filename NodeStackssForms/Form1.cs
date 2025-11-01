using System;
using System.Windows.Forms;

namespace NodeStackssForms

{
    public partial class Form1 : Form
    {
        private MyStack pila;

        public Form1()
        {
            InitializeComponent();
            pila = new MyStack();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Por favor, introduce un ID.");
                return;
            }

            int id = int.Parse(txtId.Text);
            string nombre = txtNombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            Contact n = new Contact(id, nombre, telefono);
            pila.Push(n);

            txtId.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtId.Focus();

            MostrarPila();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (pila.IsEmpty())
            {
                MessageBox.Show("La pila está vacía.");
                return;
            }

            Contact eliminado = pila.Pop();
            MessageBox.Show("Contacto eliminado:\n" + eliminado.ToString());
            MostrarPila();
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (pila.IsEmpty())
            {
                MessageBox.Show("La pila está vacía.");
                return;
            }

            MessageBox.Show("Elemento en la cima:\n" + pila.Peek().ToString());
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int total = pila.Count();
            MessageBox.Show("Elementos en la pila: " + total);
        }

        private void MostrarPila()
        {
            txtContent.Clear();
            MyStack temp = new MyStack();

            while (!pila.IsEmpty())
            {
                Contact c = pila.Pop();
                txtContent.AppendText(c.ToString() + Environment.NewLine);
                temp.Push(c);
            }

            while (!temp.IsEmpty())
            {
                pila.Push(temp.Pop());
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números y tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // bloquea el carácter
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // bloquea cualquier otro carácter
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // bloquea el carácter
            }
        }

        private void txtContains_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                MessageBox.Show("Por favor, introduce un ID para buscar.");
                txtBuscar.Focus();
                return;
                
            }
            txtBuscar.Focus();

            if (!int.TryParse(txtBuscar.Text, out int idBuscado))
            {
                MessageBox.Show("El ID debe ser un número válido.");
                return;
            }

            // Creamos un contacto temporal solo con el ID
            Contact contactoBuscado = new Contact(idBuscado, "", "");

            // Verificamos si la pila contiene ese contacto
            if (pila.Contains(contactoBuscado))
            {
                MessageBox.Show($" El contacto con ID {idBuscado}  SI existe en la pila.");
            }
            else
            {
                MessageBox.Show($" El contacto con ID {idBuscado} NO existe en la pila.");
                txtBuscar.Clear();
            }
            txtBuscar.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            if (pila.IsEmpty())
            {
                MessageBox.Show("La pila esta vacía, no hay elementos para vaciar.");
                txtId.Focus();  
            }
            else
            {
                pila.Clear();
                MostrarPila();
                MessageBox.Show("La pila ha sido vaciada.");
                txtId.Focus();
            }

               
        }
    }
}
