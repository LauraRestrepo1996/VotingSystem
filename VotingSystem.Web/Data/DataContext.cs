

namespace VotingSystem.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using Entities;

    public class DataContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }

}
