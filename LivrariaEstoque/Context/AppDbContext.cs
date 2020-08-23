using LivrariaEstoque.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace LivrariaEstoque.Context
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }
        
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Genero> Generos { get; set; }
    }
}
