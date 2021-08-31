using CLIServer.Models;
using Microsoft.EntityFrameworkCore;

namespace CLIServer.Data{
    public class CLIServerContext : DbContext{
        public CLIServerContext(DbContextOptions<CLIServerContext> opt) : base(opt){}

        public DbSet<Command> Commands { get; set; }
    }
}