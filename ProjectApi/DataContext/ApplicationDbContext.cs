using Microsoft.EntityFrameworkCore;
using ProjectApi.Models;

namespace ProjectApi.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {        
        }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}
