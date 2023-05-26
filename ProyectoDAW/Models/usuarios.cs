using System.ComponentModel.DataAnnotations;

namespace ProyectoDAW.Models
{
    public class usuarios
    {
        [Key]
        public int usuarioID { get; set; }
        public string? nombre { get; set; }
        public string? apellido { get; set; }
        public string? correo { get; set; }
        public string? telefono { get; set; }
        public string? pais { get; set; }
        public string? direccion { get; set; }
        public string? contrasena { get; set; }
        public string? empresaID { get; set; }

    }
}
