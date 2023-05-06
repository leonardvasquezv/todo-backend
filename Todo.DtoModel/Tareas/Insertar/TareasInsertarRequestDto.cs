namespace Todo.DtoModel.Tareas.Insertar
{
    public class TareasInsertarRequestDto
    {
        public string Nombre { get; set; }
        public string Accion { get; set; }
        public string Responsable { get; set; }
        public int Duracion { get; set; }
        public int Estado { get; set; }
    }
}
