using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{   
    /* Hereda de Base Entity, lo que quiere decir que tendrá también 
    los campos de Base Entity además de los que le añadamos propios de User */
    public class User : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(100)]
        public string LastName { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
