using Todo.Datos.Repositorios.Estados.Interfaces;
using Todo.DtoModel.Tareas.Obtener;

namespace Todo.Datos.Repositorios.Estados.Implementacion
{
    public class EstadosRepositorio : IEstadosRepositorio
    {
        public IEnumerable<TareasObtenerResponseDto> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
