using System.ComponentModel.DataAnnotations;


namespace ProyectoDAW.Models
{
    public class empresa
    {
        [Key]
        public int empresaID { get; set; }
        public String? correo { get; set; }
        public string? contrasena { get; set; }
        public string? nombre { get; set; }
        public String? telefono { get; set; }
        public string? descripcion { get; set; }
    }
}
