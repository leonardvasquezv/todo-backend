using Dapper;
using System.Data;
using Todo.Datos.Contexts;
using Todo.Datos.Repositorios.Tareas.Interfaces;
using Todo.DtoModel.Tareas.Editar;
using Todo.DtoModel.Tareas.Insertar;
using Todo.DtoModel.Tareas.Obtener;

namespace Todo.Datos.Repositorios.Tareas.Implementacion
{
    public class TareasRepositorio : ITareasRepositorio
    {
        private readonly DapperContext _context;

        public TareasRepositorio(DapperContext context)
        {
            _context = context;
        }

        public IEnumerable<TareasObtenerResponseDto> ObtenerTodos()
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "ObtenerTareas";

                var result = connection.Query<TareasObtenerResponseDto>(query, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public TareasInsertarResponseDto Insertar(TareasInsertarRequestDto tarea)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "AgregarTarea";
                var parameters = new DynamicParameters();

                parameters.Add("nombre", tarea.Nombre);
                parameters.Add("accion", tarea.Accion);
                parameters.Add("responsable", tarea.Responsable);
                parameters.Add("duracion", tarea.Duracion);
                parameters.Add("estado", tarea.Estado);

                var result = connection.QuerySingle<TareasInsertarResponseDto>(query, param: parameters, commandType: CommandType.StoredProcedure);
                //var result = JsonConvert.DeserializeObject<TareasResponseDto>(id);
                return result;
            }
        }

        public TareasEditarDto Editar(TareasEditarDto tarea)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "EditarTarea";
                var parameters = new DynamicParameters();

                parameters.Add("id", tarea.Id);
                parameters.Add("nombre", tarea.Nombre);
                parameters.Add("accion", tarea.Accion);
                parameters.Add("responsable", tarea.Responsable);
                parameters.Add("duracion", tarea.Duracion);
                parameters.Add("estado", tarea.Estado);

                var result = connection.QuerySingle<TareasEditarDto>(query, param: parameters, commandType: CommandType.StoredProcedure);
                //var result = JsonConvert.DeserializeObject<TareasResponseDto>(id);
                return result;
            }
        }

        public bool Eliminar(int idTarea)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "EliminarTarea";
                var parameters = new DynamicParameters();

                parameters.Add("id", idTarea);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                //var result = JsonConvert.DeserializeObject<TareasResponseDto>(id);
                return result > 0;
            }
        }
    }
}
