using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public class Curso : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(100)]
        public string DescriptionShort { get; set; } = string.Empty;

        [StringLength(280)]
        public string DescriptionLong { get; set; } = string.Empty;

        public string TargetAudience { get; set; } = string.Empty;

        public string Goals { get; set; } = string.Empty;

        public string Requeriments { get; set; } = string.Empty;

        [Required]
        public Levels Level { get; set; }
    }

    public enum Levels
    {
       Basic,
       Intermediated,
       Advanced
    }
}
