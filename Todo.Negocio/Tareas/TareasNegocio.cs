using Todo.Datos.Repositorios.Tareas.Interfaces;
using Todo.DtoModel.Tareas.Editar;
using Todo.DtoModel.Tareas.Insertar;
using Todo.DtoModel.Tareas.Obtener;
using Todo.Util;

namespace Todo.Negocio.Tareas
{
    public class TareasNegocio : ITareasNegocio
    {
        private readonly ITareasRepositorio _tareasRepositorio;

        public TareasNegocio(ITareasRepositorio tareasRepositorio)
        {
            _tareasRepositorio = tareasRepositorio;
        }

        public Response<IEnumerable<TareasObtenerResponseDto>> ObtenerTodos()
        {
            var response = new Response<IEnumerable<TareasObtenerResponseDto>> ();
            try
            {
                var tareas = _tareasRepositorio.ObtenerTodos();
                response.Data = tareas;
                response.IsSuccess = true;
                response.Message = "Consulta realizada.";
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public Response<TareasInsertarResponseDto> Insertar(TareasInsertarRequestDto tareasRequestDto)
        {
            var response = new Response<TareasInsertarResponseDto>();
            try
            {
                var tarea = _tareasRepositorio.Insertar(tareasRequestDto);
                if (tarea.IdTarea > 0)
                {
                    response.Data = tarea;
                    response.IsSuccess = true;
                    response.Message = "Registro realizado.";
                }
            }
            catch (Exception e)
            {
                //throw new Exception(e.Message);
                response.Message = e.Message;
            }
            return response;
        }

        public Response<TareasEditarDto> Editar(TareasEditarDto tareaSinEditar)
        {
            var response = new Response<TareasEditarDto>();
            try
            {
                var tareaEditada = _tareasRepositorio.Editar(tareaSinEditar);
                if (tareaEditada.Id == tareaSinEditar.Id)
                {
                    response.Data = tareaEditada;
                    response.IsSuccess = true;
                    response.Message = "Registro editado.";
                }
            }
            catch (Exception e)
            {
                //throw new Exception(e.Message);
                response.Message = e.Message;
            }
            return response;
        }

        public Response<int> Eliminar(string id)
        {
            var response = new Response<int>();
            try
            {
                var fueEliminado = _tareasRepositorio.Eliminar(Convert.ToInt32(id));
                if (fueEliminado)
                {
                    response.Data = Convert.ToInt32(id);
                    response.IsSuccess = true;
                    response.Message = "Registro eliminado.";
                }
            }
            catch (Exception e)
            {
                //throw new Exception(e.Message);
                response.Message = e.Message;
            }
            return response;
        }
    }
}
