namespace Todo.Entidades
{
    public class Tarea
    {
        public int IdTarea { get; set; }
        public string Nombre { get; set; }
        public string Accion { get; set; }
        public string Responsable { get; set; }
        public int Duracion { get; set; }
        public int FK_Estado { get; set; }
    }
}
