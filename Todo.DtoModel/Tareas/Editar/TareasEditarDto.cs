namespace Todo.DtoModel.Tareas.Editar
{
    public class TareasEditarDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Accion { get; set; }
        public string Responsable { get; set; }
        public int Duracion { get; set; }
        public int Estado { get; set; }
    }
}
