using API01.Models;
using API01.Respositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Mysqlx;

namespace API01.Controllers
{
    [Route("Cuenta")]
    [ApiController]
    public class CuentaController : Controller
    {
        [Route("/Cuenta/PostUsers")]
        [HttpPost]
        public IActionResult GetUsers(UsuariosModels usuario)
        {
           
            
            //UsuariosModels usuariosModels = new UsuariosModels();
            //usuariosModels.correo = correo;
            //usuariosModels.contrasena = contrasena;

            UsuariosServices usuarioServices = new UsuariosServices();

            //if (usuarioServices.GetUser(usuariosModels).Equals(true))
            //{
            //    return Json("Usuario Encontrado");
            //}
            //else
            //{
            //    return Json("Error al obtener el usuario");
            //}

            return Json("ok");
        }
    }
}
