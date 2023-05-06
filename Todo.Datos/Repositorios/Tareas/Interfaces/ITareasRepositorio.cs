using Todo.DtoModel.Tareas.Editar;
using Todo.DtoModel.Tareas.Insertar;
using Todo.DtoModel.Tareas.Obtener;

namespace Todo.Datos.Repositorios.Tareas.Interfaces
{
    public interface ITareasRepositorio
    {
        public TareasInsertarResponseDto Insertar(TareasInsertarRequestDto tarea);
        public IEnumerable<TareasObtenerResponseDto> ObtenerTodos();
        public TareasEditarDto Editar(TareasEditarDto tarea);
        public bool Eliminar(int idTarea);
    }
}
