namespace Todo.DtoModel.Tareas.Obtener
{
    public class TareasObtenerResponseDto
    {
        public int IdTarea { get; set; }
        public string Nombre { get; set; }
        public string Accion { get; set; }
        public string Responsable { get; set; }
        public int Duracion { get; set; }
        public int Estado { get; set; }
    }
}
