using EdunovaAPP.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace EdunovaAPP.Data
{
    public class EdunovaContext:DbContext
    {
        public EdunovaContext(DbContextOptions<EdunovaContext>options):base(options)
        {

        }
        public DbSet<Smjer>Smjerovi { get; set; }
    }
}
