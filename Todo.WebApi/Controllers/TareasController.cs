using Microsoft.AspNetCore.Mvc;
using Todo.DtoModel.Tareas.Editar;
using Todo.DtoModel.Tareas.Insertar;
using Todo.Negocio.Tareas;

namespace Todo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareasController : ControllerBase
    {
        private readonly ITareasNegocio _tareasNegocio;
        public TareasController(ITareasNegocio tareasApplication)
        {
            _tareasNegocio = tareasApplication;
        }

        [HttpGet("ObtenerTodos")]
        public IActionResult ObtenerTodos()
        {
            var response = _tareasNegocio.ObtenerTodos();
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPost("Insertar")]
        public IActionResult Insertar([FromBody] TareasInsertarRequestDto tareasRequestDto)
        {
            if (tareasRequestDto == null)
                return BadRequest();
            var response = _tareasNegocio.Insertar(tareasRequestDto);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPut("Editar")]
        public IActionResult Editar([FromBody] TareasEditarDto tareaSinEditar)
        {
            if (tareaSinEditar == null)
                return BadRequest();
            var response = _tareasNegocio.Editar(tareaSinEditar);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpDelete("Eliminar/{IdTarea}")]
        public IActionResult Delete(string IdTarea)
        {
            if (string.IsNullOrEmpty(IdTarea))
                return BadRequest();
            var response = _tareasNegocio.Eliminar(IdTarea);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }
    }
}
