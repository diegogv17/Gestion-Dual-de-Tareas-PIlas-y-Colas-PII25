using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_Dual_de_Tareas.Tarea
{
    public class Nodo
    {
        public Tarea Valor { get; set; }
        public Nodo Anterior { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(Tarea valor)
        {
            Valor = valor;
        }
    }

    public class DequeTareas
    {
        private Nodo frente;
        private Nodo final;
        public int Count { get; private set; }

        // Insertar al frente (prioridad alta)
        public void InsertFront(Tarea tarea)
        {
            Nodo nuevo = new Nodo(tarea);

            if (frente == null)
            {
                frente = nuevo;
                final = nuevo;
            }
            else
            {
                nuevo.Siguiente = frente;
                frente.Anterior = nuevo;
                frente = nuevo;
            }

            Count++;
        }

        // Insertar al final (prioridad normal)
        public void InsertRear(Tarea tarea)
        {
            Nodo nuevo = new Nodo(tarea);

            if (final == null)
            {
                frente = nuevo;
                final = nuevo;
            }
            else
            {
                final.Siguiente = nuevo;
                nuevo.Anterior = final;
                final = nuevo;
            }

            Count++;
        }

        // Atender del frente
        public Tarea DeleteFront()
        {
            if (frente == null)
                return null;

            Tarea valor = frente.Valor;
            frente = frente.Siguiente;

            if (frente != null)
                frente.Anterior = null;
            else
                final = null;

            Count--;
            return valor;
        }

        // Mostrar estado actual
        public void Print()
        {
            Console.WriteLine("\nEstado actual del deque:");
            Nodo temp = frente;

            if (temp == null)
            {
                Console.WriteLine("(vacío)");
                return;
            }

            while (temp != null)
            {
                Console.WriteLine(" - " + temp.Valor);
                temp = temp.Siguiente;
            }
        }
    }

}
