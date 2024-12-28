using System.ComponentModel.DataAnnotations;

namespace CrudWebApp.Models
{
    public class Persona
    {
        [Key]// Clave primaria de la tabla persona.
        [Display(Name = "Id de la persona")]// Nombre que se mostrara en la vista.
        public int Id { get; set; }

        [StringLength(50)]// Longitud de la cadena.
        [DataType(DataType.Text)]// Tipo de dato.
        [Display(Name = "Nombre de la persona")]// Nombre que se mostrara en la vista.
        [Required(ErrorMessage = "El nombre de la persona es requerido.")]// Campo requerido.
        public string? PrimerNombre { get; set; }

        [StringLength(50)]// Longitud de la cadena.
        [DataType(DataType.Text)]// Tipo de dato.
        [Required(ErrorMessage = "El apellido de la persona es requerido.")]// Campo requerido.
        [Display(Name = "Apellido de la persona")]// Nombre que se mostrara en la vista.
        public string? Apellido { get; set; }

        [DataType(DataType.PhoneNumber)]// Tipo de dato.
        [Phone]
        [StringLength(50)]// Longitud de la cadena.
        public string? Telefono { get; set; }

        [DataType(DataType.EmailAddress)]// Tipo de dato.
        [EmailAddress]
        [StringLength(50)]// Longitud de la cadena.
        public string? Email { get; set; }

        [DataType(DataType.Date)]// Tipo de dato.

        public int Edad { get; set; }





    }
}
