using Commander.models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt ) : base(opt)
        {
          
        }
          public DbSet<Command> Command { get; set; }
    }
}