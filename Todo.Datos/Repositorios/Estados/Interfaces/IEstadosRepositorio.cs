using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.DtoModel.Tareas.Obtener;

namespace Todo.Datos.Repositorios.Estados.Interfaces
{
    public interface IEstadosRepositorio
    {
        public IEnumerable<TareasObtenerResponseDto> ObtenerTodos();
    }
}
