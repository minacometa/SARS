using Microsoft.EntityFrameworkCore;

namespace SARS.Models
{
    public class ActivityLogContext: DbContext
    {
        public ActivityLogContext(DbContextOptions<ActivityLogContext> options)
           : base(options)
        {
        }

        public DbSet<ActivityLog> ActivityLogs { get; set; } = null!;       
    }   
}
