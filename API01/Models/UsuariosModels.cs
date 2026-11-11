using System.ComponentModel.DataAnnotations;

namespace API01.Models
{
    public class UsuariosModels
    {
        [Required(ErrorMessage = "El correo es obligatorio")]
        public string correo { get; set; }
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        public string contrasena { get; set; }
    }
}
