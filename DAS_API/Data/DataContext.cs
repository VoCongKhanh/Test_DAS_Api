using DAS_API.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAS_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //public DbSet<User> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobItem> JobItems { get; set; }
    }
}
