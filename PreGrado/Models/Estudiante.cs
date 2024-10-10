using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PreGrado.Models
{
    //[Table("Estudiante")] // opcional cuando el nombre de archivo y nombre de tabla es la misma
    [Table(name: "Estudiante", Schema = "pregrado")]
    public class Estudiante
    {
        [Key]
        [Required]
        public int Matricula { get; set; }
        [Required]
        [MaxLength(100)]
        public int Nombre { get; set; }
        [Required]
        [MaxLength(100)]
        public int Apellido { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int? CarreraID { get; set; }
        [Required]
        [MaxLength(250)]
        public string Password { get; set; }
        [Required]
        [MaxLength(250)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
