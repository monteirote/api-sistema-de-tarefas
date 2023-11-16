using Microsoft.EntityFrameworkCore;
using sistema_de_tarefas_api.Data.Map;
using sistema_de_tarefas_api.Models;

namespace sistema_de_tarefas_api.Data;

public class SistemaTarefasDBContex : DbContext
{
    public SistemaTarefasDBContex(DbContextOptions<SistemaTarefasDBContex> options)
        : base(options)
    {
    }
    
    public DbSet<UsuarioModel> Usuarios { get; set; }
    
    public DbSet<TarefaModel> Tarefas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UsuarioMap());
        modelBuilder.ApplyConfiguration(new TarefaMap());
        
        base.OnModelCreating(modelBuilder);
    }
} 