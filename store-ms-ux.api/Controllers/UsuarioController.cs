
using Microsoft.AspNetCore.Mvc;
using store_ms_ux.domain.entities;
using store_mx_us.application.interfaces.repositories;
using store_mx_ux.domain.DTOs.Usuario;

namespace store_ms_ux.api.Controllers
{
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuario _usuarioRepository;

        public UsuarioController(IUsuario usuarioRepository)
        {
            _usuarioRepository = usuarioRepository ?? throw new ArgumentNullException(nameof(usuarioRepository));
        }
        [HttpGet]
        [Route("store/lista-usuarios")]
        public async Task<List<UsuarioDBContext>> ListaUsuario()
        {
            try
            {
                var response = await _usuarioRepository.ListaUsuario();
                return (response);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [HttpGet]
        [Route("store/login")]
        //public async Task<ActionResult> LoginUsuario(CredencialesUsuarioDTO credencialesUsuario )
        //{
        //    var response = await 
        //}
        [HttpPost]
        [Route("store/agregar-usuario")]
        public async Task<ActionResult> CrearUsuario([FromBody] CrearUsuarioDTO usuario) 
        {
            var response = await _usuarioRepository.CrearUsuario(usuario);
            return Ok(response);
        }
    }
}
