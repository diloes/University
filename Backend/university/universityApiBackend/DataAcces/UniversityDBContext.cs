using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.Models.DataModels;

namespace universityApiBackend.DataAcces
{   
    // Hereda de DbContext
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext (DbContextOptions<UniversityDBContext> options) : base(options){ }

        // Add DebSets ( Tables of out Data Base )
        // Creamos la tabla Users de tipo User( recordemos que hereda de BaseEntity )
        public DbSet<User>? Users { get; set; } 
    }
}
