

namespace VotingSystem.Web.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using VotingSystem.Web.Data.Entities;

    // using Common.Models;

    public class SeedDb
    {
        private readonly DataContext context;
       // private Random random;

        public SeedDb(DataContext context)
        {
            this.context = context;
           // this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            if (!this.context.Events.Any())
            {
                this.AddEvent("Estudia actualmente?");
                this.AddEvent("¿Tienes seguro?");
                this.AddEvent("Esta a favor del aborto?");
                await this.context.SaveChangesAsync();
            }
        }

        private void AddEvent(string name)
        {
            this.context.Events.Add(new Event
            {
                Name = name,
                StartDate = DateTime.Today,
                EndDate = DateTime.Today
               
            });
        }
    }

}
