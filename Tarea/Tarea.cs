using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_Dual_de_Tareas.Tarea
{
    public class Tarea
    {
        public string Descripcion { get; set; }
        public string Prioridad { get; set; } // "Alta" o "Normal"
        public int TiempoEstimado { get; set; }

        public Tarea(string descripcion, string prioridad, int tiempo)
        {
            Descripcion = descripcion;
            Prioridad = prioridad;
            TiempoEstimado = tiempo;
        }

        public override string ToString()
        {
            return $"{Descripcion} | Prioridad: {Prioridad} | Tiempo: {TiempoEstimado} min";
        }
    }

}
