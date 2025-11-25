using Gestión_Dual_de_Tareas.Tarea;

internal class Program
{
    private static void Main(string[] args)
    {
        DequeTareas deque = new DequeTareas();

        // Insertar 8 tareas (mezcladas)
        Agregar(deque, "Revisión del servidor", "Alta", 20);
        Agregar(deque, "Enviar correos", "Normal", 10);
        Agregar(deque, "Actualizar base de datos", "Alta", 30);
        Agregar(deque, "Imprimir reportes", "Normal", 5);
        Agregar(deque, "Atender incidente crítico", "Alta", 15);
        Agregar(deque, "Organizar escritorio", "Normal", 3);
        Agregar(deque, "Respaldo del sistema", "Normal", 25);
        Agregar(deque, "Revisión de seguridad", "Alta", 40);

        Console.WriteLine("\n>>> Después de insertar las 8 tareas:");
        deque.Print();

        // Atender 3 tareas (DeleteFront)
        Console.WriteLine("\n>>> Atendiendo 3 tareas:\n");

        for (int i = 1; i <= 3; i++)
        {
            var atendida = deque.DeleteFront();
            Console.WriteLine($"Atendida #{i}: {atendida}");
            deque.Print();
        }
    }

    static void Agregar(DequeTareas d, string desc, string prioridad, int tiempo)
    {
        Tarea t = new Tarea(desc, prioridad, tiempo);

        if (prioridad == "Alta")
            d.InsertFront(t);
        else
            d.InsertRear(t);

    }
}