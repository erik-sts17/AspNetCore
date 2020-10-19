using Microsoft.EntityFrameworkCore;
using ASPCORE.Models;

namespace ASPCORE.Database
{
    public class ApplicationDBContext : DbContext
    {

        DbSet<Funcionario> Funcionarios;
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options){
        }
    }
}