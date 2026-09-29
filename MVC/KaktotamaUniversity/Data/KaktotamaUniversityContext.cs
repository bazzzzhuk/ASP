using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KaktotamaUniversity.Models;

namespace KaktotamaUniversity.Data
{
    public class KaktotamaUniversityContext : DbContext
    {
        public KaktotamaUniversityContext (DbContextOptions<KaktotamaUniversityContext> options)
            : base(options)
        {
        }

        public DbSet<KaktotamaUniversity.Models.Student> Student { get; set; } = default!;
    }
}
