using Todo.DtoModel.Tareas.Editar;
using Todo.DtoModel.Tareas.Insertar;
using Todo.DtoModel.Tareas.Obtener;
using Todo.Util;

namespace Todo.Negocio.Tareas
{
    public interface ITareasNegocio
    {
        Response<TareasInsertarResponseDto> Insertar(TareasInsertarRequestDto tareasRequestDto);
        Response<IEnumerable<TareasObtenerResponseDto>> ObtenerTodos();
        Response<int> Eliminar(string id);
        Response<TareasEditarDto> Editar(TareasEditarDto tareaSinEditar);
    }
}
