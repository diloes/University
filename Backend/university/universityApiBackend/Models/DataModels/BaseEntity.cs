// Para establecer a través de nuestro ORM una estructura 
// que indica si un campo es una clave, si es obligatorio, etc.
using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    /* 
    * Esta clase nos va a permitir establecer los requisitos o campos que queremos que
    * tengan  nuestras tablas.
    * Estos campos estarán presentes en todos los elementos de nuestra base de datos.
    */
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string UpdatedBy { get; set; } = string.Empty;
        public DateTime? UpdatedAt { get; set; }
        public string DeletedBy { get; set; } = string.Empty;
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
